namespace inventory_db
{
    partial class AuthorizationForm
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
            this.textBoxUserLogin = new System.Windows.Forms.TextBox();
            this.textBoxUserPassword = new System.Windows.Forms.TextBox();
            this.labelAuthorization = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelLoginString = new System.Windows.Forms.Label();
            this.labelPasswordString = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonUserLogin
            // 
            this.buttonUserLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonUserLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUserLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonUserLogin.ForeColor = System.Drawing.Color.White;
            this.buttonUserLogin.Location = new System.Drawing.Point(134, 142);
            this.buttonUserLogin.Name = "buttonUserLogin";
            this.buttonUserLogin.Size = new System.Drawing.Size(113, 34);
            this.buttonUserLogin.TabIndex = 0;
            this.buttonUserLogin.Text = "Вход";
            this.buttonUserLogin.UseVisualStyleBackColor = false;
            this.buttonUserLogin.Click += new System.EventHandler(this.buttonUserLogin_Click);
            // 
            // buttonExitProgram
            // 
            this.buttonExitProgram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonExitProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExitProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonExitProgram.ForeColor = System.Drawing.Color.White;
            this.buttonExitProgram.Location = new System.Drawing.Point(134, 198);
            this.buttonExitProgram.Name = "buttonExitProgram";
            this.buttonExitProgram.Size = new System.Drawing.Size(113, 33);
            this.buttonExitProgram.TabIndex = 1;
            this.buttonExitProgram.Text = "Выход";
            this.buttonExitProgram.UseVisualStyleBackColor = false;
            this.buttonExitProgram.Click += new System.EventHandler(this.buttonExitProgram_Click);
            // 
            // textBoxUserLogin
            // 
            this.textBoxUserLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBoxUserLogin.Location = new System.Drawing.Point(114, 40);
            this.textBoxUserLogin.Name = "textBoxUserLogin";
            this.textBoxUserLogin.Size = new System.Drawing.Size(167, 29);
            this.textBoxUserLogin.TabIndex = 2;
            this.textBoxUserLogin.Enter += new System.EventHandler(this.textBoxUserLogin_Enter);
            this.textBoxUserLogin.Leave += new System.EventHandler(this.textBoxUserLogin_Leave);
            // 
            // textBoxUserPassword
            // 
            this.textBoxUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBoxUserPassword.Location = new System.Drawing.Point(114, 86);
            this.textBoxUserPassword.Name = "textBoxUserPassword";
            this.textBoxUserPassword.Size = new System.Drawing.Size(167, 29);
            this.textBoxUserPassword.TabIndex = 3;
            this.textBoxUserPassword.Enter += new System.EventHandler(this.textBoxUserPassword_Enter);
            this.textBoxUserPassword.Leave += new System.EventHandler(this.textBoxUserPassword_Leave);
            // 
            // labelAuthorization
            // 
            this.labelAuthorization.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAuthorization.AutoSize = true;
            this.labelAuthorization.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.labelAuthorization.ForeColor = System.Drawing.Color.White;
            this.labelAuthorization.Location = new System.Drawing.Point(268, 9);
            this.labelAuthorization.Name = "labelAuthorization";
            this.labelAuthorization.Size = new System.Drawing.Size(240, 39);
            this.labelAuthorization.TabIndex = 4;
            this.labelAuthorization.Text = "Авторизация";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.labelPasswordString);
            this.panel1.Controls.Add(this.labelLoginString);
            this.panel1.Controls.Add(this.textBoxUserLogin);
            this.panel1.Controls.Add(this.buttonUserLogin);
            this.panel1.Controls.Add(this.textBoxUserPassword);
            this.panel1.Controls.Add(this.buttonExitProgram);
            this.panel1.Location = new System.Drawing.Point(214, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 252);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.labelAuthorization);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 68);
            this.panel2.TabIndex = 6;
            // 
            // labelLoginString
            // 
            this.labelLoginString.AutoSize = true;
            this.labelLoginString.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginString.ForeColor = System.Drawing.Color.White;
            this.labelLoginString.Location = new System.Drawing.Point(20, 40);
            this.labelLoginString.Name = "labelLoginString";
            this.labelLoginString.Size = new System.Drawing.Size(88, 29);
            this.labelLoginString.TabIndex = 4;
            this.labelLoginString.Text = "Логин";
            // 
            // labelPasswordString
            // 
            this.labelPasswordString.AutoSize = true;
            this.labelPasswordString.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasswordString.ForeColor = System.Drawing.Color.White;
            this.labelPasswordString.Location = new System.Drawing.Point(3, 85);
            this.labelPasswordString.Name = "labelPasswordString";
            this.labelPasswordString.Size = new System.Drawing.Size(105, 29);
            this.labelPasswordString.TabIndex = 5;
            this.labelPasswordString.Text = "Пароль";
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(360, 400);
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuthorizationForm";
            this.Activated += new System.EventHandler(this.AuthorizationForm_Activated);
            this.Load += new System.EventHandler(this.AuthorizationForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonUserLogin;
        private System.Windows.Forms.Button buttonExitProgram;
        private System.Windows.Forms.TextBox textBoxUserLogin;
        private System.Windows.Forms.TextBox textBoxUserPassword;
        private System.Windows.Forms.Label labelAuthorization;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelPasswordString;
        private System.Windows.Forms.Label labelLoginString;
    }
}