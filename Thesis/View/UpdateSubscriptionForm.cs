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
    public partial class UpdateSubscriptionForm : Form
    {
        DataGridViewForm form;

        public UpdateSubscriptionForm()
        {
            InitializeComponent();

            int[] ids = ClientData.GetIds();
            foreach (int id in ids)
            {
                comboId.Items.Add(id);
            }
        }

        private void clientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gymDatabaseDataSet);

            MessageBox.Show("Успешно подновен абонамент.",
                "Успешна операция", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void UpdateSubscriptionForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gymDatabaseDataSet.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.gymDatabaseDataSet.Clients);
        }

        private void dtpSubTo_MouseDown(object sender, MouseEventArgs e)
        {
            int renewings = Convert.ToInt32(txtRenewings.Text);
            renewings++;
            txtRenewings.Text = renewings.ToString();
        }   

        private void txtSubId_DoubleClick(object sender, EventArgs e)
        {
            form = new DataGridViewForm(TableName.SUBSCRIPTIONS);
            form.Show();
        }

        private void txtId_DoubleClick(object sender, EventArgs e)
        {
            form = new DataGridViewForm(TableName.CLIENTS);
            form.Show();
        }

        private void comboId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboId.SelectedIndex == 0)
            {
                MessageBox.Show("Изберете Всички Id, ако желаете последователно да видите абонаментите на всички клиенти " +
                "или конкретно Id, за да обновите конкретен клиентски абонамент.", "Успешна операция", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (comboId.SelectedIndex == 1)
            {
                this.clientsTableAdapter.Fill(this.gymDatabaseDataSet.Clients);
            }

            else {
                try

                {
                    this.clientsTableAdapter.FillById(this.gymDatabaseDataSet.Clients, ((int)(System.Convert.ChangeType(comboId.SelectedItem, typeof(int)))));
                }
                catch (Exception)
                {
                    MessageBox.Show("Проблем с обновяването на информацията.",
                        "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
