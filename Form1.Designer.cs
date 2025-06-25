namespace RFID_MoudleReader
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbx_conn = new System.Windows.Forms.GroupBox();
            this.radioCommRS485 = new System.Windows.Forms.RadioButton();
            this.radioCommRS232 = new System.Windows.Forms.RadioButton();
            this.checkBox_WorkMode = new System.Windows.Forms.CheckBox();
            this.cbxDeviceAddr = new System.Windows.Forms.ComboBox();
            this.label_DeviceAddr = new System.Windows.Forms.Label();
            this.Reset_FW = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxPort = new System.Windows.Forms.ComboBox();
            this.cbxBaudRate = new System.Windows.Forms.ComboBox();
            this.btnConn = new System.Windows.Forms.Button();
            this.gbx_NewDevAddr = new System.Windows.Forms.GroupBox();
            this.cbxNewDeviceAddr = new System.Windows.Forms.ComboBox();
            this.btn_SetReaderDeviceAddr = new System.Windows.Forms.Button();
            this.btn_GetReaderDeviceAddr = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSetFhss = new System.Windows.Forms.Button();
            this.btnGetFhss = new System.Windows.Forms.Button();
            this.btnSetFreqHopPeriod = new System.Windows.Forms.Button();
            this.btnGetFreqHopPeriod = new System.Windows.Forms.Button();
            this.btnInvtBasic = new System.Windows.Forms.Button();
            this.txtRDMultiNum = new System.Windows.Forms.TextBox();
            this.cbx_MTR_Algorithm = new System.Windows.Forms.ComboBox();
            this.cbx_MTR_Qvalue = new System.Windows.Forms.ComboBox();
            this.btnStopRD = new System.Windows.Forms.Button();
            this.btnInvtMulti = new System.Windows.Forms.Button();
            this.btnSetCW = new System.Windows.Forms.Button();
            this.button_RF_Ant_Get = new System.Windows.Forms.Button();
            this.button_RF_Ant_Set = new System.Windows.Forms.Button();
            this.button_RF_Ant_GetCurrentAntPort = new System.Windows.Forms.Button();
            this.checkBox_RF_Ant_Enable8 = new System.Windows.Forms.CheckBox();
            this.checkBox_RF_Ant_Enable7 = new System.Windows.Forms.CheckBox();
            this.checkBox_RF_Ant_Enable6 = new System.Windows.Forms.CheckBox();
            this.checkBox_RF_Ant_Enable5 = new System.Windows.Forms.CheckBox();
            this.checkBox_RF_Ant_Enable4 = new System.Windows.Forms.CheckBox();
            this.checkBox_RF_Ant_Enable3 = new System.Windows.Forms.CheckBox();
            this.checkBox_RF_Ant_Enable2 = new System.Windows.Forms.CheckBox();
            this.checkBox_RF_Ant_Enable1 = new System.Windows.Forms.CheckBox();
            this.radioButton_AntPort7 = new System.Windows.Forms.RadioButton();
            this.radioButton_AntPort6 = new System.Windows.Forms.RadioButton();
            this.radioButton_AntPort5 = new System.Windows.Forms.RadioButton();
            this.radioButton_AntPort4 = new System.Windows.Forms.RadioButton();
            this.radioButton_AntPort3 = new System.Windows.Forms.RadioButton();
            this.radioButton_AntPort2 = new System.Windows.Forms.RadioButton();
            this.radioButton_AntPort1 = new System.Windows.Forms.RadioButton();
            this.radioButton_AntPort8 = new System.Windows.Forms.RadioButton();
            this.textBox_RF_AntPort_InvCnter8 = new System.Windows.Forms.TextBox();
            this.comboBoxRF_AntPort_Port8 = new System.Windows.Forms.ComboBox();
            this.textBox_RF_AntPort_InvCnter7 = new System.Windows.Forms.TextBox();
            this.comboBoxRF_AntPort_Port7 = new System.Windows.Forms.ComboBox();
            this.textBox_RF_AntPort_InvCnter6 = new System.Windows.Forms.TextBox();
            this.comboBoxRF_AntPort_Port6 = new System.Windows.Forms.ComboBox();
            this.textBox_RF_AntPort_InvCnter5 = new System.Windows.Forms.TextBox();
            this.comboBoxRF_AntPort_Port5 = new System.Windows.Forms.ComboBox();
            this.textBox_RF_AntPort_InvCnter4 = new System.Windows.Forms.TextBox();
            this.comboBoxRF_AntPort_Port4 = new System.Windows.Forms.ComboBox();
            this.textBox_RF_AntPort_InvCnter3 = new System.Windows.Forms.TextBox();
            this.comboBoxRF_AntPort_Port3 = new System.Windows.Forms.ComboBox();
            this.textBox_RF_AntPort_InvCnter2 = new System.Windows.Forms.TextBox();
            this.comboBoxRF_AntPort_Port2 = new System.Windows.Forms.ComboBox();
            this.textBox_RF_AntPort_InvCnter1 = new System.Windows.Forms.TextBox();
            this.comboBoxRF_AntPort_Port1 = new System.Windows.Forms.ComboBox();
            this.comboBox_RF_AntPort_Quantity = new System.Windows.Forms.ComboBox();
            this.checkBox_RF_AntPort_AutoPolling = new System.Windows.Forms.CheckBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            this.checkBox_InvtMulti_AutoClear = new System.Windows.Forms.CheckBox();
            this.btn_SetNewBaudRate = new System.Windows.Forms.Button();
            this.btn_GetNewBaudRate = new System.Windows.Forms.Button();
            this.button_GPO_Set = new System.Windows.Forms.Button();
            this.button_GPO_Get = new System.Windows.Forms.Button();
            this.btnSetIO = new System.Windows.Forms.Button();
            this.btnGetIO = new System.Windows.Forms.Button();
            this.btnGetRegion = new System.Windows.Forms.Button();
            this.btnSetRegion = new System.Windows.Forms.Button();
            this.btnInsertRfCh_Get = new System.Windows.Forms.Button();
            this.txtChIndexBegin = new System.Windows.Forms.TextBox();
            this.txtChIndexEnd = new System.Windows.Forms.TextBox();
            this.btnInsertRfCh = new System.Windows.Forms.Button();
            this.cbx_AccessMemBank = new System.Windows.Forms.ComboBox();
            this.txtEpcAccessMemBankAccessPwd = new System.Windows.Forms.TextBox();
            this.txtInvEPC_AccessMemBankWordLength = new System.Windows.Forms.TextBox();
            this.txtInvEPC_AccessMemBankStartAddr = new System.Windows.Forms.TextBox();
            this.btnInvtMultiEpcTid = new System.Windows.Forms.Button();
            this.cbxNewBaudRate = new System.Windows.Forms.ComboBox();
            this.label_AntPort_Quantity = new System.Windows.Forms.Label();
            this.comboBoxRF_AntPort_PortAll = new System.Windows.Forms.ComboBox();
            this.txtInvEPC_AccessExUserMemBankStartAddrEx = new System.Windows.Forms.TextBox();
            this.txtInvEPC_AccessExUserMemBankWordLength = new System.Windows.Forms.TextBox();
            this.txtReceive = new System.Windows.Forms.TextBox();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.btn_clear_rx = new System.Windows.Forms.Button();
            this.btnClearCnt = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.timerAutoSend = new System.Windows.Forms.Timer(this.components);
            this.gbxRxData = new System.Windows.Forms.GroupBox();
            this.cbxRxTimeInfor = new System.Windows.Forms.CheckBox();
            this.cbxRxVisable = new System.Windows.Forms.CheckBox();
            this.cbxAutoClear = new System.Windows.Forms.CheckBox();
            this.gbx_inventory = new System.Windows.Forms.GroupBox();
            this.label57 = new System.Windows.Forms.Label();
            this.cbxQBasic = new System.Windows.Forms.ComboBox();
            this.txtSendDelay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbx_MTR = new System.Windows.Forms.GroupBox();
            this.lbl_TagNumberToStopTimer = new System.Windows.Forms.Label();
            this.txt_TagNumberToStopTimer = new System.Windows.Forms.TextBox();
            this.gbx_Access = new System.Windows.Forms.GroupBox();
            this.label54 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.btn_AccessMemBankHelp = new System.Windows.Forms.Button();
            this.labelInvEpcAccessMemBankAlgorithm = new System.Windows.Forms.Label();
            this.labelInvEpcAccessMemBankAccessPwd = new System.Windows.Forms.Label();
            this.labelInvEpcAccessMemBankWordLength = new System.Windows.Forms.Label();
            this.labelInvEpcAccessMemBankStartWordAddr = new System.Windows.Forms.Label();
            this.gbx_MTR_LoopNum = new System.Windows.Forms.GroupBox();
            this.btn_invt_multi_Help = new System.Windows.Forms.Button();
            this.lbl_MTR_Read_Number = new System.Windows.Forms.Label();
            this.lbl_MTR_Algorithm = new System.Windows.Forms.Label();
            this.lbl_MTR_Qvalue = new System.Windows.Forms.Label();
            this.dgvEpcBasic = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveAsCsvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbxEpcTableBasic = new System.Windows.Forms.GroupBox();
            this.lbl_TagNumberElapseTimeMs = new System.Windows.Forms.Label();
            this.lbl_TagNumberElapseTime = new System.Windows.Forms.Label();
            this.txt_TagNumberToTimeValue = new System.Windows.Forms.TextBox();
            this.textBox_EPC_Tag_Total = new System.Windows.Forms.TextBox();
            this.label_EPC_Tag_Total = new System.Windows.Forms.Label();
            this.textBox_EPC_TagCounter = new System.Windows.Forms.TextBox();
            this.label_EPC_TagCounter = new System.Windows.Forms.Label();
            this.btn_clear_epc1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage_TagRead = new System.Windows.Forms.TabPage();
            this.tabPage_SysSetting = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.gbxStatus = new System.Windows.Forms.GroupBox();
            this.txtReaderFirmwareVersion = new System.Windows.Forms.TextBox();
            this.txtModuleFirmwareVersion = new System.Windows.Forms.TextBox();
            this.txtModuleReleaseDate = new System.Windows.Forms.TextBox();
            this.txtModuleHardwareVersion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.labelHardwareVersion = new System.Windows.Forms.Label();
            this.txtTxTimerInfor = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCOMRxCnt = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCOMTxCnt = new System.Windows.Forms.TextBox();
            this.tabPageAccessTag = new System.Windows.Forms.TabPage();
            this.tabControl4 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gbxSelect = new System.Windows.Forms.GroupBox();
            this.label_Access3 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.txtGetSelLength = new System.Windows.Forms.TextBox();
            this.txtGetSelMask = new System.Windows.Forms.TextBox();
            this.btnGetSelect = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.txtSelMask = new System.Windows.Forms.TextBox();
            this.ckxTruncated = new System.Windows.Forms.CheckBox();
            this.label32 = new System.Windows.Forms.Label();
            this.txtSelLength = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.txtSelPrt0 = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.txtSelPrt2 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.txtSelPrt1 = new System.Windows.Forms.TextBox();
            this.txtSelPrt3 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.cbxSelMemBank = new System.Windows.Forms.ComboBox();
            this.cbxAction = new System.Windows.Forms.ComboBox();
            this.cbxSelTarget = new System.Windows.Forms.ComboBox();
            this.btnSetSelect = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.gbxSetQuery = new System.Windows.Forms.GroupBox();
            this.cbxM = new System.Windows.Forms.ComboBox();
            this.cbxQAdv = new System.Windows.Forms.ComboBox();
            this.btnGetQuery = new System.Windows.Forms.Button();
            this.btnSetQuery = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.cbxTarget = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbxSession = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbxSel = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxTRext = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxDR = new System.Windows.Forms.ComboBox();
            this.label_Access4 = new System.Windows.Forms.Label();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbxAccess = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWordCnt0 = new System.Windows.Forms.TextBox();
            this.txtWordPtr0 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtRwAccPassWord = new System.Windows.Forms.TextBox();
            this.txtInvtRWData = new System.Windows.Forms.TextBox();
            this.btnInvtWrtie = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cbxMemBank = new System.Windows.Forms.ComboBox();
            this.txtWordCnt1 = new System.Windows.Forms.TextBox();
            this.txtWordPtr1 = new System.Windows.Forms.TextBox();
            this.btn_invtread = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gBxLock = new System.Windows.Forms.GroupBox();
            this.cbxLockUserAction = new System.Windows.Forms.ComboBox();
            this.cbxLockTIDAction = new System.Windows.Forms.ComboBox();
            this.cbxLockEPCAction = new System.Windows.Forms.ComboBox();
            this.cbxLockAccessAction = new System.Windows.Forms.ComboBox();
            this.cbxLockKillAction = new System.Windows.Forms.ComboBox();
            this.checkBoxUser = new System.Windows.Forms.CheckBox();
            this.checkBoxTID = new System.Windows.Forms.CheckBox();
            this.checkBoxEPC = new System.Windows.Forms.CheckBox();
            this.checkBoxAccessPwd = new System.Windows.Forms.CheckBox();
            this.checkBoxKillPwd = new System.Windows.Forms.CheckBox();
            this.buttonLock = new System.Windows.Forms.Button();
            this.label42 = new System.Windows.Forms.Label();
            this.textBoxLockAccessPwd = new System.Windows.Forms.TextBox();
            this.gbxKill = new System.Windows.Forms.GroupBox();
            this.labelKillRFU = new System.Windows.Forms.Label();
            this.textBoxKillRFU = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.textBoxKillPwd = new System.Windows.Forms.TextBox();
            this.buttonKill = new System.Windows.Forms.Button();
            this.label_Acess1 = new System.Windows.Forms.Label();
            this.gbxStatus2 = new System.Windows.Forms.GroupBox();
            this.rtbxStatus = new System.Windows.Forms.RichTextBox();
            this.txtOperateEpc = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.inv_mode = new System.Windows.Forms.CheckBox();
            this.gbx_comcnt_adv = new System.Windows.Forms.GroupBox();
            this.btnClearCntAdv = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.txtCOMRxCnt_adv = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCOMTxCnt_adv = new System.Windows.Forms.TextBox();
            this.btnInvtAdv = new System.Windows.Forms.Button();
            this.gbxEpcTableAdv = new System.Windows.Forms.GroupBox();
            this.label_Access2 = new System.Windows.Forms.Label();
            this.btn_clear_epc2 = new System.Windows.Forms.Button();
            this.dgv_epc2 = new System.Windows.Forms.DataGridView();
            this.tabPageSysSetting = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox_GPIO = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.checkBox_GPI4 = new System.Windows.Forms.CheckBox();
            this.button_GPI_Get = new System.Windows.Forms.Button();
            this.checkBox_GPI3 = new System.Windows.Forms.CheckBox();
            this.checkBox_GPI2 = new System.Windows.Forms.CheckBox();
            this.comboBox_GPI4 = new System.Windows.Forms.ComboBox();
            this.checkBox_GPI1 = new System.Windows.Forms.CheckBox();
            this.comboBox_GPI3 = new System.Windows.Forms.ComboBox();
            this.comboBox_GPI2 = new System.Windows.Forms.ComboBox();
            this.comboBox_GPI1 = new System.Windows.Forms.ComboBox();
            this.groupBox_GPO = new System.Windows.Forms.GroupBox();
            this.checkBox_GPO4 = new System.Windows.Forms.CheckBox();
            this.checkBox_GPO3 = new System.Windows.Forms.CheckBox();
            this.checkBox_GPO2 = new System.Windows.Forms.CheckBox();
            this.checkBox_GPO1 = new System.Windows.Forms.CheckBox();
            this.comboBox_GPO4 = new System.Windows.Forms.ComboBox();
            this.comboBox_GPO3 = new System.Windows.Forms.ComboBox();
            this.comboBox_GPO2 = new System.Windows.Forms.ComboBox();
            this.comboBox_GPO1 = new System.Windows.Forms.ComboBox();
            this.gbxIoControl = new System.Windows.Forms.GroupBox();
            this.cbxIoDircetion = new System.Windows.Forms.ComboBox();
            this.cbxIoLevel = new System.Windows.Forms.ComboBox();
            this.btnSetIoDirection = new System.Windows.Forms.Button();
            this.cbxIO = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnGetMode = new System.Windows.Forms.Button();
            this.btnSetModuleSleep = new System.Windows.Forms.Button();
            this.bynSaveConfigToNv = new System.Windows.Forms.Button();
            this.cbxSaveNvConfig = new System.Windows.Forms.CheckBox();
            this.cbxMode = new System.Windows.Forms.ComboBox();
            this.btnSetMode = new System.Windows.Forms.Button();
            this.groupBox_RFSetting = new System.Windows.Forms.GroupBox();
            this.gbxRfPower = new System.Windows.Forms.GroupBox();
            this.btnGetPaPower = new System.Windows.Forms.Button();
            this.cbxPaPower = new System.Windows.Forms.ComboBox();
            this.btnSetPaPower = new System.Windows.Forms.Button();
            this.gbx_setfreq = new System.Windows.Forms.GroupBox();
            this.gbx_InsertRFCH = new System.Windows.Forms.GroupBox();
            this.btnInsertRfCh_Help = new System.Windows.Forms.Button();
            this.label47 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.cbxFhssHopPeriod = new System.Windows.Forms.ComboBox();
            this.cbxFHSS = new System.Windows.Forms.ComboBox();
            this.btnGetChannel = new System.Windows.Forms.Button();
            this.cbxChannel = new System.Windows.Forms.ComboBox();
            this.cbxRegion = new System.Windows.Forms.ComboBox();
            this.btnSetFreq = new System.Windows.Forms.Button();
            this.groupBox_RF_Ant = new System.Windows.Forms.GroupBox();
            this.btn_AntQuantityHelp = new System.Windows.Forms.Button();
            this.groupBox_RF_Ant_Port = new System.Windows.Forms.GroupBox();
            this.button_RF_Ant_SetAllParameter = new System.Windows.Forms.Button();
            this.btn_AntAutoPolling_ParametersHelp = new System.Windows.Forms.Button();
            this.groupBox_RF_Ant_Enable = new System.Windows.Forms.GroupBox();
            this.checkBox_RF_Ant_Enable16 = new System.Windows.Forms.CheckBox();
            this.checkBox_RF_Ant_Enable15 = new System.Windows.Forms.CheckBox();
            this.checkBox_RF_Ant_Enable14 = new System.Windows.Forms.CheckBox();
            this.checkBox_RF_Ant_Enable13 = new System.Windows.Forms.CheckBox();
            this.checkBox_RF_Ant_Enable12 = new System.Windows.Forms.CheckBox();
            this.checkBox_RF_Ant_Enable11 = new System.Windows.Forms.CheckBox();
            this.checkBox_RF_Ant_Enable9 = new System.Windows.Forms.CheckBox();
            this.checkBox_RF_Ant_Enable10 = new System.Windows.Forms.CheckBox();
            this.groupBox_RF_Ant_SwitchAnt = new System.Windows.Forms.GroupBox();
            this.radioButton_AntPort12 = new System.Windows.Forms.RadioButton();
            this.radioButton_AntPort16 = new System.Windows.Forms.RadioButton();
            this.radioButton_AntPort15 = new System.Windows.Forms.RadioButton();
            this.radioButton_AntPort11 = new System.Windows.Forms.RadioButton();
            this.radioButton_AntPort14 = new System.Windows.Forms.RadioButton();
            this.radioButton_AntPort10 = new System.Windows.Forms.RadioButton();
            this.radioButton_AntPort13 = new System.Windows.Forms.RadioButton();
            this.radioButton_AntPort9 = new System.Windows.Forms.RadioButton();
            this.label_RF_AntPort_InvCnter = new System.Windows.Forms.Label();
            this.label_RF_AntPort_Power = new System.Windows.Forms.Label();
            this.textBox_RF_AntPort_InvCnter16 = new System.Windows.Forms.TextBox();
            this.comboBoxRF_AntPort_Port16 = new System.Windows.Forms.ComboBox();
            this.comboBoxRF_AntPort_Port15 = new System.Windows.Forms.ComboBox();
            this.textBox_RF_AntPort_InvCnter15 = new System.Windows.Forms.TextBox();
            this.textBox_RF_AntPort_InvCnter14 = new System.Windows.Forms.TextBox();
            this.comboBoxRF_AntPort_Port14 = new System.Windows.Forms.ComboBox();
            this.textBox_RF_AntPort_InvCnter13 = new System.Windows.Forms.TextBox();
            this.comboBoxRF_AntPort_Port13 = new System.Windows.Forms.ComboBox();
            this.textBox_RF_AntPort_InvCnter12 = new System.Windows.Forms.TextBox();
            this.comboBoxRF_AntPort_Port12 = new System.Windows.Forms.ComboBox();
            this.textBox_RF_AntPort_InvCnter11 = new System.Windows.Forms.TextBox();
            this.comboBoxRF_AntPort_Port11 = new System.Windows.Forms.ComboBox();
            this.textBox_RF_AntPort_InvCnter10 = new System.Windows.Forms.TextBox();
            this.comboBoxRF_AntPort_Port10 = new System.Windows.Forms.ComboBox();
            this.textBox_RF_AntPort_InvCnter9 = new System.Windows.Forms.TextBox();
            this.comboBoxRF_AntPort_Port9 = new System.Windows.Forms.ComboBox();
            this.ExtCommand = new System.Windows.Forms.TabPage();
            this.BeepModeComboBox = new System.Windows.Forms.ComboBox();
            this.label64 = new System.Windows.Forms.Label();
            this.BtnGetReaderWorkMode = new System.Windows.Forms.Button();
            this.BtnSetReaderWorkMode = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.BtnFillTagData = new System.Windows.Forms.Button();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.label51 = new System.Windows.Forms.Label();
            this.EDIT_TAG_MATCHED_DATA5 = new System.Windows.Forms.TextBox();
            this.COMBO_TAG_MATCHED_BYTELEN5 = new System.Windows.Forms.ComboBox();
            this.label52 = new System.Windows.Forms.Label();
            this.Btn_Set_EnableModeOff = new System.Windows.Forms.Button();
            this.Btn_Set_EnableModeOn = new System.Windows.Forms.Button();
            this.MatchedNumberComboBox = new System.Windows.Forms.ComboBox();
            this.MatchedModeComboBox = new System.Windows.Forms.ComboBox();
            this.label56 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.Btn_Get_EnableMode21 = new System.Windows.Forms.Button();
            this.Btn_Get_Mode11 = new System.Windows.Forms.Button();
            this.Btn_Set_Mode00 = new System.Windows.Forms.Button();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label49 = new System.Windows.Forms.Label();
            this.EDIT_TAG_MATCHED_DATA4 = new System.Windows.Forms.TextBox();
            this.COMBO_TAG_MATCHED_BYTELEN4 = new System.Windows.Forms.ComboBox();
            this.label50 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label41 = new System.Windows.Forms.Label();
            this.EDIT_TAG_MATCHED_DATA3 = new System.Windows.Forms.TextBox();
            this.COMBO_TAG_MATCHED_BYTELEN3 = new System.Windows.Forms.ComboBox();
            this.label48 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label38 = new System.Windows.Forms.Label();
            this.EDIT_TAG_MATCHED_DATA2 = new System.Windows.Forms.TextBox();
            this.COMBO_TAG_MATCHED_BYTELEN2 = new System.Windows.Forms.ComboBox();
            this.label40 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label36 = new System.Windows.Forms.Label();
            this.EDIT_TAG_MATCHED_DATA1 = new System.Windows.Forms.TextBox();
            this.COMBO_TAG_MATCHED_BYTELEN1 = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.BtnGetBeepStatus = new System.Windows.Forms.Button();
            this.BtnSetBeepMode = new System.Windows.Forms.Button();
            this.ReaderWorkModeComboBox = new System.Windows.Forms.ComboBox();
            this.BtnSettingDefaultWorkParam = new System.Windows.Forms.Button();
            this.label58 = new System.Windows.Forms.Label();
            this.gbxRdIntrgtMem = new System.Windows.Forms.GroupBox();
            this.timerCheckReader = new System.Windows.Forms.Timer(this.components);
            this.tmrCheckEpc = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStripInfor = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.label_dllversion = new System.Windows.Forms.Label();
            this.gbx_conn.SuspendLayout();
            this.gbx_NewDevAddr.SuspendLayout();
            this.gbxRxData.SuspendLayout();
            this.gbx_inventory.SuspendLayout();
            this.gbx_MTR.SuspendLayout();
            this.gbx_Access.SuspendLayout();
            this.gbx_MTR_LoopNum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEpcBasic)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.gbxEpcTableBasic.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage_TagRead.SuspendLayout();
            this.tabPage_SysSetting.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.gbxStatus.SuspendLayout();
            this.tabPageAccessTag.SuspendLayout();
            this.tabControl4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.gbxSelect.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.gbxSetQuery.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbxAccess.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gBxLock.SuspendLayout();
            this.gbxKill.SuspendLayout();
            this.gbxStatus2.SuspendLayout();
            this.gbx_comcnt_adv.SuspendLayout();
            this.gbxEpcTableAdv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_epc2)).BeginInit();
            this.tabPageSysSetting.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox_GPIO.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox_GPO.SuspendLayout();
            this.gbxIoControl.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox_RFSetting.SuspendLayout();
            this.gbxRfPower.SuspendLayout();
            this.gbx_setfreq.SuspendLayout();
            this.gbx_InsertRFCH.SuspendLayout();
            this.groupBox_RF_Ant.SuspendLayout();
            this.groupBox_RF_Ant_Port.SuspendLayout();
            this.groupBox_RF_Ant_Enable.SuspendLayout();
            this.groupBox_RF_Ant_SwitchAnt.SuspendLayout();
            this.ExtCommand.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.statusStripInfor.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_conn
            // 
            this.gbx_conn.Controls.Add(this.radioCommRS485);
            this.gbx_conn.Controls.Add(this.radioCommRS232);
            this.gbx_conn.Controls.Add(this.checkBox_WorkMode);
            this.gbx_conn.Controls.Add(this.cbxDeviceAddr);
            this.gbx_conn.Controls.Add(this.label_DeviceAddr);
            this.gbx_conn.Controls.Add(this.Reset_FW);
            this.gbx_conn.Controls.Add(this.label2);
            this.gbx_conn.Controls.Add(this.label1);
            this.gbx_conn.Controls.Add(this.cbxPort);
            this.gbx_conn.Controls.Add(this.cbxBaudRate);
            this.gbx_conn.Controls.Add(this.btnConn);
            this.gbx_conn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_conn.Location = new System.Drawing.Point(755, 6);
            this.gbx_conn.Name = "gbx_conn";
            this.gbx_conn.Size = new System.Drawing.Size(305, 131);
            this.gbx_conn.TabIndex = 0;
            this.gbx_conn.TabStop = false;
            this.gbx_conn.Text = "SerialPort Connection";
            // 
            // radioCommRS485
            // 
            this.radioCommRS485.AutoSize = true;
            this.radioCommRS485.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.radioCommRS485.Location = new System.Drawing.Point(180, 106);
            this.radioCommRS485.Name = "radioCommRS485";
            this.radioCommRS485.Size = new System.Drawing.Size(62, 19);
            this.radioCommRS485.TabIndex = 26;
            this.radioCommRS485.Text = "RS485";
            this.radioCommRS485.UseVisualStyleBackColor = false;
            this.radioCommRS485.Click += new System.EventHandler(this.radioCommRS485_Click);
            // 
            // radioCommRS232
            // 
            this.radioCommRS232.AutoSize = true;
            this.radioCommRS232.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.radioCommRS232.Checked = true;
            this.radioCommRS232.Location = new System.Drawing.Point(86, 106);
            this.radioCommRS232.Name = "radioCommRS232";
            this.radioCommRS232.Size = new System.Drawing.Size(62, 19);
            this.radioCommRS232.TabIndex = 26;
            this.radioCommRS232.TabStop = true;
            this.radioCommRS232.Text = "RS232";
            this.radioCommRS232.UseVisualStyleBackColor = false;
            this.radioCommRS232.Click += new System.EventHandler(this.radioCommRS232_Click);
            // 
            // checkBox_WorkMode
            // 
            this.checkBox_WorkMode.AutoSize = true;
            this.checkBox_WorkMode.Location = new System.Drawing.Point(148, 11);
            this.checkBox_WorkMode.Name = "checkBox_WorkMode";
            this.checkBox_WorkMode.Size = new System.Drawing.Size(147, 19);
            this.checkBox_WorkMode.TabIndex = 25;
            this.checkBox_WorkMode.Text = "Polling&&Trigger Mode";
            this.toolTip1.SetToolTip(this.checkBox_WorkMode, "When Polling&Trigger Mode is selected, DEMO will not send any command to a reader" +
                    " to keep the reader in Polling or Trigger Mode, and listen the API frame from th" +
                    "e Polling Reader.");
            this.checkBox_WorkMode.UseVisualStyleBackColor = true;
            // 
            // cbxDeviceAddr
            // 
            this.cbxDeviceAddr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDeviceAddr.FormattingEnabled = true;
            this.cbxDeviceAddr.Location = new System.Drawing.Point(210, 81);
            this.cbxDeviceAddr.Name = "cbxDeviceAddr";
            this.cbxDeviceAddr.Size = new System.Drawing.Size(89, 23);
            this.cbxDeviceAddr.TabIndex = 23;
            this.cbxDeviceAddr.SelectedIndexChanged += new System.EventHandler(this.cbxDeviceAddr_SelectedIndexChanged);
            // 
            // label_DeviceAddr
            // 
            this.label_DeviceAddr.AutoSize = true;
            this.label_DeviceAddr.Location = new System.Drawing.Point(136, 86);
            this.label_DeviceAddr.Name = "label_DeviceAddr";
            this.label_DeviceAddr.Size = new System.Drawing.Size(75, 15);
            this.label_DeviceAddr.TabIndex = 24;
            this.label_DeviceAddr.Text = "Device Addr";
            // 
            // Reset_FW
            // 
            this.Reset_FW.BackColor = System.Drawing.SystemColors.Control;
            this.Reset_FW.Location = new System.Drawing.Point(8, 79);
            this.Reset_FW.Name = "Reset_FW";
            this.Reset_FW.Size = new System.Drawing.Size(122, 26);
            this.Reset_FW.TabIndex = 22;
            this.Reset_FW.Text = "Reset_FW";
            this.toolTip1.SetToolTip(this.Reset_FW, "Reset the Reader(USB should be replug after reset.)");
            this.Reset_FW.UseVisualStyleBackColor = true;
            this.Reset_FW.Click += new System.EventHandler(this.Reset_FW_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Baud Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Port No.";
            // 
            // cbxPort
            // 
            this.cbxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPort.FormattingEnabled = true;
            this.cbxPort.Location = new System.Drawing.Point(210, 31);
            this.cbxPort.Name = "cbxPort";
            this.cbxPort.Size = new System.Drawing.Size(89, 23);
            this.cbxPort.TabIndex = 2;
            this.cbxPort.DropDown += new System.EventHandler(this.cbxPort_DropDown);
            // 
            // cbxBaudRate
            // 
            this.cbxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBaudRate.FormattingEnabled = true;
            this.cbxBaudRate.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cbxBaudRate.Location = new System.Drawing.Point(210, 56);
            this.cbxBaudRate.Name = "cbxBaudRate";
            this.cbxBaudRate.Size = new System.Drawing.Size(89, 23);
            this.cbxBaudRate.TabIndex = 1;
            // 
            // btnConn
            // 
            this.btnConn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnConn.Enabled = false;
            this.btnConn.Location = new System.Drawing.Point(8, 22);
            this.btnConn.Name = "btnConn";
            this.btnConn.Size = new System.Drawing.Size(122, 51);
            this.btnConn.TabIndex = 0;
            this.btnConn.Tag = "0";
            this.btnConn.Text = "Connect";
            this.toolTip1.SetToolTip(this.btnConn, "Connect or Close the reader by serial port or USB serial port.");
            this.btnConn.UseVisualStyleBackColor = false;
            this.btnConn.Click += new System.EventHandler(this.btnConn_Click);
            // 
            // gbx_NewDevAddr
            // 
            this.gbx_NewDevAddr.Controls.Add(this.cbxNewDeviceAddr);
            this.gbx_NewDevAddr.Controls.Add(this.btn_SetReaderDeviceAddr);
            this.gbx_NewDevAddr.Controls.Add(this.btn_GetReaderDeviceAddr);
            this.gbx_NewDevAddr.Location = new System.Drawing.Point(6, 6);
            this.gbx_NewDevAddr.Name = "gbx_NewDevAddr";
            this.gbx_NewDevAddr.Size = new System.Drawing.Size(284, 58);
            this.gbx_NewDevAddr.TabIndex = 27;
            this.gbx_NewDevAddr.TabStop = false;
            this.gbx_NewDevAddr.Text = "New Device Address";
            // 
            // cbxNewDeviceAddr
            // 
            this.cbxNewDeviceAddr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNewDeviceAddr.FormattingEnabled = true;
            this.cbxNewDeviceAddr.Location = new System.Drawing.Point(83, 23);
            this.cbxNewDeviceAddr.Name = "cbxNewDeviceAddr";
            this.cbxNewDeviceAddr.Size = new System.Drawing.Size(118, 23);
            this.cbxNewDeviceAddr.TabIndex = 26;
            // 
            // btn_SetReaderDeviceAddr
            // 
            this.btn_SetReaderDeviceAddr.Location = new System.Drawing.Point(207, 20);
            this.btn_SetReaderDeviceAddr.Name = "btn_SetReaderDeviceAddr";
            this.btn_SetReaderDeviceAddr.Size = new System.Drawing.Size(71, 26);
            this.btn_SetReaderDeviceAddr.TabIndex = 25;
            this.btn_SetReaderDeviceAddr.Text = "Set";
            this.toolTip1.SetToolTip(this.btn_SetReaderDeviceAddr, "Set the Reader\'s Device Addresss.");
            this.btn_SetReaderDeviceAddr.UseVisualStyleBackColor = true;
            this.btn_SetReaderDeviceAddr.Click += new System.EventHandler(this.btn_SetReaderDeviceAddr_Click);
            // 
            // btn_GetReaderDeviceAddr
            // 
            this.btn_GetReaderDeviceAddr.Location = new System.Drawing.Point(6, 20);
            this.btn_GetReaderDeviceAddr.Name = "btn_GetReaderDeviceAddr";
            this.btn_GetReaderDeviceAddr.Size = new System.Drawing.Size(71, 26);
            this.btn_GetReaderDeviceAddr.TabIndex = 26;
            this.btn_GetReaderDeviceAddr.Text = "Get";
            this.toolTip1.SetToolTip(this.btn_GetReaderDeviceAddr, "Get the Reader\'s Device Addresss.");
            this.btn_GetReaderDeviceAddr.UseVisualStyleBackColor = true;
            this.btn_GetReaderDeviceAddr.Click += new System.EventHandler(this.btn_GetReaderDeviceAddr_Click);
            // 
            // btnSetFhss
            // 
            this.btnSetFhss.Location = new System.Drawing.Point(6, 202);
            this.btnSetFhss.Name = "btnSetFhss";
            this.btnSetFhss.Size = new System.Drawing.Size(87, 29);
            this.btnSetFhss.TabIndex = 5;
            this.btnSetFhss.Text = "Set FHSS";
            this.toolTip1.SetToolTip(this.btnSetFhss, "Set Frequency Hopping (FHSS: Frequency-Hopping Spread Spectrum)");
            this.btnSetFhss.UseVisualStyleBackColor = true;
            this.btnSetFhss.Click += new System.EventHandler(this.btnSetFhss_Click);
            // 
            // btnGetFhss
            // 
            this.btnGetFhss.Location = new System.Drawing.Point(103, 202);
            this.btnGetFhss.Name = "btnGetFhss";
            this.btnGetFhss.Size = new System.Drawing.Size(87, 29);
            this.btnGetFhss.TabIndex = 17;
            this.btnGetFhss.Text = "Get FHSS";
            this.toolTip1.SetToolTip(this.btnGetFhss, "Get the status of Frequency Hopping");
            this.btnGetFhss.UseVisualStyleBackColor = true;
            this.btnGetFhss.Click += new System.EventHandler(this.btnGetFhss_Click);
            // 
            // btnSetFreqHopPeriod
            // 
            this.btnSetFreqHopPeriod.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetFreqHopPeriod.Location = new System.Drawing.Point(6, 242);
            this.btnSetFreqHopPeriod.Name = "btnSetFreqHopPeriod";
            this.btnSetFreqHopPeriod.Size = new System.Drawing.Size(87, 29);
            this.btnSetFreqHopPeriod.TabIndex = 21;
            this.btnSetFreqHopPeriod.Text = "Set Period";
            this.toolTip1.SetToolTip(this.btnSetFreqHopPeriod, "Set the Period of FHSS (R2000 inside only)");
            this.btnSetFreqHopPeriod.UseVisualStyleBackColor = true;
            this.btnSetFreqHopPeriod.Click += new System.EventHandler(this.btnSetFreqHopPeriod_Click);
            // 
            // btnGetFreqHopPeriod
            // 
            this.btnGetFreqHopPeriod.Location = new System.Drawing.Point(103, 242);
            this.btnGetFreqHopPeriod.Name = "btnGetFreqHopPeriod";
            this.btnGetFreqHopPeriod.Size = new System.Drawing.Size(87, 29);
            this.btnGetFreqHopPeriod.TabIndex = 22;
            this.btnGetFreqHopPeriod.Text = "Get Period";
            this.toolTip1.SetToolTip(this.btnGetFreqHopPeriod, "Get the Period of FHSS (R2000 inside only)");
            this.btnGetFreqHopPeriod.UseVisualStyleBackColor = true;
            this.btnGetFreqHopPeriod.Click += new System.EventHandler(this.btnGetFreqHopPeriod_Click);
            // 
            // btnInvtBasic
            // 
            this.btnInvtBasic.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvtBasic.Location = new System.Drawing.Point(13, 19);
            this.btnInvtBasic.Name = "btnInvtBasic";
            this.btnInvtBasic.Size = new System.Drawing.Size(147, 29);
            this.btnInvtBasic.TabIndex = 0;
            this.btnInvtBasic.Text = "Read Single";
            this.toolTip1.SetToolTip(this.btnInvtBasic, "Read the tags only once.");
            this.btnInvtBasic.UseVisualStyleBackColor = true;
            this.btnInvtBasic.Click += new System.EventHandler(this.btn_invt_Click);
            // 
            // txtRDMultiNum
            // 
            this.txtRDMultiNum.Location = new System.Drawing.Point(50, 20);
            this.txtRDMultiNum.Name = "txtRDMultiNum";
            this.txtRDMultiNum.Size = new System.Drawing.Size(99, 21);
            this.txtRDMultiNum.TabIndex = 12;
            this.txtRDMultiNum.Text = "0";
            this.txtRDMultiNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtRDMultiNum, "Auto stop inventory when Loop Number of Inventory Tag is ending.");
            // 
            // cbx_MTR_Algorithm
            // 
            this.cbx_MTR_Algorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_MTR_Algorithm.FormattingEnabled = true;
            this.cbx_MTR_Algorithm.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.cbx_MTR_Algorithm.Location = new System.Drawing.Point(71, 58);
            this.cbx_MTR_Algorithm.Name = "cbx_MTR_Algorithm";
            this.cbx_MTR_Algorithm.Size = new System.Drawing.Size(42, 23);
            this.cbx_MTR_Algorithm.TabIndex = 18;
            this.toolTip1.SetToolTip(this.cbx_MTR_Algorithm, "Algorithm of Inventory Tag according to the application");
            // 
            // cbx_MTR_Qvalue
            // 
            this.cbx_MTR_Qvalue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_MTR_Qvalue.FormattingEnabled = true;
            this.cbx_MTR_Qvalue.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cbx_MTR_Qvalue.Location = new System.Drawing.Point(71, 29);
            this.cbx_MTR_Qvalue.Name = "cbx_MTR_Qvalue";
            this.cbx_MTR_Qvalue.Size = new System.Drawing.Size(42, 23);
            this.cbx_MTR_Qvalue.TabIndex = 15;
            this.toolTip1.SetToolTip(this.cbx_MTR_Qvalue, "Q Value for Inventory Tag operaiton. (2**Q)");
            // 
            // btnStopRD
            // 
            this.btnStopRD.Location = new System.Drawing.Point(164, 115);
            this.btnStopRD.Name = "btnStopRD";
            this.btnStopRD.Size = new System.Drawing.Size(115, 36);
            this.btnStopRD.TabIndex = 13;
            this.btnStopRD.Text = "Stop Read";
            this.toolTip1.SetToolTip(this.btnStopRD, "Stop Multi-Tag Read operation.");
            this.btnStopRD.UseVisualStyleBackColor = true;
            this.btnStopRD.Click += new System.EventHandler(this.btn_stop_rd_Click);
            // 
            // btnInvtMulti
            // 
            this.btnInvtMulti.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvtMulti.Location = new System.Drawing.Point(5, 115);
            this.btnInvtMulti.Name = "btnInvtMulti";
            this.btnInvtMulti.Size = new System.Drawing.Size(149, 36);
            this.btnInvtMulti.TabIndex = 11;
            this.btnInvtMulti.Text = "Read Multi-Tag";
            this.toolTip1.SetToolTip(this.btnInvtMulti, "Start Multi-Tag Read operation.");
            this.btnInvtMulti.UseVisualStyleBackColor = true;
            this.btnInvtMulti.Click += new System.EventHandler(this.btn_invt_multi_Click);
            // 
            // btnSetCW
            // 
            this.btnSetCW.Location = new System.Drawing.Point(9, 62);
            this.btnSetCW.Name = "btnSetCW";
            this.btnSetCW.Size = new System.Drawing.Size(99, 29);
            this.btnSetCW.TabIndex = 4;
            this.btnSetCW.Text = "CW ON";
            this.toolTip1.SetToolTip(this.btnSetCW, "Continuous RF Wave On or Off (for test only after Set FHSS Off)");
            this.btnSetCW.UseVisualStyleBackColor = true;
            this.btnSetCW.Click += new System.EventHandler(this.btnSetCW_Click);
            // 
            // button_RF_Ant_Get
            // 
            this.button_RF_Ant_Get.Location = new System.Drawing.Point(65, 566);
            this.button_RF_Ant_Get.Name = "button_RF_Ant_Get";
            this.button_RF_Ant_Get.Size = new System.Drawing.Size(97, 40);
            this.button_RF_Ant_Get.TabIndex = 28;
            this.button_RF_Ant_Get.Text = "Get";
            this.toolTip1.SetToolTip(this.button_RF_Ant_Get, "Get the antenna setting.");
            this.button_RF_Ant_Get.UseVisualStyleBackColor = true;
            this.button_RF_Ant_Get.Click += new System.EventHandler(this.button_RF_Ant_Get_Click);
            // 
            // button_RF_Ant_Set
            // 
            this.button_RF_Ant_Set.Location = new System.Drawing.Point(256, 566);
            this.button_RF_Ant_Set.Name = "button_RF_Ant_Set";
            this.button_RF_Ant_Set.Size = new System.Drawing.Size(97, 40);
            this.button_RF_Ant_Set.TabIndex = 27;
            this.button_RF_Ant_Set.Text = "Set";
            this.toolTip1.SetToolTip(this.button_RF_Ant_Set, "Set the antenna setting.");
            this.button_RF_Ant_Set.UseVisualStyleBackColor = true;
            this.button_RF_Ant_Set.Click += new System.EventHandler(this.button_RF_Ant_Set_Click);
            // 
            // button_RF_Ant_GetCurrentAntPort
            // 
            this.button_RF_Ant_GetCurrentAntPort.Location = new System.Drawing.Point(12, 477);
            this.button_RF_Ant_GetCurrentAntPort.Name = "button_RF_Ant_GetCurrentAntPort";
            this.button_RF_Ant_GetCurrentAntPort.Size = new System.Drawing.Size(144, 29);
            this.button_RF_Ant_GetCurrentAntPort.TabIndex = 28;
            this.button_RF_Ant_GetCurrentAntPort.Text = "Get Current ANT Port";
            this.toolTip1.SetToolTip(this.button_RF_Ant_GetCurrentAntPort, "Check current work antenna port of current reader.");
            this.button_RF_Ant_GetCurrentAntPort.UseVisualStyleBackColor = true;
            this.button_RF_Ant_GetCurrentAntPort.Click += new System.EventHandler(this.button_RF_Ant_GetCurrentAntPort_Click);
            // 
            // checkBox_RF_Ant_Enable8
            // 
            this.checkBox_RF_Ant_Enable8.AutoSize = true;
            this.checkBox_RF_Ant_Enable8.Enabled = false;
            this.checkBox_RF_Ant_Enable8.Location = new System.Drawing.Point(19, 209);
            this.checkBox_RF_Ant_Enable8.Name = "checkBox_RF_Ant_Enable8";
            this.checkBox_RF_Ant_Enable8.Size = new System.Drawing.Size(56, 19);
            this.checkBox_RF_Ant_Enable8.TabIndex = 34;
            this.checkBox_RF_Ant_Enable8.Text = "ANT8";
            this.toolTip1.SetToolTip(this.checkBox_RF_Ant_Enable8, "Enable the antenna port if this antenna is connected by an valid antenna. Otherwi" +
                    "se disable it.");
            this.checkBox_RF_Ant_Enable8.UseVisualStyleBackColor = true;
            // 
            // checkBox_RF_Ant_Enable7
            // 
            this.checkBox_RF_Ant_Enable7.AutoSize = true;
            this.checkBox_RF_Ant_Enable7.Enabled = false;
            this.checkBox_RF_Ant_Enable7.Location = new System.Drawing.Point(19, 184);
            this.checkBox_RF_Ant_Enable7.Name = "checkBox_RF_Ant_Enable7";
            this.checkBox_RF_Ant_Enable7.Size = new System.Drawing.Size(56, 19);
            this.checkBox_RF_Ant_Enable7.TabIndex = 33;
            this.checkBox_RF_Ant_Enable7.Text = "ANT7";
            this.toolTip1.SetToolTip(this.checkBox_RF_Ant_Enable7, "Enable the antenna port if this antenna is connected by an valid antenna. Otherwi" +
                    "se disable it.");
            this.checkBox_RF_Ant_Enable7.UseVisualStyleBackColor = true;
            // 
            // checkBox_RF_Ant_Enable6
            // 
            this.checkBox_RF_Ant_Enable6.AutoSize = true;
            this.checkBox_RF_Ant_Enable6.Enabled = false;
            this.checkBox_RF_Ant_Enable6.Location = new System.Drawing.Point(19, 157);
            this.checkBox_RF_Ant_Enable6.Name = "checkBox_RF_Ant_Enable6";
            this.checkBox_RF_Ant_Enable6.Size = new System.Drawing.Size(56, 19);
            this.checkBox_RF_Ant_Enable6.TabIndex = 32;
            this.checkBox_RF_Ant_Enable6.Text = "ANT6";
            this.toolTip1.SetToolTip(this.checkBox_RF_Ant_Enable6, "Enable the antenna port if this antenna is connected by an valid antenna. Otherwi" +
                    "se disable it.");
            this.checkBox_RF_Ant_Enable6.UseVisualStyleBackColor = true;
            // 
            // checkBox_RF_Ant_Enable5
            // 
            this.checkBox_RF_Ant_Enable5.AutoSize = true;
            this.checkBox_RF_Ant_Enable5.Enabled = false;
            this.checkBox_RF_Ant_Enable5.Location = new System.Drawing.Point(19, 130);
            this.checkBox_RF_Ant_Enable5.Name = "checkBox_RF_Ant_Enable5";
            this.checkBox_RF_Ant_Enable5.Size = new System.Drawing.Size(56, 19);
            this.checkBox_RF_Ant_Enable5.TabIndex = 31;
            this.checkBox_RF_Ant_Enable5.Text = "ANT5";
            this.toolTip1.SetToolTip(this.checkBox_RF_Ant_Enable5, "Enable the antenna port if this antenna is connected by an valid antenna. Otherwi" +
                    "se disable it.");
            this.checkBox_RF_Ant_Enable5.UseVisualStyleBackColor = true;
            // 
            // checkBox_RF_Ant_Enable4
            // 
            this.checkBox_RF_Ant_Enable4.AutoSize = true;
            this.checkBox_RF_Ant_Enable4.Enabled = false;
            this.checkBox_RF_Ant_Enable4.Location = new System.Drawing.Point(19, 103);
            this.checkBox_RF_Ant_Enable4.Name = "checkBox_RF_Ant_Enable4";
            this.checkBox_RF_Ant_Enable4.Size = new System.Drawing.Size(56, 19);
            this.checkBox_RF_Ant_Enable4.TabIndex = 30;
            this.checkBox_RF_Ant_Enable4.Text = "ANT4";
            this.toolTip1.SetToolTip(this.checkBox_RF_Ant_Enable4, "Enable the antenna port if this antenna is connected by an valid antenna. Otherwi" +
                    "se disable it.");
            this.checkBox_RF_Ant_Enable4.UseVisualStyleBackColor = true;
            // 
            // checkBox_RF_Ant_Enable3
            // 
            this.checkBox_RF_Ant_Enable3.AutoSize = true;
            this.checkBox_RF_Ant_Enable3.Enabled = false;
            this.checkBox_RF_Ant_Enable3.Location = new System.Drawing.Point(19, 76);
            this.checkBox_RF_Ant_Enable3.Name = "checkBox_RF_Ant_Enable3";
            this.checkBox_RF_Ant_Enable3.Size = new System.Drawing.Size(56, 19);
            this.checkBox_RF_Ant_Enable3.TabIndex = 29;
            this.checkBox_RF_Ant_Enable3.Text = "ANT3";
            this.toolTip1.SetToolTip(this.checkBox_RF_Ant_Enable3, "Enable the antenna port if this antenna is connected by an valid antenna. Otherwi" +
                    "se disable it.");
            this.checkBox_RF_Ant_Enable3.UseVisualStyleBackColor = true;
            // 
            // checkBox_RF_Ant_Enable2
            // 
            this.checkBox_RF_Ant_Enable2.AutoSize = true;
            this.checkBox_RF_Ant_Enable2.Enabled = false;
            this.checkBox_RF_Ant_Enable2.Location = new System.Drawing.Point(19, 49);
            this.checkBox_RF_Ant_Enable2.Name = "checkBox_RF_Ant_Enable2";
            this.checkBox_RF_Ant_Enable2.Size = new System.Drawing.Size(56, 19);
            this.checkBox_RF_Ant_Enable2.TabIndex = 28;
            this.checkBox_RF_Ant_Enable2.Text = "ANT2";
            this.toolTip1.SetToolTip(this.checkBox_RF_Ant_Enable2, "Enable the antenna port if this antenna is connected by an valid antenna. Otherwi" +
                    "se disable it.");
            this.checkBox_RF_Ant_Enable2.UseVisualStyleBackColor = true;
            // 
            // checkBox_RF_Ant_Enable1
            // 
            this.checkBox_RF_Ant_Enable1.AutoSize = true;
            this.checkBox_RF_Ant_Enable1.Checked = true;
            this.checkBox_RF_Ant_Enable1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_RF_Ant_Enable1.Location = new System.Drawing.Point(19, 22);
            this.checkBox_RF_Ant_Enable1.Name = "checkBox_RF_Ant_Enable1";
            this.checkBox_RF_Ant_Enable1.Size = new System.Drawing.Size(56, 19);
            this.checkBox_RF_Ant_Enable1.TabIndex = 27;
            this.checkBox_RF_Ant_Enable1.Text = "ANT1";
            this.toolTip1.SetToolTip(this.checkBox_RF_Ant_Enable1, "Enable the antenna port if this antenna is connected by an valid antenna. Otherwi" +
                    "se disable it.");
            this.checkBox_RF_Ant_Enable1.UseVisualStyleBackColor = true;
            this.checkBox_RF_Ant_Enable1.CheckedChanged += new System.EventHandler(this.checkBox_RF_Ant_Enable1_CheckedChanged);
            // 
            // radioButton_AntPort7
            // 
            this.radioButton_AntPort7.AutoSize = true;
            this.radioButton_AntPort7.Enabled = false;
            this.radioButton_AntPort7.Location = new System.Drawing.Point(18, 184);
            this.radioButton_AntPort7.Name = "radioButton_AntPort7";
            this.radioButton_AntPort7.Size = new System.Drawing.Size(55, 19);
            this.radioButton_AntPort7.TabIndex = 6;
            this.radioButton_AntPort7.TabStop = true;
            this.radioButton_AntPort7.Text = "ANT7";
            this.toolTip1.SetToolTip(this.radioButton_AntPort7, "Switch the current work antenna to this Antenna port. (API encode: 06)");
            this.radioButton_AntPort7.UseVisualStyleBackColor = true;
            this.radioButton_AntPort7.Click += new System.EventHandler(this.radioButton_AntPort7_Click);
            // 
            // radioButton_AntPort6
            // 
            this.radioButton_AntPort6.AutoSize = true;
            this.radioButton_AntPort6.Enabled = false;
            this.radioButton_AntPort6.Location = new System.Drawing.Point(18, 157);
            this.radioButton_AntPort6.Name = "radioButton_AntPort6";
            this.radioButton_AntPort6.Size = new System.Drawing.Size(55, 19);
            this.radioButton_AntPort6.TabIndex = 5;
            this.radioButton_AntPort6.TabStop = true;
            this.radioButton_AntPort6.Text = "ANT6";
            this.toolTip1.SetToolTip(this.radioButton_AntPort6, "Switch the current work antenna to this Antenna port. (API encode: 05)");
            this.radioButton_AntPort6.UseVisualStyleBackColor = true;
            this.radioButton_AntPort6.Click += new System.EventHandler(this.radioButton_AntPort6_Click);
            // 
            // radioButton_AntPort5
            // 
            this.radioButton_AntPort5.AutoSize = true;
            this.radioButton_AntPort5.Enabled = false;
            this.radioButton_AntPort5.Location = new System.Drawing.Point(18, 130);
            this.radioButton_AntPort5.Name = "radioButton_AntPort5";
            this.radioButton_AntPort5.Size = new System.Drawing.Size(55, 19);
            this.radioButton_AntPort5.TabIndex = 4;
            this.radioButton_AntPort5.TabStop = true;
            this.radioButton_AntPort5.Text = "ANT5";
            this.toolTip1.SetToolTip(this.radioButton_AntPort5, "Switch the current work antenna to this Antenna port. (API encode: 04)");
            this.radioButton_AntPort5.UseVisualStyleBackColor = true;
            this.radioButton_AntPort5.Click += new System.EventHandler(this.radioButton_AntPort5_Click);
            // 
            // radioButton_AntPort4
            // 
            this.radioButton_AntPort4.AutoSize = true;
            this.radioButton_AntPort4.Enabled = false;
            this.radioButton_AntPort4.Location = new System.Drawing.Point(18, 103);
            this.radioButton_AntPort4.Name = "radioButton_AntPort4";
            this.radioButton_AntPort4.Size = new System.Drawing.Size(55, 19);
            this.radioButton_AntPort4.TabIndex = 3;
            this.radioButton_AntPort4.TabStop = true;
            this.radioButton_AntPort4.Text = "ANT4";
            this.toolTip1.SetToolTip(this.radioButton_AntPort4, "Switch the current work antenna to this Antenna port. (API encode: 03)");
            this.radioButton_AntPort4.UseVisualStyleBackColor = true;
            this.radioButton_AntPort4.Click += new System.EventHandler(this.radioButton_AntPort4_Click);
            // 
            // radioButton_AntPort3
            // 
            this.radioButton_AntPort3.AutoSize = true;
            this.radioButton_AntPort3.Enabled = false;
            this.radioButton_AntPort3.Location = new System.Drawing.Point(18, 76);
            this.radioButton_AntPort3.Name = "radioButton_AntPort3";
            this.radioButton_AntPort3.Size = new System.Drawing.Size(55, 19);
            this.radioButton_AntPort3.TabIndex = 2;
            this.radioButton_AntPort3.TabStop = true;
            this.radioButton_AntPort3.Text = "ANT3";
            this.toolTip1.SetToolTip(this.radioButton_AntPort3, "Switch the current work antenna to this Antenna port. (API encode: 02)");
            this.radioButton_AntPort3.UseVisualStyleBackColor = true;
            this.radioButton_AntPort3.Click += new System.EventHandler(this.radioButton_AntPort3_Click);
            // 
            // radioButton_AntPort2
            // 
            this.radioButton_AntPort2.AutoSize = true;
            this.radioButton_AntPort2.Enabled = false;
            this.radioButton_AntPort2.Location = new System.Drawing.Point(18, 49);
            this.radioButton_AntPort2.Name = "radioButton_AntPort2";
            this.radioButton_AntPort2.Size = new System.Drawing.Size(55, 19);
            this.radioButton_AntPort2.TabIndex = 1;
            this.radioButton_AntPort2.TabStop = true;
            this.radioButton_AntPort2.Text = "ANT2";
            this.toolTip1.SetToolTip(this.radioButton_AntPort2, "Switch the current work antenna to this Antenna port. (API encode: 01)");
            this.radioButton_AntPort2.UseVisualStyleBackColor = true;
            this.radioButton_AntPort2.Click += new System.EventHandler(this.radioButton_AntPort2_Click);
            // 
            // radioButton_AntPort1
            // 
            this.radioButton_AntPort1.AutoSize = true;
            this.radioButton_AntPort1.Location = new System.Drawing.Point(18, 22);
            this.radioButton_AntPort1.Name = "radioButton_AntPort1";
            this.radioButton_AntPort1.Size = new System.Drawing.Size(55, 19);
            this.radioButton_AntPort1.TabIndex = 0;
            this.radioButton_AntPort1.TabStop = true;
            this.radioButton_AntPort1.Text = "ANT1";
            this.toolTip1.SetToolTip(this.radioButton_AntPort1, "Switch the current work antenna to this Antenna port. (API encode: 00)");
            this.radioButton_AntPort1.UseVisualStyleBackColor = true;
            this.radioButton_AntPort1.Click += new System.EventHandler(this.radioButton_AntPort1_Click);
            // 
            // radioButton_AntPort8
            // 
            this.radioButton_AntPort8.AutoSize = true;
            this.radioButton_AntPort8.Enabled = false;
            this.radioButton_AntPort8.Location = new System.Drawing.Point(18, 209);
            this.radioButton_AntPort8.Name = "radioButton_AntPort8";
            this.radioButton_AntPort8.Size = new System.Drawing.Size(55, 19);
            this.radioButton_AntPort8.TabIndex = 7;
            this.radioButton_AntPort8.TabStop = true;
            this.radioButton_AntPort8.Text = "ANT8";
            this.toolTip1.SetToolTip(this.radioButton_AntPort8, "Switch the current work antenna to this Antenna port. (API encode: 07)");
            this.radioButton_AntPort8.UseVisualStyleBackColor = true;
            this.radioButton_AntPort8.Click += new System.EventHandler(this.radioButton_AntPort8_Click);
            // 
            // textBox_RF_AntPort_InvCnter8
            // 
            this.textBox_RF_AntPort_InvCnter8.Enabled = false;
            this.textBox_RF_AntPort_InvCnter8.Location = new System.Drawing.Point(289, 224);
            this.textBox_RF_AntPort_InvCnter8.Name = "textBox_RF_AntPort_InvCnter8";
            this.textBox_RF_AntPort_InvCnter8.Size = new System.Drawing.Size(71, 21);
            this.textBox_RF_AntPort_InvCnter8.TabIndex = 23;
            this.textBox_RF_AntPort_InvCnter8.Text = "5";
            this.toolTip1.SetToolTip(this.textBox_RF_AntPort_InvCnter8, "Dwell on this antenna port untill number of Inventory tag command has been sent w" +
                    "hen \"Auto Polling\" is enabled.");
            // 
            // comboBoxRF_AntPort_Port8
            // 
            this.comboBoxRF_AntPort_Port8.Enabled = false;
            this.comboBoxRF_AntPort_Port8.FormattingEnabled = true;
            this.comboBoxRF_AntPort_Port8.Items.AddRange(new object[] {
            "33dBm",
            "32dBm",
            "31dBm",
            "30dBm",
            "29dBm",
            "28dBm",
            "27dBm",
            "26dBm",
            "25dBm",
            "24dBm",
            "23dBm",
            "22dBm",
            "21dBm",
            "20dBm",
            "19dBm",
            "18dBm",
            "17dBm",
            "16dBm",
            "15dBm",
            "14dBm",
            "13dBm",
            "12dBm",
            "11dBm",
            "10dBm",
            "09dBm",
            "08dBm",
            "07dBm",
            "06dBm",
            "05dBm",
            "04dBm",
            "03dBm",
            "02dBm",
            "01dBm",
            "00dBm"});
            this.comboBoxRF_AntPort_Port8.Location = new System.Drawing.Point(185, 224);
            this.comboBoxRF_AntPort_Port8.Name = "comboBoxRF_AntPort_Port8";
            this.comboBoxRF_AntPort_Port8.Size = new System.Drawing.Size(71, 23);
            this.comboBoxRF_AntPort_Port8.TabIndex = 22;
            this.toolTip1.SetToolTip(this.comboBoxRF_AntPort_Port8, "Independ RF Power for each antenna port when \"Auto Polling\" is enabled.");
            // 
            // textBox_RF_AntPort_InvCnter7
            // 
            this.textBox_RF_AntPort_InvCnter7.Enabled = false;
            this.textBox_RF_AntPort_InvCnter7.Location = new System.Drawing.Point(289, 198);
            this.textBox_RF_AntPort_InvCnter7.Name = "textBox_RF_AntPort_InvCnter7";
            this.textBox_RF_AntPort_InvCnter7.Size = new System.Drawing.Size(71, 21);
            this.textBox_RF_AntPort_InvCnter7.TabIndex = 21;
            this.textBox_RF_AntPort_InvCnter7.Text = "5";
            this.toolTip1.SetToolTip(this.textBox_RF_AntPort_InvCnter7, "Dwell on this antenna port untill number of Inventory tag command has been sent w" +
                    "hen \"Auto Polling\" is enabled.");
            // 
            // comboBoxRF_AntPort_Port7
            // 
            this.comboBoxRF_AntPort_Port7.Enabled = false;
            this.comboBoxRF_AntPort_Port7.FormattingEnabled = true;
            this.comboBoxRF_AntPort_Port7.Items.AddRange(new object[] {
            "33dBm",
            "32dBm",
            "31dBm",
            "30dBm",
            "29dBm",
            "28dBm",
            "27dBm",
            "26dBm",
            "25dBm",
            "24dBm",
            "23dBm",
            "22dBm",
            "21dBm",
            "20dBm",
            "19dBm",
            "18dBm",
            "17dBm",
            "16dBm",
            "15dBm",
            "14dBm",
            "13dBm",
            "12dBm",
            "11dBm",
            "10dBm",
            "09dBm",
            "08dBm",
            "07dBm",
            "06dBm",
            "05dBm",
            "04dBm",
            "03dBm",
            "02dBm",
            "01dBm",
            "00dBm"});
            this.comboBoxRF_AntPort_Port7.Location = new System.Drawing.Point(185, 198);
            this.comboBoxRF_AntPort_Port7.Name = "comboBoxRF_AntPort_Port7";
            this.comboBoxRF_AntPort_Port7.Size = new System.Drawing.Size(71, 23);
            this.comboBoxRF_AntPort_Port7.TabIndex = 20;
            this.toolTip1.SetToolTip(this.comboBoxRF_AntPort_Port7, "Independ RF Power for each antenna port when \"Auto Polling\" is enabled.");
            // 
            // textBox_RF_AntPort_InvCnter6
            // 
            this.textBox_RF_AntPort_InvCnter6.Enabled = false;
            this.textBox_RF_AntPort_InvCnter6.Location = new System.Drawing.Point(289, 171);
            this.textBox_RF_AntPort_InvCnter6.Name = "textBox_RF_AntPort_InvCnter6";
            this.textBox_RF_AntPort_InvCnter6.Size = new System.Drawing.Size(71, 21);
            this.textBox_RF_AntPort_InvCnter6.TabIndex = 19;
            this.textBox_RF_AntPort_InvCnter6.Text = "5";
            this.toolTip1.SetToolTip(this.textBox_RF_AntPort_InvCnter6, "Dwell on this antenna port untill number of Inventory tag command has been sent w" +
                    "hen \"Auto Polling\" is enabled.");
            // 
            // comboBoxRF_AntPort_Port6
            // 
            this.comboBoxRF_AntPort_Port6.Enabled = false;
            this.comboBoxRF_AntPort_Port6.FormattingEnabled = true;
            this.comboBoxRF_AntPort_Port6.Items.AddRange(new object[] {
            "33dBm",
            "32dBm",
            "31dBm",
            "30dBm",
            "29dBm",
            "28dBm",
            "27dBm",
            "26dBm",
            "25dBm",
            "24dBm",
            "23dBm",
            "22dBm",
            "21dBm",
            "20dBm",
            "19dBm",
            "18dBm",
            "17dBm",
            "16dBm",
            "15dBm",
            "14dBm",
            "13dBm",
            "12dBm",
            "11dBm",
            "10dBm",
            "09dBm",
            "08dBm",
            "07dBm",
            "06dBm",
            "05dBm",
            "04dBm",
            "03dBm",
            "02dBm",
            "01dBm",
            "00dBm"});
            this.comboBoxRF_AntPort_Port6.Location = new System.Drawing.Point(185, 171);
            this.comboBoxRF_AntPort_Port6.Name = "comboBoxRF_AntPort_Port6";
            this.comboBoxRF_AntPort_Port6.Size = new System.Drawing.Size(71, 23);
            this.comboBoxRF_AntPort_Port6.TabIndex = 18;
            this.toolTip1.SetToolTip(this.comboBoxRF_AntPort_Port6, "Independ RF Power for each antenna port when \"Auto Polling\" is enabled.");
            // 
            // textBox_RF_AntPort_InvCnter5
            // 
            this.textBox_RF_AntPort_InvCnter5.Enabled = false;
            this.textBox_RF_AntPort_InvCnter5.Location = new System.Drawing.Point(289, 145);
            this.textBox_RF_AntPort_InvCnter5.Name = "textBox_RF_AntPort_InvCnter5";
            this.textBox_RF_AntPort_InvCnter5.Size = new System.Drawing.Size(71, 21);
            this.textBox_RF_AntPort_InvCnter5.TabIndex = 17;
            this.textBox_RF_AntPort_InvCnter5.Text = "5";
            this.toolTip1.SetToolTip(this.textBox_RF_AntPort_InvCnter5, "Dwell on this antenna port untill number of Inventory tag command has been sent w" +
                    "hen \"Auto Polling\" is enabled.");
            // 
            // comboBoxRF_AntPort_Port5
            // 
            this.comboBoxRF_AntPort_Port5.Enabled = false;
            this.comboBoxRF_AntPort_Port5.FormattingEnabled = true;
            this.comboBoxRF_AntPort_Port5.Items.AddRange(new object[] {
            "33dBm",
            "32dBm",
            "31dBm",
            "30dBm",
            "29dBm",
            "28dBm",
            "27dBm",
            "26dBm",
            "25dBm",
            "24dBm",
            "23dBm",
            "22dBm",
            "21dBm",
            "20dBm",
            "19dBm",
            "18dBm",
            "17dBm",
            "16dBm",
            "15dBm",
            "14dBm",
            "13dBm",
            "12dBm",
            "11dBm",
            "10dBm",
            "09dBm",
            "08dBm",
            "07dBm",
            "06dBm",
            "05dBm",
            "04dBm",
            "03dBm",
            "02dBm",
            "01dBm",
            "00dBm"});
            this.comboBoxRF_AntPort_Port5.Location = new System.Drawing.Point(185, 145);
            this.comboBoxRF_AntPort_Port5.Name = "comboBoxRF_AntPort_Port5";
            this.comboBoxRF_AntPort_Port5.Size = new System.Drawing.Size(71, 23);
            this.comboBoxRF_AntPort_Port5.TabIndex = 16;
            this.toolTip1.SetToolTip(this.comboBoxRF_AntPort_Port5, "Independ RF Power for each antenna port when \"Auto Polling\" is enabled.");
            // 
            // textBox_RF_AntPort_InvCnter4
            // 
            this.textBox_RF_AntPort_InvCnter4.Enabled = false;
            this.textBox_RF_AntPort_InvCnter4.Location = new System.Drawing.Point(289, 118);
            this.textBox_RF_AntPort_InvCnter4.Name = "textBox_RF_AntPort_InvCnter4";
            this.textBox_RF_AntPort_InvCnter4.Size = new System.Drawing.Size(71, 21);
            this.textBox_RF_AntPort_InvCnter4.TabIndex = 15;
            this.textBox_RF_AntPort_InvCnter4.Text = "5";
            this.toolTip1.SetToolTip(this.textBox_RF_AntPort_InvCnter4, "Dwell on this antenna port untill number of Inventory tag command has been sent w" +
                    "hen \"Auto Polling\" is enabled.");
            // 
            // comboBoxRF_AntPort_Port4
            // 
            this.comboBoxRF_AntPort_Port4.Enabled = false;
            this.comboBoxRF_AntPort_Port4.FormattingEnabled = true;
            this.comboBoxRF_AntPort_Port4.Items.AddRange(new object[] {
            "33dBm",
            "32dBm",
            "31dBm",
            "30dBm",
            "29dBm",
            "28dBm",
            "27dBm",
            "26dBm",
            "25dBm",
            "24dBm",
            "23dBm",
            "22dBm",
            "21dBm",
            "20dBm",
            "19dBm",
            "18dBm",
            "17dBm",
            "16dBm",
            "15dBm",
            "14dBm",
            "13dBm",
            "12dBm",
            "11dBm",
            "10dBm",
            "09dBm",
            "08dBm",
            "07dBm",
            "06dBm",
            "05dBm",
            "04dBm",
            "03dBm",
            "02dBm",
            "01dBm",
            "00dBm"});
            this.comboBoxRF_AntPort_Port4.Location = new System.Drawing.Point(185, 118);
            this.comboBoxRF_AntPort_Port4.Name = "comboBoxRF_AntPort_Port4";
            this.comboBoxRF_AntPort_Port4.Size = new System.Drawing.Size(71, 23);
            this.comboBoxRF_AntPort_Port4.TabIndex = 14;
            this.toolTip1.SetToolTip(this.comboBoxRF_AntPort_Port4, "Independ RF Power for each antenna port when \"Auto Polling\" is enabled.");
            // 
            // textBox_RF_AntPort_InvCnter3
            // 
            this.textBox_RF_AntPort_InvCnter3.Enabled = false;
            this.textBox_RF_AntPort_InvCnter3.Location = new System.Drawing.Point(289, 92);
            this.textBox_RF_AntPort_InvCnter3.Name = "textBox_RF_AntPort_InvCnter3";
            this.textBox_RF_AntPort_InvCnter3.Size = new System.Drawing.Size(71, 21);
            this.textBox_RF_AntPort_InvCnter3.TabIndex = 13;
            this.textBox_RF_AntPort_InvCnter3.Text = "5";
            this.toolTip1.SetToolTip(this.textBox_RF_AntPort_InvCnter3, "Dwell on this antenna port untill number of Inventory tag command has been sent w" +
                    "hen \"Auto Polling\" is enabled.");
            // 
            // comboBoxRF_AntPort_Port3
            // 
            this.comboBoxRF_AntPort_Port3.Enabled = false;
            this.comboBoxRF_AntPort_Port3.FormattingEnabled = true;
            this.comboBoxRF_AntPort_Port3.Items.AddRange(new object[] {
            "33dBm",
            "32dBm",
            "31dBm",
            "30dBm",
            "29dBm",
            "28dBm",
            "27dBm",
            "26dBm",
            "25dBm",
            "24dBm",
            "23dBm",
            "22dBm",
            "21dBm",
            "20dBm",
            "19dBm",
            "18dBm",
            "17dBm",
            "16dBm",
            "15dBm",
            "14dBm",
            "13dBm",
            "12dBm",
            "11dBm",
            "10dBm",
            "09dBm",
            "08dBm",
            "07dBm",
            "06dBm",
            "05dBm",
            "04dBm",
            "03dBm",
            "02dBm",
            "01dBm",
            "00dBm"});
            this.comboBoxRF_AntPort_Port3.Location = new System.Drawing.Point(185, 92);
            this.comboBoxRF_AntPort_Port3.Name = "comboBoxRF_AntPort_Port3";
            this.comboBoxRF_AntPort_Port3.Size = new System.Drawing.Size(71, 23);
            this.comboBoxRF_AntPort_Port3.TabIndex = 12;
            this.toolTip1.SetToolTip(this.comboBoxRF_AntPort_Port3, "Independ RF Power for each antenna port when \"Auto Polling\" is enabled.");
            // 
            // textBox_RF_AntPort_InvCnter2
            // 
            this.textBox_RF_AntPort_InvCnter2.Enabled = false;
            this.textBox_RF_AntPort_InvCnter2.Location = new System.Drawing.Point(289, 66);
            this.textBox_RF_AntPort_InvCnter2.Name = "textBox_RF_AntPort_InvCnter2";
            this.textBox_RF_AntPort_InvCnter2.Size = new System.Drawing.Size(71, 21);
            this.textBox_RF_AntPort_InvCnter2.TabIndex = 11;
            this.textBox_RF_AntPort_InvCnter2.Text = "5";
            this.toolTip1.SetToolTip(this.textBox_RF_AntPort_InvCnter2, "Dwell on this antenna port untill number of Inventory tag command has been sent w" +
                    "hen \"Auto Polling\" is enabled.");
            // 
            // comboBoxRF_AntPort_Port2
            // 
            this.comboBoxRF_AntPort_Port2.Enabled = false;
            this.comboBoxRF_AntPort_Port2.FormattingEnabled = true;
            this.comboBoxRF_AntPort_Port2.Items.AddRange(new object[] {
            "33dBm",
            "32dBm",
            "31dBm",
            "30dBm",
            "29dBm",
            "28dBm",
            "27dBm",
            "26dBm",
            "25dBm",
            "24dBm",
            "23dBm",
            "22dBm",
            "21dBm",
            "20dBm",
            "19dBm",
            "18dBm",
            "17dBm",
            "16dBm",
            "15dBm",
            "14dBm",
            "13dBm",
            "12dBm",
            "11dBm",
            "10dBm",
            "09dBm",
            "08dBm",
            "07dBm",
            "06dBm",
            "05dBm",
            "04dBm",
            "03dBm",
            "02dBm",
            "01dBm",
            "00dBm"});
            this.comboBoxRF_AntPort_Port2.Location = new System.Drawing.Point(185, 66);
            this.comboBoxRF_AntPort_Port2.Name = "comboBoxRF_AntPort_Port2";
            this.comboBoxRF_AntPort_Port2.Size = new System.Drawing.Size(71, 23);
            this.comboBoxRF_AntPort_Port2.TabIndex = 10;
            this.toolTip1.SetToolTip(this.comboBoxRF_AntPort_Port2, "Independ RF Power for each antenna port when \"Auto Polling\" is enabled.");
            // 
            // textBox_RF_AntPort_InvCnter1
            // 
            this.textBox_RF_AntPort_InvCnter1.Location = new System.Drawing.Point(289, 39);
            this.textBox_RF_AntPort_InvCnter1.Name = "textBox_RF_AntPort_InvCnter1";
            this.textBox_RF_AntPort_InvCnter1.Size = new System.Drawing.Size(71, 21);
            this.textBox_RF_AntPort_InvCnter1.TabIndex = 9;
            this.textBox_RF_AntPort_InvCnter1.Text = "5";
            this.toolTip1.SetToolTip(this.textBox_RF_AntPort_InvCnter1, "Dwell on this antenna port untill number of Inventory tag command has been sent w" +
                    "hen \"Auto Polling\" is enabled.");
            // 
            // comboBoxRF_AntPort_Port1
            // 
            this.comboBoxRF_AntPort_Port1.FormattingEnabled = true;
            this.comboBoxRF_AntPort_Port1.Items.AddRange(new object[] {
            "33dBm",
            "32dBm",
            "31dBm",
            "30dBm",
            "29dBm",
            "28dBm",
            "27dBm",
            "26dBm",
            "25dBm",
            "24dBm",
            "23dBm",
            "22dBm",
            "21dBm",
            "20dBm",
            "19dBm",
            "18dBm",
            "17dBm",
            "16dBm",
            "15dBm",
            "14dBm",
            "13dBm",
            "12dBm",
            "11dBm",
            "10dBm",
            "09dBm",
            "08dBm",
            "07dBm",
            "06dBm",
            "05dBm",
            "04dBm",
            "03dBm",
            "02dBm",
            "01dBm",
            "00dBm"});
            this.comboBoxRF_AntPort_Port1.Location = new System.Drawing.Point(185, 39);
            this.comboBoxRF_AntPort_Port1.Name = "comboBoxRF_AntPort_Port1";
            this.comboBoxRF_AntPort_Port1.Size = new System.Drawing.Size(71, 23);
            this.comboBoxRF_AntPort_Port1.TabIndex = 8;
            this.toolTip1.SetToolTip(this.comboBoxRF_AntPort_Port1, "Independ RF Power for each antenna port when \"Auto Polling\" is enabled.");
            // 
            // comboBox_RF_AntPort_Quantity
            // 
            this.comboBox_RF_AntPort_Quantity.FormattingEnabled = true;
            this.comboBox_RF_AntPort_Quantity.Items.AddRange(new object[] {
            "1",
            "4",
            "8",
            "16"});
            this.comboBox_RF_AntPort_Quantity.Location = new System.Drawing.Point(71, 21);
            this.comboBox_RF_AntPort_Quantity.Name = "comboBox_RF_AntPort_Quantity";
            this.comboBox_RF_AntPort_Quantity.Size = new System.Drawing.Size(41, 23);
            this.comboBox_RF_AntPort_Quantity.TabIndex = 9;
            this.toolTip1.SetToolTip(this.comboBox_RF_AntPort_Quantity, "Select this quantity of the antenna port according to the reader\'s antenna port.");
            this.comboBox_RF_AntPort_Quantity.SelectedIndexChanged += new System.EventHandler(this.comboBox_RF_AntPort_Quantity_SelectedIndexChanged);
            // 
            // checkBox_RF_AntPort_AutoPolling
            // 
            this.checkBox_RF_AntPort_AutoPolling.AutoSize = true;
            this.checkBox_RF_AntPort_AutoPolling.Location = new System.Drawing.Point(147, 21);
            this.checkBox_RF_AntPort_AutoPolling.Name = "checkBox_RF_AntPort_AutoPolling";
            this.checkBox_RF_AntPort_AutoPolling.Size = new System.Drawing.Size(238, 19);
            this.checkBox_RF_AntPort_AutoPolling.TabIndex = 26;
            this.checkBox_RF_AntPort_AutoPolling.Text = "Auto Polling ANT while Read Multi-Tag";
            this.toolTip1.SetToolTip(this.checkBox_RF_AntPort_AutoPolling, "Auto polling each valid antenna port when the Mulit-Tag Command is sent.");
            this.checkBox_RF_AntPort_AutoPolling.UseVisualStyleBackColor = true;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(2, 48);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(166, 15);
            this.label39.TabIndex = 20;
            this.label39.Text = "0-Loop for ever(Only RS232)";
            this.toolTip1.SetToolTip(this.label39, "Continue to Inventory until Stop command.");
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(-292, 51);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(136, 15);
            this.label15.TabIndex = 5;
            this.label15.Text = "1-65535 times To Stop.";
            this.toolTip1.SetToolTip(this.label15, "Number of inventory to stop.");
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(13, 50);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(147, 29);
            this.btnContinue.TabIndex = 9;
            this.btnContinue.Text = "Continue";
            this.toolTip1.SetToolTip(this.btnContinue, "Read the tags only once at each interval defined by right edit box.");
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // checkBox_InvtMulti_AutoClear
            // 
            this.checkBox_InvtMulti_AutoClear.AutoSize = true;
            this.checkBox_InvtMulti_AutoClear.Checked = true;
            this.checkBox_InvtMulti_AutoClear.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_InvtMulti_AutoClear.Location = new System.Drawing.Point(9, 92);
            this.checkBox_InvtMulti_AutoClear.Name = "checkBox_InvtMulti_AutoClear";
            this.checkBox_InvtMulti_AutoClear.Size = new System.Drawing.Size(87, 19);
            this.checkBox_InvtMulti_AutoClear.TabIndex = 22;
            this.checkBox_InvtMulti_AutoClear.Text = "Auto Clear.";
            this.toolTip1.SetToolTip(this.checkBox_InvtMulti_AutoClear, "Clear the Tag list table on GUI before start Multi-tag Read.");
            this.checkBox_InvtMulti_AutoClear.UseVisualStyleBackColor = true;
            this.checkBox_InvtMulti_AutoClear.CheckedChanged += new System.EventHandler(this.checkBox_InvtMulti_AutoClear_CheckedChanged);
            // 
            // btn_SetNewBaudRate
            // 
            this.btn_SetNewBaudRate.Location = new System.Drawing.Point(207, 20);
            this.btn_SetNewBaudRate.Name = "btn_SetNewBaudRate";
            this.btn_SetNewBaudRate.Size = new System.Drawing.Size(71, 26);
            this.btn_SetNewBaudRate.TabIndex = 25;
            this.btn_SetNewBaudRate.Text = "Set";
            this.toolTip1.SetToolTip(this.btn_SetNewBaudRate, "Set the new Baud Rate of Module Reader. (Take effect after reset the Module Reade" +
                    "r)");
            this.btn_SetNewBaudRate.UseVisualStyleBackColor = true;
            this.btn_SetNewBaudRate.Click += new System.EventHandler(this.btn_SetNewBaudRate_Click);
            // 
            // btn_GetNewBaudRate
            // 
            this.btn_GetNewBaudRate.Location = new System.Drawing.Point(6, 20);
            this.btn_GetNewBaudRate.Name = "btn_GetNewBaudRate";
            this.btn_GetNewBaudRate.Size = new System.Drawing.Size(71, 26);
            this.btn_GetNewBaudRate.TabIndex = 26;
            this.btn_GetNewBaudRate.Text = "Get";
            this.toolTip1.SetToolTip(this.btn_GetNewBaudRate, "Get the Baud Rate of Module Reader");
            this.btn_GetNewBaudRate.UseVisualStyleBackColor = true;
            this.btn_GetNewBaudRate.Click += new System.EventHandler(this.btn_GetNewBaudRate_Click);
            // 
            // button_GPO_Set
            // 
            this.button_GPO_Set.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_GPO_Set.Location = new System.Drawing.Point(138, 57);
            this.button_GPO_Set.Name = "button_GPO_Set";
            this.button_GPO_Set.Size = new System.Drawing.Size(87, 32);
            this.button_GPO_Set.TabIndex = 3;
            this.button_GPO_Set.Text = "Set";
            this.toolTip1.SetToolTip(this.button_GPO_Set, "Set the GPO output of the fixed reader!");
            this.button_GPO_Set.UseVisualStyleBackColor = true;
            this.button_GPO_Set.Click += new System.EventHandler(this.button_GPIO_Set_Click);
            // 
            // button_GPO_Get
            // 
            this.button_GPO_Get.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_GPO_Get.Location = new System.Drawing.Point(138, 19);
            this.button_GPO_Get.Name = "button_GPO_Get";
            this.button_GPO_Get.Size = new System.Drawing.Size(87, 32);
            this.button_GPO_Get.TabIndex = 2;
            this.button_GPO_Get.Text = "Get";
            this.toolTip1.SetToolTip(this.button_GPO_Get, "Get the GPO Output and GPI Input status of the fixed reader!");
            this.button_GPO_Get.UseVisualStyleBackColor = true;
            this.button_GPO_Get.Click += new System.EventHandler(this.button_GPIO_Get_Click);
            // 
            // btnSetIO
            // 
            this.btnSetIO.Location = new System.Drawing.Point(82, 52);
            this.btnSetIO.Name = "btnSetIO";
            this.btnSetIO.Size = new System.Drawing.Size(94, 26);
            this.btnSetIO.TabIndex = 60;
            this.btnSetIO.Text = "Set";
            this.toolTip1.SetToolTip(this.btnSetIO, "Set the GPO stauts of Module Reader");
            this.btnSetIO.UseVisualStyleBackColor = true;
            this.btnSetIO.Click += new System.EventHandler(this.btnSetIO_Click);
            // 
            // btnGetIO
            // 
            this.btnGetIO.Location = new System.Drawing.Point(9, 52);
            this.btnGetIO.Name = "btnGetIO";
            this.btnGetIO.Size = new System.Drawing.Size(67, 27);
            this.btnGetIO.TabIndex = 59;
            this.btnGetIO.Text = "Get";
            this.toolTip1.SetToolTip(this.btnGetIO, "Get the GPI and GPO stauts of Module Reader");
            this.btnGetIO.UseVisualStyleBackColor = true;
            this.btnGetIO.Click += new System.EventHandler(this.btnGetIO_Click);
            // 
            // btnGetRegion
            // 
            this.btnGetRegion.Location = new System.Drawing.Point(105, 20);
            this.btnGetRegion.Name = "btnGetRegion";
            this.btnGetRegion.Size = new System.Drawing.Size(87, 29);
            this.btnGetRegion.TabIndex = 23;
            this.btnGetRegion.Text = "Get Region";
            this.toolTip1.SetToolTip(this.btnGetRegion, "Get Frequncy Rules for Country Region ");
            this.btnGetRegion.UseVisualStyleBackColor = true;
            this.btnGetRegion.Click += new System.EventHandler(this.btnGetRegion_Click);
            // 
            // btnSetRegion
            // 
            this.btnSetRegion.Location = new System.Drawing.Point(8, 20);
            this.btnSetRegion.Name = "btnSetRegion";
            this.btnSetRegion.Size = new System.Drawing.Size(87, 29);
            this.btnSetRegion.TabIndex = 6;
            this.btnSetRegion.Text = "Set Region";
            this.toolTip1.SetToolTip(this.btnSetRegion, "Set Frequncy Rules for Country Region");
            this.btnSetRegion.UseVisualStyleBackColor = true;
            this.btnSetRegion.Click += new System.EventHandler(this.btnSetRegion_Click);
            // 
            // btnInsertRfCh_Get
            // 
            this.btnInsertRfCh_Get.Location = new System.Drawing.Point(11, 61);
            this.btnInsertRfCh_Get.Name = "btnInsertRfCh_Get";
            this.btnInsertRfCh_Get.Size = new System.Drawing.Size(87, 29);
            this.btnInsertRfCh_Get.TabIndex = 24;
            this.btnInsertRfCh_Get.Text = "Get RFCH";
            this.toolTip1.SetToolTip(this.btnInsertRfCh_Get, "Get the freqency hopping range for FHSS in current RF channel region");
            this.btnInsertRfCh_Get.UseVisualStyleBackColor = true;
            this.btnInsertRfCh_Get.Click += new System.EventHandler(this.btnInsertRfCh_Get_Click);
            // 
            // txtChIndexBegin
            // 
            this.txtChIndexBegin.Location = new System.Drawing.Point(145, 26);
            this.txtChIndexBegin.Name = "txtChIndexBegin";
            this.txtChIndexBegin.Size = new System.Drawing.Size(38, 21);
            this.txtChIndexBegin.TabIndex = 13;
            this.txtChIndexBegin.Text = "1";
            this.txtChIndexBegin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtChIndexBegin, "MIN.=0;");
            // 
            // txtChIndexEnd
            // 
            this.txtChIndexEnd.Location = new System.Drawing.Point(225, 26);
            this.txtChIndexEnd.Name = "txtChIndexEnd";
            this.txtChIndexEnd.Size = new System.Drawing.Size(38, 21);
            this.txtChIndexEnd.TabIndex = 14;
            this.txtChIndexEnd.Text = "5";
            this.txtChIndexEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtChIndexEnd, "MAX.=RF Region Max No.");
            // 
            // btnInsertRfCh
            // 
            this.btnInsertRfCh.Location = new System.Drawing.Point(11, 20);
            this.btnInsertRfCh.Name = "btnInsertRfCh";
            this.btnInsertRfCh.Size = new System.Drawing.Size(87, 29);
            this.btnInsertRfCh.TabIndex = 8;
            this.btnInsertRfCh.Text = "Insert RFCH";
            this.toolTip1.SetToolTip(this.btnInsertRfCh, "Inser a group of freqency range into current RF channel from current RF region. (" +
                    "Insert a New RF Channel to work properly after \"Set Region\" to Clear Insert RF C" +
                    "hannel.)");
            this.btnInsertRfCh.UseVisualStyleBackColor = true;
            this.btnInsertRfCh.Click += new System.EventHandler(this.btnInsertRfCh_Click);
            // 
            // cbx_AccessMemBank
            // 
            this.cbx_AccessMemBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_AccessMemBank.FormattingEnabled = true;
            this.cbx_AccessMemBank.Items.AddRange(new object[] {
            "EPC+EPC 10 Algorithum",
            "EPC+EPC 11 Algorithum",
            "EPC+EPC 12 Algorithum",
            "EPC+TID 20 Algorithum",
            "EPC+TID 21 Algorithum",
            "EPC+TID 22 Algorithum",
            "EPC+USER 30 Algorithum",
            "EPC+USER 31 Algorithum",
            "EPC+USER 32 Algorithum",
            "EPC+TID+USER 40 Algorithum",
            "EPC+TID+USER 41 Algorithum",
            "EPC+TID+USER 42 Algorithum"});
            this.cbx_AccessMemBank.Location = new System.Drawing.Point(116, 15);
            this.cbx_AccessMemBank.Name = "cbx_AccessMemBank";
            this.cbx_AccessMemBank.Size = new System.Drawing.Size(150, 23);
            this.cbx_AccessMemBank.TabIndex = 29;
            this.toolTip1.SetToolTip(this.cbx_AccessMemBank, "Algorithm of Access MemBank.");
            this.cbx_AccessMemBank.SelectedIndexChanged += new System.EventHandler(this.cbx_AccessMemBank_SelectedIndexChanged);
            // 
            // txtEpcAccessMemBankAccessPwd
            // 
            this.txtEpcAccessMemBankAccessPwd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEpcAccessMemBankAccessPwd.Enabled = false;
            this.txtEpcAccessMemBankAccessPwd.Location = new System.Drawing.Point(169, 95);
            this.txtEpcAccessMemBankAccessPwd.Name = "txtEpcAccessMemBankAccessPwd";
            this.txtEpcAccessMemBankAccessPwd.Size = new System.Drawing.Size(97, 21);
            this.txtEpcAccessMemBankAccessPwd.TabIndex = 31;
            this.txtEpcAccessMemBankAccessPwd.Text = "00 00 00 00";
            this.txtEpcAccessMemBankAccessPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtEpcAccessMemBankAccessPwd, "The password of Access MemBank. (Not work currently)");
            // 
            // txtInvEPC_AccessMemBankWordLength
            // 
            this.txtInvEPC_AccessMemBankWordLength.Location = new System.Drawing.Point(224, 69);
            this.txtInvEPC_AccessMemBankWordLength.MaxLength = 32;
            this.txtInvEPC_AccessMemBankWordLength.Name = "txtInvEPC_AccessMemBankWordLength";
            this.txtInvEPC_AccessMemBankWordLength.Size = new System.Drawing.Size(42, 21);
            this.txtInvEPC_AccessMemBankWordLength.TabIndex = 26;
            this.txtInvEPC_AccessMemBankWordLength.Text = "6";
            this.toolTip1.SetToolTip(this.txtInvEPC_AccessMemBankWordLength, "The word length of Access MemBank for the tag. Be cafeful with overrun memory!!!");
            // 
            // txtInvEPC_AccessMemBankStartAddr
            // 
            this.txtInvEPC_AccessMemBankStartAddr.Location = new System.Drawing.Point(224, 44);
            this.txtInvEPC_AccessMemBankStartAddr.MaxLength = 4;
            this.txtInvEPC_AccessMemBankStartAddr.Name = "txtInvEPC_AccessMemBankStartAddr";
            this.txtInvEPC_AccessMemBankStartAddr.Size = new System.Drawing.Size(42, 21);
            this.txtInvEPC_AccessMemBankStartAddr.TabIndex = 24;
            this.txtInvEPC_AccessMemBankStartAddr.Text = "0";
            this.toolTip1.SetToolTip(this.txtInvEPC_AccessMemBankStartAddr, "The start Address of Access MemBank for the Tag. Be cafeful with overrun memory!!" +
                    "!");
            // 
            // btnInvtMultiEpcTid
            // 
            this.btnInvtMultiEpcTid.Font = new System.Drawing.Font("Arial", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvtMultiEpcTid.Location = new System.Drawing.Point(6, 154);
            this.btnInvtMultiEpcTid.Name = "btnInvtMultiEpcTid";
            this.btnInvtMultiEpcTid.Size = new System.Drawing.Size(268, 36);
            this.btnInvtMultiEpcTid.TabIndex = 23;
            this.btnInvtMultiEpcTid.Text = "Read Multi-Tag (EPC+MemBank)";
            this.toolTip1.SetToolTip(this.btnInvtMultiEpcTid, "Start Multi-Tag Access MemBank operation.");
            this.btnInvtMultiEpcTid.UseVisualStyleBackColor = true;
            this.btnInvtMultiEpcTid.Click += new System.EventHandler(this.btnInvtMultiEpcTid_Click);
            // 
            // cbxNewBaudRate
            // 
            this.cbxNewBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNewBaudRate.FormattingEnabled = true;
            this.cbxNewBaudRate.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cbxNewBaudRate.Location = new System.Drawing.Point(83, 23);
            this.cbxNewBaudRate.Name = "cbxNewBaudRate";
            this.cbxNewBaudRate.Size = new System.Drawing.Size(118, 23);
            this.cbxNewBaudRate.TabIndex = 26;
            this.toolTip1.SetToolTip(this.cbxNewBaudRate, "Only 115200 currently!");
            // 
            // label_AntPort_Quantity
            // 
            this.label_AntPort_Quantity.AutoSize = true;
            this.label_AntPort_Quantity.Location = new System.Drawing.Point(11, 22);
            this.label_AntPort_Quantity.Name = "label_AntPort_Quantity";
            this.label_AntPort_Quantity.Size = new System.Drawing.Size(54, 15);
            this.label_AntPort_Quantity.TabIndex = 25;
            this.label_AntPort_Quantity.Text = "Quantity";
            this.toolTip1.SetToolTip(this.label_AntPort_Quantity, "This is the actual quantity of antenna of reader");
            // 
            // comboBoxRF_AntPort_PortAll
            // 
            this.comboBoxRF_AntPort_PortAll.FormattingEnabled = true;
            this.comboBoxRF_AntPort_PortAll.Items.AddRange(new object[] {
            "33dBm",
            "32dBm",
            "31dBm",
            "30dBm",
            "29dBm",
            "28dBm",
            "27dBm",
            "26dBm",
            "25dBm",
            "24dBm",
            "23dBm",
            "22dBm",
            "21dBm",
            "20dBm",
            "19dBm",
            "18dBm",
            "17dBm",
            "16dBm",
            "15dBm",
            "14dBm",
            "13dBm",
            "12dBm",
            "11dBm",
            "10dBm",
            "09dBm",
            "08dBm",
            "07dBm",
            "06dBm",
            "05dBm",
            "04dBm",
            "03dBm",
            "02dBm",
            "01dBm",
            "00dBm"});
            this.comboBoxRF_AntPort_PortAll.Location = new System.Drawing.Point(295, 478);
            this.comboBoxRF_AntPort_PortAll.Name = "comboBoxRF_AntPort_PortAll";
            this.comboBoxRF_AntPort_PortAll.Size = new System.Drawing.Size(71, 23);
            this.comboBoxRF_AntPort_PortAll.TabIndex = 32;
            this.toolTip1.SetToolTip(this.comboBoxRF_AntPort_PortAll, "Independ RF Power for each antenna port when \"Auto Polling\" is enabled.");
            // 
            // txtInvEPC_AccessExUserMemBankStartAddrEx
            // 
            this.txtInvEPC_AccessExUserMemBankStartAddrEx.Enabled = false;
            this.txtInvEPC_AccessExUserMemBankStartAddrEx.Location = new System.Drawing.Point(106, 125);
            this.txtInvEPC_AccessExUserMemBankStartAddrEx.MaxLength = 4;
            this.txtInvEPC_AccessExUserMemBankStartAddrEx.Name = "txtInvEPC_AccessExUserMemBankStartAddrEx";
            this.txtInvEPC_AccessExUserMemBankStartAddrEx.Size = new System.Drawing.Size(42, 21);
            this.txtInvEPC_AccessExUserMemBankStartAddrEx.TabIndex = 34;
            this.txtInvEPC_AccessExUserMemBankStartAddrEx.Text = "0";
            this.toolTip1.SetToolTip(this.txtInvEPC_AccessExUserMemBankStartAddrEx, "The start Address of Access MemBank for the Tag. Be cafeful with overrun memory!!" +
                    "!");
            // 
            // txtInvEPC_AccessExUserMemBankWordLength
            // 
            this.txtInvEPC_AccessExUserMemBankWordLength.Enabled = false;
            this.txtInvEPC_AccessExUserMemBankWordLength.Location = new System.Drawing.Point(224, 125);
            this.txtInvEPC_AccessExUserMemBankWordLength.MaxLength = 32;
            this.txtInvEPC_AccessExUserMemBankWordLength.Name = "txtInvEPC_AccessExUserMemBankWordLength";
            this.txtInvEPC_AccessExUserMemBankWordLength.Size = new System.Drawing.Size(42, 21);
            this.txtInvEPC_AccessExUserMemBankWordLength.TabIndex = 35;
            this.txtInvEPC_AccessExUserMemBankWordLength.Text = "8";
            this.toolTip1.SetToolTip(this.txtInvEPC_AccessExUserMemBankWordLength, "The word length of Access MemBank for the tag. Be cafeful with overrun memory!!!");
            // 
            // txtReceive
            // 
            this.txtReceive.AllowDrop = true;
            this.txtReceive.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtReceive.Font = new System.Drawing.Font("Courier New", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceive.Location = new System.Drawing.Point(6, 43);
            this.txtReceive.MaxLength = 65536;
            this.txtReceive.Multiline = true;
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.ReadOnly = true;
            this.txtReceive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReceive.Size = new System.Drawing.Size(737, 113);
            this.txtReceive.TabIndex = 1;
            this.txtReceive.DoubleClick += new System.EventHandler(this.txtReceive_DoubleClick);
            // 
            // txtSend
            // 
            this.txtSend.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSend.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSend.Location = new System.Drawing.Point(188, 16);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(560, 21);
            this.txtSend.TabIndex = 2;
            this.txtSend.DoubleClick += new System.EventHandler(this.txtSend_DoubleClick);
            // 
            // btn_clear_rx
            // 
            this.btn_clear_rx.Location = new System.Drawing.Point(668, 9);
            this.btn_clear_rx.Name = "btn_clear_rx";
            this.btn_clear_rx.Size = new System.Drawing.Size(75, 29);
            this.btn_clear_rx.TabIndex = 3;
            this.btn_clear_rx.Text = "Clear";
            this.btn_clear_rx.UseVisualStyleBackColor = true;
            this.btn_clear_rx.Click += new System.EventHandler(this.btn_clear_rx_Click);
            // 
            // btnClearCnt
            // 
            this.btnClearCnt.Location = new System.Drawing.Point(8, 45);
            this.btnClearCnt.Name = "btnClearCnt";
            this.btnClearCnt.Size = new System.Drawing.Size(87, 29);
            this.btnClearCnt.TabIndex = 5;
            this.btnClearCnt.Text = "Reset";
            this.btnClearCnt.UseVisualStyleBackColor = true;
            this.btnClearCnt.Click += new System.EventHandler(this.btn_clear_cnt_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(8, 12);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(87, 29);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // timerAutoSend
            // 
            this.timerAutoSend.Tick += new System.EventHandler(this.timerAutoSend_Tick);
            // 
            // gbxRxData
            // 
            this.gbxRxData.Controls.Add(this.cbxRxTimeInfor);
            this.gbxRxData.Controls.Add(this.cbxRxVisable);
            this.gbxRxData.Controls.Add(this.cbxAutoClear);
            this.gbxRxData.Controls.Add(this.btn_clear_rx);
            this.gbxRxData.Controls.Add(this.txtReceive);
            this.gbxRxData.Location = new System.Drawing.Point(0, 366);
            this.gbxRxData.Name = "gbxRxData";
            this.gbxRxData.Size = new System.Drawing.Size(749, 162);
            this.gbxRxData.TabIndex = 17;
            this.gbxRxData.TabStop = false;
            this.gbxRxData.Text = "Receive Data";
            // 
            // cbxRxTimeInfor
            // 
            this.cbxRxTimeInfor.AutoSize = true;
            this.cbxRxTimeInfor.Checked = true;
            this.cbxRxTimeInfor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxRxTimeInfor.Location = new System.Drawing.Point(481, 15);
            this.cbxRxTimeInfor.Name = "cbxRxTimeInfor";
            this.cbxRxTimeInfor.Size = new System.Drawing.Size(122, 19);
            this.cbxRxTimeInfor.TabIndex = 6;
            this.cbxRxTimeInfor.Text = "Time informaiton";
            this.cbxRxTimeInfor.UseVisualStyleBackColor = true;
            // 
            // cbxRxVisable
            // 
            this.cbxRxVisable.AutoSize = true;
            this.cbxRxVisable.Checked = true;
            this.cbxRxVisable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxRxVisable.Location = new System.Drawing.Point(407, 15);
            this.cbxRxVisable.Name = "cbxRxVisable";
            this.cbxRxVisable.Size = new System.Drawing.Size(68, 19);
            this.cbxRxVisable.TabIndex = 5;
            this.cbxRxVisable.Text = "Visable";
            this.cbxRxVisable.UseVisualStyleBackColor = true;
            // 
            // cbxAutoClear
            // 
            this.cbxAutoClear.AutoSize = true;
            this.cbxAutoClear.Checked = true;
            this.cbxAutoClear.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxAutoClear.Location = new System.Drawing.Point(323, 15);
            this.cbxAutoClear.Name = "cbxAutoClear";
            this.cbxAutoClear.Size = new System.Drawing.Size(81, 19);
            this.cbxAutoClear.TabIndex = 4;
            this.cbxAutoClear.Text = "Autoclear";
            this.cbxAutoClear.UseVisualStyleBackColor = true;
            // 
            // gbx_inventory
            // 
            this.gbx_inventory.Controls.Add(this.label57);
            this.gbx_inventory.Controls.Add(this.cbxQBasic);
            this.gbx_inventory.Controls.Add(this.txtSendDelay);
            this.gbx_inventory.Controls.Add(this.label3);
            this.gbx_inventory.Controls.Add(this.label4);
            this.gbx_inventory.Controls.Add(this.btnInvtBasic);
            this.gbx_inventory.Controls.Add(this.btnContinue);
            this.gbx_inventory.Location = new System.Drawing.Point(9, 3);
            this.gbx_inventory.Name = "gbx_inventory";
            this.gbx_inventory.Size = new System.Drawing.Size(289, 99);
            this.gbx_inventory.TabIndex = 18;
            this.gbx_inventory.TabStop = false;
            this.gbx_inventory.Text = "Inventory Single Tag";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(10, 79);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(267, 15);
            this.label57.TabIndex = 38;
            this.label57.Text = "Note：1. 485 interface, Advise value >=500ms";
            // 
            // cbxQBasic
            // 
            this.cbxQBasic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxQBasic.FormattingEnabled = true;
            this.cbxQBasic.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cbxQBasic.Location = new System.Drawing.Point(223, 20);
            this.cbxQBasic.Name = "cbxQBasic";
            this.cbxQBasic.Size = new System.Drawing.Size(42, 23);
            this.cbxQBasic.TabIndex = 2;
            this.cbxQBasic.SelectedIndexChanged += new System.EventHandler(this.cbx_q_basic_SelectedIndexChanged);
            // 
            // txtSendDelay
            // 
            this.txtSendDelay.Location = new System.Drawing.Point(189, 48);
            this.txtSendDelay.Name = "txtSendDelay";
            this.txtSendDelay.Size = new System.Drawing.Size(47, 21);
            this.txtSendDelay.TabIndex = 14;
            this.txtSendDelay.Text = "60";
            this.txtSendDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Q =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "ms";
            // 
            // gbx_MTR
            // 
            this.gbx_MTR.Controls.Add(this.lbl_TagNumberToStopTimer);
            this.gbx_MTR.Controls.Add(this.txt_TagNumberToStopTimer);
            this.gbx_MTR.Controls.Add(this.gbx_Access);
            this.gbx_MTR.Controls.Add(this.checkBox_InvtMulti_AutoClear);
            this.gbx_MTR.Controls.Add(this.gbx_MTR_LoopNum);
            this.gbx_MTR.Controls.Add(this.lbl_MTR_Algorithm);
            this.gbx_MTR.Controls.Add(this.cbx_MTR_Algorithm);
            this.gbx_MTR.Controls.Add(this.lbl_MTR_Qvalue);
            this.gbx_MTR.Controls.Add(this.cbx_MTR_Qvalue);
            this.gbx_MTR.Controls.Add(this.btnStopRD);
            this.gbx_MTR.Controls.Add(this.btnInvtMulti);
            this.gbx_MTR.Location = new System.Drawing.Point(7, 101);
            this.gbx_MTR.Name = "gbx_MTR";
            this.gbx_MTR.Size = new System.Drawing.Size(291, 359);
            this.gbx_MTR.TabIndex = 16;
            this.gbx_MTR.TabStop = false;
            this.gbx_MTR.Text = "Inventory Mulit-Tag";
            // 
            // lbl_TagNumberToStopTimer
            // 
            this.lbl_TagNumberToStopTimer.AutoSize = true;
            this.lbl_TagNumberToStopTimer.Enabled = false;
            this.lbl_TagNumberToStopTimer.Location = new System.Drawing.Point(114, 93);
            this.lbl_TagNumberToStopTimer.Name = "lbl_TagNumberToStopTimer";
            this.lbl_TagNumberToStopTimer.Size = new System.Drawing.Size(114, 15);
            this.lbl_TagNumberToStopTimer.TabIndex = 35;
            this.lbl_TagNumberToStopTimer.Text = "Tag Num. for Timer";
            // 
            // txt_TagNumberToStopTimer
            // 
            this.txt_TagNumberToStopTimer.Enabled = false;
            this.txt_TagNumberToStopTimer.Location = new System.Drawing.Point(232, 90);
            this.txt_TagNumberToStopTimer.Name = "txt_TagNumberToStopTimer";
            this.txt_TagNumberToStopTimer.Size = new System.Drawing.Size(45, 21);
            this.txt_TagNumberToStopTimer.TabIndex = 34;
            this.txt_TagNumberToStopTimer.Text = "100";
            // 
            // gbx_Access
            // 
            this.gbx_Access.Controls.Add(this.label54);
            this.gbx_Access.Controls.Add(this.label53);
            this.gbx_Access.Controls.Add(this.txtInvEPC_AccessExUserMemBankWordLength);
            this.gbx_Access.Controls.Add(this.txtInvEPC_AccessExUserMemBankStartAddrEx);
            this.gbx_Access.Controls.Add(this.btn_AccessMemBankHelp);
            this.gbx_Access.Controls.Add(this.labelInvEpcAccessMemBankAlgorithm);
            this.gbx_Access.Controls.Add(this.labelInvEpcAccessMemBankAccessPwd);
            this.gbx_Access.Controls.Add(this.txtEpcAccessMemBankAccessPwd);
            this.gbx_Access.Controls.Add(this.cbx_AccessMemBank);
            this.gbx_Access.Controls.Add(this.labelInvEpcAccessMemBankWordLength);
            this.gbx_Access.Controls.Add(this.txtInvEPC_AccessMemBankWordLength);
            this.gbx_Access.Controls.Add(this.labelInvEpcAccessMemBankStartWordAddr);
            this.gbx_Access.Controls.Add(this.txtInvEPC_AccessMemBankStartAddr);
            this.gbx_Access.Controls.Add(this.btnInvtMultiEpcTid);
            this.gbx_Access.Location = new System.Drawing.Point(6, 157);
            this.gbx_Access.Name = "gbx_Access";
            this.gbx_Access.Size = new System.Drawing.Size(279, 196);
            this.gbx_Access.TabIndex = 33;
            this.gbx_Access.TabStop = false;
            this.gbx_Access.Text = "Access MemBank";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(149, 128);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(73, 15);
            this.label54.TabIndex = 37;
            this.label54.Text = "ExWordLen";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(3, 128);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(100, 15);
            this.label53.TabIndex = 36;
            this.label53.Text = "Start ExAddress";
            // 
            // btn_AccessMemBankHelp
            // 
            this.btn_AccessMemBankHelp.Location = new System.Drawing.Point(264, 3);
            this.btn_AccessMemBankHelp.Name = "btn_AccessMemBankHelp";
            this.btn_AccessMemBankHelp.Size = new System.Drawing.Size(17, 22);
            this.btn_AccessMemBankHelp.TabIndex = 33;
            this.btn_AccessMemBankHelp.Text = "?";
            this.btn_AccessMemBankHelp.UseVisualStyleBackColor = true;
            this.btn_AccessMemBankHelp.Click += new System.EventHandler(this.btn_AccessMemBankHelp_Click);
            // 
            // labelInvEpcAccessMemBankAlgorithm
            // 
            this.labelInvEpcAccessMemBankAlgorithm.AutoSize = true;
            this.labelInvEpcAccessMemBankAlgorithm.Location = new System.Drawing.Point(6, 19);
            this.labelInvEpcAccessMemBankAlgorithm.Name = "labelInvEpcAccessMemBankAlgorithm";
            this.labelInvEpcAccessMemBankAlgorithm.Size = new System.Drawing.Size(108, 15);
            this.labelInvEpcAccessMemBankAlgorithm.TabIndex = 28;
            this.labelInvEpcAccessMemBankAlgorithm.Text = "Access Algorithm";
            // 
            // labelInvEpcAccessMemBankAccessPwd
            // 
            this.labelInvEpcAccessMemBankAccessPwd.AutoSize = true;
            this.labelInvEpcAccessMemBankAccessPwd.Location = new System.Drawing.Point(6, 95);
            this.labelInvEpcAccessMemBankAccessPwd.Name = "labelInvEpcAccessMemBankAccessPwd";
            this.labelInvEpcAccessMemBankAccessPwd.Size = new System.Drawing.Size(142, 15);
            this.labelInvEpcAccessMemBankAccessPwd.TabIndex = 32;
            this.labelInvEpcAccessMemBankAccessPwd.Text = "Access Password(HEX)";
            // 
            // labelInvEpcAccessMemBankWordLength
            // 
            this.labelInvEpcAccessMemBankWordLength.AutoSize = true;
            this.labelInvEpcAccessMemBankWordLength.Location = new System.Drawing.Point(6, 72);
            this.labelInvEpcAccessMemBankWordLength.Name = "labelInvEpcAccessMemBankWordLength";
            this.labelInvEpcAccessMemBankWordLength.Size = new System.Drawing.Size(133, 15);
            this.labelInvEpcAccessMemBankWordLength.TabIndex = 27;
            this.labelInvEpcAccessMemBankWordLength.Text = "Word Length(Max<=8)";
            // 
            // labelInvEpcAccessMemBankStartWordAddr
            // 
            this.labelInvEpcAccessMemBankStartWordAddr.AutoSize = true;
            this.labelInvEpcAccessMemBankStartWordAddr.Location = new System.Drawing.Point(6, 46);
            this.labelInvEpcAccessMemBankStartWordAddr.Name = "labelInvEpcAccessMemBankStartWordAddr";
            this.labelInvEpcAccessMemBankStartWordAddr.Size = new System.Drawing.Size(160, 15);
            this.labelInvEpcAccessMemBankStartWordAddr.TabIndex = 25;
            this.labelInvEpcAccessMemBankStartWordAddr.Text = "Start Address(HEX Format)";
            // 
            // gbx_MTR_LoopNum
            // 
            this.gbx_MTR_LoopNum.Controls.Add(this.btn_invt_multi_Help);
            this.gbx_MTR_LoopNum.Controls.Add(this.label39);
            this.gbx_MTR_LoopNum.Controls.Add(this.lbl_MTR_Read_Number);
            this.gbx_MTR_LoopNum.Controls.Add(this.txtRDMultiNum);
            this.gbx_MTR_LoopNum.Location = new System.Drawing.Point(117, 18);
            this.gbx_MTR_LoopNum.Name = "gbx_MTR_LoopNum";
            this.gbx_MTR_LoopNum.Size = new System.Drawing.Size(170, 69);
            this.gbx_MTR_LoopNum.TabIndex = 21;
            this.gbx_MTR_LoopNum.TabStop = false;
            this.gbx_MTR_LoopNum.Text = "Loop Number";
            // 
            // btn_invt_multi_Help
            // 
            this.btn_invt_multi_Help.Location = new System.Drawing.Point(154, 2);
            this.btn_invt_multi_Help.Name = "btn_invt_multi_Help";
            this.btn_invt_multi_Help.Size = new System.Drawing.Size(16, 20);
            this.btn_invt_multi_Help.TabIndex = 21;
            this.btn_invt_multi_Help.Text = "?";
            this.btn_invt_multi_Help.UseVisualStyleBackColor = true;
            this.btn_invt_multi_Help.Click += new System.EventHandler(this.btn_invt_multi_Help_Click);
            // 
            // lbl_MTR_Read_Number
            // 
            this.lbl_MTR_Read_Number.AutoSize = true;
            this.lbl_MTR_Read_Number.Location = new System.Drawing.Point(8, 23);
            this.lbl_MTR_Read_Number.Name = "lbl_MTR_Read_Number";
            this.lbl_MTR_Read_Number.Size = new System.Drawing.Size(36, 15);
            this.lbl_MTR_Read_Number.TabIndex = 17;
            this.lbl_MTR_Read_Number.Text = "Num:";
            // 
            // lbl_MTR_Algorithm
            // 
            this.lbl_MTR_Algorithm.AutoSize = true;
            this.lbl_MTR_Algorithm.Location = new System.Drawing.Point(6, 61);
            this.lbl_MTR_Algorithm.Name = "lbl_MTR_Algorithm";
            this.lbl_MTR_Algorithm.Size = new System.Drawing.Size(62, 15);
            this.lbl_MTR_Algorithm.TabIndex = 19;
            this.lbl_MTR_Algorithm.Text = "Algorithm";
            // 
            // lbl_MTR_Qvalue
            // 
            this.lbl_MTR_Qvalue.AutoSize = true;
            this.lbl_MTR_Qvalue.Location = new System.Drawing.Point(10, 31);
            this.lbl_MTR_Qvalue.Name = "lbl_MTR_Qvalue";
            this.lbl_MTR_Qvalue.Size = new System.Drawing.Size(50, 15);
            this.lbl_MTR_Qvalue.TabIndex = 16;
            this.lbl_MTR_Qvalue.Text = "Q Value";
            // 
            // dgvEpcBasic
            // 
            this.dgvEpcBasic.AllowUserToAddRows = false;
            this.dgvEpcBasic.AllowUserToDeleteRows = false;
            this.dgvEpcBasic.AllowUserToResizeColumns = false;
            this.dgvEpcBasic.AllowUserToResizeRows = false;
            this.dgvEpcBasic.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvEpcBasic.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvEpcBasic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEpcBasic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEpcBasic.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvEpcBasic.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvEpcBasic.Location = new System.Drawing.Point(6, 43);
            this.dgvEpcBasic.Name = "dgvEpcBasic";
            this.dgvEpcBasic.ReadOnly = true;
            this.dgvEpcBasic.RowHeadersVisible = false;
            this.dgvEpcBasic.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvEpcBasic.RowTemplate.Height = 18;
            this.dgvEpcBasic.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEpcBasic.Size = new System.Drawing.Size(737, 306);
            this.dgvEpcBasic.TabIndex = 19;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsCsvToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(167, 26);
            // 
            // saveAsCsvToolStripMenuItem
            // 
            this.saveAsCsvToolStripMenuItem.Name = "saveAsCsvToolStripMenuItem";
            this.saveAsCsvToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.saveAsCsvToolStripMenuItem.Text = "Save As csv File";
            this.saveAsCsvToolStripMenuItem.Click += new System.EventHandler(this.saveAsTxtToolStripMenuItem_Click);
            // 
            // gbxEpcTableBasic
            // 
            this.gbxEpcTableBasic.Controls.Add(this.lbl_TagNumberElapseTimeMs);
            this.gbxEpcTableBasic.Controls.Add(this.lbl_TagNumberElapseTime);
            this.gbxEpcTableBasic.Controls.Add(this.txt_TagNumberToTimeValue);
            this.gbxEpcTableBasic.Controls.Add(this.textBox_EPC_Tag_Total);
            this.gbxEpcTableBasic.Controls.Add(this.label_EPC_Tag_Total);
            this.gbxEpcTableBasic.Controls.Add(this.textBox_EPC_TagCounter);
            this.gbxEpcTableBasic.Controls.Add(this.label_EPC_TagCounter);
            this.gbxEpcTableBasic.Controls.Add(this.btn_clear_epc1);
            this.gbxEpcTableBasic.Controls.Add(this.dgvEpcBasic);
            this.gbxEpcTableBasic.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxEpcTableBasic.Location = new System.Drawing.Point(0, 6);
            this.gbxEpcTableBasic.Name = "gbxEpcTableBasic";
            this.gbxEpcTableBasic.Size = new System.Drawing.Size(749, 355);
            this.gbxEpcTableBasic.TabIndex = 20;
            this.gbxEpcTableBasic.TabStop = false;
            this.gbxEpcTableBasic.Text = "EPC Table";
            // 
            // lbl_TagNumberElapseTimeMs
            // 
            this.lbl_TagNumberElapseTimeMs.AutoSize = true;
            this.lbl_TagNumberElapseTimeMs.Location = new System.Drawing.Point(609, 18);
            this.lbl_TagNumberElapseTimeMs.Name = "lbl_TagNumberElapseTimeMs";
            this.lbl_TagNumberElapseTimeMs.Size = new System.Drawing.Size(26, 15);
            this.lbl_TagNumberElapseTimeMs.TabIndex = 27;
            this.lbl_TagNumberElapseTimeMs.Text = "mS";
            // 
            // lbl_TagNumberElapseTime
            // 
            this.lbl_TagNumberElapseTime.AutoSize = true;
            this.lbl_TagNumberElapseTime.Location = new System.Drawing.Point(422, 17);
            this.lbl_TagNumberElapseTime.Name = "lbl_TagNumberElapseTime";
            this.lbl_TagNumberElapseTime.Size = new System.Drawing.Size(74, 15);
            this.lbl_TagNumberElapseTime.TabIndex = 26;
            this.lbl_TagNumberElapseTime.Text = "Tag timing : ";
            // 
            // txt_TagNumberToTimeValue
            // 
            this.txt_TagNumberToTimeValue.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TagNumberToTimeValue.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txt_TagNumberToTimeValue.Location = new System.Drawing.Point(502, 11);
            this.txt_TagNumberToTimeValue.Name = "txt_TagNumberToTimeValue";
            this.txt_TagNumberToTimeValue.ReadOnly = true;
            this.txt_TagNumberToTimeValue.Size = new System.Drawing.Size(101, 29);
            this.txt_TagNumberToTimeValue.TabIndex = 25;
            this.txt_TagNumberToTimeValue.Text = "0";
            // 
            // textBox_EPC_Tag_Total
            // 
            this.textBox_EPC_Tag_Total.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EPC_Tag_Total.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBox_EPC_Tag_Total.Location = new System.Drawing.Point(311, 11);
            this.textBox_EPC_Tag_Total.Name = "textBox_EPC_Tag_Total";
            this.textBox_EPC_Tag_Total.ReadOnly = true;
            this.textBox_EPC_Tag_Total.Size = new System.Drawing.Size(103, 29);
            this.textBox_EPC_Tag_Total.TabIndex = 24;
            this.textBox_EPC_Tag_Total.Text = "0";
            // 
            // label_EPC_Tag_Total
            // 
            this.label_EPC_Tag_Total.AutoSize = true;
            this.label_EPC_Tag_Total.Location = new System.Drawing.Point(272, 18);
            this.label_EPC_Tag_Total.Name = "label_EPC_Tag_Total";
            this.label_EPC_Tag_Total.Size = new System.Drawing.Size(43, 15);
            this.label_EPC_Tag_Total.TabIndex = 23;
            this.label_EPC_Tag_Total.Text = "Tags : ";
            // 
            // textBox_EPC_TagCounter
            // 
            this.textBox_EPC_TagCounter.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EPC_TagCounter.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBox_EPC_TagCounter.Location = new System.Drawing.Point(102, 11);
            this.textBox_EPC_TagCounter.Name = "textBox_EPC_TagCounter";
            this.textBox_EPC_TagCounter.ReadOnly = true;
            this.textBox_EPC_TagCounter.Size = new System.Drawing.Size(165, 29);
            this.textBox_EPC_TagCounter.TabIndex = 22;
            this.textBox_EPC_TagCounter.Text = "0";
            // 
            // label_EPC_TagCounter
            // 
            this.label_EPC_TagCounter.AutoSize = true;
            this.label_EPC_TagCounter.Location = new System.Drawing.Point(12, 18);
            this.label_EPC_TagCounter.Name = "label_EPC_TagCounter";
            this.label_EPC_TagCounter.Size = new System.Drawing.Size(84, 15);
            this.label_EPC_TagCounter.TabIndex = 21;
            this.label_EPC_TagCounter.Text = "Tag Counter : ";
            // 
            // btn_clear_epc1
            // 
            this.btn_clear_epc1.Location = new System.Drawing.Point(668, 11);
            this.btn_clear_epc1.Name = "btn_clear_epc1";
            this.btn_clear_epc1.Size = new System.Drawing.Size(75, 29);
            this.btn_clear_epc1.TabIndex = 20;
            this.btn_clear_epc1.Text = "Clear";
            this.btn_clear_epc1.UseVisualStyleBackColor = true;
            this.btn_clear_epc1.Click += new System.EventHandler(this.btn_clear_basictable_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageMain);
            this.tabControl1.Controls.Add(this.tabPageAccessTag);
            this.tabControl1.Controls.Add(this.tabPageSysSetting);
            this.tabControl1.Controls.Add(this.ExtCommand);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1074, 666);
            this.tabControl1.TabIndex = 21;
            this.tabControl1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tabControl1_KeyUp);
            // 
            // tabPageMain
            // 
            this.tabPageMain.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageMain.Controls.Add(this.tabControl2);
            this.tabPageMain.Controls.Add(this.gbxStatus);
            this.tabPageMain.Controls.Add(this.gbxEpcTableBasic);
            this.tabPageMain.Controls.Add(this.gbx_conn);
            this.tabPageMain.Controls.Add(this.gbxRxData);
            this.tabPageMain.Location = new System.Drawing.Point(4, 24);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(1066, 638);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Connection & Read EPC ";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage_TagRead);
            this.tabControl2.Controls.Add(this.tabPage_SysSetting);
            this.tabControl2.Location = new System.Drawing.Point(755, 143);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(312, 494);
            this.tabControl2.TabIndex = 34;
            // 
            // tabPage_TagRead
            // 
            this.tabPage_TagRead.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.tabPage_TagRead.Controls.Add(this.gbx_inventory);
            this.tabPage_TagRead.Controls.Add(this.gbx_MTR);
            this.tabPage_TagRead.Controls.Add(this.label15);
            this.tabPage_TagRead.Location = new System.Drawing.Point(4, 24);
            this.tabPage_TagRead.Name = "tabPage_TagRead";
            this.tabPage_TagRead.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_TagRead.Size = new System.Drawing.Size(304, 466);
            this.tabPage_TagRead.TabIndex = 0;
            this.tabPage_TagRead.Text = "Tag Read";
            // 
            // tabPage_SysSetting
            // 
            this.tabPage_SysSetting.BackColor = System.Drawing.Color.LightCyan;
            this.tabPage_SysSetting.Controls.Add(this.groupBox6);
            this.tabPage_SysSetting.Controls.Add(this.gbx_NewDevAddr);
            this.tabPage_SysSetting.Location = new System.Drawing.Point(4, 24);
            this.tabPage_SysSetting.Name = "tabPage_SysSetting";
            this.tabPage_SysSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_SysSetting.Size = new System.Drawing.Size(304, 466);
            this.tabPage_SysSetting.TabIndex = 1;
            this.tabPage_SysSetting.Text = "System Setting";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cbxNewBaudRate);
            this.groupBox6.Controls.Add(this.btn_SetNewBaudRate);
            this.groupBox6.Controls.Add(this.btn_GetNewBaudRate);
            this.groupBox6.Location = new System.Drawing.Point(6, 70);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(284, 58);
            this.groupBox6.TabIndex = 28;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "New Baud Rate (Module Reader Only)";
            // 
            // gbxStatus
            // 
            this.gbxStatus.Controls.Add(this.txtReaderFirmwareVersion);
            this.gbxStatus.Controls.Add(this.txtModuleFirmwareVersion);
            this.gbxStatus.Controls.Add(this.txtModuleReleaseDate);
            this.gbxStatus.Controls.Add(this.txtModuleHardwareVersion);
            this.gbxStatus.Controls.Add(this.label6);
            this.gbxStatus.Controls.Add(this.label7);
            this.gbxStatus.Controls.Add(this.label37);
            this.gbxStatus.Controls.Add(this.labelHardwareVersion);
            this.gbxStatus.Controls.Add(this.txtTxTimerInfor);
            this.gbxStatus.Controls.Add(this.btnSend);
            this.gbxStatus.Controls.Add(this.btnClearCnt);
            this.gbxStatus.Controls.Add(this.txtSend);
            this.gbxStatus.Controls.Add(this.label17);
            this.gbxStatus.Controls.Add(this.txtCOMRxCnt);
            this.gbxStatus.Controls.Add(this.label16);
            this.gbxStatus.Controls.Add(this.txtCOMTxCnt);
            this.gbxStatus.Location = new System.Drawing.Point(3, 534);
            this.gbxStatus.Name = "gbxStatus";
            this.gbxStatus.Size = new System.Drawing.Size(746, 98);
            this.gbxStatus.TabIndex = 25;
            this.gbxStatus.TabStop = false;
            // 
            // txtReaderFirmwareVersion
            // 
            this.txtReaderFirmwareVersion.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtReaderFirmwareVersion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReaderFirmwareVersion.ForeColor = System.Drawing.Color.Red;
            this.txtReaderFirmwareVersion.Location = new System.Drawing.Point(356, 74);
            this.txtReaderFirmwareVersion.Name = "txtReaderFirmwareVersion";
            this.txtReaderFirmwareVersion.ReadOnly = true;
            this.txtReaderFirmwareVersion.Size = new System.Drawing.Size(74, 14);
            this.txtReaderFirmwareVersion.TabIndex = 32;
            // 
            // txtModuleFirmwareVersion
            // 
            this.txtModuleFirmwareVersion.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtModuleFirmwareVersion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModuleFirmwareVersion.ForeColor = System.Drawing.Color.Red;
            this.txtModuleFirmwareVersion.Location = new System.Drawing.Point(354, 51);
            this.txtModuleFirmwareVersion.Name = "txtModuleFirmwareVersion";
            this.txtModuleFirmwareVersion.ReadOnly = true;
            this.txtModuleFirmwareVersion.Size = new System.Drawing.Size(76, 14);
            this.txtModuleFirmwareVersion.TabIndex = 33;
            // 
            // txtModuleReleaseDate
            // 
            this.txtModuleReleaseDate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtModuleReleaseDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModuleReleaseDate.ForeColor = System.Drawing.Color.Red;
            this.txtModuleReleaseDate.Location = new System.Drawing.Point(579, 73);
            this.txtModuleReleaseDate.Name = "txtModuleReleaseDate";
            this.txtModuleReleaseDate.ReadOnly = true;
            this.txtModuleReleaseDate.Size = new System.Drawing.Size(126, 14);
            this.txtModuleReleaseDate.TabIndex = 34;
            // 
            // txtModuleHardwareVersion
            // 
            this.txtModuleHardwareVersion.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtModuleHardwareVersion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModuleHardwareVersion.ForeColor = System.Drawing.Color.Red;
            this.txtModuleHardwareVersion.Location = new System.Drawing.Point(603, 50);
            this.txtModuleHardwareVersion.Name = "txtModuleHardwareVersion";
            this.txtModuleHardwareVersion.ReadOnly = true;
            this.txtModuleHardwareVersion.Size = new System.Drawing.Size(126, 14);
            this.txtModuleHardwareVersion.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 15);
            this.label6.TabIndex = 29;
            this.label6.Text = "Reader Firmware Version:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(444, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 15);
            this.label7.TabIndex = 28;
            this.label7.Text = "Reader Release Date:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(194, 50);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(154, 15);
            this.label37.TabIndex = 30;
            this.label37.Text = "Module Firmware Version:";
            // 
            // labelHardwareVersion
            // 
            this.labelHardwareVersion.AutoSize = true;
            this.labelHardwareVersion.Location = new System.Drawing.Point(444, 49);
            this.labelHardwareVersion.Name = "labelHardwareVersion";
            this.labelHardwareVersion.Size = new System.Drawing.Size(156, 15);
            this.labelHardwareVersion.TabIndex = 31;
            this.labelHardwareVersion.Text = "Module Hardware Version:";
            // 
            // txtTxTimerInfor
            // 
            this.txtTxTimerInfor.Location = new System.Drawing.Point(101, 16);
            this.txtTxTimerInfor.Name = "txtTxTimerInfor";
            this.txtTxTimerInfor.ReadOnly = true;
            this.txtTxTimerInfor.Size = new System.Drawing.Size(81, 21);
            this.txtTxTimerInfor.TabIndex = 27;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(102, 72);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 15);
            this.label17.TabIndex = 24;
            this.label17.Text = "TX:";
            // 
            // txtCOMRxCnt
            // 
            this.txtCOMRxCnt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCOMRxCnt.Location = new System.Drawing.Point(133, 52);
            this.txtCOMRxCnt.Name = "txtCOMRxCnt";
            this.txtCOMRxCnt.ReadOnly = true;
            this.txtCOMRxCnt.Size = new System.Drawing.Size(58, 14);
            this.txtCOMRxCnt.TabIndex = 21;
            this.txtCOMRxCnt.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(101, 52);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 15);
            this.label16.TabIndex = 22;
            this.label16.Text = "RX:";
            // 
            // txtCOMTxCnt
            // 
            this.txtCOMTxCnt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCOMTxCnt.Location = new System.Drawing.Point(132, 73);
            this.txtCOMTxCnt.Name = "txtCOMTxCnt";
            this.txtCOMTxCnt.ReadOnly = true;
            this.txtCOMTxCnt.Size = new System.Drawing.Size(58, 14);
            this.txtCOMTxCnt.TabIndex = 23;
            this.txtCOMTxCnt.Text = "0";
            // 
            // tabPageAccessTag
            // 
            this.tabPageAccessTag.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageAccessTag.Controls.Add(this.tabControl4);
            this.tabPageAccessTag.Controls.Add(this.label_Access4);
            this.tabPageAccessTag.Controls.Add(this.tabControl3);
            this.tabPageAccessTag.Controls.Add(this.label_Acess1);
            this.tabPageAccessTag.Controls.Add(this.gbxStatus2);
            this.tabPageAccessTag.Controls.Add(this.inv_mode);
            this.tabPageAccessTag.Controls.Add(this.gbx_comcnt_adv);
            this.tabPageAccessTag.Controls.Add(this.btnInvtAdv);
            this.tabPageAccessTag.Controls.Add(this.gbxEpcTableAdv);
            this.tabPageAccessTag.Location = new System.Drawing.Point(4, 24);
            this.tabPageAccessTag.Name = "tabPageAccessTag";
            this.tabPageAccessTag.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAccessTag.Size = new System.Drawing.Size(1066, 638);
            this.tabPageAccessTag.TabIndex = 1;
            this.tabPageAccessTag.Text = "Access Tag Memory";
            // 
            // tabControl4
            // 
            this.tabControl4.Controls.Add(this.tabPage3);
            this.tabControl4.Controls.Add(this.tabPage4);
            this.tabControl4.Location = new System.Drawing.Point(6, 350);
            this.tabControl4.Name = "tabControl4";
            this.tabControl4.SelectedIndex = 0;
            this.tabControl4.Size = new System.Drawing.Size(499, 244);
            this.tabControl4.TabIndex = 84;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.gbxSelect);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(491, 216);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Select Tag Parameter";
            // 
            // gbxSelect
            // 
            this.gbxSelect.BackColor = System.Drawing.SystemColors.Control;
            this.gbxSelect.Controls.Add(this.label_Access3);
            this.gbxSelect.Controls.Add(this.label34);
            this.gbxSelect.Controls.Add(this.label35);
            this.gbxSelect.Controls.Add(this.txtGetSelLength);
            this.gbxSelect.Controls.Add(this.txtGetSelMask);
            this.gbxSelect.Controls.Add(this.btnGetSelect);
            this.gbxSelect.Controls.Add(this.label33);
            this.gbxSelect.Controls.Add(this.txtSelMask);
            this.gbxSelect.Controls.Add(this.ckxTruncated);
            this.gbxSelect.Controls.Add(this.label32);
            this.gbxSelect.Controls.Add(this.txtSelLength);
            this.gbxSelect.Controls.Add(this.label31);
            this.gbxSelect.Controls.Add(this.txtSelPrt0);
            this.gbxSelect.Controls.Add(this.label30);
            this.gbxSelect.Controls.Add(this.txtSelPrt2);
            this.gbxSelect.Controls.Add(this.label29);
            this.gbxSelect.Controls.Add(this.txtSelPrt1);
            this.gbxSelect.Controls.Add(this.txtSelPrt3);
            this.gbxSelect.Controls.Add(this.label28);
            this.gbxSelect.Controls.Add(this.cbxSelMemBank);
            this.gbxSelect.Controls.Add(this.cbxAction);
            this.gbxSelect.Controls.Add(this.cbxSelTarget);
            this.gbxSelect.Controls.Add(this.btnSetSelect);
            this.gbxSelect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbxSelect.Location = new System.Drawing.Point(3, 17);
            this.gbxSelect.Name = "gbxSelect";
            this.gbxSelect.Size = new System.Drawing.Size(482, 172);
            this.gbxSelect.TabIndex = 27;
            this.gbxSelect.TabStop = false;
            this.gbxSelect.Text = "Select Parameter";
            // 
            // label_Access3
            // 
            this.label_Access3.AutoSize = true;
            this.label_Access3.ForeColor = System.Drawing.Color.Red;
            this.label_Access3.Location = new System.Drawing.Point(125, 0);
            this.label_Access3.Name = "label_Access3";
            this.label_Access3.Size = new System.Drawing.Size(105, 15);
            this.label_Access3.TabIndex = 82;
            this.label_Access3.Text = "Step3: Select Tag";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(226, 116);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(38, 15);
            this.label34.TabIndex = 47;
            this.label34.Text = "Mask";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(96, 116);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(46, 15);
            this.label35.TabIndex = 46;
            this.label35.Text = "Length";
            // 
            // txtGetSelLength
            // 
            this.txtGetSelLength.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGetSelLength.Location = new System.Drawing.Point(99, 134);
            this.txtGetSelLength.Name = "txtGetSelLength";
            this.txtGetSelLength.ReadOnly = true;
            this.txtGetSelLength.Size = new System.Drawing.Size(40, 21);
            this.txtGetSelLength.TabIndex = 45;
            this.txtGetSelLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGetSelMask
            // 
            this.txtGetSelMask.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGetSelMask.Location = new System.Drawing.Point(145, 134);
            this.txtGetSelMask.Name = "txtGetSelMask";
            this.txtGetSelMask.ReadOnly = true;
            this.txtGetSelMask.Size = new System.Drawing.Size(290, 21);
            this.txtGetSelMask.TabIndex = 35;
            this.txtGetSelMask.DoubleClick += new System.EventHandler(this.txtGetSelMask_DoubleClick);
            // 
            // btnGetSelect
            // 
            this.btnGetSelect.Location = new System.Drawing.Point(11, 130);
            this.btnGetSelect.Name = "btnGetSelect";
            this.btnGetSelect.Size = new System.Drawing.Size(75, 29);
            this.btnGetSelect.TabIndex = 44;
            this.btnGetSelect.Text = "Get Select";
            this.btnGetSelect.UseVisualStyleBackColor = true;
            this.btnGetSelect.Click += new System.EventHandler(this.btnGetSelect_Click);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(226, 67);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(38, 15);
            this.label33.TabIndex = 43;
            this.label33.Text = "Mask";
            // 
            // txtSelMask
            // 
            this.txtSelMask.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSelMask.Location = new System.Drawing.Point(148, 86);
            this.txtSelMask.Name = "txtSelMask";
            this.txtSelMask.Size = new System.Drawing.Size(290, 21);
            this.txtSelMask.TabIndex = 35;
            this.txtSelMask.Text = "00 00 00 00 00 00 00 00 00 00 00 00";
            this.txtSelMask.DoubleClick += new System.EventHandler(this.txtSelMask_DoubleClick);
            // 
            // ckxTruncated
            // 
            this.ckxTruncated.AutoSize = true;
            this.ckxTruncated.Enabled = false;
            this.ckxTruncated.Location = new System.Drawing.Point(20, 86);
            this.ckxTruncated.Name = "ckxTruncated";
            this.ckxTruncated.Size = new System.Drawing.Size(76, 19);
            this.ckxTruncated.TabIndex = 42;
            this.ckxTruncated.Text = "Truncate";
            this.ckxTruncated.UseVisualStyleBackColor = true;
            this.ckxTruncated.Visible = false;
            this.ckxTruncated.CheckedChanged += new System.EventHandler(this.ckxTruncated_CheckedChanged);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(96, 67);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(46, 15);
            this.label32.TabIndex = 41;
            this.label32.Text = "Length";
            // 
            // txtSelLength
            // 
            this.txtSelLength.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSelLength.Location = new System.Drawing.Point(102, 86);
            this.txtSelLength.Name = "txtSelLength";
            this.txtSelLength.Size = new System.Drawing.Size(40, 21);
            this.txtSelLength.TabIndex = 40;
            this.txtSelLength.Text = "60";
            this.txtSelLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(360, 17);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(48, 15);
            this.label31.TabIndex = 39;
            this.label31.Text = "Pointer";
            // 
            // txtSelPrt0
            // 
            this.txtSelPrt0.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSelPrt0.Location = new System.Drawing.Point(432, 36);
            this.txtSelPrt0.Name = "txtSelPrt0";
            this.txtSelPrt0.Size = new System.Drawing.Size(40, 21);
            this.txtSelPrt0.TabIndex = 38;
            this.txtSelPrt0.Text = "20";
            this.txtSelPrt0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(109, 17);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(43, 15);
            this.label30.TabIndex = 38;
            this.label30.Text = "Target";
            // 
            // txtSelPrt2
            // 
            this.txtSelPrt2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSelPrt2.Location = new System.Drawing.Point(346, 36);
            this.txtSelPrt2.Name = "txtSelPrt2";
            this.txtSelPrt2.Size = new System.Drawing.Size(40, 21);
            this.txtSelPrt2.TabIndex = 37;
            this.txtSelPrt2.Text = "00";
            this.txtSelPrt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(177, 17);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(43, 15);
            this.label29.TabIndex = 37;
            this.label29.Text = "Action";
            // 
            // txtSelPrt1
            // 
            this.txtSelPrt1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSelPrt1.Location = new System.Drawing.Point(389, 36);
            this.txtSelPrt1.Name = "txtSelPrt1";
            this.txtSelPrt1.Size = new System.Drawing.Size(40, 21);
            this.txtSelPrt1.TabIndex = 36;
            this.txtSelPrt1.Text = "00";
            this.txtSelPrt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSelPrt3
            // 
            this.txtSelPrt3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSelPrt3.Location = new System.Drawing.Point(303, 36);
            this.txtSelPrt3.Name = "txtSelPrt3";
            this.txtSelPrt3.Size = new System.Drawing.Size(40, 21);
            this.txtSelPrt3.TabIndex = 35;
            this.txtSelPrt3.Text = "00";
            this.txtSelPrt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(226, 17);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(64, 15);
            this.label28.TabIndex = 35;
            this.label28.Text = "MemBank";
            // 
            // cbxSelMemBank
            // 
            this.cbxSelMemBank.DisplayMember = "2";
            this.cbxSelMemBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSelMemBank.FormattingEnabled = true;
            this.cbxSelMemBank.Items.AddRange(new object[] {
            "RFU",
            "EPC",
            "TID",
            "User"});
            this.cbxSelMemBank.Location = new System.Drawing.Point(229, 35);
            this.cbxSelMemBank.Name = "cbxSelMemBank";
            this.cbxSelMemBank.Size = new System.Drawing.Size(59, 23);
            this.cbxSelMemBank.TabIndex = 35;
            this.cbxSelMemBank.Tag = "";
            // 
            // cbxAction
            // 
            this.cbxAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAction.FormattingEnabled = true;
            this.cbxAction.Items.AddRange(new object[] {
            "000",
            "001",
            "010",
            "011",
            "100",
            "101",
            "110",
            "111"});
            this.cbxAction.Location = new System.Drawing.Point(173, 35);
            this.cbxAction.Name = "cbxAction";
            this.cbxAction.Size = new System.Drawing.Size(48, 23);
            this.cbxAction.TabIndex = 36;
            // 
            // cbxSelTarget
            // 
            this.cbxSelTarget.DisplayMember = "2";
            this.cbxSelTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSelTarget.FormattingEnabled = true;
            this.cbxSelTarget.Items.AddRange(new object[] {
            "S0(000)",
            "S1(001)",
            "S2(010)",
            "S3(011)",
            "SL(100)",
            "RFU(101)",
            "RFU(110)",
            "RFU(111)"});
            this.cbxSelTarget.Location = new System.Drawing.Point(96, 35);
            this.cbxSelTarget.Name = "cbxSelTarget";
            this.cbxSelTarget.Size = new System.Drawing.Size(69, 23);
            this.cbxSelTarget.TabIndex = 35;
            this.cbxSelTarget.Tag = "";
            // 
            // btnSetSelect
            // 
            this.btnSetSelect.Location = new System.Drawing.Point(11, 31);
            this.btnSetSelect.Name = "btnSetSelect";
            this.btnSetSelect.Size = new System.Drawing.Size(75, 29);
            this.btnSetSelect.TabIndex = 35;
            this.btnSetSelect.Text = "Set Select";
            this.btnSetSelect.UseVisualStyleBackColor = true;
            this.btnSetSelect.Click += new System.EventHandler(this.btnSetSelect_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.gbxSetQuery);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(491, 216);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Query Parameter";
            // 
            // gbxSetQuery
            // 
            this.gbxSetQuery.Controls.Add(this.cbxM);
            this.gbxSetQuery.Controls.Add(this.cbxQAdv);
            this.gbxSetQuery.Controls.Add(this.btnGetQuery);
            this.gbxSetQuery.Controls.Add(this.btnSetQuery);
            this.gbxSetQuery.Controls.Add(this.label14);
            this.gbxSetQuery.Controls.Add(this.cbxTarget);
            this.gbxSetQuery.Controls.Add(this.label13);
            this.gbxSetQuery.Controls.Add(this.cbxSession);
            this.gbxSetQuery.Controls.Add(this.label12);
            this.gbxSetQuery.Controls.Add(this.cbxSel);
            this.gbxSetQuery.Controls.Add(this.label11);
            this.gbxSetQuery.Controls.Add(this.cbxTRext);
            this.gbxSetQuery.Controls.Add(this.label10);
            this.gbxSetQuery.Controls.Add(this.label9);
            this.gbxSetQuery.Controls.Add(this.label8);
            this.gbxSetQuery.Controls.Add(this.cbxDR);
            this.gbxSetQuery.Location = new System.Drawing.Point(6, 13);
            this.gbxSetQuery.Name = "gbxSetQuery";
            this.gbxSetQuery.Size = new System.Drawing.Size(482, 112);
            this.gbxSetQuery.TabIndex = 21;
            this.gbxSetQuery.TabStop = false;
            this.gbxSetQuery.Text = "Query Parameter";
            // 
            // cbxM
            // 
            this.cbxM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxM.Enabled = false;
            this.cbxM.FormattingEnabled = true;
            this.cbxM.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "8"});
            this.cbxM.Location = new System.Drawing.Point(120, 19);
            this.cbxM.Name = "cbxM";
            this.cbxM.Size = new System.Drawing.Size(34, 23);
            this.cbxM.TabIndex = 2;
            this.cbxM.SelectedIndexChanged += new System.EventHandler(this.cbx_m_SelectedIndexChanged);
            // 
            // cbxQAdv
            // 
            this.cbxQAdv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxQAdv.FormattingEnabled = true;
            this.cbxQAdv.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cbxQAdv.Location = new System.Drawing.Point(123, 82);
            this.cbxQAdv.Name = "cbxQAdv";
            this.cbxQAdv.Size = new System.Drawing.Size(34, 23);
            this.cbxQAdv.TabIndex = 17;
            // 
            // btnGetQuery
            // 
            this.btnGetQuery.Location = new System.Drawing.Point(303, 53);
            this.btnGetQuery.Name = "btnGetQuery";
            this.btnGetQuery.Size = new System.Drawing.Size(75, 30);
            this.btnGetQuery.TabIndex = 16;
            this.btnGetQuery.Text = "Get Query";
            this.btnGetQuery.UseVisualStyleBackColor = true;
            this.btnGetQuery.Click += new System.EventHandler(this.btn_getquery_Click);
            // 
            // btnSetQuery
            // 
            this.btnSetQuery.Location = new System.Drawing.Point(389, 53);
            this.btnSetQuery.Name = "btnSetQuery";
            this.btnSetQuery.Size = new System.Drawing.Size(75, 30);
            this.btnSetQuery.TabIndex = 14;
            this.btnSetQuery.Text = "Set Query";
            this.btnSetQuery.UseVisualStyleBackColor = true;
            this.btnSetQuery.Click += new System.EventHandler(this.btn_setquery_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(94, 85);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 15);
            this.label14.TabIndex = 12;
            this.label14.Text = "Q =";
            // 
            // cbxTarget
            // 
            this.cbxTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTarget.FormattingEnabled = true;
            this.cbxTarget.Items.AddRange(new object[] {
            "A",
            "B"});
            this.cbxTarget.Location = new System.Drawing.Point(55, 82);
            this.cbxTarget.Name = "cbxTarget";
            this.cbxTarget.Size = new System.Drawing.Size(34, 23);
            this.cbxTarget.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 15);
            this.label13.TabIndex = 10;
            this.label13.Text = "Target =";
            // 
            // cbxSession
            // 
            this.cbxSession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSession.FormattingEnabled = true;
            this.cbxSession.Items.AddRange(new object[] {
            "S0",
            "S1",
            "S2",
            "S3"});
            this.cbxSession.Location = new System.Drawing.Point(187, 48);
            this.cbxSession.Name = "cbxSession";
            this.cbxSession.Size = new System.Drawing.Size(43, 23);
            this.cbxSession.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(124, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 15);
            this.label12.TabIndex = 8;
            this.label12.Text = "Session =";
            // 
            // cbxSel
            // 
            this.cbxSel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSel.FormattingEnabled = true;
            this.cbxSel.Items.AddRange(new object[] {
            "ALL(00)",
            "ALL(01)",
            "~SL(10)",
            "SL(11)"});
            this.cbxSel.Location = new System.Drawing.Point(52, 48);
            this.cbxSel.Name = "cbxSel";
            this.cbxSel.Size = new System.Drawing.Size(67, 23);
            this.cbxSel.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 15);
            this.label11.TabIndex = 6;
            this.label11.Text = "Sel =";
            // 
            // cbxTRext
            // 
            this.cbxTRext.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTRext.Enabled = false;
            this.cbxTRext.FormattingEnabled = true;
            this.cbxTRext.Items.AddRange(new object[] {
            "NoPilot",
            "UsePilot"});
            this.cbxTRext.Location = new System.Drawing.Point(207, 19);
            this.cbxTRext.Name = "cbxTRext";
            this.cbxTRext.Size = new System.Drawing.Size(72, 23);
            this.cbxTRext.TabIndex = 5;
            this.cbxTRext.SelectedIndexChanged += new System.EventHandler(this.cbx_trext_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(159, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 15);
            this.label10.TabIndex = 4;
            this.label10.Text = "TRext =";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(91, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 15);
            this.label9.TabIndex = 3;
            this.label9.Text = "M =";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "DR =";
            // 
            // cbxDR
            // 
            this.cbxDR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDR.Enabled = false;
            this.cbxDR.FormattingEnabled = true;
            this.cbxDR.Items.AddRange(new object[] {
            "8",
            "64/3"});
            this.cbxDR.Location = new System.Drawing.Point(52, 19);
            this.cbxDR.Name = "cbxDR";
            this.cbxDR.Size = new System.Drawing.Size(34, 23);
            this.cbxDR.TabIndex = 0;
            this.cbxDR.SelectedIndexChanged += new System.EventHandler(this.cbx_dr_SelectedIndexChanged);
            // 
            // label_Access4
            // 
            this.label_Access4.AutoSize = true;
            this.label_Access4.ForeColor = System.Drawing.Color.Red;
            this.label_Access4.Location = new System.Drawing.Point(626, 345);
            this.label_Access4.Name = "label_Access4";
            this.label_Access4.Size = new System.Drawing.Size(237, 15);
            this.label_Access4.TabIndex = 83;
            this.label_Access4.Text = "Step4: Access Tag (Read/Write/Lock/Kill)";
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage1);
            this.tabControl3.Controls.Add(this.tabPage2);
            this.tabControl3.Location = new System.Drawing.Point(511, 363);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(549, 200);
            this.tabControl3.TabIndex = 81;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.gbxAccess);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(541, 172);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Read Tag / Write Tag";
            // 
            // gbxAccess
            // 
            this.gbxAccess.Controls.Add(this.label5);
            this.gbxAccess.Controls.Add(this.txtWordCnt0);
            this.gbxAccess.Controls.Add(this.txtWordPtr0);
            this.gbxAccess.Controls.Add(this.label26);
            this.gbxAccess.Controls.Add(this.label25);
            this.gbxAccess.Controls.Add(this.txtRwAccPassWord);
            this.gbxAccess.Controls.Add(this.txtInvtRWData);
            this.gbxAccess.Controls.Add(this.btnInvtWrtie);
            this.gbxAccess.Controls.Add(this.label22);
            this.gbxAccess.Controls.Add(this.label21);
            this.gbxAccess.Controls.Add(this.label20);
            this.gbxAccess.Controls.Add(this.cbxMemBank);
            this.gbxAccess.Controls.Add(this.txtWordCnt1);
            this.gbxAccess.Controls.Add(this.txtWordPtr1);
            this.gbxAccess.Controls.Add(this.btn_invtread);
            this.gbxAccess.Location = new System.Drawing.Point(6, 10);
            this.gbxAccess.Name = "gbxAccess";
            this.gbxAccess.Size = new System.Drawing.Size(521, 132);
            this.gbxAccess.TabIndex = 23;
            this.gbxAccess.TabStop = false;
            this.gbxAccess.Text = "Read / Write Tag Memory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 15);
            this.label5.TabIndex = 35;
            this.label5.Text = "(Max Length is 32 Words)";
            // 
            // txtWordCnt0
            // 
            this.txtWordCnt0.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtWordCnt0.Location = new System.Drawing.Point(229, 40);
            this.txtWordCnt0.Name = "txtWordCnt0";
            this.txtWordCnt0.Size = new System.Drawing.Size(40, 21);
            this.txtWordCnt0.TabIndex = 34;
            this.txtWordCnt0.Text = "08";
            this.txtWordCnt0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWordPtr0
            // 
            this.txtWordPtr0.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtWordPtr0.Location = new System.Drawing.Point(138, 40);
            this.txtWordPtr0.Name = "txtWordPtr0";
            this.txtWordPtr0.Size = new System.Drawing.Size(40, 21);
            this.txtWordPtr0.TabIndex = 33;
            this.txtWordPtr0.Text = "00";
            this.txtWordPtr0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(289, 22);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(111, 15);
            this.label26.TabIndex = 28;
            this.label26.Text = "Access Password";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(49, 69);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(36, 15);
            this.label25.TabIndex = 12;
            this.label25.Text = "Data:";
            // 
            // txtRwAccPassWord
            // 
            this.txtRwAccPassWord.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRwAccPassWord.Location = new System.Drawing.Point(292, 40);
            this.txtRwAccPassWord.Name = "txtRwAccPassWord";
            this.txtRwAccPassWord.Size = new System.Drawing.Size(97, 21);
            this.txtRwAccPassWord.TabIndex = 27;
            this.txtRwAccPassWord.Text = "00 00 00 00";
            this.txtRwAccPassWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInvtRWData
            // 
            this.txtInvtRWData.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtInvtRWData.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvtRWData.Location = new System.Drawing.Point(96, 69);
            this.txtInvtRWData.Name = "txtInvtRWData";
            this.txtInvtRWData.Size = new System.Drawing.Size(415, 19);
            this.txtInvtRWData.TabIndex = 10;
            this.txtInvtRWData.DoubleClick += new System.EventHandler(this.txtInvtReadData_DoubleClick);
            // 
            // btnInvtWrtie
            // 
            this.btnInvtWrtie.Location = new System.Drawing.Point(107, 95);
            this.btnInvtWrtie.Name = "btnInvtWrtie";
            this.btnInvtWrtie.Size = new System.Drawing.Size(75, 29);
            this.btnInvtWrtie.TabIndex = 7;
            this.btnInvtWrtie.Text = "Write";
            this.btnInvtWrtie.UseVisualStyleBackColor = true;
            this.btnInvtWrtie.Click += new System.EventHandler(this.btnInvtWrtie_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(21, 22);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(64, 15);
            this.label22.TabIndex = 6;
            this.label22.Text = "MemBank";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(185, 22);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(86, 15);
            this.label21.TabIndex = 5;
            this.label21.Text = "Word Counter";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(97, 22);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(82, 15);
            this.label20.TabIndex = 4;
            this.label20.Text = "Word Pointer";
            // 
            // cbxMemBank
            // 
            this.cbxMemBank.DisplayMember = "2";
            this.cbxMemBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMemBank.FormattingEnabled = true;
            this.cbxMemBank.Items.AddRange(new object[] {
            "RFU",
            "EPC",
            "TID",
            "User"});
            this.cbxMemBank.Location = new System.Drawing.Point(23, 39);
            this.cbxMemBank.Name = "cbxMemBank";
            this.cbxMemBank.Size = new System.Drawing.Size(59, 23);
            this.cbxMemBank.TabIndex = 3;
            this.cbxMemBank.Tag = "";
            this.cbxMemBank.SelectedIndexChanged += new System.EventHandler(this.cbxMemBank_SelectedIndexChanged);
            // 
            // txtWordCnt1
            // 
            this.txtWordCnt1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtWordCnt1.Location = new System.Drawing.Point(185, 40);
            this.txtWordCnt1.Name = "txtWordCnt1";
            this.txtWordCnt1.Size = new System.Drawing.Size(40, 21);
            this.txtWordCnt1.TabIndex = 2;
            this.txtWordCnt1.Text = "00";
            this.txtWordCnt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWordPtr1
            // 
            this.txtWordPtr1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtWordPtr1.Location = new System.Drawing.Point(96, 40);
            this.txtWordPtr1.Name = "txtWordPtr1";
            this.txtWordPtr1.Size = new System.Drawing.Size(40, 21);
            this.txtWordPtr1.TabIndex = 1;
            this.txtWordPtr1.Text = "00";
            this.txtWordPtr1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_invtread
            // 
            this.btn_invtread.Location = new System.Drawing.Point(24, 95);
            this.btn_invtread.Name = "btn_invtread";
            this.btn_invtread.Size = new System.Drawing.Size(75, 29);
            this.btn_invtread.TabIndex = 0;
            this.btn_invtread.Text = "Read";
            this.btn_invtread.UseVisualStyleBackColor = true;
            this.btn_invtread.Click += new System.EventHandler(this.btn_invtread_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.gBxLock);
            this.tabPage2.Controls.Add(this.gbxKill);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(541, 172);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lock tag / Kill Tag";
            // 
            // gBxLock
            // 
            this.gBxLock.Controls.Add(this.cbxLockUserAction);
            this.gBxLock.Controls.Add(this.cbxLockTIDAction);
            this.gBxLock.Controls.Add(this.cbxLockEPCAction);
            this.gBxLock.Controls.Add(this.cbxLockAccessAction);
            this.gBxLock.Controls.Add(this.cbxLockKillAction);
            this.gBxLock.Controls.Add(this.checkBoxUser);
            this.gBxLock.Controls.Add(this.checkBoxTID);
            this.gBxLock.Controls.Add(this.checkBoxEPC);
            this.gBxLock.Controls.Add(this.checkBoxAccessPwd);
            this.gBxLock.Controls.Add(this.checkBoxKillPwd);
            this.gBxLock.Controls.Add(this.buttonLock);
            this.gBxLock.Controls.Add(this.label42);
            this.gBxLock.Controls.Add(this.textBoxLockAccessPwd);
            this.gBxLock.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBxLock.Location = new System.Drawing.Point(6, 6);
            this.gBxLock.Name = "gBxLock";
            this.gBxLock.Size = new System.Drawing.Size(521, 115);
            this.gBxLock.TabIndex = 68;
            this.gBxLock.TabStop = false;
            this.gBxLock.Text = "Lock";
            // 
            // cbxLockUserAction
            // 
            this.cbxLockUserAction.DisplayMember = "2";
            this.cbxLockUserAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLockUserAction.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLockUserAction.FormattingEnabled = true;
            this.cbxLockUserAction.Items.AddRange(new object[] {
            "Open",
            "PWD Lock",
            "Perma Open",
            "Perma Lock"});
            this.cbxLockUserAction.Location = new System.Drawing.Point(271, 83);
            this.cbxLockUserAction.Name = "cbxLockUserAction";
            this.cbxLockUserAction.Size = new System.Drawing.Size(99, 23);
            this.cbxLockUserAction.TabIndex = 36;
            this.cbxLockUserAction.Tag = "";
            // 
            // cbxLockTIDAction
            // 
            this.cbxLockTIDAction.DisplayMember = "2";
            this.cbxLockTIDAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLockTIDAction.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLockTIDAction.FormattingEnabled = true;
            this.cbxLockTIDAction.Items.AddRange(new object[] {
            "Open",
            "PWD Lock",
            "Perma Open",
            "Perma Lock"});
            this.cbxLockTIDAction.Location = new System.Drawing.Point(80, 85);
            this.cbxLockTIDAction.Name = "cbxLockTIDAction";
            this.cbxLockTIDAction.Size = new System.Drawing.Size(98, 23);
            this.cbxLockTIDAction.TabIndex = 36;
            this.cbxLockTIDAction.Tag = "";
            // 
            // cbxLockEPCAction
            // 
            this.cbxLockEPCAction.DisplayMember = "2";
            this.cbxLockEPCAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLockEPCAction.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLockEPCAction.FormattingEnabled = true;
            this.cbxLockEPCAction.Items.AddRange(new object[] {
            "Open",
            "PWD Lock",
            "Perma Open",
            "Perma Lock"});
            this.cbxLockEPCAction.Location = new System.Drawing.Point(423, 53);
            this.cbxLockEPCAction.Name = "cbxLockEPCAction";
            this.cbxLockEPCAction.Size = new System.Drawing.Size(91, 23);
            this.cbxLockEPCAction.TabIndex = 36;
            this.cbxLockEPCAction.Tag = "";
            // 
            // cbxLockAccessAction
            // 
            this.cbxLockAccessAction.DisplayMember = "2";
            this.cbxLockAccessAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLockAccessAction.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLockAccessAction.FormattingEnabled = true;
            this.cbxLockAccessAction.Items.AddRange(new object[] {
            "Open",
            "PWD R/W",
            "Perma Open",
            "Perma NOT R/W"});
            this.cbxLockAccessAction.Location = new System.Drawing.Point(272, 54);
            this.cbxLockAccessAction.Name = "cbxLockAccessAction";
            this.cbxLockAccessAction.Size = new System.Drawing.Size(98, 23);
            this.cbxLockAccessAction.TabIndex = 36;
            this.cbxLockAccessAction.Tag = "";
            // 
            // cbxLockKillAction
            // 
            this.cbxLockKillAction.DisplayMember = "2";
            this.cbxLockKillAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLockKillAction.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLockKillAction.FormattingEnabled = true;
            this.cbxLockKillAction.Items.AddRange(new object[] {
            "Open",
            "PWD R/W",
            "Perma Open",
            "Perma NOT R/W"});
            this.cbxLockKillAction.Location = new System.Drawing.Point(79, 53);
            this.cbxLockKillAction.Name = "cbxLockKillAction";
            this.cbxLockKillAction.Size = new System.Drawing.Size(99, 23);
            this.cbxLockKillAction.TabIndex = 36;
            this.cbxLockKillAction.Tag = "";
            // 
            // checkBoxUser
            // 
            this.checkBoxUser.AutoSize = true;
            this.checkBoxUser.Location = new System.Drawing.Point(183, 85);
            this.checkBoxUser.Name = "checkBoxUser";
            this.checkBoxUser.Size = new System.Drawing.Size(53, 19);
            this.checkBoxUser.TabIndex = 86;
            this.checkBoxUser.Text = "User";
            this.checkBoxUser.UseVisualStyleBackColor = true;
            // 
            // checkBoxTID
            // 
            this.checkBoxTID.AutoSize = true;
            this.checkBoxTID.Location = new System.Drawing.Point(11, 85);
            this.checkBoxTID.Name = "checkBoxTID";
            this.checkBoxTID.Size = new System.Drawing.Size(44, 19);
            this.checkBoxTID.TabIndex = 86;
            this.checkBoxTID.Text = "TID";
            this.checkBoxTID.UseVisualStyleBackColor = true;
            // 
            // checkBoxEPC
            // 
            this.checkBoxEPC.AutoSize = true;
            this.checkBoxEPC.Location = new System.Drawing.Point(376, 56);
            this.checkBoxEPC.Name = "checkBoxEPC";
            this.checkBoxEPC.Size = new System.Drawing.Size(49, 19);
            this.checkBoxEPC.TabIndex = 86;
            this.checkBoxEPC.Text = "EPC";
            this.checkBoxEPC.UseVisualStyleBackColor = true;
            // 
            // checkBoxAccessPwd
            // 
            this.checkBoxAccessPwd.AutoSize = true;
            this.checkBoxAccessPwd.Location = new System.Drawing.Point(183, 55);
            this.checkBoxAccessPwd.Name = "checkBoxAccessPwd";
            this.checkBoxAccessPwd.Size = new System.Drawing.Size(97, 19);
            this.checkBoxAccessPwd.TabIndex = 86;
            this.checkBoxAccessPwd.Text = "Access Pwd";
            this.checkBoxAccessPwd.UseVisualStyleBackColor = true;
            // 
            // checkBoxKillPwd
            // 
            this.checkBoxKillPwd.AutoSize = true;
            this.checkBoxKillPwd.Location = new System.Drawing.Point(11, 56);
            this.checkBoxKillPwd.Name = "checkBoxKillPwd";
            this.checkBoxKillPwd.Size = new System.Drawing.Size(71, 19);
            this.checkBoxKillPwd.TabIndex = 86;
            this.checkBoxKillPwd.Text = "Kill Pwd";
            this.checkBoxKillPwd.UseVisualStyleBackColor = true;
            // 
            // buttonLock
            // 
            this.buttonLock.Location = new System.Drawing.Point(272, 15);
            this.buttonLock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLock.Name = "buttonLock";
            this.buttonLock.Size = new System.Drawing.Size(101, 30);
            this.buttonLock.TabIndex = 51;
            this.buttonLock.Text = "Lock";
            this.buttonLock.UseVisualStyleBackColor = true;
            this.buttonLock.Click += new System.EventHandler(this.buttonLock_Click);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(7, 24);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(141, 15);
            this.label42.TabIndex = 58;
            this.label42.Text = "Access Password (HEX)";
            // 
            // textBoxLockAccessPwd
            // 
            this.textBoxLockAccessPwd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxLockAccessPwd.Font = new System.Drawing.Font("Arial", 9F);
            this.textBoxLockAccessPwd.Location = new System.Drawing.Point(153, 19);
            this.textBoxLockAccessPwd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxLockAccessPwd.Name = "textBoxLockAccessPwd";
            this.textBoxLockAccessPwd.Size = new System.Drawing.Size(80, 21);
            this.textBoxLockAccessPwd.TabIndex = 57;
            this.textBoxLockAccessPwd.Text = "00 00 00 00";
            this.textBoxLockAccessPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbxKill
            // 
            this.gbxKill.Controls.Add(this.labelKillRFU);
            this.gbxKill.Controls.Add(this.textBoxKillRFU);
            this.gbxKill.Controls.Add(this.label44);
            this.gbxKill.Controls.Add(this.textBoxKillPwd);
            this.gbxKill.Controls.Add(this.buttonKill);
            this.gbxKill.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxKill.Location = new System.Drawing.Point(6, 122);
            this.gbxKill.Name = "gbxKill";
            this.gbxKill.Size = new System.Drawing.Size(518, 46);
            this.gbxKill.TabIndex = 69;
            this.gbxKill.TabStop = false;
            this.gbxKill.Text = "Kill";
            // 
            // labelKillRFU
            // 
            this.labelKillRFU.AutoSize = true;
            this.labelKillRFU.Location = new System.Drawing.Point(265, 19);
            this.labelKillRFU.Name = "labelKillRFU";
            this.labelKillRFU.Size = new System.Drawing.Size(68, 15);
            this.labelKillRFU.TabIndex = 62;
            this.labelKillRFU.Text = "RFU(3 bits)";
            // 
            // textBoxKillRFU
            // 
            this.textBoxKillRFU.Location = new System.Drawing.Point(343, 16);
            this.textBoxKillRFU.Name = "textBoxKillRFU";
            this.textBoxKillRFU.Size = new System.Drawing.Size(42, 21);
            this.textBoxKillRFU.TabIndex = 61;
            this.textBoxKillRFU.Text = "000";
            this.textBoxKillRFU.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(13, 18);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(118, 15);
            this.label44.TabIndex = 60;
            this.label44.Text = "Kill Password (HEX)";
            // 
            // textBoxKillPwd
            // 
            this.textBoxKillPwd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxKillPwd.Font = new System.Drawing.Font("Arial", 9F);
            this.textBoxKillPwd.Location = new System.Drawing.Point(149, 16);
            this.textBoxKillPwd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxKillPwd.Name = "textBoxKillPwd";
            this.textBoxKillPwd.Size = new System.Drawing.Size(81, 21);
            this.textBoxKillPwd.TabIndex = 59;
            this.textBoxKillPwd.Text = "00 00 00 00";
            this.textBoxKillPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonKill
            // 
            this.buttonKill.Location = new System.Drawing.Point(408, 11);
            this.buttonKill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonKill.Name = "buttonKill";
            this.buttonKill.Size = new System.Drawing.Size(101, 30);
            this.buttonKill.TabIndex = 52;
            this.buttonKill.Text = "Kill";
            this.buttonKill.UseVisualStyleBackColor = true;
            this.buttonKill.Click += new System.EventHandler(this.buttonKill_Click);
            // 
            // label_Acess1
            // 
            this.label_Acess1.AutoSize = true;
            this.label_Acess1.ForeColor = System.Drawing.Color.Red;
            this.label_Acess1.Location = new System.Drawing.Point(821, 54);
            this.label_Acess1.Name = "label_Acess1";
            this.label_Acess1.Size = new System.Drawing.Size(171, 15);
            this.label_Acess1.TabIndex = 80;
            this.label_Acess1.Text = "Step1: Search EPC ID of Tags";
            // 
            // gbxStatus2
            // 
            this.gbxStatus2.Controls.Add(this.rtbxStatus);
            this.gbxStatus2.Controls.Add(this.txtOperateEpc);
            this.gbxStatus2.Controls.Add(this.label27);
            this.gbxStatus2.Controls.Add(this.labelStatus);
            this.gbxStatus2.Location = new System.Drawing.Point(511, 569);
            this.gbxStatus2.Name = "gbxStatus2";
            this.gbxStatus2.Size = new System.Drawing.Size(549, 67);
            this.gbxStatus2.TabIndex = 79;
            this.gbxStatus2.TabStop = false;
            // 
            // rtbxStatus
            // 
            this.rtbxStatus.BackColor = System.Drawing.SystemColors.Control;
            this.rtbxStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbxStatus.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbxStatus.Location = new System.Drawing.Point(76, 44);
            this.rtbxStatus.Name = "rtbxStatus";
            this.rtbxStatus.Size = new System.Drawing.Size(433, 21);
            this.rtbxStatus.TabIndex = 79;
            this.rtbxStatus.Text = "";
            // 
            // txtOperateEpc
            // 
            this.txtOperateEpc.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtOperateEpc.Location = new System.Drawing.Point(74, 16);
            this.txtOperateEpc.Name = "txtOperateEpc";
            this.txtOperateEpc.ReadOnly = true;
            this.txtOperateEpc.Size = new System.Drawing.Size(469, 21);
            this.txtOperateEpc.TabIndex = 78;
            this.txtOperateEpc.DoubleClick += new System.EventHandler(this.txtOperateEpc_DoubleClick);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(9, 20);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(56, 15);
            this.label27.TabIndex = 77;
            this.label27.Text = "PC+EPC:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(9, 46);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(47, 15);
            this.labelStatus.TabIndex = 77;
            this.labelStatus.Text = "Status:";
            // 
            // inv_mode
            // 
            this.inv_mode.AutoSize = true;
            this.inv_mode.Location = new System.Drawing.Point(869, 128);
            this.inv_mode.Name = "inv_mode";
            this.inv_mode.Size = new System.Drawing.Size(62, 19);
            this.inv_mode.TabIndex = 48;
            this.inv_mode.Text = "Select";
            this.inv_mode.UseVisualStyleBackColor = true;
            this.inv_mode.CheckedChanged += new System.EventHandler(this.inv_mode_CheckedChanged);
            // 
            // gbx_comcnt_adv
            // 
            this.gbx_comcnt_adv.Controls.Add(this.btnClearCntAdv);
            this.gbx_comcnt_adv.Controls.Add(this.label18);
            this.gbx_comcnt_adv.Controls.Add(this.txtCOMRxCnt_adv);
            this.gbx_comcnt_adv.Controls.Add(this.label19);
            this.gbx_comcnt_adv.Controls.Add(this.txtCOMTxCnt_adv);
            this.gbx_comcnt_adv.Location = new System.Drawing.Point(818, 212);
            this.gbx_comcnt_adv.Name = "gbx_comcnt_adv";
            this.gbx_comcnt_adv.Size = new System.Drawing.Size(229, 98);
            this.gbx_comcnt_adv.TabIndex = 26;
            this.gbx_comcnt_adv.TabStop = false;
            // 
            // btnClearCntAdv
            // 
            this.btnClearCntAdv.Location = new System.Drawing.Point(6, 14);
            this.btnClearCntAdv.Name = "btnClearCntAdv";
            this.btnClearCntAdv.Size = new System.Drawing.Size(87, 29);
            this.btnClearCntAdv.TabIndex = 5;
            this.btnClearCntAdv.Text = "Reset";
            this.btnClearCntAdv.UseVisualStyleBackColor = true;
            this.btnClearCntAdv.Click += new System.EventHandler(this.btn_clear_cnt_adv_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(20, 68);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(25, 15);
            this.label18.TabIndex = 24;
            this.label18.Text = "TX:";
            // 
            // txtCOMRxCnt_adv
            // 
            this.txtCOMRxCnt_adv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCOMRxCnt_adv.Location = new System.Drawing.Point(51, 49);
            this.txtCOMRxCnt_adv.Name = "txtCOMRxCnt_adv";
            this.txtCOMRxCnt_adv.ReadOnly = true;
            this.txtCOMRxCnt_adv.Size = new System.Drawing.Size(88, 14);
            this.txtCOMRxCnt_adv.TabIndex = 21;
            this.txtCOMRxCnt_adv.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(19, 49);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(26, 15);
            this.label19.TabIndex = 22;
            this.label19.Text = "RX:";
            // 
            // txtCOMTxCnt_adv
            // 
            this.txtCOMTxCnt_adv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCOMTxCnt_adv.Location = new System.Drawing.Point(51, 69);
            this.txtCOMTxCnt_adv.Name = "txtCOMTxCnt_adv";
            this.txtCOMTxCnt_adv.ReadOnly = true;
            this.txtCOMTxCnt_adv.Size = new System.Drawing.Size(88, 14);
            this.txtCOMTxCnt_adv.TabIndex = 23;
            this.txtCOMTxCnt_adv.Text = "0";
            // 
            // btnInvtAdv
            // 
            this.btnInvtAdv.Location = new System.Drawing.Point(831, 72);
            this.btnInvtAdv.Name = "btnInvtAdv";
            this.btnInvtAdv.Size = new System.Drawing.Size(161, 38);
            this.btnInvtAdv.TabIndex = 2;
            this.btnInvtAdv.Text = "Read Single";
            this.btnInvtAdv.UseVisualStyleBackColor = true;
            this.btnInvtAdv.Click += new System.EventHandler(this.btn_invt2_Click);
            // 
            // gbxEpcTableAdv
            // 
            this.gbxEpcTableAdv.Controls.Add(this.label_Access2);
            this.gbxEpcTableAdv.Controls.Add(this.btn_clear_epc2);
            this.gbxEpcTableAdv.Controls.Add(this.dgv_epc2);
            this.gbxEpcTableAdv.Location = new System.Drawing.Point(0, 6);
            this.gbxEpcTableAdv.Name = "gbxEpcTableAdv";
            this.gbxEpcTableAdv.Size = new System.Drawing.Size(806, 324);
            this.gbxEpcTableAdv.TabIndex = 0;
            this.gbxEpcTableAdv.TabStop = false;
            this.gbxEpcTableAdv.Text = "EPC Table";
            // 
            // label_Access2
            // 
            this.label_Access2.AutoSize = true;
            this.label_Access2.ForeColor = System.Drawing.Color.Red;
            this.label_Access2.Location = new System.Drawing.Point(115, 17);
            this.label_Access2.Name = "label_Access2";
            this.label_Access2.Size = new System.Drawing.Size(291, 15);
            this.label_Access2.TabIndex = 81;
            this.label_Access2.Text = "Step2: Click One of EPC Tag which to be Accessed";
            // 
            // btn_clear_epc2
            // 
            this.btn_clear_epc2.Location = new System.Drawing.Point(452, 12);
            this.btn_clear_epc2.Name = "btn_clear_epc2";
            this.btn_clear_epc2.Size = new System.Drawing.Size(75, 29);
            this.btn_clear_epc2.TabIndex = 21;
            this.btn_clear_epc2.Text = "Clear";
            this.btn_clear_epc2.UseVisualStyleBackColor = true;
            this.btn_clear_epc2.Click += new System.EventHandler(this.btn_clear_epc2_Click);
            // 
            // dgv_epc2
            // 
            this.dgv_epc2.AllowUserToAddRows = false;
            this.dgv_epc2.AllowUserToDeleteRows = false;
            this.dgv_epc2.AllowUserToResizeColumns = false;
            this.dgv_epc2.AllowUserToResizeRows = false;
            this.dgv_epc2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_epc2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_epc2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_epc2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgv_epc2.Location = new System.Drawing.Point(6, 43);
            this.dgv_epc2.Name = "dgv_epc2";
            this.dgv_epc2.ReadOnly = true;
            this.dgv_epc2.RowHeadersVisible = false;
            this.dgv_epc2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_epc2.RowTemplate.Height = 18;
            this.dgv_epc2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_epc2.Size = new System.Drawing.Size(793, 275);
            this.dgv_epc2.TabIndex = 20;
            this.dgv_epc2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGrid_MouseUp);
            // 
            // tabPageSysSetting
            // 
            this.tabPageSysSetting.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageSysSetting.Controls.Add(this.groupBox3);
            this.tabPageSysSetting.Controls.Add(this.groupBox_RFSetting);
            this.tabPageSysSetting.Location = new System.Drawing.Point(4, 24);
            this.tabPageSysSetting.Name = "tabPageSysSetting";
            this.tabPageSysSetting.Size = new System.Drawing.Size(1066, 638);
            this.tabPageSysSetting.TabIndex = 4;
            this.tabPageSysSetting.Text = "System Setting";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox_GPIO);
            this.groupBox3.Controls.Add(this.gbxIoControl);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(8, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(265, 631);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "System";
            // 
            // groupBox_GPIO
            // 
            this.groupBox_GPIO.Controls.Add(this.groupBox7);
            this.groupBox_GPIO.Controls.Add(this.groupBox_GPO);
            this.groupBox_GPIO.Location = new System.Drawing.Point(6, 277);
            this.groupBox_GPIO.Name = "groupBox_GPIO";
            this.groupBox_GPIO.Size = new System.Drawing.Size(253, 348);
            this.groupBox_GPIO.TabIndex = 115;
            this.groupBox_GPIO.TabStop = false;
            this.groupBox_GPIO.Text = "GPIO (Fixed Reader Only)";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.checkBox_GPI4);
            this.groupBox7.Controls.Add(this.button_GPI_Get);
            this.groupBox7.Controls.Add(this.checkBox_GPI3);
            this.groupBox7.Controls.Add(this.checkBox_GPI2);
            this.groupBox7.Controls.Add(this.comboBox_GPI4);
            this.groupBox7.Controls.Add(this.checkBox_GPI1);
            this.groupBox7.Controls.Add(this.comboBox_GPI3);
            this.groupBox7.Controls.Add(this.comboBox_GPI2);
            this.groupBox7.Controls.Add(this.comboBox_GPI1);
            this.groupBox7.Location = new System.Drawing.Point(10, 190);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(229, 140);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "GPI";
            // 
            // checkBox_GPI4
            // 
            this.checkBox_GPI4.AutoSize = true;
            this.checkBox_GPI4.Location = new System.Drawing.Point(8, 112);
            this.checkBox_GPI4.Name = "checkBox_GPI4";
            this.checkBox_GPI4.Size = new System.Drawing.Size(52, 19);
            this.checkBox_GPI4.TabIndex = 72;
            this.checkBox_GPI4.Text = "GPI4";
            this.checkBox_GPI4.UseVisualStyleBackColor = true;
            // 
            // button_GPI_Get
            // 
            this.button_GPI_Get.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_GPI_Get.Location = new System.Drawing.Point(138, 69);
            this.button_GPI_Get.Name = "button_GPI_Get";
            this.button_GPI_Get.Size = new System.Drawing.Size(87, 32);
            this.button_GPI_Get.TabIndex = 2;
            this.button_GPI_Get.Text = "Get";
            this.button_GPI_Get.UseVisualStyleBackColor = true;
            this.button_GPI_Get.Click += new System.EventHandler(this.button_GPI_Get_Click);
            // 
            // checkBox_GPI3
            // 
            this.checkBox_GPI3.AutoSize = true;
            this.checkBox_GPI3.Location = new System.Drawing.Point(8, 81);
            this.checkBox_GPI3.Name = "checkBox_GPI3";
            this.checkBox_GPI3.Size = new System.Drawing.Size(52, 19);
            this.checkBox_GPI3.TabIndex = 71;
            this.checkBox_GPI3.Text = "GPI3";
            this.checkBox_GPI3.UseVisualStyleBackColor = true;
            // 
            // checkBox_GPI2
            // 
            this.checkBox_GPI2.AutoSize = true;
            this.checkBox_GPI2.Location = new System.Drawing.Point(8, 52);
            this.checkBox_GPI2.Name = "checkBox_GPI2";
            this.checkBox_GPI2.Size = new System.Drawing.Size(52, 19);
            this.checkBox_GPI2.TabIndex = 70;
            this.checkBox_GPI2.Text = "GPI2";
            this.checkBox_GPI2.UseVisualStyleBackColor = true;
            // 
            // comboBox_GPI4
            // 
            this.comboBox_GPI4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_GPI4.FormattingEnabled = true;
            this.comboBox_GPI4.Items.AddRange(new object[] {
            "Low",
            "High"});
            this.comboBox_GPI4.Location = new System.Drawing.Point(72, 109);
            this.comboBox_GPI4.Name = "comboBox_GPI4";
            this.comboBox_GPI4.Size = new System.Drawing.Size(60, 23);
            this.comboBox_GPI4.TabIndex = 64;
            // 
            // checkBox_GPI1
            // 
            this.checkBox_GPI1.AutoSize = true;
            this.checkBox_GPI1.Location = new System.Drawing.Point(8, 21);
            this.checkBox_GPI1.Name = "checkBox_GPI1";
            this.checkBox_GPI1.Size = new System.Drawing.Size(52, 19);
            this.checkBox_GPI1.TabIndex = 69;
            this.checkBox_GPI1.Text = "GPI1";
            this.checkBox_GPI1.UseVisualStyleBackColor = true;
            // 
            // comboBox_GPI3
            // 
            this.comboBox_GPI3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_GPI3.FormattingEnabled = true;
            this.comboBox_GPI3.Items.AddRange(new object[] {
            "Low",
            "High"});
            this.comboBox_GPI3.Location = new System.Drawing.Point(72, 79);
            this.comboBox_GPI3.Name = "comboBox_GPI3";
            this.comboBox_GPI3.Size = new System.Drawing.Size(60, 23);
            this.comboBox_GPI3.TabIndex = 64;
            // 
            // comboBox_GPI2
            // 
            this.comboBox_GPI2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_GPI2.FormattingEnabled = true;
            this.comboBox_GPI2.Items.AddRange(new object[] {
            "Low",
            "High"});
            this.comboBox_GPI2.Location = new System.Drawing.Point(72, 49);
            this.comboBox_GPI2.Name = "comboBox_GPI2";
            this.comboBox_GPI2.Size = new System.Drawing.Size(60, 23);
            this.comboBox_GPI2.TabIndex = 64;
            // 
            // comboBox_GPI1
            // 
            this.comboBox_GPI1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_GPI1.FormattingEnabled = true;
            this.comboBox_GPI1.Items.AddRange(new object[] {
            "Low",
            "High"});
            this.comboBox_GPI1.Location = new System.Drawing.Point(72, 19);
            this.comboBox_GPI1.Name = "comboBox_GPI1";
            this.comboBox_GPI1.Size = new System.Drawing.Size(60, 23);
            this.comboBox_GPI1.TabIndex = 64;
            // 
            // groupBox_GPO
            // 
            this.groupBox_GPO.Controls.Add(this.checkBox_GPO4);
            this.groupBox_GPO.Controls.Add(this.checkBox_GPO3);
            this.groupBox_GPO.Controls.Add(this.checkBox_GPO2);
            this.groupBox_GPO.Controls.Add(this.checkBox_GPO1);
            this.groupBox_GPO.Controls.Add(this.button_GPO_Set);
            this.groupBox_GPO.Controls.Add(this.button_GPO_Get);
            this.groupBox_GPO.Controls.Add(this.comboBox_GPO4);
            this.groupBox_GPO.Controls.Add(this.comboBox_GPO3);
            this.groupBox_GPO.Controls.Add(this.comboBox_GPO2);
            this.groupBox_GPO.Controls.Add(this.comboBox_GPO1);
            this.groupBox_GPO.Location = new System.Drawing.Point(13, 29);
            this.groupBox_GPO.Name = "groupBox_GPO";
            this.groupBox_GPO.Size = new System.Drawing.Size(229, 145);
            this.groupBox_GPO.TabIndex = 0;
            this.groupBox_GPO.TabStop = false;
            this.groupBox_GPO.Text = "GPO";
            // 
            // checkBox_GPO4
            // 
            this.checkBox_GPO4.AutoSize = true;
            this.checkBox_GPO4.Location = new System.Drawing.Point(8, 110);
            this.checkBox_GPO4.Name = "checkBox_GPO4";
            this.checkBox_GPO4.Size = new System.Drawing.Size(58, 19);
            this.checkBox_GPO4.TabIndex = 68;
            this.checkBox_GPO4.Text = "GPO4";
            this.checkBox_GPO4.UseVisualStyleBackColor = true;
            // 
            // checkBox_GPO3
            // 
            this.checkBox_GPO3.AutoSize = true;
            this.checkBox_GPO3.Location = new System.Drawing.Point(8, 79);
            this.checkBox_GPO3.Name = "checkBox_GPO3";
            this.checkBox_GPO3.Size = new System.Drawing.Size(58, 19);
            this.checkBox_GPO3.TabIndex = 67;
            this.checkBox_GPO3.Text = "GPO3";
            this.checkBox_GPO3.UseVisualStyleBackColor = true;
            // 
            // checkBox_GPO2
            // 
            this.checkBox_GPO2.AutoSize = true;
            this.checkBox_GPO2.Location = new System.Drawing.Point(8, 50);
            this.checkBox_GPO2.Name = "checkBox_GPO2";
            this.checkBox_GPO2.Size = new System.Drawing.Size(58, 19);
            this.checkBox_GPO2.TabIndex = 66;
            this.checkBox_GPO2.Text = "GPO2";
            this.checkBox_GPO2.UseVisualStyleBackColor = true;
            // 
            // checkBox_GPO1
            // 
            this.checkBox_GPO1.AutoSize = true;
            this.checkBox_GPO1.Location = new System.Drawing.Point(8, 19);
            this.checkBox_GPO1.Name = "checkBox_GPO1";
            this.checkBox_GPO1.Size = new System.Drawing.Size(58, 19);
            this.checkBox_GPO1.TabIndex = 65;
            this.checkBox_GPO1.Text = "GPO1";
            this.checkBox_GPO1.UseVisualStyleBackColor = true;
            // 
            // comboBox_GPO4
            // 
            this.comboBox_GPO4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_GPO4.FormattingEnabled = true;
            this.comboBox_GPO4.Items.AddRange(new object[] {
            "Low",
            "High"});
            this.comboBox_GPO4.Location = new System.Drawing.Point(72, 106);
            this.comboBox_GPO4.Name = "comboBox_GPO4";
            this.comboBox_GPO4.Size = new System.Drawing.Size(60, 23);
            this.comboBox_GPO4.TabIndex = 64;
            // 
            // comboBox_GPO3
            // 
            this.comboBox_GPO3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_GPO3.FormattingEnabled = true;
            this.comboBox_GPO3.Items.AddRange(new object[] {
            "Low",
            "High"});
            this.comboBox_GPO3.Location = new System.Drawing.Point(72, 77);
            this.comboBox_GPO3.Name = "comboBox_GPO3";
            this.comboBox_GPO3.Size = new System.Drawing.Size(60, 23);
            this.comboBox_GPO3.TabIndex = 64;
            // 
            // comboBox_GPO2
            // 
            this.comboBox_GPO2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_GPO2.FormattingEnabled = true;
            this.comboBox_GPO2.Items.AddRange(new object[] {
            "Low",
            "High"});
            this.comboBox_GPO2.Location = new System.Drawing.Point(72, 48);
            this.comboBox_GPO2.Name = "comboBox_GPO2";
            this.comboBox_GPO2.Size = new System.Drawing.Size(60, 23);
            this.comboBox_GPO2.TabIndex = 64;
            // 
            // comboBox_GPO1
            // 
            this.comboBox_GPO1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_GPO1.FormattingEnabled = true;
            this.comboBox_GPO1.Items.AddRange(new object[] {
            "Low",
            "High"});
            this.comboBox_GPO1.Location = new System.Drawing.Point(72, 19);
            this.comboBox_GPO1.Name = "comboBox_GPO1";
            this.comboBox_GPO1.Size = new System.Drawing.Size(60, 23);
            this.comboBox_GPO1.TabIndex = 64;
            // 
            // gbxIoControl
            // 
            this.gbxIoControl.Controls.Add(this.cbxIoDircetion);
            this.gbxIoControl.Controls.Add(this.cbxIoLevel);
            this.gbxIoControl.Controls.Add(this.btnSetIoDirection);
            this.gbxIoControl.Controls.Add(this.btnSetIO);
            this.gbxIoControl.Controls.Add(this.btnGetIO);
            this.gbxIoControl.Controls.Add(this.cbxIO);
            this.gbxIoControl.Location = new System.Drawing.Point(6, 172);
            this.gbxIoControl.Name = "gbxIoControl";
            this.gbxIoControl.Size = new System.Drawing.Size(253, 85);
            this.gbxIoControl.TabIndex = 60;
            this.gbxIoControl.TabStop = false;
            this.gbxIoControl.Text = "IO Operation(Module Reader Only)";
            this.gbxIoControl.Visible = false;
            // 
            // cbxIoDircetion
            // 
            this.cbxIoDircetion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIoDircetion.FormattingEnabled = true;
            this.cbxIoDircetion.Items.AddRange(new object[] {
            "Input",
            "Output"});
            this.cbxIoDircetion.Location = new System.Drawing.Point(182, 22);
            this.cbxIoDircetion.Name = "cbxIoDircetion";
            this.cbxIoDircetion.Size = new System.Drawing.Size(60, 23);
            this.cbxIoDircetion.TabIndex = 65;
            // 
            // cbxIoLevel
            // 
            this.cbxIoLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIoLevel.FormattingEnabled = true;
            this.cbxIoLevel.Items.AddRange(new object[] {
            "Low",
            "High"});
            this.cbxIoLevel.Location = new System.Drawing.Point(182, 54);
            this.cbxIoLevel.Name = "cbxIoLevel";
            this.cbxIoLevel.Size = new System.Drawing.Size(60, 23);
            this.cbxIoLevel.TabIndex = 64;
            // 
            // btnSetIoDirection
            // 
            this.btnSetIoDirection.Location = new System.Drawing.Point(82, 20);
            this.btnSetIoDirection.Name = "btnSetIoDirection";
            this.btnSetIoDirection.Size = new System.Drawing.Size(94, 27);
            this.btnSetIoDirection.TabIndex = 62;
            this.btnSetIoDirection.Text = "Set Direction";
            this.btnSetIoDirection.UseVisualStyleBackColor = true;
            this.btnSetIoDirection.Click += new System.EventHandler(this.btnSetIoDirection_Click);
            // 
            // cbxIO
            // 
            this.cbxIO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIO.FormattingEnabled = true;
            this.cbxIO.Items.AddRange(new object[] {
            "IO1",
            "IO2",
            "IO3",
            "IO4"});
            this.cbxIO.Location = new System.Drawing.Point(9, 23);
            this.cbxIO.Name = "cbxIO";
            this.cbxIO.Size = new System.Drawing.Size(67, 23);
            this.cbxIO.TabIndex = 58;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnGetMode);
            this.groupBox4.Controls.Add(this.btnSetModuleSleep);
            this.groupBox4.Controls.Add(this.bynSaveConfigToNv);
            this.groupBox4.Controls.Add(this.cbxSaveNvConfig);
            this.groupBox4.Controls.Add(this.cbxMode);
            this.groupBox4.Controls.Add(this.btnSetMode);
            this.groupBox4.Location = new System.Drawing.Point(6, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(253, 141);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "General Setting";
            // 
            // btnGetMode
            // 
            this.btnGetMode.Location = new System.Drawing.Point(10, 53);
            this.btnGetMode.Name = "btnGetMode";
            this.btnGetMode.Size = new System.Drawing.Size(95, 29);
            this.btnGetMode.TabIndex = 33;
            this.btnGetMode.Text = "Get Mode";
            this.btnGetMode.UseVisualStyleBackColor = true;
            this.btnGetMode.Click += new System.EventHandler(this.btnGetMode_Click);
            // 
            // btnSetModuleSleep
            // 
            this.btnSetModuleSleep.Enabled = false;
            this.btnSetModuleSleep.Location = new System.Drawing.Point(131, 100);
            this.btnSetModuleSleep.Name = "btnSetModuleSleep";
            this.btnSetModuleSleep.Size = new System.Drawing.Size(95, 29);
            this.btnSetModuleSleep.TabIndex = 32;
            this.btnSetModuleSleep.Text = "Sleep";
            this.btnSetModuleSleep.UseVisualStyleBackColor = true;
            this.btnSetModuleSleep.Click += new System.EventHandler(this.btnSetModuleSleep_Click);
            // 
            // bynSaveConfigToNv
            // 
            this.bynSaveConfigToNv.Enabled = false;
            this.bynSaveConfigToNv.Location = new System.Drawing.Point(10, 100);
            this.bynSaveConfigToNv.Name = "bynSaveConfigToNv";
            this.bynSaveConfigToNv.Size = new System.Drawing.Size(96, 29);
            this.bynSaveConfigToNv.TabIndex = 31;
            this.bynSaveConfigToNv.Text = "Save Config";
            this.bynSaveConfigToNv.UseVisualStyleBackColor = true;
            this.bynSaveConfigToNv.Click += new System.EventHandler(this.btnSaveConfigToNv_Click);
            // 
            // cbxSaveNvConfig
            // 
            this.cbxSaveNvConfig.AutoSize = true;
            this.cbxSaveNvConfig.Checked = true;
            this.cbxSaveNvConfig.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxSaveNvConfig.Enabled = false;
            this.cbxSaveNvConfig.Location = new System.Drawing.Point(123, 64);
            this.cbxSaveNvConfig.Name = "cbxSaveNvConfig";
            this.cbxSaveNvConfig.Size = new System.Drawing.Size(103, 19);
            this.cbxSaveNvConfig.TabIndex = 30;
            this.cbxSaveNvConfig.Text = "Config Enable";
            this.cbxSaveNvConfig.UseVisualStyleBackColor = true;
            // 
            // cbxMode
            // 
            this.cbxMode.AutoCompleteCustomSource.AddRange(new string[] {
            "High Sensitivity",
            "Dense Reader"});
            this.cbxMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMode.FormattingEnabled = true;
            this.cbxMode.Items.AddRange(new object[] {
            "High Sensitivity",
            "Dense Reader",
            "User Configuration"});
            this.cbxMode.Location = new System.Drawing.Point(127, 24);
            this.cbxMode.Name = "cbxMode";
            this.cbxMode.Size = new System.Drawing.Size(112, 23);
            this.cbxMode.TabIndex = 29;
            // 
            // btnSetMode
            // 
            this.btnSetMode.Location = new System.Drawing.Point(10, 20);
            this.btnSetMode.Name = "btnSetMode";
            this.btnSetMode.Size = new System.Drawing.Size(95, 29);
            this.btnSetMode.TabIndex = 28;
            this.btnSetMode.Text = "Set Mode";
            this.btnSetMode.UseVisualStyleBackColor = true;
            this.btnSetMode.Click += new System.EventHandler(this.btnSetMode_Click);
            // 
            // groupBox_RFSetting
            // 
            this.groupBox_RFSetting.Controls.Add(this.gbxRfPower);
            this.groupBox_RFSetting.Controls.Add(this.gbx_setfreq);
            this.groupBox_RFSetting.Controls.Add(this.groupBox_RF_Ant);
            this.groupBox_RFSetting.Location = new System.Drawing.Point(286, 3);
            this.groupBox_RFSetting.Name = "groupBox_RFSetting";
            this.groupBox_RFSetting.Size = new System.Drawing.Size(737, 634);
            this.groupBox_RFSetting.TabIndex = 3;
            this.groupBox_RFSetting.TabStop = false;
            this.groupBox_RFSetting.Text = "RF Setting";
            // 
            // gbxRfPower
            // 
            this.gbxRfPower.Controls.Add(this.btnSetCW);
            this.gbxRfPower.Controls.Add(this.btnGetPaPower);
            this.gbxRfPower.Controls.Add(this.cbxPaPower);
            this.gbxRfPower.Controls.Add(this.btnSetPaPower);
            this.gbxRfPower.Location = new System.Drawing.Point(6, 319);
            this.gbxRfPower.Name = "gbxRfPower";
            this.gbxRfPower.Size = new System.Drawing.Size(303, 109);
            this.gbxRfPower.TabIndex = 27;
            this.gbxRfPower.TabStop = false;
            this.gbxRfPower.Text = "RF Power Setting";
            // 
            // btnGetPaPower
            // 
            this.btnGetPaPower.Location = new System.Drawing.Point(113, 20);
            this.btnGetPaPower.Name = "btnGetPaPower";
            this.btnGetPaPower.Size = new System.Drawing.Size(99, 29);
            this.btnGetPaPower.TabIndex = 2;
            this.btnGetPaPower.Text = "Get PA Power";
            this.btnGetPaPower.UseVisualStyleBackColor = true;
            this.btnGetPaPower.Click += new System.EventHandler(this.btnGetPaPower_Click);
            // 
            // cbxPaPower
            // 
            this.cbxPaPower.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPaPower.FormattingEnabled = true;
            this.cbxPaPower.Items.AddRange(new object[] {
            "20dBm",
            "18.5dBm",
            "17dBm",
            "15.5dBm",
            "14dBm",
            "12.5dBm"});
            this.cbxPaPower.Location = new System.Drawing.Point(219, 23);
            this.cbxPaPower.Name = "cbxPaPower";
            this.cbxPaPower.Size = new System.Drawing.Size(74, 23);
            this.cbxPaPower.TabIndex = 1;
            // 
            // btnSetPaPower
            // 
            this.btnSetPaPower.Location = new System.Drawing.Point(8, 20);
            this.btnSetPaPower.Name = "btnSetPaPower";
            this.btnSetPaPower.Size = new System.Drawing.Size(99, 29);
            this.btnSetPaPower.TabIndex = 0;
            this.btnSetPaPower.Text = "Set PA Power";
            this.btnSetPaPower.UseVisualStyleBackColor = true;
            this.btnSetPaPower.Click += new System.EventHandler(this.btnSetPaPower_Click);
            // 
            // gbx_setfreq
            // 
            this.gbx_setfreq.Controls.Add(this.gbx_InsertRFCH);
            this.gbx_setfreq.Controls.Add(this.btnGetRegion);
            this.gbx_setfreq.Controls.Add(this.btnGetFreqHopPeriod);
            this.gbx_setfreq.Controls.Add(this.btnSetFreqHopPeriod);
            this.gbx_setfreq.Controls.Add(this.cbxFhssHopPeriod);
            this.gbx_setfreq.Controls.Add(this.cbxFHSS);
            this.gbx_setfreq.Controls.Add(this.btnGetFhss);
            this.gbx_setfreq.Controls.Add(this.btnSetRegion);
            this.gbx_setfreq.Controls.Add(this.btnGetChannel);
            this.gbx_setfreq.Controls.Add(this.btnSetFhss);
            this.gbx_setfreq.Controls.Add(this.cbxChannel);
            this.gbx_setfreq.Controls.Add(this.cbxRegion);
            this.gbx_setfreq.Controls.Add(this.btnSetFreq);
            this.gbx_setfreq.Location = new System.Drawing.Point(6, 21);
            this.gbx_setfreq.Name = "gbx_setfreq";
            this.gbx_setfreq.Size = new System.Drawing.Size(325, 278);
            this.gbx_setfreq.TabIndex = 17;
            this.gbx_setfreq.TabStop = false;
            this.gbx_setfreq.Text = "RF Channel Setting";
            // 
            // gbx_InsertRFCH
            // 
            this.gbx_InsertRFCH.Controls.Add(this.btnInsertRfCh_Help);
            this.gbx_InsertRFCH.Controls.Add(this.btnInsertRfCh_Get);
            this.gbx_InsertRFCH.Controls.Add(this.txtChIndexBegin);
            this.gbx_InsertRFCH.Controls.Add(this.label47);
            this.gbx_InsertRFCH.Controls.Add(this.label46);
            this.gbx_InsertRFCH.Controls.Add(this.txtChIndexEnd);
            this.gbx_InsertRFCH.Controls.Add(this.btnInsertRfCh);
            this.gbx_InsertRFCH.Location = new System.Drawing.Point(9, 95);
            this.gbx_InsertRFCH.Name = "gbx_InsertRFCH";
            this.gbx_InsertRFCH.Size = new System.Drawing.Size(283, 101);
            this.gbx_InsertRFCH.TabIndex = 25;
            this.gbx_InsertRFCH.TabStop = false;
            this.gbx_InsertRFCH.Text = "Insert RFCH";
            // 
            // btnInsertRfCh_Help
            // 
            this.btnInsertRfCh_Help.Location = new System.Drawing.Point(246, 61);
            this.btnInsertRfCh_Help.Name = "btnInsertRfCh_Help";
            this.btnInsertRfCh_Help.Size = new System.Drawing.Size(17, 23);
            this.btnInsertRfCh_Help.TabIndex = 25;
            this.btnInsertRfCh_Help.Text = "?";
            this.btnInsertRfCh_Help.UseVisualStyleBackColor = true;
            this.btnInsertRfCh_Help.Click += new System.EventHandler(this.btnInsertRfCh_Help_Click);
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(186, 29);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(33, 15);
            this.label47.TabIndex = 16;
            this.label47.Text = "Stop";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(104, 30);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(35, 15);
            this.label46.TabIndex = 15;
            this.label46.Text = "Start";
            // 
            // cbxFhssHopPeriod
            // 
            this.cbxFhssHopPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFhssHopPeriod.FormattingEnabled = true;
            this.cbxFhssHopPeriod.Items.AddRange(new object[] {
            "100mS",
            "200mS",
            "300mS",
            "400mS",
            "500mS",
            "600mS",
            "700mS",
            "800mS",
            "900mS",
            "1000mS",
            "1100mS",
            "1200mS",
            "1300mS",
            "1400mS",
            "1500mS",
            "1600mS",
            "1700mS",
            "1800mS",
            "1900mS",
            "2000mS",
            "2100mS",
            "2200mS",
            "2300mS",
            "2400mS",
            "2500mS"});
            this.cbxFhssHopPeriod.Location = new System.Drawing.Point(196, 245);
            this.cbxFhssHopPeriod.Name = "cbxFhssHopPeriod";
            this.cbxFhssHopPeriod.Size = new System.Drawing.Size(95, 23);
            this.cbxFhssHopPeriod.TabIndex = 20;
            // 
            // cbxFHSS
            // 
            this.cbxFHSS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFHSS.FormattingEnabled = true;
            this.cbxFHSS.Items.AddRange(new object[] {
            "FHSS OFF",
            "FHSS ON"});
            this.cbxFHSS.Location = new System.Drawing.Point(196, 204);
            this.cbxFHSS.Name = "cbxFHSS";
            this.cbxFHSS.Size = new System.Drawing.Size(95, 23);
            this.cbxFHSS.TabIndex = 19;
            // 
            // btnGetChannel
            // 
            this.btnGetChannel.Location = new System.Drawing.Point(105, 60);
            this.btnGetChannel.Name = "btnGetChannel";
            this.btnGetChannel.Size = new System.Drawing.Size(87, 29);
            this.btnGetChannel.TabIndex = 7;
            this.btnGetChannel.Text = "Get RFCH";
            this.btnGetChannel.UseVisualStyleBackColor = true;
            this.btnGetChannel.Click += new System.EventHandler(this.btnGetChannel_Click);
            // 
            // cbxChannel
            // 
            this.cbxChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxChannel.FormattingEnabled = true;
            this.cbxChannel.Items.AddRange(new object[] {
            "920.125MHz",
            "920.375MHz",
            "920.625MHz",
            "920.875MHz",
            "921.125MHz",
            "921.375MHz",
            "921.625MHz",
            "921.875MHz",
            "922.125MHz",
            "922.375MHz",
            "922.625MHz",
            "922.875MHz",
            "923.125MHz",
            "923.375MHz",
            "923.625MHz",
            "923.875MHz",
            "924.125MHz",
            "924.375MHz",
            "924.625MHz",
            "924.875MHz"});
            this.cbxChannel.Location = new System.Drawing.Point(198, 63);
            this.cbxChannel.Name = "cbxChannel";
            this.cbxChannel.Size = new System.Drawing.Size(121, 23);
            this.cbxChannel.TabIndex = 4;
            // 
            // cbxRegion
            // 
            this.cbxRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRegion.FormattingEnabled = true;
            this.cbxRegion.Items.AddRange(new object[] {
            "China2 (Code=1)",
            "China1 (Code=4)",
            "US       (Code=2)",
            "Europe (Code=3)",
            "Korea   (Code=6)",
            "Singapore(Code=7)",
            "SouthAfrica(Code=8)",
            "Malaysia(Code=9)"});
            this.cbxRegion.Location = new System.Drawing.Point(198, 23);
            this.cbxRegion.Name = "cbxRegion";
            this.cbxRegion.Size = new System.Drawing.Size(121, 23);
            this.cbxRegion.TabIndex = 3;
            this.cbxRegion.SelectedIndexChanged += new System.EventHandler(this.cbxRegion_SelectedIndexChanged);
            // 
            // btnSetFreq
            // 
            this.btnSetFreq.Location = new System.Drawing.Point(8, 60);
            this.btnSetFreq.Name = "btnSetFreq";
            this.btnSetFreq.Size = new System.Drawing.Size(87, 29);
            this.btnSetFreq.TabIndex = 0;
            this.btnSetFreq.Text = "Set RFCH";
            this.btnSetFreq.UseVisualStyleBackColor = true;
            this.btnSetFreq.Click += new System.EventHandler(this.btnSetFreq_Click);
            // 
            // groupBox_RF_Ant
            // 
            this.groupBox_RF_Ant.Controls.Add(this.btn_AntQuantityHelp);
            this.groupBox_RF_Ant.Controls.Add(this.button_RF_Ant_Get);
            this.groupBox_RF_Ant.Controls.Add(this.button_RF_Ant_Set);
            this.groupBox_RF_Ant.Controls.Add(this.label_AntPort_Quantity);
            this.groupBox_RF_Ant.Controls.Add(this.groupBox_RF_Ant_Port);
            this.groupBox_RF_Ant.Controls.Add(this.comboBox_RF_AntPort_Quantity);
            this.groupBox_RF_Ant.Controls.Add(this.checkBox_RF_AntPort_AutoPolling);
            this.groupBox_RF_Ant.Location = new System.Drawing.Point(337, 20);
            this.groupBox_RF_Ant.Name = "groupBox_RF_Ant";
            this.groupBox_RF_Ant.Size = new System.Drawing.Size(392, 611);
            this.groupBox_RF_Ant.TabIndex = 0;
            this.groupBox_RF_Ant.TabStop = false;
            this.groupBox_RF_Ant.Text = "Ant Setting";
            // 
            // btn_AntQuantityHelp
            // 
            this.btn_AntQuantityHelp.Location = new System.Drawing.Point(118, 21);
            this.btn_AntQuantityHelp.Name = "btn_AntQuantityHelp";
            this.btn_AntQuantityHelp.Size = new System.Drawing.Size(17, 22);
            this.btn_AntQuantityHelp.TabIndex = 29;
            this.btn_AntQuantityHelp.Text = "?";
            this.btn_AntQuantityHelp.UseVisualStyleBackColor = true;
            this.btn_AntQuantityHelp.Click += new System.EventHandler(this.btn_AntQuantityHelp_Click);
            // 
            // groupBox_RF_Ant_Port
            // 
            this.groupBox_RF_Ant_Port.Controls.Add(this.comboBoxRF_AntPort_PortAll);
            this.groupBox_RF_Ant_Port.Controls.Add(this.button_RF_Ant_SetAllParameter);
            this.groupBox_RF_Ant_Port.Controls.Add(this.btn_AntAutoPolling_ParametersHelp);
            this.groupBox_RF_Ant_Port.Controls.Add(this.button_RF_Ant_GetCurrentAntPort);
            this.groupBox_RF_Ant_Port.Controls.Add(this.groupBox_RF_Ant_Enable);
            this.groupBox_RF_Ant_Port.Controls.Add(this.groupBox_RF_Ant_SwitchAnt);
            this.groupBox_RF_Ant_Port.Controls.Add(this.label_RF_AntPort_InvCnter);
            this.groupBox_RF_Ant_Port.Controls.Add(this.label_RF_AntPort_Power);
            this.groupBox_RF_Ant_Port.Controls.Add(this.textBox_RF_AntPort_InvCnter16);
            this.groupBox_RF_Ant_Port.Controls.Add(this.textBox_RF_AntPort_InvCnter8);
            this.groupBox_RF_Ant_Port.Controls.Add(this.comboBoxRF_AntPort_Port16);
            this.groupBox_RF_Ant_Port.Controls.Add(this.comboBoxRF_AntPort_Port8);
            this.groupBox_RF_Ant_Port.Controls.Add(this.comboBoxRF_AntPort_Port15);
            this.groupBox_RF_Ant_Port.Controls.Add(this.textBox_RF_AntPort_InvCnter15);
            this.groupBox_RF_Ant_Port.Controls.Add(this.textBox_RF_AntPort_InvCnter7);
            this.groupBox_RF_Ant_Port.Controls.Add(this.comboBoxRF_AntPort_Port7);
            this.groupBox_RF_Ant_Port.Controls.Add(this.textBox_RF_AntPort_InvCnter14);
            this.groupBox_RF_Ant_Port.Controls.Add(this.comboBoxRF_AntPort_Port14);
            this.groupBox_RF_Ant_Port.Controls.Add(this.textBox_RF_AntPort_InvCnter6);
            this.groupBox_RF_Ant_Port.Controls.Add(this.comboBoxRF_AntPort_Port6);
            this.groupBox_RF_Ant_Port.Controls.Add(this.textBox_RF_AntPort_InvCnter13);
            this.groupBox_RF_Ant_Port.Controls.Add(this.comboBoxRF_AntPort_Port13);
            this.groupBox_RF_Ant_Port.Controls.Add(this.textBox_RF_AntPort_InvCnter5);
            this.groupBox_RF_Ant_Port.Controls.Add(this.comboBoxRF_AntPort_Port5);
            this.groupBox_RF_Ant_Port.Controls.Add(this.textBox_RF_AntPort_InvCnter12);
            this.groupBox_RF_Ant_Port.Controls.Add(this.comboBoxRF_AntPort_Port12);
            this.groupBox_RF_Ant_Port.Controls.Add(this.textBox_RF_AntPort_InvCnter4);
            this.groupBox_RF_Ant_Port.Controls.Add(this.comboBoxRF_AntPort_Port4);
            this.groupBox_RF_Ant_Port.Controls.Add(this.textBox_RF_AntPort_InvCnter11);
            this.groupBox_RF_Ant_Port.Controls.Add(this.comboBoxRF_AntPort_Port11);
            this.groupBox_RF_Ant_Port.Controls.Add(this.textBox_RF_AntPort_InvCnter3);
            this.groupBox_RF_Ant_Port.Controls.Add(this.comboBoxRF_AntPort_Port3);
            this.groupBox_RF_Ant_Port.Controls.Add(this.textBox_RF_AntPort_InvCnter10);
            this.groupBox_RF_Ant_Port.Controls.Add(this.comboBoxRF_AntPort_Port10);
            this.groupBox_RF_Ant_Port.Controls.Add(this.textBox_RF_AntPort_InvCnter2);
            this.groupBox_RF_Ant_Port.Controls.Add(this.comboBoxRF_AntPort_Port2);
            this.groupBox_RF_Ant_Port.Controls.Add(this.textBox_RF_AntPort_InvCnter9);
            this.groupBox_RF_Ant_Port.Controls.Add(this.comboBoxRF_AntPort_Port9);
            this.groupBox_RF_Ant_Port.Controls.Add(this.textBox_RF_AntPort_InvCnter1);
            this.groupBox_RF_Ant_Port.Controls.Add(this.comboBoxRF_AntPort_Port1);
            this.groupBox_RF_Ant_Port.Location = new System.Drawing.Point(6, 46);
            this.groupBox_RF_Ant_Port.Name = "groupBox_RF_Ant_Port";
            this.groupBox_RF_Ant_Port.Size = new System.Drawing.Size(376, 514);
            this.groupBox_RF_Ant_Port.TabIndex = 0;
            this.groupBox_RF_Ant_Port.TabStop = false;
            this.groupBox_RF_Ant_Port.Text = "Port";
            // 
            // button_RF_Ant_SetAllParameter
            // 
            this.button_RF_Ant_SetAllParameter.Location = new System.Drawing.Point(162, 477);
            this.button_RF_Ant_SetAllParameter.Name = "button_RF_Ant_SetAllParameter";
            this.button_RF_Ant_SetAllParameter.Size = new System.Drawing.Size(127, 28);
            this.button_RF_Ant_SetAllParameter.TabIndex = 31;
            this.button_RF_Ant_SetAllParameter.Text = "Set All Parameter";
            this.button_RF_Ant_SetAllParameter.UseVisualStyleBackColor = true;
            this.button_RF_Ant_SetAllParameter.Click += new System.EventHandler(this.button_RF_Ant_SetAllParameter_Click);
            // 
            // btn_AntAutoPolling_ParametersHelp
            // 
            this.btn_AntAutoPolling_ParametersHelp.Location = new System.Drawing.Point(266, 41);
            this.btn_AntAutoPolling_ParametersHelp.Name = "btn_AntAutoPolling_ParametersHelp";
            this.btn_AntAutoPolling_ParametersHelp.Size = new System.Drawing.Size(17, 22);
            this.btn_AntAutoPolling_ParametersHelp.TabIndex = 30;
            this.btn_AntAutoPolling_ParametersHelp.Text = "?";
            this.btn_AntAutoPolling_ParametersHelp.UseVisualStyleBackColor = true;
            this.btn_AntAutoPolling_ParametersHelp.Click += new System.EventHandler(this.btn_AntAutoPolling_ParametersHelp_Click);
            // 
            // groupBox_RF_Ant_Enable
            // 
            this.groupBox_RF_Ant_Enable.Controls.Add(this.checkBox_RF_Ant_Enable16);
            this.groupBox_RF_Ant_Enable.Controls.Add(this.checkBox_RF_Ant_Enable15);
            this.groupBox_RF_Ant_Enable.Controls.Add(this.checkBox_RF_Ant_Enable8);
            this.groupBox_RF_Ant_Enable.Controls.Add(this.checkBox_RF_Ant_Enable14);
            this.groupBox_RF_Ant_Enable.Controls.Add(this.checkBox_RF_Ant_Enable7);
            this.groupBox_RF_Ant_Enable.Controls.Add(this.checkBox_RF_Ant_Enable13);
            this.groupBox_RF_Ant_Enable.Controls.Add(this.checkBox_RF_Ant_Enable6);
            this.groupBox_RF_Ant_Enable.Controls.Add(this.checkBox_RF_Ant_Enable12);
            this.groupBox_RF_Ant_Enable.Controls.Add(this.checkBox_RF_Ant_Enable5);
            this.groupBox_RF_Ant_Enable.Controls.Add(this.checkBox_RF_Ant_Enable11);
            this.groupBox_RF_Ant_Enable.Controls.Add(this.checkBox_RF_Ant_Enable4);
            this.groupBox_RF_Ant_Enable.Controls.Add(this.checkBox_RF_Ant_Enable9);
            this.groupBox_RF_Ant_Enable.Controls.Add(this.checkBox_RF_Ant_Enable10);
            this.groupBox_RF_Ant_Enable.Controls.Add(this.checkBox_RF_Ant_Enable3);
            this.groupBox_RF_Ant_Enable.Controls.Add(this.checkBox_RF_Ant_Enable2);
            this.groupBox_RF_Ant_Enable.Controls.Add(this.checkBox_RF_Ant_Enable1);
            this.groupBox_RF_Ant_Enable.Location = new System.Drawing.Point(8, 21);
            this.groupBox_RF_Ant_Enable.Name = "groupBox_RF_Ant_Enable";
            this.groupBox_RF_Ant_Enable.Size = new System.Drawing.Size(80, 450);
            this.groupBox_RF_Ant_Enable.TabIndex = 27;
            this.groupBox_RF_Ant_Enable.TabStop = false;
            this.groupBox_RF_Ant_Enable.Text = "Enable";
            // 
            // checkBox_RF_Ant_Enable16
            // 
            this.checkBox_RF_Ant_Enable16.AutoSize = true;
            this.checkBox_RF_Ant_Enable16.Enabled = false;
            this.checkBox_RF_Ant_Enable16.Location = new System.Drawing.Point(19, 419);
            this.checkBox_RF_Ant_Enable16.Name = "checkBox_RF_Ant_Enable16";
            this.checkBox_RF_Ant_Enable16.Size = new System.Drawing.Size(63, 19);
            this.checkBox_RF_Ant_Enable16.TabIndex = 34;
            this.checkBox_RF_Ant_Enable16.Text = "ANT16";
            this.checkBox_RF_Ant_Enable16.UseVisualStyleBackColor = true;
            // 
            // checkBox_RF_Ant_Enable15
            // 
            this.checkBox_RF_Ant_Enable15.AutoSize = true;
            this.checkBox_RF_Ant_Enable15.Enabled = false;
            this.checkBox_RF_Ant_Enable15.Location = new System.Drawing.Point(19, 394);
            this.checkBox_RF_Ant_Enable15.Name = "checkBox_RF_Ant_Enable15";
            this.checkBox_RF_Ant_Enable15.Size = new System.Drawing.Size(63, 19);
            this.checkBox_RF_Ant_Enable15.TabIndex = 33;
            this.checkBox_RF_Ant_Enable15.Text = "ANT15";
            this.checkBox_RF_Ant_Enable15.UseVisualStyleBackColor = true;
            // 
            // checkBox_RF_Ant_Enable14
            // 
            this.checkBox_RF_Ant_Enable14.AutoSize = true;
            this.checkBox_RF_Ant_Enable14.Enabled = false;
            this.checkBox_RF_Ant_Enable14.Location = new System.Drawing.Point(19, 367);
            this.checkBox_RF_Ant_Enable14.Name = "checkBox_RF_Ant_Enable14";
            this.checkBox_RF_Ant_Enable14.Size = new System.Drawing.Size(63, 19);
            this.checkBox_RF_Ant_Enable14.TabIndex = 32;
            this.checkBox_RF_Ant_Enable14.Text = "ANT14";
            this.checkBox_RF_Ant_Enable14.UseVisualStyleBackColor = true;
            // 
            // checkBox_RF_Ant_Enable13
            // 
            this.checkBox_RF_Ant_Enable13.AutoSize = true;
            this.checkBox_RF_Ant_Enable13.Enabled = false;
            this.checkBox_RF_Ant_Enable13.Location = new System.Drawing.Point(19, 340);
            this.checkBox_RF_Ant_Enable13.Name = "checkBox_RF_Ant_Enable13";
            this.checkBox_RF_Ant_Enable13.Size = new System.Drawing.Size(63, 19);
            this.checkBox_RF_Ant_Enable13.TabIndex = 31;
            this.checkBox_RF_Ant_Enable13.Text = "ANT13";
            this.checkBox_RF_Ant_Enable13.UseVisualStyleBackColor = true;
            // 
            // checkBox_RF_Ant_Enable12
            // 
            this.checkBox_RF_Ant_Enable12.AutoSize = true;
            this.checkBox_RF_Ant_Enable12.Enabled = false;
            this.checkBox_RF_Ant_Enable12.Location = new System.Drawing.Point(19, 314);
            this.checkBox_RF_Ant_Enable12.Name = "checkBox_RF_Ant_Enable12";
            this.checkBox_RF_Ant_Enable12.Size = new System.Drawing.Size(63, 19);
            this.checkBox_RF_Ant_Enable12.TabIndex = 30;
            this.checkBox_RF_Ant_Enable12.Text = "ANT12";
            this.checkBox_RF_Ant_Enable12.UseVisualStyleBackColor = true;
            // 
            // checkBox_RF_Ant_Enable11
            // 
            this.checkBox_RF_Ant_Enable11.AutoSize = true;
            this.checkBox_RF_Ant_Enable11.Enabled = false;
            this.checkBox_RF_Ant_Enable11.Location = new System.Drawing.Point(19, 286);
            this.checkBox_RF_Ant_Enable11.Name = "checkBox_RF_Ant_Enable11";
            this.checkBox_RF_Ant_Enable11.Size = new System.Drawing.Size(62, 19);
            this.checkBox_RF_Ant_Enable11.TabIndex = 29;
            this.checkBox_RF_Ant_Enable11.Text = "ANT11";
            this.checkBox_RF_Ant_Enable11.UseVisualStyleBackColor = true;
            // 
            // checkBox_RF_Ant_Enable9
            // 
            this.checkBox_RF_Ant_Enable9.AutoSize = true;
            this.checkBox_RF_Ant_Enable9.Enabled = false;
            this.checkBox_RF_Ant_Enable9.Location = new System.Drawing.Point(19, 232);
            this.checkBox_RF_Ant_Enable9.Name = "checkBox_RF_Ant_Enable9";
            this.checkBox_RF_Ant_Enable9.Size = new System.Drawing.Size(56, 19);
            this.checkBox_RF_Ant_Enable9.TabIndex = 28;
            this.checkBox_RF_Ant_Enable9.Text = "ANT9";
            this.checkBox_RF_Ant_Enable9.UseVisualStyleBackColor = true;
            // 
            // checkBox_RF_Ant_Enable10
            // 
            this.checkBox_RF_Ant_Enable10.AutoSize = true;
            this.checkBox_RF_Ant_Enable10.Enabled = false;
            this.checkBox_RF_Ant_Enable10.Location = new System.Drawing.Point(19, 259);
            this.checkBox_RF_Ant_Enable10.Name = "checkBox_RF_Ant_Enable10";
            this.checkBox_RF_Ant_Enable10.Size = new System.Drawing.Size(63, 19);
            this.checkBox_RF_Ant_Enable10.TabIndex = 28;
            this.checkBox_RF_Ant_Enable10.Text = "ANT10";
            this.checkBox_RF_Ant_Enable10.UseVisualStyleBackColor = true;
            // 
            // groupBox_RF_Ant_SwitchAnt
            // 
            this.groupBox_RF_Ant_SwitchAnt.Controls.Add(this.radioButton_AntPort12);
            this.groupBox_RF_Ant_SwitchAnt.Controls.Add(this.radioButton_AntPort7);
            this.groupBox_RF_Ant_SwitchAnt.Controls.Add(this.radioButton_AntPort6);
            this.groupBox_RF_Ant_SwitchAnt.Controls.Add(this.radioButton_AntPort5);
            this.groupBox_RF_Ant_SwitchAnt.Controls.Add(this.radioButton_AntPort4);
            this.groupBox_RF_Ant_SwitchAnt.Controls.Add(this.radioButton_AntPort3);
            this.groupBox_RF_Ant_SwitchAnt.Controls.Add(this.radioButton_AntPort2);
            this.groupBox_RF_Ant_SwitchAnt.Controls.Add(this.radioButton_AntPort1);
            this.groupBox_RF_Ant_SwitchAnt.Controls.Add(this.radioButton_AntPort16);
            this.groupBox_RF_Ant_SwitchAnt.Controls.Add(this.radioButton_AntPort15);
            this.groupBox_RF_Ant_SwitchAnt.Controls.Add(this.radioButton_AntPort11);
            this.groupBox_RF_Ant_SwitchAnt.Controls.Add(this.radioButton_AntPort14);
            this.groupBox_RF_Ant_SwitchAnt.Controls.Add(this.radioButton_AntPort10);
            this.groupBox_RF_Ant_SwitchAnt.Controls.Add(this.radioButton_AntPort13);
            this.groupBox_RF_Ant_SwitchAnt.Controls.Add(this.radioButton_AntPort9);
            this.groupBox_RF_Ant_SwitchAnt.Controls.Add(this.radioButton_AntPort8);
            this.groupBox_RF_Ant_SwitchAnt.Location = new System.Drawing.Point(94, 21);
            this.groupBox_RF_Ant_SwitchAnt.Name = "groupBox_RF_Ant_SwitchAnt";
            this.groupBox_RF_Ant_SwitchAnt.Size = new System.Drawing.Size(85, 449);
            this.groupBox_RF_Ant_SwitchAnt.TabIndex = 26;
            this.groupBox_RF_Ant_SwitchAnt.TabStop = false;
            this.groupBox_RF_Ant_SwitchAnt.Text = "Switch";
            // 
            // radioButton_AntPort12
            // 
            this.radioButton_AntPort12.AutoSize = true;
            this.radioButton_AntPort12.Enabled = false;
            this.radioButton_AntPort12.Location = new System.Drawing.Point(19, 312);
            this.radioButton_AntPort12.Name = "radioButton_AntPort12";
            this.radioButton_AntPort12.Size = new System.Drawing.Size(62, 19);
            this.radioButton_AntPort12.TabIndex = 6;
            this.radioButton_AntPort12.TabStop = true;
            this.radioButton_AntPort12.Text = "ANT12";
            this.radioButton_AntPort12.UseVisualStyleBackColor = true;
            this.radioButton_AntPort12.Click += new System.EventHandler(this.radioButton_AntPort7_Click);
            // 
            // radioButton_AntPort16
            // 
            this.radioButton_AntPort16.AutoSize = true;
            this.radioButton_AntPort16.Enabled = false;
            this.radioButton_AntPort16.Location = new System.Drawing.Point(18, 418);
            this.radioButton_AntPort16.Name = "radioButton_AntPort16";
            this.radioButton_AntPort16.Size = new System.Drawing.Size(62, 19);
            this.radioButton_AntPort16.TabIndex = 7;
            this.radioButton_AntPort16.TabStop = true;
            this.radioButton_AntPort16.Text = "ANT16";
            this.radioButton_AntPort16.UseVisualStyleBackColor = true;
            this.radioButton_AntPort16.Click += new System.EventHandler(this.radioButton_AntPort8_Click);
            // 
            // radioButton_AntPort15
            // 
            this.radioButton_AntPort15.AutoSize = true;
            this.radioButton_AntPort15.Enabled = false;
            this.radioButton_AntPort15.Location = new System.Drawing.Point(19, 391);
            this.radioButton_AntPort15.Name = "radioButton_AntPort15";
            this.radioButton_AntPort15.Size = new System.Drawing.Size(62, 19);
            this.radioButton_AntPort15.TabIndex = 7;
            this.radioButton_AntPort15.TabStop = true;
            this.radioButton_AntPort15.Text = "ANT15";
            this.radioButton_AntPort15.UseVisualStyleBackColor = true;
            this.radioButton_AntPort15.Click += new System.EventHandler(this.radioButton_AntPort8_Click);
            // 
            // radioButton_AntPort11
            // 
            this.radioButton_AntPort11.AutoSize = true;
            this.radioButton_AntPort11.Enabled = false;
            this.radioButton_AntPort11.Location = new System.Drawing.Point(18, 286);
            this.radioButton_AntPort11.Name = "radioButton_AntPort11";
            this.radioButton_AntPort11.Size = new System.Drawing.Size(61, 19);
            this.radioButton_AntPort11.TabIndex = 7;
            this.radioButton_AntPort11.TabStop = true;
            this.radioButton_AntPort11.Text = "ANT11";
            this.radioButton_AntPort11.UseVisualStyleBackColor = true;
            this.radioButton_AntPort11.Click += new System.EventHandler(this.radioButton_AntPort8_Click);
            // 
            // radioButton_AntPort14
            // 
            this.radioButton_AntPort14.AutoSize = true;
            this.radioButton_AntPort14.Enabled = false;
            this.radioButton_AntPort14.Location = new System.Drawing.Point(19, 365);
            this.radioButton_AntPort14.Name = "radioButton_AntPort14";
            this.radioButton_AntPort14.Size = new System.Drawing.Size(62, 19);
            this.radioButton_AntPort14.TabIndex = 7;
            this.radioButton_AntPort14.TabStop = true;
            this.radioButton_AntPort14.Text = "ANT14";
            this.radioButton_AntPort14.UseVisualStyleBackColor = true;
            this.radioButton_AntPort14.Click += new System.EventHandler(this.radioButton_AntPort8_Click);
            // 
            // radioButton_AntPort10
            // 
            this.radioButton_AntPort10.AutoSize = true;
            this.radioButton_AntPort10.Enabled = false;
            this.radioButton_AntPort10.Location = new System.Drawing.Point(18, 259);
            this.radioButton_AntPort10.Name = "radioButton_AntPort10";
            this.radioButton_AntPort10.Size = new System.Drawing.Size(62, 19);
            this.radioButton_AntPort10.TabIndex = 7;
            this.radioButton_AntPort10.TabStop = true;
            this.radioButton_AntPort10.Text = "ANT10";
            this.radioButton_AntPort10.UseVisualStyleBackColor = true;
            this.radioButton_AntPort10.Click += new System.EventHandler(this.radioButton_AntPort8_Click);
            // 
            // radioButton_AntPort13
            // 
            this.radioButton_AntPort13.AutoSize = true;
            this.radioButton_AntPort13.Enabled = false;
            this.radioButton_AntPort13.Location = new System.Drawing.Point(19, 338);
            this.radioButton_AntPort13.Name = "radioButton_AntPort13";
            this.radioButton_AntPort13.Size = new System.Drawing.Size(62, 19);
            this.radioButton_AntPort13.TabIndex = 7;
            this.radioButton_AntPort13.TabStop = true;
            this.radioButton_AntPort13.Text = "ANT13";
            this.radioButton_AntPort13.UseVisualStyleBackColor = true;
            this.radioButton_AntPort13.Click += new System.EventHandler(this.radioButton_AntPort8_Click);
            // 
            // radioButton_AntPort9
            // 
            this.radioButton_AntPort9.AutoSize = true;
            this.radioButton_AntPort9.Enabled = false;
            this.radioButton_AntPort9.Location = new System.Drawing.Point(18, 233);
            this.radioButton_AntPort9.Name = "radioButton_AntPort9";
            this.radioButton_AntPort9.Size = new System.Drawing.Size(55, 19);
            this.radioButton_AntPort9.TabIndex = 7;
            this.radioButton_AntPort9.TabStop = true;
            this.radioButton_AntPort9.Text = "ANT9";
            this.radioButton_AntPort9.UseVisualStyleBackColor = true;
            this.radioButton_AntPort9.Click += new System.EventHandler(this.radioButton_AntPort8_Click);
            // 
            // label_RF_AntPort_InvCnter
            // 
            this.label_RF_AntPort_InvCnter.AutoSize = true;
            this.label_RF_AntPort_InvCnter.Location = new System.Drawing.Point(275, 21);
            this.label_RF_AntPort_InvCnter.Name = "label_RF_AntPort_InvCnter";
            this.label_RF_AntPort_InvCnter.Size = new System.Drawing.Size(95, 15);
            this.label_RF_AntPort_InvCnter.TabIndex = 25;
            this.label_RF_AntPort_InvCnter.Text = "Inventory Count";
            // 
            // label_RF_AntPort_Power
            // 
            this.label_RF_AntPort_Power.AutoSize = true;
            this.label_RF_AntPort_Power.Location = new System.Drawing.Point(182, 21);
            this.label_RF_AntPort_Power.Name = "label_RF_AntPort_Power";
            this.label_RF_AntPort_Power.Size = new System.Drawing.Size(85, 15);
            this.label_RF_AntPort_Power.TabIndex = 24;
            this.label_RF_AntPort_Power.Text = "Polling Power";
            // 
            // textBox_RF_AntPort_InvCnter16
            // 
            this.textBox_RF_AntPort_InvCnter16.Enabled = false;
            this.textBox_RF_AntPort_InvCnter16.Location = new System.Drawing.Point(287, 435);
            this.textBox_RF_AntPort_InvCnter16.Name = "textBox_RF_AntPort_InvCnter16";
            this.textBox_RF_AntPort_InvCnter16.Size = new System.Drawing.Size(71, 21);
            this.textBox_RF_AntPort_InvCnter16.TabIndex = 23;
            this.textBox_RF_AntPort_InvCnter16.Text = "5";
            // 
            // comboBoxRF_AntPort_Port16
            // 
            this.comboBoxRF_AntPort_Port16.Enabled = false;
            this.comboBoxRF_AntPort_Port16.FormattingEnabled = true;
            this.comboBoxRF_AntPort_Port16.Items.AddRange(new object[] {
            "33dBm",
            "32dBm",
            "31dBm",
            "30dBm",
            "29dBm",
            "28dBm",
            "27dBm",
            "26dBm",
            "25dBm",
            "24dBm",
            "23dBm",
            "22dBm",
            "21dBm",
            "20dBm",
            "19dBm",
            "18dBm",
            "17dBm",
            "16dBm",
            "15dBm",
            "14dBm",
            "13dBm",
            "12dBm",
            "11dBm",
            "10dBm",
            "09dBm",
            "08dBm",
            "07dBm",
            "06dBm",
            "05dBm",
            "04dBm",
            "03dBm",
            "02dBm",
            "01dBm",
            "00dBm"});
            this.comboBoxRF_AntPort_Port16.Location = new System.Drawing.Point(185, 435);
            this.comboBoxRF_AntPort_Port16.Name = "comboBoxRF_AntPort_Port16";
            this.comboBoxRF_AntPort_Port16.Size = new System.Drawing.Size(71, 23);
            this.comboBoxRF_AntPort_Port16.TabIndex = 22;
            // 
            // comboBoxRF_AntPort_Port15
            // 
            this.comboBoxRF_AntPort_Port15.Enabled = false;
            this.comboBoxRF_AntPort_Port15.FormattingEnabled = true;
            this.comboBoxRF_AntPort_Port15.Items.AddRange(new object[] {
            "33dBm",
            "32dBm",
            "31dBm",
            "30dBm",
            "29dBm",
            "28dBm",
            "27dBm",
            "26dBm",
            "25dBm",
            "24dBm",
            "23dBm",
            "22dBm",
            "21dBm",
            "20dBm",
            "19dBm",
            "18dBm",
            "17dBm",
            "16dBm",
            "15dBm",
            "14dBm",
            "13dBm",
            "12dBm",
            "11dBm",
            "10dBm",
            "09dBm",
            "08dBm",
            "07dBm",
            "06dBm",
            "05dBm",
            "04dBm",
            "03dBm",
            "02dBm",
            "01dBm",
            "00dBm"});
            this.comboBoxRF_AntPort_Port15.Location = new System.Drawing.Point(186, 409);
            this.comboBoxRF_AntPort_Port15.Name = "comboBoxRF_AntPort_Port15";
            this.comboBoxRF_AntPort_Port15.Size = new System.Drawing.Size(71, 23);
            this.comboBoxRF_AntPort_Port15.TabIndex = 20;
            // 
            // textBox_RF_AntPort_InvCnter15
            // 
            this.textBox_RF_AntPort_InvCnter15.Enabled = false;
            this.textBox_RF_AntPort_InvCnter15.Location = new System.Drawing.Point(287, 409);
            this.textBox_RF_AntPort_InvCnter15.Name = "textBox_RF_AntPort_InvCnter15";
            this.textBox_RF_AntPort_InvCnter15.Size = new System.Drawing.Size(71, 21);
            this.textBox_RF_AntPort_InvCnter15.TabIndex = 21;
            this.textBox_RF_AntPort_InvCnter15.Text = "5";
            // 
            // textBox_RF_AntPort_InvCnter14
            // 
            this.textBox_RF_AntPort_InvCnter14.Enabled = false;
            this.textBox_RF_AntPort_InvCnter14.Location = new System.Drawing.Point(287, 382);
            this.textBox_RF_AntPort_InvCnter14.Name = "textBox_RF_AntPort_InvCnter14";
            this.textBox_RF_AntPort_InvCnter14.Size = new System.Drawing.Size(71, 21);
            this.textBox_RF_AntPort_InvCnter14.TabIndex = 19;
            this.textBox_RF_AntPort_InvCnter14.Text = "5";
            // 
            // comboBoxRF_AntPort_Port14
            // 
            this.comboBoxRF_AntPort_Port14.Enabled = false;
            this.comboBoxRF_AntPort_Port14.FormattingEnabled = true;
            this.comboBoxRF_AntPort_Port14.Items.AddRange(new object[] {
            "33dBm",
            "32dBm",
            "31dBm",
            "30dBm",
            "29dBm",
            "28dBm",
            "27dBm",
            "26dBm",
            "25dBm",
            "24dBm",
            "23dBm",
            "22dBm",
            "21dBm",
            "20dBm",
            "19dBm",
            "18dBm",
            "17dBm",
            "16dBm",
            "15dBm",
            "14dBm",
            "13dBm",
            "12dBm",
            "11dBm",
            "10dBm",
            "09dBm",
            "08dBm",
            "07dBm",
            "06dBm",
            "05dBm",
            "04dBm",
            "03dBm",
            "02dBm",
            "01dBm",
            "00dBm"});
            this.comboBoxRF_AntPort_Port14.Location = new System.Drawing.Point(186, 382);
            this.comboBoxRF_AntPort_Port14.Name = "comboBoxRF_AntPort_Port14";
            this.comboBoxRF_AntPort_Port14.Size = new System.Drawing.Size(71, 23);
            this.comboBoxRF_AntPort_Port14.TabIndex = 18;
            // 
            // textBox_RF_AntPort_InvCnter13
            // 
            this.textBox_RF_AntPort_InvCnter13.Enabled = false;
            this.textBox_RF_AntPort_InvCnter13.Location = new System.Drawing.Point(287, 356);
            this.textBox_RF_AntPort_InvCnter13.Name = "textBox_RF_AntPort_InvCnter13";
            this.textBox_RF_AntPort_InvCnter13.Size = new System.Drawing.Size(71, 21);
            this.textBox_RF_AntPort_InvCnter13.TabIndex = 17;
            this.textBox_RF_AntPort_InvCnter13.Text = "5";
            // 
            // comboBoxRF_AntPort_Port13
            // 
            this.comboBoxRF_AntPort_Port13.Enabled = false;
            this.comboBoxRF_AntPort_Port13.FormattingEnabled = true;
            this.comboBoxRF_AntPort_Port13.Items.AddRange(new object[] {
            "33dBm",
            "32dBm",
            "31dBm",
            "30dBm",
            "29dBm",
            "28dBm",
            "27dBm",
            "26dBm",
            "25dBm",
            "24dBm",
            "23dBm",
            "22dBm",
            "21dBm",
            "20dBm",
            "19dBm",
            "18dBm",
            "17dBm",
            "16dBm",
            "15dBm",
            "14dBm",
            "13dBm",
            "12dBm",
            "11dBm",
            "10dBm",
            "09dBm",
            "08dBm",
            "07dBm",
            "06dBm",
            "05dBm",
            "04dBm",
            "03dBm",
            "02dBm",
            "01dBm",
            "00dBm"});
            this.comboBoxRF_AntPort_Port13.Location = new System.Drawing.Point(186, 356);
            this.comboBoxRF_AntPort_Port13.Name = "comboBoxRF_AntPort_Port13";
            this.comboBoxRF_AntPort_Port13.Size = new System.Drawing.Size(71, 23);
            this.comboBoxRF_AntPort_Port13.TabIndex = 16;
            // 
            // textBox_RF_AntPort_InvCnter12
            // 
            this.textBox_RF_AntPort_InvCnter12.Enabled = false;
            this.textBox_RF_AntPort_InvCnter12.Location = new System.Drawing.Point(287, 330);
            this.textBox_RF_AntPort_InvCnter12.Name = "textBox_RF_AntPort_InvCnter12";
            this.textBox_RF_AntPort_InvCnter12.Size = new System.Drawing.Size(71, 21);
            this.textBox_RF_AntPort_InvCnter12.TabIndex = 15;
            this.textBox_RF_AntPort_InvCnter12.Text = "5";
            // 
            // comboBoxRF_AntPort_Port12
            // 
            this.comboBoxRF_AntPort_Port12.Enabled = false;
            this.comboBoxRF_AntPort_Port12.FormattingEnabled = true;
            this.comboBoxRF_AntPort_Port12.Items.AddRange(new object[] {
            "33dBm",
            "32dBm",
            "31dBm",
            "30dBm",
            "29dBm",
            "28dBm",
            "27dBm",
            "26dBm",
            "25dBm",
            "24dBm",
            "23dBm",
            "22dBm",
            "21dBm",
            "20dBm",
            "19dBm",
            "18dBm",
            "17dBm",
            "16dBm",
            "15dBm",
            "14dBm",
            "13dBm",
            "12dBm",
            "11dBm",
            "10dBm",
            "09dBm",
            "08dBm",
            "07dBm",
            "06dBm",
            "05dBm",
            "04dBm",
            "03dBm",
            "02dBm",
            "01dBm",
            "00dBm"});
            this.comboBoxRF_AntPort_Port12.Location = new System.Drawing.Point(186, 330);
            this.comboBoxRF_AntPort_Port12.Name = "comboBoxRF_AntPort_Port12";
            this.comboBoxRF_AntPort_Port12.Size = new System.Drawing.Size(71, 23);
            this.comboBoxRF_AntPort_Port12.TabIndex = 14;
            // 
            // textBox_RF_AntPort_InvCnter11
            // 
            this.textBox_RF_AntPort_InvCnter11.Enabled = false;
            this.textBox_RF_AntPort_InvCnter11.Location = new System.Drawing.Point(287, 303);
            this.textBox_RF_AntPort_InvCnter11.Name = "textBox_RF_AntPort_InvCnter11";
            this.textBox_RF_AntPort_InvCnter11.Size = new System.Drawing.Size(71, 21);
            this.textBox_RF_AntPort_InvCnter11.TabIndex = 13;
            this.textBox_RF_AntPort_InvCnter11.Text = "5";
            // 
            // comboBoxRF_AntPort_Port11
            // 
            this.comboBoxRF_AntPort_Port11.Enabled = false;
            this.comboBoxRF_AntPort_Port11.FormattingEnabled = true;
            this.comboBoxRF_AntPort_Port11.Items.AddRange(new object[] {
            "33dBm",
            "32dBm",
            "31dBm",
            "30dBm",
            "29dBm",
            "28dBm",
            "27dBm",
            "26dBm",
            "25dBm",
            "24dBm",
            "23dBm",
            "22dBm",
            "21dBm",
            "20dBm",
            "19dBm",
            "18dBm",
            "17dBm",
            "16dBm",
            "15dBm",
            "14dBm",
            "13dBm",
            "12dBm",
            "11dBm",
            "10dBm",
            "09dBm",
            "08dBm",
            "07dBm",
            "06dBm",
            "05dBm",
            "04dBm",
            "03dBm",
            "02dBm",
            "01dBm",
            "00dBm"});
            this.comboBoxRF_AntPort_Port11.Location = new System.Drawing.Point(186, 303);
            this.comboBoxRF_AntPort_Port11.Name = "comboBoxRF_AntPort_Port11";
            this.comboBoxRF_AntPort_Port11.Size = new System.Drawing.Size(71, 23);
            this.comboBoxRF_AntPort_Port11.TabIndex = 12;
            // 
            // textBox_RF_AntPort_InvCnter10
            // 
            this.textBox_RF_AntPort_InvCnter10.Enabled = false;
            this.textBox_RF_AntPort_InvCnter10.Location = new System.Drawing.Point(287, 277);
            this.textBox_RF_AntPort_InvCnter10.Name = "textBox_RF_AntPort_InvCnter10";
            this.textBox_RF_AntPort_InvCnter10.Size = new System.Drawing.Size(71, 21);
            this.textBox_RF_AntPort_InvCnter10.TabIndex = 11;
            this.textBox_RF_AntPort_InvCnter10.Text = "5";
            // 
            // comboBoxRF_AntPort_Port10
            // 
            this.comboBoxRF_AntPort_Port10.Enabled = false;
            this.comboBoxRF_AntPort_Port10.FormattingEnabled = true;
            this.comboBoxRF_AntPort_Port10.Items.AddRange(new object[] {
            "33dBm",
            "32dBm",
            "31dBm",
            "30dBm",
            "29dBm",
            "28dBm",
            "27dBm",
            "26dBm",
            "25dBm",
            "24dBm",
            "23dBm",
            "22dBm",
            "21dBm",
            "20dBm",
            "19dBm",
            "18dBm",
            "17dBm",
            "16dBm",
            "15dBm",
            "14dBm",
            "13dBm",
            "12dBm",
            "11dBm",
            "10dBm",
            "09dBm",
            "08dBm",
            "07dBm",
            "06dBm",
            "05dBm",
            "04dBm",
            "03dBm",
            "02dBm",
            "01dBm",
            "00dBm"});
            this.comboBoxRF_AntPort_Port10.Location = new System.Drawing.Point(186, 277);
            this.comboBoxRF_AntPort_Port10.Name = "comboBoxRF_AntPort_Port10";
            this.comboBoxRF_AntPort_Port10.Size = new System.Drawing.Size(71, 23);
            this.comboBoxRF_AntPort_Port10.TabIndex = 10;
            // 
            // textBox_RF_AntPort_InvCnter9
            // 
            this.textBox_RF_AntPort_InvCnter9.Enabled = false;
            this.textBox_RF_AntPort_InvCnter9.Location = new System.Drawing.Point(287, 250);
            this.textBox_RF_AntPort_InvCnter9.Name = "textBox_RF_AntPort_InvCnter9";
            this.textBox_RF_AntPort_InvCnter9.Size = new System.Drawing.Size(71, 21);
            this.textBox_RF_AntPort_InvCnter9.TabIndex = 9;
            this.textBox_RF_AntPort_InvCnter9.Text = "5";
            // 
            // comboBoxRF_AntPort_Port9
            // 
            this.comboBoxRF_AntPort_Port9.Enabled = false;
            this.comboBoxRF_AntPort_Port9.FormattingEnabled = true;
            this.comboBoxRF_AntPort_Port9.Items.AddRange(new object[] {
            "33dBm",
            "32dBm",
            "31dBm",
            "30dBm",
            "29dBm",
            "28dBm",
            "27dBm",
            "26dBm",
            "25dBm",
            "24dBm",
            "23dBm",
            "22dBm",
            "21dBm",
            "20dBm",
            "19dBm",
            "18dBm",
            "17dBm",
            "16dBm",
            "15dBm",
            "14dBm",
            "13dBm",
            "12dBm",
            "11dBm",
            "10dBm",
            "09dBm",
            "08dBm",
            "07dBm",
            "06dBm",
            "05dBm",
            "04dBm",
            "03dBm",
            "02dBm",
            "01dBm",
            "00dBm"});
            this.comboBoxRF_AntPort_Port9.Location = new System.Drawing.Point(186, 250);
            this.comboBoxRF_AntPort_Port9.Name = "comboBoxRF_AntPort_Port9";
            this.comboBoxRF_AntPort_Port9.Size = new System.Drawing.Size(71, 23);
            this.comboBoxRF_AntPort_Port9.TabIndex = 8;
            // 
            // ExtCommand
            // 
            this.ExtCommand.BackColor = System.Drawing.SystemColors.Control;
            this.ExtCommand.Controls.Add(this.BeepModeComboBox);
            this.ExtCommand.Controls.Add(this.label64);
            this.ExtCommand.Controls.Add(this.BtnGetReaderWorkMode);
            this.ExtCommand.Controls.Add(this.BtnSetReaderWorkMode);
            this.ExtCommand.Controls.Add(this.groupBox5);
            this.ExtCommand.Controls.Add(this.BtnGetBeepStatus);
            this.ExtCommand.Controls.Add(this.BtnSetBeepMode);
            this.ExtCommand.Controls.Add(this.ReaderWorkModeComboBox);
            this.ExtCommand.Controls.Add(this.BtnSettingDefaultWorkParam);
            this.ExtCommand.Controls.Add(this.label58);
            this.ExtCommand.Location = new System.Drawing.Point(4, 24);
            this.ExtCommand.Name = "ExtCommand";
            this.ExtCommand.Size = new System.Drawing.Size(1066, 638);
            this.ExtCommand.TabIndex = 5;
            this.ExtCommand.Text = "Extended Command";
            // 
            // BeepModeComboBox
            // 
            this.BeepModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BeepModeComboBox.FormattingEnabled = true;
            this.BeepModeComboBox.Items.AddRange(new object[] {
            "0x00 Beep off",
            "0x01 Beep on"});
            this.BeepModeComboBox.Location = new System.Drawing.Point(863, 236);
            this.BeepModeComboBox.Name = "BeepModeComboBox";
            this.BeepModeComboBox.Size = new System.Drawing.Size(108, 23);
            this.BeepModeComboBox.TabIndex = 22;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(781, 239);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(70, 15);
            this.label64.TabIndex = 19;
            this.label64.Text = "Beep Mode";
            // 
            // BtnGetReaderWorkMode
            // 
            this.BtnGetReaderWorkMode.Location = new System.Drawing.Point(863, 99);
            this.BtnGetReaderWorkMode.Name = "BtnGetReaderWorkMode";
            this.BtnGetReaderWorkMode.Size = new System.Drawing.Size(155, 44);
            this.BtnGetReaderWorkMode.TabIndex = 14;
            this.BtnGetReaderWorkMode.Text = "Get Reader Work Mode";
            this.BtnGetReaderWorkMode.UseVisualStyleBackColor = true;
            this.BtnGetReaderWorkMode.Click += new System.EventHandler(this.BtnGetReaderWorkMode_Click);
            // 
            // BtnSetReaderWorkMode
            // 
            this.BtnSetReaderWorkMode.Location = new System.Drawing.Point(709, 99);
            this.BtnSetReaderWorkMode.Name = "BtnSetReaderWorkMode";
            this.BtnSetReaderWorkMode.Size = new System.Drawing.Size(151, 44);
            this.BtnSetReaderWorkMode.TabIndex = 14;
            this.BtnSetReaderWorkMode.Text = "Set Reader Work Mode";
            this.BtnSetReaderWorkMode.UseVisualStyleBackColor = true;
            this.BtnSetReaderWorkMode.Click += new System.EventHandler(this.BtnSetReaderWorkMode_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.BtnFillTagData);
            this.groupBox5.Controls.Add(this.groupBox12);
            this.groupBox5.Controls.Add(this.Btn_Set_EnableModeOff);
            this.groupBox5.Controls.Add(this.Btn_Set_EnableModeOn);
            this.groupBox5.Controls.Add(this.MatchedNumberComboBox);
            this.groupBox5.Controls.Add(this.MatchedModeComboBox);
            this.groupBox5.Controls.Add(this.label56);
            this.groupBox5.Controls.Add(this.label55);
            this.groupBox5.Controls.Add(this.Btn_Get_EnableMode21);
            this.groupBox5.Controls.Add(this.Btn_Get_Mode11);
            this.groupBox5.Controls.Add(this.Btn_Set_Mode00);
            this.groupBox5.Controls.Add(this.groupBox11);
            this.groupBox5.Controls.Add(this.groupBox10);
            this.groupBox5.Controls.Add(this.groupBox9);
            this.groupBox5.Controls.Add(this.groupBox8);
            this.groupBox5.Location = new System.Drawing.Point(8, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(669, 610);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "EPC Head Matched";
            // 
            // BtnFillTagData
            // 
            this.BtnFillTagData.Location = new System.Drawing.Point(77, 573);
            this.BtnFillTagData.Name = "BtnFillTagData";
            this.BtnFillTagData.Size = new System.Drawing.Size(130, 31);
            this.BtnFillTagData.TabIndex = 15;
            this.BtnFillTagData.Text = "Fill Tag Data";
            this.BtnFillTagData.UseVisualStyleBackColor = true;
            this.BtnFillTagData.Click += new System.EventHandler(this.BtnFillTagData_Click);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.label51);
            this.groupBox12.Controls.Add(this.EDIT_TAG_MATCHED_DATA5);
            this.groupBox12.Controls.Add(this.COMBO_TAG_MATCHED_BYTELEN5);
            this.groupBox12.Controls.Add(this.label52);
            this.groupBox12.Location = new System.Drawing.Point(16, 471);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(277, 92);
            this.groupBox12.TabIndex = 1;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Matched Tag Data Output (MSB) Number 5";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(29, 60);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(87, 15);
            this.label51.TabIndex = 30;
            this.label51.Text = "Tag Data(HEX)";
            // 
            // EDIT_TAG_MATCHED_DATA5
            // 
            this.EDIT_TAG_MATCHED_DATA5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EDIT_TAG_MATCHED_DATA5.Location = new System.Drawing.Point(133, 60);
            this.EDIT_TAG_MATCHED_DATA5.Name = "EDIT_TAG_MATCHED_DATA5";
            this.EDIT_TAG_MATCHED_DATA5.Size = new System.Drawing.Size(108, 21);
            this.EDIT_TAG_MATCHED_DATA5.TabIndex = 29;
            this.EDIT_TAG_MATCHED_DATA5.Text = "AABBCCDDEE";
            this.EDIT_TAG_MATCHED_DATA5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // COMBO_TAG_MATCHED_BYTELEN5
            // 
            this.COMBO_TAG_MATCHED_BYTELEN5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMBO_TAG_MATCHED_BYTELEN5.FormattingEnabled = true;
            this.COMBO_TAG_MATCHED_BYTELEN5.Items.AddRange(new object[] {
            "0(Disable)",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.COMBO_TAG_MATCHED_BYTELEN5.Location = new System.Drawing.Point(133, 26);
            this.COMBO_TAG_MATCHED_BYTELEN5.Name = "COMBO_TAG_MATCHED_BYTELEN5";
            this.COMBO_TAG_MATCHED_BYTELEN5.Size = new System.Drawing.Size(108, 23);
            this.COMBO_TAG_MATCHED_BYTELEN5.TabIndex = 13;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(29, 29);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(98, 15);
            this.label52.TabIndex = 12;
            this.label52.Text = "Matched Length";
            // 
            // Btn_Set_EnableModeOff
            // 
            this.Btn_Set_EnableModeOff.Location = new System.Drawing.Point(334, 391);
            this.Btn_Set_EnableModeOff.Name = "Btn_Set_EnableModeOff";
            this.Btn_Set_EnableModeOff.Size = new System.Drawing.Size(315, 44);
            this.Btn_Set_EnableModeOff.TabIndex = 0;
            this.Btn_Set_EnableModeOff.Text = "Set Matched Tag Data Mode Enable On 0x63 0x20 ";
            this.Btn_Set_EnableModeOff.UseVisualStyleBackColor = true;
            this.Btn_Set_EnableModeOff.Click += new System.EventHandler(this.Btn_Set_EnableModeOff_Click);
            // 
            // Btn_Set_EnableModeOn
            // 
            this.Btn_Set_EnableModeOn.Location = new System.Drawing.Point(334, 452);
            this.Btn_Set_EnableModeOn.Name = "Btn_Set_EnableModeOn";
            this.Btn_Set_EnableModeOn.Size = new System.Drawing.Size(315, 44);
            this.Btn_Set_EnableModeOn.TabIndex = 0;
            this.Btn_Set_EnableModeOn.Text = "Set Matched Tag Data Mode Enable Off 0x63 0x20 ";
            this.Btn_Set_EnableModeOn.UseVisualStyleBackColor = true;
            this.Btn_Set_EnableModeOn.Click += new System.EventHandler(this.Btn_Set_EnableModeOn_Click);
            // 
            // MatchedNumberComboBox
            // 
            this.MatchedNumberComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MatchedNumberComboBox.FormattingEnabled = true;
            this.MatchedNumberComboBox.Items.AddRange(new object[] {
            "Number 1",
            "Number 2",
            "Number 3",
            "Number 4",
            "Number 5"});
            this.MatchedNumberComboBox.Location = new System.Drawing.Point(407, 49);
            this.MatchedNumberComboBox.Name = "MatchedNumberComboBox";
            this.MatchedNumberComboBox.Size = new System.Drawing.Size(108, 23);
            this.MatchedNumberComboBox.TabIndex = 13;
            // 
            // MatchedModeComboBox
            // 
            this.MatchedModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MatchedModeComboBox.FormattingEnabled = true;
            this.MatchedModeComboBox.Items.AddRange(new object[] {
            "00 Not save, not Enable",
            "01 Not save,  Enable",
            "02 Save, not Enable",
            "03 Save, Enable"});
            this.MatchedModeComboBox.Location = new System.Drawing.Point(407, 20);
            this.MatchedModeComboBox.Name = "MatchedModeComboBox";
            this.MatchedModeComboBox.Size = new System.Drawing.Size(108, 23);
            this.MatchedModeComboBox.TabIndex = 13;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(299, 52);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(107, 15);
            this.label56.TabIndex = 12;
            this.label56.Text = "Matched Number ";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(299, 23);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(90, 15);
            this.label55.TabIndex = 12;
            this.label55.Text = "Matched Mode";
            // 
            // Btn_Get_EnableMode21
            // 
            this.Btn_Get_EnableMode21.Location = new System.Drawing.Point(334, 515);
            this.Btn_Get_EnableMode21.Name = "Btn_Get_EnableMode21";
            this.Btn_Get_EnableMode21.Size = new System.Drawing.Size(315, 44);
            this.Btn_Get_EnableMode21.TabIndex = 0;
            this.Btn_Get_EnableMode21.Text = "Get Matched Tag Data Mode Enable 0x63 0x21";
            this.Btn_Get_EnableMode21.UseVisualStyleBackColor = true;
            this.Btn_Get_EnableMode21.Click += new System.EventHandler(this.Btn_Get_EnableMode21_Click);
            // 
            // Btn_Get_Mode11
            // 
            this.Btn_Get_Mode11.Location = new System.Drawing.Point(334, 201);
            this.Btn_Get_Mode11.Name = "Btn_Get_Mode11";
            this.Btn_Get_Mode11.Size = new System.Drawing.Size(315, 44);
            this.Btn_Get_Mode11.TabIndex = 0;
            this.Btn_Get_Mode11.Text = "Get Matched Tag Data Mode 0x63 0x11";
            this.Btn_Get_Mode11.UseVisualStyleBackColor = true;
            this.Btn_Get_Mode11.Click += new System.EventHandler(this.Btn_Get_Mode11_Click);
            // 
            // Btn_Set_Mode00
            // 
            this.Btn_Set_Mode00.Location = new System.Drawing.Point(334, 143);
            this.Btn_Set_Mode00.Name = "Btn_Set_Mode00";
            this.Btn_Set_Mode00.Size = new System.Drawing.Size(315, 44);
            this.Btn_Set_Mode00.TabIndex = 0;
            this.Btn_Set_Mode00.Text = "Set Matched Tag Data Mode 0x63 0x0X";
            this.Btn_Set_Mode00.UseVisualStyleBackColor = true;
            this.Btn_Set_Mode00.Click += new System.EventHandler(this.Btn_Set_Mode00_Click);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.label49);
            this.groupBox11.Controls.Add(this.EDIT_TAG_MATCHED_DATA4);
            this.groupBox11.Controls.Add(this.COMBO_TAG_MATCHED_BYTELEN4);
            this.groupBox11.Controls.Add(this.label50);
            this.groupBox11.Location = new System.Drawing.Point(16, 359);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(277, 92);
            this.groupBox11.TabIndex = 1;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Matched Tag Data Output (MSB) Number 4";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(29, 60);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(87, 15);
            this.label49.TabIndex = 30;
            this.label49.Text = "Tag Data(HEX)";
            // 
            // EDIT_TAG_MATCHED_DATA4
            // 
            this.EDIT_TAG_MATCHED_DATA4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EDIT_TAG_MATCHED_DATA4.Location = new System.Drawing.Point(133, 60);
            this.EDIT_TAG_MATCHED_DATA4.Name = "EDIT_TAG_MATCHED_DATA4";
            this.EDIT_TAG_MATCHED_DATA4.Size = new System.Drawing.Size(108, 21);
            this.EDIT_TAG_MATCHED_DATA4.TabIndex = 29;
            this.EDIT_TAG_MATCHED_DATA4.Text = "AABBCCDDEE";
            this.EDIT_TAG_MATCHED_DATA4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // COMBO_TAG_MATCHED_BYTELEN4
            // 
            this.COMBO_TAG_MATCHED_BYTELEN4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMBO_TAG_MATCHED_BYTELEN4.FormattingEnabled = true;
            this.COMBO_TAG_MATCHED_BYTELEN4.Items.AddRange(new object[] {
            "0(Disable)",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.COMBO_TAG_MATCHED_BYTELEN4.Location = new System.Drawing.Point(133, 26);
            this.COMBO_TAG_MATCHED_BYTELEN4.Name = "COMBO_TAG_MATCHED_BYTELEN4";
            this.COMBO_TAG_MATCHED_BYTELEN4.Size = new System.Drawing.Size(108, 23);
            this.COMBO_TAG_MATCHED_BYTELEN4.TabIndex = 13;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(29, 29);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(98, 15);
            this.label50.TabIndex = 12;
            this.label50.Text = "Matched Length";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label41);
            this.groupBox10.Controls.Add(this.EDIT_TAG_MATCHED_DATA3);
            this.groupBox10.Controls.Add(this.COMBO_TAG_MATCHED_BYTELEN3);
            this.groupBox10.Controls.Add(this.label48);
            this.groupBox10.Location = new System.Drawing.Point(16, 247);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(277, 92);
            this.groupBox10.TabIndex = 1;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Matched Tag Data Output (MSB) Number 3";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(29, 60);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(87, 15);
            this.label41.TabIndex = 30;
            this.label41.Text = "Tag Data(HEX)";
            // 
            // EDIT_TAG_MATCHED_DATA3
            // 
            this.EDIT_TAG_MATCHED_DATA3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EDIT_TAG_MATCHED_DATA3.Location = new System.Drawing.Point(133, 60);
            this.EDIT_TAG_MATCHED_DATA3.Name = "EDIT_TAG_MATCHED_DATA3";
            this.EDIT_TAG_MATCHED_DATA3.Size = new System.Drawing.Size(108, 21);
            this.EDIT_TAG_MATCHED_DATA3.TabIndex = 29;
            this.EDIT_TAG_MATCHED_DATA3.Text = "AABBCCDDEE";
            this.EDIT_TAG_MATCHED_DATA3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // COMBO_TAG_MATCHED_BYTELEN3
            // 
            this.COMBO_TAG_MATCHED_BYTELEN3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMBO_TAG_MATCHED_BYTELEN3.FormattingEnabled = true;
            this.COMBO_TAG_MATCHED_BYTELEN3.Items.AddRange(new object[] {
            "0(Disable)",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.COMBO_TAG_MATCHED_BYTELEN3.Location = new System.Drawing.Point(133, 26);
            this.COMBO_TAG_MATCHED_BYTELEN3.Name = "COMBO_TAG_MATCHED_BYTELEN3";
            this.COMBO_TAG_MATCHED_BYTELEN3.Size = new System.Drawing.Size(108, 23);
            this.COMBO_TAG_MATCHED_BYTELEN3.TabIndex = 13;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(29, 29);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(98, 15);
            this.label48.TabIndex = 12;
            this.label48.Text = "Matched Length";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label38);
            this.groupBox9.Controls.Add(this.EDIT_TAG_MATCHED_DATA2);
            this.groupBox9.Controls.Add(this.COMBO_TAG_MATCHED_BYTELEN2);
            this.groupBox9.Controls.Add(this.label40);
            this.groupBox9.Location = new System.Drawing.Point(16, 135);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(277, 92);
            this.groupBox9.TabIndex = 1;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Matched Tag Data Output (MSB) Number 2";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(29, 60);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(87, 15);
            this.label38.TabIndex = 30;
            this.label38.Text = "Tag Data(HEX)";
            // 
            // EDIT_TAG_MATCHED_DATA2
            // 
            this.EDIT_TAG_MATCHED_DATA2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EDIT_TAG_MATCHED_DATA2.Location = new System.Drawing.Point(133, 60);
            this.EDIT_TAG_MATCHED_DATA2.Name = "EDIT_TAG_MATCHED_DATA2";
            this.EDIT_TAG_MATCHED_DATA2.Size = new System.Drawing.Size(108, 21);
            this.EDIT_TAG_MATCHED_DATA2.TabIndex = 29;
            this.EDIT_TAG_MATCHED_DATA2.Text = "AABBCCDDEE";
            this.EDIT_TAG_MATCHED_DATA2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // COMBO_TAG_MATCHED_BYTELEN2
            // 
            this.COMBO_TAG_MATCHED_BYTELEN2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMBO_TAG_MATCHED_BYTELEN2.FormattingEnabled = true;
            this.COMBO_TAG_MATCHED_BYTELEN2.Items.AddRange(new object[] {
            "0(Disable)",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.COMBO_TAG_MATCHED_BYTELEN2.Location = new System.Drawing.Point(133, 26);
            this.COMBO_TAG_MATCHED_BYTELEN2.Name = "COMBO_TAG_MATCHED_BYTELEN2";
            this.COMBO_TAG_MATCHED_BYTELEN2.Size = new System.Drawing.Size(108, 23);
            this.COMBO_TAG_MATCHED_BYTELEN2.TabIndex = 13;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(29, 29);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(98, 15);
            this.label40.TabIndex = 12;
            this.label40.Text = "Matched Length";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label36);
            this.groupBox8.Controls.Add(this.EDIT_TAG_MATCHED_DATA1);
            this.groupBox8.Controls.Add(this.COMBO_TAG_MATCHED_BYTELEN1);
            this.groupBox8.Controls.Add(this.label24);
            this.groupBox8.Location = new System.Drawing.Point(16, 23);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(277, 92);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Matched Tag Data Output (MSB) Number 1";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(29, 60);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(87, 15);
            this.label36.TabIndex = 30;
            this.label36.Text = "Tag Data(HEX)";
            // 
            // EDIT_TAG_MATCHED_DATA1
            // 
            this.EDIT_TAG_MATCHED_DATA1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.EDIT_TAG_MATCHED_DATA1.Location = new System.Drawing.Point(133, 60);
            this.EDIT_TAG_MATCHED_DATA1.Name = "EDIT_TAG_MATCHED_DATA1";
            this.EDIT_TAG_MATCHED_DATA1.Size = new System.Drawing.Size(108, 21);
            this.EDIT_TAG_MATCHED_DATA1.TabIndex = 29;
            this.EDIT_TAG_MATCHED_DATA1.Text = "AABBCCDDEE";
            this.EDIT_TAG_MATCHED_DATA1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // COMBO_TAG_MATCHED_BYTELEN1
            // 
            this.COMBO_TAG_MATCHED_BYTELEN1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMBO_TAG_MATCHED_BYTELEN1.FormattingEnabled = true;
            this.COMBO_TAG_MATCHED_BYTELEN1.Items.AddRange(new object[] {
            "0(Disable)",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.COMBO_TAG_MATCHED_BYTELEN1.Location = new System.Drawing.Point(133, 26);
            this.COMBO_TAG_MATCHED_BYTELEN1.Name = "COMBO_TAG_MATCHED_BYTELEN1";
            this.COMBO_TAG_MATCHED_BYTELEN1.Size = new System.Drawing.Size(108, 23);
            this.COMBO_TAG_MATCHED_BYTELEN1.TabIndex = 13;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(29, 29);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(98, 15);
            this.label24.TabIndex = 12;
            this.label24.Text = "Matched Length";
            // 
            // BtnGetBeepStatus
            // 
            this.BtnGetBeepStatus.Location = new System.Drawing.Point(863, 265);
            this.BtnGetBeepStatus.Name = "BtnGetBeepStatus";
            this.BtnGetBeepStatus.Size = new System.Drawing.Size(155, 44);
            this.BtnGetBeepStatus.TabIndex = 0;
            this.BtnGetBeepStatus.Text = "Get Beep Status";
            this.BtnGetBeepStatus.UseVisualStyleBackColor = true;
            this.BtnGetBeepStatus.Click += new System.EventHandler(this.BtnGetBeepStatus_Click);
            // 
            // BtnSetBeepMode
            // 
            this.BtnSetBeepMode.Location = new System.Drawing.Point(709, 265);
            this.BtnSetBeepMode.Name = "BtnSetBeepMode";
            this.BtnSetBeepMode.Size = new System.Drawing.Size(151, 44);
            this.BtnSetBeepMode.TabIndex = 0;
            this.BtnSetBeepMode.Text = "Set Beep";
            this.BtnSetBeepMode.UseVisualStyleBackColor = true;
            this.BtnSetBeepMode.Click += new System.EventHandler(this.BtnSetBeepMode_Click);
            // 
            // ReaderWorkModeComboBox
            // 
            this.ReaderWorkModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ReaderWorkModeComboBox.FormattingEnabled = true;
            this.ReaderWorkModeComboBox.Items.AddRange(new object[] {
            "Command",
            "Polling",
            "Trigger"});
            this.ReaderWorkModeComboBox.Location = new System.Drawing.Point(863, 70);
            this.ReaderWorkModeComboBox.Name = "ReaderWorkModeComboBox";
            this.ReaderWorkModeComboBox.Size = new System.Drawing.Size(108, 23);
            this.ReaderWorkModeComboBox.TabIndex = 13;
            // 
            // BtnSettingDefaultWorkParam
            // 
            this.BtnSettingDefaultWorkParam.Location = new System.Drawing.Point(771, 377);
            this.BtnSettingDefaultWorkParam.Name = "BtnSettingDefaultWorkParam";
            this.BtnSettingDefaultWorkParam.Size = new System.Drawing.Size(191, 44);
            this.BtnSettingDefaultWorkParam.TabIndex = 0;
            this.BtnSettingDefaultWorkParam.Text = "Set Default Work Parameter";
            this.BtnSettingDefaultWorkParam.UseVisualStyleBackColor = true;
            this.BtnSettingDefaultWorkParam.Click += new System.EventHandler(this.BtnSettingDefaultWorkParam_Click);
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(779, 70);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(72, 15);
            this.label58.TabIndex = 12;
            this.label58.Text = "Work Mode";
            // 
            // gbxRdIntrgtMem
            // 
            this.gbxRdIntrgtMem.Location = new System.Drawing.Point(0, 0);
            this.gbxRdIntrgtMem.Name = "gbxRdIntrgtMem";
            this.gbxRdIntrgtMem.Size = new System.Drawing.Size(200, 100);
            this.gbxRdIntrgtMem.TabIndex = 0;
            this.gbxRdIntrgtMem.TabStop = false;
            // 
            // timerCheckReader
            // 
            this.timerCheckReader.Interval = 1000;
            this.timerCheckReader.Tick += new System.EventHandler(this.timerCheckReader_Tick);
            // 
            // tmrCheckEpc
            // 
            this.tmrCheckEpc.Interval = 300;
            this.tmrCheckEpc.Tick += new System.EventHandler(this.tmrCheckEpc_Tick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStripInfor
            // 
            this.statusStripInfor.AutoSize = false;
            this.statusStripInfor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripProgressBar1});
            this.statusStripInfor.Location = new System.Drawing.Point(0, 664);
            this.statusStripInfor.Name = "statusStripInfor";
            this.statusStripInfor.Size = new System.Drawing.Size(1079, 33);
            this.statusStripInfor.TabIndex = 89;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(550, 28);
            this.toolStripStatusLabel1.Text = "UHF RFID Reader DEMO ";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(350, 28);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.AutoSize = false;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(150, 28);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(120, 27);
            // 
            // label_dllversion
            // 
            this.label_dllversion.AutoSize = true;
            this.label_dllversion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dllversion.ForeColor = System.Drawing.Color.Red;
            this.label_dllversion.Location = new System.Drawing.Point(864, 0);
            this.label_dllversion.Name = "label_dllversion";
            this.label_dllversion.Size = new System.Drawing.Size(119, 15);
            this.label_dllversion.TabIndex = 90;
            this.label_dllversion.Text = "DLL Ver: 0x92.02.15";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1079, 697);
            this.Controls.Add(this.label_dllversion);
            this.Controls.Add(this.statusStripInfor);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UHF RFID Reader DEMO (RS232/485) V7.3.1  (Release Date: 2023-05-02)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbx_conn.ResumeLayout(false);
            this.gbx_conn.PerformLayout();
            this.gbx_NewDevAddr.ResumeLayout(false);
            this.gbxRxData.ResumeLayout(false);
            this.gbxRxData.PerformLayout();
            this.gbx_inventory.ResumeLayout(false);
            this.gbx_inventory.PerformLayout();
            this.gbx_MTR.ResumeLayout(false);
            this.gbx_MTR.PerformLayout();
            this.gbx_Access.ResumeLayout(false);
            this.gbx_Access.PerformLayout();
            this.gbx_MTR_LoopNum.ResumeLayout(false);
            this.gbx_MTR_LoopNum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEpcBasic)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.gbxEpcTableBasic.ResumeLayout(false);
            this.gbxEpcTableBasic.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage_TagRead.ResumeLayout(false);
            this.tabPage_TagRead.PerformLayout();
            this.tabPage_SysSetting.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.gbxStatus.ResumeLayout(false);
            this.gbxStatus.PerformLayout();
            this.tabPageAccessTag.ResumeLayout(false);
            this.tabPageAccessTag.PerformLayout();
            this.tabControl4.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.gbxSelect.ResumeLayout(false);
            this.gbxSelect.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.gbxSetQuery.ResumeLayout(false);
            this.gbxSetQuery.PerformLayout();
            this.tabControl3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbxAccess.ResumeLayout(false);
            this.gbxAccess.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.gBxLock.ResumeLayout(false);
            this.gBxLock.PerformLayout();
            this.gbxKill.ResumeLayout(false);
            this.gbxKill.PerformLayout();
            this.gbxStatus2.ResumeLayout(false);
            this.gbxStatus2.PerformLayout();
            this.gbx_comcnt_adv.ResumeLayout(false);
            this.gbx_comcnt_adv.PerformLayout();
            this.gbxEpcTableAdv.ResumeLayout(false);
            this.gbxEpcTableAdv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_epc2)).EndInit();
            this.tabPageSysSetting.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox_GPIO.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox_GPO.ResumeLayout(false);
            this.groupBox_GPO.PerformLayout();
            this.gbxIoControl.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox_RFSetting.ResumeLayout(false);
            this.gbxRfPower.ResumeLayout(false);
            this.gbx_setfreq.ResumeLayout(false);
            this.gbx_InsertRFCH.ResumeLayout(false);
            this.gbx_InsertRFCH.PerformLayout();
            this.groupBox_RF_Ant.ResumeLayout(false);
            this.groupBox_RF_Ant.PerformLayout();
            this.groupBox_RF_Ant_Port.ResumeLayout(false);
            this.groupBox_RF_Ant_Port.PerformLayout();
            this.groupBox_RF_Ant_Enable.ResumeLayout(false);
            this.groupBox_RF_Ant_Enable.PerformLayout();
            this.groupBox_RF_Ant_SwitchAnt.ResumeLayout(false);
            this.groupBox_RF_Ant_SwitchAnt.PerformLayout();
            this.ExtCommand.ResumeLayout(false);
            this.ExtCommand.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.statusStripInfor.ResumeLayout(false);
            this.statusStripInfor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_conn;
        private System.Windows.Forms.Button btnConn;
        private System.Windows.Forms.ComboBox cbxBaudRate;
        private System.Windows.Forms.ComboBox cbxPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtReceive;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Button btn_clear_rx;
        private System.Windows.Forms.Button btnClearCnt;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Timer timerAutoSend;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.GroupBox gbxRxData;
        private System.Windows.Forms.GroupBox gbx_inventory;
        private System.Windows.Forms.Button btnInvtBasic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxQBasic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvEpcBasic;
        private System.Windows.Forms.GroupBox gbxEpcTableBasic;
        private System.Windows.Forms.Button btn_clear_epc1;
        private System.Windows.Forms.CheckBox cbxAutoClear;
        private System.Windows.Forms.CheckBox cbxRxVisable;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.TabPage tabPageAccessTag;
        private System.Windows.Forms.GroupBox gbxEpcTableAdv;
        private System.Windows.Forms.DataGridView dgv_epc2;
        private System.Windows.Forms.Button btn_clear_epc2;
        private System.Windows.Forms.Button btnInvtAdv;
        private System.Windows.Forms.GroupBox gbxSetQuery;
        private System.Windows.Forms.ComboBox cbxDR;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxM;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxTRext;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbxSel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbxSession;
        private System.Windows.Forms.GroupBox gbxRdIntrgtMem;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbxTarget;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnSetQuery;
        private System.Windows.Forms.Button btnGetQuery;
        private System.Windows.Forms.ComboBox cbxQAdv;
        private System.Windows.Forms.Button btnInvtMulti;
        private System.Windows.Forms.TextBox txtRDMultiNum;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnStopRD;
        private System.Windows.Forms.TextBox txtCOMRxCnt;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtCOMTxCnt;
        private System.Windows.Forms.GroupBox gbxStatus;
        private System.Windows.Forms.GroupBox gbxAccess;
        private System.Windows.Forms.GroupBox gbx_comcnt_adv;
        private System.Windows.Forms.Button btnClearCntAdv;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtCOMRxCnt_adv;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtCOMTxCnt_adv;
        private System.Windows.Forms.Button btn_invtread;
        private System.Windows.Forms.TextBox txtWordPtr1;
        private System.Windows.Forms.TextBox txtWordCnt1;
        private System.Windows.Forms.ComboBox cbxMemBank;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnInvtWrtie;
        private System.Windows.Forms.TextBox txtInvtRWData;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtRwAccPassWord;
        private System.Windows.Forms.TextBox txtWordPtr0;
        private System.Windows.Forms.TextBox txtWordCnt0;
        private System.Windows.Forms.GroupBox gbxSelect;
        private System.Windows.Forms.Button btnSetSelect;
        private System.Windows.Forms.ComboBox cbxSelTarget;
        private System.Windows.Forms.ComboBox cbxAction;
        private System.Windows.Forms.ComboBox cbxSelMemBank;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtSelPrt0;
        private System.Windows.Forms.TextBox txtSelPrt2;
        private System.Windows.Forms.TextBox txtSelPrt1;
        private System.Windows.Forms.TextBox txtSelPrt3;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox txtSelLength;
        private System.Windows.Forms.CheckBox ckxTruncated;
        private System.Windows.Forms.TextBox txtSelMask;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Button btnGetSelect;
        private System.Windows.Forms.TextBox txtGetSelLength;
        private System.Windows.Forms.TextBox txtGetSelMask;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.GroupBox gbxKill;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox textBoxKillPwd;
        private System.Windows.Forms.Button buttonKill;
        private System.Windows.Forms.GroupBox gBxLock;
        private System.Windows.Forms.Button buttonLock;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox textBoxLockAccessPwd;
        private System.Windows.Forms.Label labelKillRFU;
        private System.Windows.Forms.TextBox textBoxKillRFU;
        private System.Windows.Forms.CheckBox inv_mode;
        private System.Windows.Forms.TextBox txtSendDelay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveAsCsvToolStripMenuItem;
        private System.Windows.Forms.Timer timerCheckReader;
        private System.Windows.Forms.Button Reset_FW;
        private System.Windows.Forms.Timer tmrCheckEpc;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox txtOperateEpc;
        private System.Windows.Forms.GroupBox gbxStatus2;
        private System.Windows.Forms.RichTextBox rtbxStatus;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox cbxLockKillAction;
        private System.Windows.Forms.CheckBox checkBoxUser;
        private System.Windows.Forms.CheckBox checkBoxTID;
        private System.Windows.Forms.CheckBox checkBoxEPC;
        private System.Windows.Forms.CheckBox checkBoxAccessPwd;
        private System.Windows.Forms.CheckBox checkBoxKillPwd;
        private System.Windows.Forms.ComboBox cbxLockUserAction;
        private System.Windows.Forms.ComboBox cbxLockTIDAction;
        private System.Windows.Forms.ComboBox cbxLockEPCAction;
        private System.Windows.Forms.ComboBox cbxLockAccessAction;
        private System.Windows.Forms.Label label_DeviceAddr;
        private System.Windows.Forms.ComboBox cbxDeviceAddr;
        private System.Windows.Forms.Button btn_SetReaderDeviceAddr;
        private System.Windows.Forms.Button btn_GetReaderDeviceAddr;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStripInfor;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        //private System.Windows.Forms.Button btn_ClearSensorTag;
        private System.Windows.Forms.GroupBox gbx_NewDevAddr;
        private System.Windows.Forms.ComboBox cbxNewDeviceAddr;
        private System.Windows.Forms.TabPage tabPageSysSetting;
        private System.Windows.Forms.GroupBox groupBox_RF_Ant;
        private System.Windows.Forms.GroupBox groupBox_RFSetting;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox_RF_Ant_Port;
        private System.Windows.Forms.RadioButton radioButton_AntPort8;
        private System.Windows.Forms.RadioButton radioButton_AntPort7;
        private System.Windows.Forms.RadioButton radioButton_AntPort6;
        private System.Windows.Forms.RadioButton radioButton_AntPort5;
        private System.Windows.Forms.RadioButton radioButton_AntPort4;
        private System.Windows.Forms.RadioButton radioButton_AntPort3;
        private System.Windows.Forms.RadioButton radioButton_AntPort2;
        private System.Windows.Forms.RadioButton radioButton_AntPort1;
        private System.Windows.Forms.CheckBox checkBox_RF_AntPort_AutoPolling;
        private System.Windows.Forms.Label label_RF_AntPort_InvCnter;
        private System.Windows.Forms.Label label_RF_AntPort_Power;
        private System.Windows.Forms.TextBox textBox_RF_AntPort_InvCnter8;
        private System.Windows.Forms.ComboBox comboBoxRF_AntPort_Port8;
        private System.Windows.Forms.TextBox textBox_RF_AntPort_InvCnter7;
        private System.Windows.Forms.ComboBox comboBoxRF_AntPort_Port7;
        private System.Windows.Forms.TextBox textBox_RF_AntPort_InvCnter6;
        private System.Windows.Forms.ComboBox comboBoxRF_AntPort_Port6;
        private System.Windows.Forms.TextBox textBox_RF_AntPort_InvCnter5;
        private System.Windows.Forms.ComboBox comboBoxRF_AntPort_Port5;
        private System.Windows.Forms.TextBox textBox_RF_AntPort_InvCnter4;
        private System.Windows.Forms.ComboBox comboBoxRF_AntPort_Port4;
        private System.Windows.Forms.TextBox textBox_RF_AntPort_InvCnter3;
        private System.Windows.Forms.ComboBox comboBoxRF_AntPort_Port3;
        private System.Windows.Forms.TextBox textBox_RF_AntPort_InvCnter2;
        private System.Windows.Forms.ComboBox comboBoxRF_AntPort_Port2;
        private System.Windows.Forms.TextBox textBox_RF_AntPort_InvCnter1;
        private System.Windows.Forms.ComboBox comboBoxRF_AntPort_Port1;
        private System.Windows.Forms.ComboBox comboBox_RF_AntPort_Quantity;
        private System.Windows.Forms.Label label_AntPort_Quantity;
        private System.Windows.Forms.Button button_RF_Ant_Get;
        private System.Windows.Forms.Button button_RF_Ant_Set;
        private System.Windows.Forms.GroupBox groupBox_RF_Ant_Enable;
        private System.Windows.Forms.GroupBox groupBox_RF_Ant_SwitchAnt;
        private System.Windows.Forms.CheckBox checkBox_RF_Ant_Enable8;
        private System.Windows.Forms.CheckBox checkBox_RF_Ant_Enable7;
        private System.Windows.Forms.CheckBox checkBox_RF_Ant_Enable6;
        private System.Windows.Forms.CheckBox checkBox_RF_Ant_Enable5;
        private System.Windows.Forms.CheckBox checkBox_RF_Ant_Enable4;
        private System.Windows.Forms.CheckBox checkBox_RF_Ant_Enable3;
        private System.Windows.Forms.CheckBox checkBox_RF_Ant_Enable2;
        private System.Windows.Forms.CheckBox checkBox_RF_Ant_Enable1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSetModuleSleep;
        private System.Windows.Forms.Button bynSaveConfigToNv;
        private System.Windows.Forms.CheckBox cbxSaveNvConfig;
        private System.Windows.Forms.ComboBox cbxMode;
        private System.Windows.Forms.Button btnSetMode;
        private System.Windows.Forms.GroupBox gbx_setfreq;
        private System.Windows.Forms.TextBox txtChIndexBegin;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TextBox txtChIndexEnd;
        private System.Windows.Forms.Button btnInsertRfCh;
        private System.Windows.Forms.Button btnGetChannel;
        private System.Windows.Forms.Button btnSetRegion;
        private System.Windows.Forms.Button btnSetFhss;
        private System.Windows.Forms.ComboBox cbxChannel;
        private System.Windows.Forms.ComboBox cbxRegion;
        private System.Windows.Forms.Button btnSetFreq;
        private System.Windows.Forms.GroupBox gbxRfPower;
        private System.Windows.Forms.Button btnGetPaPower;
        private System.Windows.Forms.ComboBox cbxPaPower;
        private System.Windows.Forms.Button btnSetPaPower;
        private System.Windows.Forms.Button btnSetCW;
        private System.Windows.Forms.Button button_RF_Ant_GetCurrentAntPort;
        private System.Windows.Forms.GroupBox gbx_MTR;
        private System.Windows.Forms.Label lbl_MTR_Qvalue;
        private System.Windows.Forms.ComboBox cbx_MTR_Qvalue;
        private System.Windows.Forms.Label lbl_MTR_Read_Number;
        private System.Windows.Forms.Label lbl_MTR_Algorithm;
        private System.Windows.Forms.ComboBox cbx_MTR_Algorithm;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.GroupBox gbx_MTR_LoopNum;
        private System.Windows.Forms.GroupBox gbxIoControl;
        private System.Windows.Forms.ComboBox cbxIoDircetion;
        private System.Windows.Forms.ComboBox cbxIoLevel;
        private System.Windows.Forms.Button btnSetIoDirection;
        private System.Windows.Forms.Button btnSetIO;
        private System.Windows.Forms.Button btnGetIO;
        private System.Windows.Forms.ComboBox cbxIO;
        private System.Windows.Forms.Label label_EPC_TagCounter;
        private System.Windows.Forms.TextBox textBox_EPC_TagCounter;
        private System.Windows.Forms.TextBox textBox_EPC_Tag_Total;
        private System.Windows.Forms.Label label_EPC_Tag_Total;
		private System.Windows.Forms.CheckBox checkBox_InvtMulti_AutoClear;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage_TagRead;
        private System.Windows.Forms.TabPage tabPage_SysSetting;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cbxNewBaudRate;
        private System.Windows.Forms.Button btn_SetNewBaudRate;
        private System.Windows.Forms.Button btn_GetNewBaudRate;
        private System.Windows.Forms.Button btnGetFhss;
        private System.Windows.Forms.ComboBox cbxFHSS;
        private System.Windows.Forms.Button btnSetFreqHopPeriod;
        private System.Windows.Forms.ComboBox cbxFhssHopPeriod;
        private System.Windows.Forms.Button btnGetFreqHopPeriod;
		private System.Windows.Forms.GroupBox groupBox_GPIO;
		private System.Windows.Forms.Button button_GPO_Set;
        private System.Windows.Forms.Button button_GPO_Get;
        private System.Windows.Forms.GroupBox groupBox_GPO;
		private System.Windows.Forms.Button btnGetRegion;
        private System.Windows.Forms.Label label_dllversion;
		private System.Windows.Forms.Button btnInsertRfCh_Get;
        private System.Windows.Forms.GroupBox gbx_InsertRFCH;
        private System.Windows.Forms.Button btnInsertRfCh_Help;
        private System.Windows.Forms.Label label_Acess1;
        private System.Windows.Forms.Label label_Access2;
        private System.Windows.Forms.Label label_Access3;
        private System.Windows.Forms.Label label_Access4;
        private System.Windows.Forms.CheckBox cbxRxTimeInfor;
        private System.Windows.Forms.TextBox txtTxTimerInfor;
        private System.Windows.Forms.TextBox txtInvEPC_AccessMemBankStartAddr;
        private System.Windows.Forms.Button btnInvtMultiEpcTid;
        private System.Windows.Forms.Label labelInvEpcAccessMemBankStartWordAddr;
        private System.Windows.Forms.Label labelInvEpcAccessMemBankWordLength;
        private System.Windows.Forms.TextBox txtInvEPC_AccessMemBankWordLength;
        private System.Windows.Forms.ComboBox cbx_AccessMemBank;
        private System.Windows.Forms.Label labelInvEpcAccessMemBankAlgorithm;
        private System.Windows.Forms.Label labelInvEpcAccessMemBankAccessPwd;
        private System.Windows.Forms.TextBox txtEpcAccessMemBankAccessPwd;
        private System.Windows.Forms.GroupBox gbx_Access;
        private System.Windows.Forms.CheckBox checkBox_WorkMode;
		private System.Windows.Forms.TextBox txt_TagNumberToStopTimer;
		private System.Windows.Forms.Label lbl_TagNumberToStopTimer;
		private System.Windows.Forms.TextBox txt_TagNumberToTimeValue;
        private System.Windows.Forms.Label lbl_TagNumberElapseTimeMs;
        private System.Windows.Forms.Label lbl_TagNumberElapseTime;
        private System.Windows.Forms.RadioButton radioCommRS485;
        private System.Windows.Forms.RadioButton radioCommRS232;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.ComboBox comboBox_GPO4;
        private System.Windows.Forms.ComboBox comboBox_GPO3;
        private System.Windows.Forms.ComboBox comboBox_GPO2;
        private System.Windows.Forms.ComboBox comboBox_GPO1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button button_GPI_Get;
        private System.Windows.Forms.ComboBox comboBox_GPI4;
        private System.Windows.Forms.ComboBox comboBox_GPI3;
        private System.Windows.Forms.ComboBox comboBox_GPI2;
        private System.Windows.Forms.ComboBox comboBox_GPI1;
        private System.Windows.Forms.Button btn_AntQuantityHelp;
        private System.Windows.Forms.Button btn_AntAutoPolling_ParametersHelp;
        private System.Windows.Forms.Button btn_AccessMemBankHelp;
        private System.Windows.Forms.Button btnGetMode;
        private System.Windows.Forms.CheckBox checkBox_GPI4;
        private System.Windows.Forms.CheckBox checkBox_GPI3;
        private System.Windows.Forms.CheckBox checkBox_GPI2;
        private System.Windows.Forms.CheckBox checkBox_GPI1;
        private System.Windows.Forms.CheckBox checkBox_GPO4;
        private System.Windows.Forms.CheckBox checkBox_GPO3;
        private System.Windows.Forms.CheckBox checkBox_GPO2;
        private System.Windows.Forms.CheckBox checkBox_GPO1;
        private System.Windows.Forms.Button btn_invt_multi_Help;
        private System.Windows.Forms.RadioButton radioButton_AntPort12;
        private System.Windows.Forms.RadioButton radioButton_AntPort16;
        private System.Windows.Forms.RadioButton radioButton_AntPort15;
        private System.Windows.Forms.RadioButton radioButton_AntPort11;
        private System.Windows.Forms.RadioButton radioButton_AntPort14;
        private System.Windows.Forms.RadioButton radioButton_AntPort10;
        private System.Windows.Forms.RadioButton radioButton_AntPort13;
        private System.Windows.Forms.RadioButton radioButton_AntPort9;
        private System.Windows.Forms.CheckBox checkBox_RF_Ant_Enable16;
        private System.Windows.Forms.CheckBox checkBox_RF_Ant_Enable15;
        private System.Windows.Forms.CheckBox checkBox_RF_Ant_Enable14;
        private System.Windows.Forms.CheckBox checkBox_RF_Ant_Enable13;
        private System.Windows.Forms.CheckBox checkBox_RF_Ant_Enable12;
        private System.Windows.Forms.CheckBox checkBox_RF_Ant_Enable11;
        private System.Windows.Forms.CheckBox checkBox_RF_Ant_Enable10;
        private System.Windows.Forms.TextBox textBox_RF_AntPort_InvCnter16;
        private System.Windows.Forms.ComboBox comboBoxRF_AntPort_Port16;
        private System.Windows.Forms.ComboBox comboBoxRF_AntPort_Port15;
        private System.Windows.Forms.TextBox textBox_RF_AntPort_InvCnter15;
        private System.Windows.Forms.TextBox textBox_RF_AntPort_InvCnter14;
        private System.Windows.Forms.ComboBox comboBoxRF_AntPort_Port14;
        private System.Windows.Forms.TextBox textBox_RF_AntPort_InvCnter13;
        private System.Windows.Forms.ComboBox comboBoxRF_AntPort_Port13;
        private System.Windows.Forms.TextBox textBox_RF_AntPort_InvCnter12;
        private System.Windows.Forms.ComboBox comboBoxRF_AntPort_Port12;
        private System.Windows.Forms.TextBox textBox_RF_AntPort_InvCnter11;
        private System.Windows.Forms.ComboBox comboBoxRF_AntPort_Port11;
        private System.Windows.Forms.TextBox textBox_RF_AntPort_InvCnter10;
        private System.Windows.Forms.ComboBox comboBoxRF_AntPort_Port10;
        private System.Windows.Forms.TextBox textBox_RF_AntPort_InvCnter9;
        private System.Windows.Forms.ComboBox comboBoxRF_AntPort_Port9;
        private System.Windows.Forms.CheckBox checkBox_RF_Ant_Enable9;
        private System.Windows.Forms.Button button_RF_Ant_SetAllParameter;
        private System.Windows.Forms.ComboBox comboBoxRF_AntPort_PortAll;
        private System.Windows.Forms.TextBox txtInvEPC_AccessExUserMemBankStartAddrEx;
        private System.Windows.Forms.TextBox txtInvEPC_AccessExUserMemBankWordLength;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.TabPage ExtCommand;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.TextBox EDIT_TAG_MATCHED_DATA5;
        private System.Windows.Forms.ComboBox COMBO_TAG_MATCHED_BYTELEN5;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.TextBox EDIT_TAG_MATCHED_DATA4;
        private System.Windows.Forms.ComboBox COMBO_TAG_MATCHED_BYTELEN4;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox EDIT_TAG_MATCHED_DATA3;
        private System.Windows.Forms.ComboBox COMBO_TAG_MATCHED_BYTELEN3;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox EDIT_TAG_MATCHED_DATA2;
        private System.Windows.Forms.ComboBox COMBO_TAG_MATCHED_BYTELEN2;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox EDIT_TAG_MATCHED_DATA1;
        private System.Windows.Forms.ComboBox COMBO_TAG_MATCHED_BYTELEN1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button Btn_Set_Mode00;
        private System.Windows.Forms.Button Btn_Set_EnableModeOn;
        private System.Windows.Forms.Button Btn_Get_EnableMode21;
        private System.Windows.Forms.Button Btn_Get_Mode11;
        private System.Windows.Forms.ComboBox MatchedModeComboBox;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.ComboBox MatchedNumberComboBox;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Button BtnSettingDefaultWorkParam;
        private System.Windows.Forms.Button BtnGetBeepStatus;
        private System.Windows.Forms.Button BtnSetBeepMode;
        private System.Windows.Forms.Button Btn_Set_EnableModeOff;
        private System.Windows.Forms.ComboBox ReaderWorkModeComboBox;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Button BtnGetReaderWorkMode;
        private System.Windows.Forms.Button BtnSetReaderWorkMode;
        private System.Windows.Forms.Button BtnFillTagData;
        private System.Windows.Forms.ComboBox BeepModeComboBox;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtReaderFirmwareVersion;
        private System.Windows.Forms.TextBox txtModuleFirmwareVersion;
        private System.Windows.Forms.TextBox txtModuleReleaseDate;
        private System.Windows.Forms.TextBox txtModuleHardwareVersion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label labelHardwareVersion;
        //private System.IO.Ports.SerialPort ComDevice;
    }
}

