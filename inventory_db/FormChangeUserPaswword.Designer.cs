namespace inventory_db
{
    partial class FormChangeUserPaswword
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelAccountItamNumber = new System.Windows.Forms.Label();
            this.buttonItamNumberChange = new System.Windows.Forms.Button();
            this.textBoxOldPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCencel = new System.Windows.Forms.Button();
            this.labellAccountManagementFilter = new System.Windows.Forms.Label();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.textBoxNewPasswordRepead = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.labelAccountItamNumber);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 60);
            this.panel1.TabIndex = 76;
            // 
            // labelAccountItamNumber
            // 
            this.labelAccountItamNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAccountItamNumber.AutoSize = true;
            this.labelAccountItamNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.labelAccountItamNumber.ForeColor = System.Drawing.Color.White;
            this.labelAccountItamNumber.Location = new System.Drawing.Point(119, 9);
            this.labelAccountItamNumber.Name = "labelAccountItamNumber";
            this.labelAccountItamNumber.Size = new System.Drawing.Size(260, 39);
            this.labelAccountItamNumber.TabIndex = 10;
            this.labelAccountItamNumber.Text = "Смена пароля";
            // 
            // buttonItamNumberChange
            // 
            this.buttonItamNumberChange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonItamNumberChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonItamNumberChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonItamNumberChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonItamNumberChange.ForeColor = System.Drawing.Color.White;
            this.buttonItamNumberChange.Location = new System.Drawing.Point(101, 323);
            this.buttonItamNumberChange.Name = "buttonItamNumberChange";
            this.buttonItamNumberChange.Size = new System.Drawing.Size(132, 36);
            this.buttonItamNumberChange.TabIndex = 86;
            this.buttonItamNumberChange.Text = "Изменить";
            this.buttonItamNumberChange.UseVisualStyleBackColor = false;
            this.buttonItamNumberChange.Click += new System.EventHandler(this.buttonItamNumberChange_Click);
            // 
            // textBoxOldPassword
            // 
            this.textBoxOldPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxOldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.textBoxOldPassword.Location = new System.Drawing.Point(185, 118);
            this.textBoxOldPassword.Name = "textBoxOldPassword";
            this.textBoxOldPassword.Size = new System.Drawing.Size(248, 32);
            this.textBoxOldPassword.TabIndex = 84;
            this.textBoxOldPassword.Enter += new System.EventHandler(this.textBoxOldPassword_Enter);
            this.textBoxOldPassword.Leave += new System.EventHandler(this.textBoxOldPassword_Leave);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 24);
            this.label3.TabIndex = 83;
            this.label3.Text = "Старый пароль";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 80;
            this.label1.Text = "Производитель";
            // 
            // buttonCencel
            // 
            this.buttonCencel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCencel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonCencel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCencel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonCencel.ForeColor = System.Drawing.Color.White;
            this.buttonCencel.Location = new System.Drawing.Point(261, 323);
            this.buttonCencel.Name = "buttonCencel";
            this.buttonCencel.Size = new System.Drawing.Size(132, 36);
            this.buttonCencel.TabIndex = 78;
            this.buttonCencel.Text = "Отмена";
            this.buttonCencel.UseVisualStyleBackColor = false;
            this.buttonCencel.Click += new System.EventHandler(this.buttonCencel_Click);
            // 
            // labellAccountManagementFilter
            // 
            this.labellAccountManagementFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labellAccountManagementFilter.AutoSize = true;
            this.labellAccountManagementFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellAccountManagementFilter.ForeColor = System.Drawing.Color.White;
            this.labellAccountManagementFilter.Location = new System.Drawing.Point(29, 186);
            this.labellAccountManagementFilter.Name = "labellAccountManagementFilter";
            this.labellAccountManagementFilter.Size = new System.Drawing.Size(150, 24);
            this.labellAccountManagementFilter.TabIndex = 77;
            this.labellAccountManagementFilter.Text = "Новый пароль";
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.textBoxNewPassword.Location = new System.Drawing.Point(185, 186);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.Size = new System.Drawing.Size(248, 32);
            this.textBoxNewPassword.TabIndex = 87;
            this.textBoxNewPassword.Enter += new System.EventHandler(this.textBoxNewPassword_Enter);
            this.textBoxNewPassword.Leave += new System.EventHandler(this.textBoxNewPassword_Leave);
            // 
            // textBoxNewPasswordRepead
            // 
            this.textBoxNewPasswordRepead.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNewPasswordRepead.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.textBoxNewPasswordRepead.Location = new System.Drawing.Point(185, 252);
            this.textBoxNewPasswordRepead.Name = "textBoxNewPasswordRepead";
            this.textBoxNewPasswordRepead.Size = new System.Drawing.Size(248, 32);
            this.textBoxNewPasswordRepead.TabIndex = 88;
            this.textBoxNewPasswordRepead.Enter += new System.EventHandler(this.textBoxNewPasswordRepead_Enter);
            this.textBoxNewPasswordRepead.Leave += new System.EventHandler(this.textBoxNewPasswordRepead_Leave);
            // 
            // FormChangeUserPaswword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(484, 381);
            this.Controls.Add(this.textBoxNewPasswordRepead);
            this.Controls.Add(this.textBoxNewPassword);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonItamNumberChange);
            this.Controls.Add(this.textBoxOldPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCencel);
            this.Controls.Add(this.labellAccountManagementFilter);
            this.MinimumSize = new System.Drawing.Size(500, 420);
            this.Name = "FormChangeUserPaswword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormChangeUserPaswword";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelAccountItamNumber;
        private System.Windows.Forms.Button buttonItamNumberChange;
        private System.Windows.Forms.TextBox textBoxOldPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCencel;
        private System.Windows.Forms.Label labellAccountManagementFilter;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.TextBox textBoxNewPasswordRepead;
    }
}