namespace inventory_db
{
    partial class FormAddNewMOL
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
            this.textBoxDepartmentMOL = new System.Windows.Forms.TextBox();
            this.textBoxlNewMOL = new System.Windows.Forms.TextBox();
            this.buttonAddMOL = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelAddNewMOL = new System.Windows.Forms.Label();
            this.buttonExitFromForm = new System.Windows.Forms.Button();
            this.labelFullNameMOL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxDepartmentMOL
            // 
            this.textBoxDepartmentMOL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBoxDepartmentMOL.Location = new System.Drawing.Point(182, 207);
            this.textBoxDepartmentMOL.Name = "textBoxDepartmentMOL";
            this.textBoxDepartmentMOL.Size = new System.Drawing.Size(252, 29);
            this.textBoxDepartmentMOL.TabIndex = 15;
            this.textBoxDepartmentMOL.Enter += new System.EventHandler(this.textBoxDepartmentMOL_Enter);
            this.textBoxDepartmentMOL.Leave += new System.EventHandler(this.textBoxDepartmentMOL_Leave);
            // 
            // textBoxlNewMOL
            // 
            this.textBoxlNewMOL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBoxlNewMOL.Location = new System.Drawing.Point(182, 148);
            this.textBoxlNewMOL.Name = "textBoxlNewMOL";
            this.textBoxlNewMOL.Size = new System.Drawing.Size(252, 29);
            this.textBoxlNewMOL.TabIndex = 14;
            this.textBoxlNewMOL.Enter += new System.EventHandler(this.textBoxlNewMOL_Enter);
            this.textBoxlNewMOL.Leave += new System.EventHandler(this.textBoxlNewMOL_Leave);
            // 
            // buttonAddMOL
            // 
            this.buttonAddMOL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonAddMOL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddMOL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonAddMOL.ForeColor = System.Drawing.Color.White;
            this.buttonAddMOL.Location = new System.Drawing.Point(203, 265);
            this.buttonAddMOL.Name = "buttonAddMOL";
            this.buttonAddMOL.Size = new System.Drawing.Size(135, 34);
            this.buttonAddMOL.TabIndex = 26;
            this.buttonAddMOL.Text = "Добавить";
            this.buttonAddMOL.UseVisualStyleBackColor = false;
            this.buttonAddMOL.Click += new System.EventHandler(this.buttonAddMOL_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.labelAddNewMOL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 60);
            this.panel1.TabIndex = 28;
            // 
            // labelAddNewMOL
            // 
            this.labelAddNewMOL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAddNewMOL.AutoSize = true;
            this.labelAddNewMOL.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.labelAddNewMOL.ForeColor = System.Drawing.Color.White;
            this.labelAddNewMOL.Location = new System.Drawing.Point(23, 9);
            this.labelAddNewMOL.Name = "labelAddNewMOL";
            this.labelAddNewMOL.Size = new System.Drawing.Size(474, 39);
            this.labelAddNewMOL.TabIndex = 9;
            this.labelAddNewMOL.Text = "Добавление нового МОЛ\'а";
            // 
            // buttonExitFromForm
            // 
            this.buttonExitFromForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonExitFromForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExitFromForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonExitFromForm.ForeColor = System.Drawing.Color.White;
            this.buttonExitFromForm.Location = new System.Drawing.Point(203, 323);
            this.buttonExitFromForm.Name = "buttonExitFromForm";
            this.buttonExitFromForm.Size = new System.Drawing.Size(135, 33);
            this.buttonExitFromForm.TabIndex = 27;
            this.buttonExitFromForm.Text = "Отмена";
            this.buttonExitFromForm.UseVisualStyleBackColor = false;
            // 
            // labelFullNameMOL
            // 
            this.labelFullNameMOL.AutoSize = true;
            this.labelFullNameMOL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelFullNameMOL.ForeColor = System.Drawing.Color.White;
            this.labelFullNameMOL.Location = new System.Drawing.Point(51, 148);
            this.labelFullNameMOL.Name = "labelFullNameMOL";
            this.labelFullNameMOL.Size = new System.Drawing.Size(125, 24);
            this.labelFullNameMOL.TabIndex = 19;
            this.labelFullNameMOL.Text = "ФИО МОЛ\'а";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Подразделение";
            // 
            // FormAddNewMOL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(495, 368);
            this.Controls.Add(this.textBoxDepartmentMOL);
            this.Controls.Add(this.textBoxlNewMOL);
            this.Controls.Add(this.buttonAddMOL);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonExitFromForm);
            this.Controls.Add(this.labelFullNameMOL);
            this.Controls.Add(this.label2);
            this.Name = "FormAddNewMOL";
            this.Text = "FormAddNewMOL";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDepartmentMOL;
        private System.Windows.Forms.TextBox textBoxlNewMOL;
        private System.Windows.Forms.Button buttonAddMOL;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelAddNewMOL;
        private System.Windows.Forms.Button buttonExitFromForm;
        private System.Windows.Forms.Label labelFullNameMOL;
        private System.Windows.Forms.Label label2;
    }
}