using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net.Mail;
using Excel = Microsoft.Office.Interop.Excel;

using Thesis.Model;

namespace Thesis.View
{

    public partial class MainForm : Form
    {
        Worker w = null;
        TableName tn;

        AddRecordForm addForm;
        DeleteRecordForm deleteForm;
        UpdateRecordForm updateForm;
        DataGridViewForm dgvForm;
        SendEmailForm sendForm;

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(Worker wrk)
        {
            InitializeComponent();

            w = wrk;
            List<Client> clients = ClientData.GetClientsWithExpiringSubscription();

            lblWorkerName.Text = w.FirstName;

            switch (w.Role)
            {
                case 1:
                    lblRole.Text = "Собственик";
                    ShowAdminAccess();
                    
                    if (MessageBox.Show("Желаете ли да уведомите клиентите с изтичащ след 3 дни абонамент?", 
                        "Въпрос",  MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (Client client in clients)
                            SendMailClass.SendEmailToClientWithExpiringSubInRight3Days(client);
                        MessageBox.Show("Всички клиенти с абонамент изтичащ точно след 3 дни са уведомени.", "Успешна операция", MessageBoxButtons.OK, MessageBoxIcon.Information);//!
                    }
                    break;
                case 2:
                    lblRole.Text = "Треньор";
                    ShowCoachAccess();
                    break;
                case 3:
                    lblRole.Text = "Касиер";
                    ShowCashierAccess();
                    break;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }


        private void comboAddRecord_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboAddRecord.SelectedIndex)
            {
                case 0:
                    MessageBox.Show("Изберете нужната таблица.", 
                        "Съобщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 1:
                    tn = TableName.CLIENTS;
                    break;
                case 2:
                    tn = TableName.EXPENSES;
                    break;
                case 3:
                    tn = TableName.INVENTORY;
                    break;
                case 4:
                    tn = TableName.PROCEEDS;
                    break;
                case 5:
                    tn = TableName.PRODUCTS;
                    break;
                case 6:
                    tn = TableName.PROVIDERS;
                    break;
                case 7:
                    tn = TableName.SALARIES;
                    break;
                case 8:
                    tn = TableName.SUBSCRIPTIONS;
                    break;
                case 9:
                    tn = TableName.SUPPLIES;
                    break;
                case 10:
                    tn = TableName.WORKERS;
                    break;
                case 11:
                    tn = TableName.WORKOUTS;
                    break;
                case 12:
                    tn = TableName.WORKSCHEDULES;
                    break;
            }

            if (comboAddRecord.SelectedIndex != 0)
            {
                AddRecordForm f = new AddRecordForm(tn, w, 1); //1 - пълната информация
                f.Show();
            }
        }

        private void comboDeleteRecord_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboDeleteRecord.SelectedIndex)
            {
                case 0:
                    MessageBox.Show("Изберете нужната таблица.",
                        "Съобщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 1:
                    tn = TableName.CLIENTS;
                    break;
                case 2:
                    tn = TableName.EXPENSES;
                    break;
                case 3:
                    tn = TableName.INVENTORY;
                    break;
                case 4:
                    tn = TableName.PROCEEDS;
                    break;
                case 5:
                    tn = TableName.PRODUCTS;
                    break;
                case 6:
                    tn = TableName.PROVIDERS;
                    break;
                case 7:
                    tn = TableName.SALARIES;
                    break;
                case 8:
                    tn = TableName.SUBSCRIPTIONS;
                    break;
                case 9:
                    tn = TableName.SUPPLIES;
                    break;
                case 10:
                    tn = TableName.WORKERS;
                    break;
                case 11:
                    tn = TableName.WORKOUTS;
                    break;
                case 12:
                    tn = TableName.WORKSCHEDULES;
                    break;
            }

            if (comboDeleteRecord.SelectedIndex != 0)
            {
                DeleteRecordForm f = new DeleteRecordForm(tn);
                f.Show();
            }
        }

        private void comboUpdateRecord_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboUpdateRecord.SelectedIndex)
            {
                case 0:
                    MessageBox.Show("Изберете нужната таблица.",
                        "Съобщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 1:
                    tn = TableName.CLIENTS;
                    break;
                case 2:
                    tn = TableName.EXPENSES;
                    break;
                case 3:
                    tn = TableName.INVENTORY;
                    break;
                case 4:
                    tn = TableName.PROCEEDS;
                    break;
                case 5:
                    tn = TableName.PRODUCTS;
                    break;
                case 6:
                    tn = TableName.PROVIDERS;
                    break;
                case 7:
                    tn = TableName.SALARIES;
                    break;
                case 8:
                    tn = TableName.SUBSCRIPTIONS;
                    break;
                case 9:
                    tn = TableName.SUPPLIES;
                    break;
                case 10:
                    tn = TableName.WORKERS;
                    break;
                case 11:
                    tn = TableName.WORKOUTS;
                    break;
                case 12:
                    tn = TableName.WORKSCHEDULES;
                    break;
            }

            if (comboUpdateRecord.SelectedIndex != 0)
            {
                UpdateRecordForm f = new UpdateRecordForm(tn, w); //Пълната информация
                f.Show();
            }
        }

        private void comboTableDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboTableDetails.SelectedIndex)
            {
                case 0:
                    MessageBox.Show("Изберете нужната таблица.",
                        "Съобщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 1:
                    tn = TableName.CLIENTS;
                    break;
                case 2:
                    tn = TableName.EXPENSES;
                    break;
                case 3:
                    tn = TableName.INVENTORY;
                    break;
                case 4:
                    tn = TableName.PROCEEDS;
                    break;
                case 5:
                    tn = TableName.PRODUCTS;
                    break;
                case 6:
                    tn = TableName.PROVIDERS;
                    break;
                case 7:
                    tn = TableName.SALARIES;
                    break;
                case 8:
                    tn = TableName.SUBSCRIPTIONS;
                    break;
                case 9:
                    tn = TableName.SUPPLIES;
                    break;
                case 10:
                    tn = TableName.WORKERS;
                    break;
                case 11:
                    tn = TableName.WORKOUTS;
                    break;
                case 12:
                    tn = TableName.WORKSCHEDULES;
                    break;
            }

            if (comboTableDetails.SelectedIndex != 0)
            {
                DataGridViewForm f = new DataGridViewForm(tn, w, 1); //1 - пълната информация
                f.Show();
            }
        }

        private void comboSubs_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboSubs.SelectedIndex)
            {
                case 0:
                    MessageBox.Show("Изберете една от възможните опции в падащото меню.",
                        "Съобщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearRichTextBox();
                    break;
                case 1:
                    ShowExpiringCards();
                    break;
                case 2:
                    ShowExpiredCards();
                    break;
            }
        }

        private void ShowExpiringCards()
        {
            string s = "Id             Име                      Фамилия              Абонамент от     Абонамент до\n";

            string res;
            int i, count = 0;

            richSubs.Visible = true;

            ClearRichTextBox();
            richSubs.AppendText(s);
            List<Client> expiredCards = ClientData.GetClientsWithExpiringSubscription();

            foreach (Client client in expiredCards)
            {
                res = client.Id.ToString().Trim();
                count = res.Length;
                for (i = 0; i < 8 - count; i++)
                    res += "  ";
                richSubs.AppendText(res);

                res = client.FirstName.ToString().Trim();
                count = res.Length;
                for (i = 0; i < 15 - count; i++)
                    res += "  ";
                richSubs.AppendText(res);

                res = client.LastName.ToString().Trim();
                count = res.Length;
                for (i = 0; i < 15 - count; i++)
                    res += "  ";
                richSubs.AppendText(res);

                res = client.SubFrom.ToShortDateString().Trim();
                count = res.Length;
                for (i = 0; i < 15 - count; i++)
                    res += "  ";
                richSubs.AppendText(res);

                res = client.SubTo.ToShortDateString().Trim();
                richSubs.AppendText(res + "\n");
            } 
        }

        private void ShowExpiredCards()
        {
            string s ="Id             Име                      Фамилия              Абонамент от     Абонамент до\n";

            string res;
            int i, count=0;

            richSubs.Visible = true;

            ClearRichTextBox();
            richSubs.AppendText(s);
            List<Client> expiredCards = ClientData.GetClientsWithExpiredSubscription();

            foreach (Client client in expiredCards)
            {
                res = client.Id.ToString().Trim();
                count = res.Length;
                for (i = 0; i < 8 - count; i++)
                    res += "  ";
                richSubs.AppendText(res);

                res = client.FirstName.ToString().Trim();
                count = res.Length;
                for (i = 0; i < 15 - count; i++)
                    res += "  ";
                richSubs.AppendText(res);

                res = client.LastName.ToString().Trim();
                count = res.Length;
                for (i = 0; i < 15 - count; i++)
                    res += "  ";
                richSubs.AppendText(res);

                res = client.SubFrom.ToShortDateString().Trim();
                count = res.Length;
                for (i = 0; i < 15 - count; i++)
                    res += "  ";
                richSubs.AppendText(res);

                res = client.SubTo.ToShortDateString().Trim();
                richSubs.AppendText(res + "\n");

            }
        }

        private void ClearRichTextBox()
        {
            richSubs.Text = "";
        }

        private void ShowCoachAccess()
        {
            tsmiAddExpense.Visible = false;
            tsmiAddInventory.Visible = false;
            tsmiAddProduct.Visible = false;
            tsmiAddProvider.Visible = false;
            tsmiAddSalary.Visible = false;
            tsmiAddSubscription.Visible = false;
            tsmiAddSupply.Visible = false;
            tsmiAddWorker.Visible = false;
            tsmiAddWorkout.Visible = false;
            tsmiAddWorkSchedule.Visible = false;

            tsmiDelete.Visible = false;

            tsmiUpdateExpense.Visible = false;
            tsmiUpdateInventory.Visible = false;
            tsmiUpdateProduct.Visible = false;
            tsmiUpdateProvider.Visible = false;
            tsmiUpdateSalary.Visible = false;
            tsmiUpdateSubscription.Visible = false;
            tsmiUpdateSupply.Visible = false;
            tsmiUpdateWorker.Visible = false;
            tsmiUpdateWorkout.Visible = false;
            tsmiUpdateWorkSchedule.Visible = false;

            tsmiCustom.Visible = false;

            tsmiSaveInExcel.Visible = false;

            gbAddDeleteUpdate.Enabled = false;
        }

        private void ShowCashierAccess()
        {
            tsmiAddInventory.Visible = false;
            tsmiAddProvider.Visible = false;
            tsmiAddSalary.Visible = false;
            tsmiAddWorker.Visible = false;
            tsmiAddWorkSchedule.Visible = false;

            tsmiDelete.Visible = false;

            tsmiUpdateInventory.Visible = false;
            tsmiUpdateProvider.Visible = false;
            tsmiUpdateSalary.Visible = false;
            tsmiUpdateWorker.Visible = false;
            tsmiUpdateWorkSchedule.Visible = false;

            tsmiMyWorkouts.Visible = false;

            tsmiCustom.Visible = false;

            tsmiSaveInExcel.Visible = false;

            gbAddDeleteUpdate.Enabled = false;
        }

        private void ShowAdminAccess()
        {
            tsmiMyWorkouts.Enabled = false;
        }

        private void btnRenewSub_Click(object sender, EventArgs e)
        {
            UpdateSubscriptionForm f = new UpdateSubscriptionForm();
            f.Show();
        }

        private void tsmiAddClient_Click(object sender, EventArgs e)
        {
            addForm = new AddRecordForm(TableName.CLIENTS, w, 1);
            addForm.Show();
        }

        private void tsmiAddExpense_Click(object sender, EventArgs e)
        {
            addForm = new AddRecordForm(TableName.EXPENSES, w, 1);
            addForm.Show();
        }

        private void tsmiAddInventory_Click(object sender, EventArgs e)
        {
            addForm = new AddRecordForm(TableName.INVENTORY, w, 1);
            addForm.Show();
        }

        private void tsmiAddProceed_Click(object sender, EventArgs e)
        {
            addForm = new AddRecordForm(TableName.PROCEEDS, w, 1);
            addForm.Show();
        }

        private void tsmiAddProduct_Click(object sender, EventArgs e)
        {
            addForm = new AddRecordForm(TableName.PRODUCTS, w, 1);
            addForm.Show();
        }

        private void tsmiAddProvider_Click(object sender, EventArgs e)
        {
            addForm = new AddRecordForm(TableName.PROVIDERS, w, 1);
            addForm.Show();
        }

        private void tsmiAddSalary_Click(object sender, EventArgs e)
        {
            addForm = new AddRecordForm(TableName.SALARIES, w, 1);
            addForm.Show();
        }

        private void tsmiAddSubscription_Click(object sender, EventArgs e)
        {
            addForm = new AddRecordForm(TableName.SUBSCRIPTIONS, w, 1);
            addForm.Show();
        }

        private void tsmiAddSupply_Click(object sender, EventArgs e)
        {
            addForm = new AddRecordForm(TableName.SUPPLIES, w, 1);
            addForm.Show();
        }

        private void tsmiAddWorker_Click(object sender, EventArgs e)
        {
            addForm = new AddRecordForm(TableName.WORKERS, w, 1);
            addForm.Show();
        }

        private void tsmiAddWorkout_Click(object sender, EventArgs e)
        {
            addForm = new AddRecordForm(TableName.WORKOUTS, w, 2);
            addForm.Show();
        }

        private void tsmiAddWorkSchedule_Click(object sender, EventArgs e)
        {
            addForm = new AddRecordForm(TableName.WORKSCHEDULES, w, 1);
            addForm.Show();
        }

        private void tsmiDeleteClient_Click(object sender, EventArgs e)
        {
            deleteForm = new DeleteRecordForm(TableName.CLIENTS);
            deleteForm.Show();
        }

        private void tsmiDeleteExpense_Click(object sender, EventArgs e)
        {
            deleteForm = new DeleteRecordForm(TableName.EXPENSES);
            deleteForm.Show();
        }

        private void tsmiDeleteInventory_Click(object sender, EventArgs e)
        {
            deleteForm = new DeleteRecordForm(TableName.INVENTORY);
            deleteForm.Show();
        }

        private void tsmiDeleteProceed_Click(object sender, EventArgs e)
        {
            deleteForm = new DeleteRecordForm(TableName.PROCEEDS);
            deleteForm.Show();
        }

        private void tsmiDeleteProduct_Click(object sender, EventArgs e)
        {
            deleteForm = new DeleteRecordForm(TableName.PRODUCTS);
            deleteForm.Show();
        }

        private void tsmiDeleteProvider_Click(object sender, EventArgs e)
        {
            deleteForm = new DeleteRecordForm(TableName.PROVIDERS);
            deleteForm.Show();
        }

        private void tsmiDeleteSalary_Click(object sender, EventArgs e)
        {
            deleteForm = new DeleteRecordForm(TableName.SALARIES);
            deleteForm.Show();
        }

        private void tsmiDeleteSubscription_Click(object sender, EventArgs e)
        {
            deleteForm = new DeleteRecordForm(TableName.SUBSCRIPTIONS);
            deleteForm.Show();
        }

        private void tsmiDeleteSupply_Click(object sender, EventArgs e)
        {
            deleteForm = new DeleteRecordForm(TableName.SUPPLIES);
            deleteForm.Show();
        }

        private void tsmiDeleteWorker_Click(object sender, EventArgs e)
        {
            deleteForm = new DeleteRecordForm(TableName.WORKERS);
            deleteForm.Show();
        }

        private void tsmiDeleteWorkout_Click(object sender, EventArgs e)
        {
            deleteForm = new DeleteRecordForm(TableName.WORKOUTS);
            deleteForm.Show();
        }

        private void tsmiDeleteWorkSchedule_Click(object sender, EventArgs e)
        {
            deleteForm = new DeleteRecordForm(TableName.WORKSCHEDULES);
            deleteForm.Show();
        }

        private void tsmiUpdateClient_Click(object sender, EventArgs e)
        {
            updateForm = new UpdateRecordForm(TableName.CLIENTS, w);
            updateForm.Show();
        }

        private void tsmiUpdateExpense_Click(object sender, EventArgs e)
        {
            updateForm = new UpdateRecordForm(TableName.EXPENSES, w);
            updateForm.Show();
        }

        private void tsmiUpdateInventory_Click(object sender, EventArgs e)
        {
            updateForm = new UpdateRecordForm(TableName.INVENTORY, w);
            updateForm.Show();
        }

        private void tsmiUpdateProceed_Click(object sender, EventArgs e)
        {
            updateForm = new UpdateRecordForm(TableName.PROCEEDS, w);
            updateForm.Show();
        }

        private void tsmiUpdateProduct_Click(object sender, EventArgs e)
        {
            updateForm = new UpdateRecordForm(TableName.PRODUCTS, w);
            updateForm.Show();
        }

        private void tsmiUpdateProvider_Click(object sender, EventArgs e)
        {
            updateForm = new UpdateRecordForm(TableName.PROVIDERS, w);
            updateForm.Show();
        }

        private void tsmiUpdateSalary_Click(object sender, EventArgs e)
        {
            updateForm = new UpdateRecordForm(TableName.SALARIES, w);
            updateForm.Show();
        }

        private void tsmiUpdateSubscription_Click(object sender, EventArgs e)
        {
            updateForm = new UpdateRecordForm(TableName.SUBSCRIPTIONS, w);
            updateForm.Show();
        }

        private void tsmiUpdateSupply_Click(object sender, EventArgs e)
        {
            updateForm = new UpdateRecordForm(TableName.SUPPLIES, w);
            updateForm.Show();
        }

        private void tsmiUpdateWorker_Click(object sender, EventArgs e)
        {
            updateForm = new UpdateRecordForm(TableName.WORKERS, w);
            updateForm.Show();
        }

        private void tsmiUpdateWorkout_Click(object sender, EventArgs e)
        {
            updateForm = new UpdateRecordForm(TableName.WORKOUTS, w);
            updateForm.Show();
        }

        private void tsmiUpdateWorkSchedule_Click(object sender, EventArgs e)
        {
            updateForm = new UpdateRecordForm(TableName.WORKSCHEDULES, w);
            updateForm.Show();
        }

        private void tsmiShowInfo_Click(object sender, EventArgs e)
        {
            dgvForm = new DataGridViewForm(TableName.WORKERS, w, 7);
            dgvForm.Show();
        }

        private void tsmiUpdateInfo_Click(object sender, EventArgs e)
        {
            updateForm = new UpdateRecordForm(TableName.WORKERS, w, 7);
            updateForm.Show();
        }

        private void tsmiMySalaries_Click(object sender, EventArgs e)
        {
            dgvForm = new DataGridViewForm(TableName.SALARIES, w, 7);
            dgvForm.Show();
        }

        private void tsmiMySchedule_Click(object sender, EventArgs e)
        {
            dgvForm = new DataGridViewForm(TableName.WORKSCHEDULES, w, 7);
            dgvForm.Show();
        }

        private void tsmiMyWorkouts_Click(object sender, EventArgs e)
        {
            dgvForm = new DataGridViewForm(TableName.WORKOUTS, w, 7);
            dgvForm.Show();
        }

        private void tsmiSaveInExcel_Click(object sender, EventArgs e)
        {
            dgvForm = new DataGridViewForm();
            saveFileDialog.DefaultExt = "*.xlsx";
            saveFileDialog.Filter = "Excel file (*.xlsx)|*.xlsx";
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK
            && (saveFileDialog.FileName.Length > 0))
            {
                try
                {
                    dgvForm.MakeExcelFile(saveFileDialog.FileName);
                    MessageBox.Show("Файлът е записан успешно.", "Успешна операция", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Файлът не беше съхранен поради грешка в записа!",
                    "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tsmiCustom_Click(object sender, EventArgs e)
        {
            sendForm = new SendEmailForm();
            sendForm.Show();
        }

        private void tsmiToOne_Click(object sender, EventArgs e)
        {
            sendForm = new SendEmailForm(1);
            sendForm.Show();
        }

        private void tsmiToAllExpiringIn3Days_Click(object sender, EventArgs e)
        {
            List<Client> clients = ClientData.GetClientsWithExpiringSubscription();
            foreach (Client client in clients)
                SendMailClass.SendEmailToClientWithExpiringSubIn3Days(client);
            MessageBox.Show("Всички клиенти, с абонаменти изтичащи до 3 дни, са уведомени по e-mail.",
                        "Съобщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tsmiToAllExpired_Click(object sender, EventArgs e)
        {
            List<Client> clients = ClientData.GetClientsWithExpiredSubscription();
            foreach (Client client in clients)
                SendMailClass.SendEmailToClientWithExpiredSub(client);
            MessageBox.Show("Всички клиенти, с изтекли абонаменти, са уведомени по e-mail.",
                        "Съобщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tsmiToAllExpiring_Click(object sender, EventArgs e)
        {
            List<Client> clients = ClientData.GetClientsWithExpiringSubscription();
            foreach (Client client in clients)
                SendMailClass.SendEmailToClientWithExpiringSub(client);
            MessageBox.Show("Всички клиенти, с активни абонаменти, са уведомени по e-mail.",
                        "Съобщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            AboutBoxForm about = new AboutBoxForm();
            about.Show();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblTime.Text = DateTime.Now.ToShortTimeString();
        }

    }
}
