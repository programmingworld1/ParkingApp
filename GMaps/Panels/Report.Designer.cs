namespace GMaps.Panels
{
    partial class Report
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbFirstname = new System.Windows.Forms.TextBox();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.tbLastname = new System.Windows.Forms.TextBox();
            this.tbInsertion = new System.Windows.Forms.TextBox();
            this.lblInsertion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(107, 130);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(443, 170);
            this.tbMessage.TabIndex = 5;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(27, 94);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(52, 13);
            this.lblCategory.TabIndex = 11;
            this.lblCategory.Text = "Categorie";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "De parkeerplek waar ik heen werd geleid bestaat niet",
            "Ik wil een nieuwe parkeerplek melden",
            "Er zijn te weinig parkeerplekken in de buurt",
            "Overige"});
            this.cmbCategory.Location = new System.Drawing.Point(107, 91);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(443, 21);
            this.cmbCategory.TabIndex = 4;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.SystemColors.Control;
            this.btnSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Location = new System.Drawing.Point(107, 319);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Versturen";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(27, 133);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(40, 13);
            this.lblMessage.TabIndex = 12;
            this.lblMessage.Text = "Bericht";
            // 
            // epError
            // 
            this.epError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epError.ContainerControl = this;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(335, 59);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(215, 20);
            this.tbEmail.TabIndex = 3;
            // 
            // tbFirstname
            // 
            this.tbFirstname.Location = new System.Drawing.Point(107, 27);
            this.tbFirstname.Name = "tbFirstname";
            this.tbFirstname.Size = new System.Drawing.Size(131, 20);
            this.tbFirstname.TabIndex = 0;
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(27, 30);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(55, 13);
            this.lblFirstname.TabIndex = 7;
            this.lblFirstname.Text = "Voornaam";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(255, 62);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "E-mail";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(255, 30);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(64, 13);
            this.lblLastname.TabIndex = 9;
            this.lblLastname.Text = "Achternaam";
            // 
            // tbLastname
            // 
            this.tbLastname.Location = new System.Drawing.Point(335, 27);
            this.tbLastname.Name = "tbLastname";
            this.tbLastname.Size = new System.Drawing.Size(215, 20);
            this.tbLastname.TabIndex = 2;
            // 
            // tbInsertion
            // 
            this.tbInsertion.Location = new System.Drawing.Point(107, 58);
            this.tbInsertion.Name = "tbInsertion";
            this.tbInsertion.Size = new System.Drawing.Size(131, 20);
            this.tbInsertion.TabIndex = 1;
            // 
            // lblInsertion
            // 
            this.lblInsertion.AutoSize = true;
            this.lblInsertion.Location = new System.Drawing.Point(27, 61);
            this.lblInsertion.Name = "lblInsertion";
            this.lblInsertion.Size = new System.Drawing.Size(79, 13);
            this.lblInsertion.TabIndex = 8;
            this.lblInsertion.Text = "Tussenvoegsel";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblInsertion);
            this.Controls.Add(this.tbInsertion);
            this.Controls.Add(this.tbLastname);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblFirstname);
            this.Controls.Add(this.tbFirstname);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.tbMessage);
            this.Location = new System.Drawing.Point(147, 66);
            this.Name = "Report";
            this.Size = new System.Drawing.Size(788, 396);
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.ErrorProvider epError;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label lblInsertion;
        private System.Windows.Forms.TextBox tbInsertion;
        private System.Windows.Forms.TextBox tbLastname;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.TextBox tbFirstname;
        private System.Windows.Forms.TextBox tbEmail;
    }
}
