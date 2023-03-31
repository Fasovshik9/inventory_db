namespace inventory_db
{
    partial class FormEquipmentModelAddNew
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
            this.buttonAddNewEquipmentModel = new System.Windows.Forms.Button();
            this.buttonCencel = new System.Windows.Forms.Button();
            this.textBoxEquipmentModelAddNew = new System.Windows.Forms.TextBox();
            this.labellAccountManagementFilter = new System.Windows.Forms.Label();
            this.comboBoxEquipmentManufacturer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxEquipmentType = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.labelAccountEquipmentModel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 60);
            this.panel1.TabIndex = 41;
            // 
            // labelAccountEquipmentModel
            // 
            this.labelAccountEquipmentModel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAccountEquipmentModel.AutoSize = true;
            this.labelAccountEquipmentModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.labelAccountEquipmentModel.ForeColor = System.Drawing.Color.White;
            this.labelAccountEquipmentModel.Location = new System.Drawing.Point(174, 9);
            this.labelAccountEquipmentModel.Name = "labelAccountEquipmentModel";
            this.labelAccountEquipmentModel.Size = new System.Drawing.Size(260, 39);
            this.labelAccountEquipmentModel.TabIndex = 10;
            this.labelAccountEquipmentModel.Text = "Новая модель";
            // 
            // buttonAddNewEquipmentModel
            // 
            this.buttonAddNewEquipmentModel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddNewEquipmentModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonAddNewEquipmentModel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddNewEquipmentModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonAddNewEquipmentModel.ForeColor = System.Drawing.Color.White;
            this.buttonAddNewEquipmentModel.Location = new System.Drawing.Point(166, 327);
            this.buttonAddNewEquipmentModel.Name = "buttonAddNewEquipmentModel";
            this.buttonAddNewEquipmentModel.Size = new System.Drawing.Size(132, 36);
            this.buttonAddNewEquipmentModel.TabIndex = 38;
            this.buttonAddNewEquipmentModel.Text = "Добавить";
            this.buttonAddNewEquipmentModel.UseVisualStyleBackColor = false;
            this.buttonAddNewEquipmentModel.Click += new System.EventHandler(this.buttonAddNewEquipmentModel_Click);
            // 
            // buttonCencel
            // 
            this.buttonCencel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCencel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonCencel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCencel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonCencel.ForeColor = System.Drawing.Color.White;
            this.buttonCencel.Location = new System.Drawing.Point(348, 327);
            this.buttonCencel.Name = "buttonCencel";
            this.buttonCencel.Size = new System.Drawing.Size(132, 36);
            this.buttonCencel.TabIndex = 45;
            this.buttonCencel.Text = "Отмена";
            this.buttonCencel.UseVisualStyleBackColor = false;
            this.buttonCencel.Click += new System.EventHandler(this.buttonCencel_Click);
            // 
            // textBoxEquipmentModelAddNew
            // 
            this.textBoxEquipmentModelAddNew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxEquipmentModelAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.textBoxEquipmentModelAddNew.Location = new System.Drawing.Point(181, 178);
            this.textBoxEquipmentModelAddNew.Name = "textBoxEquipmentModelAddNew";
            this.textBoxEquipmentModelAddNew.Size = new System.Drawing.Size(395, 32);
            this.textBoxEquipmentModelAddNew.TabIndex = 44;
            this.textBoxEquipmentModelAddNew.Enter += new System.EventHandler(this.textBoxEquipmentModelAddNew_Enter);
            this.textBoxEquipmentModelAddNew.Leave += new System.EventHandler(this.textBoxEquipmentModelAddNew_Leave);
            // 
            // labellAccountManagementFilter
            // 
            this.labellAccountManagementFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labellAccountManagementFilter.AutoSize = true;
            this.labellAccountManagementFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellAccountManagementFilter.ForeColor = System.Drawing.Color.White;
            this.labellAccountManagementFilter.Location = new System.Drawing.Point(88, 186);
            this.labellAccountManagementFilter.Name = "labellAccountManagementFilter";
            this.labellAccountManagementFilter.Size = new System.Drawing.Size(87, 24);
            this.labellAccountManagementFilter.TabIndex = 42;
            this.labellAccountManagementFilter.Text = "Модель";
            // 
            // comboBoxEquipmentManufacturer
            // 
            this.comboBoxEquipmentManufacturer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxEquipmentManufacturer.DisplayMember = "1";
            this.comboBoxEquipmentManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.comboBoxEquipmentManufacturer.FormattingEnabled = true;
            this.comboBoxEquipmentManufacturer.Location = new System.Drawing.Point(181, 96);
            this.comboBoxEquipmentManufacturer.Name = "comboBoxEquipmentManufacturer";
            this.comboBoxEquipmentManufacturer.Size = new System.Drawing.Size(395, 32);
            this.comboBoxEquipmentManufacturer.TabIndex = 46;
            this.comboBoxEquipmentManufacturer.TextChanged += new System.EventHandler(this.comboBoxEquipmentManufacturer_TextChanged);
            this.comboBoxEquipmentManufacturer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxEquipmentManufacturer_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 47;
            this.label1.Text = "Производитель";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(128, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 24);
            this.label2.TabIndex = 49;
            this.label2.Text = "Тип";
            // 
            // comboBoxEquipmentType
            // 
            this.comboBoxEquipmentType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxEquipmentType.DisplayMember = "1";
            this.comboBoxEquipmentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.comboBoxEquipmentType.FormattingEnabled = true;
            this.comboBoxEquipmentType.Location = new System.Drawing.Point(181, 261);
            this.comboBoxEquipmentType.Name = "comboBoxEquipmentType";
            this.comboBoxEquipmentType.Size = new System.Drawing.Size(395, 32);
            this.comboBoxEquipmentType.TabIndex = 48;
            this.comboBoxEquipmentType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxEquipmentType_KeyPress);
            // 
            // FormEquipmentModelAddNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(619, 395);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxEquipmentType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxEquipmentManufacturer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonAddNewEquipmentModel);
            this.Controls.Add(this.buttonCencel);
            this.Controls.Add(this.textBoxEquipmentModelAddNew);
            this.Controls.Add(this.labellAccountManagementFilter);
            this.MinimumSize = new System.Drawing.Size(635, 434);
            this.Name = "FormEquipmentModelAddNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление новой модели";
            this.Activated += new System.EventHandler(this.FormEquipmentModelAddNew_Activated);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelAccountEquipmentModel;
        private System.Windows.Forms.Button buttonAddNewEquipmentModel;
        private System.Windows.Forms.Button buttonCencel;
        private System.Windows.Forms.TextBox textBoxEquipmentModelAddNew;
        private System.Windows.Forms.Label labellAccountManagementFilter;
        private System.Windows.Forms.ComboBox comboBoxEquipmentManufacturer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxEquipmentType;
    }
}