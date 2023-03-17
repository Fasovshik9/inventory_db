namespace inventory_db
{
    partial class FormItamNumberChange
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
            this.comboBoxModelChange = new System.Windows.Forms.ComboBox();
            this.textBoxItamNumberChange = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxEquipmentTypeChange = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxEquipmentManufacturerChange = new System.Windows.Forms.ComboBox();
            this.buttonCencel = new System.Windows.Forms.Button();
            this.labellAccountManagementFilter = new System.Windows.Forms.Label();
            this.buttonItamNumberChange = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.labelAccountItamNumber);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 60);
            this.panel1.TabIndex = 65;
            // 
            // labelAccountItamNumber
            // 
            this.labelAccountItamNumber.AutoSize = true;
            this.labelAccountItamNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.labelAccountItamNumber.ForeColor = System.Drawing.Color.White;
            this.labelAccountItamNumber.Location = new System.Drawing.Point(64, 9);
            this.labelAccountItamNumber.Name = "labelAccountItamNumber";
            this.labelAccountItamNumber.Size = new System.Drawing.Size(650, 39);
            this.labelAccountItamNumber.TabIndex = 10;
            this.labelAccountItamNumber.Text = "Изменить номенклатурный артикуль";
            // 
            // comboBoxModelChange
            // 
            this.comboBoxModelChange.DisplayMember = "1";
            this.comboBoxModelChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.comboBoxModelChange.FormattingEnabled = true;
            this.comboBoxModelChange.Location = new System.Drawing.Point(294, 182);
            this.comboBoxModelChange.Name = "comboBoxModelChange";
            this.comboBoxModelChange.Size = new System.Drawing.Size(395, 32);
            this.comboBoxModelChange.TabIndex = 74;
            this.comboBoxModelChange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxModelChange_KeyPress);
            // 
            // textBoxItamNumberChange
            // 
            this.textBoxItamNumberChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.textBoxItamNumberChange.Location = new System.Drawing.Point(294, 113);
            this.textBoxItamNumberChange.Name = "textBoxItamNumberChange";
            this.textBoxItamNumberChange.Size = new System.Drawing.Size(395, 32);
            this.textBoxItamNumberChange.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 24);
            this.label3.TabIndex = 72;
            this.label3.Text = "Номенклатурный артикуль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(228, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 24);
            this.label2.TabIndex = 71;
            this.label2.Text = "Тип";
            // 
            // comboBoxEquipmentTypeChange
            // 
            this.comboBoxEquipmentTypeChange.DisplayMember = "1";
            this.comboBoxEquipmentTypeChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.comboBoxEquipmentTypeChange.FormattingEnabled = true;
            this.comboBoxEquipmentTypeChange.Location = new System.Drawing.Point(294, 326);
            this.comboBoxEquipmentTypeChange.Name = "comboBoxEquipmentTypeChange";
            this.comboBoxEquipmentTypeChange.Size = new System.Drawing.Size(395, 32);
            this.comboBoxEquipmentTypeChange.TabIndex = 70;
            this.comboBoxEquipmentTypeChange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxEquipmentTypeChange_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(122, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 69;
            this.label1.Text = "Производитель";
            // 
            // comboBoxEquipmentManufacturerChange
            // 
            this.comboBoxEquipmentManufacturerChange.DisplayMember = "1";
            this.comboBoxEquipmentManufacturerChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.comboBoxEquipmentManufacturerChange.FormattingEnabled = true;
            this.comboBoxEquipmentManufacturerChange.Location = new System.Drawing.Point(294, 251);
            this.comboBoxEquipmentManufacturerChange.Name = "comboBoxEquipmentManufacturerChange";
            this.comboBoxEquipmentManufacturerChange.Size = new System.Drawing.Size(395, 32);
            this.comboBoxEquipmentManufacturerChange.TabIndex = 68;
            this.comboBoxEquipmentManufacturerChange.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxEquipmentManufacturerChange_KeyPress);
            // 
            // buttonCencel
            // 
            this.buttonCencel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonCencel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCencel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonCencel.ForeColor = System.Drawing.Color.White;
            this.buttonCencel.Location = new System.Drawing.Point(392, 405);
            this.buttonCencel.Name = "buttonCencel";
            this.buttonCencel.Size = new System.Drawing.Size(132, 36);
            this.buttonCencel.TabIndex = 67;
            this.buttonCencel.Text = "Отмена";
            this.buttonCencel.UseVisualStyleBackColor = false;
            this.buttonCencel.Click += new System.EventHandler(this.buttonCencel_Click);
            // 
            // labellAccountManagementFilter
            // 
            this.labellAccountManagementFilter.AutoSize = true;
            this.labellAccountManagementFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellAccountManagementFilter.ForeColor = System.Drawing.Color.White;
            this.labellAccountManagementFilter.Location = new System.Drawing.Point(201, 185);
            this.labellAccountManagementFilter.Name = "labellAccountManagementFilter";
            this.labellAccountManagementFilter.Size = new System.Drawing.Size(87, 24);
            this.labellAccountManagementFilter.TabIndex = 66;
            this.labellAccountManagementFilter.Text = "Модель";
            // 
            // buttonItamNumberChange
            // 
            this.buttonItamNumberChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonItamNumberChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonItamNumberChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonItamNumberChange.ForeColor = System.Drawing.Color.White;
            this.buttonItamNumberChange.Location = new System.Drawing.Point(232, 405);
            this.buttonItamNumberChange.Name = "buttonItamNumberChange";
            this.buttonItamNumberChange.Size = new System.Drawing.Size(132, 36);
            this.buttonItamNumberChange.TabIndex = 75;
            this.buttonItamNumberChange.Text = "Изменить";
            this.buttonItamNumberChange.UseVisualStyleBackColor = false;
            this.buttonItamNumberChange.Click += new System.EventHandler(this.buttonItamNumberChange_Click);
            // 
            // FormItamNumberChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonItamNumberChange);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBoxModelChange);
            this.Controls.Add(this.textBoxItamNumberChange);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxEquipmentTypeChange);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxEquipmentManufacturerChange);
            this.Controls.Add(this.buttonCencel);
            this.Controls.Add(this.labellAccountManagementFilter);
            this.Name = "FormItamNumberChange";
            this.Text = "FormItamNumberChange";
            this.Load += new System.EventHandler(this.FormItamNumberChange_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelAccountItamNumber;
        private System.Windows.Forms.ComboBox comboBoxModelChange;
        private System.Windows.Forms.TextBox textBoxItamNumberChange;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxEquipmentTypeChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxEquipmentManufacturerChange;
        private System.Windows.Forms.Button buttonCencel;
        private System.Windows.Forms.Label labellAccountManagementFilter;
        private System.Windows.Forms.Button buttonItamNumberChange;
    }
}