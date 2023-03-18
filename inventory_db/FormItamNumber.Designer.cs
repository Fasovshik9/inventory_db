namespace inventory_db
{
    partial class FormItamNumber
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
            this.listViewItamNumber = new System.Windows.Forms.ListView();
            this.columnHeaderItamNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEquipmentManufacturerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeadeEquipmentModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTypeEquipment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelItamNumber = new System.Windows.Forms.Label();
            this.buttonChangeItamNumber = new System.Windows.Forms.Button();
            this.buttonDeleteItamNumber = new System.Windows.Forms.Button();
            this.buttonAddNewItamNumber = new System.Windows.Forms.Button();
            this.buttonCencel = new System.Windows.Forms.Button();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.buttonEmptyFilter = new System.Windows.Forms.Button();
            this.labellAccountManagementFilter = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewItamNumber
            // 
            this.listViewItamNumber.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderItamNumber,
            this.columnHeaderEquipmentManufacturerName,
            this.columnHeadeEquipmentModel,
            this.columnHeaderTypeEquipment});
            this.listViewItamNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listViewItamNumber.FullRowSelect = true;
            this.listViewItamNumber.GridLines = true;
            this.listViewItamNumber.HideSelection = false;
            this.listViewItamNumber.Location = new System.Drawing.Point(37, 160);
            this.listViewItamNumber.Name = "listViewItamNumber";
            this.listViewItamNumber.Size = new System.Drawing.Size(876, 366);
            this.listViewItamNumber.TabIndex = 37;
            this.listViewItamNumber.UseCompatibleStateImageBehavior = false;
            this.listViewItamNumber.View = System.Windows.Forms.View.Details;
            this.listViewItamNumber.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listViewItamNumber_MouseDown);
            // 
            // columnHeaderItamNumber
            // 
            this.columnHeaderItamNumber.Text = "Номенклатурный артикуль";
            this.columnHeaderItamNumber.Width = 221;
            // 
            // columnHeaderEquipmentManufacturerName
            // 
            this.columnHeaderEquipmentManufacturerName.Text = "Производитель";
            this.columnHeaderEquipmentManufacturerName.Width = 250;
            // 
            // columnHeadeEquipmentModel
            // 
            this.columnHeadeEquipmentModel.Text = "Модель";
            this.columnHeadeEquipmentModel.Width = 208;
            // 
            // columnHeaderTypeEquipment
            // 
            this.columnHeaderTypeEquipment.Text = "Тип";
            this.columnHeaderTypeEquipment.Width = 188;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.labelItamNumber);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 60);
            this.panel1.TabIndex = 41;
            // 
            // labelItamNumber
            // 
            this.labelItamNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelItamNumber.AutoSize = true;
            this.labelItamNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.labelItamNumber.ForeColor = System.Drawing.Color.White;
            this.labelItamNumber.Location = new System.Drawing.Point(236, 9);
            this.labelItamNumber.Name = "labelItamNumber";
            this.labelItamNumber.Size = new System.Drawing.Size(478, 39);
            this.labelItamNumber.TabIndex = 10;
            this.labelItamNumber.Text = "Номенклатурный артикуль";
            // 
            // buttonChangeItamNumber
            // 
            this.buttonChangeItamNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonChangeItamNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeItamNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonChangeItamNumber.ForeColor = System.Drawing.Color.White;
            this.buttonChangeItamNumber.Location = new System.Drawing.Point(294, 541);
            this.buttonChangeItamNumber.Name = "buttonChangeItamNumber";
            this.buttonChangeItamNumber.Size = new System.Drawing.Size(132, 36);
            this.buttonChangeItamNumber.TabIndex = 40;
            this.buttonChangeItamNumber.Text = "Изменить";
            this.buttonChangeItamNumber.UseVisualStyleBackColor = false;
            this.buttonChangeItamNumber.Click += new System.EventHandler(this.buttonChangeItamNumber_Click);
            // 
            // buttonDeleteItamNumber
            // 
            this.buttonDeleteItamNumber.BackColor = System.Drawing.Color.Red;
            this.buttonDeleteItamNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteItamNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonDeleteItamNumber.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteItamNumber.Location = new System.Drawing.Point(489, 541);
            this.buttonDeleteItamNumber.Name = "buttonDeleteItamNumber";
            this.buttonDeleteItamNumber.Size = new System.Drawing.Size(132, 36);
            this.buttonDeleteItamNumber.TabIndex = 39;
            this.buttonDeleteItamNumber.Text = "Удалить";
            this.buttonDeleteItamNumber.UseVisualStyleBackColor = false;
            this.buttonDeleteItamNumber.Click += new System.EventHandler(this.buttonDeleteItamNumber_Click);
            // 
            // buttonAddNewItamNumber
            // 
            this.buttonAddNewItamNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonAddNewItamNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddNewItamNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonAddNewItamNumber.ForeColor = System.Drawing.Color.White;
            this.buttonAddNewItamNumber.Location = new System.Drawing.Point(141, 541);
            this.buttonAddNewItamNumber.Name = "buttonAddNewItamNumber";
            this.buttonAddNewItamNumber.Size = new System.Drawing.Size(132, 36);
            this.buttonAddNewItamNumber.TabIndex = 38;
            this.buttonAddNewItamNumber.Text = "Добавить";
            this.buttonAddNewItamNumber.UseVisualStyleBackColor = false;
            this.buttonAddNewItamNumber.Click += new System.EventHandler(this.buttonAddNewItamNumber_Click);
            // 
            // buttonCencel
            // 
            this.buttonCencel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonCencel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCencel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonCencel.ForeColor = System.Drawing.Color.White;
            this.buttonCencel.Location = new System.Drawing.Point(650, 541);
            this.buttonCencel.Name = "buttonCencel";
            this.buttonCencel.Size = new System.Drawing.Size(132, 36);
            this.buttonCencel.TabIndex = 45;
            this.buttonCencel.Text = "Отмена";
            this.buttonCencel.UseVisualStyleBackColor = false;
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.textBoxFilter.Location = new System.Drawing.Point(212, 105);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(288, 32);
            this.textBoxFilter.TabIndex = 44;
            this.textBoxFilter.TextChanged += new System.EventHandler(this.textBoxFilter_TextChanged);
            // 
            // buttonEmptyFilter
            // 
            this.buttonEmptyFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonEmptyFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmptyFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmptyFilter.ForeColor = System.Drawing.Color.White;
            this.buttonEmptyFilter.Location = new System.Drawing.Point(506, 103);
            this.buttonEmptyFilter.Name = "buttonEmptyFilter";
            this.buttonEmptyFilter.Size = new System.Drawing.Size(208, 36);
            this.buttonEmptyFilter.TabIndex = 43;
            this.buttonEmptyFilter.Text = "Отчистить фильтр";
            this.buttonEmptyFilter.UseVisualStyleBackColor = false;
            this.buttonEmptyFilter.Click += new System.EventHandler(this.buttonEmptyFilter_Click);
            // 
            // labellAccountManagementFilter
            // 
            this.labellAccountManagementFilter.AutoSize = true;
            this.labellAccountManagementFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellAccountManagementFilter.ForeColor = System.Drawing.Color.White;
            this.labellAccountManagementFilter.Location = new System.Drawing.Point(121, 109);
            this.labellAccountManagementFilter.Name = "labellAccountManagementFilter";
            this.labellAccountManagementFilter.Size = new System.Drawing.Size(85, 24);
            this.labellAccountManagementFilter.TabIndex = 42;
            this.labellAccountManagementFilter.Text = "Фильтр";
            // 
            // FormItamNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(957, 589);
            this.Controls.Add(this.listViewItamNumber);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonChangeItamNumber);
            this.Controls.Add(this.buttonDeleteItamNumber);
            this.Controls.Add(this.buttonAddNewItamNumber);
            this.Controls.Add(this.buttonCencel);
            this.Controls.Add(this.textBoxFilter);
            this.Controls.Add(this.buttonEmptyFilter);
            this.Controls.Add(this.labellAccountManagementFilter);
            this.Name = "FormItamNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormItamNumber";
            this.Activated += new System.EventHandler(this.FormItamNumber_Activated);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewItamNumber;
        private System.Windows.Forms.ColumnHeader columnHeaderEquipmentManufacturerName;
        public System.Windows.Forms.ColumnHeader columnHeadeEquipmentModel;
        private System.Windows.Forms.ColumnHeader columnHeaderTypeEquipment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelItamNumber;
        private System.Windows.Forms.Button buttonChangeItamNumber;
        private System.Windows.Forms.Button buttonDeleteItamNumber;
        private System.Windows.Forms.Button buttonAddNewItamNumber;
        private System.Windows.Forms.Button buttonCencel;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.Button buttonEmptyFilter;
        private System.Windows.Forms.Label labellAccountManagementFilter;
        private System.Windows.Forms.ColumnHeader columnHeaderItamNumber;
    }
}