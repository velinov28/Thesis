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
    public partial class AddRecordForm : Form
    {
        TableName choice;
        Worker w;
        int flag;

        public AddRecordForm(TableName _choice)
        {
            choice = _choice;

            InitializeComponent();
            this.Text = choice.ToString();
            ShowChoice();
        }

        public AddRecordForm(TableName _choice, Worker _w, int _flag)
        {
            choice = _choice;
            w = _w;
            flag = _flag;
            
            InitializeComponent();
            this.Text = choice.ToString();
            ShowChoice();
        }

        public AddRecordForm()
        {
            InitializeComponent();
        }

        private void AddRecordForm_Load(object sender, EventArgs e)
        {
           
        }

        private void ShowChoice()
        {
            HideAllGroupBoxes();

            switch (choice)
            {
                case TableName.CLIENTS:
                    ShowGroupBox(gbClients);
                    gbClients.Size = new Size(335, 325);
                    this.Size = new Size(400, 430);
                    lblRequired.Location = new Point(100, 320);
                    btnAdd.Location = new Point(150, 350);
                    break;
                case TableName.EXPENSES:
                    ShowGroupBox(gbExpenses);
                    gbExpenses.Size = new Size(315, 190);
                    this.Size = new Size(370, 290);
                    lblRequired.Location = new Point(90, 185);
                    btnAdd.Location = new Point(140, 210);
                    break;
                case TableName.INVENTORY:
                    ShowGroupBox(gbInventory);
                    gbInventory.Size = new Size(342, 310);
                    this.Size = new Size(400, 410);
                    lblRequired.Location = new Point(100, 300);
                    btnAdd.Location = new Point(150, 330);
                    break;
                case TableName.PROCEEDS:
                    ShowGroupBox(gbProceeds);
                    gbProceeds.Size = new Size(302, 165);
                    this.Size = new Size(360, 265);
                    lblRequired.Location = new Point(90, 155);
                    btnAdd.Location = new Point(140, 180);
                    break;
                case TableName.PRODUCTS:
                    ShowGroupBox(gbProducts);
                    gbProducts.Size = new Size(330, 240);
                    this.Size = new Size(390, 335);
                    lblRequired.Location = new Point(100, 230);
                    btnAdd.Location = new Point(150, 260);
                    break;
                case TableName.PROVIDERS:
                    ShowGroupBox(gbProviders);
                    gbProviders.Size = new Size(300, 195);
                    this.Size = new Size(340, 285);
                    lblRequired.Location = new Point(75, 188);
                    btnAdd.Location = new Point(125, 210);
                    break;
                case TableName.SALARIES:
                    ShowGroupBox(gbSalaries);
                    gbSalaries.Size = new Size(216, 140);
                    this.Size = new Size(255, 235);
                    lblRequired.Location = new Point(35, 133);
                    btnAdd.Location = new Point(85, 158);
                    break;
                case TableName.SUBSCRIPTIONS:
                    ShowGroupBox(gbSubscriptions);
                    gbSubscriptions.Size = new Size(306, 150);
                    this.Size = new Size(346, 240);
                    lblRequired.Location = new Point(80, 140);
                    btnAdd.Location = new Point(130, 165);
                    break;
                case TableName.SUPPLIES:
                    ShowGroupBox(gbSupplies);
                    gbSupplies.Size = new Size(310, 190);
                    this.Size = new Size(355, 280);
                    lblRequired.Location = new Point(85, 185);
                    btnAdd.Location = new Point(135, 205);
                    break;
                case TableName.WORKERS:
                    ShowGroupBox(gbWorkers);
                    gbWorkers.Size = new Size(322, 310);
                    this.Size = new Size(370, 400);
                    lblRequired.Location = new Point(88, 300);
                    btnAdd.Location = new Point(138, 325);
                    break;
                case TableName.WORKOUTS:
                    ShowGroupBox(gbWorkouts);
                    gbWorkouts.Size = new Size(224, 200);
                    this.Size = new Size(264, 290);
                    lblRequired.Location = new Point(40, 192);
                    btnAdd.Location = new Point(90, 215);
                    break;
                case TableName.WORKSCHEDULES:
                    ShowGroupBox(gbWorkSchedules);
                    gbWorkSchedules.Size = new Size(300, 150);
                    this.Size = new Size(340, 240);
                    lblRequired.Location = new Point(78, 140);
                    btnAdd.Location = new Point(128, 165);
                    break;
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
            gb.Visible = true;
            gb.Location = new Point(12, 12);
        }

        private void txtCoachIdC_DoubleClick(object sender, EventArgs e)
        {
            flag = 2;
            DataGridViewForm dgWorkers = new DataGridViewForm(TableName.WORKERS, w, flag); //flag = 2 - частична информация
            dgWorkers.Show();
        }

        private void txtSubIdC_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewForm dgSubscriptions = new DataGridViewForm(TableName.SUBSCRIPTIONS);
            dgSubscriptions.Show();
        }

        private void txtProvIdProd_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewForm dgProviders = new DataGridViewForm(TableName.PROVIDERS);
            dgProviders.Show();
        }

        private void txtWorkerIdWS_DoubleClick(object sender, EventArgs e)
        {
            flag = 1;
            DataGridViewForm dgWorkers = new DataGridViewForm(TableName.WORKERS, w, flag);
            dgWorkers.Show();
        }

        private void txtWorkerIdSal_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewForm dgWorkers = new DataGridViewForm(TableName.WORKERS);
            dgWorkers.Show();
        }

        private void txtClientIdProc_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewForm dgClients = new DataGridViewForm(TableName.CLIENTS);
            dgClients.Show();
        }

        private void txtProviderIdSup_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewForm dgProviders = new DataGridViewForm(TableName.PROVIDERS);
            dgProviders.Show();
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

        private void txtProvIdInv_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewForm dgProviders = new DataGridViewForm(TableName.PROVIDERS);
            dgProviders.Show();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool result;
            switch (choice)
            {
                case TableName.CLIENTS:
                    result = InsertClient();
                    if (result)
                        MessageBox.Show("Успешно въвеждане на клиент.",
                        "Успешна операция", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Неуспешно въвеждане на клиент.",
                            "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case TableName.EXPENSES:
                    result = InsertExpense();
                    if (result)
                        MessageBox.Show("Успешно въвеждане на разход.",
                            "Успешна операция", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Неуспешно въвеждане на разход.",
                            "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                    
                case TableName.INVENTORY:
                     result = InsertInventory();
                    if (result)
                        MessageBox.Show("Успешно въвеждане на оборудване.",
                            "Успешна операция", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Неуспешно въвеждане на оборудване.",
                            "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case TableName.PROCEEDS:
                    result = InsertProceed();
                    if (result)
                        MessageBox.Show("Успешно въвеждане на приход.",
                            "Успешна операция", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Неуспешно въвеждане на приход.",
                            "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case TableName.PRODUCTS:
                    result = InsertProduct();
                    if (result)
                        MessageBox.Show("Успешно въвеждане на продукт.",
                            "Успешна операция", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Неуспешно въвеждане на продукт.",
                            "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case TableName.PROVIDERS:
                    result = InsertProvider();
                    if (result)
                        MessageBox.Show("Успешно въвеждане на доставчик.",
                            "Успешна операция", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Неуспешно въвеждане на доставчик.",
                            "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case TableName.SALARIES:
                    result = InsertSalary();
                    if (result)
                        MessageBox.Show("Успешно въвеждане на заплата.",
                            "Успешна операция", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Неуспешно въвеждане на заплата.",
                            "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case TableName.SUBSCRIPTIONS:
                    result = InsertSubscription();
                    if (result)
                        MessageBox.Show("Успешно въвеждане на абонамент.",
                            "Успешна операция", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Неуспешно въвеждане на абонамент.",
                            "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case TableName.SUPPLIES:
                    result = InsertSupply();
                    if (result)
                        MessageBox.Show("Успешно въвеждане на доставка.",
                            "Успешна операция", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Неуспешно въвеждане на доставка.",
                            "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case TableName.WORKERS:
                    result = InsertWorker();
                    if (result)
                        MessageBox.Show("Успешно въвеждане на служител.",
                            "Успешна операция", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Неуспешно въвеждане на служител.",
                            "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case TableName.WORKOUTS:
                    result = InsertWorkout();
                    if (result)
                        MessageBox.Show("Успешно въвеждане на тренировка.",
                            "Успешна операция", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Неуспешно въвеждане на тренировка.",
                            "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case TableName.WORKSCHEDULES:
                    result = InsertWorkSchedule();
                    if (result)
                        MessageBox.Show("Успешно въвеждане на смяна.",
                            "Успешна операция", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Неуспешно въвеждане на смяна.",
                            "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            this.Close();
        }

        bool InsertClient()
        {
            Client c = new Client();

            string subFrom = dtpSubFromC.Text;
            string subTo = dtpSubToC.Text;
            string subId = txtSubIdC.Text;
            string addedAt = dtpAddedAtC.Text;
            string numberRenewings = txtRenewsC.Text;
            string coachId = txtCoachIdC.Text;
            //string bonus = checkBonusC.Text;
            //DateTime dt = Convert.ToDateTime(subFrom);

            if (txtFirstNameC.Text == "" || txtLastNameC.Text == "" || txtRenewsC.Text == "")
            {
                MessageBox.Show("Не сте попълнили всички задължителни полета",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            try
            {
                c.FirstName = txtFirstNameC.Text;
                c.LastName = txtLastNameC.Text;
                c.SubFrom = Convert.ToDateTime(subFrom);
                c.SubTo = Convert.ToDateTime(subTo);
                c.SubId = Convert.ToInt32(subId);
                c.AddedAt = Convert.ToDateTime(addedAt);
                c.NumberRenewings = Convert.ToInt32(numberRenewings);
                if (txtEmailC.Text == "null" || txtEmailC.Text == "")
                    c.Email = null;
                else
                    c.Email = txtEmailC.Text;
                if (txtPhoneC.Text == "null" || txtPhoneC.Text == "")
                    c.PhoneNumber = null;
                else
                    c.PhoneNumber = txtPhoneC.Text;
                if (coachId == "0" || coachId == "null" || coachId == "")
                    c.CoachId = null;
                else
                    c.CoachId = Convert.ToInt32(coachId);
                c.Bonus = checkBonusC.Checked;
            }

            catch (Exception)
            {
                MessageBox.Show("Въвели сте данни в некоректен формат в някое от полетата.",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            ClientsDataContext cl = new ClientsDataContext();
            try
            {
                cl.AddClient(c.FirstName, c.LastName, c.SubFrom, c.SubTo, c.SubId, c.AddedAt, c.NumberRenewings, c.Email, c.PhoneNumber, c.CoachId, c.Bonus);
                cl.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
         
        }

        bool InsertExpense()
        {
            Expense e = new Expense();

            string cost = txtCostE.Text;
            string date = dtpDateE.Text;
            string supplyId = txtSupplyIdE.Text;
            string salaryId = txtSalaryIdE.Text;

            if (txtCostE.Text == "" || txtDescriptE.Text == "")
            {
                MessageBox.Show("Не сте попълнили всички задължителни полета",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            try
            {
                e.Cost = Convert.ToDecimal(cost);
                e.Date = Convert.ToDateTime(date);

                if (supplyId == "0" || supplyId == "null" || supplyId == "")
                    e.SupplyId = null;
                else
                    e.SupplyId = Convert.ToInt32(supplyId);
                if (salaryId == "0" || salaryId == "null" || salaryId == "")
                    e.SalaryId = null;
                else
                    e.SalaryId = Convert.ToInt32(salaryId);
                e.Description = txtDescriptE.Text;
                e.Amount = txtAmountE.Text;

                if ((e.SalaryId == null && e.SupplyId == null) ||
                    (e.SalaryId != null && e.SupplyId != null))
                {
                    MessageBox.Show("Задължително едно от полетата №заплата " +
                        "или №доставка трябва да е null, а другото различно от null",
                        "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            catch(Exception)
            {
                MessageBox.Show("Въвели сте данни в некоректен формат в някое от полетата.",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


           ExpensesDataContext exp = new ExpensesDataContext();
           try
            {
                exp.AddExpense(e.Cost, e.Date, e.SupplyId, e.SalaryId, e.Description, e.Amount);
                exp.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
               return false;
            }
        }

        bool InsertInventory()
        {
            Inventory inv = new Inventory();

            string deliveryDate = dtpDelDateInv.Text;
            string numberOfRepairs = txtRepairsInv.Text;
            string expirationDate = dtpExpDateInv.Text;
            string futureDateChange = dtpChangeDateInv.Text;
            string deliveryPrice = txtDelPriceInv.Text;
            string providerId = txtProvIdInv.Text;
            int type = comboTypeInv.SelectedIndex;

            if (txtNameInv.Text == "" || txtAmountInv.Text == "" || txtDelPriceInv.Text == "")
            {
                MessageBox.Show("Не сте попълнили всички задължителни полета.",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            try
            {
                inv.Name = txtNameInv.Text;

                switch (type)
                {
                    case 1:
                        inv.Type = "Машина";
                        break;
                    case 2:
                        inv.Type = "Свободна тежест";
                        break;
                    case 3:
                        inv.Type = "Диск";
                        break;
                    case 4:
                        inv.Type = "Аксесоар";
                        break;
                    case 5:
                        inv.Type = "Друго";
                        break;
                }

                inv.Brand = txtBrandInv.Text;
                inv.Amount = txtAmountInv.Text;

                if (checkDelDateNullInv.Checked == true)
                    inv.DeliveryDate = null;
                else
                    inv.DeliveryDate = Convert.ToDateTime(deliveryDate);

                if (numberOfRepairs == "0" || numberOfRepairs == "null" || numberOfRepairs == "")
                    inv.NumberOfRepairs = null;
                else
                    inv.NumberOfRepairs = Convert.ToInt32(numberOfRepairs);

                if (checkExpDateNullInv.Checked == true)
                    inv.ExpirationDate = null;
                else
                    inv.ExpirationDate = Convert.ToDateTime(expirationDate);

                if (checkChangeDateNullInv.Checked == true)
                    inv.FutureDateChange = null;
                else
                    inv.FutureDateChange = Convert.ToDateTime(futureDateChange); 

                inv.DeliveryPrice = Convert.ToDecimal(deliveryPrice);
                if (providerId == "0" || providerId == "null" || providerId == "")
                    inv.ProviderId = null;
                else
                    inv.ProviderId = Convert.ToInt32(providerId);
            }

            catch (Exception)
            {
                MessageBox.Show("Въвели сте данни в некоректен формат в някое от полетата.",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            InventoryDataContext invent = new InventoryDataContext();
            try
            {
                invent.AddInventory(inv.Name, inv.Type, inv.Brand, inv.Amount, inv.DeliveryDate, inv.NumberOfRepairs,inv.ExpirationDate, inv.FutureDateChange, inv.DeliveryPrice, inv.ProviderId);
                invent.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
         
        }

        bool InsertProceed()
        {
            Proceed pr = new Proceed();

            string cost = txtCostProc.Text;
            string date = dtpDateProc.Text;
            string clientId = txtClientIdProc.Text;
            string amount = txtAmountProc.Text;

            if (txtCostProc.Text == "" || txtClientIdProc.Text == "" || txtDescProc.Text == "")
            {
                MessageBox.Show("Не сте попълнили всички задължителни полета.",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            try
            {
                pr.Cost = Convert.ToDecimal(cost);
                pr.Date = Convert.ToDateTime(date);
                pr.ClientId = Convert.ToInt32(clientId);
                pr.Description = txtDescProc.Text;
                if (amount == "0" || amount == "null" || amount == "")
                    pr.Amount = null;
                else
                    pr.Amount = amount;
            }

            catch (Exception)
            {
                MessageBox.Show("Въвели сте данни в некоректен формат в някое от полетата.",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            ProceedsDataContext proc = new ProceedsDataContext();
            try
            {
                proc.AddProceed(pr.Cost, pr.Date, pr.ClientId, pr.Description, pr.Amount);
                proc.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        bool InsertProduct()
        {
            Product pr = new Product();

            int type = comboCategoryProd.SelectedIndex;

            string lastDeliveryDate = dtpLDDProd.Text;
            string futureDeliveryDate = dtpFDDProd.Text;
            string salePrice = txtSalePriceProd.Text;
            string providerId = txtProvIdProd.Text;

            if(txtNameProd.Text=="" || txtAmountProd.Text=="" || txtSalePriceProd.Text=="")
            {
                MessageBox.Show("Не сте попълнили всички задължителни полета",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            try
            {
                pr.Name = txtNameProd.Text;
                pr.Amount = txtAmountProd.Text;
                pr.Barcode = txtBarcodeProd.Text;
                switch (type)
                {
                    case 1:
                        pr.Category = "Протеини";
                        break;
                    case 2:
                        pr.Category = "Аминокиселини";
                        break;
                    case 3:
                        pr.Category = "Витамини";
                        break;
                    case 4:
                        pr.Category = "Азотни бустери";
                        break;
                    case 5:
                        pr.Category = "Безалкохолни напитки";
                        break;
                    case 6:
                        pr.Category = "Протеинови вафли";
                        break;
                    case 7:
                        pr.Category = "Други";
                        break;
                }
                pr.LastDeliveryDate = Convert.ToDateTime(lastDeliveryDate);
                if (checkFDDNullProd.Checked == true)
                    pr.FutureDeliveryDate = null;
                else
                    pr.FutureDeliveryDate = Convert.ToDateTime(futureDeliveryDate);

                pr.SalePrice = Convert.ToDecimal(salePrice);

                if (providerId == "0" || providerId == "null" || providerId == "")
                    pr.ProviderId = null;
                else
                    pr.ProviderId = Convert.ToInt32(providerId);
            }

            catch (Exception)
            {
                MessageBox.Show("Въвели сте данни в некоректен формат в някое от полетата.",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            ProductsDataContext prod = new ProductsDataContext();
            try
            {
                prod.AddProduct(pr.Name, pr.Amount, pr.Barcode, pr.Category, pr.LastDeliveryDate, pr.FutureDeliveryDate, pr.SalePrice, pr.ProviderId);
                prod.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        bool InsertProvider()
        {
            Provider pr = new Provider();

            double number;

            pr.CompanyName = txtCompNameProv.Text; //.Trim() ако не ме мързи 
            pr.Address = txtAddrProv.Text;
            pr.Email = txtEmailProv.Text;
            pr.PhoneNumber = txtPhoneProv.Text;

            if (txtCompNameProv.Text == "" || txtAddrProv.Text == "" ||
                txtAddrProv.Text == "" || txtEmailProv.Text == "")
            {
                MessageBox.Show("Не сте попълнили всички задължителни полета.",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtAPNProv.Text == "0" || txtAPNProv.Text == "null" || txtAPNProv.Text == "")
                pr.AccountablePersonName = null;
            else
                pr.AccountablePersonName = txtAPNProv.Text;
            if (txtAPPINProv.Text == "0" || txtAPPINProv.Text == "null" || txtAPPINProv.Text == "")
                pr.AccountablePersonPIN = null;
            else
                pr.AccountablePersonPIN = txtAPPINProv.Text;

            try
            {
                number = Convert.ToDouble(txtPhoneProv.Text);
                if(pr.AccountablePersonPIN !=null)
                   number = Convert.ToDouble(txtAPPINProv.Text);
            }

            catch (Exception)
            {
                MessageBox.Show("Въвели сте данни в некоректен формат в някое от полетата.",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
           
            ProvidersDataContext prov = new ProvidersDataContext();
            try
            {
                prov.AddProvider(pr.CompanyName, pr.Address, pr.Email, pr.PhoneNumber, pr.AccountablePersonName, pr.AccountablePersonPIN);
                prov.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        bool InsertSalary()
        {
            Salary s = new Salary();

            string workerId = txtWorkerIdSal.Text;
            string date = dtpDateSal.Text;
            string salary = txtSalarySal.Text;
            string bonus = txtBonusSal.Text;

            if (txtWorkerIdSal.Text == "" || txtSalarySal.Text == "")
            {
                MessageBox.Show("Не сте попълнили всички задължителни полета",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            try
            {
                s.WorkerId = Convert.ToInt32(workerId);
                s.Date = Convert.ToDateTime(date);
                s.Salaryy = Convert.ToDecimal(salary);
                if (bonus == "0" || bonus == "null" || bonus == "")
                    s.Bonus = null;
                else
                    s.Bonus = Convert.ToDecimal(bonus);
            }

            catch (Exception)
            {
                MessageBox.Show("Въвели сте данни в некоректен формат в някое от полетата.",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            SalariesDataContext sal = new SalariesDataContext();
            try
            {
                sal.AddSalary(s.WorkerId, s.Date, s.Salaryy, s.Bonus);
                sal.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        bool InsertSubscription()
        {
            Subscription s = new Subscription();

            string price = txtPriceSub.Text;
            string duration = numDurationSub.Text;
            string visits = numVisitsSub.Text;

            if (txtNameSub.Text == "" || txtPriceSub.Text == "")
            {
                MessageBox.Show("Не сте попълнили всички задължителни полета.",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            try
            {
                s.Name = txtNameSub.Text;
                s.Price = Convert.ToDecimal(price);
                s.Duration_months = Convert.ToInt32(duration);
                if (visits == "0" || visits == "null" || visits == "")
                    s.Visits = 0;
                else
                    s.Visits = Convert.ToInt32(visits);
            }
            catch (Exception)
            {
                MessageBox.Show("Въвели сте данни в некоректен формат в някое от полетата.",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            SubscriptionsDataContext sub = new SubscriptionsDataContext();
            try
            {
                sub.AddSubscription(s.Name, s.Price, s.Duration_months, s.Visits);
                sub.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        bool InsertSupply()
        {
            Supply s = new Supply();

            string providerId = txtProviderIdSup.Text;
            string date = dtpDateSup.Text;
            string delPrice = txtDelPriceSup.Text;
            string salePrice = txtSalePriceSup.Text;

            if (txtNameSup.Text == "" || txtProviderIdSup.Text == "" ||
                txtDelPriceSup.Text == "" || txtAmountSup.Text == "")
            {
                MessageBox.Show("Не сте попълнили всички задължителни полета.",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            try
            {

                s.Name = txtNameSup.Text;
                s.ProviderId = Convert.ToInt32(providerId);
                s.Date = Convert.ToDateTime(date);
                s.DeliveryPrice = Convert.ToDecimal(delPrice);

                if (salePrice == "0" || salePrice == "null" || salePrice == "")
                    s.SalePrice = null;
                else
                    s.SalePrice = Convert.ToDecimal(salePrice);

                s.Amount = txtAmountSup.Text;
            }

            catch (Exception)
            {
                MessageBox.Show("Въвели сте данни в некоректен формат в някое от полетата.",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            SuppliesDataContext sup = new SuppliesDataContext();
            try
            {
                sup.AddSupply(s.Name, s.ProviderId, s.Date, s.DeliveryPrice, s.SalePrice, s.Amount);
                sup.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        bool InsertWorker()
        {
            Worker w = new Worker();

            string firstWorkDayDate = dtpFirstDayW.Text;
            string monthSalary = txtSalaryW.Text;
            int role = comboRoleW.SelectedIndex;
            double number;

            if (txtFirstNameW.Text == "" || txtLastNameW.Text == "" ||
                txtUsername.Text == "" || txtPass.Text == "" || txtPINW.Text == ""
                || txtSalaryW.Text == "" || txtEmailW.Text == "" || txtPhoneW.Text == "")
            {
                MessageBox.Show("Не сте попълнили всички задължителни полета",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            try
            {
                w.FirstName = txtFirstNameW.Text;
                w.LastName = txtLastNameW.Text;
                w.Username = txtUsername.Text;
                w.Password = txtPass.Text;
                w.PIN = txtPINW.Text;
                w.FirstWorkDayDate = Convert.ToDateTime(firstWorkDayDate);
                w.MonthSalary = Convert.ToDecimal(monthSalary);
                w.Role = role;
                w.Email = txtEmailW.Text;
                w.PhoneNumber = txtPhoneW.Text;

                number = Convert.ToDouble(txtPINW.Text);
                number = Convert.ToDouble(txtPhoneW.Text);
            }

            catch (Exception)
            {
                MessageBox.Show("Въвели сте данни в некоректен формат в някое от полетата.",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            WorkersDataContext wrk = new WorkersDataContext();
            try
            {
                wrk.AddWorker(w.FirstName, w.LastName, w.Username, w.Password, w.PIN, w.FirstWorkDayDate, w.MonthSalary, w.Role, w.Email, w.PhoneNumber);
                wrk.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        bool InsertWorkout() 
        {
            Workout w = new Workout();

            string coachId = txtCoachIdWO.Text;
            string clientId = txtClientIdWO.Text;
            string date = dtpDateWO.Text;
            string startTime = txtStartWO.Text;
            string endTime = txtEndWO.Text;
            string price = txtPriceWO.Text;

            int[] ids = WorkerData.GetCoachIdsByRole();
            int i = 0;

            if (txtClientIdWO.Text == "")
            {
                MessageBox.Show("Не сте попълнили всички задължителни полета.",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            try
            {
                if (coachId == "0" || coachId == "null" || coachId == "")
                    w.CoachId = null;
                else
                {
                    w.CoachId = Convert.ToInt32(coachId);
                    foreach (int id in ids)
                    {
                        if (w.CoachId == id)
                            i++;
                    }
                    if (i == 0)
                        return false;
                }

                w.ClientId = Convert.ToInt32(clientId);
                w.Date = Convert.ToDateTime(date);

                if (startTime == "0" || startTime == "null" || startTime == "")
                    w.StartTime = null;
                else
                    w.StartTime = startTime;

                if (endTime == "0" || endTime == "null" || endTime == "")
                    w.EndTime = null;
                else
                    w.EndTime = endTime;

                if (price == "0" || price == "null" || price == "")
                    w.Price = null;
                else
                    w.Price = Convert.ToDecimal(price);
            }
            catch (Exception)
            {
                MessageBox.Show("Въвели сте данни в некоректен формат в някое от полетата.",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            WorkoutsDataContext wo = new WorkoutsDataContext();
            try
            {
                wo.AddWorkout(w.CoachId, w.ClientId, w.Date, w.StartTime, w.EndTime, w.Price);
                wo.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        bool InsertWorkSchedule()
        {
            WorkSchedule w = new WorkSchedule();

            string workerId = txtWorkerIdWS.Text;
            string shift = txtShiftWS.Text;
            string date = dtpDateWS.Text;

            if (txtWorkerIdWS.Text == "" || txtShiftWS.Text == "" || txtWorkTimeWS.Text == "")
            {
                MessageBox.Show("Не сте попълнили всички задължителни полета",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            try
            {
                w.WorkerId = Convert.ToInt32(workerId);
                w.Shift = Convert.ToInt32(shift);
                w.WorkingTime = txtWorkTimeWS.Text;
                w.Date = Convert.ToDateTime(date);
            }
            catch (Exception)
            {
                MessageBox.Show("Въвели сте данни в некоректен формат в някое от полетата.",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            WorkSchedulesDataContext ws = new WorkSchedulesDataContext();
            try
            {
                ws.AddWorkSchedule(w.WorkerId, w.Shift, w.WorkingTime, w.Date);
                ws.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        private void comboTypeInv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboTypeInv.SelectedIndex == 0)
                MessageBox.Show("Изберете подходящ тип от долуизброените.");
        }

        private void comboCategoryProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboCategoryProd.SelectedIndex == 0)
                MessageBox.Show("Изберете подходяща категория от долуизброените.",
                    "Съобщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboRoleW_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboRoleW.SelectedIndex == 0)
                MessageBox.Show("Изберете подходяща длъжност от долуизброените.",
                    "Съобщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkDelDateNullInv_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDelDateNullInv.Checked == true)
                dtpDelDateInv.Enabled = false;
            else
                dtpDelDateInv.Enabled = true;
        }

        private void checkExpDateNullInv_CheckedChanged(object sender, EventArgs e)
        {
            if (checkExpDateNullInv.Checked == true)
                dtpExpDateInv.Enabled = false;
            else
                dtpExpDateInv.Enabled = true;
        }

        private void checkChangeDateNullInv_CheckedChanged(object sender, EventArgs e)
        {
            if (checkChangeDateNullInv.Checked == true)
                dtpChangeDateInv.Enabled = false;
            else
                dtpChangeDateInv.Enabled = true;
        }

        private void checkFDDNullProd_CheckedChanged(object sender, EventArgs e)
        {
            if (checkFDDNullProd.Checked == true)
                dtpFDDProd.Enabled = false;
            else
                dtpFDDProd.Enabled = true;
        }
    }
}
