namespace Thesis.View
{
    partial class LoginForm
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
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pbWelcome = new System.Windows.Forms.PictureBox();
            this.btnSendMail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbWelcome)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(25, 127);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(111, 13);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Потребителско име:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(88, 157);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(48, 13);
            this.lblPass.TabIndex = 0;
            this.lblPass.Text = "Парола:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(135, 124);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(135, 154);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.Image = global::Thesis.Properties.Resources.login;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.Location = new System.Drawing.Point(70, 184);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(132, 33);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Вход в системата";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pbWelcome
            // 
            this.pbWelcome.BackgroundImage = global::Thesis.Properties.Resources.welcome1;
            this.pbWelcome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbWelcome.Location = new System.Drawing.Point(34, 12);
            this.pbWelcome.Name = "pbWelcome";
            this.pbWelcome.Size = new System.Drawing.Size(190, 106);
            this.pbWelcome.TabIndex = 8;
            this.pbWelcome.TabStop = false;
            // 
            // btnSendMail
            // 
            this.btnSendMail.BackColor = System.Drawing.Color.Green;
            this.btnSendMail.ForeColor = System.Drawing.Color.White;
            this.btnSendMail.Image = global::Thesis.Properties.Resources.letter;
            this.btnSendMail.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSendMail.Location = new System.Drawing.Point(28, 223);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(207, 33);
            this.btnSendMail.TabIndex = 7;
            this.btnSendMail.Text = "Изпрати паролата ми по e-mail";
            this.btnSendMail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSendMail.UseVisualStyleBackColor = false;
            this.btnSendMail.Visible = false;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(198)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(263, 262);
            this.Controls.Add(this.pbWelcome);
            this.Controls.Add(this.btnSendMail);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUser);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbWelcome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSendMail;
        private System.Windows.Forms.PictureBox pbWelcome;
    }
}