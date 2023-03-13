namespace inventory_db
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.мОЛToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типыОборудованяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользовательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.администрированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAccountManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.производительОборудованияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оборудованиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.пользовательToolStripMenuItem,
            this.администрированиеToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemLocation,
            this.мОЛToolStripMenuItem,
            this.типыОборудованяToolStripMenuItem,
            this.производительОборудованияToolStripMenuItem,
            this.оборудованиеToolStripMenuItem});
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // ToolStripMenuItemLocation
            // 
            this.ToolStripMenuItemLocation.Name = "ToolStripMenuItemLocation";
            this.ToolStripMenuItemLocation.Size = new System.Drawing.Size(241, 22);
            this.ToolStripMenuItemLocation.Text = "Место расположение";
            this.ToolStripMenuItemLocation.Click += new System.EventHandler(this.ToolStripMenuItemLocation_Click);
            // 
            // мОЛToolStripMenuItem
            // 
            this.мОЛToolStripMenuItem.Name = "мОЛToolStripMenuItem";
            this.мОЛToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.мОЛToolStripMenuItem.Text = "МОЛ";
            this.мОЛToolStripMenuItem.Click += new System.EventHandler(this.мОЛToolStripMenuItem_Click);
            // 
            // типыОборудованяToolStripMenuItem
            // 
            this.типыОборудованяToolStripMenuItem.Name = "типыОборудованяToolStripMenuItem";
            this.типыОборудованяToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.типыОборудованяToolStripMenuItem.Text = "Типы оборудованя";
            this.типыОборудованяToolStripMenuItem.Click += new System.EventHandler(this.типыОборудованяToolStripMenuItem_Click);
            // 
            // пользовательToolStripMenuItem
            // 
            this.пользовательToolStripMenuItem.Name = "пользовательToolStripMenuItem";
            this.пользовательToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.пользовательToolStripMenuItem.Text = "Пользователь";
            // 
            // администрированиеToolStripMenuItem
            // 
            this.администрированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemAccountManagement});
            this.администрированиеToolStripMenuItem.Name = "администрированиеToolStripMenuItem";
            this.администрированиеToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.администрированиеToolStripMenuItem.Text = "Администрирование";
            // 
            // MenuItemAccountManagement
            // 
            this.MenuItemAccountManagement.Name = "MenuItemAccountManagement";
            this.MenuItemAccountManagement.Size = new System.Drawing.Size(255, 22);
            this.MenuItemAccountManagement.Text = "Управление учетными записями";
            this.MenuItemAccountManagement.Click += new System.EventHandler(this.MenuItemAccountManagement_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // производительОборудованияToolStripMenuItem
            // 
            this.производительОборудованияToolStripMenuItem.Name = "производительОборудованияToolStripMenuItem";
            this.производительОборудованияToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.производительОборудованияToolStripMenuItem.Text = "Производитель оборудования";
            this.производительОборудованияToolStripMenuItem.Click += new System.EventHandler(this.производительОборудованияToolStripMenuItem_Click);
            // 
            // оборудованиеToolStripMenuItem
            // 
            this.оборудованиеToolStripMenuItem.Name = "оборудованиеToolStripMenuItem";
            this.оборудованиеToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.оборудованиеToolStripMenuItem.Text = "Оборудование";
            this.оборудованиеToolStripMenuItem.Click += new System.EventHandler(this.оборудованиеToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользовательToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem администрированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAccountManagement;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemLocation;
        private System.Windows.Forms.ToolStripMenuItem мОЛToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типыОборудованяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem производительОборудованияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оборудованиеToolStripMenuItem;
    }
}

