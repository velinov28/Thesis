namespace Thesis.View
{
    partial class SendEmailForm
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
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.lblClientId = new System.Windows.Forms.Label();
            this.gbMail = new System.Windows.Forms.GroupBox();
            this.btnCC = new System.Windows.Forms.Button();
            this.comboTables = new System.Windows.Forms.ComboBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.lblBCC = new System.Windows.Forms.Label();
            this.txtBCC = new System.Windows.Forms.TextBox();
            this.lblCC = new System.Windows.Forms.Label();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.btnBCC = new System.Windows.Forms.Button();
            this.lblTo = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.richTextBoxText = new System.Windows.Forms.RichTextBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.pbSender = new System.Windows.Forms.PictureBox();
            this.btnSendMail = new System.Windows.Forms.Button();
            this.gbMail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSender)).BeginInit();
            this.SuspendLayout();
            // 
            // txtClientId
            // 
            this.txtClientId.Location = new System.Drawing.Point(83, 15);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(100, 20);
            this.txtClientId.TabIndex = 3;
            this.txtClientId.DoubleClick += new System.EventHandler(this.txtClientId_DoubleClick);
            // 
            // lblClientId
            // 
            this.lblClientId.AutoSize = true;
            this.lblClientId.Location = new System.Drawing.Point(12, 18);
            this.lblClientId.Name = "lblClientId";
            this.lblClientId.Size = new System.Drawing.Size(72, 13);
            this.lblClientId.TabIndex = 2;
            this.lblClientId.Text = "Id на клиент:";
            // 
            // gbMail
            // 
            this.gbMail.Controls.Add(this.btnCC);
            this.gbMail.Controls.Add(this.comboTables);
            this.gbMail.Controls.Add(this.lblSubject);
            this.gbMail.Controls.Add(this.txtSubject);
            this.gbMail.Controls.Add(this.lblBCC);
            this.gbMail.Controls.Add(this.txtBCC);
            this.gbMail.Controls.Add(this.lblCC);
            this.gbMail.Controls.Add(this.txtCC);
            this.gbMail.Controls.Add(this.btnBCC);
            this.gbMail.Controls.Add(this.lblTo);
            this.gbMail.Controls.Add(this.txtTo);
            this.gbMail.Controls.Add(this.richTextBoxText);
            this.gbMail.Controls.Add(this.lblFrom);
            this.gbMail.Controls.Add(this.txtFrom);
            this.gbMail.Location = new System.Drawing.Point(14, 41);
            this.gbMail.Name = "gbMail";
            this.gbMail.Size = new System.Drawing.Size(431, 301);
            this.gbMail.TabIndex = 35;
            this.gbMail.TabStop = false;
            // 
            // btnCC
            // 
            this.btnCC.Location = new System.Drawing.Point(235, 13);
            this.btnCC.Name = "btnCC";
            this.btnCC.Size = new System.Drawing.Size(90, 23);
            this.btnCC.TabIndex = 25;
            this.btnCC.Text = "Явно копие";
            this.btnCC.UseVisualStyleBackColor = true;
            this.btnCC.Click += new System.EventHandler(this.btnCC_Click);
            // 
            // comboTables
            // 
            this.comboTables.FormattingEnabled = true;
            this.comboTables.Items.AddRange(new object[] {
            "--Избери таблица--",
            "Клиенти",
            "Доставчици",
            "Служители"});
            this.comboTables.Location = new System.Drawing.Point(299, 37);
            this.comboTables.Name = "comboTables";
            this.comboTables.Size = new System.Drawing.Size(121, 21);
            this.comboTables.TabIndex = 32;
            this.comboTables.SelectedIndexChanged += new System.EventHandler(this.comboTables_SelectedIndexChanged);
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(45, 106);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(37, 13);
            this.lblSubject.TabIndex = 14;
            this.lblSubject.Text = "Тема:";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(83, 103);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(338, 20);
            this.txtSubject.TabIndex = 15;
            // 
            // lblBCC
            // 
            this.lblBCC.AutoSize = true;
            this.lblBCC.Location = new System.Drawing.Point(3, 84);
            this.lblBCC.Name = "lblBCC";
            this.lblBCC.Size = new System.Drawing.Size(79, 13);
            this.lblBCC.TabIndex = 16;
            this.lblBCC.Text = "Скрито копие:";
            this.lblBCC.Visible = false;
            // 
            // txtBCC
            // 
            this.txtBCC.Location = new System.Drawing.Point(82, 81);
            this.txtBCC.Name = "txtBCC";
            this.txtBCC.Size = new System.Drawing.Size(338, 20);
            this.txtBCC.TabIndex = 17;
            this.txtBCC.Visible = false;
            // 
            // lblCC
            // 
            this.lblCC.AutoSize = true;
            this.lblCC.Location = new System.Drawing.Point(13, 62);
            this.lblCC.Name = "lblCC";
            this.lblCC.Size = new System.Drawing.Size(69, 13);
            this.lblCC.TabIndex = 18;
            this.lblCC.Text = "Явно копие:";
            this.lblCC.Visible = false;
            // 
            // txtCC
            // 
            this.txtCC.Location = new System.Drawing.Point(82, 59);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(338, 20);
            this.txtCC.TabIndex = 19;
            this.txtCC.Visible = false;
            // 
            // btnBCC
            // 
            this.btnBCC.Location = new System.Drawing.Point(330, 13);
            this.btnBCC.Name = "btnBCC";
            this.btnBCC.Size = new System.Drawing.Size(90, 23);
            this.btnBCC.TabIndex = 26;
            this.btnBCC.Text = "Скрито копие";
            this.btnBCC.UseVisualStyleBackColor = true;
            this.btnBCC.Click += new System.EventHandler(this.btnBCC_Click);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(57, 40);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(25, 13);
            this.lblTo.TabIndex = 20;
            this.lblTo.Text = "До:";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(82, 37);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(211, 20);
            this.txtTo.TabIndex = 21;
            // 
            // richTextBoxText
            // 
            this.richTextBoxText.Location = new System.Drawing.Point(16, 129);
            this.richTextBoxText.Name = "richTextBoxText";
            this.richTextBoxText.Size = new System.Drawing.Size(405, 157);
            this.richTextBoxText.TabIndex = 24;
            this.richTextBoxText.Text = "";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(59, 18);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(23, 13);
            this.lblFrom.TabIndex = 22;
            this.lblFrom.Text = "От:";
            // 
            // txtFrom
            // 
            this.txtFrom.Enabled = false;
            this.txtFrom.Location = new System.Drawing.Point(82, 15);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(147, 20);
            this.txtFrom.TabIndex = 23;
            this.txtFrom.Text = "krasimirapetrova0@gmail.com";
            // 
            // pbSender
            // 
            this.pbSender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.pbSender.Image = global::Thesis.Properties.Resources.sender1;
            this.pbSender.Location = new System.Drawing.Point(451, 73);
            this.pbSender.Name = "pbSender";
            this.pbSender.Size = new System.Drawing.Size(200, 201);
            this.pbSender.TabIndex = 36;
            this.pbSender.TabStop = false;
            // 
            // btnSendMail
            // 
            this.btnSendMail.BackColor = System.Drawing.Color.Green;
            this.btnSendMail.ForeColor = System.Drawing.Color.White;
            this.btnSendMail.Image = global::Thesis.Properties.Resources.letter;
            this.btnSendMail.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSendMail.Location = new System.Drawing.Point(201, 12);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(122, 33);
            this.btnSendMail.TabIndex = 13;
            this.btnSendMail.Text = "Изпрати e-mail";
            this.btnSendMail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSendMail.UseVisualStyleBackColor = false;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // SendEmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(663, 331);
            this.Controls.Add(this.pbSender);
            this.Controls.Add(this.gbMail);
            this.Controls.Add(this.btnSendMail);
            this.Controls.Add(this.txtClientId);
            this.Controls.Add(this.lblClientId);
            this.Name = "SendEmailForm";
            this.Text = "Изпрати e-mail";
            this.Load += new System.EventHandler(this.SendEmailForm_Load);
            this.gbMail.ResumeLayout(false);
            this.gbMail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSender)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.Label lblClientId;
        private System.Windows.Forms.Button btnSendMail;
        private System.Windows.Forms.PictureBox pbSender;
        private System.Windows.Forms.GroupBox gbMail;
        private System.Windows.Forms.Button btnCC;
        private System.Windows.Forms.ComboBox comboTables;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label lblBCC;
        private System.Windows.Forms.TextBox txtBCC;
        private System.Windows.Forms.Label lblCC;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.Button btnBCC;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.RichTextBox richTextBoxText;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.TextBox txtFrom;
    }
}