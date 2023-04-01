namespace inventory_db
{
    partial class FormEquipmentType
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
            this.listViewEquipment = new System.Windows.Forms.ListView();
            this.columnEquipmentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAddNewEquipment = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelEquipment = new System.Windows.Forms.Label();
            this.buttonEmptyFilter = new System.Windows.Forms.Button();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.textBoxAddNewEquipment = new System.Windows.Forms.TextBox();
            this.buttonCencel = new System.Windows.Forms.Button();
            this.buttonChangeEquipment = new System.Windows.Forms.Button();
            this.textBoxChangeEquipment = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonDeleteEquipment = new System.Windows.Forms.Button();
            this.labellAccountManagementFilter = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewEquipment
            // 
            this.listViewEquipment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listViewEquipment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnEquipmentName});
            this.listViewEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listViewEquipment.FullRowSelect = true;
            this.listViewEquipment.GridLines = true;
            this.listViewEquipment.HideSelection = false;
            this.listViewEquipment.Location = new System.Drawing.Point(12, 81);
            this.listViewEquipment.Name = "listViewEquipment";
            this.listViewEquipment.Size = new System.Drawing.Size(404, 363);
            this.listViewEquipment.TabIndex = 28;
            this.listViewEquipment.UseCompatibleStateImageBehavior = false;
            this.listViewEquipment.View = System.Windows.Forms.View.Details;
            this.listViewEquipment.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listViewEquipment_MouseDown);
            // 
            // columnEquipmentName
            // 
            this.columnEquipmentName.Text = "Тип оборудования";
            // 
            // buttonAddNewEquipment
            // 
            this.buttonAddNewEquipment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddNewEquipment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonAddNewEquipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddNewEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonAddNewEquipment.ForeColor = System.Drawing.Color.White;
            this.buttonAddNewEquipment.Location = new System.Drawing.Point(554, 227);
            this.buttonAddNewEquipment.Name = "buttonAddNewEquipment";
            this.buttonAddNewEquipment.Size = new System.Drawing.Size(132, 36);
            this.buttonAddNewEquipment.TabIndex = 27;
            this.buttonAddNewEquipment.Text = "Добавить";
            this.buttonAddNewEquipment.UseVisualStyleBackColor = false;
            this.buttonAddNewEquipment.Click += new System.EventHandler(this.buttonAddNewEquipment_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.labelEquipment);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 60);
            this.panel1.TabIndex = 32;
            // 
            // labelEquipment
            // 
            this.labelEquipment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEquipment.AutoSize = true;
            this.labelEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.labelEquipment.ForeColor = System.Drawing.Color.White;
            this.labelEquipment.Location = new System.Drawing.Point(239, 9);
            this.labelEquipment.Name = "labelEquipment";
            this.labelEquipment.Size = new System.Drawing.Size(358, 39);
            this.labelEquipment.TabIndex = 10;
            this.labelEquipment.Text = "Типы оборудования";
            this.labelEquipment.Click += new System.EventHandler(this.labelEquipment_Click);
            // 
            // buttonEmptyFilter
            // 
            this.buttonEmptyFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEmptyFilter.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonEmptyFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmptyFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmptyFilter.ForeColor = System.Drawing.Color.White;
            this.buttonEmptyFilter.Location = new System.Drawing.Point(511, 135);
            this.buttonEmptyFilter.Name = "buttonEmptyFilter";
            this.buttonEmptyFilter.Size = new System.Drawing.Size(208, 36);
            this.buttonEmptyFilter.TabIndex = 31;
            this.buttonEmptyFilter.Text = "Очистить фильтр";
            this.buttonEmptyFilter.UseVisualStyleBackColor = false;
            this.buttonEmptyFilter.Click += new System.EventHandler(this.buttonEmptyFilter_Click);
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.textBoxFilter.Location = new System.Drawing.Point(446, 90);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(342, 32);
            this.textBoxFilter.TabIndex = 30;
            this.textBoxFilter.TextChanged += new System.EventHandler(this.textBoxFilter_TextChanged);
            // 
            // textBoxAddNewEquipment
            // 
            this.textBoxAddNewEquipment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAddNewEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.textBoxAddNewEquipment.Location = new System.Drawing.Point(446, 189);
            this.textBoxAddNewEquipment.Name = "textBoxAddNewEquipment";
            this.textBoxAddNewEquipment.Size = new System.Drawing.Size(342, 32);
            this.textBoxAddNewEquipment.TabIndex = 29;
            this.textBoxAddNewEquipment.Enter += new System.EventHandler(this.textBoxAddNewEquipment_Enter);
            this.textBoxAddNewEquipment.Leave += new System.EventHandler(this.textBoxAddNewEquipment_Leave);
            // 
            // buttonCencel
            // 
            this.buttonCencel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCencel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonCencel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCencel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonCencel.ForeColor = System.Drawing.Color.White;
            this.buttonCencel.Location = new System.Drawing.Point(622, 324);
            this.buttonCencel.Name = "buttonCencel";
            this.buttonCencel.Size = new System.Drawing.Size(132, 36);
            this.buttonCencel.TabIndex = 37;
            this.buttonCencel.Text = "Отмена";
            this.buttonCencel.UseVisualStyleBackColor = false;
            this.buttonCencel.Click += new System.EventHandler(this.buttonCencel_Click);
            // 
            // buttonChangeEquipment
            // 
            this.buttonChangeEquipment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonChangeEquipment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonChangeEquipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonChangeEquipment.ForeColor = System.Drawing.Color.White;
            this.buttonChangeEquipment.Location = new System.Drawing.Point(462, 324);
            this.buttonChangeEquipment.Name = "buttonChangeEquipment";
            this.buttonChangeEquipment.Size = new System.Drawing.Size(132, 36);
            this.buttonChangeEquipment.TabIndex = 36;
            this.buttonChangeEquipment.Text = "Изменить";
            this.buttonChangeEquipment.UseVisualStyleBackColor = false;
            this.buttonChangeEquipment.Click += new System.EventHandler(this.buttonChangeEquipment_Click);
            // 
            // textBoxChangeEquipment
            // 
            this.textBoxChangeEquipment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxChangeEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.textBoxChangeEquipment.Location = new System.Drawing.Point(446, 286);
            this.textBoxChangeEquipment.Name = "textBoxChangeEquipment";
            this.textBoxChangeEquipment.Size = new System.Drawing.Size(342, 32);
            this.textBoxChangeEquipment.TabIndex = 35;
            this.textBoxChangeEquipment.Visible = false;
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(622, 386);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(132, 36);
            this.buttonBack.TabIndex = 34;
            this.buttonBack.Text = "Закрыть";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonDeleteEquipment
            // 
            this.buttonDeleteEquipment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDeleteEquipment.BackColor = System.Drawing.Color.Red;
            this.buttonDeleteEquipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonDeleteEquipment.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteEquipment.Location = new System.Drawing.Point(462, 386);
            this.buttonDeleteEquipment.Name = "buttonDeleteEquipment";
            this.buttonDeleteEquipment.Size = new System.Drawing.Size(132, 36);
            this.buttonDeleteEquipment.TabIndex = 33;
            this.buttonDeleteEquipment.Text = "Удалить";
            this.buttonDeleteEquipment.UseVisualStyleBackColor = false;
            this.buttonDeleteEquipment.Click += new System.EventHandler(this.buttonDeleteEquipment_Click);
            // 
            // labellAccountManagementFilter
            // 
            this.labellAccountManagementFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labellAccountManagementFilter.AutoSize = true;
            this.labellAccountManagementFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellAccountManagementFilter.ForeColor = System.Drawing.Color.White;
            this.labellAccountManagementFilter.Location = new System.Drawing.Point(575, 63);
            this.labellAccountManagementFilter.Name = "labellAccountManagementFilter";
            this.labellAccountManagementFilter.Size = new System.Drawing.Size(85, 24);
            this.labellAccountManagementFilter.TabIndex = 38;
            this.labellAccountManagementFilter.Text = "Фильтр";
            // 
            // FormEquipmentType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labellAccountManagementFilter);
            this.Controls.Add(this.listViewEquipment);
            this.Controls.Add(this.buttonAddNewEquipment);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonEmptyFilter);
            this.Controls.Add(this.textBoxFilter);
            this.Controls.Add(this.textBoxAddNewEquipment);
            this.Controls.Add(this.buttonCencel);
            this.Controls.Add(this.buttonChangeEquipment);
            this.Controls.Add(this.textBoxChangeEquipment);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonDeleteEquipment);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FormEquipmentType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Типы оборудования";
            this.Activated += new System.EventHandler(this.FormEquipment_Activated);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewEquipment;
        public System.Windows.Forms.ColumnHeader columnEquipmentName;
        private System.Windows.Forms.Button buttonAddNewEquipment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelEquipment;
        private System.Windows.Forms.Button buttonEmptyFilter;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.TextBox textBoxAddNewEquipment;
        private System.Windows.Forms.Button buttonCencel;
        private System.Windows.Forms.Button buttonChangeEquipment;
        private System.Windows.Forms.TextBox textBoxChangeEquipment;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonDeleteEquipment;
        private System.Windows.Forms.Label labellAccountManagementFilter;
    }
}