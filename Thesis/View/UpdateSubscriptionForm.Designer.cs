namespace Thesis.View
{
    partial class UpdateSubscriptionForm
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
            System.Windows.Forms.Label lblId;
            System.Windows.Forms.Label lblSubFrom;
            System.Windows.Forms.Label lblSubTo;
            System.Windows.Forms.Label lblSubId;
            System.Windows.Forms.Label lblRenewings;
            System.Windows.Forms.Label lblIdCombo;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateSubscriptionForm));
            this.gymDatabaseDataSet = new Thesis.GymDatabaseDataSet();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new Thesis.GymDatabaseDataSetTableAdapters.ClientsTableAdapter();
            this.tableAdapterManager = new Thesis.GymDatabaseDataSetTableAdapters.TableAdapterManager();
            this.clientsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.clientsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txtId = new System.Windows.Forms.TextBox();
            this.dtpSubFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpSubTo = new System.Windows.Forms.DateTimePicker();
            this.txtSubId = new System.Windows.Forms.TextBox();
            this.txtRenewings = new System.Windows.Forms.TextBox();
            this.comboId = new System.Windows.Forms.ComboBox();
            this.lblRequired = new System.Windows.Forms.Label();
            lblId = new System.Windows.Forms.Label();
            lblSubFrom = new System.Windows.Forms.Label();
            lblSubTo = new System.Windows.Forms.Label();
            lblSubId = new System.Windows.Forms.Label();
            lblRenewings = new System.Windows.Forms.Label();
            lblIdCombo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gymDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingNavigator)).BeginInit();
            this.clientsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new System.Drawing.Point(68, 40);
            lblId.Name = "lblId";
            lblId.Size = new System.Drawing.Size(23, 13);
            lblId.TabIndex = 1;
            lblId.Text = "Id*:";
            // 
            // lblSubFrom
            // 
            lblSubFrom.AutoSize = true;
            lblSubFrom.Location = new System.Drawing.Point(7, 67);
            lblSubFrom.Name = "lblSubFrom";
            lblSubFrom.Size = new System.Drawing.Size(84, 13);
            lblSubFrom.TabIndex = 3;
            lblSubFrom.Text = "Абонамент от*:";
            // 
            // lblSubTo
            // 
            lblSubTo.AutoSize = true;
            lblSubTo.Location = new System.Drawing.Point(6, 93);
            lblSubTo.Name = "lblSubTo";
            lblSubTo.Size = new System.Drawing.Size(85, 13);
            lblSubTo.TabIndex = 5;
            lblSubTo.Text = "Абонамент до*:";
            // 
            // lblSubId
            // 
            lblSubId.AutoSize = true;
            lblSubId.Location = new System.Drawing.Point(8, 118);
            lblSubId.Name = "lblSubId";
            lblSubId.Size = new System.Drawing.Size(83, 13);
            lblSubId.TabIndex = 7;
            lblSubId.Text = "№ абонамент*:";
            // 
            // lblRenewings
            // 
            lblRenewings.AutoSize = true;
            lblRenewings.Location = new System.Drawing.Point(3, 144);
            lblRenewings.Name = "lblRenewings";
            lblRenewings.Size = new System.Drawing.Size(88, 13);
            lblRenewings.TabIndex = 9;
            lblRenewings.Text = "Подновявания*:";
            // 
            // lblIdCombo
            // 
            lblIdCombo.AutoSize = true;
            lblIdCombo.Location = new System.Drawing.Point(210, 40);
            lblIdCombo.Name = "lblIdCombo";
            lblIdCombo.Size = new System.Drawing.Size(19, 13);
            lblIdCombo.TabIndex = 12;
            lblIdCombo.Text = "Id:";
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
            this.tableAdapterManager.ExpensesTableAdapter = null;
            this.tableAdapterManager.InventoryTableAdapter = null;
            this.tableAdapterManager.ProceedsTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.ProvidersTableAdapter = null;
            this.tableAdapterManager.SalariesTableAdapter = null;
            this.tableAdapterManager.SubscriptionsTableAdapter = null;
            this.tableAdapterManager.SuppliesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Thesis.GymDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkersTableAdapter = null;
            this.tableAdapterManager.WorkoutsTableAdapter = null;
            this.tableAdapterManager.WorkSchedulesTableAdapter = null;
            // 
            // clientsBindingNavigator
            // 
            this.clientsBindingNavigator.AddNewItem = null;
            this.clientsBindingNavigator.BindingSource = this.clientsBindingSource;
            this.clientsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.clientsBindingNavigator.CountItemFormat = "от {0}";
            this.clientsBindingNavigator.DeleteItem = null;
            this.clientsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.clientsBindingNavigatorSaveItem,
            this.toolStripSeparator1});
            this.clientsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.clientsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.clientsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.clientsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.clientsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.clientsBindingNavigator.Name = "clientsBindingNavigator";
            this.clientsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.clientsBindingNavigator.Size = new System.Drawing.Size(321, 25);
            this.clientsBindingNavigator.TabIndex = 0;
            this.clientsBindingNavigator.Text = "bindingNavigator1";
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
            // clientsBindingNavigatorSaveItem
            // 
            this.clientsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clientsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("clientsBindingNavigatorSaveItem.Image")));
            this.clientsBindingNavigatorSaveItem.Name = "clientsBindingNavigatorSaveItem";
            this.clientsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.clientsBindingNavigatorSaveItem.Text = "Запиши данните";
            this.clientsBindingNavigatorSaveItem.Click += new System.EventHandler(this.clientsBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // txtId
            // 
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "Id", true));
            this.txtId.Location = new System.Drawing.Point(92, 37);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(111, 20);
            this.txtId.TabIndex = 2;
            this.txtId.DoubleClick += new System.EventHandler(this.txtId_DoubleClick);
            // 
            // dtpSubFrom
            // 
            this.dtpSubFrom.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientsBindingSource, "SubFrom", true));
            this.dtpSubFrom.Location = new System.Drawing.Point(92, 63);
            this.dtpSubFrom.Name = "dtpSubFrom";
            this.dtpSubFrom.Size = new System.Drawing.Size(111, 20);
            this.dtpSubFrom.TabIndex = 4;
            // 
            // dtpSubTo
            // 
            this.dtpSubTo.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientsBindingSource, "SubTo", true));
            this.dtpSubTo.Location = new System.Drawing.Point(92, 89);
            this.dtpSubTo.Name = "dtpSubTo";
            this.dtpSubTo.Size = new System.Drawing.Size(111, 20);
            this.dtpSubTo.TabIndex = 6;
            this.dtpSubTo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtpSubTo_MouseDown);
            // 
            // txtSubId
            // 
            this.txtSubId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "SubId", true));
            this.txtSubId.Location = new System.Drawing.Point(92, 115);
            this.txtSubId.Name = "txtSubId";
            this.txtSubId.Size = new System.Drawing.Size(111, 20);
            this.txtSubId.TabIndex = 8;
            this.txtSubId.DoubleClick += new System.EventHandler(this.txtSubId_DoubleClick);
            // 
            // txtRenewings
            // 
            this.txtRenewings.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "NumberRenewings", true));
            this.txtRenewings.Location = new System.Drawing.Point(92, 141);
            this.txtRenewings.Name = "txtRenewings";
            this.txtRenewings.Size = new System.Drawing.Size(111, 20);
            this.txtRenewings.TabIndex = 10;
            // 
            // comboId
            // 
            this.comboId.FormattingEnabled = true;
            this.comboId.Items.AddRange(new object[] {
            "--Изберете--",
            "Всички Id"});
            this.comboId.Location = new System.Drawing.Point(231, 36);
            this.comboId.Name = "comboId";
            this.comboId.Size = new System.Drawing.Size(84, 21);
            this.comboId.TabIndex = 11;
            this.comboId.SelectedIndexChanged += new System.EventHandler(this.comboId_SelectedIndexChanged);
            // 
            // lblRequired
            // 
            this.lblRequired.AutoSize = true;
            this.lblRequired.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequired.Location = new System.Drawing.Point(34, 164);
            this.lblRequired.Name = "lblRequired";
            this.lblRequired.Size = new System.Drawing.Size(169, 14);
            this.lblRequired.TabIndex = 13;
            this.lblRequired.Text = "Полетата с * са задължителни";
            // 
            // UpdateSubscriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(198)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(321, 192);
            this.Controls.Add(this.lblRequired);
            this.Controls.Add(lblIdCombo);
            this.Controls.Add(this.comboId);
            this.Controls.Add(lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(lblSubFrom);
            this.Controls.Add(this.dtpSubFrom);
            this.Controls.Add(lblSubTo);
            this.Controls.Add(this.dtpSubTo);
            this.Controls.Add(lblSubId);
            this.Controls.Add(this.txtSubId);
            this.Controls.Add(lblRenewings);
            this.Controls.Add(this.txtRenewings);
            this.Controls.Add(this.clientsBindingNavigator);
            this.Name = "UpdateSubscriptionForm";
            this.Text = "Презареждане на месечен абонамент";
            this.Load += new System.EventHandler(this.UpdateSubscriptionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gymDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingNavigator)).EndInit();
            this.clientsBindingNavigator.ResumeLayout(false);
            this.clientsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GymDatabaseDataSet gymDatabaseDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private GymDatabaseDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private GymDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator clientsBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton clientsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DateTimePicker dtpSubFrom;
        private System.Windows.Forms.DateTimePicker dtpSubTo;
        private System.Windows.Forms.TextBox txtSubId;
        private System.Windows.Forms.TextBox txtRenewings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ComboBox comboId;
        private System.Windows.Forms.Label lblRequired;

    }
}