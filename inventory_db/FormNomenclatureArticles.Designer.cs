namespace inventory_db
{
    partial class FormNomenclatureArticles
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
            this.listViewNomenclatureArticles = new System.Windows.Forms.ListView();
            this.columnNomenclatureArticles = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAddNewNomenclatureArticles = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelAccountAddNewNomenclatureArticles = new System.Windows.Forms.Label();
            this.buttonEmptyFilter = new System.Windows.Forms.Button();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.textBoxAddNewNomenclatureArticles = new System.Windows.Forms.TextBox();
            this.buttonCencel = new System.Windows.Forms.Button();
            this.buttonChangeNomenclatureArticles = new System.Windows.Forms.Button();
            this.textBoxChangeNomenclatureArticles = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonDeleteNomenclatureArticles = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewNomenclatureArticles
            // 
            this.listViewNomenclatureArticles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listViewNomenclatureArticles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNomenclatureArticles});
            this.listViewNomenclatureArticles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listViewNomenclatureArticles.FullRowSelect = true;
            this.listViewNomenclatureArticles.GridLines = true;
            this.listViewNomenclatureArticles.HideSelection = false;
            this.listViewNomenclatureArticles.Location = new System.Drawing.Point(12, 81);
            this.listViewNomenclatureArticles.Name = "listViewNomenclatureArticles";
            this.listViewNomenclatureArticles.Size = new System.Drawing.Size(404, 363);
            this.listViewNomenclatureArticles.TabIndex = 28;
            this.listViewNomenclatureArticles.UseCompatibleStateImageBehavior = false;
            this.listViewNomenclatureArticles.View = System.Windows.Forms.View.Details;
            this.listViewNomenclatureArticles.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listViewNomenclatureArticles_MouseDown);
            this.listViewNomenclatureArticles.MouseLeave += new System.EventHandler(this.listViewNomenclatureArticles_MouseLeave);
            // 
            // columnNomenclatureArticles
            // 
            this.columnNomenclatureArticles.Text = "Номенклатурные артикули";
            // 
            // buttonAddNewNomenclatureArticles
            // 
            this.buttonAddNewNomenclatureArticles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddNewNomenclatureArticles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonAddNewNomenclatureArticles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddNewNomenclatureArticles.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonAddNewNomenclatureArticles.ForeColor = System.Drawing.Color.White;
            this.buttonAddNewNomenclatureArticles.Location = new System.Drawing.Point(554, 227);
            this.buttonAddNewNomenclatureArticles.Name = "buttonAddNewNomenclatureArticles";
            this.buttonAddNewNomenclatureArticles.Size = new System.Drawing.Size(132, 36);
            this.buttonAddNewNomenclatureArticles.TabIndex = 27;
            this.buttonAddNewNomenclatureArticles.Text = "Добавить";
            this.buttonAddNewNomenclatureArticles.UseVisualStyleBackColor = false;
            this.buttonAddNewNomenclatureArticles.Click += new System.EventHandler(this.buttonAddNewNomenclatureArticles_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.labelAccountAddNewNomenclatureArticles);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 60);
            this.panel1.TabIndex = 32;
            // 
            // labelAccountAddNewNomenclatureArticles
            // 
            this.labelAccountAddNewNomenclatureArticles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAccountAddNewNomenclatureArticles.AutoSize = true;
            this.labelAccountAddNewNomenclatureArticles.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.labelAccountAddNewNomenclatureArticles.ForeColor = System.Drawing.Color.White;
            this.labelAccountAddNewNomenclatureArticles.Location = new System.Drawing.Point(168, 9);
            this.labelAccountAddNewNomenclatureArticles.Name = "labelAccountAddNewNomenclatureArticles";
            this.labelAccountAddNewNomenclatureArticles.Size = new System.Drawing.Size(479, 39);
            this.labelAccountAddNewNomenclatureArticles.TabIndex = 10;
            this.labelAccountAddNewNomenclatureArticles.Text = "Номенклатурные артикули";
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
            // textBoxAddNewNomenclatureArticles
            // 
            this.textBoxAddNewNomenclatureArticles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAddNewNomenclatureArticles.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.textBoxAddNewNomenclatureArticles.Location = new System.Drawing.Point(446, 189);
            this.textBoxAddNewNomenclatureArticles.Name = "textBoxAddNewNomenclatureArticles";
            this.textBoxAddNewNomenclatureArticles.Size = new System.Drawing.Size(342, 32);
            this.textBoxAddNewNomenclatureArticles.TabIndex = 29;
            this.textBoxAddNewNomenclatureArticles.Enter += new System.EventHandler(this.textBoxAddNewNomenclatureArticles_Enter);
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
            // buttonChangeNomenclatureArticles
            // 
            this.buttonChangeNomenclatureArticles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonChangeNomenclatureArticles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonChangeNomenclatureArticles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeNomenclatureArticles.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonChangeNomenclatureArticles.ForeColor = System.Drawing.Color.White;
            this.buttonChangeNomenclatureArticles.Location = new System.Drawing.Point(462, 324);
            this.buttonChangeNomenclatureArticles.Name = "buttonChangeNomenclatureArticles";
            this.buttonChangeNomenclatureArticles.Size = new System.Drawing.Size(132, 36);
            this.buttonChangeNomenclatureArticles.TabIndex = 36;
            this.buttonChangeNomenclatureArticles.Text = "Изменить";
            this.buttonChangeNomenclatureArticles.UseVisualStyleBackColor = false;
            this.buttonChangeNomenclatureArticles.Click += new System.EventHandler(this.buttonChangeNomenclatureArticles_Click);
            // 
            // textBoxChangeNomenclatureArticles
            // 
            this.textBoxChangeNomenclatureArticles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxChangeNomenclatureArticles.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.textBoxChangeNomenclatureArticles.Location = new System.Drawing.Point(446, 286);
            this.textBoxChangeNomenclatureArticles.Name = "textBoxChangeNomenclatureArticles";
            this.textBoxChangeNomenclatureArticles.Size = new System.Drawing.Size(342, 32);
            this.textBoxChangeNomenclatureArticles.TabIndex = 35;
            this.textBoxChangeNomenclatureArticles.Visible = false;
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
            // buttonDeleteNomenclatureArticles
            // 
            this.buttonDeleteNomenclatureArticles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDeleteNomenclatureArticles.BackColor = System.Drawing.Color.Red;
            this.buttonDeleteNomenclatureArticles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteNomenclatureArticles.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonDeleteNomenclatureArticles.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteNomenclatureArticles.Location = new System.Drawing.Point(462, 386);
            this.buttonDeleteNomenclatureArticles.Name = "buttonDeleteNomenclatureArticles";
            this.buttonDeleteNomenclatureArticles.Size = new System.Drawing.Size(132, 36);
            this.buttonDeleteNomenclatureArticles.TabIndex = 33;
            this.buttonDeleteNomenclatureArticles.Text = "Удалить";
            this.buttonDeleteNomenclatureArticles.UseVisualStyleBackColor = false;
            this.buttonDeleteNomenclatureArticles.Click += new System.EventHandler(this.buttonDeleteNomenclatureArticles_Click);
            // 
            // FormNomenclatureArticles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewNomenclatureArticles);
            this.Controls.Add(this.buttonAddNewNomenclatureArticles);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonEmptyFilter);
            this.Controls.Add(this.textBoxFilter);
            this.Controls.Add(this.textBoxAddNewNomenclatureArticles);
            this.Controls.Add(this.buttonCencel);
            this.Controls.Add(this.buttonChangeNomenclatureArticles);
            this.Controls.Add(this.textBoxChangeNomenclatureArticles);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonDeleteNomenclatureArticles);
            this.Name = "FormNomenclatureArticles";
            this.Text = "FormNomenclatureArticles";
            this.Activated += new System.EventHandler(this.FormNomenclatureArticles_Activated);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewNomenclatureArticles;
        public System.Windows.Forms.ColumnHeader columnNomenclatureArticles;
        private System.Windows.Forms.Button buttonAddNewNomenclatureArticles;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelAccountAddNewNomenclatureArticles;
        private System.Windows.Forms.Button buttonEmptyFilter;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.TextBox textBoxAddNewNomenclatureArticles;
        private System.Windows.Forms.Button buttonCencel;
        private System.Windows.Forms.Button buttonChangeNomenclatureArticles;
        private System.Windows.Forms.TextBox textBoxChangeNomenclatureArticles;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonDeleteNomenclatureArticles;
    }
}