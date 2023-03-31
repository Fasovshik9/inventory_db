namespace inventory_db
{
    partial class FormEquipmentManufacturer
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
            this.listViewEquipmentManufacturer = new System.Windows.Forms.ListView();
            this.columnEquipmentManufacturer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAddNewEquipmentManufacturer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelEquipmentManufacturer = new System.Windows.Forms.Label();
            this.buttonEmptyFilter = new System.Windows.Forms.Button();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.textBoxAddNewEquipmentManufacturer = new System.Windows.Forms.TextBox();
            this.buttonCencel = new System.Windows.Forms.Button();
            this.buttonChangeEquipmentManufacturer = new System.Windows.Forms.Button();
            this.textBoxChangeEquipmentManufacturer = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonDeleteEquipmentManufacturer = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewEquipmentManufacturer
            // 
            this.listViewEquipmentManufacturer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listViewEquipmentManufacturer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnEquipmentManufacturer});
            this.listViewEquipmentManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listViewEquipmentManufacturer.FullRowSelect = true;
            this.listViewEquipmentManufacturer.GridLines = true;
            this.listViewEquipmentManufacturer.HideSelection = false;
            this.listViewEquipmentManufacturer.Location = new System.Drawing.Point(12, 81);
            this.listViewEquipmentManufacturer.Name = "listViewEquipmentManufacturer";
            this.listViewEquipmentManufacturer.Size = new System.Drawing.Size(404, 363);
            this.listViewEquipmentManufacturer.TabIndex = 28;
            this.listViewEquipmentManufacturer.UseCompatibleStateImageBehavior = false;
            this.listViewEquipmentManufacturer.View = System.Windows.Forms.View.Details;
            this.listViewEquipmentManufacturer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listViewEquipmentManufacturer_MouseDown);
            // 
            // columnEquipmentManufacturer
            // 
            this.columnEquipmentManufacturer.Text = "Производитель оборудования";
            // 
            // buttonAddNewEquipmentManufacturer
            // 
            this.buttonAddNewEquipmentManufacturer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddNewEquipmentManufacturer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonAddNewEquipmentManufacturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddNewEquipmentManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonAddNewEquipmentManufacturer.ForeColor = System.Drawing.Color.White;
            this.buttonAddNewEquipmentManufacturer.Location = new System.Drawing.Point(554, 227);
            this.buttonAddNewEquipmentManufacturer.Name = "buttonAddNewEquipmentManufacturer";
            this.buttonAddNewEquipmentManufacturer.Size = new System.Drawing.Size(132, 36);
            this.buttonAddNewEquipmentManufacturer.TabIndex = 27;
            this.buttonAddNewEquipmentManufacturer.Text = "Добавить";
            this.buttonAddNewEquipmentManufacturer.UseVisualStyleBackColor = false;
            this.buttonAddNewEquipmentManufacturer.Click += new System.EventHandler(this.buttonAddNewEquipmentManufacturer_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.labelEquipmentManufacturer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 60);
            this.panel1.TabIndex = 32;
            // 
            // labelEquipmentManufacturer
            // 
            this.labelEquipmentManufacturer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEquipmentManufacturer.AutoSize = true;
            this.labelEquipmentManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.labelEquipmentManufacturer.ForeColor = System.Drawing.Color.White;
            this.labelEquipmentManufacturer.Location = new System.Drawing.Point(118, 9);
            this.labelEquipmentManufacturer.Name = "labelEquipmentManufacturer";
            this.labelEquipmentManufacturer.Size = new System.Drawing.Size(536, 39);
            this.labelEquipmentManufacturer.TabIndex = 10;
            this.labelEquipmentManufacturer.Text = "Производители оборудования";
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
            // textBoxAddNewEquipmentManufacturer
            // 
            this.textBoxAddNewEquipmentManufacturer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAddNewEquipmentManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.textBoxAddNewEquipmentManufacturer.Location = new System.Drawing.Point(446, 189);
            this.textBoxAddNewEquipmentManufacturer.Name = "textBoxAddNewEquipmentManufacturer";
            this.textBoxAddNewEquipmentManufacturer.Size = new System.Drawing.Size(342, 32);
            this.textBoxAddNewEquipmentManufacturer.TabIndex = 29;
            this.textBoxAddNewEquipmentManufacturer.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxAddNewEquipmentManufacturer_DragEnter);
            this.textBoxAddNewEquipmentManufacturer.Enter += new System.EventHandler(this.textBoxAddNewEquipmentManufacturer_Enter);
            this.textBoxAddNewEquipmentManufacturer.Leave += new System.EventHandler(this.textBoxAddNewEquipmentManufacturer_Leave);
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
            // buttonChangeEquipmentManufacturer
            // 
            this.buttonChangeEquipmentManufacturer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonChangeEquipmentManufacturer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonChangeEquipmentManufacturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeEquipmentManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonChangeEquipmentManufacturer.ForeColor = System.Drawing.Color.White;
            this.buttonChangeEquipmentManufacturer.Location = new System.Drawing.Point(462, 324);
            this.buttonChangeEquipmentManufacturer.Name = "buttonChangeEquipmentManufacturer";
            this.buttonChangeEquipmentManufacturer.Size = new System.Drawing.Size(132, 36);
            this.buttonChangeEquipmentManufacturer.TabIndex = 36;
            this.buttonChangeEquipmentManufacturer.Text = "Изменить";
            this.buttonChangeEquipmentManufacturer.UseVisualStyleBackColor = false;
            this.buttonChangeEquipmentManufacturer.Click += new System.EventHandler(this.buttonChangeEquipmentManufacturer_Click);
            // 
            // textBoxChangeEquipmentManufacturer
            // 
            this.textBoxChangeEquipmentManufacturer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxChangeEquipmentManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.textBoxChangeEquipmentManufacturer.Location = new System.Drawing.Point(446, 286);
            this.textBoxChangeEquipmentManufacturer.Name = "textBoxChangeEquipmentManufacturer";
            this.textBoxChangeEquipmentManufacturer.Size = new System.Drawing.Size(342, 32);
            this.textBoxChangeEquipmentManufacturer.TabIndex = 35;
            this.textBoxChangeEquipmentManufacturer.Visible = false;
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
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonDeleteEquipmentManufacturer
            // 
            this.buttonDeleteEquipmentManufacturer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDeleteEquipmentManufacturer.BackColor = System.Drawing.Color.Red;
            this.buttonDeleteEquipmentManufacturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteEquipmentManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonDeleteEquipmentManufacturer.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteEquipmentManufacturer.Location = new System.Drawing.Point(462, 386);
            this.buttonDeleteEquipmentManufacturer.Name = "buttonDeleteEquipmentManufacturer";
            this.buttonDeleteEquipmentManufacturer.Size = new System.Drawing.Size(132, 36);
            this.buttonDeleteEquipmentManufacturer.TabIndex = 33;
            this.buttonDeleteEquipmentManufacturer.Text = "Удалить";
            this.buttonDeleteEquipmentManufacturer.UseVisualStyleBackColor = false;
            this.buttonDeleteEquipmentManufacturer.Click += new System.EventHandler(this.buttonDeleteEquipmentManufacturer_Click);
            // 
            // FormEquipmentManufacturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewEquipmentManufacturer);
            this.Controls.Add(this.buttonAddNewEquipmentManufacturer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonEmptyFilter);
            this.Controls.Add(this.textBoxFilter);
            this.Controls.Add(this.textBoxAddNewEquipmentManufacturer);
            this.Controls.Add(this.buttonCencel);
            this.Controls.Add(this.buttonChangeEquipmentManufacturer);
            this.Controls.Add(this.textBoxChangeEquipmentManufacturer);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonDeleteEquipmentManufacturer);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FormEquipmentManufacturer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Производители оборудования";
            this.Activated += new System.EventHandler(this.FormEquipmentManufacturer_Activated);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewEquipmentManufacturer;
        public System.Windows.Forms.ColumnHeader columnEquipmentManufacturer;
        private System.Windows.Forms.Button buttonAddNewEquipmentManufacturer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelEquipmentManufacturer;
        private System.Windows.Forms.Button buttonEmptyFilter;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.TextBox textBoxAddNewEquipmentManufacturer;
        private System.Windows.Forms.Button buttonCencel;
        private System.Windows.Forms.Button buttonChangeEquipmentManufacturer;
        private System.Windows.Forms.TextBox textBoxChangeEquipmentManufacturer;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonDeleteEquipmentManufacturer;
    }
}