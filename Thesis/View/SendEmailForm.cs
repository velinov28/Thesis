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
    public partial class SendEmailForm : Form
    {
        bool CCvisible;
        bool BCCvisible;
        int flag = 0;
        DataGridViewForm form;

        public SendEmailForm()
        {
            InitializeComponent();
        }

        public SendEmailForm(int _flag)
        {
            flag = _flag;
            InitializeComponent();
        }

        private void SendEmailForm_Load(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                gbMail.Visible = false;
                btnSendMail.Location = new Point(14, 35);
                pbSender.Location = new Point(195, 6);
                this.Size = new Size(415, 250);
            }

            else
            {
                lblClientId.Visible = false;
                txtClientId.Visible = false;
                pbSender.Visible = false;

                lblSubject.Location = new Point(45, 62);
                txtSubject.Location = new Point(82, 59);

                btnSendMail.Location = new Point(13, 8);

                richTextBoxText.Location = new Point(16, 85);
                richTextBoxText.Size = new Size(405, 201);
                this.Size = new Size(470, 408);
            }
        }


        private void btnCC_Click(object sender, EventArgs e)
        {
            txtCC.Text = "";
            if (CCvisible == false)
            {
                lblCC.Visible = true;
                txtCC.Visible = true;
                CCvisible = true;

                if (BCCvisible == false)
                {
                    lblSubject.Location = new Point(45, 84);
                    txtSubject.Location = new Point(82, 81);

                    richTextBoxText.Location = new Point(16, 103);
                    richTextBoxText.Size = new Size(405, 183);

                }
                else
                {
                    lblBCC.Location = new Point(3, 84);
                    txtBCC.Location = new Point(82, 81);

                    lblSubject.Location = new Point(45, 106);
                    txtSubject.Location = new Point(82, 103);

                    richTextBoxText.Location = new Point(16, 129);
                    richTextBoxText.Size = new Size(405, 157);
                }
            }

            else
            {
                lblCC.Visible = false;
                txtCC.Visible = false;
                CCvisible = false;

                if (BCCvisible == false)
                {
                    lblSubject.Location = new Point(45, 62);
                    txtSubject.Location = new Point(82, 59);

                    richTextBoxText.Location = new Point(16, 85);
                    richTextBoxText.Size = new Size(405, 201);
                }

                else
                {
                    lblBCC.Location = new Point(3, 62);
                    txtBCC.Location = new Point(82, 59);

                    lblSubject.Location = new Point(45, 84);
                    txtSubject.Location = new Point(82, 81);

                    richTextBoxText.Location = new Point(16, 103);
                    richTextBoxText.Size = new Size(405, 183);
                }
            }

        }

        private void btnBCC_Click(object sender, EventArgs e)
        {
            txtBCC.Text = "";
            if (CCvisible == false)
            {
                if (BCCvisible == false)
                {
                    lblBCC.Visible = true;
                    txtBCC.Visible = true;
                    BCCvisible = true;

                    lblBCC.Location = new Point(3, 62);
                    txtBCC.Location = new Point(82, 59);

                    lblSubject.Location = new Point(45, 84);
                    txtSubject.Location = new Point(82, 81);

                    richTextBoxText.Location = new Point(16, 103);
                    richTextBoxText.Size = new Size(405, 183);
                }

                else
                {
                    lblBCC.Visible = false;
                    txtBCC.Visible = false;
                    BCCvisible = false;

                    lblSubject.Location = new Point(45, 62);
                    txtSubject.Location = new Point(82, 59);

                    richTextBoxText.Location = new Point(16, 85);
                    richTextBoxText.Size = new Size(405, 201);
                }
            }
            else
            {
                if (BCCvisible == false)
                {
                    lblBCC.Visible = true;
                    txtBCC.Visible = true;
                    BCCvisible = true;

                    lblBCC.Location = new Point(3, 84);
                    txtBCC.Location = new Point(82, 81);

                    lblSubject.Location = new Point(45, 106);
                    txtSubject.Location = new Point(82, 103);

                    richTextBoxText.Location = new Point(16, 129);
                    richTextBoxText.Size = new Size(405, 157);
                }

                else
                {
                    lblBCC.Visible = false;
                    txtBCC.Visible = false;
                    BCCvisible = false;

                    lblSubject.Location = new Point(45, 84);
                    txtSubject.Location = new Point(82, 81);

                    richTextBoxText.Location = new Point(16, 103);
                    richTextBoxText.Size = new Size(405, 183);
                }
            }
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            string to, cc, bcc, subject, text;
            bool ok;

            if (flag == 1)
            {
                try
                {
                    int id = Convert.ToInt32(txtClientId.Text.Trim());
                    Client c = ClientData.GetClientById(id);
                    if (c == null)
                        MessageBox.Show("Не съществува потребител с Id = " + id.ToString(),
                            "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        SendMailClass.SendEmail(c);
                        MessageBox.Show("Клиентът е уведомен по e-mail.",
                            "Успешна операция", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                
                catch (Exception)
                {
                    MessageBox.Show("Въведените данни не са в правилния формат.",
                            "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                to = txtTo.Text.Trim();
                cc = txtCC.Text.Trim();
                bcc = txtBCC.Text.Trim();
                subject = txtSubject.Text.Trim();
                text = richTextBoxText.Text.Trim();

                ok = SendMailClass.SendEmail(to, cc, bcc, subject, text);
                if (ok == true)
                    MessageBox.Show("Съобщението е изпратено успешно",
                        "Успешна операция", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Съобщението не е изпратено. Не са попълнени всички нужни полета.",
                        "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboTables.SelectedIndex)
            {
                case 0:
                    MessageBox.Show("Изберете таблица от долуизброените",
                        "Съобщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 1:
                    form = new DataGridViewForm(TableName.CLIENTS, 9);
                    form.Show();
                    break;
                case 2:
                    form = new DataGridViewForm(TableName.PROVIDERS, 9);
                    form.Show();
                    break;
                case 3:
                    form = new DataGridViewForm(TableName.WORKERS, 9);
                    form.Show();
                    break;
            }
        }

        private void txtClientId_DoubleClick(object sender, EventArgs e)
        {
            form = new DataGridViewForm(TableName.CLIENTS, 9);
            form.Show();
        }
    }
}

