namespace Thesis.View
{
    partial class UpdateRecordForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblIdE;
            System.Windows.Forms.Label lblCostE;
            System.Windows.Forms.Label lblDateE;
            System.Windows.Forms.Label lblSupplyIdE;
            System.Windows.Forms.Label lblSalaryIdE;
            System.Windows.Forms.Label lblDescriptE;
            System.Windows.Forms.Label lblAmountE;
            System.Windows.Forms.Label lblIdC;
            System.Windows.Forms.Label lblFirstNameC;
            System.Windows.Forms.Label lblLastNameC;
            System.Windows.Forms.Label lblSubFromC;
            System.Windows.Forms.Label lblSubToC;
            System.Windows.Forms.Label lblAddedAtC;
            System.Windows.Forms.Label lblRenewsC;
            System.Windows.Forms.Label lblEmailC;
            System.Windows.Forms.Label lblPhoneC;
            System.Windows.Forms.Label lblCoachIdC;
            System.Windows.Forms.Label lblBonusC;
            System.Windows.Forms.Label lblIdProd;
            System.Windows.Forms.Label lblNameProd;
            System.Windows.Forms.Label lblAmountProd;
            System.Windows.Forms.Label lblBarcodeProd;
            System.Windows.Forms.Label lblCategoryProd;
            System.Windows.Forms.Label lblLDDProd;
            System.Windows.Forms.Label lblFDDProd;
            System.Windows.Forms.Label lblSalePriceProd;
            System.Windows.Forms.Label lblProvIdProd;
            System.Windows.Forms.Label lblIdProc;
            System.Windows.Forms.Label lblCostProc;
            System.Windows.Forms.Label lblDateProc;
            System.Windows.Forms.Label lblClientIdProc;
            System.Windows.Forms.Label lblDescProc;
            System.Windows.Forms.Label lblAmountProc;
            System.Windows.Forms.Label lblIdInv;
            System.Windows.Forms.Label lblNameInv;
            System.Windows.Forms.Label lblTypeInv;
            System.Windows.Forms.Label lblBrandInv;
            System.Windows.Forms.Label lblAmountInv;
            System.Windows.Forms.Label lblDelDateInv;
            System.Windows.Forms.Label lblRepairsInv;
            System.Windows.Forms.Label lblExpDateInv;
            System.Windows.Forms.Label lblChangeDateInv;
            System.Windows.Forms.Label lblDelPriceInv;
            System.Windows.Forms.Label lblProvIdInv;
            System.Windows.Forms.Label lblIdSal;
            System.Windows.Forms.Label lblWorkerIdSal;
            System.Windows.Forms.Label lblDateSal;
            System.Windows.Forms.Label lblSalarySal;
            System.Windows.Forms.Label lblBonusSal;
            System.Windows.Forms.Label lblIdProv;
            System.Windows.Forms.Label lblCompNameProv;
            System.Windows.Forms.Label lblAddrProv;
            System.Windows.Forms.Label lblEmailProv;
            System.Windows.Forms.Label lblPhoneProv;
            System.Windows.Forms.Label lblAPNProv;
            System.Windows.Forms.Label lblAPPINProv;
            System.Windows.Forms.Label lblIdSup;
            System.Windows.Forms.Label lblNameSup;
            System.Windows.Forms.Label lblProviderIdSup;
            System.Windows.Forms.Label lblDateSup;
            System.Windows.Forms.Label lblDelPriceSup;
            System.Windows.Forms.Label lblSalePriceSup;
            System.Windows.Forms.Label lblAmountSup;
            System.Windows.Forms.Label lblIdSub;
            System.Windows.Forms.Label lblNameSub;
            System.Windows.Forms.Label lblPriceSub;
            System.Windows.Forms.Label lblDurationSub;
            System.Windows.Forms.Label lblVisitsSub;
            System.Windows.Forms.Label lblIdWS;
            System.Windows.Forms.Label lblWorkerIdWS;
            System.Windows.Forms.Label lblShiftWS;
            System.Windows.Forms.Label lblWorkTimeWS;
            System.Windows.Forms.Label lblDateWS;
            System.Windows.Forms.Label lblIdWO;
            System.Windows.Forms.Label lblCoachIdWO;
            System.Windows.Forms.Label lblClientIdWO;
            System.Windows.Forms.Label lblDateWO;
            System.Windows.Forms.Label lblStartWO;
            System.Windows.Forms.Label lblEndWO;
            System.Windows.Forms.Label lblPriceWO;
            System.Windows.Forms.Label lblIdW;
            System.Windows.Forms.Label lblUsername;
            System.Windows.Forms.Label lblPass;
            System.Windows.Forms.Label lblFirstNameW;
            System.Windows.Forms.Label lblLastNameW;
            System.Windows.Forms.Label lblPINW;
            System.Windows.Forms.Label lblFirstDayW;
            System.Windows.Forms.Label lblSalaryW;
            System.Windows.Forms.Label lblRoleW;
            System.Windows.Forms.Label lblEmailW;
            System.Windows.Forms.Label lblPhoneW;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateRecordForm));
            this.gymDatabaseDataSet = new Thesis.GymDatabaseDataSet();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new Thesis.GymDatabaseDataSetTableAdapters.ClientsTableAdapter();
            this.tableAdapterManager = new Thesis.GymDatabaseDataSetTableAdapters.TableAdapterManager();
            this.expensesTableAdapter = new Thesis.GymDatabaseDataSetTableAdapters.ExpensesTableAdapter();
            this.inventoryTableAdapter = new Thesis.GymDatabaseDataSetTableAdapters.InventoryTableAdapter();
            this.proceedsTableAdapter = new Thesis.GymDatabaseDataSetTableAdapters.ProceedsTableAdapter();
            this.productsTableAdapter = new Thesis.GymDatabaseDataSetTableAdapters.ProductsTableAdapter();
            this.providersTableAdapter = new Thesis.GymDatabaseDataSetTableAdapters.ProvidersTableAdapter();
            this.salariesTableAdapter = new Thesis.GymDatabaseDataSetTableAdapters.SalariesTableAdapter();
            this.subscriptionsTableAdapter = new Thesis.GymDatabaseDataSetTableAdapters.SubscriptionsTableAdapter();
            this.suppliesTableAdapter = new Thesis.GymDatabaseDataSetTableAdapters.SuppliesTableAdapter();
            this.workersTableAdapter = new Thesis.GymDatabaseDataSetTableAdapters.WorkersTableAdapter();
            this.workoutsTableAdapter = new Thesis.GymDatabaseDataSetTableAdapters.WorkoutsTableAdapter();
            this.workSchedulesTableAdapter = new Thesis.GymDatabaseDataSetTableAdapters.WorkSchedulesTableAdapter();
            this.tableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.expensesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbExpenses = new System.Windows.Forms.GroupBox();
            this.txtIdE = new System.Windows.Forms.TextBox();
            this.txtCostE = new System.Windows.Forms.TextBox();
            this.dtpDateE = new System.Windows.Forms.DateTimePicker();
            this.txtSupplyIdE = new System.Windows.Forms.TextBox();
            this.txtSalaryIdE = new System.Windows.Forms.TextBox();
            this.txtDescriptE = new System.Windows.Forms.TextBox();
            this.txtAmountE = new System.Windows.Forms.TextBox();
            this.gbClients = new System.Windows.Forms.GroupBox();
            this.txtIdC = new System.Windows.Forms.TextBox();
            this.txtSubIdC = new System.Windows.Forms.TextBox();
            this.lblSubIdC = new System.Windows.Forms.Label();
            this.txtFirstNameC = new System.Windows.Forms.TextBox();
            this.txtLastNameC = new System.Windows.Forms.TextBox();
            this.dtpSubFromC = new System.Windows.Forms.DateTimePicker();
            this.dtpSubToC = new System.Windows.Forms.DateTimePicker();
            this.dtpAddedAtC = new System.Windows.Forms.DateTimePicker();
            this.txtRenewsC = new System.Windows.Forms.TextBox();
            this.txtEmailC = new System.Windows.Forms.TextBox();
            this.txtPhoneC = new System.Windows.Forms.TextBox();
            this.txtCoachIdC = new System.Windows.Forms.TextBox();
            this.checkBonusC = new System.Windows.Forms.CheckBox();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proceedsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbProducts = new System.Windows.Forms.GroupBox();
            this.txtIdProd = new System.Windows.Forms.TextBox();
            this.txtNameProd = new System.Windows.Forms.TextBox();
            this.txtAmountProd = new System.Windows.Forms.TextBox();
            this.txtBarcodeProd = new System.Windows.Forms.TextBox();
            this.comboCategoryProd = new System.Windows.Forms.ComboBox();
            this.dtpLDDProd = new System.Windows.Forms.DateTimePicker();
            this.dtpFDDProd = new System.Windows.Forms.DateTimePicker();
            this.txtSalePriceProd = new System.Windows.Forms.TextBox();
            this.txtProvIdProd = new System.Windows.Forms.TextBox();
            this.gbProceeds = new System.Windows.Forms.GroupBox();
            this.txtIdProc = new System.Windows.Forms.TextBox();
            this.txtCostProc = new System.Windows.Forms.TextBox();
            this.dtpDateProc = new System.Windows.Forms.DateTimePicker();
            this.txtClientIdProc = new System.Windows.Forms.TextBox();
            this.txtDescProc = new System.Windows.Forms.TextBox();
            this.txtAmountProc = new System.Windows.Forms.TextBox();
            this.gbInventory = new System.Windows.Forms.GroupBox();
            this.txtIdInv = new System.Windows.Forms.TextBox();
            this.txtNameInv = new System.Windows.Forms.TextBox();
            this.comboTypeInv = new System.Windows.Forms.ComboBox();
            this.txtBrandInv = new System.Windows.Forms.TextBox();
            this.txtAmountInv = new System.Windows.Forms.TextBox();
            this.dtpDelDateInv = new System.Windows.Forms.DateTimePicker();
            this.txtRepairsInv = new System.Windows.Forms.TextBox();
            this.dtpExpDateInv = new System.Windows.Forms.DateTimePicker();
            this.dtpChangeDateInv = new System.Windows.Forms.DateTimePicker();
            this.txtDelPriceInv = new System.Windows.Forms.TextBox();
            this.txtProvIdInv = new System.Windows.Forms.TextBox();
            this.providersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salariesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subscriptionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suppliesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workoutsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workSchedulesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbSalaries = new System.Windows.Forms.GroupBox();
            this.txtIdSal = new System.Windows.Forms.TextBox();
            this.txtWorkerIdSal = new System.Windows.Forms.TextBox();
            this.dtpDateSal = new System.Windows.Forms.DateTimePicker();
            this.txtSalarySal = new System.Windows.Forms.TextBox();
            this.txtBonusSal = new System.Windows.Forms.TextBox();
            this.gbProviders = new System.Windows.Forms.GroupBox();
            this.txtIdProv = new System.Windows.Forms.TextBox();
            this.txtCompNameProv = new System.Windows.Forms.TextBox();
            this.txtAddrProv = new System.Windows.Forms.TextBox();
            this.txtEmailProv = new System.Windows.Forms.TextBox();
            this.txtPhoneProv = new System.Windows.Forms.TextBox();
            this.txtAPNProv = new System.Windows.Forms.TextBox();
            this.txtAPPINProv = new System.Windows.Forms.TextBox();
            this.gbSupplies = new System.Windows.Forms.GroupBox();
            this.txtIdSup = new System.Windows.Forms.TextBox();
            this.txtNameSup = new System.Windows.Forms.TextBox();
            this.txtProviderIdSup = new System.Windows.Forms.TextBox();
            this.dtpDateSup = new System.Windows.Forms.DateTimePicker();
            this.txtDelPriceSup = new System.Windows.Forms.TextBox();
            this.txtSalePriceSup = new System.Windows.Forms.TextBox();
            this.txtAmountSup = new System.Windows.Forms.TextBox();
            this.gbSubscriptions = new System.Windows.Forms.GroupBox();
            this.txtIdSub = new System.Windows.Forms.TextBox();
            this.numVisitsSub = new System.Windows.Forms.NumericUpDown();
            this.numDurationSub = new System.Windows.Forms.NumericUpDown();
            this.txtNameSub = new System.Windows.Forms.TextBox();
            this.txtPriceSub = new System.Windows.Forms.TextBox();
            this.gbWorkSchedules = new System.Windows.Forms.GroupBox();
            this.txtIdWS = new System.Windows.Forms.TextBox();
            this.txtWorkerIdWS = new System.Windows.Forms.TextBox();
            this.txtShiftWS = new System.Windows.Forms.TextBox();
            this.txtWorkTimeWS = new System.Windows.Forms.TextBox();
            this.dtpDateWS = new System.Windows.Forms.DateTimePicker();
            this.gbWorkouts = new System.Windows.Forms.GroupBox();
            this.txtIdWO = new System.Windows.Forms.TextBox();
            this.txtCoachIdWO = new System.Windows.Forms.TextBox();
            this.txtClientIdWO = new System.Windows.Forms.TextBox();
            this.dtpDateWO = new System.Windows.Forms.DateTimePicker();
            this.txtStartWO = new System.Windows.Forms.TextBox();
            this.txtEndWO = new System.Windows.Forms.TextBox();
            this.txtPriceWO = new System.Windows.Forms.TextBox();
            this.gbWorkers = new System.Windows.Forms.GroupBox();
            this.txtIdW = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtFirstNameW = new System.Windows.Forms.TextBox();
            this.txtLastNameW = new System.Windows.Forms.TextBox();
            this.txtPINW = new System.Windows.Forms.TextBox();
            this.dtpFirstDayW = new System.Windows.Forms.DateTimePicker();
            this.txtSalaryW = new System.Windows.Forms.TextBox();
            this.comboRoleW = new System.Windows.Forms.ComboBox();
            this.txtEmailW = new System.Windows.Forms.TextBox();
            this.txtPhoneW = new System.Windows.Forms.TextBox();
            this.lblRequired = new System.Windows.Forms.Label();
            lblIdE = new System.Windows.Forms.Label();
            lblCostE = new System.Windows.Forms.Label();
            lblDateE = new System.Windows.Forms.Label();
            lblSupplyIdE = new System.Windows.Forms.Label();
            lblSalaryIdE = new System.Windows.Forms.Label();
            lblDescriptE = new System.Windows.Forms.Label();
            lblAmountE = new System.Windows.Forms.Label();
            lblIdC = new System.Windows.Forms.Label();
            lblFirstNameC = new System.Windows.Forms.Label();
            lblLastNameC = new System.Windows.Forms.Label();
            lblSubFromC = new System.Windows.Forms.Label();
            lblSubToC = new System.Windows.Forms.Label();
            lblAddedAtC = new System.Windows.Forms.Label();
            lblRenewsC = new System.Windows.Forms.Label();
            lblEmailC = new System.Windows.Forms.Label();
            lblPhoneC = new System.Windows.Forms.Label();
            lblCoachIdC = new System.Windows.Forms.Label();
            lblBonusC = new System.Windows.Forms.Label();
            lblIdProd = new System.Windows.Forms.Label();
            lblNameProd = new System.Windows.Forms.Label();
            lblAmountProd = new System.Windows.Forms.Label();
            lblBarcodeProd = new System.Windows.Forms.Label();
            lblCategoryProd = new System.Windows.Forms.Label();
            lblLDDProd = new System.Windows.Forms.Label();
            lblFDDProd = new System.Windows.Forms.Label();
            lblSalePriceProd = new System.Windows.Forms.Label();
            lblProvIdProd = new System.Windows.Forms.Label();
            lblIdProc = new System.Windows.Forms.Label();
            lblCostProc = new System.Windows.Forms.Label();
            lblDateProc = new System.Windows.Forms.Label();
            lblClientIdProc = new System.Windows.Forms.Label();
            lblDescProc = new System.Windows.Forms.Label();
            lblAmountProc = new System.Windows.Forms.Label();
            lblIdInv = new System.Windows.Forms.Label();
            lblNameInv = new System.Windows.Forms.Label();
            lblTypeInv = new System.Windows.Forms.Label();
            lblBrandInv = new System.Windows.Forms.Label();
            lblAmountInv = new System.Windows.Forms.Label();
            lblDelDateInv = new System.Windows.Forms.Label();
            lblRepairsInv = new System.Windows.Forms.Label();
            lblExpDateInv = new System.Windows.Forms.Label();
            lblChangeDateInv = new System.Windows.Forms.Label();
            lblDelPriceInv = new System.Windows.Forms.Label();
            lblProvIdInv = new System.Windows.Forms.Label();
            lblIdSal = new System.Windows.Forms.Label();
            lblWorkerIdSal = new System.Windows.Forms.Label();
            lblDateSal = new System.Windows.Forms.Label();
            lblSalarySal = new System.Windows.Forms.Label();
            lblBonusSal = new System.Windows.Forms.Label();
            lblIdProv = new System.Windows.Forms.Label();
            lblCompNameProv = new System.Windows.Forms.Label();
            lblAddrProv = new System.Windows.Forms.Label();
            lblEmailProv = new System.Windows.Forms.Label();
            lblPhoneProv = new System.Windows.Forms.Label();
            lblAPNProv = new System.Windows.Forms.Label();
            lblAPPINProv = new System.Windows.Forms.Label();
            lblIdSup = new System.Windows.Forms.Label();
            lblNameSup = new System.Windows.Forms.Label();
            lblProviderIdSup = new System.Windows.Forms.Label();
            lblDateSup = new System.Windows.Forms.Label();
            lblDelPriceSup = new System.Windows.Forms.Label();
            lblSalePriceSup = new System.Windows.Forms.Label();
            lblAmountSup = new System.Windows.Forms.Label();
            lblIdSub = new System.Windows.Forms.Label();
            lblNameSub = new System.Windows.Forms.Label();
            lblPriceSub = new System.Windows.Forms.Label();
            lblDurationSub = new System.Windows.Forms.Label();
            lblVisitsSub = new System.Windows.Forms.Label();
            lblIdWS = new System.Windows.Forms.Label();
            lblWorkerIdWS = new System.Windows.Forms.Label();
            lblShiftWS = new System.Windows.Forms.Label();
            lblWorkTimeWS = new System.Windows.Forms.Label();
            lblDateWS = new System.Windows.Forms.Label();
            lblIdWO = new System.Windows.Forms.Label();
            lblCoachIdWO = new System.Windows.Forms.Label();
            lblClientIdWO = new System.Windows.Forms.Label();
            lblDateWO = new System.Windows.Forms.Label();
            lblStartWO = new System.Windows.Forms.Label();
            lblEndWO = new System.Windows.Forms.Label();
            lblPriceWO = new System.Windows.Forms.Label();
            lblIdW = new System.Windows.Forms.Label();
            lblUsername = new System.Windows.Forms.Label();
            lblPass = new System.Windows.Forms.Label();
            lblFirstNameW = new System.Windows.Forms.Label();
            lblLastNameW = new System.Windows.Forms.Label();
            lblPINW = new System.Windows.Forms.Label();
            lblFirstDayW = new System.Windows.Forms.Label();
            lblSalaryW = new System.Windows.Forms.Label();
            lblRoleW = new System.Windows.Forms.Label();
            lblEmailW = new System.Windows.Forms.Label();
            lblPhoneW = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gymDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingNavigator)).BeginInit();
            this.tableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expensesBindingSource)).BeginInit();
            this.gbExpenses.SuspendLayout();
            this.gbClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proceedsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.gbProducts.SuspendLayout();
            this.gbProceeds.SuspendLayout();
            this.gbInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salariesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscriptionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workoutsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workSchedulesBindingSource)).BeginInit();
            this.gbSalaries.SuspendLayout();
            this.gbProviders.SuspendLayout();
            this.gbSupplies.SuspendLayout();
            this.gbSubscriptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVisitsSub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDurationSub)).BeginInit();
            this.gbWorkSchedules.SuspendLayout();
            this.gbWorkouts.SuspendLayout();
            this.gbWorkers.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIdE
            // 
            lblIdE.AutoSize = true;
            lblIdE.Location = new System.Drawing.Point(61, 21);
            lblIdE.Name = "lblIdE";
            lblIdE.Size = new System.Drawing.Size(23, 13);
            lblIdE.TabIndex = 0;
            lblIdE.Text = "Id*:";
            // 
            // lblCostE
            // 
            lblCostE.AutoSize = true;
            lblCostE.Location = new System.Drawing.Point(44, 48);
            lblCostE.Name = "lblCostE";
            lblCostE.Size = new System.Drawing.Size(40, 13);
            lblCostE.TabIndex = 2;
            lblCostE.Text = "Цена*:";
            // 
            // lblDateE
            // 
            lblDateE.AutoSize = true;
            lblDateE.Location = new System.Drawing.Point(44, 75);
            lblDateE.Name = "lblDateE";
            lblDateE.Size = new System.Drawing.Size(40, 13);
            lblDateE.TabIndex = 4;
            lblDateE.Text = "Дата*:";
            // 
            // lblSupplyIdE
            // 
            lblSupplyIdE.AutoSize = true;
            lblSupplyIdE.Location = new System.Drawing.Point(13, 100);
            lblSupplyIdE.Name = "lblSupplyIdE";
            lblSupplyIdE.Size = new System.Drawing.Size(71, 13);
            lblSupplyIdE.TabIndex = 6;
            lblSupplyIdE.Text = "№ доставка:";
            // 
            // lblSalaryIdE
            // 
            lblSalaryIdE.AutoSize = true;
            lblSalaryIdE.Location = new System.Drawing.Point(19, 126);
            lblSalaryIdE.Name = "lblSalaryIdE";
            lblSalaryIdE.Size = new System.Drawing.Size(65, 13);
            lblSalaryIdE.TabIndex = 8;
            lblSalaryIdE.Text = "№ заплата:";
            // 
            // lblDescriptE
            // 
            lblDescriptE.AutoSize = true;
            lblDescriptE.Location = new System.Drawing.Point(20, 152);
            lblDescriptE.Name = "lblDescriptE";
            lblDescriptE.Size = new System.Drawing.Size(64, 13);
            lblDescriptE.TabIndex = 10;
            lblDescriptE.Text = "Описание*:";
            // 
            // lblAmountE
            // 
            lblAmountE.AutoSize = true;
            lblAmountE.Location = new System.Drawing.Point(15, 178);
            lblAmountE.Name = "lblAmountE";
            lblAmountE.Size = new System.Drawing.Size(69, 13);
            lblAmountE.TabIndex = 12;
            lblAmountE.Text = "Количество:";
            // 
            // lblIdC
            // 
            lblIdC.AutoSize = true;
            lblIdC.Location = new System.Drawing.Point(98, 14);
            lblIdC.Name = "lblIdC";
            lblIdC.Size = new System.Drawing.Size(23, 13);
            lblIdC.TabIndex = 0;
            lblIdC.Text = "Id*:";
            // 
            // lblFirstNameC
            // 
            lblFirstNameC.AutoSize = true;
            lblFirstNameC.Location = new System.Drawing.Point(85, 40);
            lblFirstNameC.Name = "lblFirstNameC";
            lblFirstNameC.Size = new System.Drawing.Size(36, 13);
            lblFirstNameC.TabIndex = 2;
            lblFirstNameC.Text = "Име*:";
            // 
            // lblLastNameC
            // 
            lblLastNameC.AutoSize = true;
            lblLastNameC.Location = new System.Drawing.Point(58, 66);
            lblLastNameC.Name = "lblLastNameC";
            lblLastNameC.Size = new System.Drawing.Size(63, 13);
            lblLastNameC.TabIndex = 4;
            lblLastNameC.Text = "Фамилия*:";
            // 
            // lblSubFromC
            // 
            lblSubFromC.AutoSize = true;
            lblSubFromC.Location = new System.Drawing.Point(37, 92);
            lblSubFromC.Name = "lblSubFromC";
            lblSubFromC.Size = new System.Drawing.Size(84, 13);
            lblSubFromC.TabIndex = 6;
            lblSubFromC.Text = "Абонамент от*:";
            // 
            // lblSubToC
            // 
            lblSubToC.AutoSize = true;
            lblSubToC.Location = new System.Drawing.Point(36, 118);
            lblSubToC.Name = "lblSubToC";
            lblSubToC.Size = new System.Drawing.Size(85, 13);
            lblSubToC.TabIndex = 8;
            lblSubToC.Text = "Абонамент до*:";
            // 
            // lblAddedAtC
            // 
            lblAddedAtC.AutoSize = true;
            lblAddedAtC.Location = new System.Drawing.Point(47, 170);
            lblAddedAtC.Name = "lblAddedAtC";
            lblAddedAtC.Size = new System.Drawing.Size(74, 13);
            lblAddedAtC.TabIndex = 12;
            lblAddedAtC.Text = "Добавен на*:";
            // 
            // lblRenewsC
            // 
            lblRenewsC.AutoSize = true;
            lblRenewsC.Location = new System.Drawing.Point(7, 196);
            lblRenewsC.Name = "lblRenewsC";
            lblRenewsC.Size = new System.Drawing.Size(114, 13);
            lblRenewsC.TabIndex = 14;
            lblRenewsC.Text = "Брой подновявания*:";
            // 
            // lblEmailC
            // 
            lblEmailC.AutoSize = true;
            lblEmailC.Location = new System.Drawing.Point(65, 222);
            lblEmailC.Name = "lblEmailC";
            lblEmailC.Size = new System.Drawing.Size(56, 13);
            lblEmailC.TabIndex = 16;
            lblEmailC.Text = "Ел. поща:";
            // 
            // lblPhoneC
            // 
            lblPhoneC.AutoSize = true;
            lblPhoneC.Location = new System.Drawing.Point(54, 248);
            lblPhoneC.Name = "lblPhoneC";
            lblPhoneC.Size = new System.Drawing.Size(67, 13);
            lblPhoneC.TabIndex = 18;
            lblPhoneC.Text = "Тел. номер:";
            // 
            // lblCoachIdC
            // 
            lblCoachIdC.AutoSize = true;
            lblCoachIdC.Location = new System.Drawing.Point(40, 274);
            lblCoachIdC.Name = "lblCoachIdC";
            lblCoachIdC.Size = new System.Drawing.Size(81, 13);
            lblCoachIdC.TabIndex = 20;
            lblCoachIdC.Text = "№ инструктор:";
            // 
            // lblBonusC
            // 
            lblBonusC.AutoSize = true;
            lblBonusC.Location = new System.Drawing.Point(77, 300);
            lblBonusC.Name = "lblBonusC";
            lblBonusC.Size = new System.Drawing.Size(44, 13);
            lblBonusC.TabIndex = 22;
            lblBonusC.Text = "Бонус*:";
            // 
            // lblIdProd
            // 
            lblIdProd.AutoSize = true;
            lblIdProd.Location = new System.Drawing.Point(93, 19);
            lblIdProd.Name = "lblIdProd";
            lblIdProd.Size = new System.Drawing.Size(23, 13);
            lblIdProd.TabIndex = 0;
            lblIdProd.Text = "Id*:";
            // 
            // lblNameProd
            // 
            lblNameProd.AutoSize = true;
            lblNameProd.Location = new System.Drawing.Point(80, 44);
            lblNameProd.Name = "lblNameProd";
            lblNameProd.Size = new System.Drawing.Size(36, 13);
            lblNameProd.TabIndex = 2;
            lblNameProd.Text = "Име*:";
            // 
            // lblAmountProd
            // 
            lblAmountProd.AutoSize = true;
            lblAmountProd.Location = new System.Drawing.Point(43, 69);
            lblAmountProd.Name = "lblAmountProd";
            lblAmountProd.Size = new System.Drawing.Size(73, 13);
            lblAmountProd.TabIndex = 4;
            lblAmountProd.Text = "Количество*:";
            // 
            // lblBarcodeProd
            // 
            lblBarcodeProd.AutoSize = true;
            lblBarcodeProd.Location = new System.Drawing.Point(69, 94);
            lblBarcodeProd.Name = "lblBarcodeProd";
            lblBarcodeProd.Size = new System.Drawing.Size(47, 13);
            lblBarcodeProd.TabIndex = 6;
            lblBarcodeProd.Text = "Баркод:";
            // 
            // lblCategoryProd
            // 
            lblCategoryProd.AutoSize = true;
            lblCategoryProd.Location = new System.Drawing.Point(49, 119);
            lblCategoryProd.Name = "lblCategoryProd";
            lblCategoryProd.Size = new System.Drawing.Size(67, 13);
            lblCategoryProd.TabIndex = 8;
            lblCategoryProd.Text = "Категория*:";
            // 
            // lblLDDProd
            // 
            lblLDDProd.AutoSize = true;
            lblLDDProd.Location = new System.Drawing.Point(2, 144);
            lblLDDProd.Name = "lblLDDProd";
            lblLDDProd.Size = new System.Drawing.Size(114, 13);
            lblLDDProd.TabIndex = 10;
            lblLDDProd.Text = "Последна доставка*:";
            // 
            // lblFDDProd
            // 
            lblFDDProd.AutoSize = true;
            lblFDDProd.Location = new System.Drawing.Point(11, 169);
            lblFDDProd.Name = "lblFDDProd";
            lblFDDProd.Size = new System.Drawing.Size(105, 13);
            lblFDDProd.TabIndex = 12;
            lblFDDProd.Text = "Бъдеща доставка*:";
            // 
            // lblSalePriceProd
            // 
            lblSalePriceProd.AutoSize = true;
            lblSalePriceProd.Location = new System.Drawing.Point(23, 194);
            lblSalePriceProd.Name = "lblSalePriceProd";
            lblSalePriceProd.Size = new System.Drawing.Size(93, 13);
            lblSalePriceProd.TabIndex = 14;
            lblSalePriceProd.Text = "Продажна цена*:";
            // 
            // lblProvIdProd
            // 
            lblProvIdProd.AutoSize = true;
            lblProvIdProd.Location = new System.Drawing.Point(36, 219);
            lblProvIdProd.Name = "lblProvIdProd";
            lblProvIdProd.Size = new System.Drawing.Size(80, 13);
            lblProvIdProd.TabIndex = 16;
            lblProvIdProd.Text = "№ доставчик*:";
            // 
            // lblIdProc
            // 
            lblIdProc.AutoSize = true;
            lblIdProc.Location = new System.Drawing.Point(54, 20);
            lblIdProc.Name = "lblIdProc";
            lblIdProc.Size = new System.Drawing.Size(23, 13);
            lblIdProc.TabIndex = 0;
            lblIdProc.Text = "Id*:";
            // 
            // lblCostProc
            // 
            lblCostProc.AutoSize = true;
            lblCostProc.Location = new System.Drawing.Point(37, 46);
            lblCostProc.Name = "lblCostProc";
            lblCostProc.Size = new System.Drawing.Size(40, 13);
            lblCostProc.TabIndex = 2;
            lblCostProc.Text = "Цена*:";
            // 
            // lblDateProc
            // 
            lblDateProc.AutoSize = true;
            lblDateProc.Location = new System.Drawing.Point(37, 72);
            lblDateProc.Name = "lblDateProc";
            lblDateProc.Size = new System.Drawing.Size(40, 13);
            lblDateProc.TabIndex = 4;
            lblDateProc.Text = "Дата*:";
            // 
            // lblClientIdProc
            // 
            lblClientIdProc.AutoSize = true;
            lblClientIdProc.Location = new System.Drawing.Point(14, 98);
            lblClientIdProc.Name = "lblClientIdProc";
            lblClientIdProc.Size = new System.Drawing.Size(63, 13);
            lblClientIdProc.TabIndex = 6;
            lblClientIdProc.Text = "№ клиент*:";
            // 
            // lblDescProc
            // 
            lblDescProc.AutoSize = true;
            lblDescProc.Location = new System.Drawing.Point(13, 124);
            lblDescProc.Name = "lblDescProc";
            lblDescProc.Size = new System.Drawing.Size(64, 13);
            lblDescProc.TabIndex = 8;
            lblDescProc.Text = "Описание*:";
            // 
            // lblAmountProc
            // 
            lblAmountProc.AutoSize = true;
            lblAmountProc.Location = new System.Drawing.Point(8, 150);
            lblAmountProc.Name = "lblAmountProc";
            lblAmountProc.Size = new System.Drawing.Size(69, 13);
            lblAmountProc.TabIndex = 10;
            lblAmountProc.Text = "Количество:";
            // 
            // lblIdInv
            // 
            lblIdInv.AutoSize = true;
            lblIdInv.Location = new System.Drawing.Point(85, 16);
            lblIdInv.Name = "lblIdInv";
            lblIdInv.Size = new System.Drawing.Size(23, 13);
            lblIdInv.TabIndex = 0;
            lblIdInv.Text = "Id*:";
            // 
            // lblNameInv
            // 
            lblNameInv.AutoSize = true;
            lblNameInv.Location = new System.Drawing.Point(72, 42);
            lblNameInv.Name = "lblNameInv";
            lblNameInv.Size = new System.Drawing.Size(36, 13);
            lblNameInv.TabIndex = 2;
            lblNameInv.Text = "Име*:";
            // 
            // lblTypeInv
            // 
            lblTypeInv.AutoSize = true;
            lblTypeInv.Location = new System.Drawing.Point(75, 68);
            lblTypeInv.Name = "lblTypeInv";
            lblTypeInv.Size = new System.Drawing.Size(33, 13);
            lblTypeInv.TabIndex = 4;
            lblTypeInv.Text = "Тип*:";
            // 
            // lblBrandInv
            // 
            lblBrandInv.AutoSize = true;
            lblBrandInv.Location = new System.Drawing.Point(65, 94);
            lblBrandInv.Name = "lblBrandInv";
            lblBrandInv.Size = new System.Drawing.Size(43, 13);
            lblBrandInv.TabIndex = 6;
            lblBrandInv.Text = "Марка:";
            // 
            // lblAmountInv
            // 
            lblAmountInv.AutoSize = true;
            lblAmountInv.Location = new System.Drawing.Point(35, 120);
            lblAmountInv.Name = "lblAmountInv";
            lblAmountInv.Size = new System.Drawing.Size(73, 13);
            lblAmountInv.TabIndex = 8;
            lblAmountInv.Text = "Количество*:";
            // 
            // lblDelDateInv
            // 
            lblDelDateInv.AutoSize = true;
            lblDelDateInv.Location = new System.Drawing.Point(27, 146);
            lblDelDateInv.Name = "lblDelDateInv";
            lblDelDateInv.Size = new System.Drawing.Size(81, 13);
            lblDelDateInv.TabIndex = 10;
            lblDelDateInv.Text = "Доставено на:";
            // 
            // lblRepairsInv
            // 
            lblRepairsInv.AutoSize = true;
            lblRepairsInv.Location = new System.Drawing.Point(27, 172);
            lblRepairsInv.Name = "lblRepairsInv";
            lblRepairsInv.Size = new System.Drawing.Size(81, 13);
            lblRepairsInv.TabIndex = 12;
            lblRepairsInv.Text = "Брой ремонти:";
            // 
            // lblExpDateInv
            // 
            lblExpDateInv.AutoSize = true;
            lblExpDateInv.Location = new System.Drawing.Point(53, 198);
            lblExpDateInv.Name = "lblExpDateInv";
            lblExpDateInv.Size = new System.Drawing.Size(55, 13);
            lblExpDateInv.TabIndex = 14;
            lblExpDateInv.Text = "Годно до:";
            // 
            // lblChangeDateInv
            // 
            lblChangeDateInv.AutoSize = true;
            lblChangeDateInv.Location = new System.Drawing.Point(8, 224);
            lblChangeDateInv.Name = "lblChangeDateInv";
            lblChangeDateInv.Size = new System.Drawing.Size(100, 13);
            lblChangeDateInv.TabIndex = 16;
            lblChangeDateInv.Text = "Планувана смяна:";
            // 
            // lblDelPriceInv
            // 
            lblDelPriceInv.AutoSize = true;
            lblDelPriceInv.Location = new System.Drawing.Point(17, 250);
            lblDelPriceInv.Name = "lblDelPriceInv";
            lblDelPriceInv.Size = new System.Drawing.Size(91, 13);
            lblDelPriceInv.TabIndex = 18;
            lblDelPriceInv.Text = "Доставна цена*:";
            // 
            // lblProvIdInv
            // 
            lblProvIdInv.AutoSize = true;
            lblProvIdInv.Location = new System.Drawing.Point(32, 276);
            lblProvIdInv.Name = "lblProvIdInv";
            lblProvIdInv.Size = new System.Drawing.Size(76, 13);
            lblProvIdInv.TabIndex = 20;
            lblProvIdInv.Text = "№ доставчик:";
            // 
            // lblIdSal
            // 
            lblIdSal.AutoSize = true;
            lblIdSal.Location = new System.Drawing.Point(60, 19);
            lblIdSal.Name = "lblIdSal";
            lblIdSal.Size = new System.Drawing.Size(23, 13);
            lblIdSal.TabIndex = 0;
            lblIdSal.Text = "Id*:";
            // 
            // lblWorkerIdSal
            // 
            lblWorkerIdSal.AutoSize = true;
            lblWorkerIdSal.Location = new System.Drawing.Point(7, 45);
            lblWorkerIdSal.Name = "lblWorkerIdSal";
            lblWorkerIdSal.Size = new System.Drawing.Size(76, 13);
            lblWorkerIdSal.TabIndex = 2;
            lblWorkerIdSal.Text = "№ служител*:";
            // 
            // lblDateSal
            // 
            lblDateSal.AutoSize = true;
            lblDateSal.Location = new System.Drawing.Point(43, 71);
            lblDateSal.Name = "lblDateSal";
            lblDateSal.Size = new System.Drawing.Size(40, 13);
            lblDateSal.TabIndex = 4;
            lblDateSal.Text = "Дата*:";
            // 
            // lblSalarySal
            // 
            lblSalarySal.AutoSize = true;
            lblSalarySal.Location = new System.Drawing.Point(27, 97);
            lblSalarySal.Name = "lblSalarySal";
            lblSalarySal.Size = new System.Drawing.Size(56, 13);
            lblSalarySal.TabIndex = 6;
            lblSalarySal.Text = "Заплата*:";
            // 
            // lblBonusSal
            // 
            lblBonusSal.AutoSize = true;
            lblBonusSal.Location = new System.Drawing.Point(43, 123);
            lblBonusSal.Name = "lblBonusSal";
            lblBonusSal.Size = new System.Drawing.Size(40, 13);
            lblBonusSal.TabIndex = 8;
            lblBonusSal.Text = "Бонус:";
            // 
            // lblIdProv
            // 
            lblIdProv.AutoSize = true;
            lblIdProv.Location = new System.Drawing.Point(72, 25);
            lblIdProv.Name = "lblIdProv";
            lblIdProv.Size = new System.Drawing.Size(23, 13);
            lblIdProv.TabIndex = 0;
            lblIdProv.Text = "Id*:";
            // 
            // lblCompNameProv
            // 
            lblCompNameProv.AutoSize = true;
            lblCompNameProv.Location = new System.Drawing.Point(7, 50);
            lblCompNameProv.Name = "lblCompNameProv";
            lblCompNameProv.Size = new System.Drawing.Size(88, 13);
            lblCompNameProv.TabIndex = 2;
            lblCompNameProv.Text = "Име на фирма*:";
            // 
            // lblAddrProv
            // 
            lblAddrProv.AutoSize = true;
            lblAddrProv.Location = new System.Drawing.Point(50, 75);
            lblAddrProv.Name = "lblAddrProv";
            lblAddrProv.Size = new System.Drawing.Size(45, 13);
            lblAddrProv.TabIndex = 4;
            lblAddrProv.Text = "Адрес*:";
            // 
            // lblEmailProv
            // 
            lblEmailProv.AutoSize = true;
            lblEmailProv.Location = new System.Drawing.Point(35, 100);
            lblEmailProv.Name = "lblEmailProv";
            lblEmailProv.Size = new System.Drawing.Size(60, 13);
            lblEmailProv.TabIndex = 6;
            lblEmailProv.Text = "Ел. поща*:";
            // 
            // lblPhoneProv
            // 
            lblPhoneProv.AutoSize = true;
            lblPhoneProv.Location = new System.Drawing.Point(24, 125);
            lblPhoneProv.Name = "lblPhoneProv";
            lblPhoneProv.Size = new System.Drawing.Size(71, 13);
            lblPhoneProv.TabIndex = 8;
            lblPhoneProv.Text = "Тел. номер*:";
            // 
            // lblAPNProv
            // 
            lblAPNProv.AutoSize = true;
            lblAPNProv.Location = new System.Drawing.Point(20, 150);
            lblAPNProv.Name = "lblAPNProv";
            lblAPNProv.Size = new System.Drawing.Size(75, 13);
            lblAPNProv.TabIndex = 10;
            lblAPNProv.Text = "Име на МОЛ:";
            // 
            // lblAPPINProv
            // 
            lblAPPINProv.AutoSize = true;
            lblAPPINProv.Location = new System.Drawing.Point(21, 175);
            lblAPPINProv.Name = "lblAPPINProv";
            lblAPPINProv.Size = new System.Drawing.Size(74, 13);
            lblAPPINProv.TabIndex = 12;
            lblAPPINProv.Text = "ЕГН на МОЛ:";
            // 
            // lblIdSup
            // 
            lblIdSup.AutoSize = true;
            lblIdSup.Location = new System.Drawing.Point(72, 25);
            lblIdSup.Name = "lblIdSup";
            lblIdSup.Size = new System.Drawing.Size(23, 13);
            lblIdSup.TabIndex = 0;
            lblIdSup.Text = "Id*:";
            // 
            // lblNameSup
            // 
            lblNameSup.AutoSize = true;
            lblNameSup.Location = new System.Drawing.Point(59, 50);
            lblNameSup.Name = "lblNameSup";
            lblNameSup.Size = new System.Drawing.Size(36, 13);
            lblNameSup.TabIndex = 2;
            lblNameSup.Text = "Име*:";
            // 
            // lblProviderIdSup
            // 
            lblProviderIdSup.AutoSize = true;
            lblProviderIdSup.Location = new System.Drawing.Point(15, 75);
            lblProviderIdSup.Name = "lblProviderIdSup";
            lblProviderIdSup.Size = new System.Drawing.Size(80, 13);
            lblProviderIdSup.TabIndex = 4;
            lblProviderIdSup.Text = "№ доставчик*:";
            // 
            // lblDateSup
            // 
            lblDateSup.AutoSize = true;
            lblDateSup.Location = new System.Drawing.Point(55, 100);
            lblDateSup.Name = "lblDateSup";
            lblDateSup.Size = new System.Drawing.Size(40, 13);
            lblDateSup.TabIndex = 6;
            lblDateSup.Text = "Дата*:";
            // 
            // lblDelPriceSup
            // 
            lblDelPriceSup.AutoSize = true;
            lblDelPriceSup.Location = new System.Drawing.Point(4, 125);
            lblDelPriceSup.Name = "lblDelPriceSup";
            lblDelPriceSup.Size = new System.Drawing.Size(91, 13);
            lblDelPriceSup.TabIndex = 8;
            lblDelPriceSup.Text = "Доставна цена*:";
            // 
            // lblSalePriceSup
            // 
            lblSalePriceSup.AutoSize = true;
            lblSalePriceSup.Location = new System.Drawing.Point(6, 150);
            lblSalePriceSup.Name = "lblSalePriceSup";
            lblSalePriceSup.Size = new System.Drawing.Size(89, 13);
            lblSalePriceSup.TabIndex = 10;
            lblSalePriceSup.Text = "Продажна цена:";
            // 
            // lblAmountSup
            // 
            lblAmountSup.AutoSize = true;
            lblAmountSup.Location = new System.Drawing.Point(22, 175);
            lblAmountSup.Name = "lblAmountSup";
            lblAmountSup.Size = new System.Drawing.Size(73, 13);
            lblAmountSup.TabIndex = 12;
            lblAmountSup.Text = "Количество*:";
            // 
            // lblIdSub
            // 
            lblIdSub.AutoSize = true;
            lblIdSub.Location = new System.Drawing.Point(95, 21);
            lblIdSub.Name = "lblIdSub";
            lblIdSub.Size = new System.Drawing.Size(23, 13);
            lblIdSub.TabIndex = 0;
            lblIdSub.Text = "Id*:";
            // 
            // lblNameSub
            // 
            lblNameSub.AutoSize = true;
            lblNameSub.Location = new System.Drawing.Point(82, 47);
            lblNameSub.Name = "lblNameSub";
            lblNameSub.Size = new System.Drawing.Size(36, 13);
            lblNameSub.TabIndex = 2;
            lblNameSub.Text = "Име*:";
            // 
            // lblPriceSub
            // 
            lblPriceSub.AutoSize = true;
            lblPriceSub.Location = new System.Drawing.Point(78, 73);
            lblPriceSub.Name = "lblPriceSub";
            lblPriceSub.Size = new System.Drawing.Size(40, 13);
            lblPriceSub.TabIndex = 4;
            lblPriceSub.Text = "Цена*:";
            // 
            // lblDurationSub
            // 
            lblDurationSub.AutoSize = true;
            lblDurationSub.Location = new System.Drawing.Point(4, 99);
            lblDurationSub.Name = "lblDurationSub";
            lblDurationSub.Size = new System.Drawing.Size(114, 13);
            lblDurationSub.TabIndex = 6;
            lblDurationSub.Text = "Месеци /продълж./*:";
            // 
            // lblVisitsSub
            // 
            lblVisitsSub.AutoSize = true;
            lblVisitsSub.Location = new System.Drawing.Point(45, 125);
            lblVisitsSub.Name = "lblVisitsSub";
            lblVisitsSub.Size = new System.Drawing.Size(73, 13);
            lblVisitsSub.TabIndex = 8;
            lblVisitsSub.Text = "Посещения*:";
            // 
            // lblIdWS
            // 
            lblIdWS.AutoSize = true;
            lblIdWS.Location = new System.Drawing.Point(70, 23);
            lblIdWS.Name = "lblIdWS";
            lblIdWS.Size = new System.Drawing.Size(23, 13);
            lblIdWS.TabIndex = 0;
            lblIdWS.Text = "Id*:";
            // 
            // lblWorkerIdWS
            // 
            lblWorkerIdWS.AutoSize = true;
            lblWorkerIdWS.Location = new System.Drawing.Point(17, 49);
            lblWorkerIdWS.Name = "lblWorkerIdWS";
            lblWorkerIdWS.Size = new System.Drawing.Size(76, 13);
            lblWorkerIdWS.TabIndex = 2;
            lblWorkerIdWS.Text = "№ служител*:";
            // 
            // lblShiftWS
            // 
            lblShiftWS.AutoSize = true;
            lblShiftWS.Location = new System.Drawing.Point(46, 75);
            lblShiftWS.Name = "lblShiftWS";
            lblShiftWS.Size = new System.Drawing.Size(47, 13);
            lblShiftWS.TabIndex = 4;
            lblShiftWS.Text = "Смяна*:";
            // 
            // lblWorkTimeWS
            // 
            lblWorkTimeWS.AutoSize = true;
            lblWorkTimeWS.Location = new System.Drawing.Point(2, 101);
            lblWorkTimeWS.Name = "lblWorkTimeWS";
            lblWorkTimeWS.Size = new System.Drawing.Size(91, 13);
            lblWorkTimeWS.TabIndex = 6;
            lblWorkTimeWS.Text = "Работно време*:";
            // 
            // lblDateWS
            // 
            lblDateWS.AutoSize = true;
            lblDateWS.Location = new System.Drawing.Point(53, 127);
            lblDateWS.Name = "lblDateWS";
            lblDateWS.Size = new System.Drawing.Size(40, 13);
            lblDateWS.TabIndex = 8;
            lblDateWS.Text = "Дата*:";
            // 
            // lblIdWO
            // 
            lblIdWO.AutoSize = true;
            lblIdWO.Location = new System.Drawing.Point(64, 21);
            lblIdWO.Name = "lblIdWO";
            lblIdWO.Size = new System.Drawing.Size(23, 13);
            lblIdWO.TabIndex = 0;
            lblIdWO.Text = "Id*:";
            // 
            // lblCoachIdWO
            // 
            lblCoachIdWO.AutoSize = true;
            lblCoachIdWO.Location = new System.Drawing.Point(6, 46);
            lblCoachIdWO.Name = "lblCoachIdWO";
            lblCoachIdWO.Size = new System.Drawing.Size(81, 13);
            lblCoachIdWO.TabIndex = 2;
            lblCoachIdWO.Text = "№ инструктор:";
            // 
            // lblClientIdWO
            // 
            lblClientIdWO.AutoSize = true;
            lblClientIdWO.Location = new System.Drawing.Point(24, 71);
            lblClientIdWO.Name = "lblClientIdWO";
            lblClientIdWO.Size = new System.Drawing.Size(63, 13);
            lblClientIdWO.TabIndex = 4;
            lblClientIdWO.Text = "№ клиент*:";
            // 
            // lblDateWO
            // 
            lblDateWO.AutoSize = true;
            lblDateWO.Location = new System.Drawing.Point(47, 96);
            lblDateWO.Name = "lblDateWO";
            lblDateWO.Size = new System.Drawing.Size(40, 13);
            lblDateWO.TabIndex = 6;
            lblDateWO.Text = "Дата*:";
            // 
            // lblStartWO
            // 
            lblStartWO.AutoSize = true;
            lblStartWO.Location = new System.Drawing.Point(40, 121);
            lblStartWO.Name = "lblStartWO";
            lblStartWO.Size = new System.Drawing.Size(47, 13);
            lblStartWO.TabIndex = 8;
            lblStartWO.Text = "Начало:";
            // 
            // lblEndWO
            // 
            lblEndWO.AutoSize = true;
            lblEndWO.Location = new System.Drawing.Point(52, 146);
            lblEndWO.Name = "lblEndWO";
            lblEndWO.Size = new System.Drawing.Size(35, 13);
            lblEndWO.TabIndex = 10;
            lblEndWO.Text = "Край:";
            // 
            // lblPriceWO
            // 
            lblPriceWO.AutoSize = true;
            lblPriceWO.Location = new System.Drawing.Point(51, 171);
            lblPriceWO.Name = "lblPriceWO";
            lblPriceWO.Size = new System.Drawing.Size(36, 13);
            lblPriceWO.TabIndex = 12;
            lblPriceWO.Text = "Цена:";
            // 
            // lblIdW
            // 
            lblIdW.AutoSize = true;
            lblIdW.Location = new System.Drawing.Point(55, 23);
            lblIdW.Name = "lblIdW";
            lblIdW.Size = new System.Drawing.Size(23, 13);
            lblIdW.TabIndex = 0;
            lblIdW.Text = "Id*:";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new System.Drawing.Point(13, 101);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new System.Drawing.Size(65, 13);
            lblUsername.TabIndex = 6;
            lblUsername.Text = "Потр. име*:";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new System.Drawing.Point(26, 127);
            lblPass.Name = "lblPass";
            lblPass.Size = new System.Drawing.Size(52, 13);
            lblPass.TabIndex = 8;
            lblPass.Text = "Парола*:";
            // 
            // lblFirstNameW
            // 
            lblFirstNameW.AutoSize = true;
            lblFirstNameW.Location = new System.Drawing.Point(42, 49);
            lblFirstNameW.Name = "lblFirstNameW";
            lblFirstNameW.Size = new System.Drawing.Size(36, 13);
            lblFirstNameW.TabIndex = 2;
            lblFirstNameW.Text = "Име*:";
            // 
            // lblLastNameW
            // 
            lblLastNameW.AutoSize = true;
            lblLastNameW.Location = new System.Drawing.Point(15, 75);
            lblLastNameW.Name = "lblLastNameW";
            lblLastNameW.Size = new System.Drawing.Size(63, 13);
            lblLastNameW.TabIndex = 4;
            lblLastNameW.Text = "Фамилия*:";
            // 
            // lblPINW
            // 
            lblPINW.AutoSize = true;
            lblPINW.Location = new System.Drawing.Point(43, 153);
            lblPINW.Name = "lblPINW";
            lblPINW.Size = new System.Drawing.Size(35, 13);
            lblPINW.TabIndex = 10;
            lblPINW.Text = "ЕГН*:";
            // 
            // lblFirstDayW
            // 
            lblFirstDayW.AutoSize = true;
            lblFirstDayW.Location = new System.Drawing.Point(4, 179);
            lblFirstDayW.Name = "lblFirstDayW";
            lblFirstDayW.Size = new System.Drawing.Size(74, 13);
            lblFirstDayW.TabIndex = 12;
            lblFirstDayW.Text = "Добавен на*:";
            // 
            // lblSalaryW
            // 
            lblSalaryW.AutoSize = true;
            lblSalaryW.Location = new System.Drawing.Point(22, 205);
            lblSalaryW.Name = "lblSalaryW";
            lblSalaryW.Size = new System.Drawing.Size(56, 13);
            lblSalaryW.TabIndex = 14;
            lblSalaryW.Text = "Заплата*:";
            // 
            // lblRoleW
            // 
            lblRoleW.AutoSize = true;
            lblRoleW.Location = new System.Drawing.Point(11, 231);
            lblRoleW.Name = "lblRoleW";
            lblRoleW.Size = new System.Drawing.Size(67, 13);
            lblRoleW.TabIndex = 16;
            lblRoleW.Text = "Длъжност*:";
            // 
            // lblEmailW
            // 
            lblEmailW.AutoSize = true;
            lblEmailW.Location = new System.Drawing.Point(18, 257);
            lblEmailW.Name = "lblEmailW";
            lblEmailW.Size = new System.Drawing.Size(60, 13);
            lblEmailW.TabIndex = 18;
            lblEmailW.Text = "Ел. поща*:";
            // 
            // lblPhoneW
            // 
            lblPhoneW.AutoSize = true;
            lblPhoneW.Location = new System.Drawing.Point(7, 283);
            lblPhoneW.Name = "lblPhoneW";
            lblPhoneW.Size = new System.Drawing.Size(71, 13);
            lblPhoneW.TabIndex = 20;
            lblPhoneW.Text = "Тел. номер*:";
            // 
            // gymDatabaseDataSet
            // 
            this.gymDatabaseDataSet.DataSetName = "GymDatabaseDataSet";
            this.gymDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.gymDatabaseDataSet;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = this.clientsTableAdapter;
            this.tableAdapterManager.ExpensesTableAdapter = this.expensesTableAdapter;
            this.tableAdapterManager.InventoryTableAdapter = this.inventoryTableAdapter;
            this.tableAdapterManager.ProceedsTableAdapter = this.proceedsTableAdapter;
            this.tableAdapterManager.ProductsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager.ProvidersTableAdapter = this.providersTableAdapter;
            this.tableAdapterManager.SalariesTableAdapter = this.salariesTableAdapter;
            this.tableAdapterManager.SubscriptionsTableAdapter = this.subscriptionsTableAdapter;
            this.tableAdapterManager.SuppliesTableAdapter = this.suppliesTableAdapter;
            this.tableAdapterManager.UpdateOrder = Thesis.GymDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkersTableAdapter = this.workersTableAdapter;
            this.tableAdapterManager.WorkoutsTableAdapter = this.workoutsTableAdapter;
            this.tableAdapterManager.WorkSchedulesTableAdapter = this.workSchedulesTableAdapter;
            // 
            // expensesTableAdapter
            // 
            this.expensesTableAdapter.ClearBeforeFill = true;
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // proceedsTableAdapter
            // 
            this.proceedsTableAdapter.ClearBeforeFill = true;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // providersTableAdapter
            // 
            this.providersTableAdapter.ClearBeforeFill = true;
            // 
            // salariesTableAdapter
            // 
            this.salariesTableAdapter.ClearBeforeFill = true;
            // 
            // subscriptionsTableAdapter
            // 
            this.subscriptionsTableAdapter.ClearBeforeFill = true;
            // 
            // suppliesTableAdapter
            // 
            this.suppliesTableAdapter.ClearBeforeFill = true;
            // 
            // workersTableAdapter
            // 
            this.workersTableAdapter.ClearBeforeFill = true;
            // 
            // workoutsTableAdapter
            // 
            this.workoutsTableAdapter.ClearBeforeFill = true;
            // 
            // workSchedulesTableAdapter
            // 
            this.workSchedulesTableAdapter.ClearBeforeFill = true;
            // 
            // tableBindingNavigator
            // 
            this.tableBindingNavigator.AddNewItem = null;
            this.tableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tableBindingNavigator.CountItemFormat = "от {0}";
            this.tableBindingNavigator.DeleteItem = null;
            this.tableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.tableBindingNavigatorSaveItem,
            this.toolStripSeparator1});
            this.tableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tableBindingNavigator.Name = "tableBindingNavigator";
            this.tableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tableBindingNavigator.Size = new System.Drawing.Size(807, 25);
            this.tableBindingNavigator.TabIndex = 0;
            this.tableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "от {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общ брой записи";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Първи запис";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Предишен запис";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текуща позиция";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Следващ запис";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Последен запис";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tableBindingNavigatorSaveItem
            // 
            this.tableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tableBindingNavigatorSaveItem.Image")));
            this.tableBindingNavigatorSaveItem.Name = "tableBindingNavigatorSaveItem";
            this.tableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tableBindingNavigatorSaveItem.Text = "Запиши данните";
            this.tableBindingNavigatorSaveItem.Click += new System.EventHandler(this.tableBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // expensesBindingSource
            // 
            this.expensesBindingSource.DataMember = "Expenses";
            this.expensesBindingSource.DataSource = this.gymDatabaseDataSet;
            // 
            // gbExpenses
            // 
            this.gbExpenses.Controls.Add(lblIdE);
            this.gbExpenses.Controls.Add(this.txtIdE);
            this.gbExpenses.Controls.Add(lblCostE);
            this.gbExpenses.Controls.Add(this.txtCostE);
            this.gbExpenses.Controls.Add(lblDateE);
            this.gbExpenses.Controls.Add(this.dtpDateE);
            this.gbExpenses.Controls.Add(lblSupplyIdE);
            this.gbExpenses.Controls.Add(this.txtSupplyIdE);
            this.gbExpenses.Controls.Add(lblSalaryIdE);
            this.gbExpenses.Controls.Add(this.txtSalaryIdE);
            this.gbExpenses.Controls.Add(lblDescriptE);
            this.gbExpenses.Controls.Add(this.txtDescriptE);
            this.gbExpenses.Controls.Add(lblAmountE);
            this.gbExpenses.Controls.Add(this.txtAmountE);
            this.gbExpenses.Location = new System.Drawing.Point(257, 151);
            this.gbExpenses.Name = "gbExpenses";
            this.gbExpenses.Size = new System.Drawing.Size(96, 49);
            this.gbExpenses.TabIndex = 49;
            this.gbExpenses.TabStop = false;
            this.gbExpenses.Text = "Разходи";
            // 
            // txtIdE
            // 
            this.txtIdE.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expensesBindingSource, "Id", true));
            this.txtIdE.Enabled = false;
            this.txtIdE.Location = new System.Drawing.Point(84, 18);
            this.txtIdE.Name = "txtIdE";
            this.txtIdE.Size = new System.Drawing.Size(200, 20);
            this.txtIdE.TabIndex = 1;
            // 
            // txtCostE
            // 
            this.txtCostE.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expensesBindingSource, "Cost", true));
            this.txtCostE.Location = new System.Drawing.Point(84, 45);
            this.txtCostE.Name = "txtCostE";
            this.txtCostE.Size = new System.Drawing.Size(200, 20);
            this.txtCostE.TabIndex = 3;
            // 
            // dtpDateE
            // 
            this.dtpDateE.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expensesBindingSource, "Date", true));
            this.dtpDateE.Location = new System.Drawing.Point(84, 71);
            this.dtpDateE.Name = "dtpDateE";
            this.dtpDateE.Size = new System.Drawing.Size(200, 20);
            this.dtpDateE.TabIndex = 5;
            // 
            // txtSupplyIdE
            // 
            this.txtSupplyIdE.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expensesBindingSource, "SupplyId", true));
            this.txtSupplyIdE.Location = new System.Drawing.Point(84, 97);
            this.txtSupplyIdE.Name = "txtSupplyIdE";
            this.txtSupplyIdE.Size = new System.Drawing.Size(200, 20);
            this.txtSupplyIdE.TabIndex = 7;
            this.txtSupplyIdE.DoubleClick += new System.EventHandler(this.txtSupplyIdE_DoubleClick);
            // 
            // txtSalaryIdE
            // 
            this.txtSalaryIdE.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expensesBindingSource, "SalaryId", true));
            this.txtSalaryIdE.Location = new System.Drawing.Point(84, 123);
            this.txtSalaryIdE.Name = "txtSalaryIdE";
            this.txtSalaryIdE.Size = new System.Drawing.Size(200, 20);
            this.txtSalaryIdE.TabIndex = 9;
            this.txtSalaryIdE.DoubleClick += new System.EventHandler(this.txtSalaryIdE_DoubleClick);
            // 
            // txtDescriptE
            // 
            this.txtDescriptE.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expensesBindingSource, "Description", true));
            this.txtDescriptE.Location = new System.Drawing.Point(84, 149);
            this.txtDescriptE.Name = "txtDescriptE";
            this.txtDescriptE.Size = new System.Drawing.Size(200, 20);
            this.txtDescriptE.TabIndex = 11;
            // 
            // txtAmountE
            // 
            this.txtAmountE.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expensesBindingSource, "Amount", true));
            this.txtAmountE.Location = new System.Drawing.Point(84, 175);
            this.txtAmountE.Name = "txtAmountE";
            this.txtAmountE.Size = new System.Drawing.Size(200, 20);
            this.txtAmountE.TabIndex = 13;
            // 
            // gbClients
            // 
            this.gbClients.Controls.Add(lblIdC);
            this.gbClients.Controls.Add(this.txtIdC);
            this.gbClients.Controls.Add(this.txtSubIdC);
            this.gbClients.Controls.Add(this.lblSubIdC);
            this.gbClients.Controls.Add(lblFirstNameC);
            this.gbClients.Controls.Add(this.txtFirstNameC);
            this.gbClients.Controls.Add(lblLastNameC);
            this.gbClients.Controls.Add(this.txtLastNameC);
            this.gbClients.Controls.Add(lblSubFromC);
            this.gbClients.Controls.Add(this.dtpSubFromC);
            this.gbClients.Controls.Add(lblSubToC);
            this.gbClients.Controls.Add(this.dtpSubToC);
            this.gbClients.Controls.Add(lblAddedAtC);
            this.gbClients.Controls.Add(this.dtpAddedAtC);
            this.gbClients.Controls.Add(lblRenewsC);
            this.gbClients.Controls.Add(this.txtRenewsC);
            this.gbClients.Controls.Add(lblEmailC);
            this.gbClients.Controls.Add(this.txtEmailC);
            this.gbClients.Controls.Add(lblPhoneC);
            this.gbClients.Controls.Add(this.txtPhoneC);
            this.gbClients.Controls.Add(lblCoachIdC);
            this.gbClients.Controls.Add(this.txtCoachIdC);
            this.gbClients.Controls.Add(lblBonusC);
            this.gbClients.Controls.Add(this.checkBonusC);
            this.gbClients.Location = new System.Drawing.Point(140, 151);
            this.gbClients.Name = "gbClients";
            this.gbClients.Size = new System.Drawing.Size(97, 49);
            this.gbClients.TabIndex = 48;
            this.gbClients.TabStop = false;
            this.gbClients.Text = "Клиенти";
            // 
            // txtIdC
            // 
            this.txtIdC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "Id", true));
            this.txtIdC.Enabled = false;
            this.txtIdC.Location = new System.Drawing.Point(125, 11);
            this.txtIdC.Name = "txtIdC";
            this.txtIdC.Size = new System.Drawing.Size(200, 20);
            this.txtIdC.TabIndex = 1;
            // 
            // txtSubIdC
            // 
            this.txtSubIdC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "SubId", true));
            this.txtSubIdC.Location = new System.Drawing.Point(125, 141);
            this.txtSubIdC.Name = "txtSubIdC";
            this.txtSubIdC.Size = new System.Drawing.Size(200, 20);
            this.txtSubIdC.TabIndex = 11;
            this.txtSubIdC.DoubleClick += new System.EventHandler(this.txtSubIdC_DoubleClick);
            // 
            // lblSubIdC
            // 
            this.lblSubIdC.AutoSize = true;
            this.lblSubIdC.Location = new System.Drawing.Point(42, 144);
            this.lblSubIdC.Name = "lblSubIdC";
            this.lblSubIdC.Size = new System.Drawing.Size(79, 13);
            this.lblSubIdC.TabIndex = 10;
            this.lblSubIdC.Text = "№ абонамент:";
            // 
            // txtFirstNameC
            // 
            this.txtFirstNameC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "FirstName", true));
            this.txtFirstNameC.Location = new System.Drawing.Point(125, 37);
            this.txtFirstNameC.Name = "txtFirstNameC";
            this.txtFirstNameC.Size = new System.Drawing.Size(200, 20);
            this.txtFirstNameC.TabIndex = 3;
            // 
            // txtLastNameC
            // 
            this.txtLastNameC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "LastName", true));
            this.txtLastNameC.Location = new System.Drawing.Point(125, 63);
            this.txtLastNameC.Name = "txtLastNameC";
            this.txtLastNameC.Size = new System.Drawing.Size(200, 20);
            this.txtLastNameC.TabIndex = 5;
            // 
            // dtpSubFromC
            // 
            this.dtpSubFromC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "SubFrom", true));
            this.dtpSubFromC.Location = new System.Drawing.Point(125, 89);
            this.dtpSubFromC.Name = "dtpSubFromC";
            this.dtpSubFromC.Size = new System.Drawing.Size(200, 20);
            this.dtpSubFromC.TabIndex = 7;
            // 
            // dtpSubToC
            // 
            this.dtpSubToC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "SubTo", true));
            this.dtpSubToC.Location = new System.Drawing.Point(125, 115);
            this.dtpSubToC.Name = "dtpSubToC";
            this.dtpSubToC.Size = new System.Drawing.Size(200, 20);
            this.dtpSubToC.TabIndex = 9;
            // 
            // dtpAddedAtC
            // 
            this.dtpAddedAtC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "AddedAt", true));
            this.dtpAddedAtC.Location = new System.Drawing.Point(125, 167);
            this.dtpAddedAtC.Name = "dtpAddedAtC";
            this.dtpAddedAtC.Size = new System.Drawing.Size(200, 20);
            this.dtpAddedAtC.TabIndex = 13;
            // 
            // txtRenewsC
            // 
            this.txtRenewsC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "NumberRenewings", true));
            this.txtRenewsC.Location = new System.Drawing.Point(125, 193);
            this.txtRenewsC.Name = "txtRenewsC";
            this.txtRenewsC.Size = new System.Drawing.Size(200, 20);
            this.txtRenewsC.TabIndex = 15;
            // 
            // txtEmailC
            // 
            this.txtEmailC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "Email", true));
            this.txtEmailC.Location = new System.Drawing.Point(125, 219);
            this.txtEmailC.Name = "txtEmailC";
            this.txtEmailC.Size = new System.Drawing.Size(200, 20);
            this.txtEmailC.TabIndex = 17;
            // 
            // txtPhoneC
            // 
            this.txtPhoneC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "PhoneNumber", true));
            this.txtPhoneC.Location = new System.Drawing.Point(125, 245);
            this.txtPhoneC.Name = "txtPhoneC";
            this.txtPhoneC.Size = new System.Drawing.Size(200, 20);
            this.txtPhoneC.TabIndex = 19;
            // 
            // txtCoachIdC
            // 
            this.txtCoachIdC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "CoachId", true));
            this.txtCoachIdC.Location = new System.Drawing.Point(125, 271);
            this.txtCoachIdC.Name = "txtCoachIdC";
            this.txtCoachIdC.Size = new System.Drawing.Size(200, 20);
            this.txtCoachIdC.TabIndex = 21;
            this.txtCoachIdC.DoubleClick += new System.EventHandler(this.txtCoachIdC_DoubleClick);
            // 
            // checkBonusC
            // 
            this.checkBonusC.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.clientsBindingSource, "Bonus", true));
            this.checkBonusC.Location = new System.Drawing.Point(125, 297);
            this.checkBonusC.Name = "checkBonusC";
            this.checkBonusC.Size = new System.Drawing.Size(200, 20);
            this.checkBonusC.TabIndex = 23;
            this.checkBonusC.UseVisualStyleBackColor = true;
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "Inventory";
            this.inventoryBindingSource.DataSource = this.gymDatabaseDataSet;
            // 
            // proceedsBindingSource
            // 
            this.proceedsBindingSource.DataMember = "Proceeds";
            this.proceedsBindingSource.DataSource = this.gymDatabaseDataSet;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.gymDatabaseDataSet;
            // 
            // gbProducts
            // 
            this.gbProducts.Controls.Add(lblIdProd);
            this.gbProducts.Controls.Add(this.txtIdProd);
            this.gbProducts.Controls.Add(lblNameProd);
            this.gbProducts.Controls.Add(this.txtNameProd);
            this.gbProducts.Controls.Add(lblAmountProd);
            this.gbProducts.Controls.Add(this.txtAmountProd);
            this.gbProducts.Controls.Add(lblBarcodeProd);
            this.gbProducts.Controls.Add(this.txtBarcodeProd);
            this.gbProducts.Controls.Add(lblCategoryProd);
            this.gbProducts.Controls.Add(this.comboCategoryProd);
            this.gbProducts.Controls.Add(lblLDDProd);
            this.gbProducts.Controls.Add(this.dtpLDDProd);
            this.gbProducts.Controls.Add(lblFDDProd);
            this.gbProducts.Controls.Add(this.dtpFDDProd);
            this.gbProducts.Controls.Add(lblSalePriceProd);
            this.gbProducts.Controls.Add(this.txtSalePriceProd);
            this.gbProducts.Controls.Add(lblProvIdProd);
            this.gbProducts.Controls.Add(this.txtProvIdProd);
            this.gbProducts.Location = new System.Drawing.Point(140, 218);
            this.gbProducts.Name = "gbProducts";
            this.gbProducts.Size = new System.Drawing.Size(97, 42);
            this.gbProducts.TabIndex = 53;
            this.gbProducts.TabStop = false;
            this.gbProducts.Text = "Продукти";
            // 
            // txtIdProd
            // 
            this.txtIdProd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Id", true));
            this.txtIdProd.Enabled = false;
            this.txtIdProd.Location = new System.Drawing.Point(117, 16);
            this.txtIdProd.Name = "txtIdProd";
            this.txtIdProd.Size = new System.Drawing.Size(200, 20);
            this.txtIdProd.TabIndex = 1;
            // 
            // txtNameProd
            // 
            this.txtNameProd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Name", true));
            this.txtNameProd.Location = new System.Drawing.Point(117, 41);
            this.txtNameProd.Name = "txtNameProd";
            this.txtNameProd.Size = new System.Drawing.Size(200, 20);
            this.txtNameProd.TabIndex = 3;
            // 
            // txtAmountProd
            // 
            this.txtAmountProd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Amount", true));
            this.txtAmountProd.Location = new System.Drawing.Point(117, 66);
            this.txtAmountProd.Name = "txtAmountProd";
            this.txtAmountProd.Size = new System.Drawing.Size(200, 20);
            this.txtAmountProd.TabIndex = 5;
            // 
            // txtBarcodeProd
            // 
            this.txtBarcodeProd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Barcode", true));
            this.txtBarcodeProd.Location = new System.Drawing.Point(117, 91);
            this.txtBarcodeProd.Name = "txtBarcodeProd";
            this.txtBarcodeProd.Size = new System.Drawing.Size(200, 20);
            this.txtBarcodeProd.TabIndex = 7;
            // 
            // comboCategoryProd
            // 
            this.comboCategoryProd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Category", true));
            this.comboCategoryProd.FormattingEnabled = true;
            this.comboCategoryProd.Items.AddRange(new object[] {
            "--Избери--",
            "Протеини",
            "Аминокиселини",
            "Витамини",
            "Азотни бустери",
            "Безалкохолни напитки",
            "Протеинови вафли",
            "Други"});
            this.comboCategoryProd.Location = new System.Drawing.Point(117, 116);
            this.comboCategoryProd.Name = "comboCategoryProd";
            this.comboCategoryProd.Size = new System.Drawing.Size(200, 21);
            this.comboCategoryProd.TabIndex = 9;
            // 
            // dtpLDDProd
            // 
            this.dtpLDDProd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "LastDeliveryDate", true));
            this.dtpLDDProd.Location = new System.Drawing.Point(117, 142);
            this.dtpLDDProd.Name = "dtpLDDProd";
            this.dtpLDDProd.Size = new System.Drawing.Size(200, 20);
            this.dtpLDDProd.TabIndex = 11;
            // 
            // dtpFDDProd
            // 
            this.dtpFDDProd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "FutureDeliveryDate", true));
            this.dtpFDDProd.Location = new System.Drawing.Point(117, 167);
            this.dtpFDDProd.Name = "dtpFDDProd";
            this.dtpFDDProd.Size = new System.Drawing.Size(200, 20);
            this.dtpFDDProd.TabIndex = 13;
            // 
            // txtSalePriceProd
            // 
            this.txtSalePriceProd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "SalePrice", true));
            this.txtSalePriceProd.Location = new System.Drawing.Point(117, 192);
            this.txtSalePriceProd.Name = "txtSalePriceProd";
            this.txtSalePriceProd.Size = new System.Drawing.Size(200, 20);
            this.txtSalePriceProd.TabIndex = 15;
            // 
            // txtProvIdProd
            // 
            this.txtProvIdProd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ProviderId", true));
            this.txtProvIdProd.Location = new System.Drawing.Point(117, 217);
            this.txtProvIdProd.Name = "txtProvIdProd";
            this.txtProvIdProd.Size = new System.Drawing.Size(200, 20);
            this.txtProvIdProd.TabIndex = 17;
            this.txtProvIdProd.DoubleClick += new System.EventHandler(this.txtProvIdProd_DoubleClick);
            // 
            // gbProceeds
            // 
            this.gbProceeds.Controls.Add(lblIdProc);
            this.gbProceeds.Controls.Add(this.txtIdProc);
            this.gbProceeds.Controls.Add(lblCostProc);
            this.gbProceeds.Controls.Add(this.txtCostProc);
            this.gbProceeds.Controls.Add(lblDateProc);
            this.gbProceeds.Controls.Add(this.dtpDateProc);
            this.gbProceeds.Controls.Add(lblClientIdProc);
            this.gbProceeds.Controls.Add(this.txtClientIdProc);
            this.gbProceeds.Controls.Add(lblDescProc);
            this.gbProceeds.Controls.Add(this.txtDescProc);
            this.gbProceeds.Controls.Add(lblAmountProc);
            this.gbProceeds.Controls.Add(this.txtAmountProc);
            this.gbProceeds.Location = new System.Drawing.Point(140, 35);
            this.gbProceeds.Name = "gbProceeds";
            this.gbProceeds.Size = new System.Drawing.Size(97, 42);
            this.gbProceeds.TabIndex = 52;
            this.gbProceeds.TabStop = false;
            this.gbProceeds.Text = "Приходи";
            // 
            // txtIdProc
            // 
            this.txtIdProc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proceedsBindingSource, "Id", true));
            this.txtIdProc.Enabled = false;
            this.txtIdProc.Location = new System.Drawing.Point(77, 17);
            this.txtIdProc.Name = "txtIdProc";
            this.txtIdProc.Size = new System.Drawing.Size(200, 20);
            this.txtIdProc.TabIndex = 1;
            // 
            // txtCostProc
            // 
            this.txtCostProc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proceedsBindingSource, "Cost", true));
            this.txtCostProc.Location = new System.Drawing.Point(77, 43);
            this.txtCostProc.Name = "txtCostProc";
            this.txtCostProc.Size = new System.Drawing.Size(200, 20);
            this.txtCostProc.TabIndex = 3;
            // 
            // dtpDateProc
            // 
            this.dtpDateProc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proceedsBindingSource, "Date", true));
            this.dtpDateProc.Location = new System.Drawing.Point(77, 69);
            this.dtpDateProc.Name = "dtpDateProc";
            this.dtpDateProc.Size = new System.Drawing.Size(200, 20);
            this.dtpDateProc.TabIndex = 5;
            // 
            // txtClientIdProc
            // 
            this.txtClientIdProc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proceedsBindingSource, "ClientId", true));
            this.txtClientIdProc.Location = new System.Drawing.Point(77, 95);
            this.txtClientIdProc.Name = "txtClientIdProc";
            this.txtClientIdProc.Size = new System.Drawing.Size(200, 20);
            this.txtClientIdProc.TabIndex = 7;
            this.txtClientIdProc.DoubleClick += new System.EventHandler(this.txtClientIdProc_DoubleClick);
            // 
            // txtDescProc
            // 
            this.txtDescProc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proceedsBindingSource, "Description", true));
            this.txtDescProc.Location = new System.Drawing.Point(77, 121);
            this.txtDescProc.Name = "txtDescProc";
            this.txtDescProc.Size = new System.Drawing.Size(200, 20);
            this.txtDescProc.TabIndex = 9;
            // 
            // txtAmountProc
            // 
            this.txtAmountProc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proceedsBindingSource, "Amount", true));
            this.txtAmountProc.Location = new System.Drawing.Point(77, 147);
            this.txtAmountProc.Name = "txtAmountProc";
            this.txtAmountProc.Size = new System.Drawing.Size(200, 20);
            this.txtAmountProc.TabIndex = 11;
            // 
            // gbInventory
            // 
            this.gbInventory.Controls.Add(lblIdInv);
            this.gbInventory.Controls.Add(this.txtIdInv);
            this.gbInventory.Controls.Add(lblNameInv);
            this.gbInventory.Controls.Add(this.txtNameInv);
            this.gbInventory.Controls.Add(lblTypeInv);
            this.gbInventory.Controls.Add(this.comboTypeInv);
            this.gbInventory.Controls.Add(lblBrandInv);
            this.gbInventory.Controls.Add(this.txtBrandInv);
            this.gbInventory.Controls.Add(lblAmountInv);
            this.gbInventory.Controls.Add(this.txtAmountInv);
            this.gbInventory.Controls.Add(lblDelDateInv);
            this.gbInventory.Controls.Add(this.dtpDelDateInv);
            this.gbInventory.Controls.Add(lblRepairsInv);
            this.gbInventory.Controls.Add(this.txtRepairsInv);
            this.gbInventory.Controls.Add(lblExpDateInv);
            this.gbInventory.Controls.Add(this.dtpExpDateInv);
            this.gbInventory.Controls.Add(lblChangeDateInv);
            this.gbInventory.Controls.Add(this.dtpChangeDateInv);
            this.gbInventory.Controls.Add(lblDelPriceInv);
            this.gbInventory.Controls.Add(this.txtDelPriceInv);
            this.gbInventory.Controls.Add(lblProvIdInv);
            this.gbInventory.Controls.Add(this.txtProvIdInv);
            this.gbInventory.Location = new System.Drawing.Point(140, 87);
            this.gbInventory.Name = "gbInventory";
            this.gbInventory.Size = new System.Drawing.Size(97, 51);
            this.gbInventory.TabIndex = 51;
            this.gbInventory.TabStop = false;
            this.gbInventory.Text = "Оборудване";
            // 
            // txtIdInv
            // 
            this.txtIdInv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "Id", true));
            this.txtIdInv.Enabled = false;
            this.txtIdInv.Location = new System.Drawing.Point(109, 13);
            this.txtIdInv.Name = "txtIdInv";
            this.txtIdInv.Size = new System.Drawing.Size(200, 20);
            this.txtIdInv.TabIndex = 1;
            // 
            // txtNameInv
            // 
            this.txtNameInv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "Name", true));
            this.txtNameInv.Location = new System.Drawing.Point(109, 38);
            this.txtNameInv.Name = "txtNameInv";
            this.txtNameInv.Size = new System.Drawing.Size(200, 20);
            this.txtNameInv.TabIndex = 3;
            // 
            // comboTypeInv
            // 
            this.comboTypeInv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "Type", true));
            this.comboTypeInv.FormattingEnabled = true;
            this.comboTypeInv.Items.AddRange(new object[] {
            "--Избери--",
            "Машина",
            "Свободна тежест",
            "Диск",
            "Аксесоар",
            "Друго"});
            this.comboTypeInv.Location = new System.Drawing.Point(109, 63);
            this.comboTypeInv.Name = "comboTypeInv";
            this.comboTypeInv.Size = new System.Drawing.Size(200, 21);
            this.comboTypeInv.TabIndex = 5;
            // 
            // txtBrandInv
            // 
            this.txtBrandInv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "Brand", true));
            this.txtBrandInv.Location = new System.Drawing.Point(109, 90);
            this.txtBrandInv.Name = "txtBrandInv";
            this.txtBrandInv.Size = new System.Drawing.Size(200, 20);
            this.txtBrandInv.TabIndex = 7;
            // 
            // txtAmountInv
            // 
            this.txtAmountInv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "Amount", true));
            this.txtAmountInv.Location = new System.Drawing.Point(109, 116);
            this.txtAmountInv.Name = "txtAmountInv";
            this.txtAmountInv.Size = new System.Drawing.Size(200, 20);
            this.txtAmountInv.TabIndex = 9;
            // 
            // dtpDelDateInv
            // 
            this.dtpDelDateInv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "DeliveryDate", true));
            this.dtpDelDateInv.Location = new System.Drawing.Point(109, 143);
            this.dtpDelDateInv.Name = "dtpDelDateInv";
            this.dtpDelDateInv.Size = new System.Drawing.Size(200, 20);
            this.dtpDelDateInv.TabIndex = 11;
            this.dtpDelDateInv.Value = new System.DateTime(1914, 5, 24, 0, 0, 0, 0);
            // 
            // txtRepairsInv
            // 
            this.txtRepairsInv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "NumberOfRepairs", true));
            this.txtRepairsInv.Location = new System.Drawing.Point(109, 168);
            this.txtRepairsInv.Name = "txtRepairsInv";
            this.txtRepairsInv.Size = new System.Drawing.Size(200, 20);
            this.txtRepairsInv.TabIndex = 13;
            // 
            // dtpExpDateInv
            // 
            this.dtpExpDateInv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "ExpirationDate", true));
            this.dtpExpDateInv.Location = new System.Drawing.Point(109, 195);
            this.dtpExpDateInv.Name = "dtpExpDateInv";
            this.dtpExpDateInv.Size = new System.Drawing.Size(200, 20);
            this.dtpExpDateInv.TabIndex = 15;
            this.dtpExpDateInv.Value = new System.DateTime(1914, 5, 24, 0, 0, 0, 0);
            // 
            // dtpChangeDateInv
            // 
            this.dtpChangeDateInv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "FutureDateChange", true));
            this.dtpChangeDateInv.Location = new System.Drawing.Point(109, 220);
            this.dtpChangeDateInv.Name = "dtpChangeDateInv";
            this.dtpChangeDateInv.Size = new System.Drawing.Size(200, 20);
            this.dtpChangeDateInv.TabIndex = 17;
            this.dtpChangeDateInv.Value = new System.DateTime(1914, 5, 24, 0, 0, 0, 0);
            // 
            // txtDelPriceInv
            // 
            this.txtDelPriceInv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "DeliveryPrice", true));
            this.txtDelPriceInv.Location = new System.Drawing.Point(109, 246);
            this.txtDelPriceInv.Name = "txtDelPriceInv";
            this.txtDelPriceInv.Size = new System.Drawing.Size(200, 20);
            this.txtDelPriceInv.TabIndex = 19;
            // 
            // txtProvIdInv
            // 
            this.txtProvIdInv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "ProviderId", true));
            this.txtProvIdInv.Location = new System.Drawing.Point(109, 273);
            this.txtProvIdInv.Name = "txtProvIdInv";
            this.txtProvIdInv.Size = new System.Drawing.Size(200, 20);
            this.txtProvIdInv.TabIndex = 21;
            this.txtProvIdInv.DoubleClick += new System.EventHandler(this.txtProvIdInv_DoubleClick);
            // 
            // providersBindingSource
            // 
            this.providersBindingSource.DataMember = "Providers";
            this.providersBindingSource.DataSource = this.gymDatabaseDataSet;
            // 
            // salariesBindingSource
            // 
            this.salariesBindingSource.DataMember = "Salaries";
            this.salariesBindingSource.DataSource = this.gymDatabaseDataSet;
            // 
            // subscriptionsBindingSource
            // 
            this.subscriptionsBindingSource.DataMember = "Subscriptions";
            this.subscriptionsBindingSource.DataSource = this.gymDatabaseDataSet;
            // 
            // suppliesBindingSource
            // 
            this.suppliesBindingSource.DataMember = "Supplies";
            this.suppliesBindingSource.DataSource = this.gymDatabaseDataSet;
            // 
            // workersBindingSource
            // 
            this.workersBindingSource.DataMember = "Workers";
            this.workersBindingSource.DataSource = this.gymDatabaseDataSet;
            // 
            // workoutsBindingSource
            // 
            this.workoutsBindingSource.DataMember = "Workouts";
            this.workoutsBindingSource.DataSource = this.gymDatabaseDataSet;
            // 
            // workSchedulesBindingSource
            // 
            this.workSchedulesBindingSource.DataMember = "WorkSchedules";
            this.workSchedulesBindingSource.DataSource = this.gymDatabaseDataSet;
            // 
            // gbSalaries
            // 
            this.gbSalaries.Controls.Add(lblIdSal);
            this.gbSalaries.Controls.Add(this.txtIdSal);
            this.gbSalaries.Controls.Add(lblWorkerIdSal);
            this.gbSalaries.Controls.Add(this.txtWorkerIdSal);
            this.gbSalaries.Controls.Add(lblDateSal);
            this.gbSalaries.Controls.Add(this.dtpDateSal);
            this.gbSalaries.Controls.Add(lblSalarySal);
            this.gbSalaries.Controls.Add(this.txtSalarySal);
            this.gbSalaries.Controls.Add(lblBonusSal);
            this.gbSalaries.Controls.Add(this.txtBonusSal);
            this.gbSalaries.Location = new System.Drawing.Point(257, 35);
            this.gbSalaries.Name = "gbSalaries";
            this.gbSalaries.Size = new System.Drawing.Size(96, 40);
            this.gbSalaries.TabIndex = 55;
            this.gbSalaries.TabStop = false;
            this.gbSalaries.Text = "Заплати";
            // 
            // txtIdSal
            // 
            this.txtIdSal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salariesBindingSource, "Id", true));
            this.txtIdSal.Enabled = false;
            this.txtIdSal.Location = new System.Drawing.Point(84, 16);
            this.txtIdSal.Name = "txtIdSal";
            this.txtIdSal.Size = new System.Drawing.Size(140, 20);
            this.txtIdSal.TabIndex = 1;
            // 
            // txtWorkerIdSal
            // 
            this.txtWorkerIdSal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salariesBindingSource, "WorkerId", true));
            this.txtWorkerIdSal.Location = new System.Drawing.Point(84, 42);
            this.txtWorkerIdSal.Name = "txtWorkerIdSal";
            this.txtWorkerIdSal.Size = new System.Drawing.Size(140, 20);
            this.txtWorkerIdSal.TabIndex = 3;
            this.txtWorkerIdSal.DoubleClick += new System.EventHandler(this.txtWorkerIdSal_DoubleClick);
            // 
            // dtpDateSal
            // 
            this.dtpDateSal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salariesBindingSource, "Date", true));
            this.dtpDateSal.Location = new System.Drawing.Point(84, 68);
            this.dtpDateSal.Name = "dtpDateSal";
            this.dtpDateSal.Size = new System.Drawing.Size(140, 20);
            this.dtpDateSal.TabIndex = 5;
            // 
            // txtSalarySal
            // 
            this.txtSalarySal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salariesBindingSource, "Salary", true));
            this.txtSalarySal.Location = new System.Drawing.Point(84, 94);
            this.txtSalarySal.Name = "txtSalarySal";
            this.txtSalarySal.Size = new System.Drawing.Size(140, 20);
            this.txtSalarySal.TabIndex = 7;
            // 
            // txtBonusSal
            // 
            this.txtBonusSal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salariesBindingSource, "Bonus", true));
            this.txtBonusSal.Location = new System.Drawing.Point(84, 120);
            this.txtBonusSal.Name = "txtBonusSal";
            this.txtBonusSal.Size = new System.Drawing.Size(140, 20);
            this.txtBonusSal.TabIndex = 9;
            // 
            // gbProviders
            // 
            this.gbProviders.Controls.Add(lblIdProv);
            this.gbProviders.Controls.Add(this.txtIdProv);
            this.gbProviders.Controls.Add(lblCompNameProv);
            this.gbProviders.Controls.Add(this.txtCompNameProv);
            this.gbProviders.Controls.Add(lblAddrProv);
            this.gbProviders.Controls.Add(this.txtAddrProv);
            this.gbProviders.Controls.Add(lblEmailProv);
            this.gbProviders.Controls.Add(this.txtEmailProv);
            this.gbProviders.Controls.Add(lblPhoneProv);
            this.gbProviders.Controls.Add(this.txtPhoneProv);
            this.gbProviders.Controls.Add(lblAPNProv);
            this.gbProviders.Controls.Add(this.txtAPNProv);
            this.gbProviders.Controls.Add(lblAPPINProv);
            this.gbProviders.Controls.Add(this.txtAPPINProv);
            this.gbProviders.Location = new System.Drawing.Point(257, 218);
            this.gbProviders.Name = "gbProviders";
            this.gbProviders.Size = new System.Drawing.Size(96, 45);
            this.gbProviders.TabIndex = 54;
            this.gbProviders.TabStop = false;
            this.gbProviders.Text = "Доставчици";
            // 
            // txtIdProv
            // 
            this.txtIdProv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providersBindingSource, "Id", true));
            this.txtIdProv.Enabled = false;
            this.txtIdProv.Location = new System.Drawing.Point(96, 22);
            this.txtIdProv.Name = "txtIdProv";
            this.txtIdProv.Size = new System.Drawing.Size(179, 20);
            this.txtIdProv.TabIndex = 1;
            // 
            // txtCompNameProv
            // 
            this.txtCompNameProv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providersBindingSource, "CompanyName", true));
            this.txtCompNameProv.Location = new System.Drawing.Point(96, 47);
            this.txtCompNameProv.Name = "txtCompNameProv";
            this.txtCompNameProv.Size = new System.Drawing.Size(179, 20);
            this.txtCompNameProv.TabIndex = 3;
            // 
            // txtAddrProv
            // 
            this.txtAddrProv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providersBindingSource, "Address", true));
            this.txtAddrProv.Location = new System.Drawing.Point(96, 72);
            this.txtAddrProv.Name = "txtAddrProv";
            this.txtAddrProv.Size = new System.Drawing.Size(179, 20);
            this.txtAddrProv.TabIndex = 5;
            // 
            // txtEmailProv
            // 
            this.txtEmailProv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providersBindingSource, "Email", true));
            this.txtEmailProv.Location = new System.Drawing.Point(96, 97);
            this.txtEmailProv.Name = "txtEmailProv";
            this.txtEmailProv.Size = new System.Drawing.Size(179, 20);
            this.txtEmailProv.TabIndex = 7;
            // 
            // txtPhoneProv
            // 
            this.txtPhoneProv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providersBindingSource, "PhoneNumber", true));
            this.txtPhoneProv.Location = new System.Drawing.Point(96, 122);
            this.txtPhoneProv.Name = "txtPhoneProv";
            this.txtPhoneProv.Size = new System.Drawing.Size(179, 20);
            this.txtPhoneProv.TabIndex = 9;
            // 
            // txtAPNProv
            // 
            this.txtAPNProv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providersBindingSource, "AccountablePersonName", true));
            this.txtAPNProv.Location = new System.Drawing.Point(96, 147);
            this.txtAPNProv.Name = "txtAPNProv";
            this.txtAPNProv.Size = new System.Drawing.Size(179, 20);
            this.txtAPNProv.TabIndex = 11;
            // 
            // txtAPPINProv
            // 
            this.txtAPPINProv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providersBindingSource, "AccountablePersonPIN", true));
            this.txtAPPINProv.Location = new System.Drawing.Point(96, 172);
            this.txtAPPINProv.Name = "txtAPPINProv";
            this.txtAPPINProv.Size = new System.Drawing.Size(179, 20);
            this.txtAPPINProv.TabIndex = 13;
            // 
            // gbSupplies
            // 
            this.gbSupplies.Controls.Add(lblIdSup);
            this.gbSupplies.Controls.Add(this.txtIdSup);
            this.gbSupplies.Controls.Add(lblNameSup);
            this.gbSupplies.Controls.Add(this.txtNameSup);
            this.gbSupplies.Controls.Add(lblProviderIdSup);
            this.gbSupplies.Controls.Add(this.txtProviderIdSup);
            this.gbSupplies.Controls.Add(lblDateSup);
            this.gbSupplies.Controls.Add(this.dtpDateSup);
            this.gbSupplies.Controls.Add(lblDelPriceSup);
            this.gbSupplies.Controls.Add(this.txtDelPriceSup);
            this.gbSupplies.Controls.Add(lblSalePriceSup);
            this.gbSupplies.Controls.Add(this.txtSalePriceSup);
            this.gbSupplies.Controls.Add(lblAmountSup);
            this.gbSupplies.Controls.Add(this.txtAmountSup);
            this.gbSupplies.Location = new System.Drawing.Point(13, 218);
            this.gbSupplies.Name = "gbSupplies";
            this.gbSupplies.Size = new System.Drawing.Size(111, 40);
            this.gbSupplies.TabIndex = 57;
            this.gbSupplies.TabStop = false;
            this.gbSupplies.Text = "Доставки";
            // 
            // txtIdSup
            // 
            this.txtIdSup.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliesBindingSource, "Id", true));
            this.txtIdSup.Enabled = false;
            this.txtIdSup.Location = new System.Drawing.Point(96, 22);
            this.txtIdSup.Name = "txtIdSup";
            this.txtIdSup.Size = new System.Drawing.Size(200, 20);
            this.txtIdSup.TabIndex = 1;
            // 
            // txtNameSup
            // 
            this.txtNameSup.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliesBindingSource, "Name", true));
            this.txtNameSup.Location = new System.Drawing.Point(96, 47);
            this.txtNameSup.Name = "txtNameSup";
            this.txtNameSup.Size = new System.Drawing.Size(200, 20);
            this.txtNameSup.TabIndex = 3;
            // 
            // txtProviderIdSup
            // 
            this.txtProviderIdSup.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliesBindingSource, "ProviderId", true));
            this.txtProviderIdSup.Location = new System.Drawing.Point(96, 72);
            this.txtProviderIdSup.Name = "txtProviderIdSup";
            this.txtProviderIdSup.Size = new System.Drawing.Size(200, 20);
            this.txtProviderIdSup.TabIndex = 5;
            this.txtProviderIdSup.DoubleClick += new System.EventHandler(this.txtProviderIdSup_DoubleClick);
            // 
            // dtpDateSup
            // 
            this.dtpDateSup.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliesBindingSource, "Date", true));
            this.dtpDateSup.Location = new System.Drawing.Point(96, 97);
            this.dtpDateSup.Name = "dtpDateSup";
            this.dtpDateSup.Size = new System.Drawing.Size(200, 20);
            this.dtpDateSup.TabIndex = 7;
            // 
            // txtDelPriceSup
            // 
            this.txtDelPriceSup.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliesBindingSource, "DeliveryPrice", true));
            this.txtDelPriceSup.Location = new System.Drawing.Point(96, 122);
            this.txtDelPriceSup.Name = "txtDelPriceSup";
            this.txtDelPriceSup.Size = new System.Drawing.Size(200, 20);
            this.txtDelPriceSup.TabIndex = 9;
            // 
            // txtSalePriceSup
            // 
            this.txtSalePriceSup.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliesBindingSource, "SalePrice", true));
            this.txtSalePriceSup.Location = new System.Drawing.Point(96, 147);
            this.txtSalePriceSup.Name = "txtSalePriceSup";
            this.txtSalePriceSup.Size = new System.Drawing.Size(200, 20);
            this.txtSalePriceSup.TabIndex = 11;
            // 
            // txtAmountSup
            // 
            this.txtAmountSup.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliesBindingSource, "Amount", true));
            this.txtAmountSup.Location = new System.Drawing.Point(96, 172);
            this.txtAmountSup.Name = "txtAmountSup";
            this.txtAmountSup.Size = new System.Drawing.Size(200, 20);
            this.txtAmountSup.TabIndex = 13;
            // 
            // gbSubscriptions
            // 
            this.gbSubscriptions.Controls.Add(lblIdSub);
            this.gbSubscriptions.Controls.Add(this.txtIdSub);
            this.gbSubscriptions.Controls.Add(this.numVisitsSub);
            this.gbSubscriptions.Controls.Add(this.numDurationSub);
            this.gbSubscriptions.Controls.Add(lblNameSub);
            this.gbSubscriptions.Controls.Add(this.txtNameSub);
            this.gbSubscriptions.Controls.Add(lblPriceSub);
            this.gbSubscriptions.Controls.Add(this.txtPriceSub);
            this.gbSubscriptions.Controls.Add(lblDurationSub);
            this.gbSubscriptions.Controls.Add(lblVisitsSub);
            this.gbSubscriptions.Location = new System.Drawing.Point(12, 86);
            this.gbSubscriptions.Name = "gbSubscriptions";
            this.gbSubscriptions.Size = new System.Drawing.Size(111, 49);
            this.gbSubscriptions.TabIndex = 56;
            this.gbSubscriptions.TabStop = false;
            this.gbSubscriptions.Text = "Абонаменти";
            // 
            // txtIdSub
            // 
            this.txtIdSub.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.subscriptionsBindingSource, "Id", true));
            this.txtIdSub.Enabled = false;
            this.txtIdSub.Location = new System.Drawing.Point(118, 18);
            this.txtIdSub.Name = "txtIdSub";
            this.txtIdSub.Size = new System.Drawing.Size(146, 20);
            this.txtIdSub.TabIndex = 1;
            // 
            // numVisitsSub
            // 
            this.numVisitsSub.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.subscriptionsBindingSource, "Visits", true));
            this.numVisitsSub.Location = new System.Drawing.Point(118, 122);
            this.numVisitsSub.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.numVisitsSub.Name = "numVisitsSub";
            this.numVisitsSub.Size = new System.Drawing.Size(146, 20);
            this.numVisitsSub.TabIndex = 9;
            // 
            // numDurationSub
            // 
            this.numDurationSub.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.subscriptionsBindingSource, "Duration_months", true));
            this.numDurationSub.Location = new System.Drawing.Point(118, 96);
            this.numDurationSub.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numDurationSub.Name = "numDurationSub";
            this.numDurationSub.Size = new System.Drawing.Size(146, 20);
            this.numDurationSub.TabIndex = 7;
            // 
            // txtNameSub
            // 
            this.txtNameSub.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.subscriptionsBindingSource, "Name", true));
            this.txtNameSub.Location = new System.Drawing.Point(118, 44);
            this.txtNameSub.Name = "txtNameSub";
            this.txtNameSub.Size = new System.Drawing.Size(146, 20);
            this.txtNameSub.TabIndex = 3;
            // 
            // txtPriceSub
            // 
            this.txtPriceSub.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.subscriptionsBindingSource, "Price", true));
            this.txtPriceSub.Location = new System.Drawing.Point(118, 70);
            this.txtPriceSub.Name = "txtPriceSub";
            this.txtPriceSub.Size = new System.Drawing.Size(146, 20);
            this.txtPriceSub.TabIndex = 5;
            // 
            // gbWorkSchedules
            // 
            this.gbWorkSchedules.Controls.Add(lblIdWS);
            this.gbWorkSchedules.Controls.Add(this.txtIdWS);
            this.gbWorkSchedules.Controls.Add(lblWorkerIdWS);
            this.gbWorkSchedules.Controls.Add(this.txtWorkerIdWS);
            this.gbWorkSchedules.Controls.Add(lblShiftWS);
            this.gbWorkSchedules.Controls.Add(this.txtShiftWS);
            this.gbWorkSchedules.Controls.Add(lblWorkTimeWS);
            this.gbWorkSchedules.Controls.Add(this.txtWorkTimeWS);
            this.gbWorkSchedules.Controls.Add(lblDateWS);
            this.gbWorkSchedules.Controls.Add(this.dtpDateWS);
            this.gbWorkSchedules.Location = new System.Drawing.Point(12, 153);
            this.gbWorkSchedules.Name = "gbWorkSchedules";
            this.gbWorkSchedules.Size = new System.Drawing.Size(111, 49);
            this.gbWorkSchedules.TabIndex = 60;
            this.gbWorkSchedules.TabStop = false;
            this.gbWorkSchedules.Text = "Работни графици";
            // 
            // txtIdWS
            // 
            this.txtIdWS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workSchedulesBindingSource, "Id", true));
            this.txtIdWS.Enabled = false;
            this.txtIdWS.Location = new System.Drawing.Point(94, 20);
            this.txtIdWS.Name = "txtIdWS";
            this.txtIdWS.Size = new System.Drawing.Size(157, 20);
            this.txtIdWS.TabIndex = 1;
            // 
            // txtWorkerIdWS
            // 
            this.txtWorkerIdWS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workSchedulesBindingSource, "WorkerId", true));
            this.txtWorkerIdWS.Location = new System.Drawing.Point(94, 46);
            this.txtWorkerIdWS.Name = "txtWorkerIdWS";
            this.txtWorkerIdWS.Size = new System.Drawing.Size(157, 20);
            this.txtWorkerIdWS.TabIndex = 3;
            this.txtWorkerIdWS.DoubleClick += new System.EventHandler(this.txtWorkerIdWS_DoubleClick);
            // 
            // txtShiftWS
            // 
            this.txtShiftWS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workSchedulesBindingSource, "Shift", true));
            this.txtShiftWS.Location = new System.Drawing.Point(94, 72);
            this.txtShiftWS.Name = "txtShiftWS";
            this.txtShiftWS.Size = new System.Drawing.Size(157, 20);
            this.txtShiftWS.TabIndex = 5;
            // 
            // txtWorkTimeWS
            // 
            this.txtWorkTimeWS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workSchedulesBindingSource, "WorkingTime", true));
            this.txtWorkTimeWS.Location = new System.Drawing.Point(94, 98);
            this.txtWorkTimeWS.Name = "txtWorkTimeWS";
            this.txtWorkTimeWS.Size = new System.Drawing.Size(157, 20);
            this.txtWorkTimeWS.TabIndex = 7;
            // 
            // dtpDateWS
            // 
            this.dtpDateWS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workSchedulesBindingSource, "Date", true));
            this.dtpDateWS.Location = new System.Drawing.Point(94, 124);
            this.dtpDateWS.Name = "dtpDateWS";
            this.dtpDateWS.Size = new System.Drawing.Size(157, 20);
            this.dtpDateWS.TabIndex = 9;
            // 
            // gbWorkouts
            // 
            this.gbWorkouts.Controls.Add(lblIdWO);
            this.gbWorkouts.Controls.Add(this.txtIdWO);
            this.gbWorkouts.Controls.Add(lblCoachIdWO);
            this.gbWorkouts.Controls.Add(this.txtCoachIdWO);
            this.gbWorkouts.Controls.Add(lblClientIdWO);
            this.gbWorkouts.Controls.Add(this.txtClientIdWO);
            this.gbWorkouts.Controls.Add(lblDateWO);
            this.gbWorkouts.Controls.Add(this.dtpDateWO);
            this.gbWorkouts.Controls.Add(lblStartWO);
            this.gbWorkouts.Controls.Add(this.txtStartWO);
            this.gbWorkouts.Controls.Add(lblEndWO);
            this.gbWorkouts.Controls.Add(this.txtEndWO);
            this.gbWorkouts.Controls.Add(lblPriceWO);
            this.gbWorkouts.Controls.Add(this.txtPriceWO);
            this.gbWorkouts.Location = new System.Drawing.Point(257, 86);
            this.gbWorkouts.Name = "gbWorkouts";
            this.gbWorkouts.Size = new System.Drawing.Size(96, 52);
            this.gbWorkouts.TabIndex = 59;
            this.gbWorkouts.TabStop = false;
            this.gbWorkouts.Text = "Тренировки";
            // 
            // txtIdWO
            // 
            this.txtIdWO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workoutsBindingSource, "Id", true));
            this.txtIdWO.Enabled = false;
            this.txtIdWO.Location = new System.Drawing.Point(87, 18);
            this.txtIdWO.Name = "txtIdWO";
            this.txtIdWO.Size = new System.Drawing.Size(136, 20);
            this.txtIdWO.TabIndex = 1;
            // 
            // txtCoachIdWO
            // 
            this.txtCoachIdWO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workoutsBindingSource, "CoachId", true));
            this.txtCoachIdWO.Location = new System.Drawing.Point(87, 43);
            this.txtCoachIdWO.Name = "txtCoachIdWO";
            this.txtCoachIdWO.Size = new System.Drawing.Size(136, 20);
            this.txtCoachIdWO.TabIndex = 3;
            this.txtCoachIdWO.DoubleClick += new System.EventHandler(this.txtCoachIdWO_DoubleClick);
            // 
            // txtClientIdWO
            // 
            this.txtClientIdWO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workoutsBindingSource, "ClientId", true));
            this.txtClientIdWO.Location = new System.Drawing.Point(87, 68);
            this.txtClientIdWO.Name = "txtClientIdWO";
            this.txtClientIdWO.Size = new System.Drawing.Size(136, 20);
            this.txtClientIdWO.TabIndex = 5;
            this.txtClientIdWO.DoubleClick += new System.EventHandler(this.txtClientIdWO_DoubleClick);
            // 
            // dtpDateWO
            // 
            this.dtpDateWO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workoutsBindingSource, "Date", true));
            this.dtpDateWO.Location = new System.Drawing.Point(87, 93);
            this.dtpDateWO.Name = "dtpDateWO";
            this.dtpDateWO.Size = new System.Drawing.Size(136, 20);
            this.dtpDateWO.TabIndex = 7;
            // 
            // txtStartWO
            // 
            this.txtStartWO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workoutsBindingSource, "StartTime", true));
            this.txtStartWO.Location = new System.Drawing.Point(87, 118);
            this.txtStartWO.Name = "txtStartWO";
            this.txtStartWO.Size = new System.Drawing.Size(136, 20);
            this.txtStartWO.TabIndex = 9;
            // 
            // txtEndWO
            // 
            this.txtEndWO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workoutsBindingSource, "EndTime", true));
            this.txtEndWO.Location = new System.Drawing.Point(87, 143);
            this.txtEndWO.Name = "txtEndWO";
            this.txtEndWO.Size = new System.Drawing.Size(136, 20);
            this.txtEndWO.TabIndex = 11;
            // 
            // txtPriceWO
            // 
            this.txtPriceWO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workoutsBindingSource, "Price", true));
            this.txtPriceWO.Location = new System.Drawing.Point(87, 168);
            this.txtPriceWO.Name = "txtPriceWO";
            this.txtPriceWO.Size = new System.Drawing.Size(136, 20);
            this.txtPriceWO.TabIndex = 13;
            // 
            // gbWorkers
            // 
            this.gbWorkers.Controls.Add(lblIdW);
            this.gbWorkers.Controls.Add(this.txtIdW);
            this.gbWorkers.Controls.Add(lblUsername);
            this.gbWorkers.Controls.Add(this.txtUsername);
            this.gbWorkers.Controls.Add(lblPass);
            this.gbWorkers.Controls.Add(this.txtPass);
            this.gbWorkers.Controls.Add(lblFirstNameW);
            this.gbWorkers.Controls.Add(this.txtFirstNameW);
            this.gbWorkers.Controls.Add(lblLastNameW);
            this.gbWorkers.Controls.Add(this.txtLastNameW);
            this.gbWorkers.Controls.Add(lblPINW);
            this.gbWorkers.Controls.Add(this.txtPINW);
            this.gbWorkers.Controls.Add(lblFirstDayW);
            this.gbWorkers.Controls.Add(this.dtpFirstDayW);
            this.gbWorkers.Controls.Add(lblSalaryW);
            this.gbWorkers.Controls.Add(this.txtSalaryW);
            this.gbWorkers.Controls.Add(lblRoleW);
            this.gbWorkers.Controls.Add(this.comboRoleW);
            this.gbWorkers.Controls.Add(lblEmailW);
            this.gbWorkers.Controls.Add(this.txtEmailW);
            this.gbWorkers.Controls.Add(lblPhoneW);
            this.gbWorkers.Controls.Add(this.txtPhoneW);
            this.gbWorkers.Location = new System.Drawing.Point(12, 35);
            this.gbWorkers.Name = "gbWorkers";
            this.gbWorkers.Size = new System.Drawing.Size(111, 42);
            this.gbWorkers.TabIndex = 58;
            this.gbWorkers.TabStop = false;
            this.gbWorkers.Text = "Служители";
            // 
            // txtIdW
            // 
            this.txtIdW.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "Id", true));
            this.txtIdW.Enabled = false;
            this.txtIdW.Location = new System.Drawing.Point(79, 20);
            this.txtIdW.Name = "txtIdW";
            this.txtIdW.Size = new System.Drawing.Size(200, 20);
            this.txtIdW.TabIndex = 1;
            // 
            // txtUsername
            // 
            this.txtUsername.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "Username", true));
            this.txtUsername.Location = new System.Drawing.Point(79, 98);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 20);
            this.txtUsername.TabIndex = 7;
            // 
            // txtPass
            // 
            this.txtPass.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "Password", true));
            this.txtPass.Location = new System.Drawing.Point(79, 124);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(200, 20);
            this.txtPass.TabIndex = 9;
            // 
            // txtFirstNameW
            // 
            this.txtFirstNameW.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "FirstName", true));
            this.txtFirstNameW.Location = new System.Drawing.Point(79, 46);
            this.txtFirstNameW.Name = "txtFirstNameW";
            this.txtFirstNameW.Size = new System.Drawing.Size(200, 20);
            this.txtFirstNameW.TabIndex = 3;
            // 
            // txtLastNameW
            // 
            this.txtLastNameW.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "LastName", true));
            this.txtLastNameW.Location = new System.Drawing.Point(79, 72);
            this.txtLastNameW.Name = "txtLastNameW";
            this.txtLastNameW.Size = new System.Drawing.Size(200, 20);
            this.txtLastNameW.TabIndex = 5;
            // 
            // txtPINW
            // 
            this.txtPINW.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "PIN", true));
            this.txtPINW.Location = new System.Drawing.Point(79, 150);
            this.txtPINW.Name = "txtPINW";
            this.txtPINW.Size = new System.Drawing.Size(200, 20);
            this.txtPINW.TabIndex = 11;
            // 
            // dtpFirstDayW
            // 
            this.dtpFirstDayW.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "FirstWorkDayDate", true));
            this.dtpFirstDayW.Location = new System.Drawing.Point(79, 176);
            this.dtpFirstDayW.Name = "dtpFirstDayW";
            this.dtpFirstDayW.Size = new System.Drawing.Size(200, 20);
            this.dtpFirstDayW.TabIndex = 13;
            // 
            // txtSalaryW
            // 
            this.txtSalaryW.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "MonthSalary", true));
            this.txtSalaryW.Location = new System.Drawing.Point(79, 202);
            this.txtSalaryW.Name = "txtSalaryW";
            this.txtSalaryW.Size = new System.Drawing.Size(200, 20);
            this.txtSalaryW.TabIndex = 15;
            // 
            // comboRoleW
            // 
            this.comboRoleW.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "Role", true));
            this.comboRoleW.FormattingEnabled = true;
            this.comboRoleW.Items.AddRange(new object[] {
            "--Избери--",
            "Администратор",
            "Инструктор",
            "Касиер"});
            this.comboRoleW.Location = new System.Drawing.Point(79, 228);
            this.comboRoleW.Name = "comboRoleW";
            this.comboRoleW.Size = new System.Drawing.Size(200, 21);
            this.comboRoleW.TabIndex = 17;
            // 
            // txtEmailW
            // 
            this.txtEmailW.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "Email", true));
            this.txtEmailW.Location = new System.Drawing.Point(79, 255);
            this.txtEmailW.Name = "txtEmailW";
            this.txtEmailW.Size = new System.Drawing.Size(200, 20);
            this.txtEmailW.TabIndex = 19;
            // 
            // txtPhoneW
            // 
            this.txtPhoneW.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.workersBindingSource, "PhoneNumber", true));
            this.txtPhoneW.Location = new System.Drawing.Point(79, 281);
            this.txtPhoneW.Name = "txtPhoneW";
            this.txtPhoneW.Size = new System.Drawing.Size(200, 20);
            this.txtPhoneW.TabIndex = 21;
            // 
            // lblRequired
            // 
            this.lblRequired.AutoSize = true;
            this.lblRequired.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequired.Location = new System.Drawing.Point(617, 87);
            this.lblRequired.Name = "lblRequired";
            this.lblRequired.Size = new System.Drawing.Size(169, 14);
            this.lblRequired.TabIndex = 61;
            this.lblRequired.Text = "Полетата с * са задължителни";
            // 
            // UpdateRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(198)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(807, 347);
            this.Controls.Add(this.lblRequired);
            this.Controls.Add(this.gbWorkSchedules);
            this.Controls.Add(this.gbWorkouts);
            this.Controls.Add(this.gbWorkers);
            this.Controls.Add(this.gbSupplies);
            this.Controls.Add(this.gbSubscriptions);
            this.Controls.Add(this.gbSalaries);
            this.Controls.Add(this.gbProviders);
            this.Controls.Add(this.gbProducts);
            this.Controls.Add(this.gbProceeds);
            this.Controls.Add(this.gbInventory);
            this.Controls.Add(this.gbExpenses);
            this.Controls.Add(this.gbClients);
            this.Controls.Add(this.tableBindingNavigator);
            this.Name = "UpdateRecordForm";
            this.Text = "UpdateRecordForm";
            this.Load += new System.EventHandler(this.UpdateRecordForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gymDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingNavigator)).EndInit();
            this.tableBindingNavigator.ResumeLayout(false);
            this.tableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expensesBindingSource)).EndInit();
            this.gbExpenses.ResumeLayout(false);
            this.gbExpenses.PerformLayout();
            this.gbClients.ResumeLayout(false);
            this.gbClients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proceedsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.gbProducts.ResumeLayout(false);
            this.gbProducts.PerformLayout();
            this.gbProceeds.ResumeLayout(false);
            this.gbProceeds.PerformLayout();
            this.gbInventory.ResumeLayout(false);
            this.gbInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salariesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscriptionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workoutsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workSchedulesBindingSource)).EndInit();
            this.gbSalaries.ResumeLayout(false);
            this.gbSalaries.PerformLayout();
            this.gbProviders.ResumeLayout(false);
            this.gbProviders.PerformLayout();
            this.gbSupplies.ResumeLayout(false);
            this.gbSupplies.PerformLayout();
            this.gbSubscriptions.ResumeLayout(false);
            this.gbSubscriptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVisitsSub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDurationSub)).EndInit();
            this.gbWorkSchedules.ResumeLayout(false);
            this.gbWorkSchedules.PerformLayout();
            this.gbWorkouts.ResumeLayout(false);
            this.gbWorkouts.PerformLayout();
            this.gbWorkers.ResumeLayout(false);
            this.gbWorkers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GymDatabaseDataSet gymDatabaseDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private GymDatabaseDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private GymDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tableBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tableBindingNavigatorSaveItem;
        private GymDatabaseDataSetTableAdapters.ExpensesTableAdapter expensesTableAdapter;
        private System.Windows.Forms.BindingSource expensesBindingSource;
        private System.Windows.Forms.GroupBox gbExpenses;
        private System.Windows.Forms.TextBox txtIdE;
        private System.Windows.Forms.TextBox txtCostE;
        private System.Windows.Forms.DateTimePicker dtpDateE;
        private System.Windows.Forms.TextBox txtSupplyIdE;
        private System.Windows.Forms.TextBox txtSalaryIdE;
        private System.Windows.Forms.TextBox txtDescriptE;
        private System.Windows.Forms.TextBox txtAmountE;
        private System.Windows.Forms.GroupBox gbClients;
        private System.Windows.Forms.TextBox txtIdC;
        private System.Windows.Forms.TextBox txtSubIdC;
        private System.Windows.Forms.Label lblSubIdC;
        private System.Windows.Forms.TextBox txtFirstNameC;
        private System.Windows.Forms.TextBox txtLastNameC;
        private System.Windows.Forms.DateTimePicker dtpSubFromC;
        private System.Windows.Forms.DateTimePicker dtpSubToC;
        private System.Windows.Forms.DateTimePicker dtpAddedAtC;
        private System.Windows.Forms.TextBox txtRenewsC;
        private System.Windows.Forms.TextBox txtEmailC;
        private System.Windows.Forms.TextBox txtPhoneC;
        private System.Windows.Forms.TextBox txtCoachIdC;
        private System.Windows.Forms.CheckBox checkBonusC;
        private GymDatabaseDataSetTableAdapters.InventoryTableAdapter inventoryTableAdapter;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private GymDatabaseDataSetTableAdapters.ProceedsTableAdapter proceedsTableAdapter;
        private System.Windows.Forms.BindingSource proceedsBindingSource;
        private GymDatabaseDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.GroupBox gbProducts;
        private System.Windows.Forms.TextBox txtIdProd;
        private System.Windows.Forms.TextBox txtNameProd;
        private System.Windows.Forms.TextBox txtAmountProd;
        private System.Windows.Forms.TextBox txtBarcodeProd;
        private System.Windows.Forms.ComboBox comboCategoryProd;
        private System.Windows.Forms.DateTimePicker dtpLDDProd;
        private System.Windows.Forms.DateTimePicker dtpFDDProd;
        private System.Windows.Forms.TextBox txtSalePriceProd;
        private System.Windows.Forms.TextBox txtProvIdProd;
        private System.Windows.Forms.GroupBox gbProceeds;
        private System.Windows.Forms.TextBox txtIdProc;
        private System.Windows.Forms.TextBox txtCostProc;
        private System.Windows.Forms.DateTimePicker dtpDateProc;
        private System.Windows.Forms.TextBox txtClientIdProc;
        private System.Windows.Forms.TextBox txtDescProc;
        private System.Windows.Forms.TextBox txtAmountProc;
        private System.Windows.Forms.GroupBox gbInventory;
        private System.Windows.Forms.TextBox txtIdInv;
        private System.Windows.Forms.TextBox txtNameInv;
        private System.Windows.Forms.ComboBox comboTypeInv;
        private System.Windows.Forms.TextBox txtBrandInv;
        private System.Windows.Forms.TextBox txtAmountInv;
        private System.Windows.Forms.DateTimePicker dtpDelDateInv;
        private System.Windows.Forms.TextBox txtRepairsInv;
        private System.Windows.Forms.DateTimePicker dtpExpDateInv;
        private System.Windows.Forms.DateTimePicker dtpChangeDateInv;
        private System.Windows.Forms.TextBox txtDelPriceInv;
        private System.Windows.Forms.TextBox txtProvIdInv;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.BindingSource providersBindingSource;
        private GymDatabaseDataSetTableAdapters.ProvidersTableAdapter providersTableAdapter;
        private System.Windows.Forms.BindingSource salariesBindingSource;
        private GymDatabaseDataSetTableAdapters.SalariesTableAdapter salariesTableAdapter;
        private System.Windows.Forms.BindingSource subscriptionsBindingSource;
        private GymDatabaseDataSetTableAdapters.SubscriptionsTableAdapter subscriptionsTableAdapter;
        private System.Windows.Forms.BindingSource suppliesBindingSource;
        private GymDatabaseDataSetTableAdapters.SuppliesTableAdapter suppliesTableAdapter;
        private System.Windows.Forms.BindingSource workersBindingSource;
        private GymDatabaseDataSetTableAdapters.WorkersTableAdapter workersTableAdapter;
        private System.Windows.Forms.BindingSource workoutsBindingSource;
        private GymDatabaseDataSetTableAdapters.WorkoutsTableAdapter workoutsTableAdapter;
        private System.Windows.Forms.BindingSource workSchedulesBindingSource;
        private GymDatabaseDataSetTableAdapters.WorkSchedulesTableAdapter workSchedulesTableAdapter;
        private System.Windows.Forms.GroupBox gbSalaries;
        private System.Windows.Forms.TextBox txtIdSal;
        private System.Windows.Forms.TextBox txtWorkerIdSal;
        private System.Windows.Forms.DateTimePicker dtpDateSal;
        private System.Windows.Forms.TextBox txtSalarySal;
        private System.Windows.Forms.TextBox txtBonusSal;
        private System.Windows.Forms.GroupBox gbProviders;
        private System.Windows.Forms.TextBox txtIdProv;
        private System.Windows.Forms.TextBox txtCompNameProv;
        private System.Windows.Forms.TextBox txtAddrProv;
        private System.Windows.Forms.TextBox txtEmailProv;
        private System.Windows.Forms.TextBox txtPhoneProv;
        private System.Windows.Forms.TextBox txtAPNProv;
        private System.Windows.Forms.TextBox txtAPPINProv;
        private System.Windows.Forms.GroupBox gbSupplies;
        private System.Windows.Forms.TextBox txtIdSup;
        private System.Windows.Forms.TextBox txtNameSup;
        private System.Windows.Forms.TextBox txtProviderIdSup;
        private System.Windows.Forms.DateTimePicker dtpDateSup;
        private System.Windows.Forms.TextBox txtDelPriceSup;
        private System.Windows.Forms.TextBox txtSalePriceSup;
        private System.Windows.Forms.TextBox txtAmountSup;
        private System.Windows.Forms.GroupBox gbSubscriptions;
        private System.Windows.Forms.TextBox txtIdSub;
        private System.Windows.Forms.NumericUpDown numVisitsSub;
        private System.Windows.Forms.NumericUpDown numDurationSub;
        private System.Windows.Forms.TextBox txtNameSub;
        private System.Windows.Forms.TextBox txtPriceSub;
        private System.Windows.Forms.GroupBox gbWorkSchedules;
        private System.Windows.Forms.TextBox txtIdWS;
        private System.Windows.Forms.TextBox txtWorkerIdWS;
        private System.Windows.Forms.TextBox txtShiftWS;
        private System.Windows.Forms.TextBox txtWorkTimeWS;
        private System.Windows.Forms.DateTimePicker dtpDateWS;
        private System.Windows.Forms.GroupBox gbWorkouts;
        private System.Windows.Forms.TextBox txtIdWO;
        private System.Windows.Forms.TextBox txtCoachIdWO;
        private System.Windows.Forms.TextBox txtClientIdWO;
        private System.Windows.Forms.DateTimePicker dtpDateWO;
        private System.Windows.Forms.TextBox txtStartWO;
        private System.Windows.Forms.TextBox txtEndWO;
        private System.Windows.Forms.TextBox txtPriceWO;
        private System.Windows.Forms.GroupBox gbWorkers;
        private System.Windows.Forms.TextBox txtIdW;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtFirstNameW;
        private System.Windows.Forms.TextBox txtLastNameW;
        private System.Windows.Forms.TextBox txtPINW;
        private System.Windows.Forms.DateTimePicker dtpFirstDayW;
        private System.Windows.Forms.TextBox txtSalaryW;
        private System.Windows.Forms.ComboBox comboRoleW;
        private System.Windows.Forms.TextBox txtEmailW;
        private System.Windows.Forms.TextBox txtPhoneW;
        private System.Windows.Forms.Label lblRequired;
    }
}