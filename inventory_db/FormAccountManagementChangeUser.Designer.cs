namespace inventory_db
{
    partial class FormAccountManagementChangeUser
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
            this.buttonUserLogin = new System.Windows.Forms.Button();
            this.buttonExitProgram = new System.Windows.Forms.Button();
            this.comboBoxAccountManagementUserPrivilege = new System.Windows.Forms.ComboBox();
            this.labelAccountManagementUserPrivilege = new System.Windows.Forms.Label();
            this.labelAccountManagementUserPassword = new System.Windows.Forms.Label();
            this.labelAccountManagementUserFullName = new System.Windows.Forms.Label();
            this.labelAccountManagementUserLogin = new System.Windows.Forms.Label();
            this.textBoxAccountManagementUserPassword = new System.Windows.Forms.TextBox();
            this.textBoxAccountManagementUserFullName = new System.Windows.Forms.TextBox();
            this.textBoxlAccountManagementUserLogin = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelAccountManagementAddNewUser = new System.Windows.Forms.Label();
            this.buttonChangePassword = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonUserLogin
            // 
            this.buttonUserLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUserLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonUserLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUserLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonUserLogin.ForeColor = System.Drawing.Color.White;
            this.buttonUserLogin.Location = new System.Drawing.Point(232, 347);
            this.buttonUserLogin.Name = "buttonUserLogin";
            this.buttonUserLogin.Size = new System.Drawing.Size(135, 34);
            this.buttonUserLogin.TabIndex = 22;
            this.buttonUserLogin.Text = "Изменить";
            this.buttonUserLogin.UseVisualStyleBackColor = false;
            this.buttonUserLogin.Click += new System.EventHandler(this.buttonUserLogin_Click);
            // 
            // buttonExitProgram
            // 
            this.buttonExitProgram.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonExitProgram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonExitProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExitProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonExitProgram.ForeColor = System.Drawing.Color.White;
            this.buttonExitProgram.Location = new System.Drawing.Point(232, 445);
            this.buttonExitProgram.Name = "buttonExitProgram";
            this.buttonExitProgram.Size = new System.Drawing.Size(135, 33);
            this.buttonExitProgram.TabIndex = 23;
            this.buttonExitProgram.Text = "Отмена";
            this.buttonExitProgram.UseVisualStyleBackColor = false;
            this.buttonExitProgram.Click += new System.EventHandler(this.buttonExitProgram_Click);
            // 
            // comboBoxAccountManagementUserPrivilege
            // 
            this.comboBoxAccountManagementUserPrivilege.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxAccountManagementUserPrivilege.DisplayMember = "1";
            this.comboBoxAccountManagementUserPrivilege.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.comboBoxAccountManagementUserPrivilege.FormattingEnabled = true;
            this.comboBoxAccountManagementUserPrivilege.Items.AddRange(new object[] {
            "admin",
            "user"});
            this.comboBoxAccountManagementUserPrivilege.Location = new System.Drawing.Point(203, 247);
            this.comboBoxAccountManagementUserPrivilege.Name = "comboBoxAccountManagementUserPrivilege";
            this.comboBoxAccountManagementUserPrivilege.Size = new System.Drawing.Size(252, 32);
            this.comboBoxAccountManagementUserPrivilege.TabIndex = 21;
            // 
            // labelAccountManagementUserPrivilege
            // 
            this.labelAccountManagementUserPrivilege.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAccountManagementUserPrivilege.AutoSize = true;
            this.labelAccountManagementUserPrivilege.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelAccountManagementUserPrivilege.ForeColor = System.Drawing.Color.White;
            this.labelAccountManagementUserPrivilege.Location = new System.Drawing.Point(56, 255);
            this.labelAccountManagementUserPrivilege.Name = "labelAccountManagementUserPrivilege";
            this.labelAccountManagementUserPrivilege.Size = new System.Drawing.Size(128, 24);
            this.labelAccountManagementUserPrivilege.TabIndex = 19;
            this.labelAccountManagementUserPrivilege.Text = "Привилегия";
            // 
            // labelAccountManagementUserPassword
            // 
            this.labelAccountManagementUserPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAccountManagementUserPassword.AutoSize = true;
            this.labelAccountManagementUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelAccountManagementUserPassword.ForeColor = System.Drawing.Color.White;
            this.labelAccountManagementUserPassword.Location = new System.Drawing.Point(102, 315);
            this.labelAccountManagementUserPassword.Name = "labelAccountManagementUserPassword";
            this.labelAccountManagementUserPassword.Size = new System.Drawing.Size(82, 24);
            this.labelAccountManagementUserPassword.TabIndex = 18;
            this.labelAccountManagementUserPassword.Text = "Пароль";
            this.labelAccountManagementUserPassword.Visible = false;
            // 
            // labelAccountManagementUserFullName
            // 
            this.labelAccountManagementUserFullName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAccountManagementUserFullName.AutoSize = true;
            this.labelAccountManagementUserFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelAccountManagementUserFullName.ForeColor = System.Drawing.Color.White;
            this.labelAccountManagementUserFullName.Location = new System.Drawing.Point(127, 191);
            this.labelAccountManagementUserFullName.Name = "labelAccountManagementUserFullName";
            this.labelAccountManagementUserFullName.Size = new System.Drawing.Size(57, 24);
            this.labelAccountManagementUserFullName.TabIndex = 17;
            this.labelAccountManagementUserFullName.Text = "ФИО";
            // 
            // labelAccountManagementUserLogin
            // 
            this.labelAccountManagementUserLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAccountManagementUserLogin.AutoSize = true;
            this.labelAccountManagementUserLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelAccountManagementUserLogin.ForeColor = System.Drawing.Color.White;
            this.labelAccountManagementUserLogin.Location = new System.Drawing.Point(115, 134);
            this.labelAccountManagementUserLogin.Name = "labelAccountManagementUserLogin";
            this.labelAccountManagementUserLogin.Size = new System.Drawing.Size(69, 24);
            this.labelAccountManagementUserLogin.TabIndex = 16;
            this.labelAccountManagementUserLogin.Text = "Логин";
            // 
            // textBoxAccountManagementUserPassword
            // 
            this.textBoxAccountManagementUserPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAccountManagementUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBoxAccountManagementUserPassword.Location = new System.Drawing.Point(203, 312);
            this.textBoxAccountManagementUserPassword.Name = "textBoxAccountManagementUserPassword";
            this.textBoxAccountManagementUserPassword.Size = new System.Drawing.Size(252, 29);
            this.textBoxAccountManagementUserPassword.TabIndex = 15;
            this.textBoxAccountManagementUserPassword.Visible = false;
            this.textBoxAccountManagementUserPassword.Enter += new System.EventHandler(this.textBoxAccountManagementUserPassword_Enter);
            this.textBoxAccountManagementUserPassword.Leave += new System.EventHandler(this.textBoxAccountManagementUserPassword_Leave);
            // 
            // textBoxAccountManagementUserFullName
            // 
            this.textBoxAccountManagementUserFullName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAccountManagementUserFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBoxAccountManagementUserFullName.Location = new System.Drawing.Point(203, 186);
            this.textBoxAccountManagementUserFullName.Name = "textBoxAccountManagementUserFullName";
            this.textBoxAccountManagementUserFullName.Size = new System.Drawing.Size(252, 29);
            this.textBoxAccountManagementUserFullName.TabIndex = 14;
            this.textBoxAccountManagementUserFullName.Enter += new System.EventHandler(this.textBoxAccountManagementUserFullName_Enter);
            this.textBoxAccountManagementUserFullName.Leave += new System.EventHandler(this.textBoxAccountManagementUserFullName_Leave);
            // 
            // textBoxlAccountManagementUserLogin
            // 
            this.textBoxlAccountManagementUserLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxlAccountManagementUserLogin.Enabled = false;
            this.textBoxlAccountManagementUserLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBoxlAccountManagementUserLogin.Location = new System.Drawing.Point(203, 129);
            this.textBoxlAccountManagementUserLogin.Name = "textBoxlAccountManagementUserLogin";
            this.textBoxlAccountManagementUserLogin.Size = new System.Drawing.Size(252, 29);
            this.textBoxlAccountManagementUserLogin.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.labelAccountManagementAddNewUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 60);
            this.panel1.TabIndex = 24;
            // 
            // labelAccountManagementAddNewUser
            // 
            this.labelAccountManagementAddNewUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAccountManagementAddNewUser.AutoSize = true;
            this.labelAccountManagementAddNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.labelAccountManagementAddNewUser.ForeColor = System.Drawing.Color.White;
            this.labelAccountManagementAddNewUser.Location = new System.Drawing.Point(62, 9);
            this.labelAccountManagementAddNewUser.Name = "labelAccountManagementAddNewUser";
            this.labelAccountManagementAddNewUser.Size = new System.Drawing.Size(486, 39);
            this.labelAccountManagementAddNewUser.TabIndex = 9;
            this.labelAccountManagementAddNewUser.Text = "Изменение учетной записи";
            // 
            // buttonChangePassword
            // 
            this.buttonChangePassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonChangePassword.ForeColor = System.Drawing.Color.White;
            this.buttonChangePassword.Location = new System.Drawing.Point(213, 396);
            this.buttonChangePassword.Name = "buttonChangePassword";
            this.buttonChangePassword.Size = new System.Drawing.Size(180, 34);
            this.buttonChangePassword.TabIndex = 25;
            this.buttonChangePassword.Text = "Сброс пароля";
            this.buttonChangePassword.UseVisualStyleBackColor = false;
            this.buttonChangePassword.Click += new System.EventHandler(this.buttonChangePassword_Click);
            // 
            // FormAccountManagementChangeUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(594, 481);
            this.Controls.Add(this.buttonChangePassword);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonUserLogin);
            this.Controls.Add(this.buttonExitProgram);
            this.Controls.Add(this.comboBoxAccountManagementUserPrivilege);
            this.Controls.Add(this.labelAccountManagementUserPrivilege);
            this.Controls.Add(this.labelAccountManagementUserPassword);
            this.Controls.Add(this.labelAccountManagementUserFullName);
            this.Controls.Add(this.labelAccountManagementUserLogin);
            this.Controls.Add(this.textBoxAccountManagementUserPassword);
            this.Controls.Add(this.textBoxAccountManagementUserFullName);
            this.Controls.Add(this.textBoxlAccountManagementUserLogin);
            this.MinimumSize = new System.Drawing.Size(610, 520);
            this.Name = "FormAccountManagementChangeUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAccountManagementChangeUser";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUserLogin;
        private System.Windows.Forms.Button buttonExitProgram;
        private System.Windows.Forms.Label labelAccountManagementUserPrivilege;
        private System.Windows.Forms.Label labelAccountManagementUserPassword;
        private System.Windows.Forms.Label labelAccountManagementUserFullName;
        private System.Windows.Forms.Label labelAccountManagementUserLogin;
        private System.Windows.Forms.TextBox textBoxAccountManagementUserPassword;
        public System.Windows.Forms.TextBox textBoxlAccountManagementUserLogin;
        public System.Windows.Forms.ComboBox comboBoxAccountManagementUserPrivilege;
        public System.Windows.Forms.TextBox textBoxAccountManagementUserFullName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelAccountManagementAddNewUser;
        private System.Windows.Forms.Button buttonChangePassword;
    }
}