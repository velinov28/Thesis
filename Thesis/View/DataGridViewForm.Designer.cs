namespace Thesis.View
{
    partial class DataGridViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataGridViewForm));
            this.dgvQueryResult = new System.Windows.Forms.DataGridView();
            this.workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gymDatabaseDataSet = new Thesis.GymDatabaseDataSet();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new Thesis.GymDatabaseDataSetTableAdapters.ClientsTableAdapter();
            this.expensesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.expensesTableAdapter = new Thesis.GymDatabaseDataSetTableAdapters.ExpensesTableAdapter();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryTableAdapter = new Thesis.GymDatabaseDataSetTableAdapters.InventoryTableAdapter();
            this.proceedsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proceedsTableAdapter = new Thesis.GymDatabaseDataSetTableAdapters.ProceedsTableAdapter();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new Thesis.GymDatabaseDataSetTableAdapters.ProductsTableAdapter();
            this.providersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.providersTableAdapter = new Thesis.GymDatabaseDataSetTableAdapters.ProvidersTableAdapter();
            this.salariesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salariesTableAdapter = new Thesis.GymDatabaseDataSetTableAdapters.SalariesTableAdapter();
            this.subscriptionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subscriptionsTableAdapter = new Thesis.GymDatabaseDataSetTableAdapters.SubscriptionsTableAdapter();
            this.suppliesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suppliesTableAdapter = new Thesis.GymDatabaseDataSetTableAdapters.SuppliesTableAdapter();
            this.workersTableAdapter = new Thesis.GymDatabaseDataSetTableAdapters.WorkersTableAdapter();
            this.workoutsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workoutsTableAdapter = new Thesis.GymDatabaseDataSetTableAdapters.WorkoutsTableAdapter();
            this.workSchedulesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workSchedulesTableAdapter = new Thesis.GymDatabaseDataSetTableAdapters.WorkSchedulesTableAdapter();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueryResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proceedsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salariesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscriptionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workoutsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workSchedulesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvQueryResult
            // 
            this.dgvQueryResult.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(198)))), ((int)(((byte)(253)))));
            this.dgvQueryResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvQueryResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQueryResult.Location = new System.Drawing.Point(13, 13);
            this.dgvQueryResult.Name = "dgvQueryResult";
            this.dgvQueryResult.Size = new System.Drawing.Size(764, 227);
            this.dgvQueryResult.TabIndex = 0;
            // 
            // workersBindingSource
            // 
            this.workersBindingSource.DataMember = "Workers";
            this.workersBindingSource.DataSource = this.gymDatabaseDataSet;
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
            // expensesBindingSource
            // 
            this.expensesBindingSource.DataMember = "Expenses";
            this.expensesBindingSource.DataSource = this.gymDatabaseDataSet;
            // 
            // expensesTableAdapter
            // 
            this.expensesTableAdapter.ClearBeforeFill = true;
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "Inventory";
            this.inventoryBindingSource.DataSource = this.gymDatabaseDataSet;
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // proceedsBindingSource
            // 
            this.proceedsBindingSource.DataMember = "Proceeds";
            this.proceedsBindingSource.DataSource = this.gymDatabaseDataSet;
            // 
            // proceedsTableAdapter
            // 
            this.proceedsTableAdapter.ClearBeforeFill = true;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.gymDatabaseDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // providersBindingSource
            // 
            this.providersBindingSource.DataMember = "Providers";
            this.providersBindingSource.DataSource = this.gymDatabaseDataSet;
            // 
            // providersTableAdapter
            // 
            this.providersTableAdapter.ClearBeforeFill = true;
            // 
            // salariesBindingSource
            // 
            this.salariesBindingSource.DataMember = "Salaries";
            this.salariesBindingSource.DataSource = this.gymDatabaseDataSet;
            // 
            // salariesTableAdapter
            // 
            this.salariesTableAdapter.ClearBeforeFill = true;
            // 
            // subscriptionsBindingSource
            // 
            this.subscriptionsBindingSource.DataMember = "Subscriptions";
            this.subscriptionsBindingSource.DataSource = this.gymDatabaseDataSet;
            // 
            // subscriptionsTableAdapter
            // 
            this.subscriptionsTableAdapter.ClearBeforeFill = true;
            // 
            // suppliesBindingSource
            // 
            this.suppliesBindingSource.DataMember = "Supplies";
            this.suppliesBindingSource.DataSource = this.gymDatabaseDataSet;
            // 
            // suppliesTableAdapter
            // 
            this.suppliesTableAdapter.ClearBeforeFill = true;
            // 
            // workersTableAdapter
            // 
            this.workersTableAdapter.ClearBeforeFill = true;
            // 
            // workoutsBindingSource
            // 
            this.workoutsBindingSource.DataMember = "Workouts";
            this.workoutsBindingSource.DataSource = this.gymDatabaseDataSet;
            // 
            // workoutsTableAdapter
            // 
            this.workoutsTableAdapter.ClearBeforeFill = true;
            // 
            // workSchedulesBindingSource
            // 
            this.workSchedulesBindingSource.DataMember = "WorkSchedules";
            this.workSchedulesBindingSource.DataSource = this.gymDatabaseDataSet;
            // 
            // workSchedulesTableAdapter
            // 
            this.workSchedulesTableAdapter.ClearBeforeFill = true;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(192)))), ((int)(((byte)(234)))));
            this.btnPrint.Image = global::Thesis.Properties.Resources.print;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.Location = new System.Drawing.Point(783, 13);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(64, 33);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // DataGridViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(198)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(899, 392);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvQueryResult);
            this.Name = "DataGridViewForm";
            this.Text = "DataGridViewForm";
            this.Load += new System.EventHandler(this.DataGridViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueryResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proceedsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salariesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscriptionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workoutsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workSchedulesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQueryResult;
        private GymDatabaseDataSet gymDatabaseDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private GymDatabaseDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.BindingSource expensesBindingSource;
        private GymDatabaseDataSetTableAdapters.ExpensesTableAdapter expensesTableAdapter;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private GymDatabaseDataSetTableAdapters.InventoryTableAdapter inventoryTableAdapter;
        private System.Windows.Forms.BindingSource proceedsBindingSource;
        private GymDatabaseDataSetTableAdapters.ProceedsTableAdapter proceedsTableAdapter;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private GymDatabaseDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
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
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
    }
}