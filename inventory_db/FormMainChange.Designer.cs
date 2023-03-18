namespace inventory_db
{
    partial class FormMainChange
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
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxStuff = new System.Windows.Forms.ComboBox();
            this.comboBoxItamNumber = new System.Windows.Forms.ComboBox();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxEquipmentType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxEquipmentManufacturer = new System.Windows.Forms.ComboBox();
            this.labellAccountManagementFilter = new System.Windows.Forms.Label();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.comboBoxMOL = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxLocation = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxInventNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonMainChange = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCencel = new System.Windows.Forms.Button();
            this.labelAccountItamNumber = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(134, 508);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 24);
            this.label9.TabIndex = 129;
            this.label9.Text = "Сотрудник ИТ";
            // 
            // comboBoxStuff
            // 
            this.comboBoxStuff.DisplayMember = "1";
            this.comboBoxStuff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.comboBoxStuff.FormattingEnabled = true;
            this.comboBoxStuff.Location = new System.Drawing.Point(289, 500);
            this.comboBoxStuff.Name = "comboBoxStuff";
            this.comboBoxStuff.Size = new System.Drawing.Size(395, 32);
            this.comboBoxStuff.TabIndex = 128;
            this.comboBoxStuff.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxStuff_KeyPress);
            // 
            // comboBoxItamNumber
            // 
            this.comboBoxItamNumber.DisplayMember = "1";
            this.comboBoxItamNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.comboBoxItamNumber.FormattingEnabled = true;
            this.comboBoxItamNumber.Location = new System.Drawing.Point(289, 312);
            this.comboBoxItamNumber.Name = "comboBoxItamNumber";
            this.comboBoxItamNumber.Size = new System.Drawing.Size(395, 32);
            this.comboBoxItamNumber.TabIndex = 127;
            this.comboBoxItamNumber.SelectedIndexChanged += new System.EventHandler(this.comboBoxItamNumber_SelectedIndexChanged);
            this.comboBoxItamNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxItamNumber_KeyPress);
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.DisplayMember = "1";
            this.comboBoxModel.Enabled = false;
            this.comboBoxModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new System.Drawing.Point(289, 359);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(395, 32);
            this.comboBoxModel.TabIndex = 126;
            this.comboBoxModel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxModel_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 24);
            this.label1.TabIndex = 125;
            this.label1.Text = "Номенклатурный артикуль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(233, 456);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 24);
            this.label2.TabIndex = 124;
            this.label2.Text = "Тип";
            // 
            // comboBoxEquipmentType
            // 
            this.comboBoxEquipmentType.DisplayMember = "1";
            this.comboBoxEquipmentType.Enabled = false;
            this.comboBoxEquipmentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.comboBoxEquipmentType.FormattingEnabled = true;
            this.comboBoxEquipmentType.Location = new System.Drawing.Point(289, 453);
            this.comboBoxEquipmentType.Name = "comboBoxEquipmentType";
            this.comboBoxEquipmentType.Size = new System.Drawing.Size(395, 32);
            this.comboBoxEquipmentType.TabIndex = 123;
            this.comboBoxEquipmentType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxEquipmentType_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(117, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 24);
            this.label8.TabIndex = 122;
            this.label8.Text = "Производитель";
            // 
            // comboBoxEquipmentManufacturer
            // 
            this.comboBoxEquipmentManufacturer.DisplayMember = "1";
            this.comboBoxEquipmentManufacturer.Enabled = false;
            this.comboBoxEquipmentManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.comboBoxEquipmentManufacturer.FormattingEnabled = true;
            this.comboBoxEquipmentManufacturer.Location = new System.Drawing.Point(289, 406);
            this.comboBoxEquipmentManufacturer.Name = "comboBoxEquipmentManufacturer";
            this.comboBoxEquipmentManufacturer.Size = new System.Drawing.Size(395, 32);
            this.comboBoxEquipmentManufacturer.TabIndex = 121;
            this.comboBoxEquipmentManufacturer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxEquipmentManufacturer_KeyPress);
            // 
            // labellAccountManagementFilter
            // 
            this.labellAccountManagementFilter.AutoSize = true;
            this.labellAccountManagementFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellAccountManagementFilter.ForeColor = System.Drawing.Color.White;
            this.labellAccountManagementFilter.Location = new System.Drawing.Point(196, 367);
            this.labellAccountManagementFilter.Name = "labellAccountManagementFilter";
            this.labellAccountManagementFilter.Size = new System.Drawing.Size(87, 24);
            this.labellAccountManagementFilter.TabIndex = 120;
            this.labellAccountManagementFilter.Text = "Модель";
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.DisplayMember = "1";
            this.comboBoxDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(289, 218);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(395, 32);
            this.comboBoxDepartment.TabIndex = 119;
            this.comboBoxDepartment.SelectedIndexChanged += new System.EventHandler(this.comboBoxDepartment_SelectedIndexChanged);
            this.comboBoxDepartment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxDepartment_KeyPress);
            // 
            // comboBoxMOL
            // 
            this.comboBoxMOL.DisplayMember = "1";
            this.comboBoxMOL.Enabled = false;
            this.comboBoxMOL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.comboBoxMOL.FormattingEnabled = true;
            this.comboBoxMOL.Location = new System.Drawing.Point(289, 265);
            this.comboBoxMOL.Name = "comboBoxMOL";
            this.comboBoxMOL.Size = new System.Drawing.Size(395, 32);
            this.comboBoxMOL.TabIndex = 118;
            this.comboBoxMOL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxMOL_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(224, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 24);
            this.label7.TabIndex = 117;
            this.label7.Text = "МОЛ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(224, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 24);
            this.label6.TabIndex = 115;
            this.label6.Text = "Дата";
            // 
            // comboBoxLocation
            // 
            this.comboBoxLocation.DisplayMember = "1";
            this.comboBoxLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.comboBoxLocation.FormattingEnabled = true;
            this.comboBoxLocation.Location = new System.Drawing.Point(289, 124);
            this.comboBoxLocation.Name = "comboBoxLocation";
            this.comboBoxLocation.Size = new System.Drawing.Size(395, 32);
            this.comboBoxLocation.TabIndex = 114;
            this.comboBoxLocation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxLocation_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(196, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 24);
            this.label5.TabIndex = 113;
            this.label5.Text = "Локация";
            // 
            // textBoxInventNumber
            // 
            this.textBoxInventNumber.Enabled = false;
            this.textBoxInventNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.textBoxInventNumber.Location = new System.Drawing.Point(289, 75);
            this.textBoxInventNumber.Name = "textBoxInventNumber";
            this.textBoxInventNumber.Size = new System.Drawing.Size(395, 32);
            this.textBoxInventNumber.TabIndex = 112;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(68, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 24);
            this.label4.TabIndex = 111;
            this.label4.Text = "Инвентарный номер";
            // 
            // buttonMainChange
            // 
            this.buttonMainChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonMainChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMainChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonMainChange.ForeColor = System.Drawing.Color.White;
            this.buttonMainChange.Location = new System.Drawing.Point(246, 554);
            this.buttonMainChange.Name = "buttonMainChange";
            this.buttonMainChange.Size = new System.Drawing.Size(132, 36);
            this.buttonMainChange.TabIndex = 110;
            this.buttonMainChange.Text = "Изменить";
            this.buttonMainChange.UseVisualStyleBackColor = false;
            this.buttonMainChange.Click += new System.EventHandler(this.buttonMainChange_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(207, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 24);
            this.label3.TabIndex = 109;
            this.label3.Text = "Отдел";
            // 
            // buttonCencel
            // 
            this.buttonCencel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonCencel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCencel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonCencel.ForeColor = System.Drawing.Color.White;
            this.buttonCencel.Location = new System.Drawing.Point(416, 554);
            this.buttonCencel.Name = "buttonCencel";
            this.buttonCencel.Size = new System.Drawing.Size(132, 36);
            this.buttonCencel.TabIndex = 108;
            this.buttonCencel.Text = "Отмена";
            this.buttonCencel.UseVisualStyleBackColor = false;
            // 
            // labelAccountItamNumber
            // 
            this.labelAccountItamNumber.AutoSize = true;
            this.labelAccountItamNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.labelAccountItamNumber.ForeColor = System.Drawing.Color.White;
            this.labelAccountItamNumber.Location = new System.Drawing.Point(177, 9);
            this.labelAccountItamNumber.Name = "labelAccountItamNumber";
            this.labelAccountItamNumber.Size = new System.Drawing.Size(441, 39);
            this.labelAccountItamNumber.TabIndex = 10;
            this.labelAccountItamNumber.Text = "Изменение обрудования";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker1.Location = new System.Drawing.Point(289, 174);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(395, 29);
            this.dateTimePicker1.TabIndex = 116;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.labelAccountItamNumber);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 69);
            this.panel1.TabIndex = 107;
            // 
            // FormMainChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(774, 607);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxStuff);
            this.Controls.Add(this.comboBoxItamNumber);
            this.Controls.Add(this.comboBoxModel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxEquipmentType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxEquipmentManufacturer);
            this.Controls.Add(this.labellAccountManagementFilter);
            this.Controls.Add(this.comboBoxDepartment);
            this.Controls.Add(this.comboBoxMOL);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxLocation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxInventNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonMainChange);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCencel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panel1);
            this.Name = "FormMainChange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMainChange";
            this.Load += new System.EventHandler(this.FormMainChange_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxStuff;
        private System.Windows.Forms.ComboBox comboBoxItamNumber;
        private System.Windows.Forms.ComboBox comboBoxModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxEquipmentType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxEquipmentManufacturer;
        private System.Windows.Forms.Label labellAccountManagementFilter;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.ComboBox comboBoxMOL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxLocation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxInventNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonMainChange;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCencel;
        private System.Windows.Forms.Label labelAccountItamNumber;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
    }
}