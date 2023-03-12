namespace inventory_db
{
    partial class FormLocation
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
            this.buttonAddNewLocation = new System.Windows.Forms.Button();
            this.listViewLocation = new System.Windows.Forms.ListView();
            this.columnLocationName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxAddNewLocation = new System.Windows.Forms.TextBox();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.buttonEmptyFilter = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelAccountManagementAddNewUser = new System.Windows.Forms.Label();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.buttonCencel = new System.Windows.Forms.Button();
            this.textBoxChangeLocation = new System.Windows.Forms.TextBox();
            this.buttonChangeLocation = new System.Windows.Forms.Button();
            this.buttonCensel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAddNewLocation
            // 
            this.buttonAddNewLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddNewLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonAddNewLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddNewLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonAddNewLocation.ForeColor = System.Drawing.Color.White;
            this.buttonAddNewLocation.Location = new System.Drawing.Point(554, 221);
            this.buttonAddNewLocation.Name = "buttonAddNewLocation";
            this.buttonAddNewLocation.Size = new System.Drawing.Size(132, 36);
            this.buttonAddNewLocation.TabIndex = 2;
            this.buttonAddNewLocation.Text = "Добавить";
            this.buttonAddNewLocation.UseVisualStyleBackColor = false;
            this.buttonAddNewLocation.Click += new System.EventHandler(this.buttonAddNewLocation_Click);
            // 
            // listViewLocation
            // 
            this.listViewLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listViewLocation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnLocationName});
            this.listViewLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listViewLocation.FullRowSelect = true;
            this.listViewLocation.GridLines = true;
            this.listViewLocation.HideSelection = false;
            this.listViewLocation.Location = new System.Drawing.Point(12, 75);
            this.listViewLocation.Name = "listViewLocation";
            this.listViewLocation.Size = new System.Drawing.Size(404, 363);
            this.listViewLocation.TabIndex = 3;
            this.listViewLocation.UseCompatibleStateImageBehavior = false;
            this.listViewLocation.View = System.Windows.Forms.View.Details;
            this.listViewLocation.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewLocation_MouseDoubleClick);
            this.listViewLocation.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listViewAccountManagement_MouseDown);
            // 
            // columnLocationName
            // 
            this.columnLocationName.Text = "Локация";
            // 
            // textBoxAddNewLocation
            // 
            this.textBoxAddNewLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAddNewLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.textBoxAddNewLocation.Location = new System.Drawing.Point(446, 183);
            this.textBoxAddNewLocation.Name = "textBoxAddNewLocation";
            this.textBoxAddNewLocation.Size = new System.Drawing.Size(342, 32);
            this.textBoxAddNewLocation.TabIndex = 18;
            this.textBoxAddNewLocation.TextChanged += new System.EventHandler(this.textBoxAddNewLocation_TextChanged);
            this.textBoxAddNewLocation.Enter += new System.EventHandler(this.textBoxAddNewLocation_Enter);
            this.textBoxAddNewLocation.Leave += new System.EventHandler(this.textBoxAddNewLocation_Leave);
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.textBoxFilter.Location = new System.Drawing.Point(446, 75);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(342, 32);
            this.textBoxFilter.TabIndex = 19;
            this.textBoxFilter.TextChanged += new System.EventHandler(this.textBoxFilter_TextChanged);
            // 
            // buttonEmptyFilter
            // 
            this.buttonEmptyFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEmptyFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonEmptyFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmptyFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmptyFilter.ForeColor = System.Drawing.Color.White;
            this.buttonEmptyFilter.Location = new System.Drawing.Point(511, 129);
            this.buttonEmptyFilter.Name = "buttonEmptyFilter";
            this.buttonEmptyFilter.Size = new System.Drawing.Size(208, 36);
            this.buttonEmptyFilter.TabIndex = 20;
            this.buttonEmptyFilter.Text = "Отчистить фильтр";
            this.buttonEmptyFilter.UseVisualStyleBackColor = false;
            this.buttonEmptyFilter.Click += new System.EventHandler(this.buttonEmptyFilter_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.labelAccountManagementAddNewUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 60);
            this.panel1.TabIndex = 21;
            // 
            // labelAccountManagementAddNewUser
            // 
            this.labelAccountManagementAddNewUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAccountManagementAddNewUser.AutoSize = true;
            this.labelAccountManagementAddNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.labelAccountManagementAddNewUser.ForeColor = System.Drawing.Color.White;
            this.labelAccountManagementAddNewUser.Location = new System.Drawing.Point(308, 9);
            this.labelAccountManagementAddNewUser.Name = "labelAccountManagementAddNewUser";
            this.labelAccountManagementAddNewUser.Size = new System.Drawing.Size(165, 39);
            this.labelAccountManagementAddNewUser.TabIndex = 10;
            this.labelAccountManagementAddNewUser.Text = "Локации";
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDeleteUser.BackColor = System.Drawing.Color.Red;
            this.buttonDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonDeleteUser.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteUser.Location = new System.Drawing.Point(462, 380);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(132, 36);
            this.buttonDeleteUser.TabIndex = 22;
            this.buttonDeleteUser.Text = "Удалить";
            this.buttonDeleteUser.UseVisualStyleBackColor = false;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // buttonCencel
            // 
            this.buttonCencel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCencel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonCencel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCencel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonCencel.ForeColor = System.Drawing.Color.White;
            this.buttonCencel.Location = new System.Drawing.Point(622, 380);
            this.buttonCencel.Name = "buttonCencel";
            this.buttonCencel.Size = new System.Drawing.Size(132, 36);
            this.buttonCencel.TabIndex = 23;
            this.buttonCencel.Text = "Назад";
            this.buttonCencel.UseVisualStyleBackColor = false;
            this.buttonCencel.Click += new System.EventHandler(this.buttonCencel_Click);
            // 
            // textBoxChangeLocation
            // 
            this.textBoxChangeLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxChangeLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.textBoxChangeLocation.Location = new System.Drawing.Point(446, 280);
            this.textBoxChangeLocation.Name = "textBoxChangeLocation";
            this.textBoxChangeLocation.Size = new System.Drawing.Size(342, 32);
            this.textBoxChangeLocation.TabIndex = 24;
            this.textBoxChangeLocation.Visible = false;
            // 
            // buttonChangeLocation
            // 
            this.buttonChangeLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonChangeLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonChangeLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonChangeLocation.ForeColor = System.Drawing.Color.White;
            this.buttonChangeLocation.Location = new System.Drawing.Point(462, 318);
            this.buttonChangeLocation.Name = "buttonChangeLocation";
            this.buttonChangeLocation.Size = new System.Drawing.Size(132, 36);
            this.buttonChangeLocation.TabIndex = 25;
            this.buttonChangeLocation.Text = "Изменить";
            this.buttonChangeLocation.UseVisualStyleBackColor = false;
            this.buttonChangeLocation.Click += new System.EventHandler(this.buttonChangeLocation_Click);
            // 
            // buttonCensel
            // 
            this.buttonCensel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCensel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonCensel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCensel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonCensel.ForeColor = System.Drawing.Color.White;
            this.buttonCensel.Location = new System.Drawing.Point(622, 318);
            this.buttonCensel.Name = "buttonCensel";
            this.buttonCensel.Size = new System.Drawing.Size(132, 36);
            this.buttonCensel.TabIndex = 26;
            this.buttonCensel.Text = "Отмена";
            this.buttonCensel.UseVisualStyleBackColor = false;
            this.buttonCensel.Click += new System.EventHandler(this.buttonCensel_Click);
            // 
            // FormLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCensel);
            this.Controls.Add(this.buttonChangeLocation);
            this.Controls.Add(this.textBoxChangeLocation);
            this.Controls.Add(this.buttonCencel);
            this.Controls.Add(this.buttonDeleteUser);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonEmptyFilter);
            this.Controls.Add(this.textBoxFilter);
            this.Controls.Add(this.textBoxAddNewLocation);
            this.Controls.Add(this.listViewLocation);
            this.Controls.Add(this.buttonAddNewLocation);
            this.Name = "FormLocation";
            this.Text = "FormLocation";
            this.Activated += new System.EventHandler(this.FormLocation_Activated);
            this.Load += new System.EventHandler(this.FormLocation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddNewLocation;
        private System.Windows.Forms.ListView listViewLocation;
        public System.Windows.Forms.ColumnHeader columnLocationName;
        private System.Windows.Forms.TextBox textBoxAddNewLocation;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.Button buttonEmptyFilter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelAccountManagementAddNewUser;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.Button buttonCencel;
        private System.Windows.Forms.TextBox textBoxChangeLocation;
        private System.Windows.Forms.Button buttonChangeLocation;
        private System.Windows.Forms.Button buttonCensel;
    }
}