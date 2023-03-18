namespace inventory_db
{
    partial class FormEquipment
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
            this.columnHeaderItemNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEquipmentManufacturerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEquipmentModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonChangeEquipment = new System.Windows.Forms.Button();
            this.buttonDeleteEquipment = new System.Windows.Forms.Button();
            this.buttonAddNewEquipment = new System.Windows.Forms.Button();
            this.labelAccountManagementAddNewUser = new System.Windows.Forms.Label();
            this.buttonCencel = new System.Windows.Forms.Button();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.buttonEmptyFilter = new System.Windows.Forms.Button();
            this.labellAccountManagementFilter = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewEquipment
            // 
            this.listViewEquipment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listViewEquipment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderItemNumber,
            this.columnHeaderEquipmentManufacturerName,
            this.columnHeaderEquipmentModel});
            this.listViewEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listViewEquipment.FullRowSelect = true;
            this.listViewEquipment.GridLines = true;
            this.listViewEquipment.HideSelection = false;
            this.listViewEquipment.Location = new System.Drawing.Point(7, 127);
            this.listViewEquipment.Name = "listViewEquipment";
            this.listViewEquipment.Size = new System.Drawing.Size(658, 366);
            this.listViewEquipment.TabIndex = 19;
            this.listViewEquipment.UseCompatibleStateImageBehavior = false;
            this.listViewEquipment.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderItemNumber
            // 
            this.columnHeaderItemNumber.Text = "Номенклатурный артикул";
            this.columnHeaderItemNumber.Width = 208;
            // 
            // columnHeaderEquipmentManufacturerName
            // 
            this.columnHeaderEquipmentManufacturerName.Text = "Производитель оборудования";
            this.columnHeaderEquipmentManufacturerName.Width = 250;
            // 
            // columnHeaderEquipmentModel
            // 
            this.columnHeaderEquipmentModel.Text = "Модель оборудования";
            this.columnHeaderEquipmentModel.Width = 188;
            // 
            // buttonChangeEquipment
            // 
            this.buttonChangeEquipment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonChangeEquipment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonChangeEquipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonChangeEquipment.ForeColor = System.Drawing.Color.White;
            this.buttonChangeEquipment.Location = new System.Drawing.Point(165, 513);
            this.buttonChangeEquipment.Name = "buttonChangeEquipment";
            this.buttonChangeEquipment.Size = new System.Drawing.Size(132, 36);
            this.buttonChangeEquipment.TabIndex = 22;
            this.buttonChangeEquipment.Text = "Изменить";
            this.buttonChangeEquipment.UseVisualStyleBackColor = false;
            // 
            // buttonDeleteEquipment
            // 
            this.buttonDeleteEquipment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDeleteEquipment.BackColor = System.Drawing.Color.Red;
            this.buttonDeleteEquipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonDeleteEquipment.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteEquipment.Location = new System.Drawing.Point(360, 513);
            this.buttonDeleteEquipment.Name = "buttonDeleteEquipment";
            this.buttonDeleteEquipment.Size = new System.Drawing.Size(132, 36);
            this.buttonDeleteEquipment.TabIndex = 21;
            this.buttonDeleteEquipment.Text = "Удалить";
            this.buttonDeleteEquipment.UseVisualStyleBackColor = false;
            // 
            // buttonAddNewEquipment
            // 
            this.buttonAddNewEquipment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddNewEquipment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonAddNewEquipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddNewEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonAddNewEquipment.ForeColor = System.Drawing.Color.White;
            this.buttonAddNewEquipment.Location = new System.Drawing.Point(12, 513);
            this.buttonAddNewEquipment.Name = "buttonAddNewEquipment";
            this.buttonAddNewEquipment.Size = new System.Drawing.Size(132, 36);
            this.buttonAddNewEquipment.TabIndex = 20;
            this.buttonAddNewEquipment.Text = "Добавить";
            this.buttonAddNewEquipment.UseVisualStyleBackColor = false;
            this.buttonAddNewEquipment.Click += new System.EventHandler(this.buttonAddNewEquipment_Click);
            // 
            // labelAccountManagementAddNewUser
            // 
            this.labelAccountManagementAddNewUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAccountManagementAddNewUser.AutoSize = true;
            this.labelAccountManagementAddNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.labelAccountManagementAddNewUser.ForeColor = System.Drawing.Color.White;
            this.labelAccountManagementAddNewUser.Location = new System.Drawing.Point(179, 9);
            this.labelAccountManagementAddNewUser.Name = "labelAccountManagementAddNewUser";
            this.labelAccountManagementAddNewUser.Size = new System.Drawing.Size(267, 39);
            this.labelAccountManagementAddNewUser.TabIndex = 10;
            this.labelAccountManagementAddNewUser.Text = "Оборудование";
            // 
            // buttonCencel
            // 
            this.buttonCencel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCencel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonCencel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCencel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonCencel.ForeColor = System.Drawing.Color.White;
            this.buttonCencel.Location = new System.Drawing.Point(521, 513);
            this.buttonCencel.Name = "buttonCencel";
            this.buttonCencel.Size = new System.Drawing.Size(132, 36);
            this.buttonCencel.TabIndex = 27;
            this.buttonCencel.Text = "Отмена";
            this.buttonCencel.UseVisualStyleBackColor = false;
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.textBoxFilter.Location = new System.Drawing.Point(98, 78);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(332, 32);
            this.textBoxFilter.TabIndex = 26;
            // 
            // buttonEmptyFilter
            // 
            this.buttonEmptyFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEmptyFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonEmptyFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmptyFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmptyFilter.ForeColor = System.Drawing.Color.White;
            this.buttonEmptyFilter.Location = new System.Drawing.Point(436, 76);
            this.buttonEmptyFilter.Name = "buttonEmptyFilter";
            this.buttonEmptyFilter.Size = new System.Drawing.Size(208, 36);
            this.buttonEmptyFilter.TabIndex = 25;
            this.buttonEmptyFilter.Text = "Отчистить фильтр";
            this.buttonEmptyFilter.UseVisualStyleBackColor = false;
            // 
            // labellAccountManagementFilter
            // 
            this.labellAccountManagementFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labellAccountManagementFilter.AutoSize = true;
            this.labellAccountManagementFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellAccountManagementFilter.ForeColor = System.Drawing.Color.White;
            this.labellAccountManagementFilter.Location = new System.Drawing.Point(7, 82);
            this.labellAccountManagementFilter.Name = "labellAccountManagementFilter";
            this.labellAccountManagementFilter.Size = new System.Drawing.Size(85, 24);
            this.labellAccountManagementFilter.TabIndex = 24;
            this.labellAccountManagementFilter.Text = "Фильтр";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.labelAccountManagementAddNewUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 60);
            this.panel1.TabIndex = 23;
            // 
            // FormEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(677, 561);
            this.Controls.Add(this.listViewEquipment);
            this.Controls.Add(this.buttonChangeEquipment);
            this.Controls.Add(this.buttonDeleteEquipment);
            this.Controls.Add(this.buttonAddNewEquipment);
            this.Controls.Add(this.buttonCencel);
            this.Controls.Add(this.textBoxFilter);
            this.Controls.Add(this.buttonEmptyFilter);
            this.Controls.Add(this.labellAccountManagementFilter);
            this.Controls.Add(this.panel1);
            this.Name = "FormEquipment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEquipment";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewEquipment;
        public System.Windows.Forms.ColumnHeader columnHeaderItemNumber;
        private System.Windows.Forms.ColumnHeader columnHeaderEquipmentManufacturerName;
        private System.Windows.Forms.ColumnHeader columnHeaderEquipmentModel;
        private System.Windows.Forms.Button buttonChangeEquipment;
        private System.Windows.Forms.Button buttonDeleteEquipment;
        private System.Windows.Forms.Button buttonAddNewEquipment;
        private System.Windows.Forms.Label labelAccountManagementAddNewUser;
        private System.Windows.Forms.Button buttonCencel;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.Button buttonEmptyFilter;
        private System.Windows.Forms.Label labellAccountManagementFilter;
        private System.Windows.Forms.Panel panel1;
    }
}