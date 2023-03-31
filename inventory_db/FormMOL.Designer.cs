namespace inventory_db
{
    partial class FormMOL
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
            this.labelMOL = new System.Windows.Forms.Label();
            this.listViewMOL = new System.Windows.Forms.ListView();
            this.columnHeaderFullNameMOL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMOLDepartment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAddNewMOL = new System.Windows.Forms.Button();
            this.buttonEmptyFilter = new System.Windows.Forms.Button();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.buttonChangeMOL = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.labelMOL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 60);
            this.panel1.TabIndex = 32;
            // 
            // labelMOL
            // 
            this.labelMOL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMOL.AutoSize = true;
            this.labelMOL.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.labelMOL.ForeColor = System.Drawing.Color.White;
            this.labelMOL.Location = new System.Drawing.Point(308, 9);
            this.labelMOL.Name = "labelMOL";
            this.labelMOL.Size = new System.Drawing.Size(135, 39);
            this.labelMOL.TabIndex = 10;
            this.labelMOL.Text = "МОЛ\'ы";
            // 
            // listViewMOL
            // 
            this.listViewMOL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listViewMOL.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderFullNameMOL,
            this.columnHeaderMOLDepartment});
            this.listViewMOL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listViewMOL.FullRowSelect = true;
            this.listViewMOL.GridLines = true;
            this.listViewMOL.HideSelection = false;
            this.listViewMOL.Location = new System.Drawing.Point(12, 81);
            this.listViewMOL.Name = "listViewMOL";
            this.listViewMOL.Size = new System.Drawing.Size(404, 363);
            this.listViewMOL.TabIndex = 28;
            this.listViewMOL.UseCompatibleStateImageBehavior = false;
            this.listViewMOL.View = System.Windows.Forms.View.Details;
            this.listViewMOL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listViewMOL_MouseDown);
            // 
            // columnHeaderFullNameMOL
            // 
            this.columnHeaderFullNameMOL.Text = "ФИО МОЛ\'а";
            // 
            // columnHeaderMOLDepartment
            // 
            this.columnHeaderMOLDepartment.Text = "Подразделение";
            this.columnHeaderMOLDepartment.Width = 178;
            // 
            // buttonAddNewMOL
            // 
            this.buttonAddNewMOL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddNewMOL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonAddNewMOL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddNewMOL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonAddNewMOL.ForeColor = System.Drawing.Color.White;
            this.buttonAddNewMOL.Location = new System.Drawing.Point(547, 220);
            this.buttonAddNewMOL.Name = "buttonAddNewMOL";
            this.buttonAddNewMOL.Size = new System.Drawing.Size(132, 36);
            this.buttonAddNewMOL.TabIndex = 27;
            this.buttonAddNewMOL.Text = "Добавить";
            this.buttonAddNewMOL.UseVisualStyleBackColor = false;
            this.buttonAddNewMOL.Click += new System.EventHandler(this.buttonAddNewMOL_Click);
            // 
            // buttonEmptyFilter
            // 
            this.buttonEmptyFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEmptyFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonEmptyFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmptyFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmptyFilter.ForeColor = System.Drawing.Color.White;
            this.buttonEmptyFilter.Location = new System.Drawing.Point(511, 135);
            this.buttonEmptyFilter.Name = "buttonEmptyFilter";
            this.buttonEmptyFilter.Size = new System.Drawing.Size(208, 36);
            this.buttonEmptyFilter.TabIndex = 31;
            this.buttonEmptyFilter.Text = "Отчистить фильтр";
            this.buttonEmptyFilter.UseVisualStyleBackColor = false;
            this.buttonEmptyFilter.Click += new System.EventHandler(this.buttonEmptyFilter_Click);
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.textBoxFilter.Location = new System.Drawing.Point(446, 81);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(342, 32);
            this.textBoxFilter.TabIndex = 30;
            this.textBoxFilter.TextChanged += new System.EventHandler(this.textBoxFilter_TextChanged);
            // 
            // buttonChangeMOL
            // 
            this.buttonChangeMOL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonChangeMOL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonChangeMOL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeMOL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonChangeMOL.ForeColor = System.Drawing.Color.White;
            this.buttonChangeMOL.Location = new System.Drawing.Point(547, 280);
            this.buttonChangeMOL.Name = "buttonChangeMOL";
            this.buttonChangeMOL.Size = new System.Drawing.Size(132, 36);
            this.buttonChangeMOL.TabIndex = 36;
            this.buttonChangeMOL.Text = "Изменить";
            this.buttonChangeMOL.UseVisualStyleBackColor = false;
            this.buttonChangeMOL.Click += new System.EventHandler(this.buttonChangeMOL_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(547, 340);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(132, 36);
            this.buttonBack.TabIndex = 34;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDeleteUser.BackColor = System.Drawing.Color.Red;
            this.buttonDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonDeleteUser.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteUser.Location = new System.Drawing.Point(547, 396);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(132, 36);
            this.buttonDeleteUser.TabIndex = 33;
            this.buttonDeleteUser.Text = "Удалить";
            this.buttonDeleteUser.UseVisualStyleBackColor = false;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // FormMOL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listViewMOL);
            this.Controls.Add(this.buttonAddNewMOL);
            this.Controls.Add(this.buttonEmptyFilter);
            this.Controls.Add(this.textBoxFilter);
            this.Controls.Add(this.buttonChangeMOL);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonDeleteUser);
            this.Name = "FormMOL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "МОЛ\'ы";
            this.Activated += new System.EventHandler(this.FormMOL_Activated);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelMOL;
        private System.Windows.Forms.ListView listViewMOL;
        public System.Windows.Forms.ColumnHeader columnHeaderFullNameMOL;
        private System.Windows.Forms.Button buttonAddNewMOL;
        private System.Windows.Forms.Button buttonEmptyFilter;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.Button buttonChangeMOL;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.ColumnHeader columnHeaderMOLDepartment;
    }
}