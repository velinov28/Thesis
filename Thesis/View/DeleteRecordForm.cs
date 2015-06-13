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
    public partial class DeleteRecordForm : Form
    {
        TableName choice;

        public DeleteRecordForm(TableName _choice)
        {
            choice = _choice;
            InitializeComponent();
            GetChoice();
        }

        public DeleteRecordForm()
        {
            InitializeComponent();
        }

        private void DeleteRecordForm_Load(object sender, EventArgs e)
        {
            
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
            gb.Visible = true;
            gb.Location = new Point(14, 26);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool result;
            switch (choice)
            {
                case TableName.CLIENTS:
                    result = RemoveClient();
                    if (result)
                        MessageBox.Show("Успешно изтриване на клиент.",
                            "Успешна операция", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Неуспешно изтриване на клиент.",
                            "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case TableName.EXPENSES:
                    result = RemoveExpense();
                    if (result)
                        MessageBox.Show("Успешно изтриване на разход.",
                            "Успешна операция", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Неуспешно изтриване на разход.",
                            "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                    
                case TableName.INVENTORY:
                     result = RemoveInventory();
                    if (result)
                        MessageBox.Show("Успешно изтриване на оборудване.",
                            "Успешна операция", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Неуспешно изтриване на оборудване.",
                            "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case TableName.PROCEEDS:
                    result = RemoveProceed();
                    if (result)
                        MessageBox.Show("Успешно изтриване на приход.",
                            "Успешна операция", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Неуспешно изтриване на приход.",
                            "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case TableName.PRODUCTS:
                    result = RemoveProduct();
                    if (result)
                        MessageBox.Show("Успешно изтриване на продукт.",
                            "Успешна операция", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Неуспешно изтриване на продукт.",
                            "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case TableName.PROVIDERS:
                    result = RemoveProvider();
                    if (result)
                        MessageBox.Show("Успешно изтриване на доставчик.",
                            "Успешна операция", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Неуспешно изтриване на доставчик.",
                            "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case TableName.SALARIES:
                    result = RemoveSalary();
                    if (result)
                        MessageBox.Show("Успешно изтриване на заплата.",
                            "Успешна операция", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Неуспешно изтриване на заплата.",
                            "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case TableName.SUBSCRIPTIONS:
                    result = RemoveSubscription();
                    if (result)
                        MessageBox.Show("Успешно изтриване на абонамент.",
                            "Успешна операция", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Неуспешно изтриване на абонамент.",
                            "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case TableName.SUPPLIES:
                    result = RemoveSupply();
                    if (result)
                        MessageBox.Show("Успешно изтриване на доставка.",
                            "Успешна операция", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Неуспешно изтриване на доставка.",
                            "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case TableName.WORKERS:
                    result = RemoveWorker();
                    if (result)
                        MessageBox.Show("Успешно изтриване на служител.",
                            "Успешна операция", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Неуспешно изтриване на служител.",
                            "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case TableName.WORKOUTS:
                    result = RemoveWorkout();
                    if (result)
                        MessageBox.Show("Успешно изтриване на тренировка.",
                            "Успешна операция", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Неуспешно изтриване на тренировка.",
                            "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case TableName.WORKSCHEDULES:
                    result = RemoveWorkSchedule();
                    if (result)
                        MessageBox.Show("Успешно изтриване на смяна.",
                            "Успешна операция", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Неуспешно изтриване на смяна.",
                            "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            this.Close();
        }
       

        private void GetChoice()
        {
            this.Text = choice.ToString();
            HideAllGroupBoxes();

            switch (choice)
            {
                case TableName.CLIENTS:
                    ShowGroupBox(gbClients);
                    gbClients.Size = new Size(337, 322);
                    this.Size = new Size(385, 435);

                    bindingNavigator1.BindingSource = clientsBindingSource;
                    this.clientsTableAdapter.Fill(this.gymDatabaseDataSet.Clients);

                    btnDelete.Location = new Point(144, 358);
                    break;

                case TableName.EXPENSES:
                    ShowGroupBox(gbExpenses);
                    gbExpenses.Size = new Size(294, 209);
                    this.Size = new Size(340, 320);

                    bindingNavigator1.BindingSource = expensesBindingSource;
                    this.expensesTableAdapter.Fill(this.gymDatabaseDataSet.Expenses);
                    
                    btnDelete.Location = new Point(119, 241);
                    break;

                case TableName.INVENTORY:
                    ShowGroupBox(gbInventory);
                    gbInventory.Size = new Size(319, 301);
                    this.Size = new Size(370, 415);

                    bindingNavigator1.BindingSource = inventoryBindingSource;
                    this.inventoryTableAdapter.Fill(this.gymDatabaseDataSet.Inventory);
                    
                    btnDelete.Location = new Point(126, 337);
                    break;

                case TableName.PROCEEDS:
                    ShowGroupBox(gbProceeds);
                    gbProceeds.Size = new Size(286, 180);
                    this.Size = new Size(330, 295);

                    bindingNavigator1.BindingSource = proceedsBindingSource;
                    this.proceedsTableAdapter.Fill(this.gymDatabaseDataSet.Proceeds);
                    
                    btnDelete.Location = new Point(110, 217);
                    break;

                case TableName.PRODUCTS:
                    ShowGroupBox(gbProducts);
                    gbProducts.Size = new Size(326, 242);
                    this.Size = new Size(365, 355);

                    bindingNavigator1.BindingSource = productsBindingSource;
                    this.productsTableAdapter.Fill(this.gymDatabaseDataSet.Products);
                    
                    btnDelete.Location = new Point(135, 276);
                    break;

                case TableName.PROVIDERS:
                    ShowGroupBox(gbProviders);
                    gbProviders.Size = new Size(280, 204);
                    this.Size = new Size(320, 320);

                    bindingNavigator1.BindingSource = providersBindingSource;
                    this.providersTableAdapter.Fill(this.gymDatabaseDataSet.Providers);
                    
                    btnDelete.Location = new Point(114, 237);
                    break;

                case TableName.SALARIES:
                    ShowGroupBox(gbSalaries);
                    gbSalaries.Size = new Size(233, 150);
                    this.Size = new Size(275, 265);

                    bindingNavigator1.BindingSource = salariesBindingSource;
                    this.salariesTableAdapter.Fill(this.gymDatabaseDataSet.Salaries);
                    
                    btnDelete.Location = new Point(89, 186);
                    break;

                case TableName.SUBSCRIPTIONS:
                    ShowGroupBox(gbSubscriptions);
                    gbSubscriptions.Size = new Size(275, 155);
                    this.Size = new Size(320, 265);

                    bindingNavigator1.BindingSource = subscriptionsBindingSource;
                    this.subscriptionsTableAdapter.Fill(this.gymDatabaseDataSet.Subscriptions);
                    
                    btnDelete.Location = new Point(113, 188);
                    break;

                case TableName.SUPPLIES:
                    ShowGroupBox(gbSupplies);
                    gbSupplies.Size = new Size(306, 201);
                    this.Size = new Size(345, 315);

                    bindingNavigator1.BindingSource = suppliesBindingSource;
                    this.suppliesTableAdapter.Fill(this.gymDatabaseDataSet.Supplies);
                   
                    btnDelete.Location = new Point(127, 235);
                    break;

                case TableName.WORKERS:
                    ShowGroupBox(gbWorkers);
                    gbWorkers.Size = new Size(289, 313);
                    this.Size = new Size(330, 424);

                    bindingNavigator1.BindingSource = workersBindingSource;
                    this.workersTableAdapter.Fill(this.gymDatabaseDataSet.Workers);
                   
                    btnDelete.Location = new Point(114, 346);
                    break;

                case TableName.WORKOUTS:
                    ShowGroupBox(gbWorkouts);
                    gbWorkouts.Size = new Size(233, 197);
                    this.Size = new Size(273, 310);

                    bindingNavigator1.BindingSource = workoutsBindingSource;
                    this.workoutsTableAdapter.Fill(this.gymDatabaseDataSet.Workouts);
                    
                    btnDelete.Location = new Point(87, 231);
                    break;

                case TableName.WORKSCHEDULES:
                    ShowGroupBox(gbWorkSchedules);
                    gbWorkSchedules.Size = new Size(260, 154);
                    this.Size = new Size(300, 268);

                    bindingNavigator1.BindingSource = workSchedulesBindingSource;
                    this.workSchedulesTableAdapter.Fill(this.gymDatabaseDataSet.WorkSchedules);
                    
                    btnDelete.Location = new Point(103, 190);
                    break;
            }
        }

        bool RemoveClient()
        {
            int id = Convert.ToInt32(txtIdC.Text);

            ClientsDataContext cl = new ClientsDataContext();
            try
            {
                cl.DeleteClient(id);
                cl.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        bool RemoveExpense()
        {
            int id = Convert.ToInt32(txtIdE.Text);

            ExpensesDataContext exp = new ExpensesDataContext();
            try
            {
                exp.DeleteExpense(id);
                exp.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        bool RemoveInventory()
        {
            int id = Convert.ToInt32(txtIdInv.Text);

            InventoryDataContext inv = new InventoryDataContext();
            try
            {
                inv.DeleteInventory(id);
                inv.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        bool RemoveProceed()
        {
            int id = Convert.ToInt32(txtIdProc.Text);

            ProceedsDataContext proc = new ProceedsDataContext();
            try
            {
                proc.DeleteProceed(id);
                proc.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        bool RemoveProduct()
        {
            int id = Convert.ToInt32(txtIdProd.Text);

            ProductsDataContext prod = new ProductsDataContext();
            try
            {
                prod.DeleteProduct(id);
                prod.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        bool RemoveProvider()
        {
            int id = Convert.ToInt32(txtIdProv.Text);

            ProvidersDataContext prov = new ProvidersDataContext();
            try
            {
                prov.DeleteProvider(id);
                prov.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        bool RemoveSalary()
        {
            int id = Convert.ToInt32(txtIdSal.Text);

            SalariesDataContext sal = new SalariesDataContext();
            try
            {
                sal.DeleteSalary(id);
                sal.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        bool RemoveSubscription()
        {
            int id = Convert.ToInt32(txtIdSub.Text);

            SubscriptionsDataContext sub = new SubscriptionsDataContext();
            try
            {
                sub.DeleteSubscription(id);
                sub.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        bool RemoveSupply()
        {
            int id = Convert.ToInt32(txtIdSup.Text);

            SuppliesDataContext sup = new SuppliesDataContext();
            try
            {
                sup.DeleteSupply(id);
                sup.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        bool RemoveWorker()
        {
            int id = Convert.ToInt32(txtIdW.Text);

            WorkersDataContext wrk = new WorkersDataContext();
            try
            {
                wrk.DeleteWorker(id);
                wrk.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        bool RemoveWorkout()
        {
            int id = Convert.ToInt32(txtIdWO.Text);

            WorkoutsDataContext wo = new WorkoutsDataContext();
            try
            {
                wo.DeleteWorkout(id);
                wo.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        bool RemoveWorkSchedule()
        {
            int id = Convert.ToInt32(txtIdWS.Text);

            WorkSchedulesDataContext ws = new WorkSchedulesDataContext();
            try
            {
                ws.DeleteWorkSchedule(id);
                ws.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}