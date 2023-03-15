namespace inventory_db
{
    partial class FormEquipmentModelChange
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
            this.labelAccountEquipmentModel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxEquipmentType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxEquipmentManufacturer = new System.Windows.Forms.ComboBox();
            this.buttonAEquipmentModelChange = new System.Windows.Forms.Button();
            this.buttonCencel = new System.Windows.Forms.Button();
            this.textBoxEquipmentModelChange = new System.Windows.Forms.TextBox();
            this.labellAccountManagementFilter = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.labelAccountEquipmentModel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 60);
            this.panel1.TabIndex = 51;
            // 
            // labelAccountEquipmentModel
            // 
            this.labelAccountEquipmentModel.AutoSize = true;
            this.labelAccountEquipmentModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.labelAccountEquipmentModel.ForeColor = System.Drawing.Color.White;
            this.labelAccountEquipmentModel.Location = new System.Drawing.Point(186, 9);
            this.labelAccountEquipmentModel.Name = "labelAccountEquipmentModel";
            this.labelAccountEquipmentModel.Size = new System.Drawing.Size(322, 39);
            this.labelAccountEquipmentModel.TabIndex = 10;
            this.labelAccountEquipmentModel.Text = "Изменить модель";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(128, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 24);
            this.label2.TabIndex = 58;
            this.label2.Text = "Тип";
            // 
            // comboBoxEquipmentType
            // 
            this.comboBoxEquipmentType.DisplayMember = "1";
            this.comboBoxEquipmentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.comboBoxEquipmentType.FormattingEnabled = true;
            this.comboBoxEquipmentType.Location = new System.Drawing.Point(181, 276);
            this.comboBoxEquipmentType.Name = "comboBoxEquipmentType";
            this.comboBoxEquipmentType.Size = new System.Drawing.Size(395, 32);
            this.comboBoxEquipmentType.TabIndex = 57;
            this.comboBoxEquipmentType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxEquipmentType_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 56;
            this.label1.Text = "Производитель";
            // 
            // comboBoxEquipmentManufacturer
            // 
            this.comboBoxEquipmentManufacturer.DisplayMember = "1";
            this.comboBoxEquipmentManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.comboBoxEquipmentManufacturer.FormattingEnabled = true;
            this.comboBoxEquipmentManufacturer.Location = new System.Drawing.Point(181, 200);
            this.comboBoxEquipmentManufacturer.Name = "comboBoxEquipmentManufacturer";
            this.comboBoxEquipmentManufacturer.Size = new System.Drawing.Size(395, 32);
            this.comboBoxEquipmentManufacturer.TabIndex = 55;
            this.comboBoxEquipmentManufacturer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxEquipmentManufacturer_KeyPress);
            // 
            // buttonAEquipmentModelChange
            // 
            this.buttonAEquipmentModelChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonAEquipmentModelChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAEquipmentModelChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonAEquipmentModelChange.ForeColor = System.Drawing.Color.White;
            this.buttonAEquipmentModelChange.Location = new System.Drawing.Point(159, 359);
            this.buttonAEquipmentModelChange.Name = "buttonAEquipmentModelChange";
            this.buttonAEquipmentModelChange.Size = new System.Drawing.Size(132, 36);
            this.buttonAEquipmentModelChange.TabIndex = 50;
            this.buttonAEquipmentModelChange.Text = "Изменить";
            this.buttonAEquipmentModelChange.UseVisualStyleBackColor = false;
            this.buttonAEquipmentModelChange.Click += new System.EventHandler(this.buttonAEquipmentModelChange_Click);
            // 
            // buttonCencel
            // 
            this.buttonCencel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonCencel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCencel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonCencel.ForeColor = System.Drawing.Color.White;
            this.buttonCencel.Location = new System.Drawing.Point(341, 359);
            this.buttonCencel.Name = "buttonCencel";
            this.buttonCencel.Size = new System.Drawing.Size(132, 36);
            this.buttonCencel.TabIndex = 54;
            this.buttonCencel.Text = "Отмена";
            this.buttonCencel.UseVisualStyleBackColor = false;
            this.buttonCencel.Click += new System.EventHandler(this.buttonCencel_Click);
            // 
            // textBoxEquipmentModelChange
            // 
            this.textBoxEquipmentModelChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.textBoxEquipmentModelChange.Location = new System.Drawing.Point(181, 119);
            this.textBoxEquipmentModelChange.Name = "textBoxEquipmentModelChange";
            this.textBoxEquipmentModelChange.Size = new System.Drawing.Size(395, 32);
            this.textBoxEquipmentModelChange.TabIndex = 53;
            // 
            // labellAccountManagementFilter
            // 
            this.labellAccountManagementFilter.AutoSize = true;
            this.labellAccountManagementFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellAccountManagementFilter.ForeColor = System.Drawing.Color.White;
            this.labellAccountManagementFilter.Location = new System.Drawing.Point(88, 127);
            this.labellAccountManagementFilter.Name = "labellAccountManagementFilter";
            this.labellAccountManagementFilter.Size = new System.Drawing.Size(87, 24);
            this.labellAccountManagementFilter.TabIndex = 52;
            this.labellAccountManagementFilter.Text = "Модель";
            // 
            // FormEquipmentModelChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(678, 439);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxEquipmentType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxEquipmentManufacturer);
            this.Controls.Add(this.buttonAEquipmentModelChange);
            this.Controls.Add(this.buttonCencel);
            this.Controls.Add(this.textBoxEquipmentModelChange);
            this.Controls.Add(this.labellAccountManagementFilter);
            this.Name = "FormEquipmentModelChange";
            this.Text = "FormEquipmentModelChange";
            this.Activated += new System.EventHandler(this.FormEquipmentModelChange_Activated);
            this.Load += new System.EventHandler(this.FormEquipmentModelChange_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelAccountEquipmentModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAEquipmentModelChange;
        private System.Windows.Forms.Button buttonCencel;
        private System.Windows.Forms.Label labellAccountManagementFilter;
        public System.Windows.Forms.ComboBox comboBoxEquipmentType;
        public System.Windows.Forms.ComboBox comboBoxEquipmentManufacturer;
        public System.Windows.Forms.TextBox textBoxEquipmentModelChange;
    }
}