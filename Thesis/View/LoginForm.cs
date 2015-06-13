using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using Thesis.Controller;
using Thesis.Model;

namespace Thesis.View
{
    public partial class LoginForm : Form
    {

        public Worker worker { get; private set; }

        public LoginForm()
        {
            worker = null;
            InitializeComponent();
            this.Text = "Добре дошли във фитнес системата";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginValidation lv = new LoginValidation(txtUsername.Text, txtPassword.Text);
            Worker wrk;
            if (lv.ValidateUserInput(out wrk))
            {
                this.worker = wrk;
                this.DialogResult = DialogResult.OK;
                MainForm mf = new MainForm(this.worker);
                mf.ShowDialog();
            }
            else
            {
                MessageBox.Show(lv.errText,
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnSendMail.Visible = true;
            }

            txtPassword.Text = "";
            txtUsername.Text = "";
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            string email = SendMailClass.SendPassToEmail(txtUsername.Text.Trim());
            if (email!=null)
                  MessageBox.Show("Паролата е изпратена на e-mail <" + email.Trim() + "> .",
                      "Съобщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Не съществува такова потребителско име.",
                    "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
