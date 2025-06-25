using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Threading;
using RFID_Reader_Cmds;
using RFID_Reader_Com;
using System.Globalization;


namespace RFID_MoudleReader
{

    public partial class Form1 : Form
    {
        private bool bAutoSend = false;
        private int CurrentModuleType = 0; //0 92x     1 96x
        private int LoopNum_cnt = 0;
        private bool change_q_1st = true;
        private bool change_q_message = true;

        public ReceiveParser rp;

        DataTable basic_table = new DataTable();
        DataTable advanced_table = new DataTable();

        DataSet ds_basic = null;
        DataSet ds_advanced = null;

        string pc = string.Empty;
        string epc = string.Empty;
        string tid = string.Empty;
        string user = string.Empty;
        string crc = string.Empty;
        string rssi = string.Empty;
        string antno = string.Empty;

        int FailEPCNum = 0;
        int SucessEPCNum = 0;
        double errnum = 0;
        double db_errEPCNum = 0;
        double db_LoopNum_cnt = 0;
        string per = "0.000";

        private String timeFormat = "yyyy/MM/dd HH:mm:ss.ff";
        //private String timeFormat = System.Globalization.DateTimeFormatInfo.CurrentInfo.ShortDatePattern.ToString() + " HH:mm:ss.ff";

        static string[] strBuff = new String[4096];

        int rowIndex = 0;
        int initDataTableLen = 1;  //Inital the line number of Datatable

        private static int[] mixerGainTable = { 0, 3, 6, 9, 12, 15, 16 };

        private static int[] IFAmpGainTable = { 12, 18, 21, 24, 27, 30, 36, 40 };

        private static byte ReaderDeviceAddress = ConstCode.READER_DEVICEADDR_BROADCAST;//0xFF;


        public Form1()
        {
            InitializeComponent();
            setTip();
            this.cbxFHSS.SelectedIndex = 0;
            this.cbxFhssHopPeriod.SelectedIndex = 1;
            this.cbxRegion.SelectedIndex = 0;
            this.cbxChannel.SelectedIndex = 0;
            this.cbxBaudRate.SelectedIndex = 4;
            this.cbxDR.SelectedIndex = 0;
            this.cbxM.SelectedIndex = 0;
            this.cbxTRext.SelectedIndex = 1;
            this.cbxSel.SelectedIndex = 0;
            this.cbxSession.SelectedIndex = 0;
            this.cbxTarget.SelectedIndex = 0;
            this.cbxQBasic.SelectedIndex = 4;
            this.cbxQAdv.SelectedIndex = 4;
            this.cbxMemBank.SelectedIndex = 3;
            this.cbxSelTarget.SelectedIndex = 0;
            this.cbxAction.SelectedIndex = 0;
            this.cbxSelMemBank.SelectedIndex = 1;
            this.cbxPaPower.SelectedIndex = 0;
            this.cbxMode.SelectedIndex = 0;
            this.cbxIO.SelectedIndex = 0;
            this.cbxIoLevel.SelectedIndex = 0;
            this.cbxIoDircetion.SelectedIndex = 0;
            this.cbxLockKillAction.SelectedIndex = 0;
            this.cbxLockAccessAction.SelectedIndex = 0;
            this.cbxLockEPCAction.SelectedIndex = 0;
            this.cbxLockTIDAction.SelectedIndex = 0;
            this.cbxLockUserAction.SelectedIndex = 0;

            //this.cbx_ReadDemo_DeviceAddrStart.SelectedIndex = 0;
            //this.cbx_ReadDemo_DeviceAddrStop.SelectedIndex = 5;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //lblVersion.Text += AssemblyLib.AssemblyVersion;
            //get all available serial port list
            string[] ports = Sp.GetInstance().GetPortNames();
            foreach (string port in ports)
            {
                cbxPort.Items.Add(port);
            }
            if (cbxPort.Items.Count > 0)
            {
                cbxPort.SelectedIndex = 0;
                btnConn.Enabled = true;
            }
            cbxBaudRate.SelectedIndex = 4;//2018-11-08
            cbxNewBaudRate.SelectedIndex = cbxBaudRate.SelectedIndex;//2018-11-08


            int i;
            for (i = 0; i < 255; i++)
            {
                cbxDeviceAddr.Items.Add(i.ToString("D03"));
                cbxNewDeviceAddr.Items.Add(i.ToString("D03"));
            }
            i = 255;
            cbxDeviceAddr.Items.Add(i.ToString("D03") + " Broadcast");
            cbxNewDeviceAddr.Items.Add(i.ToString("D03") + " Broadcast");

            checkBox_GPO1.Checked = true;
            checkBox_GPO2.Checked = true;
            checkBox_GPO3.Checked = true;
            checkBox_GPO4.Checked = true;
            comboBox_GPO1.SelectedIndex = 0;
            comboBox_GPO2.SelectedIndex = 0;
            comboBox_GPO3.SelectedIndex = 0;
            comboBox_GPO4.SelectedIndex = 0;

            checkBox_GPI1.Checked = true;
            checkBox_GPI2.Checked = true;
            checkBox_GPI3.Checked = true;
            checkBox_GPI4.Checked = true;
            comboBox_GPI1.SelectedIndex = 0;
            comboBox_GPI2.SelectedIndex = 0;
            comboBox_GPI3.SelectedIndex = 0;
            comboBox_GPI4.SelectedIndex = 0;


            cbxDeviceAddr.SelectedIndex = 255;//Default to use Broadcast Address to conncect the Reader, if we do not know the Reader's device address.
            cbxNewDeviceAddr.SelectedIndex = 255;
            ReaderDeviceAddress = (byte)cbxDeviceAddr.SelectedIndex;
            Commands.ReaderDeviceAddr = ReaderDeviceAddress;

            rp = new ReceiveParser();
            Sp.GetInstance().ComDevice.DataReceived += new SerialDataReceivedEventHandler(rp.DataReceived);
            rp.PacketReceived += new EventHandler<StrArrEventArgs>(rp_PaketReceived);
            Sp.GetInstance().DataSent += new EventHandler<byteArrEventArgs>(ComDataSent);

            //-----------------------------------------			
            this.dgvEpcBasic.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(dgvEpcBasic_DataBindingComplete);
            this.dgv_epc2.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(dgv_epc2_DataBindingComplete);
            //ComDevice.NewLine = "/r/n";
            change_q_1st = false;

            //DataGridView
            ds_basic = new DataSet();
            ds_advanced = new DataSet();
            //dt = new DataTable();

            basic_table = BasicGetEPCHead();
            advanced_table = AdvancedGetEPCHead();
            ds_basic.Tables.Add(basic_table);
            ds_advanced.Tables.Add(advanced_table);

            DataView BasicDataViewEpc = ds_basic.Tables[0].DefaultView;
            DataView AdvancedDataViewEpc = ds_advanced.Tables[0].DefaultView;
            this.dgvEpcBasic.DataSource = BasicDataViewEpc;
            this.dgv_epc2.DataSource = AdvancedDataViewEpc;
            Basic_DGV_ColumnsWidth(this.dgvEpcBasic);
            Advanced_DGV_ColumnsWidth(this.dgv_epc2);
            btnInvtBasic.Focus();

            adjustUIcomponents("M100");

            ReadTagInital();

            byte MainVer = 0, MtypeVer = 0, MinorVer = 0;
            Commands.GetDllVersion(ref MainVer, ref MtypeVer, ref MinorVer);
            string strDllVer = MainVer.ToString("X02") + "." + MtypeVer.ToString("X02") + "." + MinorVer.ToString("X02");
            setToolStripStatusMessage1("UHF RFID Reader Demo. DLL Version: " + strDllVer, Color.Red);

            Ant_Inital();

            MatchedModeComboBox.SelectedIndex = 0;
            MatchedNumberComboBox.SelectedIndex = 0;
            COMBO_TAG_MATCHED_BYTELEN1.SelectedIndex = 0;
            COMBO_TAG_MATCHED_BYTELEN2.SelectedIndex = 0;
            COMBO_TAG_MATCHED_BYTELEN3.SelectedIndex = 0;
            COMBO_TAG_MATCHED_BYTELEN4.SelectedIndex = 0;
            COMBO_TAG_MATCHED_BYTELEN5.SelectedIndex = 0;
            ReaderWorkModeComboBox.SelectedIndex = 0;
            BeepModeComboBox.SelectedIndex = 1;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Sp.GetInstance().IsOpen())
            {
                if (bAutoSend == true)
                {
                    bAutoSend = !bAutoSend;
                    timerAutoSend.Enabled = false;
                    btnContinue.Text = "Continue";
                    tmrCheckEpc.Enabled = false;

                    Thread.Sleep(200);
                }

                if (bInventoryGoing == true)
                {
                    txtSend.Text = Commands.RFID_Q_StopRead(ReaderDeviceAddress);
                    RS232SendStopInventory(txtSend.Text); GetTxTime();
                    Thread.Sleep(100);
                    txtSend.Text = Commands.RFID_Q_StopRead(ReaderDeviceAddress);
                    RS232SendStopInventory(txtSend.Text); GetTxTime();

                    tmrCheckEpc.Enabled = false;
                    bInventoryGoing = false;

                    this.btnInvtMulti.UseVisualStyleBackColor = true; //2019-04-18
                    this.btnInvtMultiEpcTid.UseVisualStyleBackColor = true;

                }
                Sp.GetInstance().Close();
            }
        }

        //-----------------------------------------------------
        private delegate void SetTextBoxDelegate(object sender, string strtext);
        private void setTextBoxInvoke(object sender, string strtext)
        {
            if (this.txtSend.InvokeRequired)
            {
                SetTextBoxDelegate md = new SetTextBoxDelegate(this.setTextBoxInvoke);
                this.Invoke(md, new object[] { sender, strtext });
            }
            else
                ((TextBox)sender).Text = strtext;
        }

        //----------------------------------------------------
        private void ComDataSent(object sender, byteArrEventArgs e)
        {
            //txtCOMTxCnt.Text = (Convert.ToInt32(txtCOMTxCnt.Text) + e.Data.Length).ToString();
            //txtCOMTxCnt_adv.Text = txtCOMTxCnt.Text;
            string strCnt = (Convert.ToInt32(txtCOMTxCnt.Text) + e.Data.Length).ToString();
            setTextBoxInvoke(txtCOMTxCnt, strCnt);
            setTextBoxInvoke(txtCOMTxCnt_adv, strCnt);
        }

        //-----------------------------------------------------txtTxTimerInfor
        private delegate void txtSendDelegate(string strtext);
        private void set_txtSend(string strtext)
        {
            if (this.txtSend.InvokeRequired)
            {
                txtSendDelegate md = new txtSendDelegate(this.set_txtSend);
                this.Invoke(md, new object[] { strtext });
            }
            else
                this.txtSend.Text = strtext;
        }
        private delegate void txtTxTimeSendDelegate(string strtext);
        private void set_TxTimeSend(string strtext)
        {
            if (this.txtTxTimerInfor.InvokeRequired)
            {
                txtTxTimeSendDelegate md = new txtTxTimeSendDelegate(this.set_TxTimeSend);
                this.Invoke(md, new object[] { strtext });
            }
            else
                this.txtTxTimerInfor.Text = strtext;
        }

        //-------------------------------------------------
        private void GetTxTime()
        {
            //txtTxTimerInfor.Text = DateTime.Now.ToString("HH:mm:ss:fff");
            set_TxTimeSend(DateTime.Now.ToString("HH:mm:ss:fff"));
        }

        public void RS232SendStopInventory(string strCommandFrame)
        {
            if (Sp.GetInstance().IsOpen())
            {
                Sp.GetInstance().Send(txtSend.Text);
            }
            else
            {
                MessageBox.Show("The reader has not been connected!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void RS232SendCommand(string strCommandFrame)
        {
            if (Sp.GetInstance().IsOpen())
            {
                if (bAutoSend == true)
                {
                    MessageBox.Show("Please Stop Continuous Inventory", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (bInventoryGoing == true)
                {
                    MessageBox.Show("Please Stop Read Multi-Tag first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Sp.GetInstance().Send(txtSend.Text);
            }
            else
            {
                MessageBox.Show("The reader has not been connected!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private DateTime GetSysTime()  // 2021-09-07
        {
            return DateTime.Now;
        }

        private long GetSysTickMsTime()
        {
            return Environment.TickCount;   //Milliseconds			
        }

        public static string ExecDateDiff(DateTime dateBegin, DateTime dateEnd)  // 2021-09-07
        {
            TimeSpan ts1 = new TimeSpan(dateBegin.Ticks);
            TimeSpan ts2 = new TimeSpan(dateEnd.Ticks);
            TimeSpan ts3 = ts1.Subtract(ts2).Duration();
            return ts3.TotalMilliseconds.ToString();
        }

        private void tabControl1_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F9)
            {
                btn_invt_multi_Click(null, null);
            }
            else if (e.KeyCode == Keys.F10)
            {
                btn_stop_rd_Click(null, null);
            }
            else if (e.KeyCode == Keys.F11)
            {
                btn_clear_basictable_Click(null, null);
            }
        }

        private int getSuccessTagEpc(string[] packetRx)
        {
            txtOperateEpc.Text = "";
            if (packetRx.Length < 9)
            {
                return 0;
            }
            int pcEpcLen = Convert.ToInt32(packetRx[0], 16);
            for (int i = 0; i < pcEpcLen; i++)
            {
                txtOperateEpc.Text += packetRx[i + 1] + " ";
            }
            return pcEpcLen;
        }

        private void setStatus(string msg, Color color)
        {
            rtbxStatus.Text = msg;
            rtbxStatus.ForeColor = color;

            setToolStripStatusMessage1(msg, color);
        }

        private void btnClearS_Click(object sender, EventArgs e)
        {
            txtSend.Text = "";
        }

        private void btn_clear_rx_Click(object sender, EventArgs e)
        {
            txtReceive.Text = "";
        }

        private void setToolStripStatusMessage1(string msg, Color color)
        {
            toolStripStatusLabel1.Text = msg;
            toolStripStatusLabel1.ForeColor = color;
        }

        private void setToolStripStatusMessage2(string msg, Color color)
        {
            toolStripStatusLabel2.Text = msg;
            toolStripStatusLabel2.ForeColor = color;

        }

        private void setToolStripStatusMessage3(string msg, Color color)
        {
            toolStripStatusLabel3.Text = msg;
            toolStripStatusLabel3.ForeColor = color;

        }

        private void adjustUIcomponents(string hardwareVersion)
        {
            this.cbxPaPower.Items.Clear();
            for (int i = 30; i >= 0; i--)
            {
                this.cbxPaPower.Items.Add(i.ToString() + "dBm");
            }
            this.cbxPaPower.SelectedIndex = 0;
            this.cbxQBasic.SelectedIndexChanged -= new System.EventHandler(this.cbx_q_basic_SelectedIndexChanged);
            this.cbxQBasic.SelectedIndex = 5;
            this.cbxQBasic.SelectedIndexChanged += new System.EventHandler(this.cbx_q_basic_SelectedIndexChanged);
            this.cbxQAdv.SelectedIndex = 5;
            this.gbxIoControl.Visible = true;
        }

        private void setTip()
        {
            toolTip1.SetToolTip(this.label1, "Available COM Port");
            toolTip1.SetToolTip(this.txtReceive, "Double Click To Select ALL");
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            RS232SendCommand(txtSend.Text); GetTxTime();
        }

        private void saveAsTxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();

            //File type filter
            save.Filter = "*.csv|*.CSV|*.*|(*.*)";

            if (save.ShowDialog() == DialogResult.OK)
            {
                string name = save.FileName;
                FileInfo info = new FileInfo(name);
                //info.Delete();
                StreamWriter writer = null;
                try
                {
                    writer = info.CreateText();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    writer.Write("No.,PC,EPC,CRC,RSSI(dBm),CNT,PER(%),");
                    writer.WriteLine();
                    for (int i = 0; i < basic_table.Rows.Count; i++)
                    {
                        for (int j = 0; j < basic_table.Columns.Count; j++)
                        {
                            writer.Write(basic_table.Rows[i][j].ToString() + ",");
                        }
                        writer.WriteLine();
                        //writer.Write(richTextBox1.Text);
                    }
                    writer.Close();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        int lastRecCnt = 0;

        private void txtOperateEpc_DoubleClick(object sender, EventArgs e)
        {
            txtOperateEpc.SelectAll();
        }

        private void cbxPort_DropDown(object sender, EventArgs e)
        {
            string[] NamesArr = SerialPort.GetPortNames();

            this.cbxPort.Items.Clear();
            if (NamesArr.Length != 0)
            {
                foreach (var oo in NamesArr)
                {
                    this.cbxPort.Items.Add(oo);
                    btnConn.Enabled = true;
                }
                this.cbxPort.SelectedIndex = 0;
            }
        }

        //-----------------------------------------------------------------
        #region timer

        private void tmrCheckEpc_Tick(object sender, EventArgs e)
        {
            if (lastRecCnt == Convert.ToInt32(txtCOMRxCnt.Text)) // no data received during last Tick, it may mean the Read Continue stoped
            {
                tmrCheckEpc.Enabled = false;
                return;
            }
            lastRecCnt = Convert.ToInt32(txtCOMRxCnt.Text);
            DateTime now = System.DateTime.Now;
            DateTime dt;
            DateTimeFormatInfo dtFormat = new System.Globalization.DateTimeFormatInfo();

            dtFormat.LongDatePattern = timeFormat;

            int timeout = (10 * tmrCheckEpc.Interval);
            for (int i = 0; i < this.dgvEpcBasic.Rows.Count; i++)
            {
                string time = this.dgvEpcBasic.Rows[i].Cells[7].Value.ToString();
                if (null != time && !"".Equals(time))
                {
                    //dt = Convert.ToDateTime(time, dtFormat);
                    //dt = DateTime.ParseExact(time, timeFormat, CultureInfo.InvariantCulture);
                    if (DateTime.TryParse(time, out dt))
                    {
                        TimeSpan sub = now.Subtract(dt);
                        if (sub.TotalMilliseconds > timeout)
                        {
                            this.dgvEpcBasic.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        }
                        //else if ((sub.TotalMilliseconds > (tmrCheckEpc.Interval + 100)))
                        //{
                        //    this.dgvEpcBasic.Rows[i].DefaultCellStyle.BackColor = Color.Pink;
                        //}
                        else
                        {
                            int r = 0xFF & (int)(sub.TotalMilliseconds / timeout * 255);
                            //this.dgvEpcBasic.Rows[i].DefaultCellStyle.BackColor = Color.White;
                            this.dgvEpcBasic.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(0xff, 255 - r, 255 - r);

                        }
                    }

                }
            }

        }

        private void timerCheckReader_Tick(object sender, EventArgs e)
        {
            timerCheckReader.Enabled = false;
            if (hardwareVersion == "")
            {
                MessageBox.Show("Connect Reader Failed, Please Check if the Com port and the power is OK!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                readerConnected = false;
            }
            else
            {
                readerConnected = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabel3.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        }
        #endregion

        //-----------------------------------------------------------------
        #region DataGridView

        private const int _BASIC_TABLE_INDEX_NO_ = 0;
        private const int _BASIC_TABLE_INDEX_PC_ = 1;
        private const int _BASIC_TABLE_INDEX_EPC_ = 2;
        private const int _BASIC_TABLE_INDEX_TID_ = 3;
        private const int _BASIC_TABLE_INDEX_USER_ = 4;
        private const int _BASIC_TABLE_INDEX_RSSI_ = 5;
        private const int _BASIC_TABLE_INDEX_CNT_ = 6;
        private const int _BASIC_TABLE_INDEX_ANT_ = 7;
        private DataTable BasicGetEPCHead()
        {
            basic_table.TableName = "EPC";
            basic_table.Columns.Add("No.", typeof(string)); // 0
            basic_table.Columns.Add("PC", typeof(string)); // 1
            basic_table.Columns.Add("EPC", typeof(string)); // 2
            basic_table.Columns.Add("TID", typeof(string)); // 3
            basic_table.Columns.Add("USER", typeof(string)); // 4
            basic_table.Columns.Add("RSSI(dB)", typeof(string)); // 5
            basic_table.Columns.Add("CNT", typeof(string)); // 6
            basic_table.Columns.Add("ANT", typeof(string)); // 7

            for (int i = 0; i <= initDataTableLen - 1; i++)
            {
                basic_table.Rows.Add(new object[] { null });
            }
            basic_table.AcceptChanges();

            return basic_table;
        }

        private const int _ADV_TABLE_INDEX_NO_ = 0;
        private const int _ADV_TABLE_INDEX_PC_ = 1;
        private const int _ADV_TABLE_INDEX_EPC_ = 2;
        private const int _ADV_TABLE_INDEX_TID_ = 3;
        private const int _ADV_TABLE_INDEX_CNT_ = 4;
        private const int _ADV_TABLE_INDEX_ANT_ = 5;
        private DataTable AdvancedGetEPCHead()
        {
            advanced_table.TableName = "EPC";
            advanced_table.Columns.Add("No.", typeof(string)); //0
            advanced_table.Columns.Add("PC", typeof(string)); //1
            advanced_table.Columns.Add("EPC", typeof(string)); //2
            advanced_table.Columns.Add("TID", typeof(string)); //3
            advanced_table.Columns.Add("CNT", typeof(string)); //4
            advanced_table.Columns.Add("ANT", typeof(string)); //5
            for (int i = 0; i <= initDataTableLen - 1; i++)
            {
                advanced_table.Rows.Add(new object[] { null });
            }
            advanced_table.AcceptChanges();

            return advanced_table;
        }

        private void Basic_DGV_ColumnsWidth(DataGridView dataGridView1)
        {
            //dataGridView1.Columns[6].SortMode = DataGridViewColumnSortMode.Programmatic;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersHeight = 40;
            //dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Lucida Console", 10);
            dataGridView1.Columns[_BASIC_TABLE_INDEX_NO_].Width = 40;
            //dataGridView1.Columns[0].DefaultCellStyle.Font = new Font("Lucida Console", 10);
            dataGridView1.Columns[_BASIC_TABLE_INDEX_NO_].Resizable = DataGridViewTriState.False;
            dataGridView1.Columns[_BASIC_TABLE_INDEX_NO_].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns[_BASIC_TABLE_INDEX_PC_].Width = 60;
            //dataGridView1.Columns[1].DefaultCellStyle.Font = new Font("Lucida Console", 10);
            dataGridView1.Columns[_BASIC_TABLE_INDEX_PC_].Resizable = DataGridViewTriState.False;
            dataGridView1.Columns[_BASIC_TABLE_INDEX_PC_].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns[_BASIC_TABLE_INDEX_EPC_].Width = 280;
            //dataGridView1.Columns[_BASIC_TABLE_INDEX_EPC_].DefaultCellStyle.Font = new Font("Lucida Console", 10);
            dataGridView1.Columns[_BASIC_TABLE_INDEX_EPC_].Resizable = DataGridViewTriState.False;
            dataGridView1.Columns[_BASIC_TABLE_INDEX_EPC_].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns[_BASIC_TABLE_INDEX_TID_].Width = 200;
            //dataGridView1.Columns[_BASIC_TABLE_INDEX_TID_].DefaultCellStyle.Font = new Font("Lucida Console", 10);
            dataGridView1.Columns[_BASIC_TABLE_INDEX_TID_].Resizable = DataGridViewTriState.False;
            dataGridView1.Columns[_BASIC_TABLE_INDEX_TID_].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns[_BASIC_TABLE_INDEX_USER_].Width = 200;
            //dataGridView1.Columns[_BASIC_TABLE_INDEX_USER_].DefaultCellStyle.Font = new Font("Lucida Console", 10);
            dataGridView1.Columns[_BASIC_TABLE_INDEX_USER_].Resizable = DataGridViewTriState.False;
            dataGridView1.Columns[_BASIC_TABLE_INDEX_USER_].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns[_BASIC_TABLE_INDEX_RSSI_].Width = 50;
            //dataGridView1.Columns[_BASIC_TABLE_INDEX_RSSI_].DefaultCellStyle.Font = new Font("Lucida Console", 10);
            dataGridView1.Columns[_BASIC_TABLE_INDEX_RSSI_].Resizable = DataGridViewTriState.False;
            dataGridView1.Columns[_BASIC_TABLE_INDEX_RSSI_].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns[_BASIC_TABLE_INDEX_CNT_].Width = 70;
            //dataGridView1.Columns[_BASIC_TABLE_INDEX_CNT_].DefaultCellStyle.Font = new Font("Lucida Console", 10);
            dataGridView1.Columns[_BASIC_TABLE_INDEX_CNT_].Resizable = DataGridViewTriState.False;
            dataGridView1.Columns[_BASIC_TABLE_INDEX_CNT_].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns[_BASIC_TABLE_INDEX_ANT_].Width = 50;
            //dataGridView1.Columns[_BASIC_TABLE_INDEX_ANT_].DefaultCellStyle.Font = new Font("Lucida Console", 10);
            dataGridView1.Columns[_BASIC_TABLE_INDEX_ANT_].Resizable = DataGridViewTriState.False;
            dataGridView1.Columns[_BASIC_TABLE_INDEX_ANT_].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void Advanced_DGV_ColumnsWidth(DataGridView dataGridView1)
        {
            //dataGridView1.Columns[6].SortMode = DataGridViewColumnSortMode.Programmatic;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersHeight = 40;
            //dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Lucida Console", 10);
            dataGridView1.Columns[_ADV_TABLE_INDEX_NO_].Width = 40;
            //dataGridView1.Columns[_ADV_TABLE_INDEX_NO_].DefaultCellStyle.Font = new Font("Lucida Console", 10);
            dataGridView1.Columns[_ADV_TABLE_INDEX_NO_].Resizable = DataGridViewTriState.False;
            dataGridView1.Columns[_ADV_TABLE_INDEX_NO_].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns[_ADV_TABLE_INDEX_PC_].Width = 60;
            //dataGridView1.Columns[_ADV_TABLE_INDEX_PC_].DefaultCellStyle.Font = new Font("Lucida Console", 10);
            dataGridView1.Columns[_ADV_TABLE_INDEX_PC_].Resizable = DataGridViewTriState.False;
            dataGridView1.Columns[_ADV_TABLE_INDEX_PC_].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns[_ADV_TABLE_INDEX_EPC_].Width = 300;
            //dataGridView1.Columns[_ADV_TABLE_INDEX_EPC_].DefaultCellStyle.Font = new Font("Lucida Console", 10);
            dataGridView1.Columns[_ADV_TABLE_INDEX_EPC_].Resizable = DataGridViewTriState.False;
            dataGridView1.Columns[_ADV_TABLE_INDEX_EPC_].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns[_ADV_TABLE_INDEX_TID_].Width = 200;
            //dataGridView1.Columns[_ADV_TABLE_INDEX_TID_].DefaultCellStyle.Font = new Font("Lucida Console", 10);
            dataGridView1.Columns[_ADV_TABLE_INDEX_TID_].Resizable = DataGridViewTriState.False;
            dataGridView1.Columns[_ADV_TABLE_INDEX_TID_].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns[_ADV_TABLE_INDEX_CNT_].Width = 70;
            //dataGridView1.Columns[_ADV_TABLE_INDEX_CNT_].DefaultCellStyle.Font = new Font("Lucida Console", 10);
            dataGridView1.Columns[_ADV_TABLE_INDEX_CNT_].Resizable = DataGridViewTriState.False;
            dataGridView1.Columns[_ADV_TABLE_INDEX_CNT_].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns[_ADV_TABLE_INDEX_ANT_].Width = 40;
            //dataGridView1.Columns[_ADV_TABLE_INDEX_ANT_].DefaultCellStyle.Font = new Font("Lucida Console", 10);
            dataGridView1.Columns[_ADV_TABLE_INDEX_ANT_].Resizable = DataGridViewTriState.False;
            dataGridView1.Columns[_ADV_TABLE_INDEX_ANT_].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void GetEPC(string pc, string epc, string tid, string user, string rssi, string antno)
        {
            this.dgv_epc2.ClearSelection();
            bool isFoundEpc = false;
            string newEpcItemCnt;
            int indexEpc = 0;

            int EpcItemCnt;

            uint EpcTagCounter = Convert.ToUInt32(textBox_EPC_TagCounter.Text);
            EpcTagCounter++;
            textBox_EPC_TagCounter.Text = EpcTagCounter.ToString();

            if (rowIndex <= initDataTableLen)
            {
                EpcItemCnt = rowIndex;
            }
            else
            {
                EpcItemCnt = basic_table.Rows.Count;
                EpcItemCnt = advanced_table.Rows.Count;
            }

            for (int j = 0; j < EpcItemCnt; j++)
            {
                if (basic_table.Rows[j][1].ToString() == pc
                    && basic_table.Rows[j][2].ToString() == epc
                    && basic_table.Rows[j][3].ToString() == tid
                    && basic_table.Rows[j][4].ToString() == user
                    )
                {
                    indexEpc = j;
                    isFoundEpc = true;
                    break;
                }
            }

            if (EpcItemCnt < initDataTableLen)
            {
                if (!isFoundEpc || EpcItemCnt == 0)
                {
                    if (EpcItemCnt + 1 < 10)
                    {
                        newEpcItemCnt = "0" + Convert.ToString(EpcItemCnt + 1);
                    }
                    else
                    {
                        newEpcItemCnt = Convert.ToString(EpcItemCnt + 1);
                    }
                    try
                    {
                        basic_table.Rows[EpcItemCnt][_BASIC_TABLE_INDEX_NO_] = newEpcItemCnt; // EpcItemCnt + 1;
                        basic_table.Rows[EpcItemCnt][_BASIC_TABLE_INDEX_PC_] = pc;
                        basic_table.Rows[EpcItemCnt][_BASIC_TABLE_INDEX_EPC_] = epc;
                        basic_table.Rows[EpcItemCnt][_BASIC_TABLE_INDEX_TID_] = tid;
                        basic_table.Rows[EpcItemCnt][_BASIC_TABLE_INDEX_USER_] = user;
                        basic_table.Rows[EpcItemCnt][_BASIC_TABLE_INDEX_RSSI_] = rssi;
                        basic_table.Rows[EpcItemCnt][_BASIC_TABLE_INDEX_CNT_] = 1;
                        basic_table.Rows[EpcItemCnt][_BASIC_TABLE_INDEX_ANT_] = antno;//System.DateTime.Now.ToString(timeFormat);

                        advanced_table.Rows[EpcItemCnt][_ADV_TABLE_INDEX_NO_] = newEpcItemCnt; // EpcItemCnt + 1;
                        advanced_table.Rows[EpcItemCnt][_ADV_TABLE_INDEX_PC_] = pc;
                        advanced_table.Rows[EpcItemCnt][_ADV_TABLE_INDEX_EPC_] = epc;
                        advanced_table.Rows[EpcItemCnt][_ADV_TABLE_INDEX_TID_] = tid;
                        advanced_table.Rows[EpcItemCnt][_ADV_TABLE_INDEX_CNT_] = 1;
                        advanced_table.Rows[EpcItemCnt][_ADV_TABLE_INDEX_ANT_] = antno;

                        rowIndex++;
                    }
                    catch (System.Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    textBox_EPC_Tag_Total.Text = newEpcItemCnt;
                    GetInventoryTagNumberTimer();//2021-09-07
                }
                else
                {
                    if (indexEpc + 1 < 10)
                    {
                        newEpcItemCnt = "0" + Convert.ToString(indexEpc + 1);
                    }
                    else
                    {
                        newEpcItemCnt = Convert.ToString(indexEpc + 1);
                    }
                    try
                    {
                        basic_table.Rows[indexEpc][_BASIC_TABLE_INDEX_NO_] = newEpcItemCnt; // indexEpc + 1;
                        basic_table.Rows[indexEpc][_BASIC_TABLE_INDEX_RSSI_] = rssi;
                        basic_table.Rows[indexEpc][_BASIC_TABLE_INDEX_CNT_] = Convert.ToInt32(basic_table.Rows[indexEpc][_BASIC_TABLE_INDEX_CNT_].ToString()) + 1;
                        basic_table.Rows[indexEpc][_BASIC_TABLE_INDEX_ANT_] = antno;//System.DateTime.Now.ToString(timeFormat);

                        advanced_table.Rows[indexEpc][_ADV_TABLE_INDEX_NO_] = newEpcItemCnt; // indexEpc + 1;
                        advanced_table.Rows[indexEpc][_ADV_TABLE_INDEX_CNT_] = Convert.ToInt32(advanced_table.Rows[indexEpc][_ADV_TABLE_INDEX_CNT_].ToString()) + 1;
                        advanced_table.Rows[indexEpc][_ADV_TABLE_INDEX_ANT_] = antno;//Convert.ToInt32(advanced_table.Rows[indexEpc][_ADV_TABLE_INDEX_ANT_].ToString()) + 1;
                    }
                    catch (System.Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            else
            {
                if (!isFoundEpc || EpcItemCnt == 0)
                {
                    if (EpcItemCnt + 1 < 10)
                    {
                        newEpcItemCnt = "0" + Convert.ToString(EpcItemCnt + 1);
                    }
                    else
                    {
                        newEpcItemCnt = Convert.ToString(EpcItemCnt + 1);
                    }
                    basic_table.Rows.Add(new object[] { newEpcItemCnt, pc, epc, tid, user, rssi, "1", antno });
                    advanced_table.Rows.Add(new object[] { newEpcItemCnt, pc, epc, tid, "1", antno });
                    rowIndex++;

                    textBox_EPC_Tag_Total.Text = newEpcItemCnt;
                    GetInventoryTagNumberTimer();//2021-09-07
                }
                else
                {
                    if (indexEpc + 1 < 10)
                    {
                        newEpcItemCnt = "0" + Convert.ToString(indexEpc + 1);
                    }
                    else
                    {
                        newEpcItemCnt = Convert.ToString(indexEpc + 1);
                    }
                    try
                    {
                        basic_table.Rows[indexEpc][_BASIC_TABLE_INDEX_NO_] = newEpcItemCnt; // indexEpc + 1;
                        basic_table.Rows[indexEpc][_BASIC_TABLE_INDEX_RSSI_] = rssi;
                        basic_table.Rows[indexEpc][_BASIC_TABLE_INDEX_CNT_] = Convert.ToInt32(basic_table.Rows[indexEpc][_BASIC_TABLE_INDEX_CNT_].ToString()) + 1;
                        basic_table.Rows[indexEpc][_BASIC_TABLE_INDEX_ANT_] = antno;//System.DateTime.Now.ToString(timeFormat);

                        advanced_table.Rows[indexEpc][_ADV_TABLE_INDEX_NO_] = newEpcItemCnt; // indexEpc + 1;
                        advanced_table.Rows[indexEpc][_ADV_TABLE_INDEX_CNT_] = Convert.ToInt32(advanced_table.Rows[indexEpc][_ADV_TABLE_INDEX_CNT_].ToString()) + 1;
                        advanced_table.Rows[indexEpc][_ADV_TABLE_INDEX_ANT_] = antno; //Convert.ToInt32(advanced_table.Rows[indexEpc][_ADV_TABLE_INDEX_ANT_].ToString()) + 1;
                    }
                    catch (System.Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }

        private void dgvEpcBasic_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgvEpcBasic.ClearSelection();
        }

        private void dgv_epc2_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //if (e.ListChangedType == ListChangedType.ItemChanged || e.ListChangedType == ListChangedType.ItemAdded)
            {
                for (int i = 0; i < this.dgv_epc2.Rows.Count; i++)
                {
                    if (i % 2 == 0)
                    {
                        this.dgv_epc2.Rows[i].DefaultCellStyle.BackColor = Color.AliceBlue;
                    }
                }
            }
        }

        public void dataGrid_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            int rowIndex = dgv_epc2.CurrentRow.Index;
            if (dgv_epc2.Rows[rowIndex].Cells[2].Value.ToString() != null)
            {
                txtSelMask.Text = dgv_epc2.Rows[rowIndex].Cells[2].Value.ToString();
            }
            txtSelLength.Text = (txtSelMask.Text.Replace(" ", "").Length * 4).ToString("X2");
        }


        private void btn_clear_basictable_Click(object sender, EventArgs e)
        {
            basic_table.Clear();
            advanced_table.Clear();
            LoopNum_cnt = 0;
            FailEPCNum = 0;
            SucessEPCNum = 0;
            db_LoopNum_cnt = 0;
            for (int i = 0; i <= initDataTableLen - 1; i++)
            {
                basic_table.Rows.Add(new object[] { null });
            }
            basic_table.AcceptChanges();
            for (int i = 0; i <= initDataTableLen - 1; i++)
            {
                advanced_table.Rows.Add(new object[] { null });
            }
            advanced_table.AcceptChanges();
            rowIndex = 0;
            textBox_EPC_TagCounter.Text = "0";
            textBox_EPC_Tag_Total.Text = "0";
            txt_TagNumberToTimeValue.Text = "0";
        }

        private void btn_clear_epc2_Click(object sender, EventArgs e)
        {
            txtReceive.Text = "";
            basic_table.Clear();
            advanced_table.Clear();
            LoopNum_cnt = 0;
            FailEPCNum = 0;
            SucessEPCNum = 0;
            db_LoopNum_cnt = 0;
            for (int i = 0; i <= initDataTableLen - 1; i++)
            {
                basic_table.Rows.Add(new object[] { null });
            }
            basic_table.AcceptChanges();
            for (int i = 0; i <= initDataTableLen - 1; i++)
            {
                advanced_table.Rows.Add(new object[] { null });
            }
            advanced_table.AcceptChanges();
            rowIndex = 0;

        }



        #endregion


        //-----------------------------------------------------------------
        #region others

        private void btn_clear_cnt_Click(object sender, EventArgs e)
        {
            txtCOMRxCnt.Text = "0";
            txtCOMTxCnt.Text = "0";
            txtCOMRxCnt_adv.Text = "0";
            txtCOMTxCnt_adv.Text = "0";
        }

        private void btn_clear_cnt_adv_Click(object sender, EventArgs e)
        {
            txtCOMRxCnt.Text = "0";
            txtCOMTxCnt.Text = "0";
            txtCOMRxCnt_adv.Text = "0";
            txtCOMTxCnt_adv.Text = "0";
        }

        private string[] String16toString2(string S)
        {
            string[] S_array = new string[8];
            int intS = Convert.ToInt32(S, 16);
            for (int i = 7; i >= 0; i--)
            {
                S_array[i] = "0";
                if (intS >= System.Math.Pow(2, i)) S_array[i] = "1";
                intS = intS - Convert.ToInt32(S_array[i]) * Convert.ToInt32(System.Math.Pow(2, i));
            }
            return S_array;
        }

        private string StringToString(string S)
        {
            string Str = null;

            int S_num = Convert.ToInt32(S, 16);
            if (S_num < 16)
            {
                Str = "0" + S;
            }
            else
            {
                Str = S;
            }
            return Str;
        }

        private string[] StringArrayToStringArray(string[] S)
        {
            string[] Str = new string[S.Length];
            for (int i = 0; i < S.Length; i++)
            {
                int S_num = Convert.ToInt32(S[i], 16);
                if (S_num < 16)
                {
                    Str[i] = "0" + S[i];
                }
                else
                {
                    Str[i] = S[i];
                }
            }
            return Str;
        }

        private byte[] StringsToBytes(string[] B)
        {
            byte[] BToInt32 = new byte[B.Length];
            for (int i = 0; i < B.Length; i++)
            {
                BToInt32[i] = StringToByte(B[i]);
            }
            return BToInt32;
        }

        private byte StringToByte(string Str)
        {
            for (int i = Str.Length; i < 2; i++)
            {
                Str += "0";
            }
            return (byte)(Convert.ToInt32(Str, 16));
        }

        private string AutoAddSpace(string Str)
        {
            String StrDone = string.Empty;
            int i;
            for (i = 0; i < (Str.Length - 2); i = i + 2)
            {
                StrDone = StrDone + Str[i] + Str[i + 1] + " ";
            }
            if (Str.Length % 2 == 0 && Str.Length != 0)
            {
                if (Str.Length == i + 1)
                {
                    StrDone = StrDone + Str[i];
                }
                else
                {
                    StrDone = StrDone + Str[i] + Str[i + 1];
                }
            }
            else
            {
                StrDone = StrDone + StringToString(Str[i].ToString());
            }
            return StrDone;
        }

        private void txtReceive_DoubleClick(object sender, EventArgs e)
        {
            txtReceive.SelectAll();
        }

        private void txtSelMask_DoubleClick(object sender, EventArgs e)
        {
            txtSelMask.SelectAll();
        }

        private void txtSend_DoubleClick(object sender, EventArgs e)
        {
            txtSend.SelectAll();
        }


        private void txtInvtReadData_DoubleClick(object sender, EventArgs e)
        {
            txtInvtRWData.SelectAll();
        }

        private void txtGetSelMask_DoubleClick(object sender, EventArgs e)
        {
            txtGetSelMask.SelectAll();
        }
        #endregion


        //-----------------------------------------------------------------
        #region show received packet

        private void GetSelectTagParameter_ResponseMessageProcess(Commands.ReaderResponseFrameString rxStrPkts)
        {
            string infoGetSelParam = string.Empty;
            string[] strSelCombParam = String16toString2(rxStrPkts.strParameters[0]);
            string strSelTarget = strSelCombParam[7] + strSelCombParam[6] + strSelCombParam[5];
            string strSelAction = strSelCombParam[4] + strSelCombParam[3] + strSelCombParam[2];
            string strSelMemBank = strSelCombParam[1] + strSelCombParam[0];

            string strSelTargetInfo = null;
            if (strSelTarget == "000")
            {
                strSelTargetInfo = "S0";
            }
            else if (strSelTarget == "001")
            {
                strSelTargetInfo = "S1";
            }
            else if (strSelTarget == "010")
            {
                strSelTargetInfo = "S2";
            }
            else if (strSelTarget == "011")
            {
                strSelTargetInfo = "S3";
            }
            else if (strSelTarget == "100")
            {
                strSelTargetInfo = "SL";
            }
            else
            {
                strSelTargetInfo = "RFU";
            }

            string strSelMemBankInfo = null;
            if (strSelMemBank == "00")
            {
                strSelMemBankInfo = "RFU";
            }
            else if (strSelMemBank == "01")
            {
                strSelMemBankInfo = "EPC";
            }
            else if (strSelMemBank == "10")
            {
                strSelMemBankInfo = "TID";
            }
            else
            {
                strSelMemBankInfo = "User";
            }
            infoGetSelParam = "Target=" + strSelTargetInfo + ", Action=" + strSelAction + ", Memory Bank=" + strSelMemBankInfo;
            infoGetSelParam = infoGetSelParam + ", Pointer=0x" + rxStrPkts.strParameters[1] + rxStrPkts.strParameters[2] + rxStrPkts.strParameters[3] + rxStrPkts.strParameters[4];
            infoGetSelParam = infoGetSelParam + ", Length=0x" + rxStrPkts.strParameters[5];
            string strTruncate = null;
            if (rxStrPkts.strParameters[6] == "00")
            {
                strTruncate = "Disable Truncation";
            }
            else
            {
                strTruncate = "Enable Truncation";
            }
            infoGetSelParam = infoGetSelParam + ", " + strTruncate;

            this.txtGetSelLength.Text = rxStrPkts.strParameters[5];

            string strGetSelMask = null;
            int intGetSelMaskByte = Convert.ToInt32(rxStrPkts.strParameters[5], 16) / 8;
            int intGetSelMaskBit = Convert.ToInt32(rxStrPkts.strParameters[5], 16) - intGetSelMaskByte * 8;
            if (intGetSelMaskBit == 0)
            {
                for (int i = 0; i < intGetSelMaskByte; i++)
                {
                    strGetSelMask = strGetSelMask + rxStrPkts.strParameters[7 + i];
                }
            }
            else
            {
                for (int i = 0; i < intGetSelMaskByte + 1; i++)
                {
                    strGetSelMask = strGetSelMask + rxStrPkts.strParameters[7 + i];
                }
            }

            this.txtGetSelMask.Text = Commands.AutoAddSpace(strGetSelMask);
            MessageBox.Show(infoGetSelParam, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GetQueryParameter_ResponseMessageProcess(Commands.ReaderResponseFrameString rxStrPkts)
        {
            string infoGetQuery = string.Empty;
            string[] strMSB = String16toString2(rxStrPkts.strParameters[0]);
            string[] strLSB = String16toString2(rxStrPkts.strParameters[1]);
            int intQ = Convert.ToInt32(strLSB[6]) * 8 + Convert.ToInt32(strLSB[5]) * 4
                        + Convert.ToInt32(strLSB[4]) * 2 + Convert.ToInt32(strLSB[3]);
            string strM = string.Empty;
            if ((strMSB[6] + strMSB[5]) == "00")
            {
                strM = "1";
            }
            else if ((strMSB[6] + strMSB[5]) == "01")
            {
                strM = "2";
            }
            else if ((strMSB[6] + strMSB[5]) == "10")
            {
                strM = "4";
            }
            else if ((strMSB[6] + strMSB[5]) == "11")
            {
                strM = "8";
            }
            string strTRext = string.Empty;
            if (strMSB[4] == "0")
            {
                strTRext = "NoPilot";
            }
            else
            {
                strTRext = "UsePilot";
            }
            string strTarget = string.Empty;
            if (strLSB[7] == "0")
            {
                strTarget = "A";
            }
            else
            {
                strTarget = "B";
            }
            infoGetQuery = "DR=" + strMSB[7] + ", ";
            infoGetQuery = infoGetQuery + "M=" + strM + ", ";
            infoGetQuery = infoGetQuery + "TRext=" + strTRext + ", ";
            infoGetQuery = infoGetQuery + "Sel=" + strMSB[3] + strMSB[2] + ", ";
            infoGetQuery = infoGetQuery + "Session=" + strMSB[1] + strMSB[0] + ", ";
            infoGetQuery = infoGetQuery + "Target=" + strTarget + ", ";
            infoGetQuery = infoGetQuery + "Q=" + intQ;
            MessageBox.Show(infoGetQuery, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RegionChannelFHSS_ResponseMessageProcess(Commands.ReaderResponseFrameString rxStrPkts)
        {
            if (rxStrPkts.strCmdH == ConstCode.CMD_SET_REGION)
            {
                curRegion = GetRegionValueFromUI(cbxRegion.SelectedIndex);
                ChangedRFchannelTableFromFreqRegion(cbxRegion.SelectedIndex);
                setToolStripStatusMessage1("Set RF Region Successed!", Color.Purple);
            }
            else if (rxStrPkts.strCmdH == ConstCode.CMD_GET_REGION)
            {
                string strRegion = "";
                curRegion = rxStrPkts.strParameters[0];
                switch (rxStrPkts.strParameters[0])
                {
                    case ConstCode.REGION_CODE_CHN2:	 // China 2
                        cbxRegion.SelectedIndex = 0;
                        strRegion = "China2";
                        break;
                    case ConstCode.REGION_CODE_CHN1:	 // China 1
                        cbxRegion.SelectedIndex = 1;
                        strRegion = "China1";
                        break;
                    case ConstCode.REGION_CODE_US:	// US
                        cbxRegion.SelectedIndex = 2;
                        strRegion = "US";
                        break;
                    case ConstCode.REGION_CODE_EUR:	 // Europe
                        cbxRegion.SelectedIndex = 3;
                        strRegion = "Europe";
                        break;
                    case ConstCode.REGION_CODE_KOREA:	 // Korea
                        cbxRegion.SelectedIndex = 4;
                        strRegion = "Korea";
                        break;
                    case ConstCode.REGION_CODE_SINGASINGAPORE:	 // Singapore
                        cbxRegion.SelectedIndex = 5;
                        strRegion = "Singapore";
                        break;
                    case ConstCode.REGION_CODE_SOUTHAFRICA:	 // SouthArica   //2021-04-25
                        cbxRegion.SelectedIndex = 6;
                        strRegion = "SouthArica";
                        break;
                    case ConstCode.REGION_CODE_MALAYSIA:	 // Malaysia   //2021-12-06
                        cbxRegion.SelectedIndex = 7;
                        strRegion = "Malaysia";
                        break;
                    default:
                        cbxRegion.SelectedIndex = 0;
                        strRegion = "Unknow";
                        break;
                }
                ChangedRFchannelTableFromFreqRegion(cbxRegion.SelectedIndex);
                setToolStripStatusMessage1("Get RF Region Successed! {Index=" + rxStrPkts.strParameters[0] + "-" + strRegion + "}", Color.Purple);
            }
            else if (rxStrPkts.strCmdH == ConstCode.CMD_SET_RF_CHANNEL)
            {
                setToolStripStatusMessage1("Set RF Channel Successed!", Color.Purple);
            }
            else if (rxStrPkts.strCmdH == ConstCode.CMD_GET_RF_CHANNEL)
            {
                double curRfChIndex = Convert.ToInt32(rxStrPkts.strParameters[0], 16);
                double curRfCh;
                switch (curRegion)
                {
                    case ConstCode.REGION_CODE_CHN2: // China 2
                        curRfCh = 920.125 + curRfChIndex * 0.25;
                        break;
                    case ConstCode.REGION_CODE_CHN1: // China 1
                        curRfCh = 840.125 + curRfChIndex * 0.25;
                        break;
                    case ConstCode.REGION_CODE_US: // US
                        curRfCh = 902.25 + curRfChIndex * 0.5;
                        break;
                    case ConstCode.REGION_CODE_EUR: // Europe
                        curRfCh = 865.1 + curRfChIndex * 0.2;
                        break;
                    case ConstCode.REGION_CODE_KOREA:  // Korea
                        curRfCh = 917.1 + curRfChIndex * 0.2;
                        break;
                    case ConstCode.REGION_CODE_SINGASINGAPORE:	 // Singapore
                        curRfCh = 923.125 + curRfChIndex * 0.25;
                        break;
                    case ConstCode.REGION_CODE_SOUTHAFRICA:	 // SouthArica   //2021-04-25
                        curRfCh = 915.6 + curRfChIndex * 0.2;
                        break;
                    case ConstCode.REGION_CODE_MALAYSIA:	 // Malaysia   //2021-12-06
                        curRfCh = 919.25 + curRfChIndex * 0.5;
                        break;
                    default:
                        curRfCh = 0.0;
                        break;
                }
                if (curRfChIndex >= cbxChannel.Items.Count)
                {
                    setToolStripStatusMessage1("RF Channel is Invalid!!! Set a new RF Channel value! (Index=" + curRfChIndex.ToString() + ")", Color.Red);
                }
                else
                {
                    cbxChannel.SelectedIndex = (int)curRfChIndex;
                    setToolStripStatusMessage1("Current RF Channel is " + curRfCh + " MHz", Color.Purple);
                }
            }
            else if (rxStrPkts.strCmdH == ConstCode.CMD_INSERT_FHSS_CHANNEL)
            {
                if (rxStrPkts.strCmdL == "00")
                {
                    setToolStripStatusMessage1("Insert RF channel in the current range of RF region  is OK! ", Color.Purple);
                }
                else if (rxStrPkts.strCmdL == "01")
                {
                    uint RFchnlInrNum = Convert.ToUInt16(rxStrPkts.strParameters[0], 16);
                    uint RFchnlBegin = Convert.ToUInt16(rxStrPkts.strParameters[1], 16);
                    uint RFchnlEnd;
                    if (RFchnlInrNum > 0)
                    {
                        RFchnlEnd = RFchnlBegin + RFchnlInrNum - 1;
                        txtChIndexBegin.Text = RFchnlBegin.ToString();
                        txtChIndexEnd.Text = RFchnlEnd.ToString();

                        string strInformation = "Get Insert RF Channel frome: " + txtChIndexBegin.Text + " To " + txtChIndexEnd.Text + " !";

                        setToolStripStatusMessage1(strInformation, Color.Purple);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Sub Command for Module Reader!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);  // 2019-07-24
                    }
                }
            }
            else if (rxStrPkts.strCmdH == ConstCode.CMD_SET_FHSS)
            {
                string strFh;
                if (rxStrPkts.strCmdL == "00")
                {
                    if (rxStrPkts.strParameters[0] == ConstCode.SET_OFF)
                        setToolStripStatusMessage1("Set RF FHSS On/Off Successed! (FHSS Off)", Color.Purple);
                    else
                        setToolStripStatusMessage1("Set RF FHSS On/Off Successed! (FHSS On)", Color.Purple);
                }
                else if (rxStrPkts.strCmdL == "01")
                {
                    if (rxStrPkts.strParameters[0] == ConstCode.SET_OFF)
                    {
                        setToolStripStatusMessage1("Get RF FHSS On/Off Successed! (FHSS Off)", Color.Purple);
                        cbxFHSS.SelectedIndex = 0;
                    }
                    else
                    {
                        setToolStripStatusMessage1("Get RF FHSS On/Off Successed! (FHSS On)", Color.Purple);
                        cbxFHSS.SelectedIndex = 1;
                    }
                }
                else if (rxStrPkts.strCmdL == "02")
                { //Set Freqency Hopping Period
                    strFh = rxStrPkts.strParameters[0] + rxStrPkts.strParameters[1];
                    uint nFh = Convert.ToUInt16(strFh, 16);
                    cbxFhssHopPeriod.SelectedIndex = (int)(nFh / 100) - 1; //100mS

                    strFh = string.Format("{0:D}mS", nFh);
                    setToolStripStatusMessage1("Set RF FHSS Period Successed! " + strFh, Color.Purple);
                }
                else if (rxStrPkts.strCmdL == "03")
                {  //Get Freqency Hopping Period
                    strFh = rxStrPkts.strParameters[0] + rxStrPkts.strParameters[1];
                    uint nFh = Convert.ToUInt16(strFh, 16);
                    cbxFhssHopPeriod.SelectedIndex = (int)(nFh / 100) - 1; //100mS

                    strFh = string.Format("{0:D}mS", nFh);
                    setToolStripStatusMessage1("Get RF FHSS Period Successed! " + strFh, Color.Purple);
                }
            }

        }

        private void AntResponseMessageProcess(Commands.ReaderResponseFrameString rxStrPkts) //string strCmdL)
        {
            bool bParamError = false;
            uint uAntEnable;
            string strAntEnable;
            string sstr;
            int i, k = 0;

            if (rxStrPkts.strStatus != ConstCode.FAIL_OK)
            {
                setToolStripStatusMessage1("Error Code: 0x" + rxStrPkts.strStatus, Color.Red);
                return;
            }
            switch (rxStrPkts.strCmdL)
            {
                case "00":
                    if (rxStrPkts.strParameters[0] != Ant.Quantity.ToString("X2"))
                        bParamError = true;
                    if (rxStrPkts.strParameters[1] != Ant.Enable[0].ToString("X2"))
                        bParamError = true;
                    if (rxStrPkts.strParameters[2] != Ant.Enable[1].ToString("X2"))
                        bParamError = true;
                    if (rxStrPkts.strParameters[3] != Ant.Enable[2].ToString("X2"))
                        bParamError = true;
                    if (rxStrPkts.strParameters[4] != Ant.Enable[3].ToString("X2"))
                        bParamError = true;
                    if (rxStrPkts.strParameters[5] != Ant.PollingCycle.ToString("X2"))
                        bParamError = true;
                    k = 6;
                    for (i = 0; i < Ant.Quantity; i++)
                    {
                        sstr = rxStrPkts.strParameters[k] + rxStrPkts.strParameters[k + 1];
                        if (sstr != Ant.AntRFPower[i].ToString("X4"))
                            bParamError = true;

                        sstr = rxStrPkts.strParameters[k + 2] + rxStrPkts.strParameters[k + 3];
                        if (sstr != Ant.PollingNumber[i].ToString("X4"))
                            bParamError = true;
                        k = k + 4;
                    }
                    if (bParamError == false)
                        setToolStripStatusMessage1("Set Antenna Parameters Successed!", Color.Purple);
                    else
                        setToolStripStatusMessage1("Set Antenna Parameters Failed!", Color.Red);
                    break;

                case "01":
                    try
                    {
                        Ant.Quantity = Convert.ToByte(rxStrPkts.strParameters[0], 16);
                        comboBox_RF_AntPort_Quantity.Text = Ant.Quantity.ToString();

                        strAntEnable = rxStrPkts.strParameters[2] + rxStrPkts.strParameters[1];
                        uAntEnable = Convert.ToUInt32(strAntEnable, 16);

                        //Ant.Enable[0] = Convert.ToByte(rxStrPkts.strParameters[1],16); 
                        for (i = 0; i < _ANT_Max_Quantity_; i++)   ///!!!
                        {
                            if (((uAntEnable >> i) & 0x01) != 0x00) //if (((Ant.Enable[0] >> i) & 0x01) != 0x00)
                            {
                                AntEnableBitCheck[i].Checked = true;
                            }
                            else
                            {
                                AntEnableBitCheck[i].Checked = false;
                            }
                        }


                        Ant.PollingCycle = byte.Parse(rxStrPkts.strParameters[5]);
                        if (Ant.PollingCycle != 0)
                            checkBox_RF_AntPort_AutoPolling.Checked = true;
                        else
                            checkBox_RF_AntPort_AutoPolling.Checked = false;

                        k = 6;
                        for (i = 0; i < Ant.Quantity; i++)
                        {
                            sstr = rxStrPkts.strParameters[k] + rxStrPkts.strParameters[k + 1];
                            Ant.AntRFPower[i] = Convert.ToUInt16(sstr, 16);
                            //i = (Ant.AntRFPower[i] / 100) - 30;
                            AntRfPowerCmb[i].SelectedIndex = 33 - (Ant.AntRFPower[i] / 100);
                            sstr = rxStrPkts.strParameters[k + 2] + rxStrPkts.strParameters[k + 3];
                            Ant.PollingNumber[i] = Convert.ToUInt16(sstr, 16);
                            AntPollingCountTxt[i].Text = Ant.PollingNumber[i].ToString();
                            k = k + 4;
                        }
                        comboBox_RF_AntPort_Quantity_SelectedIndexChanged(null, null);//2021-12-28
                        setToolStripStatusMessage1("Get Antenna Parameters Successed!", Color.Purple);
                    }
                    catch (System.Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        setToolStripStatusMessage1("Exception:" + ex.Message, Color.Red);
                    }
                    break;

                case "02":
                    k = Convert.ToInt16(rxStrPkts.strParameters[0], 16);
                    k = k + 1;
                    setToolStripStatusMessage1("Switch to Antenna Port: Ant" + k.ToString(), Color.MediumSeaGreen);
                    break;

                case "03":
                    try
                    {
                        k = Convert.ToInt16(rxStrPkts.strParameters[0], 16);
                        for (i = 0; i < _ANT_Max_Quantity_; i++)
                        {
                            AntPortRb[i].Checked = false;
                        }
                        AntPortRb[k].Checked = true;
                        k = k + 1;
                        setToolStripStatusMessage1("Get Current Antenna Port: Ant" + k.ToString(), Color.Purple);
                    }
                    catch (System.Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        setToolStripStatusMessage1("Exception:" + ex.Message, Color.Red);
                    }
                    break;
            }
        }

        private void SINGLE_IDResponseMessageProcess(Commands.ReaderResponseFrameString rxStrPkts)
        {
            epc = "";
            tid = "";
            user = "";

            SucessEPCNum = SucessEPCNum + 1;
            db_errEPCNum = FailEPCNum;
            db_LoopNum_cnt = db_LoopNum_cnt + 1;
            errnum = (db_errEPCNum / db_LoopNum_cnt) * 100;
            per = string.Format("{0:0.000}", errnum);

            int rssidBm = Convert.ToInt16(rxStrPkts.strParameters[0], 16); // rssidBm is negative && in bytes
            if (CurrentModuleType == 0)//92x模块 
            {
                if (rssidBm > 127)
                {
                    rssidBm = -((-rssidBm) & 0xFF);
                }
            }
            rssi = rssidBm.ToString();
            rssi = rssidBm.ToString();

            int PCEPCLength = ((Convert.ToInt32((rxStrPkts.strParameters[1]), 16)) / 8 + 1) * 2;
            pc = rxStrPkts.strParameters[1] + " " + rxStrPkts.strParameters[2];
            epc = string.Empty;
            for (int i = 0; i < PCEPCLength - 2; i++)
            {
                epc = epc + rxStrPkts.strParameters[3 + i];
            }
            epc = Commands.AutoAddSpace(epc);
            crc = rxStrPkts.strParameters[1 + PCEPCLength] + " " + rxStrPkts.strParameters[2 + PCEPCLength];

            antno = rxStrPkts.strParameters[3 + PCEPCLength];

            GetEPC(pc, epc, tid, user, rssi, antno);

        }

        private void MULTI_IDResponseMessageProcess(Commands.ReaderResponseFrameString rxStrPkts)
        {
            // Inventory Algorithm:  //2022-04-21
            // 0x10  0x11  0x12  EPC+EPC   ConstCode.Inventory_Tag_Alg_code.Inventory_Tag_Alg_EPC_EPC_10/11/12;
            // 0x20  0x21  0x22  EPC+TID   ConstCode.Inventory_Tag_Alg_code.Inventory_Tag_Alg_EPC_TID_20/21/22
            // 0x30  0x31  0x32  EPC+USER  ConstCode.Inventory_Tag_Alg_code.Inventory_Tag_Alg_EPC_USER_30/31/32
            if (rxStrPkts.strCmdL == Convert.ToString((byte)ConstCode.Inventory_Tag_Alg_code.Inventory_Tag_Alg_EPC_EPC_10, 16)
                 || rxStrPkts.strCmdL == Convert.ToString((byte)ConstCode.Inventory_Tag_Alg_code.Inventory_Tag_Alg_EPC_EPC_11, 16)
                 || rxStrPkts.strCmdL == Convert.ToString((byte)ConstCode.Inventory_Tag_Alg_code.Inventory_Tag_Alg_EPC_EPC_12, 16)
             )
            {
                epc = "";
                tid = "";
                user = "";
                int IndexParam = 0;

                //---------------------------------------[0]  RSSI always=0  , because the Tag Inventory algorithum when 
                int rssidBm = Convert.ToInt16(rxStrPkts.strParameters[0], 16); // This byte is reserved for this command
                if (CurrentModuleType == 0)//92x模块 
                {
                    if (rssidBm > 127)
                    {
                        rssidBm = -((-rssidBm) & 0xFF);
                    }
                }
                rssi = rssidBm.ToString();
                //---------------------------------------[1]  PL -->  PC + EPC + StoredCRC + AntNo
                int PL = Convert.ToInt16(rxStrPkts.strParameters[1], 16);// 
                //---------------------------------------[2~3]  PC: Protocol Control Word.
                int PCEPCLength = ((Convert.ToInt32((rxStrPkts.strParameters[2]), 16)) / 8 + 1) * 2;
                pc = rxStrPkts.strParameters[2] + " " + rxStrPkts.strParameters[3];
                //---------------------------------------[4~...]  EPC
                epc = string.Empty;
                int i;
                for (i = 0; i < PCEPCLength - 2; i++)
                {
                    epc = epc + rxStrPkts.strParameters[4 + i];
                }
                IndexParam = i + 4;
                crc = rxStrPkts.strParameters[IndexParam] + " " + rxStrPkts.strParameters[IndexParam + 1];//StoreCRC
                IndexParam = IndexParam + 2;

                antno = rxStrPkts.strParameters[IndexParam++]; //AntNo

            }

            else if (rxStrPkts.strCmdL == Convert.ToString((byte)ConstCode.Inventory_Tag_Alg_code.Inventory_Tag_Alg_EPC_TID_20, 16)
                 || rxStrPkts.strCmdL == Convert.ToString((byte)ConstCode.Inventory_Tag_Alg_code.Inventory_Tag_Alg_EPC_TID_21, 16)
                 || rxStrPkts.strCmdL == Convert.ToString((byte)ConstCode.Inventory_Tag_Alg_code.Inventory_Tag_Alg_EPC_TID_22, 16)
            )
            {
                epc = "";
                tid = "";
                user = "";

                int IndexParam = 0;

                //---------------------------------------[0]  RSSI always=0  , because the Tag Inventory algorithum when 
                int rssidBm = Convert.ToInt16(rxStrPkts.strParameters[0], 16); // This byte is reserved for this command
                if (CurrentModuleType == 0)//92x模块 
                {
                    if (rssidBm > 127)
                    {
                        rssidBm = -((-rssidBm) & 0xFF);
                    }
                }
                rssi = rssidBm.ToString();
                rssi = rssidBm.ToString();
                //---------------------------------------[1]  PL -->  PC + EPC + StoredCRC + AntNo
                int PL = Convert.ToInt16(rxStrPkts.strParameters[1], 16);// 
                //---------------------------------------[2~3]  PC: Protocol Control Word.
                int PCEPCLength = ((Convert.ToInt32((rxStrPkts.strParameters[2]), 16)) / 8 + 1) * 2;
                pc = rxStrPkts.strParameters[2] + " " + rxStrPkts.strParameters[3];
                //---------------------------------------[4~...]  EPC
                epc = string.Empty;
                int i;
                for (i = 0; i < PCEPCLength - 2; i++)
                {
                    epc = epc + rxStrPkts.strParameters[4 + i];
                }
                IndexParam = i + 4;
                crc = rxStrPkts.strParameters[IndexParam] + " " + rxStrPkts.strParameters[IndexParam + 1];//StoreCRC
                IndexParam = IndexParam + 2;

                antno = rxStrPkts.strParameters[IndexParam++]; //AntNo
                //---------------------------------------[...]  ML+MEMBANK: Access Membank: EPC+EPC/TID/USER   
                int ML = Convert.ToInt16(rxStrPkts.strParameters[IndexParam++], 16);
                tid = string.Empty;
                for (i = 0; i < ML; i++)
                {
                    tid = tid + rxStrPkts.strParameters[IndexParam++];
                }
            }
            else if (rxStrPkts.strCmdL == Convert.ToString((byte)ConstCode.Inventory_Tag_Alg_code.Inventory_Tag_Alg_EPC_USER_30, 16)
                 || rxStrPkts.strCmdL == Convert.ToString((byte)ConstCode.Inventory_Tag_Alg_code.Inventory_Tag_Alg_EPC_USER_31, 16)
                 || rxStrPkts.strCmdL == Convert.ToString((byte)ConstCode.Inventory_Tag_Alg_code.Inventory_Tag_Alg_EPC_USER_32, 16)
            )
            {
                epc = "";
                tid = "";
                user = "";
                int IndexParam = 0;

                //---------------------------------------[0]  RSSI always=0  , because the Tag Inventory algorithum when 
                int rssidBm = Convert.ToInt16(rxStrPkts.strParameters[0], 16); // This byte is reserved for this command
                if (CurrentModuleType == 0)//92x模块 
                {
                    if (rssidBm > 127)
                    {
                        rssidBm = -((-rssidBm) & 0xFF);
                    }
                }
                rssi = rssidBm.ToString();
                rssi = rssidBm.ToString();
                //---------------------------------------[1]  PL -->  PC + EPC + StoredCRC + AntNo
                int PL = Convert.ToInt16(rxStrPkts.strParameters[1], 16);// 
                //---------------------------------------[2~3]  PC: Protocol Control Word.
                int PCEPCLength = ((Convert.ToInt32((rxStrPkts.strParameters[2]), 16)) / 8 + 1) * 2;
                pc = rxStrPkts.strParameters[2] + " " + rxStrPkts.strParameters[3];
                //---------------------------------------[4~...]  EPC
                epc = string.Empty;
                int i;
                for (i = 0; i < PCEPCLength - 2; i++)
                {
                    epc = epc + rxStrPkts.strParameters[4 + i];
                }
                IndexParam = i + 4;
                crc = rxStrPkts.strParameters[IndexParam] + " " + rxStrPkts.strParameters[IndexParam + 1];//StoreCRC
                IndexParam = IndexParam + 2;

                antno = rxStrPkts.strParameters[IndexParam++]; //AntNo
                //---------------------------------------[...]  ML+MEMBANK: Access Membank: EPC+EPC/TID/USER   
                int ML = Convert.ToInt16(rxStrPkts.strParameters[IndexParam++], 16);
                user = string.Empty;
                for (i = 0; i < ML; i++)
                {
                    user = user + rxStrPkts.strParameters[IndexParam++];
                }
            }

            else if (rxStrPkts.strCmdL == Convert.ToString((byte)ConstCode.Inventory_Tag_Alg_code.Inventory_Tag_Alg_EPC_TID_USER_40, 16)
                 || rxStrPkts.strCmdL == Convert.ToString((byte)ConstCode.Inventory_Tag_Alg_code.Inventory_Tag_Alg_EPC_TID_USER_41, 16)
                 || rxStrPkts.strCmdL == Convert.ToString((byte)ConstCode.Inventory_Tag_Alg_code.Inventory_Tag_Alg_EPC_TID_USER_42, 16)
            )
            {
                //  EPC + Access MemBank(EPC,TID, USER (12))
                // RSSI(1) + PL(1) + PC(2) +EPC(PC) +StoreCRC(2) +ANTNO(1) +ML+MEMBANK (+EL+ExMEMBANK)
                epc = "";
                tid = "";
                user = "";

                int IndexParam = 0;

                //---------------------------------------[0]  RSSI always=0  , because the Tag Inventory algorithum when 
                int rssidBm = Convert.ToInt16(rxStrPkts.strParameters[0], 16); // This byte is reserved for this command
                if (CurrentModuleType == 0)//92x模块 
                {
                    if (rssidBm > 127)
                    {
                        rssidBm = -((-rssidBm) & 0xFF);
                    }
                }
                rssi = rssidBm.ToString();
                //---------------------------------------[1]  PL -->  PC + EPC + StoredCRC + AntNo
                int PL = Convert.ToInt16(rxStrPkts.strParameters[1], 16);// 
                //---------------------------------------[2~3]  PC: Protocol Control Word.
                int PCEPCLength = ((Convert.ToInt32((rxStrPkts.strParameters[2]), 16)) / 8 + 1) * 2;
                pc = rxStrPkts.strParameters[2] + " " + rxStrPkts.strParameters[3];
                //---------------------------------------[4~...]  EPC
                epc = string.Empty;
                int i;
                for (i = 0; i < PCEPCLength - 2; i++)
                {
                    epc = epc + rxStrPkts.strParameters[4 + i];
                }
                IndexParam = i + 4;
                crc = rxStrPkts.strParameters[IndexParam] + " " + rxStrPkts.strParameters[IndexParam + 1];//StoreCRC
                IndexParam = IndexParam + 2;

                antno = rxStrPkts.strParameters[IndexParam++]; //AntNo
                //---------------------------------------[...]  ML+MEMBANK: Access Membank: EPC+EPC/TID/USER   
                int ML = Convert.ToInt16(rxStrPkts.strParameters[IndexParam++], 16);
                tid = string.Empty;
                for (i = 0; i < ML; i++)
                {
                    tid = tid + rxStrPkts.strParameters[IndexParam++];
                }
                //------------------------------------------------[] EL+ExMEMBANK   (Access Membank: EPC+TID+USER  )
                if (rxStrPkts.strCmdL == Convert.ToString((byte)ConstCode.Inventory_Tag_Alg_code.Inventory_Tag_Alg_EPC_TID_USER_40, 16)
                    || rxStrPkts.strCmdL == Convert.ToString((byte)ConstCode.Inventory_Tag_Alg_code.Inventory_Tag_Alg_EPC_TID_USER_41, 16)
                    || rxStrPkts.strCmdL == Convert.ToString((byte)ConstCode.Inventory_Tag_Alg_code.Inventory_Tag_Alg_EPC_TID_USER_42, 16)
                )
                {
                    int EL = Convert.ToInt16(rxStrPkts.strParameters[IndexParam++], 16);
                    user = string.Empty;
                    for (i = 0; i < EL; i++)
                    {
                        user = user + rxStrPkts.strParameters[IndexParam++];
                    }
                }

            }
            else
            {
                epc = "";
                tid = "";
                user = "";

                errnum = 0; //  2020-11-21   it is not correct;
                per = string.Format("{0:0.000}", errnum);

                int rssidBm = Convert.ToInt16(rxStrPkts.strParameters[0], 16); // rssidBm is negative && in bytes
                if (CurrentModuleType == 0)//92x模块 
                {
                    if (rssidBm > 127)
                    {
                        rssidBm = -((-rssidBm) & 0xFF);
                    }
                }
                rssi = rssidBm.ToString();
                rssi = rssidBm.ToString();
                //---------------------------------------[1~2]  PC
                int PCEPCLength = ((Convert.ToInt32((rxStrPkts.strParameters[1]), 16)) / 8 + 1) * 2;
                pc = rxStrPkts.strParameters[1] + " " + rxStrPkts.strParameters[2];
                epc = string.Empty;
                for (int i = 0; i < PCEPCLength - 2; i++)
                {
                    epc = epc + rxStrPkts.strParameters[3 + i];
                }
                if (epc.Length <= 32)
                    epc = Commands.AutoAddSpace(epc);
                crc = rxStrPkts.strParameters[1 + PCEPCLength] + " " + rxStrPkts.strParameters[2 + PCEPCLength];

                antno = rxStrPkts.strParameters[3 + PCEPCLength];

            }

            GetEPC(pc, epc, tid, user, rssi, antno);

        }

        private void GPIO_ResponseMessageProcess(Commands.ReaderResponseFrameString rxStrPkts)
        {
            if (rxStrPkts.strCmdL == "00")
            {
                if (rxStrPkts.strParameters[0] == "00")
                {
                    if (rxStrPkts.strParameters[2] == ConstCode.SET_OFF)
                        setToolStripStatusMessage1("Set GPIO Direction Successed! (Input)", Color.Purple);
                    else
                        setToolStripStatusMessage1("Set GPIO Direction Successed! (Output)", Color.Purple);
                }
                else if (rxStrPkts.strParameters[0] == "01")
                {
                    if (rxStrPkts.strParameters[2] == ConstCode.SET_OFF)
                        setToolStripStatusMessage1("Set GPO On/Off Successed! (Low)", Color.Purple);
                    else
                        setToolStripStatusMessage1("Set GPO On/Off Successed! (High)", Color.Purple);
                }
                else if (rxStrPkts.strParameters[0] == "02")
                {
                    if (rxStrPkts.strParameters[2] == ConstCode.SET_OFF)
                    {
                        setToolStripStatusMessage1("Get GPIO High/Low Successed! (Low)", Color.Purple);
                        cbxIoLevel.SelectedIndex = 0;
                    }
                    else
                    {
                        setToolStripStatusMessage1("Get GPIO High/Low Successed! (High)", Color.Purple);
                        cbxIoLevel.SelectedIndex = 1;
                    }
                }
                else if (rxStrPkts.strParameters[0] == "11")
                {
                    if (rxStrPkts.strParameters[2] == ConstCode.SET_OFF)
                    {
                        if ((rxStrPkts.strParameters[1] == "01") && (checkBox_GPO1.Checked == true))
                        {
                            comboBox_GPO1.SelectedIndex = 0;
                        }
                        else if ((rxStrPkts.strParameters[1] == "02") && (checkBox_GPO2.Checked == true))
                        {
                            comboBox_GPO2.SelectedIndex = 0;
                        }
                        else if ((rxStrPkts.strParameters[1] == "03") && (checkBox_GPO3.Checked == true))
                        {
                            comboBox_GPO3.SelectedIndex = 0;
                        }
                        else if ((rxStrPkts.strParameters[1] == "04") && (checkBox_GPO4.Checked == true))
                        {
                            comboBox_GPO4.SelectedIndex = 0;
                        }
                        setToolStripStatusMessage1("Set GPO High/Low Successed! (Low)", Color.Purple);
                    }
                    else
                    {
                        if ((rxStrPkts.strParameters[1] == "01") && (checkBox_GPO1.Checked == true))
                        {
                            comboBox_GPO1.SelectedIndex = 1;
                        }
                        else if ((rxStrPkts.strParameters[1] == "02") && (checkBox_GPO2.Checked == true))
                        {
                            comboBox_GPO2.SelectedIndex = 1;
                        }
                        else if ((rxStrPkts.strParameters[1] == "03") && (checkBox_GPO3.Checked == true))
                        {
                            comboBox_GPO3.SelectedIndex = 1;
                        }
                        else if ((rxStrPkts.strParameters[1] == "04") && (checkBox_GPO4.Checked == true))
                        {
                            comboBox_GPO4.SelectedIndex = 1;
                        }
                        setToolStripStatusMessage1("Set GPO High/Low Successed! (High)", Color.Purple);
                    }
                }
                else if (rxStrPkts.strParameters[0] == "12")
                {
                    if (rxStrPkts.strParameters[2] == ConstCode.SET_OFF)
                    {
                        if ((rxStrPkts.strParameters[1] == "01") && (checkBox_GPO1.Checked == true))
                        {
                            comboBox_GPO1.SelectedIndex = 0;
                        }
                        else if ((rxStrPkts.strParameters[1] == "02") && (checkBox_GPO2.Checked == true))
                        {
                            comboBox_GPO2.SelectedIndex = 0;
                        }
                        else if ((rxStrPkts.strParameters[1] == "03") && (checkBox_GPO3.Checked == true))
                        {
                            comboBox_GPO3.SelectedIndex = 0;
                        }
                        else if ((rxStrPkts.strParameters[1] == "04") && (checkBox_GPO4.Checked == true))
                        {
                            comboBox_GPO4.SelectedIndex = 0;
                        }
                        setToolStripStatusMessage1("Get GPO High/Low Successed! (Low)", Color.Purple);
                    }
                    else
                    {
                        if ((rxStrPkts.strParameters[1] == "01") && (checkBox_GPO1.Checked == true))
                        {
                            comboBox_GPO1.SelectedIndex = 1;
                        }
                        else if ((rxStrPkts.strParameters[1] == "02") && (checkBox_GPO2.Checked == true))
                        {
                            comboBox_GPO2.SelectedIndex = 1;
                        }
                        else if ((rxStrPkts.strParameters[1] == "03") && (checkBox_GPO3.Checked == true))
                        {
                            comboBox_GPO3.SelectedIndex = 1;
                        }
                        else if ((rxStrPkts.strParameters[1] == "04") && (checkBox_GPO4.Checked == true))
                        {
                            comboBox_GPO4.SelectedIndex = 1;
                        }
                        setToolStripStatusMessage1("Get GPO High/Low Successed! (High)", Color.Purple);
                    }

                }
                else if (rxStrPkts.strParameters[0] == "13")
                {
                    if (rxStrPkts.strParameters[2] == ConstCode.SET_OFF)
                    {
                        if ((rxStrPkts.strParameters[1] == "01") && (checkBox_GPI1.Checked == true))
                        {
                            comboBox_GPI1.SelectedIndex = 0;
                        }
                        else if ((rxStrPkts.strParameters[1] == "02") && (checkBox_GPI2.Checked == true))
                        {
                            comboBox_GPI2.SelectedIndex = 0;
                        }
                        else if ((rxStrPkts.strParameters[1] == "03") && (checkBox_GPI3.Checked == true))
                        {
                            comboBox_GPI3.SelectedIndex = 0;
                        }
                        else if ((rxStrPkts.strParameters[1] == "04") && (checkBox_GPI4.Checked == true))
                        {
                            comboBox_GPI4.SelectedIndex = 0;
                        }
                        setToolStripStatusMessage1("Get GPI High/Low Successed! (Low)", Color.Purple);
                    }
                    else
                    {
                        if ((rxStrPkts.strParameters[1] == "01") && (checkBox_GPI1.Checked == true))
                        {
                            comboBox_GPI1.SelectedIndex = 1;
                        }
                        else if ((rxStrPkts.strParameters[1] == "02") && (checkBox_GPI2.Checked == true))
                        {
                            comboBox_GPI2.SelectedIndex = 1;
                        }
                        else if ((rxStrPkts.strParameters[1] == "03") && (checkBox_GPI3.Checked == true))
                        {
                            comboBox_GPI3.SelectedIndex = 1;
                        }
                        else if ((rxStrPkts.strParameters[1] == "04") && (checkBox_GPI4.Checked == true))
                        {
                            comboBox_GPI4.SelectedIndex = 1;
                        }
                        setToolStripStatusMessage1("Get GPI High/Low Successed! (High)", Color.Purple);
                    }

                }
            }

        }

        private void ExtCommand_ResponseMessageProcess(Commands.ReaderResponseFrameString rxStrPkts)
        {
            if (rxStrPkts.strCmdH == ConstCode.CMD_Setting_Reader_Work_Mode)//"61"
            {
                if (rxStrPkts.strCmdL == "00")
                {
                    if (rxStrPkts.strParameters[0] == "00")
                    {
                        setToolStripStatusMessage1("Set Reader Work Mode Success (Command mode)", Color.MediumSeaGreen);
                    }
                    else if (rxStrPkts.strParameters[0] == "01")
                    {
                        setToolStripStatusMessage1("Set Reader Work Mode Success (Polling mode)", Color.MediumSeaGreen);
                    }
                    else if (rxStrPkts.strParameters[0] == "02")
                    {
                        setToolStripStatusMessage1("Set Reader Work Mode Success (Trigger mode)", Color.MediumSeaGreen);
                    }

                }
                else if (rxStrPkts.strCmdL == "01")
                {
                    ReaderWorkModeComboBox.SelectedIndex = Convert.ToInt32(rxStrPkts.strParameters[0]);
                    if (rxStrPkts.strParameters[0] == "00")
                    {
                        setToolStripStatusMessage1("Get Reader Work Mode Success (Command mode)", Color.MediumSeaGreen);
                    }
                    else if (rxStrPkts.strParameters[0] == "01")
                    {
                        setToolStripStatusMessage1("Get Reader Work Mode Success (Polling mode)", Color.MediumSeaGreen);
                    }
                    else if (rxStrPkts.strParameters[0] == "02")
                    {
                        setToolStripStatusMessage1("Get Reader Work Mode Success (Trigger mode)", Color.MediumSeaGreen);
                    }
                }
            }
            else if (rxStrPkts.strCmdH == ConstCode.CMD_Setting_Matched_Tag_Data_Mode)//"63"
            {
                if ((rxStrPkts.strCmdL == "00") || (rxStrPkts.strCmdL == "01") || (rxStrPkts.strCmdL == "02") || (rxStrPkts.strCmdL == "03"))
                {
                    setToolStripStatusMessage1("Set Matched Tag Data Mode Success", Color.MediumSeaGreen);
                }

                else if (rxStrPkts.strCmdL == "11")
                {
                    String FilderString = string.Empty;
                    try
                    {
                        if ((Convert.ToInt32(rxStrPkts.strParameters[1]) <= 5) && (Convert.ToInt32(rxStrPkts.strParameters[1]) >= 1))
                        {
                            for (int i = 0; i < Convert.ToInt32(rxStrPkts.strParameters[1]); i++)
                            {
                                FilderString += rxStrPkts.strParameters[2 + i];
                            }
                        }
                        else
                        {
                            FilderString = "";
                        }
                    }
                    catch (System.Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    switch (Convert.ToInt32(rxStrPkts.strParameters[0]))
                    {
                        case 0x00:
                            //MatchedNumberComboBox.SelectedIndex = Convert.ToInt32(rxStrPkts.strParameters[0]);
                            if ((Convert.ToInt32(rxStrPkts.strParameters[1]) <= 5))
                            {
                                COMBO_TAG_MATCHED_BYTELEN1.SelectedIndex = Convert.ToInt32(rxStrPkts.strParameters[1]);
                                EDIT_TAG_MATCHED_DATA1.Text = FilderString;
                            }
                            break;
                        case 0x01:
                            //MatchedNumberComboBox.SelectedIndex = Convert.ToInt32(rxStrPkts.strParameters[0]);
                            if ((Convert.ToInt32(rxStrPkts.strParameters[1]) <= 5))
                            {
                                COMBO_TAG_MATCHED_BYTELEN2.SelectedIndex = Convert.ToInt32(rxStrPkts.strParameters[1]);
                                EDIT_TAG_MATCHED_DATA2.Text = FilderString;
                            }
                            break;
                        case 0x02:
                            //MatchedNumberComboBox.SelectedIndex = Convert.ToInt32(rxStrPkts.strParameters[0]);
                            if ((Convert.ToInt32(rxStrPkts.strParameters[1]) <= 5))
                            {
                                COMBO_TAG_MATCHED_BYTELEN3.SelectedIndex = Convert.ToInt32(rxStrPkts.strParameters[1]);
                                EDIT_TAG_MATCHED_DATA3.Text = FilderString;
                            }
                            break;
                        case 0x03:
                            //MatchedNumberComboBox.SelectedIndex = Convert.ToInt32(rxStrPkts.strParameters[0]);
                            if ((Convert.ToInt32(rxStrPkts.strParameters[1]) <= 5))
                            {
                                COMBO_TAG_MATCHED_BYTELEN4.SelectedIndex = Convert.ToInt32(rxStrPkts.strParameters[1]);
                                EDIT_TAG_MATCHED_DATA4.Text = FilderString;
                            }
                            break;

                        case 0x04:
                            //MatchedNumberComboBox.SelectedIndex = Convert.ToInt32(rxStrPkts.strParameters[0]);
                            if ((Convert.ToInt32(rxStrPkts.strParameters[1]) <= 5))
                            {
                                COMBO_TAG_MATCHED_BYTELEN5.SelectedIndex = Convert.ToInt32(rxStrPkts.strParameters[1]);
                                EDIT_TAG_MATCHED_DATA5.Text = FilderString;
                            }
                            break;


                    }
                    setToolStripStatusMessage1("Get Matched Tag Data Mode Success", Color.MediumSeaGreen);
                }
                else if (rxStrPkts.strCmdL == "20")
                {
                    setToolStripStatusMessage1("Set Matched Tag Data Mode Enable Success", Color.MediumSeaGreen);
                }
                else if (rxStrPkts.strCmdL == "21")
                {
                    String EnableString = string.Empty;
                    try
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            EnableString += rxStrPkts.strParameters[i] + " ";
                        }
                    }
                    catch (System.Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    setToolStripStatusMessage1("Get Matched Tag Data Mode Enable Success(" + EnableString + ")", Color.MediumSeaGreen);
                }
            }
            else if (rxStrPkts.strCmdH == ConstCode.CMD_Setting_Beep_Mode)//"64"
            {
                if (rxStrPkts.strCmdL == "00")
                {
                    if (rxStrPkts.strParameters[0] == "00")
                    {
                        setToolStripStatusMessage1("Set Beep mode Success (Beep Off)", Color.MediumSeaGreen);
                    }
                    else if (rxStrPkts.strParameters[0] == "01")
                    {
                        setToolStripStatusMessage1("Set Beep mode Success (Beep On)", Color.MediumSeaGreen);
                    }
                }
                else if (rxStrPkts.strCmdL == "01")
                {
                    BeepModeComboBox.SelectedIndex = Convert.ToInt32(rxStrPkts.strParameters[0]);
                    if (rxStrPkts.strParameters[0] == "00")
                    {
                        setToolStripStatusMessage1("Get Beep mode Success (Beep Off)", Color.MediumSeaGreen);
                    }
                    else if (rxStrPkts.strParameters[0] == "01")
                    {
                        setToolStripStatusMessage1("Get Beep mode Success (Beep On)", Color.MediumSeaGreen);
                    }
                }
            }

            else if (rxStrPkts.strCmdH == ConstCode.CMD_Load_Default_Work_Parameter)//"65"
            {
                if (rxStrPkts.strCmdL == "00")
                {
                    setToolStripStatusMessage1("Load Default Work Parameter Success", Color.MediumSeaGreen);
                }
            }
        }

        private string ParseErrCode(int errorCode)
        {
            switch (errorCode & 0x0F)
            {
                case ConstCode.ERROR_CODE_OTHER_ERROR:
                    return "Other Error";
                case ConstCode.ERROR_CODE_MEM_OVERRUN:
                    return "Memory Overrun";
                case ConstCode.ERROR_CODE_MEM_LOCKED:
                    return "Memory Locked";
                case ConstCode.ERROR_CODE_INSUFFICIENT_POWER:
                    return "Insufficient Power";
                case ConstCode.ERROR_CODE_NON_SPEC_ERROR:
                    return "Non-specific Error";
                default:
                    return "Non-specific Error";
            }
        }

        private void rp_PacketFail(string FailCode, string rxstrLen, string[] strParam)
        {
            int failType = Convert.ToInt32(FailCode, 16);
            int rxlen = Convert.ToInt32(rxstrLen, 16);
            if (rxlen > 7) // has PC+EPC field
            {
                txtOperateEpc.Text = "";
                int pcEpcLen = Convert.ToInt32(strParam[0], 16);

                for (int i = 0; i < pcEpcLen; i++)
                {
                    txtOperateEpc.Text += strParam[i + 1] + " ";
                }
            }
            else
            {
                txtOperateEpc.Text = "";
            }

            if (FailCode == ConstCode.FAIL_INVENTORY_TAG_TIMEOUT)
            {
                FailEPCNum = FailEPCNum + 1;
                db_errEPCNum = FailEPCNum;
                db_LoopNum_cnt = db_LoopNum_cnt + 1;
                errnum = (db_errEPCNum / db_LoopNum_cnt) * 100;
                per = string.Format("{0:0.000}", errnum);
                //pbx_Inv_Indicator.Visible = false;				
            }
            else if (FailCode == ConstCode.FAIL_FHSS_FAIL)
            {
                setStatus("FHSS Failed", Color.Red);
            }
            else if (FailCode == ConstCode.FAIL_ANT_NOT_AVAILABLE)
            {
                setStatus("Switch Antenna Port Failed! Please check the Antenna Setting.", Color.Red);
            }
            else if (FailCode == ConstCode.FAIL_ACCESS_PWD_ERROR)
            {
                setStatus("Access Failed, Please Check the Access Password", Color.Red);
            }
            else if (FailCode == ConstCode.FAIL_READ_MEMORY_NO_TAG)
            {
                setStatus("No Tag Response, Fail to Read Tag Memory", Color.Red);
            }
            else if (FailCode.Substring(0, 1) == ConstCode.FAIL_READ_ERROR_CODE_BASE.Substring(0, 1))
            {
                setStatus("Read Failed. Error Code: " + ParseErrCode(failType), Color.Red);
            }
            else if (FailCode == ConstCode.FAIL_WRITE_MEMORY_NO_TAG)
            {
                setStatus("No Tag Response, Fail to Write Tag Memory", Color.Red);
            }
            else if (FailCode.Substring(0, 1) == ConstCode.FAIL_WRITE_ERROR_CODE_BASE.Substring(0, 1))
            {
                setStatus("Write Failed. Error Code: " + ParseErrCode(failType), Color.Red);
            }
            else if (FailCode == ConstCode.FAIL_LOCK_NO_TAG)
            {
                setStatus("No Tag Response, Lock Operation Failed", Color.Red);
            }
            else if (FailCode.Substring(0, 1) == ConstCode.FAIL_LOCK_ERROR_CODE_BASE.Substring(0, 1))
            {
                setStatus("Lock Failed. Error Code: " + ParseErrCode(failType), Color.Red);
            }
            else if (FailCode == ConstCode.FAIL_KILL_NO_TAG)
            {
                setStatus("No Tag Response, Kill Operation Failed", Color.Red);
            }
            else if (FailCode.Substring(0, 1) == ConstCode.FAIL_KILL_ERROR_CODE_BASE.Substring(0, 1))
            {
                setStatus("Kill Failed. Error Code: " + ParseErrCode(failType), Color.Red);
            }
            else if (FailCode.Substring(0, 1) == ConstCode.FAIL_CUSTOM_CMD_BASE.Substring(0, 1))
            {
                setStatus("Command Executed Failed. Error Code: " + ParseErrCode(failType), Color.Red);
            }
            else if (FailCode == ConstCode.FAIL_INVALID_PARA)
            {
                MessageBox.Show("Invalid Parameters", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (FailCode == ConstCode.FAIL_INVALID_CMD)
            {
                MessageBox.Show("Invalid Command!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (FailCode == ConstCode.FAIL_SUBCMD_UNDEF)
            {
                MessageBox.Show("Invalid Sub Command!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (FailCode == ConstCode.FAIL_MAINCMD_UNDEF)
            {
                MessageBox.Show("Invalid Main Command!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (FailCode == ConstCode.FAIL_COMMAND_CRC)//2019-05-10
            {
                setStatus("API command Crc is Error!", Color.Red);
            }
            else if (FailCode == ConstCode.FAIL_PARAMETER_FAIL)//2019-05-10
            {
                setStatus("Set or Get Reader Parameter is failed!", Color.Red);
            }
            else if (FailCode == ConstCode.FAIL_READER_FAIL)//2019-05-10
            {
                setStatus("Set Reader operation is failed1", Color.Red);
            }
            else if (FailCode == ConstCode.FAIL_TAG_FAIL)//2019-05-10
            {
                setStatus("Access Tag operation is failed!", Color.Red);
            }

        }


        private void rp_PaketOK(Commands.ReaderResponseFrameString rxStrPkts)
        {
            setStatus("", Color.MediumSeaGreen);
            setToolStripStatusMessage1("", Color.Purple);
            if (rxStrPkts.strCmdH == ConstCode.CMD_EXE_FAILED)
            {

            }
            else if (rxStrPkts.strCmdH == ConstCode.CMD_SET_READER_ENV_MODE)
            {
                if (rxStrPkts.strCmdL == "00")
                {
                    setToolStripStatusMessage1("Set Reader Enviorment Mode! (Input)", Color.Purple);
                }
                else if (rxStrPkts.strCmdL == "01")
                {
                    int iEnvModeIndex = Convert.ToInt32(rxStrPkts.strParameters[0]);
                    if (iEnvModeIndex > 2)  // !!!!
                    {
                        setToolStripStatusMessage1("Get Reader Enviorment Mode Error!", Color.Purple);
                    }
                    else
                    {
                        cbxMode.SelectedIndex = iEnvModeIndex;
                        setToolStripStatusMessage1("Get Reader Enviorment Mode! - " + cbxMode.SelectedItem.ToString(), Color.Purple);
                    }
                }
            }
            else if (rxStrPkts.strCmdH == ConstCode.CMD_SET_QUERY_PARA)            //SetQuery
            {
                setToolStripStatusMessage1("Query Parameters has set up!", Color.Purple);
            }
            else if (rxStrPkts.strCmdH == ConstCode.CMD_GET_QUERY_PARA)            //GetQuery
            {
                GetQueryParameter_ResponseMessageProcess(rxStrPkts);
            }
            else if (rxStrPkts.strCmdH == ConstCode.CMD_SET_SELECT_PARA)            //SetSelectTag
            {
                setToolStripStatusMessage1("Select Tag Parameters has set up!", Color.Purple);
            }
            else if (rxStrPkts.strCmdH == ConstCode.CMD_GET_SELECT_PARA)            //GetSelectTag
            {
                GetSelectTagParameter_ResponseMessageProcess(rxStrPkts);
            }
            else if (rxStrPkts.strCmdH == ConstCode.CMD_SINGLE_ID)
            {
                SINGLE_IDResponseMessageProcess(rxStrPkts);
            }
            else if (rxStrPkts.strCmdH == ConstCode.CMD_MULTI_ID)         //Succeed to InvtMulti EPC    
            {
                MULTI_IDResponseMessageProcess(rxStrPkts);
            }
            else if (rxStrPkts.strCmdH == ConstCode.CMD_STOP_MULTI)         //
            {
                string strStatus = rxStrPkts.strParameters[0] + rxStrPkts.strParameters[1] + rxStrPkts.strParameters[2] + rxStrPkts.strParameters[3];
                string strStatus1 = DataConvert.HexToDec(strStatus);

                int ReadTagNumber = Convert.ToInt32(strStatus1);

                this.btnInvtMulti.UseVisualStyleBackColor = true;//2019-04-18
                this.btnInvtMultiEpcTid.UseVisualStyleBackColor = true;
                setStatus("Stop Read Multi-Tag!", Color.MediumSeaGreen);
                setToolStripStatusMessage2("Tag Counter:" + ReadTagNumber.ToString(), Color.MediumBlue);

            }
            else if (rxStrPkts.strCmdH == ConstCode.CMD_READ_DATA)         //Read Tag Memory
            {
                string strInvtReadData = "";
                txtInvtRWData.Text = "";
                txtOperateEpc.Text = "";
                int dataLen = Convert.ToInt32(rxStrPkts.strLength, 16);
                int pcEpcLen = Convert.ToInt32(rxStrPkts.strParameters[0], 16);

                for (int i = 0; i < pcEpcLen; i++)
                {
                    txtOperateEpc.Text += rxStrPkts.strParameters[i + 1] + " ";
                }

                //for (int i = 0; i < dataLen - pcEpcLen - 1; i++)
                dataLen = dataLen - 6;
                dataLen = dataLen - pcEpcLen;
                dataLen = dataLen - 2;// -1;
                for (int i = 0; i < dataLen; i++)
                {
                    strInvtReadData = strInvtReadData + rxStrPkts.strParameters[i + pcEpcLen + 1];
                }
                txtInvtRWData.Text = Commands.AutoAddSpace(strInvtReadData);
                setStatus("Read Memory Success:" + txtInvtRWData.Text, Color.MediumSeaGreen);
            }
            else if (rxStrPkts.strCmdH == ConstCode.CMD_WRITE_DATA)
            {
                getSuccessTagEpc(rxStrPkts.strParameters);
                setStatus("Write Memory Success:" + txtInvtRWData.Text, Color.MediumSeaGreen);
            }
            else if (rxStrPkts.strCmdH == ConstCode.CMD_LOCK_UNLOCK)
            {
                getSuccessTagEpc(rxStrPkts.strParameters);
                setStatus("Lock Success", Color.MediumSeaGreen);
            }
            else if (rxStrPkts.strCmdH == ConstCode.CMD_KILL)
            {
                getSuccessTagEpc(rxStrPkts.strParameters);
                setStatus("Kill Success", Color.MediumSeaGreen);
            }
            else if (rxStrPkts.strCmdH == ConstCode.CMD_IO_CONTROL)
            {
                GPIO_ResponseMessageProcess(rxStrPkts);
            }
            else if (rxStrPkts.strCmdH == ConstCode.CMD_SET_REGION)
            {
                curRegion = GetRegionValueFromUI(cbxRegion.SelectedIndex);
                ChangedRFchannelTableFromFreqRegion(cbxRegion.SelectedIndex);
                setToolStripStatusMessage1("Set RF Region Successed!", Color.Purple);
            }
            else if ((rxStrPkts.strCmdH == ConstCode.CMD_GET_REGION) ||
                    (rxStrPkts.strCmdH == ConstCode.CMD_SET_RF_CHANNEL) ||
                    (rxStrPkts.strCmdH == ConstCode.CMD_GET_RF_CHANNEL) ||
                    (rxStrPkts.strCmdH == ConstCode.CMD_INSERT_FHSS_CHANNEL) ||
                    (rxStrPkts.strCmdH == ConstCode.CMD_SET_FHSS))
            {
                RegionChannelFHSS_ResponseMessageProcess(rxStrPkts);
            }
            else if (rxStrPkts.strCmdH == ConstCode.CMD_SET_POWER)
            {
                setToolStripStatusMessage1("Set Current RF Power is OK!", Color.Purple);
            }
            else if (rxStrPkts.strCmdH == ConstCode.CMD_GET_POWER)
            {
                int rfpwrSel;
                string curPower = rxStrPkts.strParameters[0] + rxStrPkts.strParameters[1];
                rfpwrSel = (int)(Convert.ToInt16(curPower, 16) / 100.0);
                cbxPaPower.SelectedIndex = 30 - rfpwrSel;
                setToolStripStatusMessage1("Current Power is " + (Convert.ToInt16(curPower, 16) / 100.0) + "dBm!", Color.Purple);
            }
            else if (rxStrPkts.strCmdH == ConstCode.CMD_SET_CW)
            {
                string curPower = rxStrPkts.strParameters[0] + rxStrPkts.strParameters[1];
                if (rxStrPkts.strParameters[0] == "00")
                    setToolStripStatusMessage1("CW RF Power is Off! ", Color.Purple);
                else
                    setToolStripStatusMessage1("CW RF Power is On! ", Color.Purple);
            }
            else if (rxStrPkts.strCmdH == ConstCode.CMD_ANT)
            {
                AntResponseMessageProcess(rxStrPkts);
            }
            else if (rxStrPkts.strCmdH == ConstCode.CMD_GET_MODULE_INFO)
            {
                if (checkingReaderAvailable)
                {
                    if (rxStrPkts.strCmdL == ConstCode.MODULE_FIRMWARE_VERSION_SUBCMD)//"01"
                    {
                        string HWMajorVer, HWMinorVer, SWMajorVer, SWMinorVer;
                        HWMajorVer = rxStrPkts.strParameters[0];
                        HWMinorVer = rxStrPkts.strParameters[1];
                        SWMajorVer = rxStrPkts.strParameters[2];
                        SWMinorVer = rxStrPkts.strParameters[3];
                        txtModuleFirmwareVersion.Text = HWMajorVer + "." + HWMinorVer + "." + SWMajorVer + "." + SWMinorVer;
                    }
                    else if (rxStrPkts.strCmdL == ConstCode.READER_FIRMWARE_VERSION_SUBCMD)//"0A"
                    {
                        string HWMajorVer, HWMinorVer, SWMajorVer, SWMinorVer;
                        HWMajorVer = DataConvert.HexToDec(rxStrPkts.strParameters[0]);
                        HWMinorVer = DataConvert.HexToDec(rxStrPkts.strParameters[1]);
                        SWMajorVer = DataConvert.HexToDec(rxStrPkts.strParameters[2]);
                        SWMinorVer = DataConvert.HexToDec(rxStrPkts.strParameters[3]);
                        txtReaderFirmwareVersion.Text = HWMajorVer + "." + HWMinorVer + "." + SWMajorVer + "." + SWMinorVer;
                    }
                    else if (rxStrPkts.strCmdL == ConstCode.READER_RELEASE_DATE_INFO_SUBCMD)//"89"
                    {
                        String releaseDate = string.Empty;
                        try
                        {
                            for (int i = 0; i < Convert.ToInt32(rxStrPkts.strLength, 16) - 1; i++)
                            {
                                releaseDate += (char)Convert.ToInt32(rxStrPkts.strParameters[i], 16);
                            }
                            txtModuleReleaseDate.Text = releaseDate;
                        }
                        catch (System.Exception ex)
                        {
                            txtModuleReleaseDate.Text = "";
                            Console.WriteLine(ex.Message);
                        }
                    }

                    else if (rxStrPkts.strCmdL == ConstCode.MODULE_READER_INFORMATION_SUBCMD)//"00"
                    {
                        if (rxStrPkts.strParameters[0] == ConstCode.MODULE_HARDWARE_VERSION_FIELD)
                        {
                            hardwareVersion = String.Empty;
                            try
                            {
                                for (int i = 0; i < Convert.ToInt32(rxStrPkts.strLength, 16) - 1; i++)
                                {
                                    hardwareVersion += (char)Convert.ToInt32(rxStrPkts.strParameters[1 + i], 16);
                                }
                                if (hardwareVersion.Contains("MU96") == true)//MU961
                                {
                                    CurrentModuleType = 1;
                                }
                                else
                                {
                                    CurrentModuleType = 0;
                                }
                                txtModuleHardwareVersion.Text = hardwareVersion;
                                adjustUIcomponents(hardwareVersion);
                                getFirmwareVersion();
                            }
                            catch (System.Exception ex)
                            {
                                hardwareVersion = rxStrPkts.strParameters[1].Substring(1, 1) + "." + rxStrPkts.strParameters[2];
                                txtModuleHardwareVersion.Text = hardwareVersion;
                                Console.WriteLine(ex.Message);
                            }
                        }
                        else if (rxStrPkts.strParameters[0] == ConstCode.MODULE_SOFTWARE_VERSION_FIELD)
                        {
                            String firmwareVersion = string.Empty;
                            try
                            {
                                for (int i = 0; i < Convert.ToInt32(rxStrPkts.strLength, 16) - 1; i++)
                                {
                                    firmwareVersion += (char)Convert.ToInt32(rxStrPkts.strParameters[1 + i], 16);
                                }
                            }
                            catch (System.Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }

                    }
                }

            }
            else if (rxStrPkts.strCmdH == ConstCode.CMD_READ_ADDR)
            {
                string str10devAddr = DataConvert.HexToDec(rxStrPkts.strParameters[0]);
                int devAddr = Convert.ToInt32(str10devAddr);

                string strdevAddr = devAddr.ToString("D03");
                if (rxStrPkts.strCmdL == ConstCode.READER_OPERATION_SET)
                {
                    cbxNewDeviceAddr.SelectedIndex = devAddr;
                    MessageBox.Show("Set Reader to new Device Address: " + strdevAddr, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    setToolStripStatusMessage1("Set new Reader's Device Address: " + strdevAddr, Color.MediumSeaGreen);
                }
                else if (rxStrPkts.strCmdL == ConstCode.READER_OPERATION_GET)
                {
                    if (devAddr != 0xFF)
                        cbxNewDeviceAddr.SelectedIndex = devAddr;
                    setToolStripStatusMessage1("Get Reader's Device Address: " + strdevAddr, Color.MediumSeaGreen);
                }
            }
            else if (rxStrPkts.strCmdH == ConstCode.CMD_SET_UART_BAUDRATE)
            {
                if (rxStrPkts.strCmdL == ConstCode.READER_OPERATION_SET)
                {
                    setToolStripStatusMessage1("Set Reader's Baud Rate: " + cbxNewBaudRate.Text, Color.MediumSeaGreen);
                    MessageBox.Show("Take effect after reset the Reader!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (rxStrPkts.strCmdL == ConstCode.READER_OPERATION_GET)
                {
                    cbxNewBaudRate.SelectedIndex = Convert.ToInt32(rxStrPkts.strParameters[0]);
                    setToolStripStatusMessage1("Get Reader's Baud Rate: " + cbxNewBaudRate.Text, Color.MediumSeaGreen);
                }
            }
            else if ((rxStrPkts.strCmdH == ConstCode.CMD_Setting_Reader_Work_Mode) || //"61"
                    (rxStrPkts.strCmdH == ConstCode.CMD_Setting_Matched_Tag_Data_Mode) || //"63"
                    (rxStrPkts.strCmdH == ConstCode.CMD_Setting_Beep_Mode) || //"64"
                    (rxStrPkts.strCmdH == ConstCode.CMD_Load_Default_Work_Parameter))//"65"
            {
                ExtCommand_ResponseMessageProcess(rxStrPkts);
            }

        }

        private void rp_PaketReceived(object sender, StrArrEventArgs e)
        {
            string[] packetRx = e.Data;
            string strPacket = string.Empty;
            for (int i = 0; i < packetRx.Length; i++)
            {
                strPacket += packetRx[i] + " ";
            }
            this.Invoke((EventHandler)(delegate
            {
                txtCOMRxCnt.Text = (Convert.ToInt32(txtCOMRxCnt.Text) + packetRx.Length).ToString();
                txtCOMRxCnt_adv.Text = txtCOMRxCnt.Text;

                //auto clear received data region
                int txtReceive_len = txtReceive.Lines.Length; //txtReceive.GetLineFromCharIndex(txtReceive.Text.Length + 1);
                if (cbxAutoClear.Checked)
                {
                    if (txtReceive_len > 9)
                    {
                        txtReceive.Text = string.Empty;
                    }
                }
                //--------------------------------------------------
                int dis;
                //int packetRxLen = Marshal.SizeOf(Commands.ReaderRespFramePacket);//Convert.ToInt16(packetRx[3],10);
                byte[] packetRxHex = new byte[256];//packetRxLen];
                packetRxHex = DataConvert.GetHexBytes(strPacket, out dis);

                Commands.ReaderResponseFrameString rxStrPkts = new Commands.ReaderResponseFrameString(true);
                rxStrPkts = Commands.GetReaderResponsFrameStringStructFromHexBuffer(packetRxHex);
                //Commands.ReaderResponseFrame RdRecv = (Commands.ReaderResponseFrame)RFID_Reader_Cmds.DataConvert.BytesToStruct(packetRxHex, Commands.ReaderRespFramePacket.GetType());
                //---------------------------------------------------- 
                if (rxStrPkts.strStatus == ConstCode.FAIL_OK)
                {
                    rp_PaketOK(rxStrPkts);
                }
                else
                {// rxStrPkts.strStatus
                    rp_PacketFail(rxStrPkts.strStatus, rxStrPkts.strLength, rxStrPkts.strParameters);

                }

                if (cbxRxVisable.Checked == true)
                {
                    if (cbxRxTimeInfor.Checked == true)
                        this.txtReceive.Text = this.txtReceive.Text + "[" + DateTime.Now.ToString("HH:mm:ss:fff") + "]" + strPacket + "\r\n";
                    else
                        this.txtReceive.Text = this.txtReceive.Text + strPacket + "\r\n";
                }

#if TRACE
            //Console.WriteLine("a packet received!");
#endif
            }));
        }
        #endregion




        //-----------------------------------------------------------------
        #region Serial Port connection and download Firmware

        private void getFirmwareVersion()
        {
            Thread.Sleep(100);
            txtSend.Text = Commands.RFID_Q_GetModuleFirmWare(ReaderDeviceAddress);
            RS232SendCommand(txtSend.Text); GetTxTime();

            Thread.Sleep(100);
            txtSend.Text = Commands.RFID_Q_GetReaderFirmWare(ReaderDeviceAddress);
            RS232SendCommand(txtSend.Text); GetTxTime();

            Thread.Sleep(100);
            txtSend.Text = Commands.RFID_Q_GetReaderReleaseDate(ReaderDeviceAddress);
            RS232SendCommand(txtSend.Text); GetTxTime();
        }

        public void checkReaderAvailable()
        {
            if (Sp.GetInstance().IsOpen())
            {
                txtSend.Text = Commands.RFID_Q_StopRead(ReaderDeviceAddress);
                RS232SendCommand(txtSend.Text); GetTxTime();
                Thread.Sleep(200);

                hardwareVersion = "";
                checkingReaderAvailable = true;
                readerConnected = false;

                txtSend.Text = Commands.RFID_Q_GetModuleHardWare(ReaderDeviceAddress);
                RS232SendCommand(txtSend.Text); GetTxTime();

                timerCheckReader.Enabled = true;
            }
        }

        private void cbxDeviceAddr_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReaderDeviceAddress = (byte)cbxDeviceAddr.SelectedIndex;
            Commands.ReaderDeviceAddr = ReaderDeviceAddress;
        }

        private void cbx_dr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbxDR.SelectedIndex == 1)
            {
                MessageBox.Show("Does Not Support DR = 64/3 In this Version", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cbxDR.SelectedIndex = 0;
            }
        }

        private void cbx_m_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbxM.SelectedIndex == 1 || this.cbxM.SelectedIndex == 2 || this.cbxM.SelectedIndex == 3)
            {
                MessageBox.Show("Does Not Support M = 2/4/8 In this Version", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cbxM.SelectedIndex = 0;
            }
        }

        private void cbx_trext_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbxTRext.SelectedIndex == 0)
            {
                MessageBox.Show("Does Not Support No Pilot Tone In this Version", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cbxTRext.SelectedIndex = 1;
            }
        }

        private void radioCommRS232_Click(object sender, EventArgs e)
        {
            txtSendDelay.Text = "60";
            txtRDMultiNum.Text = "0";
            //btnStopRD.Visible = true;
            cbxDeviceAddr.SelectedIndex = 255;
        }

        private void radioCommRS485_Click(object sender, EventArgs e)
        {
            txtSendDelay.Text = "600";
            txtRDMultiNum.Text = "3";
            //btnStopRD.Visible = false;
            cbxDeviceAddr.SelectedIndex = 255;
        }

        private void btnConn_Click(object sender, EventArgs e)
        {
            if (btnConn.Tag.ToString() == "0")
            {
                Sp.GetInstance().Config(cbxPort.SelectedItem.ToString(), Convert.ToInt32(cbxBaudRate.SelectedItem.ToString()), Parity.None, 8, StopBits.One);
                if (!Sp.GetInstance().Open())
                {
                    MessageBox.Show("Open Serial Port Fail!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                btnConn.Text = "Disconnect";
                btnConn.Tag = "1";
                this.btnConn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));

                if (checkBox_WorkMode.Checked == false)// 2021-03-11   When checkBox_WorkMode is selected, DEMO will not send any command to a reader to keep the reader in Polling or Trigger Mode, and listen the API frame from the Polling Reader.
                {
                    bInventoryGoing = false;
                    checkReaderAvailable();
                }
                checkBox_WorkMode.Enabled = false;
            }
            else
            {
                if (checkBox_WorkMode.Checked == false)
                {
                    if (Sp.GetInstance().IsOpen())
                    {
                        if (bAutoSend == true)
                        {
                            bAutoSend = !bAutoSend;
                            timerAutoSend.Enabled = false;
                            btnContinue.Text = "Continue";
                            tmrCheckEpc.Enabled = false;

                            Thread.Sleep(200);
                        }

                        if (bInventoryGoing == true)
                        {
                            txtSend.Text = Commands.RFID_Q_StopRead(ReaderDeviceAddress);
                            RS232SendStopInventory(txtSend.Text); GetTxTime();
                            Thread.Sleep(200);
                            txtSend.Text = Commands.RFID_Q_StopRead(ReaderDeviceAddress);
                            RS232SendStopInventory(txtSend.Text); GetTxTime();

                            tmrCheckEpc.Enabled = false;
                            bInventoryGoing = false;

                            this.btnInvtMulti.UseVisualStyleBackColor = true; //2019-04-18
                            this.btnInvtMultiEpcTid.UseVisualStyleBackColor = true;

                        }
                    }
                }
                if (!Sp.GetInstance().Close())
                {
                    MessageBox.Show("Serial Port Close Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                tmrCheckEpc.Enabled = false;
                bInventoryGoing = false;

                btnConn.Text = "Connect";
                btnConn.Tag = "0";
                this.btnConn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
                checkBox_WorkMode.Enabled = true;

                txtModuleFirmwareVersion.Text = "";
                txtModuleHardwareVersion.Text = "";
                txtReaderFirmwareVersion.Text = "";
                txtModuleReleaseDate.Text = "";
            }
        }

        private void Reset_FW_Click(object sender, EventArgs e)
        {//CMD_TEST_RESET
            txtSend.Text = Commands.RFID_Q_ResetReader(ReaderDeviceAddress);
            RS232SendCommand(txtSend.Text); GetTxTime();

            Thread.Sleep(100);
            if (!Sp.GetInstance().Close())
            {
                MessageBox.Show("Serial Port Close Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnConn.Text = "Connect";
            btnConn.Tag = "0";
            this.btnConn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            checkBox_WorkMode.Enabled = true;
        }


        #endregion



        //-----------------------------------------------------------------
        #region Tag data operator command region

        private String int2HexString(int a)
        {
            byte byte_a = Convert.ToByte(a);
            string str = byte_a.ToString("x").ToUpper();
            str = StringToString(str);
            return str;
        }

        private void cbx_q_basic_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (change_q_1st == false)
            {
                if (bAutoSend == true)
                {
                    MessageBox.Show("Please Stop Continuous Inventory", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (bInventoryGoing == true)
                {
                    MessageBox.Show("Please Stop Read Multi-Tag first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int intDR = this.cbxDR.SelectedIndex;
                int intM = this.cbxM.SelectedIndex;
                int intTRext = this.cbxTRext.SelectedIndex;
                int intSel = this.cbxSel.SelectedIndex;
                int intSession = this.cbxSession.SelectedIndex;

                int intTarget = this.cbxTarget.SelectedIndex;
                int intQ = this.cbxQBasic.SelectedIndex;

                txtSend.Text = Commands.RFID_Q_SetQuery(ReaderDeviceAddress, intDR, intM, intTRext, intSel, intSession, intTarget, intQ);
                RS232SendCommand(txtSend.Text); GetTxTime();
                this.cbxQAdv.SelectedIndex = intQ;
            }
        }

        private void btn_setquery_Click(object sender, EventArgs e)
        {
            int intDR = this.cbxDR.SelectedIndex;
            int intM = this.cbxM.SelectedIndex;
            int intTRext = this.cbxTRext.SelectedIndex;
            int intSel = this.cbxSel.SelectedIndex;
            int intSession = this.cbxSession.SelectedIndex;

            int intTarget = this.cbxTarget.SelectedIndex;
            int intQ = this.cbxQAdv.SelectedIndex;

            txtSend.Text = Commands.RFID_Q_SetQuery(ReaderDeviceAddress, intDR, intM, intTRext, intSel, intSession, intTarget, intQ);
            RS232SendCommand(txtSend.Text); GetTxTime();
        }

        private void btn_getquery_Click(object sender, EventArgs e)
        {
            txtSend.Text = Commands.RFID_Q_GetQuery(ReaderDeviceAddress);
            RS232SendCommand(txtSend.Text); GetTxTime();
        }

        private void ReadTagInital()
        {
            this.cbx_MTR_Algorithm.SelectedIndex = 2;
            this.cbx_MTR_Qvalue.SelectedIndex = 5;

            this.txtSendDelay.Text = "500";
            this.txtRDMultiNum.Text = "0";//  2020-08-18      188";//"65535";
            this.btnStopRD.Visible = true;

            this.cbx_AccessMemBank.SelectedIndex = 5;   //2021-03-01
        }
        private bool bInventoryGoing = false;// doing the inventory multi-tag...
        private long lDateTime_StartToReadMultiTag = 0;
        private long lDateTime_TagNumberToBeRead = 0;
        private bool bTagNumberToTimerReady = false;

        private void btn_invt2_Click(object sender, EventArgs e)
        {
            if (bAutoSend == true)
            {
                MessageBox.Show("Please Stop Continuous Inventory", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (bInventoryGoing == true)
            {
                MessageBox.Show("Please Stop Read Multi-Tag first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoopNum_cnt = LoopNum_cnt + 1;
            txtSend.Text = Commands.RFID_Q_ReadSingle(ReaderDeviceAddress);
            RS232SendCommand(txtSend.Text); GetTxTime();
        }

        private void btn_invt_Click(object sender, EventArgs e)
        {
            if (bAutoSend == true)
            {
                MessageBox.Show("Please Stop Continuous Inventory", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (bInventoryGoing == true)
            {
                MessageBox.Show("Please Stop Read Multi-Tag first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            LoopNum_cnt = LoopNum_cnt + 1;
            txtSend.Text = Commands.RFID_Q_ReadSingle(ReaderDeviceAddress);
            RS232SendCommand(txtSend.Text); GetTxTime();
        }

        private void GetInventoryTagNumberTimer() //2021-09-07
        {
            long lTagNumberElapsedTime = 0;
            int nTagNumberTotal = Convert.ToInt16(textBox_EPC_Tag_Total.Text);
            int nTagNumberToTimer = Convert.ToInt16(txt_TagNumberToStopTimer.Text);
            if (bTagNumberToTimerReady == false && nTagNumberToTimer != 0)
            {
                if (nTagNumberTotal >= nTagNumberToTimer)
                {
                    bTagNumberToTimerReady = true;
                    lDateTime_TagNumberToBeRead = GetSysTickMsTime();
                    lTagNumberElapsedTime = lDateTime_TagNumberToBeRead - lDateTime_StartToReadMultiTag;
                    txt_TagNumberToTimeValue.Text = lTagNumberElapsedTime.ToString();
                }
            }
        }

        private void btn_invt_multi_Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Note：1. 485 interface, Advise Num value 1 ~ 100.\r\n   2. 485 interface, No 'Stop Read'.\r\n   3. 485 interface, Do not execute other commands until 'Read Multi-Tag' return.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_stop_rd_Click(object sender, EventArgs e)
        {
            if (bAutoSend == true)
            {
                MessageBox.Show("Please Stop Continuous Inventory", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            txtSend.Text = Commands.RFID_Q_StopRead(ReaderDeviceAddress);
            RS232SendStopInventory(txtSend.Text); GetTxTime();
            Thread.Sleep(200);
            txtSend.Text = Commands.RFID_Q_StopRead(ReaderDeviceAddress);
            RS232SendStopInventory(txtSend.Text); GetTxTime();

            tmrCheckEpc.Enabled = false;
            bInventoryGoing = false;
            this.btnInvtMulti.UseVisualStyleBackColor = true; //2019-04-18
            this.btnInvtMultiEpcTid.UseVisualStyleBackColor = true;
        }

        private void InvtMulti_AutoClear()  //2022-01-10
        {
            if (checkBox_InvtMulti_AutoClear.Checked == true)
            {
                btn_clear_basictable_Click(null, null);
                btn_clear_rx_Click(null, null);
                txt_TagNumberToTimeValue.Text = "0"; //2021-09-07
                bTagNumberToTimerReady = false;
                lDateTime_StartToReadMultiTag = GetSysTickMsTime();
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (bInventoryGoing == true)
            {
                MessageBox.Show("Please Stop Read Multi-Tag first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Sp.GetInstance().IsOpen() == true)
            {
                bAutoSend = !bAutoSend;
                if (bAutoSend)
                {
                    timerAutoSend.Interval = Convert.ToInt32(txtSendDelay.Text);
                    timerAutoSend.Enabled = true;
                    txtSend.Text = Commands.RFID_Q_ReadSingle(ReaderDeviceAddress);
                    btnContinue.Text = "Stop";
                    tmrCheckEpc.Enabled = true;
                }
                else
                {
                    timerAutoSend.Interval = Convert.ToInt32(txtSendDelay.Text);
                    timerAutoSend.Enabled = false;
                    btnContinue.Text = "Continue";
                    tmrCheckEpc.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Please Connect Serial Port！", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void timerAutoSend_Tick(object sender, EventArgs e)
        {
            LoopNum_cnt = LoopNum_cnt + 1;
            try
            {
                if (Sp.GetInstance().Send(txtSend.Text) == 0)
                {
                    bAutoSend = false;
                    timerAutoSend.Enabled = false;
                    btnContinue.Text = "Continue";
                }
            }
            catch (System.Exception ex)
            {
                bAutoSend = false;
                timerAutoSend.Enabled = false;
                btnContinue.Text = "Continue";
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void cbxMemBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxMemBank.SelectedIndex)
            {
                case 0:
                    {
                        txtWordPtr0.Text = "00";
                        txtWordPtr1.Text = "00";
                        txtWordCnt0.Text = "04";
                        txtWordCnt1.Text = "00";
                        setToolStripStatusMessage1("RFU Bank is reserve for future!", Color.DeepPink);
                    }
                    break;
                case 1:
                    {
                        txtWordPtr0.Text = "02";
                        txtWordPtr1.Text = "00";
                        txtWordCnt0.Text = "06";
                        txtWordCnt1.Text = "00";
                        setToolStripStatusMessage1("EPC ID Data is start from word pointer 0x02 with 0x06 word length normally!", Color.DeepPink);
                        setToolStripStatusMessage2("0x00=CRC,0x01=PC,0x02~0x07=EPC", Color.DeepSkyBlue);
                    }
                    break;
                case 2:
                    {
                        txtWordPtr0.Text = "00";
                        txtWordPtr1.Text = "00";
                        txtWordCnt0.Text = "06";
                        txtWordCnt1.Text = "00";
                        setToolStripStatusMessage1("TID Bank is 4 word length normally!", Color.DeepPink);
                    }
                    break;
                case 3:
                    {
                        txtWordPtr0.Text = "00";
                        txtWordPtr1.Text = "00";
                        txtWordCnt0.Text = "02";
                        txtWordCnt1.Text = "00";
                        setToolStripStatusMessage1("Some Tag has no USER Bank!", Color.DeepPink);
                    }
                    break;

            }
        }

        private void checkBox_InvtMulti_AutoClear_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_InvtMulti_AutoClear.Checked == true)
            {
                txt_TagNumberToStopTimer.Enabled = true;
                lbl_TagNumberToStopTimer.Enabled = true;
            }
            else
            {
                txt_TagNumberToStopTimer.Enabled = false;
                lbl_TagNumberToStopTimer.Enabled = false;
            }

        }

        private void btn_invt_multi_Click(object sender, EventArgs e)
        {
            if (bAutoSend == true)
            {
                MessageBox.Show("Please Stop Continuous Inventory", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (bInventoryGoing == true)
            {
                MessageBox.Show("Please Stop Read Multi-Tag first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            InvtMulti_AutoClear(); //2022-01-10
            int loopCnt = Convert.ToInt32(txtRDMultiNum.Text);

            txtSend.Text = Commands.RFID_Q_ReadMulti(ReaderDeviceAddress, (byte)cbx_MTR_Algorithm.SelectedIndex, (byte)cbx_MTR_Qvalue.SelectedIndex, loopCnt);
            RS232SendCommand(txtSend.Text); GetTxTime();
            tmrCheckEpc.Enabled = true;
            bInventoryGoing = true;

            this.btnInvtMulti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));//2019-04-18
        }

        private void btnInvtMultiEpcTid_Click(object sender, EventArgs e) // //2021-03-01
        {
            if (bAutoSend == true)
            {
                MessageBox.Show("Please Stop Continuous Inventory", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (bInventoryGoing == true)
            {
                MessageBox.Show("Please Stop Read Multi-Tag first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            InvtMulti_AutoClear(); //2022-01-10

            string strAccessPasswd = txtEpcAccessMemBankAccessPwd.Text.Replace(" ", "");
            if (strAccessPasswd.Length != 8)
            {
                MessageBox.Show("Access password should be two words!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            uint iAccessPasswd = Convert.ToUInt32(strAccessPasswd);
            string strAccessMemBankStartAddr = txtInvEPC_AccessMemBankStartAddr.Text.Replace(" ", "");
            string strAccessExUserMemBankStartAddr = txtInvEPC_AccessExUserMemBankStartAddrEx.Text.Replace(" ", "");

            int loopCnt = Convert.ToInt32(txtRDMultiNum.Text);

            // Inventory Algorithm:  //2022-04-21
            // 0x10(10)  0x11(11)  0x12(12)  EPC+EPC
            // 0x20(20)  0x21(21)  0x22(22)  EPC+TID
            // 0x30(30)  0x31(31)  0x32(32)  EPC+USER
            // 0x40(40)  0x41(41)  0x42(42)  EPC+TID+USER
            byte yAccessMemBankAlgorithm = 0x22;
            switch (cbx_AccessMemBank.SelectedIndex)
            {
                case 0:
                    yAccessMemBankAlgorithm = (byte)ConstCode.Inventory_Tag_Alg_code.Inventory_Tag_Alg_EPC_EPC_10;
                    break;
                case 1:
                    yAccessMemBankAlgorithm = (byte)ConstCode.Inventory_Tag_Alg_code.Inventory_Tag_Alg_EPC_EPC_11;
                    break;
                case 2:
                    yAccessMemBankAlgorithm = (byte)ConstCode.Inventory_Tag_Alg_code.Inventory_Tag_Alg_EPC_EPC_12;
                    break;
                case 3:
                    yAccessMemBankAlgorithm = (byte)ConstCode.Inventory_Tag_Alg_code.Inventory_Tag_Alg_EPC_TID_20;
                    break;
                case 4:
                    yAccessMemBankAlgorithm = (byte)ConstCode.Inventory_Tag_Alg_code.Inventory_Tag_Alg_EPC_TID_21;
                    break;
                case 5:
                    yAccessMemBankAlgorithm = (byte)ConstCode.Inventory_Tag_Alg_code.Inventory_Tag_Alg_EPC_TID_22;
                    break;
                case 6:
                    yAccessMemBankAlgorithm = (byte)ConstCode.Inventory_Tag_Alg_code.Inventory_Tag_Alg_EPC_USER_30;
                    break;
                case 7:
                    yAccessMemBankAlgorithm = (byte)ConstCode.Inventory_Tag_Alg_code.Inventory_Tag_Alg_EPC_USER_31;
                    break;
                case 8:
                    yAccessMemBankAlgorithm = (byte)ConstCode.Inventory_Tag_Alg_code.Inventory_Tag_Alg_EPC_USER_32;
                    break;
                case 9:
                    yAccessMemBankAlgorithm = (byte)ConstCode.Inventory_Tag_Alg_code.Inventory_Tag_Alg_EPC_TID_USER_40;
                    break;
                case 10:
                    yAccessMemBankAlgorithm = (byte)ConstCode.Inventory_Tag_Alg_code.Inventory_Tag_Alg_EPC_TID_USER_41;
                    break;
                case 11:
                    yAccessMemBankAlgorithm = (byte)ConstCode.Inventory_Tag_Alg_code.Inventory_Tag_Alg_EPC_TID_USER_42;
                    break;
                default:
                    yAccessMemBankAlgorithm = (byte)ConstCode.Inventory_Tag_Alg_code.Inventory_Tag_Alg_EPC_TID_22;
                    break;
            }
            int iAccessMemBankStartAddr = Convert.ToInt32(strAccessMemBankStartAddr, 16);
            byte yAccessMemBankByteLength = (byte)Convert.ToInt32(txtInvEPC_AccessMemBankWordLength.Text);

            int iAccessExUserMemBankStartAddr = Convert.ToInt32(strAccessExUserMemBankStartAddr, 16);
            byte yAccessExUserMemBankByteLength = (byte)Convert.ToInt32(txtInvEPC_AccessExUserMemBankWordLength.Text);

            if (yAccessMemBankAlgorithm <= (byte)ConstCode.Inventory_Tag_Alg_code.Inventory_Tag_Alg_EPC_USER_32)
                txtSend.Text = Commands.RFID_Q_ReadMultiEpcAccess(ReaderDeviceAddress, yAccessMemBankAlgorithm, (byte)cbx_MTR_Qvalue.SelectedIndex, loopCnt, iAccessMemBankStartAddr, yAccessMemBankByteLength, iAccessPasswd);
            else
                txtSend.Text = Commands.RFID_Q_ReadMultiEpcAccessEx(ReaderDeviceAddress, yAccessMemBankAlgorithm, (byte)cbx_MTR_Qvalue.SelectedIndex, loopCnt, iAccessMemBankStartAddr, yAccessMemBankByteLength,
                                                                    iAccessExUserMemBankStartAddr, yAccessExUserMemBankByteLength, iAccessPasswd); //2022-04-21
            RS232SendCommand(txtSend.Text); GetTxTime();
            tmrCheckEpc.Enabled = true;
            bInventoryGoing = true;

            this.btnInvtMultiEpcTid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));//2020-11-21
        }

        private void cbx_AccessMemBank_SelectedIndexChanged(object sender, EventArgs e)//2022-04-21
        {
            if (cbx_AccessMemBank.SelectedIndex >= 9 && cbx_AccessMemBank.SelectedIndex <= 11)
            {
                txtInvEPC_AccessExUserMemBankStartAddrEx.Enabled = true;
                txtInvEPC_AccessExUserMemBankWordLength.Enabled = true;
            }
            else
            {
                txtInvEPC_AccessExUserMemBankStartAddrEx.Enabled = false;
                txtInvEPC_AccessExUserMemBankWordLength.Enabled = false;
            }
        }

        private void btn_AccessMemBankHelp_Click(object sender, EventArgs e)   //2021-12-28
        {
            MessageBox.Show("Need supported by customized firmware!",
                "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }


        private void select()
        {
            if (Sp.GetInstance().IsOpen() == false)
            {
                return;
            }
            int intSelTarget = this.cbxSelTarget.SelectedIndex;
            int intAction = this.cbxAction.SelectedIndex;
            int intSelMemBank = this.cbxSelMemBank.SelectedIndex;

            int intSelPointer = Convert.ToInt32((txtSelPrt3.Text + txtSelPrt2.Text + txtSelPrt1.Text + txtSelPrt0.Text), 16);
            int intMaskLen = Convert.ToInt32(txtSelLength.Text, 16);
            int intSelDataMSB = intSelMemBank + intAction * 4 + intSelTarget * 32;
            int intTruncate = 0;

            Sp.GetInstance().Send(Commands.RFID_Q_SetSelect(ReaderDeviceAddress, intSelTarget, intAction, intSelMemBank, intSelPointer, intMaskLen, intTruncate, txtSelMask.Text));
            Thread.Sleep(200);
        }

        private void btn_invtread_Click(object sender, EventArgs e)
        {
            if (bAutoSend == true)
            {
                MessageBox.Show("Please Stop Continuous Inventory", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (bInventoryGoing == true)
            {
                MessageBox.Show("Please Stop Read Multi-Tag first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            string strAccessPasswd = txtRwAccPassWord.Text.Replace(" ", "");
            if (strAccessPasswd.Length != 8)
            {
                MessageBox.Show("Access password should be two words!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int wordPtr = Convert.ToInt32((txtWordPtr1.Text.Replace(" ", "") + txtWordPtr0.Text.Replace(" ", "")), 16);
            int wordCnt = Convert.ToInt32((txtWordCnt1.Text.Replace(" ", "") + txtWordCnt0.Text.Replace(" ", "")), 16);

            int intMemBank = cbxMemBank.SelectedIndex;

            select();
            Thread.Sleep(200);

            txtSend.Text = Commands.RFID_Q_ReadData(ReaderDeviceAddress, strAccessPasswd, intMemBank, wordPtr, wordCnt);
            RS232SendCommand(txtSend.Text); GetTxTime();

        }

        private void btnSetSelect_Click(object sender, EventArgs e)
        {
            int intSelTarget = this.cbxSelTarget.SelectedIndex;
            int intAction = this.cbxAction.SelectedIndex;
            int intSelMemBank = this.cbxSelMemBank.SelectedIndex;

            int intSelPointer = Convert.ToInt32((txtSelPrt3.Text + txtSelPrt2.Text + txtSelPrt1.Text + txtSelPrt0.Text), 16);
            int intMaskLen = Convert.ToInt32(txtSelLength.Text, 16);
            int intSelDataMSB = intSelMemBank + intAction * 4 + intSelTarget * 32;
            int intTruncate = 0;
            if (this.ckxTruncated.Checked == true)
            {
                intTruncate = 0x80;
            }

            txtSend.Text = Commands.RFID_Q_SetSelect(ReaderDeviceAddress, intSelTarget, intAction, intSelMemBank, intSelPointer, intMaskLen, intTruncate, txtSelMask.Text);
            RS232SendCommand(txtSend.Text); GetTxTime();
            //inv_mode.Checked = true;
        }

        private void btnGetSelect_Click(object sender, EventArgs e)
        {
            txtSend.Text = Commands.RFID_Q_GetSelect(ReaderDeviceAddress);
            RS232SendCommand(txtSend.Text); GetTxTime();
        }

        private void btnInvtWrtie_Click(object sender, EventArgs e)
        {
            if (bAutoSend == true)
            {
                MessageBox.Show("Please Stop Continuous Inventory", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (bInventoryGoing == true)
            {
                MessageBox.Show("Please Stop Read Multi-Tag first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            string strAccessPasswd = txtRwAccPassWord.Text.Replace(" ", "");
            if (strAccessPasswd.Length != 8)
            {
                MessageBox.Show("Access password should be two words!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string strDate4Write = txtInvtRWData.Text.Replace(" ", "");

            int intMemBank = cbxMemBank.SelectedIndex;
            int wordPtr = Convert.ToInt32((txtWordPtr1.Text.Replace(" ", "") + txtWordPtr0.Text.Replace(" ", "")), 16);
            int wordCnt = strDate4Write.Length / 4; // in word!

            if (strDate4Write.Length % 4 != 0)
            {
                MessageBox.Show("The Write Data's Length Should Be Integer Multiples Words", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //if (strDate4Write.Length > 16 * 4)
            //{
            //    MessageBox.Show("Write Data Length Limit is 16 Words", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            select();
            Thread.Sleep(200);

            txtSend.Text = Commands.RFID_Q_WriteData(ReaderDeviceAddress, strAccessPasswd, intMemBank, wordPtr, wordCnt, strDate4Write);
            RS232SendCommand(txtSend.Text); GetTxTime();

        }

        private void buttonLock_Click(object sender, EventArgs e)
        {
            if (bAutoSend == true)
            {
                MessageBox.Show("Please Stop Continuous Inventory", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (bInventoryGoing == true)
            {
                MessageBox.Show("Please Stop Read Multi-Tag first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textBoxLockAccessPwd.Text.Length == 0) return;

            select();

            int lockPayload = buildLockPayload();
            txtSend.Text = Commands.RFID_Q_Lock(ReaderDeviceAddress, textBoxLockAccessPwd.Text, lockPayload);
            RS232SendCommand(txtSend.Text); GetTxTime();
        }

        private int buildLockPayload()
        {
            int ld = 0;
            Commands.lock_payload_type payload;
            if (checkBoxKillPwd.Checked)
            {
                payload = Commands.genLockPayload((byte)cbxLockKillAction.SelectedIndex, 0x00);
                ld |= (payload.byte0 << 16) | (payload.byte1 << 8) | (payload.byte2);
            }
            if (checkBoxAccessPwd.Checked)
            {
                payload = Commands.genLockPayload((byte)cbxLockAccessAction.SelectedIndex, 0x01);
                ld |= (payload.byte0 << 16) | (payload.byte1 << 8) | (payload.byte2);
            }
            if (checkBoxEPC.Checked)
            {
                payload = Commands.genLockPayload((byte)cbxLockEPCAction.SelectedIndex, 0x02);
                ld |= (payload.byte0 << 16) | (payload.byte1 << 8) | (payload.byte2);
            }
            if (checkBoxTID.Checked)
            {
                payload = Commands.genLockPayload((byte)cbxLockTIDAction.SelectedIndex, 0x03);
                ld |= (payload.byte0 << 16) | (payload.byte1 << 8) | (payload.byte2);
            }
            if (checkBoxUser.Checked)
            {
                payload = Commands.genLockPayload((byte)cbxLockUserAction.SelectedIndex, 0x04);
                ld |= (payload.byte0 << 16) | (payload.byte1 << 8) | (payload.byte2);
            }
            return ld;
        }

        private void buttonKill_Click(object sender, EventArgs e)
        {
            if (bAutoSend == true)
            {
                MessageBox.Show("Please Stop Continuous Inventory", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (bInventoryGoing == true)
            {
                MessageBox.Show("Please Stop Read Multi-Tag first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textBoxKillPwd.Text.Length == 0) return;

            string strKillPasswd = textBoxKillPwd.Text.Replace(" ", "");
            if (strKillPasswd.Length != 8)
            {
                MessageBox.Show("Kill password should be two words!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int killRfu = 0;
            string strKillRfu = textBoxKillRFU.Text.Replace(" ", "");
            if (strKillRfu.Length == 0)
            {
                killRfu = 0;
            }
            else if (strKillRfu.Length != 3)
            {
                MessageBox.Show("Kill RFU/Recom should be 3 bits!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                try
                {
                    killRfu = Convert.ToInt32(strKillRfu, 2);
                }
                catch (System.Exception ex)
                {
                    Console.WriteLine("Convert Kill RFU fail." + ex.Message);
                    MessageBox.Show("Kill RFU/Recom should be 3 bits!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            select();

            txtSend.Text = Commands.RFID_Q_Kill(ReaderDeviceAddress, strKillPasswd, killRfu);
            RS232SendCommand(txtSend.Text); GetTxTime();
        }

        private void inv_mode_CheckedChanged(object sender, EventArgs e)
        {
            if (inv_mode.Checked)
            {
                txtSend.Text = Commands.RFID_Q_SetInventoryMode(ReaderDeviceAddress, ConstCode.INVENTORY_MODE0);  //INVENTORY_MODE0
            }
            else
            {
                txtSend.Text = Commands.RFID_Q_SetInventoryMode(ReaderDeviceAddress, ConstCode.INVENTORY_MODE1);  //INVENTORY_MODE1
            }
            RS232SendCommand(txtSend.Text); GetTxTime();
        }

        private void ckxTruncated_CheckedChanged(object sender, EventArgs e)
        {
            if (ckxTruncated.Checked)
            {
                int intSelTarget = this.cbxSelTarget.SelectedIndex;
                int intSelMemBank = this.cbxSelMemBank.SelectedIndex;
                if (intSelTarget != 4 || intSelMemBank != 1)
                {
                    MessageBox.Show("Select Target should be 100 and MemBank should be EPC", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ckxTruncated.Checked = false;
                }
            }
        }

        #endregion


        //-----------------------------------------------------------------
        #region Reader parameter operate command

        private void btnSetMode_Click(object sender, EventArgs e)
        {
            txtSend.Text = Commands.RFID_Q_SetReaderEnvMode(ReaderDeviceAddress, (byte)cbxMode.SelectedIndex);
            RS232SendCommand(txtSend.Text); GetTxTime();
        }

        private void btnGetMode_Click(object sender, EventArgs e)  //2021-12-28
        {
            txtSend.Text = Commands.RFID_Q_GetReaderEnvMode(ReaderDeviceAddress);
            RS232SendCommand(txtSend.Text); GetTxTime();
        }

        private void btnSaveConfigToNv_Click(object sender, EventArgs e)
        {
            byte NV_enable = cbxSaveNvConfig.Checked ? (byte)0x01 : (byte)0x00;
            txtSend.Text = Commands.RFID_Q_SaveConfigToNv(ReaderDeviceAddress, NV_enable);
            RS232SendCommand(txtSend.Text); GetTxTime();
        }

        private void btnSetModuleSleep_Click(object sender, EventArgs e)
        {
            txtSend.Text = Commands.RFID_Q_SetModuleSleep(ReaderDeviceAddress);
            RS232SendCommand(txtSend.Text); GetTxTime();
        }

        private string curRegion = ConstCode.REGION_CODE_CHN2;
        private string hardwareVersion;
        private bool checkingReaderAvailable = false;
        private bool readerConnected;
        private string GetRegionValueFromUI(int IndexRegeion)
        {
            string strRegion;
            switch (IndexRegeion)
            {
                case 0:	 // China 2
                    strRegion = ConstCode.REGION_CODE_CHN2;
                    break;
                case 1:	 // China 1
                    strRegion = ConstCode.REGION_CODE_CHN1;
                    break;
                case 2:	// US
                    strRegion = ConstCode.REGION_CODE_US;
                    break;
                case 3:	 // Europe
                    strRegion = ConstCode.REGION_CODE_EUR;
                    break;
                case 4:	 // Korea
                    strRegion = ConstCode.REGION_CODE_KOREA;
                    break;
                case 5:	 // Singapore
                    strRegion = ConstCode.REGION_CODE_SINGASINGAPORE;
                    break;
                case 6:	 // SouthAfrica   //2021-04-25
                    strRegion = ConstCode.REGION_CODE_SOUTHAFRICA;
                    break;
                case 7:	 // Malaysia   //2021-12-06
                    strRegion = ConstCode.REGION_CODE_MALAYSIA;
                    break;
                default:
                    strRegion = ConstCode.REGION_CODE_CHN2;
                    break;
            }
            return strRegion;
        }

        private void btnSetRegion_Click(object sender, EventArgs e)
        {
            curRegion = GetRegionValueFromUI(cbxRegion.SelectedIndex);
            txtSend.Text = Commands.RFID_Q_SetRegion(ReaderDeviceAddress, curRegion);
            RS232SendCommand(txtSend.Text); GetTxTime();
            cbxChannel.SelectedIndex = 0;
        }

        private void btnGetRegion_Click(object sender, EventArgs e)
        {
            txtSend.Text = Commands.RFID_Q_GetRegion(ReaderDeviceAddress);
            RS232SendCommand(txtSend.Text); GetTxTime();
        }

        private void ChangedRFchannelTableFromFreqRegion(int IndexFreqRegion)
        {//2019-01-26
            string strIndex;
            cbxChannel.Items.Clear();
            switch (IndexFreqRegion)
            {
                case 0: // China 2
                    for (int i = 0; i < 20; i++)
                    {
                        strIndex = i.ToString("D2") + "-";
                        this.cbxChannel.Items.Add(strIndex + (920.125 + i * 0.25).ToString() + "MHz");
                    }
                    break;
                case 1: // China 1
                    for (int i = 0; i < 20; i++)
                    {
                        strIndex = i.ToString("D2") + "-";
                        this.cbxChannel.Items.Add(strIndex + (840.125 + i * 0.25).ToString() + "MHz");
                    }
                    break;
                case 2: // US
                    for (int i = 0; i < 52; i++)
                    {
                        strIndex = i.ToString("D2") + "-";
                        this.cbxChannel.Items.Add(strIndex + (902.25 + i * 0.5).ToString() + "MHz");
                    }
                    break;
                case 3: // Europe
                    for (int i = 0; i < 15; i++)
                    {
                        strIndex = i.ToString("D2") + "-";
                        this.cbxChannel.Items.Add(strIndex + (865.1 + i * 0.2).ToString() + "MHz");
                    }
                    break;
                case 4:  // Korea
                    for (int i = 0; i < 32; i++)
                    {
                        strIndex = i.ToString("D2") + "-";
                        this.cbxChannel.Items.Add(strIndex + (917.1 + i * 0.2).ToString() + "MHz");
                    }
                    break;
                case 5: // Singapore
                    for (int i = 0; i < 12; i++)
                    {
                        strIndex = i.ToString("D2") + "-";
                        this.cbxChannel.Items.Add(strIndex + (923.125 + i * 0.25).ToString() + "MHz");
                    }
                    break;
                case 6: // SouthAfrica
                    for (int i = 0; i < 19; i++)
                    {
                        strIndex = i.ToString("D2") + "-";
                        this.cbxChannel.Items.Add(strIndex + (915.4 + i * 0.2).ToString("F2") + "MHz");
                    }
                    break;
                case 7: // Malaysia   //2021-12-06
                    for (int i = 0; i < 8; i++)
                    {
                        strIndex = i.ToString("D2") + "-";
                        this.cbxChannel.Items.Add(strIndex + (919.25 + i * 0.5).ToString("F2") + "MHz");
                    }
                    break;
                default:
                    break;
            }
            cbxChannel.SelectedIndex = 0;
        }

        private void cbxRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*cbxChannel.Items.Clear(); 
            switch (cbxRegion.SelectedIndex)
            {
                case 0 : // China 2
                    for (int i = 0; i < 20; i++)
                    {
                        this.cbxChannel.Items.Add((920.125 + i * 0.25).ToString() + "MHz");
                    }
            	    break;
                case 1: // China 1
                    for (int i = 0; i < 20; i++)
                    {
                        this.cbxChannel.Items.Add((840.125 + i * 0.25).ToString() + "MHz");
                    }
                    break;
                case 2: // US
                    for (int i = 0; i < 52; i++)
                    {
                        this.cbxChannel.Items.Add((902.25 + i * 0.5).ToString() + "MHz");
                    }
                    break;
                case 3: // Europe
                    for (int i = 0; i < 15; i++)
                    {
                        this.cbxChannel.Items.Add((865.1 + i * 0.2).ToString() + "MHz");
                    }
                        break;
                case 4:  // Korea
                        for (int i = 0; i < 32; i++)
                        {
                            this.cbxChannel.Items.Add((917.1 + i * 0.2).ToString() + "MHz");
                        }
                        break;
                default :
                        break;
            }  */
            ChangedRFchannelTableFromFreqRegion(cbxRegion.SelectedIndex);
            cbxChannel.SelectedIndex = 0;
        }

        private void btnGetChannel_Click(object sender, EventArgs e)
        {
            if (bAutoSend == true)
            {
                MessageBox.Show("Please Stop Continuous Inventory", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (bInventoryGoing == true)
            {
                MessageBox.Show("Please Stop Read Multi-Tag first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnGetRegion_Click(null, null);// Get Region firstly;
            Thread.Sleep(200);

            txtSend.Text = Commands.RFID_Q_GetRfChannel(ReaderDeviceAddress);
            RS232SendCommand(txtSend.Text); GetTxTime();
        }

        private void btnSetFhss_Click(object sender, EventArgs e)
        {
            if (cbxFHSS.SelectedIndex != 0)
            {
                txtSend.Text = Commands.RFID_Q_SetFhss(ReaderDeviceAddress, ConstCode.SET_ON);
            }
            else
            {
                txtSend.Text = Commands.RFID_Q_SetFhss(ReaderDeviceAddress, ConstCode.SET_OFF);
            }
            RS232SendCommand(txtSend.Text); GetTxTime();

        }

        private void btnGetFhss_Click(object sender, EventArgs e)
        {
            txtSend.Text = Commands.RFID_Q_GetFhss(ReaderDeviceAddress);
            RS232SendCommand(txtSend.Text); GetTxTime();
        }

        private void btnSetFreqHopPeriod_Click(object sender, EventArgs e)
        {
            ushort FhssPeriod = (ushort)((cbxFhssHopPeriod.SelectedIndex + 1) * 100);
            txtSend.Text = Commands.RFID_Q_SetFhssPeriod(ReaderDeviceAddress, FhssPeriod);
            RS232SendCommand(txtSend.Text); GetTxTime();
        }

        private void btnGetFreqHopPeriod_Click(object sender, EventArgs e)
        {
            txtSend.Text = Commands.RFID_Q_GetFhssPeriod(ReaderDeviceAddress);
            RS232SendCommand(txtSend.Text); GetTxTime();
        }


        private void btnInsertRfCh_Click(object sender, EventArgs e)
        {
            byte[] channelList;
            int chIndexBegin = Convert.ToInt32(txtChIndexBegin.Text);
            int chIndexEnd = Convert.ToInt32(txtChIndexEnd.Text);
            byte channelNum = (byte)(chIndexEnd - chIndexBegin + 1);
            if (chIndexBegin > chIndexEnd)
            {
                MessageBox.Show("Insert parameter is invalid!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            channelList = new byte[channelNum];
            for (int i = chIndexBegin; i <= chIndexEnd; i++)
            {
                channelList[i - chIndexBegin] = (byte)i;
            }
            txtSend.Text = Commands.RFID_Q_InsertRfCh(ReaderDeviceAddress, channelNum, channelList);
            RS232SendCommand(txtSend.Text); GetTxTime();
        }

        private void btnInsertRfCh_Get_Click(object sender, EventArgs e)
        {
            txtSend.Text = Commands.RFID_Q_GetInrRfCh(ReaderDeviceAddress);
            RS232SendCommand(txtSend.Text); GetTxTime();
        }

        private void btnInsertRfCh_Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. \"Set Region\" to Cancel the  Insert RF Channel!\r\n2. FHSS=\"ON\"!",
                "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }


        private void btnSetPaPower_Click(object sender, EventArgs e)
        {
            int powerDBm = 0;
            float powerFloat = 0;
            try
            {
                powerFloat = float.Parse(cbxPaPower.SelectedItem.ToString().Replace("dBm", ""));
                powerDBm = (int)(powerFloat * 100);
            }
            catch (Exception formatException)
            {
                Console.WriteLine(formatException.ToString());
                switch (cbxPaPower.SelectedIndex)
                {
                    case 5:
                        powerDBm = 1250;
                        break;
                    case 4:
                        powerDBm = 1400;
                        break;
                    case 3:
                        powerDBm = 1550;
                        break;
                    case 2:
                        powerDBm = 1700;
                        break;
                    case 1:
                        powerDBm = 1850;
                        break;
                    case 0:
                        powerDBm = 2000;
                        break;
                    default:
                        powerDBm = 2000;
                        break;
                }
            }
            txtSend.Text = Commands.RFID_Q_SetPaPower(ReaderDeviceAddress, (Int16)powerDBm);
            RS232SendCommand(txtSend.Text); GetTxTime();
        }

        private void btnGetPaPower_Click(object sender, EventArgs e)
        {
            txtSend.Text = Commands.RFID_Q_GetPaPower(ReaderDeviceAddress);
            RS232SendCommand(txtSend.Text); GetTxTime();
        }

        private void btnSetFreq_Click(object sender, EventArgs e)
        {
            txtSend.Text = Commands.RFID_Q_SetRfChannel(ReaderDeviceAddress, cbxChannel.SelectedIndex.ToString("X2"));
            RS232SendCommand(txtSend.Text); GetTxTime();
        }

        private void btnSetCW_Click(object sender, EventArgs e)
        {
            if (btnSetCW.Text == "CW ON")
            {
                txtSend.Text = Commands.RFID_Q_SetCW(ReaderDeviceAddress, ConstCode.SET_ON);
            }
            else
            {
                txtSend.Text = Commands.RFID_Q_SetCW(ReaderDeviceAddress, ConstCode.SET_OFF);
            }
            RS232SendCommand(txtSend.Text); GetTxTime();

            if (btnSetCW.Text == "CW ON")
            {
                btnSetCW.Text = "CW OFF";
            }
            else
            {
                btnSetCW.Text = "CW ON";
            }
        }

        private void GetReaderDeviceAddr()
        {// If we do not know the current Reader's Device Address, we can use the Broadcast Device Address to get it.
            txtSend.Text = Commands.RFID_Q_ReaderDeviceAddr(ConstCode.READER_DEVICEADDR_BROADCAST, ConstCode.READER_OPERATION_GET, 0);
            RS232SendCommand(txtSend.Text); GetTxTime();
        }

        private void btn_SetReaderDeviceAddr_Click(object sender, EventArgs e)
        {
            //txtSend.Text = Commands.RFID_Q_ReaderDeviceAddr(ConstCode.READER_DEVICEADDR_BROADCAST, ConstCode.READER_OPERATION_SET, cbxDeviceAddr.SelectedIndex);
            txtSend.Text = Commands.RFID_Q_ReaderDeviceAddr(ReaderDeviceAddress, ConstCode.READER_OPERATION_SET, cbxNewDeviceAddr.SelectedIndex);
            RS232SendCommand(txtSend.Text); GetTxTime();
        }

        private void btn_GetReaderDeviceAddr_Click(object sender, EventArgs e)
        {
            //txtSend.Text = Commands.RFID_Q_ReaderDeviceAddr(ConstCode.READER_DEVICEADDR_BROADCAST, ConstCode.READER_OPERATION_GET, cbxDeviceAddr.SelectedIndex);
            txtSend.Text = Commands.RFID_Q_ReaderDeviceAddr(ReaderDeviceAddress, ConstCode.READER_OPERATION_GET, cbxDeviceAddr.SelectedIndex);
            RS232SendCommand(txtSend.Text); GetTxTime();
        }

        private void btn_SetNewBaudRate_Click(object sender, EventArgs e) //2018-11-09
        {
            /*Actually Baud Rate Data is:
	        0=9600     
	        1=19200  
	        2=38400  
	        3=57600   
	        4=115200 
	        */
            int BaudRate = cbxNewBaudRate.SelectedIndex;
            txtSend.Text = Commands.RFID_Q_SetUartBaudRateX(ReaderDeviceAddress, BaudRate);
            RS232SendCommand(txtSend.Text); GetTxTime();
        }

        private void btn_GetNewBaudRate_Click(object sender, EventArgs e)
        {
            txtSend.Text = Commands.RFID_Q_GetUartBaudRate(ReaderDeviceAddress);
            RS232SendCommand(txtSend.Text); GetTxTime();
        }

        #endregion


        //-----------------------------------------------------------------
        #region Reader GPIO operate command
        //-----------------------------------------------------------------Module Reader
        private void btnSetIO_Click(object sender, EventArgs e)
        {
            byte para0 = 0x01;
            byte para1 = (byte)(cbxIO.SelectedIndex + 1);
            byte para2 = (byte)cbxIoLevel.SelectedIndex;
            txtSend.Text = Commands.RFID_Q_IoControl(ReaderDeviceAddress, para0, para1, para2);
            RS232SendCommand(txtSend.Text); GetTxTime();
        }

        private void btnSetIoDirection_Click(object sender, EventArgs e)
        {
            byte para0 = 0x00;
            byte para1 = (byte)(cbxIO.SelectedIndex + 1);
            byte para2 = (byte)cbxIoDircetion.SelectedIndex;
            txtSend.Text = Commands.RFID_Q_IoControl(ReaderDeviceAddress, para0, para1, para2);
            RS232SendCommand(txtSend.Text); GetTxTime();
        }

        private void btnGetIO_Click(object sender, EventArgs e)
        {
            byte para0 = 0x02;
            byte para1 = (byte)(cbxIO.SelectedIndex + 1);
            byte para2 = 0x00;
            txtSend.Text = Commands.RFID_Q_IoControl(ReaderDeviceAddress, para0, para1, para2);
            RS232SendCommand(txtSend.Text); GetTxTime();
        }
        //-----------------------------------------------------------------// for Fixed Reader Only
        private void button_GPIO_Get_Click(object sender, EventArgs e)
        {
            /*byte para0 = 0x12;
            byte para1 = 0x00;
            byte para2 = 0x00;
            if (radioButton_GPO1.Checked == true)
            {
                para1 = 0x01;
                para2 = (byte)comboBox_GPO1.SelectedIndex;
            }
            if (radioButton_GPO2.Checked == true)
            {
                para1 = 0x02;
                para2 = (byte)comboBox_GPO2.SelectedIndex;
            }
            if (radioButton_GPO3.Checked == true)
            {
                para1 = 0x03;
                para2 = (byte)comboBox_GPO3.SelectedIndex;
            }
            if (radioButton_GPO4.Checked == true)
            {
                para1 = 0x04;
                para2 = (byte)comboBox_GPO4.SelectedIndex;
            }
            txtSend.Text = Commands.RFID_Q_IoControl(ReaderDeviceAddress, para0, para1, para2);
            RS232SendCommand(txtSend.Text); GetTxTime();*/
            byte para0 = 0x12;
            byte para1 = 0x00;
            byte para2 = 0x00;
            if (checkBox_GPO1.Checked == true)
            {
                para1 = 0x01;
                para2 = (byte)comboBox_GPO1.SelectedIndex;
                txtSend.Text = Commands.RFID_Q_IoControl(ReaderDeviceAddress, para0, para1, para2);
                RS232SendCommand(txtSend.Text); GetTxTime();
                Thread.Sleep(20);
            }
            if (checkBox_GPO2.Checked == true)
            {
                para1 = 0x02;
                para2 = (byte)comboBox_GPO2.SelectedIndex;
                txtSend.Text = Commands.RFID_Q_IoControl(ReaderDeviceAddress, para0, para1, para2);
                RS232SendCommand(txtSend.Text); GetTxTime();
                Thread.Sleep(20);
            }
            if (checkBox_GPO3.Checked == true)
            {
                para1 = 0x03;
                para2 = (byte)comboBox_GPO3.SelectedIndex;
                txtSend.Text = Commands.RFID_Q_IoControl(ReaderDeviceAddress, para0, para1, para2);
                RS232SendCommand(txtSend.Text); GetTxTime();
                Thread.Sleep(20);
            }
            if (checkBox_GPO4.Checked == true)
            {
                para1 = 0x04;
                para2 = (byte)comboBox_GPO4.SelectedIndex;
                txtSend.Text = Commands.RFID_Q_IoControl(ReaderDeviceAddress, para0, para1, para2);
                RS232SendCommand(txtSend.Text); GetTxTime();
                Thread.Sleep(20);
            }

        }

        private void button_GPIO_Set_Click(object sender, EventArgs e)
        {
            /*byte para0 = 0x11;
            byte para1 = 0x00;
            byte para2 = 0x00;
            if (radioButton_GPO1.Checked == true)
            {
                para1 = 0x01;
                para2 = (byte)comboBox_GPO1.SelectedIndex;
            }
            if (radioButton_GPO2.Checked == true)
            {
                para1 = 0x02;
                para2 = (byte)comboBox_GPO2.SelectedIndex;
            }
            if (radioButton_GPO3.Checked == true)
            {
                para1 = 0x03;
                para2 = (byte)comboBox_GPO3.SelectedIndex;
            }
            if (radioButton_GPO4.Checked == true)
            {
                para1 = 0x04;
                para2 = (byte)comboBox_GPO4.SelectedIndex;
            }
            txtSend.Text = Commands.RFID_Q_IoControl(ReaderDeviceAddress, para0, para1, para2);
            RS232SendCommand(txtSend.Text); GetTxTime();*/
            byte para0 = 0x11;
            byte para1 = 0x00;
            byte para2 = 0x00;
            if (checkBox_GPO1.Checked == true)
            {
                para1 = 0x01;
                para2 = (byte)comboBox_GPO1.SelectedIndex;
                txtSend.Text = Commands.RFID_Q_IoControl(ReaderDeviceAddress, para0, para1, para2);
                RS232SendCommand(txtSend.Text); GetTxTime();
                Thread.Sleep(20);
            }
            if (checkBox_GPO2.Checked == true)
            {
                para1 = 0x02;
                para2 = (byte)comboBox_GPO2.SelectedIndex;
                txtSend.Text = Commands.RFID_Q_IoControl(ReaderDeviceAddress, para0, para1, para2);
                RS232SendCommand(txtSend.Text); GetTxTime();
                Thread.Sleep(20);
            }
            if (checkBox_GPO3.Checked == true)
            {
                para1 = 0x03;
                para2 = (byte)comboBox_GPO3.SelectedIndex;
                txtSend.Text = Commands.RFID_Q_IoControl(ReaderDeviceAddress, para0, para1, para2);
                RS232SendCommand(txtSend.Text); GetTxTime();
                Thread.Sleep(20);
            }
            if (checkBox_GPO4.Checked == true)
            {
                para1 = 0x04;
                para2 = (byte)comboBox_GPO4.SelectedIndex;
                txtSend.Text = Commands.RFID_Q_IoControl(ReaderDeviceAddress, para0, para1, para2);
                RS232SendCommand(txtSend.Text); GetTxTime();
                Thread.Sleep(20);
            }

        }

        private void button_GPI_Get_Click(object sender, EventArgs e)
        {
            /*byte para0 = 0x13;
            byte para1 = 0x00;
            byte para2 = 0x00;
            if (radioButton_GPI1.Checked == true)
            {
                para1 = 0x01;
                para2 = (byte)comboBox_GPI1.SelectedIndex;
            }
            if (radioButton_GPI2.Checked == true)
            {
                para1 = 0x02;
                para2 = (byte)comboBox_GPI2.SelectedIndex;
            }
            if (radioButton_GPI3.Checked == true)
            {
                para1 = 0x03;
                para2 = (byte)comboBox_GPI3.SelectedIndex;
            }
            if (radioButton_GPI4.Checked == true)
            {
                para1 = 0x04;
                para2 = (byte)comboBox_GPI4.SelectedIndex;
            }
            txtSend.Text = Commands.RFID_Q_IoControl(ReaderDeviceAddress, para0, para1, para2);
            RS232SendCommand(txtSend.Text); GetTxTime();*/
            byte para0 = 0x13;
            byte para1 = 0x00;
            byte para2 = 0x00;
            if (checkBox_GPI1.Checked == true)
            {
                para1 = 0x01;
                para2 = (byte)comboBox_GPI1.SelectedIndex;
                txtSend.Text = Commands.RFID_Q_IoControl(ReaderDeviceAddress, para0, para1, para2);
                RS232SendCommand(txtSend.Text); GetTxTime();
                Thread.Sleep(20);
            }
            if (checkBox_GPI2.Checked == true)
            {
                para1 = 0x02;
                para2 = (byte)comboBox_GPI2.SelectedIndex;
                txtSend.Text = Commands.RFID_Q_IoControl(ReaderDeviceAddress, para0, para1, para2);
                RS232SendCommand(txtSend.Text); GetTxTime();
                Thread.Sleep(20);
            }
            if (checkBox_GPI3.Checked == true)
            {
                para1 = 0x03;
                para2 = (byte)comboBox_GPI3.SelectedIndex;
                txtSend.Text = Commands.RFID_Q_IoControl(ReaderDeviceAddress, para0, para1, para2);
                RS232SendCommand(txtSend.Text); GetTxTime();
                Thread.Sleep(20);
            }
            if (checkBox_GPI4.Checked == true)
            {
                para1 = 0x04;
                para2 = (byte)comboBox_GPI4.SelectedIndex;
                txtSend.Text = Commands.RFID_Q_IoControl(ReaderDeviceAddress, para0, para1, para2);
                RS232SendCommand(txtSend.Text); GetTxTime();
                Thread.Sleep(20);
            }

        }

        #endregion


        //-----------------------------------------------------------------
        #region Ant Operation
        private const int _ANT_Max_Quantity_ = 16;

        private Commands.AntWorkParamStruct Ant = new Commands.AntWorkParamStruct(true);
        private CheckBox[] AntEnableBitCheck = new CheckBox[_ANT_Max_Quantity_];/* { checkBox_RF_Ant_Enable1, checkBox_RF_Ant_Enable2,
                                            checkBox_RF_Ant_Enable3, checkBox_RF_Ant_Enable4,
                                            checkBox_RF_Ant_Enable5, checkBox_RF_Ant_Enable6,
                                            checkBox_RF_Ant_Enable7, checkBox_RF_Ant_Enable8
            };*/
        private RadioButton[] AntPortRb = new RadioButton[_ANT_Max_Quantity_];
        private ComboBox[] AntRfPowerCmb = new ComboBox[_ANT_Max_Quantity_];
        private TextBox[] AntPollingCountTxt = new TextBox[_ANT_Max_Quantity_];

        private bool bAnt_InitalFlag = false;
        private void Ant_Inital()
        {
            this.comboBoxRF_AntPort_Port1.SelectedIndex = 0;
            this.comboBoxRF_AntPort_Port2.SelectedIndex = 0;
            this.comboBoxRF_AntPort_Port3.SelectedIndex = 0;
            this.comboBoxRF_AntPort_Port4.SelectedIndex = 0;
            this.comboBoxRF_AntPort_Port5.SelectedIndex = 0;
            this.comboBoxRF_AntPort_Port6.SelectedIndex = 0;
            this.comboBoxRF_AntPort_Port7.SelectedIndex = 0;
            this.comboBoxRF_AntPort_Port8.SelectedIndex = 0;
            this.comboBoxRF_AntPort_Port9.SelectedIndex = 0;
            this.comboBoxRF_AntPort_Port10.SelectedIndex = 0;
            this.comboBoxRF_AntPort_Port11.SelectedIndex = 0;
            this.comboBoxRF_AntPort_Port12.SelectedIndex = 0;
            this.comboBoxRF_AntPort_Port13.SelectedIndex = 0;
            this.comboBoxRF_AntPort_Port14.SelectedIndex = 0;
            this.comboBoxRF_AntPort_Port15.SelectedIndex = 0;
            this.comboBoxRF_AntPort_Port16.SelectedIndex = 0;

            this.radioButton_AntPort1.Checked = true;
            this.checkBox_RF_Ant_Enable1.Checked = true;
            this.comboBox_RF_AntPort_Quantity.SelectedIndex = 0;

            AntEnableBitCheck[0] = checkBox_RF_Ant_Enable1;
            AntEnableBitCheck[1] = checkBox_RF_Ant_Enable2;
            AntEnableBitCheck[2] = checkBox_RF_Ant_Enable3;
            AntEnableBitCheck[3] = checkBox_RF_Ant_Enable4;
            AntEnableBitCheck[4] = checkBox_RF_Ant_Enable5;
            AntEnableBitCheck[5] = checkBox_RF_Ant_Enable6;
            AntEnableBitCheck[6] = checkBox_RF_Ant_Enable7;
            AntEnableBitCheck[7] = checkBox_RF_Ant_Enable8;
            AntEnableBitCheck[8] = checkBox_RF_Ant_Enable9;
            AntEnableBitCheck[9] = checkBox_RF_Ant_Enable10;
            AntEnableBitCheck[10] = checkBox_RF_Ant_Enable11;
            AntEnableBitCheck[11] = checkBox_RF_Ant_Enable12;
            AntEnableBitCheck[12] = checkBox_RF_Ant_Enable13;
            AntEnableBitCheck[13] = checkBox_RF_Ant_Enable14;
            AntEnableBitCheck[14] = checkBox_RF_Ant_Enable15;
            AntEnableBitCheck[15] = checkBox_RF_Ant_Enable16;

            AntPortRb[0] = radioButton_AntPort1;
            AntPortRb[1] = radioButton_AntPort2;
            AntPortRb[2] = radioButton_AntPort3;
            AntPortRb[3] = radioButton_AntPort4;
            AntPortRb[4] = radioButton_AntPort5;
            AntPortRb[5] = radioButton_AntPort6;
            AntPortRb[6] = radioButton_AntPort7;
            AntPortRb[7] = radioButton_AntPort8;
            AntPortRb[8] = radioButton_AntPort9;
            AntPortRb[9] = radioButton_AntPort10;
            AntPortRb[10] = radioButton_AntPort11;
            AntPortRb[11] = radioButton_AntPort12;
            AntPortRb[12] = radioButton_AntPort13;
            AntPortRb[13] = radioButton_AntPort14;
            AntPortRb[14] = radioButton_AntPort15;
            AntPortRb[15] = radioButton_AntPort16;

            AntRfPowerCmb[0] = comboBoxRF_AntPort_Port1;
            AntRfPowerCmb[1] = comboBoxRF_AntPort_Port2;
            AntRfPowerCmb[2] = comboBoxRF_AntPort_Port3;
            AntRfPowerCmb[3] = comboBoxRF_AntPort_Port4;
            AntRfPowerCmb[4] = comboBoxRF_AntPort_Port5;
            AntRfPowerCmb[5] = comboBoxRF_AntPort_Port6;
            AntRfPowerCmb[6] = comboBoxRF_AntPort_Port7;
            AntRfPowerCmb[7] = comboBoxRF_AntPort_Port8;
            AntRfPowerCmb[8] = comboBoxRF_AntPort_Port9;
            AntRfPowerCmb[9] = comboBoxRF_AntPort_Port10;
            AntRfPowerCmb[10] = comboBoxRF_AntPort_Port11;
            AntRfPowerCmb[11] = comboBoxRF_AntPort_Port12;
            AntRfPowerCmb[12] = comboBoxRF_AntPort_Port13;
            AntRfPowerCmb[13] = comboBoxRF_AntPort_Port14;
            AntRfPowerCmb[14] = comboBoxRF_AntPort_Port15;
            AntRfPowerCmb[15] = comboBoxRF_AntPort_Port16;

            AntPollingCountTxt[0] = textBox_RF_AntPort_InvCnter1;
            AntPollingCountTxt[1] = textBox_RF_AntPort_InvCnter2;
            AntPollingCountTxt[2] = textBox_RF_AntPort_InvCnter3;
            AntPollingCountTxt[3] = textBox_RF_AntPort_InvCnter4;
            AntPollingCountTxt[4] = textBox_RF_AntPort_InvCnter5;
            AntPollingCountTxt[5] = textBox_RF_AntPort_InvCnter6;
            AntPollingCountTxt[6] = textBox_RF_AntPort_InvCnter7;
            AntPollingCountTxt[7] = textBox_RF_AntPort_InvCnter8;
            AntPollingCountTxt[8] = textBox_RF_AntPort_InvCnter9;
            AntPollingCountTxt[9] = textBox_RF_AntPort_InvCnter10;
            AntPollingCountTxt[10] = textBox_RF_AntPort_InvCnter11;
            AntPollingCountTxt[11] = textBox_RF_AntPort_InvCnter12;
            AntPollingCountTxt[12] = textBox_RF_AntPort_InvCnter13;
            AntPollingCountTxt[13] = textBox_RF_AntPort_InvCnter14;
            AntPollingCountTxt[14] = textBox_RF_AntPort_InvCnter15;
            AntPollingCountTxt[15] = textBox_RF_AntPort_InvCnter16;

            bAnt_InitalFlag = true;
            for (int i = 0; i < _ANT_Max_Quantity_; i++)
            {
                AntRfPowerCmb[i].SelectedIndex = 33 - 30;
            }
            comboBoxRF_AntPort_PortAll.SelectedIndex = 3;
        }


        private ulong AntGetEnableSetting()
        {
            ulong EnSet = 0, t;
            for (int i = 0; i < _ANT_Max_Quantity_; i++)
            {
                if (AntEnableBitCheck[i].Checked)
                {
                    t = 1;
                    t = t << i;
                    EnSet = EnSet | t;
                }
            }
            return EnSet;
        }
        private void AntSetEnableSetting(ulong EnbSet)
        {
            ulong EnbSet1 = EnbSet;
            for (int i = 0; i < _ANT_Max_Quantity_; i++)
            {
                if ((EnbSet1 & 0x00000001) != 0)
                    AntEnableBitCheck[i].Checked = true;
                else
                    AntEnableBitCheck[i].Checked = false;
                EnbSet1 = EnbSet1 >> 1;
            }
        }
        private void checkBox_RF_Ant_Enable1_CheckedChanged(object sender, EventArgs e)  //2021-07-20
        {
            if (this.checkBox_RF_Ant_Enable1.Checked == false)
            {
                this.checkBox_RF_Ant_Enable1.Checked = true;
                MessageBox.Show("Antenna1 Should be USED and CONNECTED to a valid atennna!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void button_RF_Ant_Set_Click(object sender, EventArgs e)
        {
            byte i;
            Ant.Quantity = byte.Parse(comboBox_RF_AntPort_Quantity.SelectedItem.ToString());

            for (i = 0; i < 4; i++)
                Ant.Enable[i] = 0;

            ulong lEnbleBits = AntGetEnableSetting();
            Ant.Enable[0] = (byte)(lEnbleBits & 0x000000FF);
            Ant.Enable[1] = (byte)(lEnbleBits >> 8 & 0x000000FF);
            Ant.Enable[2] = (byte)(lEnbleBits >> 16 & 0x000000FF);
            Ant.Enable[3] = (byte)(lEnbleBits >> 24 & 0x000000FF);
            //------------------
            float powerFloat = 0;
            int powerDBm = 0;
            try
            {
                for (i = 0; i < Ant.Quantity; i++)
                {
                    powerFloat = float.Parse(AntRfPowerCmb[i].SelectedItem.ToString().Replace("dBm", ""));
                    powerDBm = (int)(powerFloat * 100);
                    Ant.AntRFPower[i] = (ushort)powerDBm;
                    Ant.PollingNumber[i] = ushort.Parse(AntPollingCountTxt[i].Text);
                }
            }
            catch (Exception formatException)
            {
                Console.WriteLine(formatException.ToString());
            }

            if (checkBox_RF_AntPort_AutoPolling.Checked)
                Ant.PollingCycle = 1;
            else
                Ant.PollingCycle = 0;

            txtSend.Text = Commands.RFID_Q_AntWorkParamters(ReaderDeviceAddress, ConstCode.READER_OPERATION_SET, Ant);
            RS232SendCommand(txtSend.Text); GetTxTime();

        }

        private void button_RF_Ant_Get_Click(object sender, EventArgs e)
        {
            txtSend.Text = Commands.RFID_Q_AntWorkParamters(ReaderDeviceAddress, ConstCode.READER_OPERATION_GET, Ant);
            RS232SendCommand(txtSend.Text); GetTxTime();
        }

        private void comboBox_RF_AntPort_Quantity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bAnt_InitalFlag == false)
                return;
            int i;
            for (i = 0; i < _ANT_Max_Quantity_; i++)
            {
                AntEnableBitCheck[i].Enabled = false;
                AntPortRb[i].Enabled = false;
                AntRfPowerCmb[i].Enabled = false;
                AntPollingCountTxt[i].Enabled = false;
            }

            Ant.Quantity = byte.Parse(comboBox_RF_AntPort_Quantity.SelectedItem.ToString());
            for (i = 0; i < Ant.Quantity; i++)
            {
                AntEnableBitCheck[i].Enabled = true;
                AntPortRb[i].Enabled = true;
                //if (checkBox_RF_AntPort_AutoPolling.Checked)  //2021-12-28
                {
                    AntRfPowerCmb[i].Enabled = true;
                    AntPollingCountTxt[i].Enabled = true;
                }
            }

            if (Ant.Quantity == 1)
            {
                AntEnableBitCheck[0].Checked = true;
                radioButton_AntPort1_Click(sender, e);
            }
        }

        private void btn_AntQuantityHelp_Click(object sender, EventArgs e)  //2021-12-28
        {
            MessageBox.Show("1. The ANT quantitiy should be corresponding to actual ANT quantity of reader!\r\n2.User should not CHANGED this setting for reader.\r\n3.Some antenna port could be disable when never be used.\r\n4.Get this setting by \"Get\" button.",
                "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void checkBox_RF_AntPort_AutoPolling_CheckedChanged(object sender, EventArgs e)  //2021-12-28
        {
            int i;
            Ant.Quantity = byte.Parse(comboBox_RF_AntPort_Quantity.SelectedItem.ToString());
            for (i = 0; i < Ant.Quantity; i++)
            {
                AntEnableBitCheck[i].Enabled = true;
                AntPortRb[i].Enabled = true;
                if (checkBox_RF_AntPort_AutoPolling.Checked)  //2021-12-28
                {
                    AntRfPowerCmb[i].Enabled = true;
                    AntPollingCountTxt[i].Enabled = true;
                }
                else
                {
                    AntRfPowerCmb[i].Enabled = false;
                    AntPollingCountTxt[i].Enabled = false;
                }
            }
        }

        private void btn_AntAutoPolling_ParametersHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1.These two setting is used for \"Antenna Auto-Polling\".\r\n2.\"Polling Power\" defined each ANT transmit RF power while the reader poll the ANT port.\r\n3.\"Inventory Count\" defined how many INVENTORY command will be sent when reader poll the ANT port. ",
                "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void SwitchAntennaPort(byte AntNo)
        {
            txtSend.Text = Commands.RFID_Q_SetAntCurrentAntPort(ReaderDeviceAddress, AntNo);
            RS232SendCommand(txtSend.Text); GetTxTime();
        }

        private void radioButton_AntPort1_Click(object sender, EventArgs e)
        {
            SwitchAntennaPort(0);
        }

        private void radioButton_AntPort2_Click(object sender, EventArgs e)
        {
            SwitchAntennaPort(1);
        }

        private void radioButton_AntPort3_Click(object sender, EventArgs e)
        {
            SwitchAntennaPort(2);
        }

        private void radioButton_AntPort4_Click(object sender, EventArgs e)
        {
            SwitchAntennaPort(3);
        }

        private void radioButton_AntPort5_Click(object sender, EventArgs e)
        {
            SwitchAntennaPort(4);
        }

        private void radioButton_AntPort6_Click(object sender, EventArgs e)
        {
            SwitchAntennaPort(5);
        }

        private void radioButton_AntPort7_Click(object sender, EventArgs e)
        {
            SwitchAntennaPort(6);
        }

        private void radioButton_AntPort8_Click(object sender, EventArgs e)
        {
            SwitchAntennaPort(7);
        }
        private void button_RF_Ant_SetAllParameter_Click(object sender, EventArgs e)
        {
            string sstr;
            for (int i = 0; i < 16; i++)
            {
                sstr = (33 - comboBoxRF_AntPort_PortAll.SelectedIndex).ToString();
                Ant.AntRFPower[i] = Convert.ToUInt16(sstr, 10);
                AntRfPowerCmb[i].SelectedIndex = 33 - (Ant.AntRFPower[i]);
            }
        }


        private void button_RF_Ant_GetCurrentAntPort_Click(object sender, EventArgs e)
        {
            byte AntPort = 0;
            txtSend.Text = Commands.RFID_Q_AntCurrentAntPort(ReaderDeviceAddress, ConstCode.READER_OPERATION_GET, AntPort);
            RS232SendCommand(txtSend.Text); GetTxTime();
        }
        #endregion



        //-----------------------------------------------------------------
        #region Extended Command

        private void Btn_Set_Mode00_Click(object sender, EventArgs e)
        {
            int intSelTMatchedMode = this.MatchedModeComboBox.SelectedIndex;
            int intSelTMatchedNumber = this.MatchedNumberComboBox.SelectedIndex;
            int intSelTMatchedLengtharget = this.COMBO_TAG_MATCHED_BYTELEN1.SelectedIndex;
            string strDate2Write = EDIT_TAG_MATCHED_DATA1.Text.Replace(" ", "");

            switch (MatchedNumberComboBox.SelectedIndex)
            {
                case 0:
                    intSelTMatchedLengtharget = this.COMBO_TAG_MATCHED_BYTELEN1.SelectedIndex;
                    strDate2Write = EDIT_TAG_MATCHED_DATA1.Text.Replace(" ", "");
                    break;
                case 1:
                    intSelTMatchedLengtharget = this.COMBO_TAG_MATCHED_BYTELEN2.SelectedIndex;
                    strDate2Write = EDIT_TAG_MATCHED_DATA2.Text.Replace(" ", "");
                    break;

                case 2:
                    intSelTMatchedLengtharget = this.COMBO_TAG_MATCHED_BYTELEN3.SelectedIndex;
                    strDate2Write = EDIT_TAG_MATCHED_DATA3.Text.Replace(" ", "");
                    break;

                case 3:
                    intSelTMatchedLengtharget = this.COMBO_TAG_MATCHED_BYTELEN4.SelectedIndex;
                    strDate2Write = EDIT_TAG_MATCHED_DATA4.Text.Replace(" ", "");
                    break;

                case 4:
                    intSelTMatchedLengtharget = this.COMBO_TAG_MATCHED_BYTELEN5.SelectedIndex;
                    strDate2Write = EDIT_TAG_MATCHED_DATA5.Text.Replace(" ", "");

                    break;

                default:
                    MessageBox.Show("The number must be between 0 and 4", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }
            if (strDate2Write.Length % 2 != 0)
            {
                MessageBox.Show("The Data's Length Should Be Integer Multiples bytes", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (intSelTMatchedLengtharget != 0)
            {
                if (strDate2Write.Length / 2 < intSelTMatchedLengtharget)
                {
                    MessageBox.Show("The Write Data's String length is twice the set length", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            strDate2Write = strDate2Write.Substring(0, intSelTMatchedLengtharget * 2);

            txtSend.Text = Commands.RFID_Q_SetMatchedTagDataMode(ReaderDeviceAddress, intSelTMatchedMode, intSelTMatchedNumber, intSelTMatchedLengtharget, strDate2Write);
            RS232SendCommand(txtSend.Text); GetTxTime();
        }




        private void Btn_Get_Mode11_Click(object sender, EventArgs e)
        {
            int intSelTMatchedNumber = this.MatchedNumberComboBox.SelectedIndex;
            txtSend.Text = Commands.RFID_Q_GetMatchedTagDataMode(ReaderDeviceAddress, intSelTMatchedNumber);
            RS232SendCommand(txtSend.Text); GetTxTime();
        }

        private void Btn_Set_EnableModeOn_Click(object sender, EventArgs e)
        {
            int FLS1 = 0x00;
            int FLV1 = 0x01;
            int FLS2 = 0x01;
            int FLV2 = 0x01;
            int FLS3 = 0x02;
            int FLV3 = 0x01;
            int FLS4 = 0x03;
            int FLV4 = 0x01;
            int FLS5 = 0x04;
            int FLV5 = 0x01;
            txtSend.Text = Commands.RFID_Q_Set_EnableMode(ReaderDeviceAddress, FLS1, FLV1, FLS2, FLV2, FLS3, FLV3, FLS4, FLV4, FLS5, FLV5);
            RS232SendCommand(txtSend.Text); GetTxTime();
        }
        private void Btn_Set_EnableModeOff_Click(object sender, EventArgs e)
        {
            int FLS1 = 0x00;
            int FLV1 = 0x00;
            int FLS2 = 0x01;
            int FLV2 = 0x00;
            int FLS3 = 0x02;
            int FLV3 = 0x00;
            int FLS4 = 0x03;
            int FLV4 = 0x00;
            int FLS5 = 0x04;
            int FLV5 = 0x00;
            txtSend.Text = Commands.RFID_Q_Set_EnableMode(ReaderDeviceAddress, FLS1, FLV1, FLS2, FLV2, FLS3, FLV3, FLS4, FLV4, FLS5, FLV5);
            RS232SendCommand(txtSend.Text); GetTxTime();
        }


        private void Btn_Get_EnableMode21_Click(object sender, EventArgs e)
        {
            txtSend.Text = Commands.RFID_Q_Get_EnableMode(ReaderDeviceAddress);
            RS232SendCommand(txtSend.Text); GetTxTime();

        }

        private void BtnSetReaderWorkMode_Click(object sender, EventArgs e)
        {
            int imode = ReaderWorkModeComboBox.SelectedIndex;
            txtSend.Text = Commands.RFID_Q_SetReaderWorkMode(ReaderDeviceAddress, imode);
            RS232SendCommand(txtSend.Text); GetTxTime();

        }

        private void BtnGetReaderWorkMode_Click(object sender, EventArgs e)
        {
            int imode = ReaderWorkModeComboBox.SelectedIndex;
            txtSend.Text = Commands.RFID_Q_GetReaderWorkMode(ReaderDeviceAddress);
            RS232SendCommand(txtSend.Text); GetTxTime();

        }

        private void BtnSettingDefaultWorkParam_Click(object sender, EventArgs e)
        {
            txtSend.Text = Commands.RFID_Q_SetDefaultWorkParameter(ReaderDeviceAddress);
            RS232SendCommand(txtSend.Text); GetTxTime();

        }


        private void BtnSetBeepMode_Click(object sender, EventArgs e)
        {
            int iMode = this.BeepModeComboBox.SelectedIndex;
            txtSend.Text = Commands.RFID_Q_SetBeep(ReaderDeviceAddress, iMode);
            RS232SendCommand(txtSend.Text); GetTxTime();

        }


        private void BtnGetBeepStatus_Click(object sender, EventArgs e)
        {
            txtSend.Text = Commands.RFID_Q_GetBeep(ReaderDeviceAddress);
            RS232SendCommand(txtSend.Text); GetTxTime();
        }




        private void BtnFillTagData_Click(object sender, EventArgs e)
        {
            EDIT_TAG_MATCHED_DATA1.Text = "AABBCCDDEE";
            EDIT_TAG_MATCHED_DATA2.Text = "AABBCCDDEE";
            EDIT_TAG_MATCHED_DATA3.Text = "AABBCCDDEE";
            EDIT_TAG_MATCHED_DATA4.Text = "AABBCCDDEE";
            EDIT_TAG_MATCHED_DATA5.Text = "AABBCCDDEE";
        }

        #endregion












    }
}
