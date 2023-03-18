namespace inventory_db
{
    partial class FormEquipmentModel
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
            this.listViewEquipmentModel = new System.Windows.Forms.ListView();
            this.columnHeaderEquipmentManufacturerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeadeEquipmentModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTypeEquipment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelAccountEquipmentModel = new System.Windows.Forms.Label();
            this.buttonChangeEquipmentModel = new System.Windows.Forms.Button();
            this.buttonDeleteEquipmentModel = new System.Windows.Forms.Button();
            this.buttonAddNewEquipmentModel = new System.Windows.Forms.Button();
            this.buttonCencel = new System.Windows.Forms.Button();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.buttonEmptyFilter = new System.Windows.Forms.Button();
            this.labellAccountManagementFilter = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewEquipmentModel
            // 
            this.listViewEquipmentModel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderEquipmentManufacturerName,
            this.columnHeadeEquipmentModel,
            this.columnHeaderTypeEquipment});
            this.listViewEquipmentModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listViewEquipmentModel.FullRowSelect = true;
            this.listViewEquipmentModel.GridLines = true;
            this.listViewEquipmentModel.HideSelection = false;
            this.listViewEquipmentModel.Location = new System.Drawing.Point(37, 154);
            this.listViewEquipmentModel.Name = "listViewEquipmentModel";
            this.listViewEquipmentModel.Size = new System.Drawing.Size(658, 366);
            this.listViewEquipmentModel.TabIndex = 28;
            this.listViewEquipmentModel.UseCompatibleStateImageBehavior = false;
            this.listViewEquipmentModel.View = System.Windows.Forms.View.Details;
            this.listViewEquipmentModel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listViewEquipmentModel_MouseDown);
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
            this.panel1.Controls.Add(this.labelAccountEquipmentModel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 60);
            this.panel1.TabIndex = 32;
            // 
            // labelAccountEquipmentModel
            // 
            this.labelAccountEquipmentModel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAccountEquipmentModel.AutoSize = true;
            this.labelAccountEquipmentModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.labelAccountEquipmentModel.ForeColor = System.Drawing.Color.White;
            this.labelAccountEquipmentModel.Location = new System.Drawing.Point(128, 9);
            this.labelAccountEquipmentModel.Name = "labelAccountEquipmentModel";
            this.labelAccountEquipmentModel.Size = new System.Drawing.Size(402, 39);
            this.labelAccountEquipmentModel.TabIndex = 10;
            this.labelAccountEquipmentModel.Text = "Модели оборудования";
            // 
            // buttonChangeEquipmentModel
            // 
            this.buttonChangeEquipmentModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonChangeEquipmentModel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeEquipmentModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonChangeEquipmentModel.ForeColor = System.Drawing.Color.White;
            this.buttonChangeEquipmentModel.Location = new System.Drawing.Point(191, 540);
            this.buttonChangeEquipmentModel.Name = "buttonChangeEquipmentModel";
            this.buttonChangeEquipmentModel.Size = new System.Drawing.Size(132, 36);
            this.buttonChangeEquipmentModel.TabIndex = 31;
            this.buttonChangeEquipmentModel.Text = "Изменить";
            this.buttonChangeEquipmentModel.UseVisualStyleBackColor = false;
            this.buttonChangeEquipmentModel.Click += new System.EventHandler(this.buttonChangeEquipmentModel_Click);
            // 
            // buttonDeleteEquipmentModel
            // 
            this.buttonDeleteEquipmentModel.BackColor = System.Drawing.Color.Red;
            this.buttonDeleteEquipmentModel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteEquipmentModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonDeleteEquipmentModel.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteEquipmentModel.Location = new System.Drawing.Point(386, 540);
            this.buttonDeleteEquipmentModel.Name = "buttonDeleteEquipmentModel";
            this.buttonDeleteEquipmentModel.Size = new System.Drawing.Size(132, 36);
            this.buttonDeleteEquipmentModel.TabIndex = 30;
            this.buttonDeleteEquipmentModel.Text = "Удалить";
            this.buttonDeleteEquipmentModel.UseVisualStyleBackColor = false;
            this.buttonDeleteEquipmentModel.Click += new System.EventHandler(this.buttonDeleteEquipmentModel_Click);
            // 
            // buttonAddNewEquipmentModel
            // 
            this.buttonAddNewEquipmentModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonAddNewEquipmentModel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddNewEquipmentModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonAddNewEquipmentModel.ForeColor = System.Drawing.Color.White;
            this.buttonAddNewEquipmentModel.Location = new System.Drawing.Point(38, 540);
            this.buttonAddNewEquipmentModel.Name = "buttonAddNewEquipmentModel";
            this.buttonAddNewEquipmentModel.Size = new System.Drawing.Size(132, 36);
            this.buttonAddNewEquipmentModel.TabIndex = 29;
            this.buttonAddNewEquipmentModel.Text = "Добавить";
            this.buttonAddNewEquipmentModel.UseVisualStyleBackColor = false;
            this.buttonAddNewEquipmentModel.Click += new System.EventHandler(this.buttonAddNewEquipmentModel_Click);
            // 
            // buttonCencel
            // 
            this.buttonCencel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonCencel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCencel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonCencel.ForeColor = System.Drawing.Color.White;
            this.buttonCencel.Location = new System.Drawing.Point(547, 540);
            this.buttonCencel.Name = "buttonCencel";
            this.buttonCencel.Size = new System.Drawing.Size(132, 36);
            this.buttonCencel.TabIndex = 36;
            this.buttonCencel.Text = "Отмена";
            this.buttonCencel.UseVisualStyleBackColor = false;
            this.buttonCencel.Click += new System.EventHandler(this.buttonCencel_Click);
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.textBoxFilter.Location = new System.Drawing.Point(124, 105);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(265, 32);
            this.textBoxFilter.TabIndex = 35;
            this.textBoxFilter.TextChanged += new System.EventHandler(this.textBoxFilter_TextChanged);
            // 
            // buttonEmptyFilter
            // 
            this.buttonEmptyFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonEmptyFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmptyFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmptyFilter.ForeColor = System.Drawing.Color.White;
            this.buttonEmptyFilter.Location = new System.Drawing.Point(395, 103);
            this.buttonEmptyFilter.Name = "buttonEmptyFilter";
            this.buttonEmptyFilter.Size = new System.Drawing.Size(208, 36);
            this.buttonEmptyFilter.TabIndex = 34;
            this.buttonEmptyFilter.Text = "Отчистить фильтр";
            this.buttonEmptyFilter.UseVisualStyleBackColor = false;
            this.buttonEmptyFilter.Click += new System.EventHandler(this.buttonEmptyFilter_Click);
            // 
            // labellAccountManagementFilter
            // 
            this.labellAccountManagementFilter.AutoSize = true;
            this.labellAccountManagementFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellAccountManagementFilter.ForeColor = System.Drawing.Color.White;
            this.labellAccountManagementFilter.Location = new System.Drawing.Point(33, 109);
            this.labellAccountManagementFilter.Name = "labellAccountManagementFilter";
            this.labellAccountManagementFilter.Size = new System.Drawing.Size(85, 24);
            this.labellAccountManagementFilter.TabIndex = 33;
            this.labellAccountManagementFilter.Text = "Фильтр";
            // 
            // FormEquipmentModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(740, 603);
            this.Controls.Add(this.listViewEquipmentModel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonChangeEquipmentModel);
            this.Controls.Add(this.buttonDeleteEquipmentModel);
            this.Controls.Add(this.buttonAddNewEquipmentModel);
            this.Controls.Add(this.buttonCencel);
            this.Controls.Add(this.textBoxFilter);
            this.Controls.Add(this.buttonEmptyFilter);
            this.Controls.Add(this.labellAccountManagementFilter);
            this.Name = "FormEquipmentModel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEquipmentModel";
            this.Activated += new System.EventHandler(this.FormEquipmentModel_Activated);
            this.Load += new System.EventHandler(this.FormEquipmentModel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewEquipmentModel;
        public System.Windows.Forms.ColumnHeader columnHeadeEquipmentModel;
        private System.Windows.Forms.ColumnHeader columnHeaderEquipmentManufacturerName;
        private System.Windows.Forms.ColumnHeader columnHeaderTypeEquipment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelAccountEquipmentModel;
        private System.Windows.Forms.Button buttonChangeEquipmentModel;
        private System.Windows.Forms.Button buttonDeleteEquipmentModel;
        private System.Windows.Forms.Button buttonAddNewEquipmentModel;
        private System.Windows.Forms.Button buttonCencel;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.Button buttonEmptyFilter;
        private System.Windows.Forms.Label labellAccountManagementFilter;
    }
}