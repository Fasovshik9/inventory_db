namespace inventory_db
{
    partial class FormAccountManagement
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
            this.listViewAccountManagement = new System.Windows.Forms.ListView();
            this.columnHeaderUserLogin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUserPrivilege = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAddNewUser = new System.Windows.Forms.Button();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.buttonChangeUser = new System.Windows.Forms.Button();
            this.labelAccountManagementAddNewUser = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labellAccountManagementFilter = new System.Windows.Forms.Label();
            this.buttonEmptyFilter = new System.Windows.Forms.Button();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewAccountManagement
            // 
            this.listViewAccountManagement.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listViewAccountManagement.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderUserLogin,
            this.columnHeaderFullName,
            this.columnHeaderUserPrivilege});
            this.listViewAccountManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listViewAccountManagement.FullRowSelect = true;
            this.listViewAccountManagement.GridLines = true;
            this.listViewAccountManagement.HideSelection = false;
            this.listViewAccountManagement.Location = new System.Drawing.Point(12, 119);
            this.listViewAccountManagement.Name = "listViewAccountManagement";
            this.listViewAccountManagement.Size = new System.Drawing.Size(570, 288);
            this.listViewAccountManagement.TabIndex = 0;
            this.listViewAccountManagement.UseCompatibleStateImageBehavior = false;
            this.listViewAccountManagement.View = System.Windows.Forms.View.Details;
            this.listViewAccountManagement.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewAccountManagement_MouseDoubleClick);
            this.listViewAccountManagement.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listViewAccountManagement_MouseDown);
            // 
            // columnHeaderUserLogin
            // 
            this.columnHeaderUserLogin.Text = "Логин";
            // 
            // columnHeaderFullName
            // 
            this.columnHeaderFullName.Text = "ФИО";
            // 
            // columnHeaderUserPrivilege
            // 
            this.columnHeaderUserPrivilege.Text = "Привилегия";
            // 
            // buttonAddNewUser
            // 
            this.buttonAddNewUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddNewUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonAddNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonAddNewUser.ForeColor = System.Drawing.Color.White;
            this.buttonAddNewUser.Location = new System.Drawing.Point(27, 433);
            this.buttonAddNewUser.Name = "buttonAddNewUser";
            this.buttonAddNewUser.Size = new System.Drawing.Size(132, 36);
            this.buttonAddNewUser.TabIndex = 1;
            this.buttonAddNewUser.Text = "Добавить";
            this.buttonAddNewUser.UseVisualStyleBackColor = false;
            this.buttonAddNewUser.Click += new System.EventHandler(this.buttonAddNewUser_Click);
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDeleteUser.BackColor = System.Drawing.Color.Red;
            this.buttonDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonDeleteUser.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteUser.Location = new System.Drawing.Point(422, 433);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(132, 36);
            this.buttonDeleteUser.TabIndex = 2;
            this.buttonDeleteUser.Text = "Удалить";
            this.buttonDeleteUser.UseVisualStyleBackColor = false;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // buttonChangeUser
            // 
            this.buttonChangeUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonChangeUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonChangeUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonChangeUser.ForeColor = System.Drawing.Color.White;
            this.buttonChangeUser.Location = new System.Drawing.Point(225, 433);
            this.buttonChangeUser.Name = "buttonChangeUser";
            this.buttonChangeUser.Size = new System.Drawing.Size(132, 36);
            this.buttonChangeUser.TabIndex = 3;
            this.buttonChangeUser.Text = "Изменить";
            this.buttonChangeUser.UseVisualStyleBackColor = false;
            this.buttonChangeUser.Click += new System.EventHandler(this.buttonChangeUser_Click);
            // 
            // labelAccountManagementAddNewUser
            // 
            this.labelAccountManagementAddNewUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAccountManagementAddNewUser.AutoSize = true;
            this.labelAccountManagementAddNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.labelAccountManagementAddNewUser.ForeColor = System.Drawing.Color.White;
            this.labelAccountManagementAddNewUser.Location = new System.Drawing.Point(5, 9);
            this.labelAccountManagementAddNewUser.Name = "labelAccountManagementAddNewUser";
            this.labelAccountManagementAddNewUser.Size = new System.Drawing.Size(570, 39);
            this.labelAccountManagementAddNewUser.TabIndex = 10;
            this.labelAccountManagementAddNewUser.Text = "Управление учеными записфми";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.labelAccountManagementAddNewUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 60);
            this.panel1.TabIndex = 14;
            // 
            // labellAccountManagementFilter
            // 
            this.labellAccountManagementFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labellAccountManagementFilter.AutoSize = true;
            this.labellAccountManagementFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellAccountManagementFilter.ForeColor = System.Drawing.Color.White;
            this.labellAccountManagementFilter.Location = new System.Drawing.Point(12, 81);
            this.labellAccountManagementFilter.Name = "labellAccountManagementFilter";
            this.labellAccountManagementFilter.Size = new System.Drawing.Size(85, 24);
            this.labellAccountManagementFilter.TabIndex = 15;
            this.labellAccountManagementFilter.Text = "Фильтр";
            // 
            // buttonEmptyFilter
            // 
            this.buttonEmptyFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEmptyFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonEmptyFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmptyFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmptyFilter.ForeColor = System.Drawing.Color.White;
            this.buttonEmptyFilter.Location = new System.Drawing.Point(374, 75);
            this.buttonEmptyFilter.Name = "buttonEmptyFilter";
            this.buttonEmptyFilter.Size = new System.Drawing.Size(208, 36);
            this.buttonEmptyFilter.TabIndex = 16;
            this.buttonEmptyFilter.Text = "Отчистить фильтр";
            this.buttonEmptyFilter.UseVisualStyleBackColor = false;
            this.buttonEmptyFilter.Click += new System.EventHandler(this.buttonEmptyFilter_Click);
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.textBoxFilter.Location = new System.Drawing.Point(103, 77);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(265, 32);
            this.textBoxFilter.TabIndex = 17;
            this.textBoxFilter.TextChanged += new System.EventHandler(this.textBoxFilter_TextChanged);
            // 
            // FormAccountManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(594, 481);
            this.Controls.Add(this.textBoxFilter);
            this.Controls.Add(this.buttonEmptyFilter);
            this.Controls.Add(this.labellAccountManagementFilter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonChangeUser);
            this.Controls.Add(this.buttonDeleteUser);
            this.Controls.Add(this.buttonAddNewUser);
            this.Controls.Add(this.listViewAccountManagement);
            this.MinimumSize = new System.Drawing.Size(610, 520);
            this.Name = "FormAccountManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAccountManagement";
            this.Activated += new System.EventHandler(this.FormAccountManagement_Activated);
            this.Load += new System.EventHandler(this.FormAccountManagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewAccountManagement;
        private System.Windows.Forms.ColumnHeader columnHeaderUserPrivilege;
        private System.Windows.Forms.ColumnHeader columnHeaderFullName;
        private System.Windows.Forms.Button buttonAddNewUser;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.Button buttonChangeUser;
        private System.Windows.Forms.Label labelAccountManagementAddNewUser;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ColumnHeader columnHeaderUserLogin;
        private System.Windows.Forms.Label labellAccountManagementFilter;
        private System.Windows.Forms.Button buttonEmptyFilter;
        private System.Windows.Forms.TextBox textBoxFilter;
    }
}