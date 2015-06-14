using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Thesis.Model;

namespace Thesis.View
{
    public partial class UpdateRecordForm : Form
    {
        TableName choice;
        Worker w;
        int flag;

        public UpdateRecordForm(TableName _choice)
        {
            choice = _choice;
            flag = 0;

            InitializeComponent();
        }

        public UpdateRecordForm(TableName _choice, Worker _w)
        {
            choice = _choice;
            w = _w;
            flag = 0;

            InitializeComponent();
        }

        public UpdateRecordForm(TableName _choice, Worker _w, int _flag)
        {
            choice = _choice;
            w = _w;
            flag = _flag;

            InitializeComponent();
        }

        private void UpdateRecordForm_Load(object sender, EventArgs e)
        {
            switch (choice)
            {
                case TableName.CLIENTS:
                    tableBindingNavigator.BindingSource = clientsBindingSource;
                    this.clientsTableAdapter.Fill(this.gymDatabaseDataSet.Clients);
                    ShowGroupBox(gbClients);
                    break;
                case TableName.EXPENSES:
                    tableBindingNavigator.BindingSource = expensesBindingSource;
                    this.expensesTableAdapter.Fill(this.gymDatabaseDataSet.Expenses);
                    ShowGroupBox(gbExpenses);
                    break;
                case TableName.INVENTORY:
                    tableBindingNavigator.BindingSource = inventoryBindingSource;
                    this.inventoryTableAdapter.Fill(this.gymDatabaseDataSet.Inventory);
                    ShowGroupBox(gbInventory);
                    break;
                case TableName.PROCEEDS:
                    tableBindingNavigator.BindingSource = proceedsBindingSource;
                    this.proceedsTableAdapter.Fill(this.gymDatabaseDataSet.Proceeds);
                    ShowGroupBox(gbProceeds);
                    break;
                case TableName.PRODUCTS:
                    tableBindingNavigator.BindingSource = productsBindingSource;
                    this.productsTableAdapter.Fill(this.gymDatabaseDataSet.Products);
                    ShowGroupBox(gbProducts);
                    break;
                case TableName.PROVIDERS:
                    tableBindingNavigator.BindingSource = providersBindingSource;
                    this.providersTableAdapter.Fill(this.gymDatabaseDataSet.Providers);
                    ShowGroupBox(gbProviders);
                    break;
                case TableName.SALARIES:
                    tableBindingNavigator.BindingSource = salariesBindingSource;
                    this.salariesTableAdapter.Fill(this.gymDatabaseDataSet.Salaries);
                    ShowGroupBox(gbSalaries);
                    break;
                case TableName.SUBSCRIPTIONS:
                    tableBindingNavigator.BindingSource = subscriptionsBindingSource;
                    this.subscriptionsTableAdapter.Fill(this.gymDatabaseDataSet.Subscriptions);
                    ShowGroupBox(gbSubscriptions);
                    break;
                case TableName.SUPPLIES:
                    tableBindingNavigator.BindingSource = suppliesBindingSource;
                    this.suppliesTableAdapter.Fill(this.gymDatabaseDataSet.Supplies);
                    ShowGroupBox(gbSupplies);
                    break;
                case TableName.WORKERS:
                    tableBindingNavigator.BindingSource = workersBindingSource;
                    if (flag == 7)
                    {
                        this.workersTableAdapter.FillById(this.gymDatabaseDataSet.Workers, w.Id);
                        bindingNavigatorCountItem.Enabled = false;
                        bindingNavigatorMoveFirstItem.Enabled = false;
                        bindingNavigatorMoveLastItem.Enabled = false;
                        bindingNavigatorMoveNextItem.Enabled = false;
                        bindingNavigatorMovePreviousItem.Enabled = false;
                        bindingNavigatorPositionItem.Enabled = false;
                    }
                    else
                        this.workersTableAdapter.Fill(this.gymDatabaseDataSet.Workers);
                    ShowGroupBox(gbWorkers);
                    break;
                case TableName.WORKOUTS:
                    tableBindingNavigator.BindingSource = workoutsBindingSource;
                    this.workoutsTableAdapter.Fill(this.gymDatabaseDataSet.Workouts);
                    ShowGroupBox(gbWorkouts);
                    break;
                case TableName.WORKSCHEDULES:
                    tableBindingNavigator.BindingSource = workSchedulesBindingSource;
                    this.workSchedulesTableAdapter.Fill(this.gymDatabaseDataSet.WorkSchedules);
                    ShowGroupBox(gbWorkSchedules);
                    break;
            }
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Сигурни ли сте, че искате да промените този запис?",
                        "Въпрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    this.Validate();
                    switch (choice)
                    {
                        case TableName.CLIENTS:
                            this.clientsBindingSource.EndEdit();
                            break;
                        case TableName.EXPENSES:
                            this.expensesBindingSource.EndEdit();
                            break;
                        case TableName.INVENTORY:
                            this.inventoryBindingSource.EndEdit();
                            break;
                        case TableName.PROCEEDS:
                            this.proceedsBindingSource.EndEdit();
                            break;
                        case TableName.PRODUCTS:
                            this.productsBindingSource.EndEdit();
                            break;
                        case TableName.PROVIDERS:
                            this.providersBindingSource.EndEdit();
                            break;
                        case TableName.SALARIES:
                            this.salariesBindingSource.EndEdit();
                            break;
                        case TableName.SUBSCRIPTIONS:
                            this.subscriptionsBindingSource.EndEdit();
                            break;
                        case TableName.SUPPLIES:
                            this.suppliesBindingSource.EndEdit();
                            break;
                        case TableName.WORKERS:
                            this.workersBindingSource.EndEdit();
                            break;
                        case TableName.WORKOUTS:
                            this.workoutsBindingSource.EndEdit();
                            break;
                        case TableName.WORKSCHEDULES:
                            this.workSchedulesBindingSource.EndEdit();
                            break;
                    }
                    this.tableAdapterManager.UpdateAll(this.gymDatabaseDataSet);
                    MessageBox.Show("Успешно обновени данни.", "Успешна операция", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception)
                {
                    MessageBox.Show("Не е извършена промяна.");
                }

                this.Close();
            }
        }

        private void HideAllGroupBoxes()
        {
            gbClients.Visible = false;
            gbExpenses.Visible = false;
            gbInventory.Visible = false;
            gbProceeds.Visible = false;
            gbProducts.Visible = false;
            gbProviders.Visible = false;
            gbSalaries.Visible = false;
            gbSubscriptions.Visible = false;
            gbSupplies.Visible = false;
            gbWorkers.Visible = false;
            gbWorkouts.Visible = false;
            gbWorkSchedules.Visible = false;
        }

        private void ShowGroupBox(GroupBox gb)
        {
            this.Text = choice.ToString();
            HideAllGroupBoxes();
            gb.Visible = true;
            gb.Location = new Point(14, 26);

            switch (choice)
            {
                case TableName.CLIENTS:
                    gb.Size = new Size(337, 342);
                    this.Size = new Size(385, 420);
                    lblRequired.Location = new Point(100, 345);
                    break;

                case TableName.EXPENSES:
                    
                    gb.Size = new Size(294, 225);
                    this.Size = new Size(340, 310);
                    lblRequired.Location = new Point(80, 230);
                    break;

                case TableName.INVENTORY:
                    gb.Size = new Size(319, 320);
                    this.Size = new Size(370, 400);
                    lblRequired.Location = new Point(85, 325);
                    break;

                case TableName.PROCEEDS:
                    gb.Size = new Size(286, 190);
                    this.Size = new Size(330, 270);
                    lblRequired.Location = new Point(70, 195);
                    break;

                case TableName.PRODUCTS:
                    gb.Size = new Size(326, 260);
                    this.Size = new Size(365, 330);
                    lblRequired.Location = new Point(85, 265);
                    break;

                case TableName.PROVIDERS:
                    gb.Size = new Size(280, 220);
                    this.Size = new Size(320, 300);
                    lblRequired.Location = new Point(70, 225);
                    break;

                case TableName.SALARIES:
                    gb.Size = new Size(233, 170);
                    this.Size = new Size(275, 240);
                    lblRequired.Location = new Point(50, 175);
                    break;

                case TableName.SUBSCRIPTIONS:
                    gb.Size = new Size(275, 165);
                    this.Size = new Size(320, 240);
                    lblRequired.Location = new Point(70, 170);
                    break;

                case TableName.SUPPLIES:
                    gb.Size = new Size(306, 218);
                    this.Size = new Size(345, 290);
                    lblRequired.Location = new Point(85, 223);
                    break;

                case TableName.WORKERS:
                    gb.Size = new Size(289, 320);
                    this.Size = new Size(330, 395);
                    lblRequired.Location = new Point(75, 328);
                    break;

                case TableName.WORKOUTS:
                    gb.Size = new Size(233, 207);
                    this.Size = new Size(273, 280);
                    lblRequired.Location = new Point(50, 215);
                    break;

                case TableName.WORKSCHEDULES:
                    gb.Size = new Size(260, 165);
                    this.Size = new Size(300, 240);
                    lblRequired.Location = new Point(60, 172);
                    break;
            }
        }

        private void txtProvIdInv_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewForm dgProviders = new DataGridViewForm(TableName.PROVIDERS);
            dgProviders.Show();
        }

        private void txtClientIdProc_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewForm dgClients = new DataGridViewForm(TableName.CLIENTS);
            dgClients.Show();
        }

        private void txtSubIdC_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewForm dgSubscriptions = new DataGridViewForm(TableName.SUBSCRIPTIONS);
            dgSubscriptions.Show();
        }

        private void txtCoachIdC_DoubleClick(object sender, EventArgs e)
        {
            flag = 2;
            DataGridViewForm dgWorkers = new DataGridViewForm(TableName.WORKERS, w, flag); //Частична информация
            dgWorkers.Show();
        }

        private void txtProvIdProd_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewForm dgProviders = new DataGridViewForm(TableName.PROVIDERS);
            dgProviders.Show();
        }

        private void txtProviderIdSup_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewForm dgProviders = new DataGridViewForm(TableName.PROVIDERS);
            dgProviders.Show();
        }

        private void txtWorkerIdSal_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewForm dgWorkers = new DataGridViewForm(TableName.WORKERS);
            dgWorkers.Show();
        }

        private void txtCoachIdWO_DoubleClick(object sender, EventArgs e)
        {
            flag = 2;
            DataGridViewForm dgWorkers = new DataGridViewForm(TableName.WORKERS, w, flag);
            dgWorkers.Show();
        }

        private void txtClientIdWO_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewForm dgClients = new DataGridViewForm(TableName.CLIENTS);
            dgClients.Show();
        }

        private void txtSupplyIdE_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewForm dgSupplies = new DataGridViewForm(TableName.SUPPLIES);
            dgSupplies.Show();
        }

        private void txtSalaryIdE_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewForm dgSalaries = new DataGridViewForm(TableName.SALARIES, w, 1);
            dgSalaries.Show();
        }

        private void txtWorkerIdWS_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewForm dgWorkers = new DataGridViewForm(TableName.WORKERS);
            dgWorkers.Show();
        }    
    }
}
