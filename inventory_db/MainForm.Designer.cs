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
            this.производительОборудованияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оборудованиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.модельОборудованияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользовательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьПарольToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.администрированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAccountManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewMain = new System.Windows.Forms.ListView();
            this.columnHeaderInvent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMOLFullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDepatnment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderItamNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderManufacturer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonIMainAddNew = new System.Windows.Forms.Button();
            this.buttonMainChange = new System.Windows.Forms.Button();
            this.buttonDeleteMain = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelFilter = new System.Windows.Forms.Label();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.buttonFilterEmpty = new System.Windows.Forms.Button();
            this.comboBoxFilterAll = new System.Windows.Forms.ComboBox();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFinish = new System.Windows.Forms.DateTimePicker();
            this.labelDateStart = new System.Windows.Forms.Label();
            this.labelDateFinish = new System.Windows.Forms.Label();
            this.textBoxFilterAll = new System.Windows.Forms.TextBox();
            this.labelUserLogin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.menuStrip1.Size = new System.Drawing.Size(1319, 24);
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
            this.оборудованиеToolStripMenuItem,
            this.модельОборудованияToolStripMenuItem});
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
            this.оборудованиеToolStripMenuItem.Text = "Модель";
            this.оборудованиеToolStripMenuItem.Click += new System.EventHandler(this.оборудованиеToolStripMenuItem_Click);
            // 
            // модельОборудованияToolStripMenuItem
            // 
            this.модельОборудованияToolStripMenuItem.Name = "модельОборудованияToolStripMenuItem";
            this.модельОборудованияToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.модельОборудованияToolStripMenuItem.Text = "Номенклатурный артикуль";
            this.модельОборудованияToolStripMenuItem.Click += new System.EventHandler(this.модельОборудованияToolStripMenuItem_Click);
            // 
            // пользовательToolStripMenuItem
            // 
            this.пользовательToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изменитьПарольToolStripMenuItem});
            this.пользовательToolStripMenuItem.Name = "пользовательToolStripMenuItem";
            this.пользовательToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.пользовательToolStripMenuItem.Text = "Пользователь";
            // 
            // изменитьПарольToolStripMenuItem
            // 
            this.изменитьПарольToolStripMenuItem.Name = "изменитьПарольToolStripMenuItem";
            this.изменитьПарольToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.изменитьПарольToolStripMenuItem.Text = "Изменить пароль";
            this.изменитьПарольToolStripMenuItem.Click += new System.EventHandler(this.изменитьПарольToolStripMenuItem_Click);
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
            // listViewMain
            // 
            this.listViewMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderInvent,
            this.columnHeaderLocation,
            this.columnHeaderDate,
            this.columnHeaderMOLFullName,
            this.columnHeaderDepatnment,
            this.columnHeaderItamNumber,
            this.columnHeaderManufacturer,
            this.columnHeaderModel,
            this.columnHeaderType,
            this.columnHeaderUser});
            this.listViewMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewMain.FullRowSelect = true;
            this.listViewMain.GridLines = true;
            this.listViewMain.HideSelection = false;
            this.listViewMain.Location = new System.Drawing.Point(9, 134);
            this.listViewMain.Name = "listViewMain";
            this.listViewMain.Size = new System.Drawing.Size(1300, 438);
            this.listViewMain.TabIndex = 1;
            this.listViewMain.UseCompatibleStateImageBehavior = false;
            this.listViewMain.View = System.Windows.Forms.View.Details;
            this.listViewMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listViewMain_MouseDown);
            // 
            // columnHeaderInvent
            // 
            this.columnHeaderInvent.Text = "Инвент. номер";
            this.columnHeaderInvent.Width = 118;
            // 
            // columnHeaderLocation
            // 
            this.columnHeaderLocation.Text = "Локация";
            this.columnHeaderLocation.Width = 166;
            // 
            // columnHeaderDate
            // 
            this.columnHeaderDate.Text = "Дата";
            this.columnHeaderDate.Width = 82;
            // 
            // columnHeaderMOLFullName
            // 
            this.columnHeaderMOLFullName.Text = "МОЛ";
            this.columnHeaderMOLFullName.Width = 76;
            // 
            // columnHeaderDepatnment
            // 
            this.columnHeaderDepatnment.Text = "Отдел";
            this.columnHeaderDepatnment.Width = 97;
            // 
            // columnHeaderItamNumber
            // 
            this.columnHeaderItamNumber.Text = "Номен. Артикл.";
            this.columnHeaderItamNumber.Width = 116;
            // 
            // columnHeaderManufacturer
            // 
            this.columnHeaderManufacturer.Text = "Производитель";
            this.columnHeaderManufacturer.Width = 135;
            // 
            // columnHeaderModel
            // 
            this.columnHeaderModel.Text = "Модель";
            this.columnHeaderModel.Width = 125;
            // 
            // columnHeaderType
            // 
            this.columnHeaderType.Text = "Тип";
            this.columnHeaderType.Width = 100;
            // 
            // columnHeaderUser
            // 
            this.columnHeaderUser.Text = "Сотрудник ИТ";
            this.columnHeaderUser.Width = 100;
            // 
            // buttonIMainAddNew
            // 
            this.buttonIMainAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonIMainAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIMainAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonIMainAddNew.ForeColor = System.Drawing.Color.White;
            this.buttonIMainAddNew.Location = new System.Drawing.Point(436, 579);
            this.buttonIMainAddNew.Name = "buttonIMainAddNew";
            this.buttonIMainAddNew.Size = new System.Drawing.Size(132, 36);
            this.buttonIMainAddNew.TabIndex = 76;
            this.buttonIMainAddNew.Text = "Добавить";
            this.buttonIMainAddNew.UseVisualStyleBackColor = false;
            this.buttonIMainAddNew.Click += new System.EventHandler(this.buttonIMainAddNew_Click);
            // 
            // buttonMainChange
            // 
            this.buttonMainChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonMainChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMainChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonMainChange.ForeColor = System.Drawing.Color.White;
            this.buttonMainChange.Location = new System.Drawing.Point(606, 579);
            this.buttonMainChange.Name = "buttonMainChange";
            this.buttonMainChange.Size = new System.Drawing.Size(132, 36);
            this.buttonMainChange.TabIndex = 111;
            this.buttonMainChange.Text = "Изменить";
            this.buttonMainChange.UseVisualStyleBackColor = false;
            this.buttonMainChange.Click += new System.EventHandler(this.buttonMainChange_Click);
            // 
            // buttonDeleteMain
            // 
            this.buttonDeleteMain.BackColor = System.Drawing.Color.Red;
            this.buttonDeleteMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonDeleteMain.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteMain.Location = new System.Drawing.Point(789, 579);
            this.buttonDeleteMain.Name = "buttonDeleteMain";
            this.buttonDeleteMain.Size = new System.Drawing.Size(132, 36);
            this.buttonDeleteMain.TabIndex = 112;
            this.buttonDeleteMain.Text = "Удалить";
            this.buttonDeleteMain.UseVisualStyleBackColor = false;
            this.buttonDeleteMain.Click += new System.EventHandler(this.buttonDeleteMain_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(1077, 579);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(132, 36);
            this.buttonExit.TabIndex = 113;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.labelFilter.ForeColor = System.Drawing.Color.White;
            this.labelFilter.Location = new System.Drawing.Point(3, 66);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(96, 26);
            this.labelFilter.TabIndex = 115;
            this.labelFilter.Text = "Фильтр";
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Items.AddRange(new object[] {
            "По инвентарному номеру",
            "По локации",
            "По дате",
            "По МОЛ\'у",
            "По отделу",
            "По номен. артикулю",
            "По производителю",
            "По модели",
            "По типу",
            "По сотруднику ИТ",
            "По всем полям"});
            this.comboBoxFilter.Location = new System.Drawing.Point(386, 63);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(304, 33);
            this.comboBoxFilter.TabIndex = 116;
            this.comboBoxFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilter_SelectedIndexChanged);
            // 
            // buttonFilterEmpty
            // 
            this.buttonFilterEmpty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonFilterEmpty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFilterEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonFilterEmpty.ForeColor = System.Drawing.Color.White;
            this.buttonFilterEmpty.Location = new System.Drawing.Point(706, 53);
            this.buttonFilterEmpty.Name = "buttonFilterEmpty";
            this.buttonFilterEmpty.Size = new System.Drawing.Size(240, 43);
            this.buttonFilterEmpty.TabIndex = 117;
            this.buttonFilterEmpty.Text = "Отчистить фильтр";
            this.buttonFilterEmpty.UseVisualStyleBackColor = false;
            this.buttonFilterEmpty.Click += new System.EventHandler(this.buttonFilterEmpty_Click);
            // 
            // comboBoxFilterAll
            // 
            this.comboBoxFilterAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.comboBoxFilterAll.FormattingEnabled = true;
            this.comboBoxFilterAll.Location = new System.Drawing.Point(105, 59);
            this.comboBoxFilterAll.Name = "comboBoxFilterAll";
            this.comboBoxFilterAll.Size = new System.Drawing.Size(275, 33);
            this.comboBoxFilterAll.TabIndex = 118;
            this.comboBoxFilterAll.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilterAll_SelectedIndexChanged);
            this.comboBoxFilterAll.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxFilterAll_KeyPress);
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerStart.Location = new System.Drawing.Point(105, 40);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(275, 32);
            this.dateTimePickerStart.TabIndex = 119;
            this.dateTimePickerStart.Visible = false;
            this.dateTimePickerStart.ValueChanged += new System.EventHandler(this.dateTimePickerStart_ValueChanged);
            // 
            // dateTimePickerFinish
            // 
            this.dateTimePickerFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerFinish.Location = new System.Drawing.Point(105, 87);
            this.dateTimePickerFinish.Name = "dateTimePickerFinish";
            this.dateTimePickerFinish.Size = new System.Drawing.Size(275, 32);
            this.dateTimePickerFinish.TabIndex = 120;
            this.dateTimePickerFinish.Visible = false;
            this.dateTimePickerFinish.ValueChanged += new System.EventHandler(this.dateTimePickerFinish_ValueChanged);
            // 
            // labelDateStart
            // 
            this.labelDateStart.AutoSize = true;
            this.labelDateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.labelDateStart.ForeColor = System.Drawing.Color.White;
            this.labelDateStart.Location = new System.Drawing.Point(63, 46);
            this.labelDateStart.Name = "labelDateStart";
            this.labelDateStart.Size = new System.Drawing.Size(36, 26);
            this.labelDateStart.TabIndex = 121;
            this.labelDateStart.Text = "от";
            this.labelDateStart.Visible = false;
            // 
            // labelDateFinish
            // 
            this.labelDateFinish.AutoSize = true;
            this.labelDateFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.labelDateFinish.ForeColor = System.Drawing.Color.White;
            this.labelDateFinish.Location = new System.Drawing.Point(60, 87);
            this.labelDateFinish.Name = "labelDateFinish";
            this.labelDateFinish.Size = new System.Drawing.Size(39, 26);
            this.labelDateFinish.TabIndex = 122;
            this.labelDateFinish.Text = "до";
            this.labelDateFinish.Visible = false;
            // 
            // textBoxFilterAll
            // 
            this.textBoxFilterAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.textBoxFilterAll.Location = new System.Drawing.Point(105, 66);
            this.textBoxFilterAll.Name = "textBoxFilterAll";
            this.textBoxFilterAll.Size = new System.Drawing.Size(275, 32);
            this.textBoxFilterAll.TabIndex = 123;
            this.textBoxFilterAll.Visible = false;
            this.textBoxFilterAll.TextChanged += new System.EventHandler(this.textBoxFilterAll_TextChanged);
            // 
            // labelUserLogin
            // 
            this.labelUserLogin.AutoSize = true;
            this.labelUserLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.labelUserLogin.ForeColor = System.Drawing.Color.White;
            this.labelUserLogin.Location = new System.Drawing.Point(1158, 40);
            this.labelUserLogin.Name = "labelUserLogin";
            this.labelUserLogin.Size = new System.Drawing.Size(76, 26);
            this.labelUserLogin.TabIndex = 124;
            this.labelUserLogin.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(978, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 26);
            this.label1.TabIndex = 125;
            this.label1.Text = "Пользователь: ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1319, 627);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelUserLogin);
            this.Controls.Add(this.textBoxFilterAll);
            this.Controls.Add(this.labelDateFinish);
            this.Controls.Add(this.labelDateStart);
            this.Controls.Add(this.dateTimePickerFinish);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.comboBoxFilterAll);
            this.Controls.Add(this.buttonFilterEmpty);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonDeleteMain);
            this.Controls.Add(this.buttonMainChange);
            this.Controls.Add(this.buttonIMainAddNew);
            this.Controls.Add(this.listViewMain);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MainForm";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
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
        private System.Windows.Forms.ToolStripMenuItem модельОборудованияToolStripMenuItem;
        private System.Windows.Forms.ListView listViewMain;
        private System.Windows.Forms.ColumnHeader columnHeaderInvent;
        private System.Windows.Forms.ColumnHeader columnHeaderLocation;
        private System.Windows.Forms.ColumnHeader columnHeaderDate;
        private System.Windows.Forms.ColumnHeader columnHeaderMOLFullName;
        private System.Windows.Forms.ColumnHeader columnHeaderDepatnment;
        private System.Windows.Forms.ColumnHeader columnHeaderItamNumber;
        private System.Windows.Forms.ColumnHeader columnHeaderManufacturer;
        private System.Windows.Forms.ColumnHeader columnHeaderModel;
        private System.Windows.Forms.ColumnHeader columnHeaderType;
        private System.Windows.Forms.ColumnHeader columnHeaderUser;
        private System.Windows.Forms.Button buttonIMainAddNew;
        private System.Windows.Forms.Button buttonMainChange;
        private System.Windows.Forms.Button buttonDeleteMain;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.Button buttonFilterEmpty;
        private System.Windows.Forms.ComboBox comboBoxFilterAll;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinish;
        private System.Windows.Forms.Label labelDateStart;
        private System.Windows.Forms.Label labelDateFinish;
        private System.Windows.Forms.ToolStripMenuItem изменитьПарольToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxFilterAll;
        private System.Windows.Forms.Label labelUserLogin;
        private System.Windows.Forms.Label label1;
    }
}

