using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_db
{
    public partial class MainForm : Form
    {
        // Столбец, который мы сейчас используем для сортировки.
        private ColumnHeader SortingColumn = null;
        public string userLogin;
        public string oldUserPassword;
        public string privilegeUser;
        public string fullUserName;

        public string rowstextBoxInventNumberMouse;
        public string rowscomboBoxLocationMouse;
        public string rowsdateTimePicker1Mouse;
        public string rowscomboBoxDepartmentMouse;
        public string rowscomboBoxMOLMouse;
        public string rowscomboBoxItamNumberMouse;
        public string rowscomboBoxModelMouse;
        public string rowscomboBoxEquipmentManufacturerMouse;
        public string rowscomboBoxEquipmentTypeMouse;
        public string rowscomboBoxStuffMouse;




        private List<string[]> filteredList = null;
        private List<string[]> rowsMain = new List<string[]>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MenuItemAccountManagement_Click(object sender, EventArgs e)
        {
            FormAccountManagement FormAccountManagement = new FormAccountManagement();
            FormAccountManagement.ShowDialog();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //if (exitValue == true)
            {
                Environment.Exit(0);
            }
            this.Close();
        }

        private void ToolStripMenuItemLocation_Click(object sender, EventArgs e)
        {
            FormLocation FormLocation = new FormLocation();
            FormLocation.ShowDialog();
        }

        private void мОЛToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMOL FormMOL = new FormMOL();
            FormMOL.ShowDialog();
        }

        private void типыОборудованяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEquipmentType FormEquipment = new FormEquipmentType();
            FormEquipment.ShowDialog();
        }

        private void производительОборудованияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEquipmentManufacturer FormEquipmentManufacturer = new FormEquipmentManufacturer();
            FormEquipmentManufacturer.ShowDialog();
        }

        private void оборудованиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEquipmentModel FormEquipmentModel = new FormEquipmentModel();
            FormEquipmentModel.ShowDialog();
        }

        private void модельОборудованияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormItamNumber FormItamNumber = new FormItamNumber();
            FormItamNumber.ShowDialog();
        }

        private void RefreshlistViewMain(List<string[]> list)
        {
            listViewMain.Items.Clear();
            foreach (string[] s in list)
            {
                listViewMain.Items.Add(new ListViewItem(s));
            }
        }

        private void RefreshlistViewMain()
        {
            MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["inventory"].ConnectionString);
            rowsMain.Clear();
            MySqlDataReader dataReader = null;
            string[] row;
            //try
            {
                sqlConnection.Open();
                //MySqlCommand sqlCommand = new MySqlCommand(" " +
                //                                           "SELECT tb_equipment_report.invent_number,  tb_location.col_location_name, tb_equipment_report.col_date,  tb_department.col_mol_full_name, tb_department.mol_department, tb_itam_number.item_number, tb_equipment_model.equipment_model_name, tb_equipment_manufacturer.col_equipment_manufacturer_name, tb_type_equipment.col_type_equipment_name,tb_authorization_staff.col_full_name_staff " +
                //                                           "FROM  tb_equipment_report " +
                //                                           "JOIN tb_location " +
                //                                           "ON tb_equipment_report.id_col_location = tb_location.id_col_location " +
                //                                           "JOIN tb_department " +
                //                                           "ON tb_equipment_report.mol_department = tb_department.mol_department " +
                //                                           "JOIN tb_itam_number " +
                //                                           "ON tb_equipment_report.item_number = tb_itam_number.item_number " +
                //                                           "JOIN tb_equipment_model " +
                //                                           "ON tb_itam_number.equipment_model_name = tb_equipment_model.equipment_model_name " +
                //                                           "JOIN tb_equipment_manufacturer " +
                //                                           "ON tb_equipment_model.id_equipment_manufacturer = tb_equipment_manufacturer.id_equipment_manufacturer " +
                //                                           "JOIN tb_type_equipment " +
                //                                           "ON tb_equipment_model.id_type_equipment = tb_type_equipment.id_type_equipment " +
                //                                           "JOIN tb_authorization_staff " +
                //                                           "ON tb_equipment_report.login_authorization_staff = tb_authorization_staff.login_authorization_staff ", sqlConnection);
                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM inventory.main_report", sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    row = new string[]
                    {
                        Convert.ToString(dataReader["invent_number"]),
                        Convert.ToString(dataReader["col_location_name"]),
                        Convert.ToString(dataReader["col_date"]).Substring(0, Convert.ToString(dataReader["col_date"]).Length - 11),
                        Convert.ToString(dataReader["col_mol_full_name"]),
                        Convert.ToString(dataReader["mol_department"]),
                        Convert.ToString(dataReader["item_number"]),
                        Convert.ToString(dataReader["col_equipment_manufacturer_name"]),
                        Convert.ToString(dataReader["equipment_model_name"]),
                        Convert.ToString(dataReader["col_type_equipment_name"]),
                        Convert.ToString(dataReader["col_full_name_staff"])
                    };
                    rowsMain.Add(row);
                }
                sqlConnection.Close();
                dataReader.Close();
            }
            //catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            //finally
            {
                if (dataReader != null && !dataReader.IsClosed)
                {
                    dataReader.Close();
                }
            }
            listViewMain.Items.Clear();
            foreach (string[] s in rowsMain)
            {
                listViewMain.Items.Add(new ListViewItem(s));
            }
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            RefreshlistViewMain();
            if (privilegeUser == "Администратор")
            {
                администрированиеToolStripMenuItem.Visible = true;
                пользовательToolStripMenuItem.Visible = false;
            }    
            else
                администрированиеToolStripMenuItem.Visible = false;

            labelUserLogin.Text = fullUserName;
        }

        private void buttonIMainAddNew_Click(object sender, EventArgs e)
        {
            FormMainAddNew FormMainAddNew = new FormMainAddNew();
            FormMainAddNew.fullStuffName = fullUserName;
            FormMainAddNew.ShowDialog();

        }

        private void buttonMainChange_Click(object sender, EventArgs e)
        {
            FormMainChange FormMainChange = new FormMainChange();

            if (this.listViewMain.SelectedItems.Count != 0)
            {
                FormMainChange.textBoxInventNumberBuff = rowstextBoxInventNumberMouse;
                FormMainChange.comboBoxLocationBuff = rowscomboBoxLocationMouse;
                FormMainChange.dateTimePicker1Buff = rowsdateTimePicker1Mouse;
                FormMainChange.comboBoxDepartmentBuff = rowscomboBoxDepartmentMouse;
                FormMainChange.comboBoxMOLBuff = rowscomboBoxMOLMouse;
                FormMainChange.comboBoxItamNumberBuff = rowscomboBoxItamNumberMouse;
                FormMainChange.comboBoxModelBuff = rowscomboBoxModelMouse;
                FormMainChange.comboBoxEquipmentManufacturerBuff = rowscomboBoxEquipmentManufacturerMouse;
                FormMainChange.comboBoxEquipmentTypeBuff = rowscomboBoxEquipmentTypeMouse;
                FormMainChange.comboBoxStuffBuff = rowscomboBoxStuffMouse;
                FormMainChange.ShowDialog();
                RefreshlistViewMain();
            }
            else
            {
                MessageBox.Show("Выберете строку!", "Ошибка");
            }
        }

        private void listViewMain_MouseDown(object sender, MouseEventArgs e)
        {
            {
                ListViewHitTestInfo info = listViewMain.HitTest(e.X, e.Y);
                ListViewItem item = info.Item;

                if (item != null)
                {
                    this.rowstextBoxInventNumberMouse = item.SubItems[0].Text;
                    this.rowscomboBoxLocationMouse = item.SubItems[1].Text;
                    this.rowsdateTimePicker1Mouse = item.SubItems[2].Text;
                    this.rowscomboBoxDepartmentMouse = item.SubItems[3].Text;
                    this.rowscomboBoxMOLMouse = item.SubItems[4].Text;
                    this.rowscomboBoxItamNumberMouse = item.SubItems[5].Text;
                    this.rowscomboBoxModelMouse = item.SubItems[6].Text;
                    this.rowscomboBoxEquipmentManufacturerMouse = item.SubItems[7].Text;
                    this.rowscomboBoxEquipmentTypeMouse = item.SubItems[8].Text;
                    this.rowscomboBoxStuffMouse = item.SubItems[9].Text;
                }
                else
                {
                    this.listViewMain.SelectedItems.Clear();
                }
            }
        }

        private void buttonDeleteMain_Click(object sender, EventArgs e)
        {
            MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["inventory"].ConnectionString);
            if (this.listViewMain.SelectedItems.Count != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить оборудование?", "Удаление типа", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string query = "DELETE FROM `tb_equipment_report` WHERE `invent_number` = @invent_number";
                    MySqlCommand commandDatabase = new MySqlCommand(query, sqlConnection);
                    commandDatabase.Parameters.Add("@invent_number", MySqlDbType.VarChar).Value = rowstextBoxInventNumberMouse;

                    commandDatabase.CommandTimeout = 60;
                    MySqlDataReader reader;
                    try
                    {
                        sqlConnection.Open();
                        reader = commandDatabase.ExecuteReader();
                        // Succesfully deleted
                        sqlConnection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    RefreshlistViewMain();
                }
            }
            else
            {
                MessageBox.Show("Выберете оборудование!", "Ошибка");
            }
        }

        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void buttonFilterEmpty_Click(object sender, EventArgs e)
        {
            
            comboBoxFilterAll.SelectedIndex = -1;
            comboBoxFilter.SelectedIndex = -1;
            FilterForWithoutDate();
            RefreshlistViewMain();
            textBoxFilterAll.Visible = false;
            comboBoxFilterAll.Visible = false;
        }

        private void Filter(int a)
        {
            //comboBoxFilterAll.Text = "";
            filteredList = rowsMain.Where(x =>
                (x[a].ToLower().Contains(comboBoxFilterAll.Text.ToLower()))
            ).ToList();
            RefreshlistViewMain(filteredList);
        }


        private void FilterInventNumber(int a)
        {
            //comboBoxFilterAll.DataSource = null;
            MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["inventory"].ConnectionString);
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM tb_equipment_report", sqlConnection);
                //SqlDataAdapter da = new SqlDataAdapter(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable table = new DataTable();
                adapter.SelectCommand = command;


                sqlConnection.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Fleet");
                comboBoxFilterAll.DisplayMember = "invent_number";
                comboBoxFilterAll.ValueMember = "invent_number";
                comboBoxFilterAll.DataSource = ds.Tables["Fleet"];
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("Error occured!");
            }

        }
        private void FilterLocation(int a)
        {
            //comboBoxFilterAll.DataSource = null;
            MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["inventory"].ConnectionString);
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM tb_location", sqlConnection);
                //SqlDataAdapter da = new SqlDataAdapter(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable table = new DataTable();
                adapter.SelectCommand = command;


                sqlConnection.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Fleet");
                comboBoxFilterAll.DisplayMember = "col_location_name";
                comboBoxFilterAll.ValueMember = "id_col_location";
                comboBoxFilterAll.DataSource = ds.Tables["Fleet"];
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("Error occured!");
            }
        }
        private void FilterDate(int a)
        {
            //comboBoxFilterAll.DataSource = null;
            MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["inventory"].ConnectionString);
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM tb_equipment_report", sqlConnection);
                //SqlDataAdapter da = new SqlDataAdapter(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable table = new DataTable();
                adapter.SelectCommand = command;


                sqlConnection.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Fleet");
                comboBoxFilterAll.DisplayMember = "col_date";
                comboBoxFilterAll.ValueMember = "col_date";
                comboBoxFilterAll.DataSource = ds.Tables["Fleet"];
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("Error occured!");
            }
        }
        private void FilterDepartment(int a)
        {
            //comboBoxFilterAll.DataSource = null;
            MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["inventory"].ConnectionString);
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM tb_department", sqlConnection);
                //SqlDataAdapter da = new SqlDataAdapter(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable table = new DataTable();
                adapter.SelectCommand = command;


                sqlConnection.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Fleet");
                comboBoxFilterAll.DisplayMember = "mol_department";
                comboBoxFilterAll.ValueMember = "mol_department";
                comboBoxFilterAll.DataSource = ds.Tables["Fleet"];
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("Error occured!");
            }
        }
        private void FilterMOL(int a)
        {
            //comboBoxFilterAll.DataSource = null;
            MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["inventory"].ConnectionString);
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM tb_department", sqlConnection);
                //SqlDataAdapter da = new SqlDataAdapter(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable table = new DataTable();
                adapter.SelectCommand = command;


                sqlConnection.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Fleet");
                comboBoxFilterAll.DisplayMember = "col_mol_full_name";
                comboBoxFilterAll.ValueMember = "mol_department";
                comboBoxFilterAll.DataSource = ds.Tables["Fleet"];
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("Error occured!");
            }
        }
        private void FilterItamNumber(int a)
        {
            //comboBoxFilterAll.DataSource = null;
            MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["inventory"].ConnectionString);
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM tb_itam_number", sqlConnection);
                //SqlDataAdapter da = new SqlDataAdapter(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable table = new DataTable();
                adapter.SelectCommand = command;


                sqlConnection.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Fleet");
                comboBoxFilterAll.DisplayMember = "item_number";
                comboBoxFilterAll.ValueMember = "item_number";
                comboBoxFilterAll.DataSource = ds.Tables["Fleet"];
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("Error occured!");
            }
        }
        private void FilterModel(int a)
        {
            //comboBoxFilterAll.DataSource = null;

            MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["inventory"].ConnectionString);
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM tb_equipment_model", sqlConnection);
                //SqlDataAdapter da = new SqlDataAdapter(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable table = new DataTable();
                adapter.SelectCommand = command;


                sqlConnection.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Fleet");
                comboBoxFilterAll.DisplayMember = "equipment_model_name";
                comboBoxFilterAll.ValueMember = "equipment_model_name";
                comboBoxFilterAll.DataSource = ds.Tables["Fleet"];
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("Error occured!");
            }
        }
        private void FilterEquipmentManufacturer(int a)
        {
            //comboBoxFilterAll.DataSource = null;

            MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["inventory"].ConnectionString);
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM tb_equipment_manufacturer", sqlConnection);
                //SqlDataAdapter da = new SqlDataAdapter(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable table = new DataTable();
                adapter.SelectCommand = command;


                sqlConnection.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Fleet");
                comboBoxFilterAll.DisplayMember = "col_equipment_manufacturer_name";
                comboBoxFilterAll.ValueMember = "id_equipment_manufacturer";
                comboBoxFilterAll.DataSource = ds.Tables["Fleet"];
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("Error occured!");
            }
        }
        private void FilterEquipmentType(int a)
        {
            //comboBoxFilterAll.DataSource = null;

            MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["inventory"].ConnectionString);
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM tb_type_equipment", sqlConnection);
                //SqlDataAdapter da = new SqlDataAdapter(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable table = new DataTable();
                adapter.SelectCommand = command;


                sqlConnection.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Fleet");
                comboBoxFilterAll.DisplayMember = "col_type_equipment_name";
                comboBoxFilterAll.ValueMember = "id_type_equipment";
                comboBoxFilterAll.DataSource = ds.Tables["Fleet"];
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("Error occured!");
            }
        }
        private void FilterStuff(int a)
        {
            //comboBoxFilterAll.DataSource = null;

            MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["inventory"].ConnectionString);
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM tb_authorization_staff", sqlConnection);
                //SqlDataAdapter da = new SqlDataAdapter(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable table = new DataTable();
                adapter.SelectCommand = command;


                sqlConnection.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Fleet");
                comboBoxFilterAll.DisplayMember = "col_full_name_staff";
                comboBoxFilterAll.ValueMember = "login_authorization_staff";
                comboBoxFilterAll.DataSource = ds.Tables["Fleet"];
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("Error occured!");
            }
        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxFilterAll.Visible = false;
            comboBoxFilterAll.DataSource = null;
            if (comboBoxFilter.SelectedIndex == 0)
            {
                FilterForWithoutDate();
                FilterInventNumber(0);
            }
            else if (comboBoxFilter.SelectedIndex == 1)
            {
                FilterForWithoutDate();
                FilterLocation(1);
            }
            else if (comboBoxFilter.SelectedIndex == 2)
            {
                FilterForWithtDate();
                FilterDate(2);
            }
            else if (comboBoxFilter.SelectedIndex == 3)
            {
                FilterForWithoutDate();
                FilterMOL(3);
            }
            else if (comboBoxFilter.SelectedIndex == 4)
            {
                FilterForWithoutDate();
                FilterDepartment(4);
            }
            else if (comboBoxFilter.SelectedIndex == 5)
            {
                FilterForWithoutDate();
                FilterItamNumber(5);
            }
            else if (comboBoxFilter.SelectedIndex == 6)
            {
                FilterForWithoutDate();
                FilterEquipmentManufacturer(6);
            }
            else if (comboBoxFilter.SelectedIndex == 7)
            {
                FilterForWithoutDate();
                FilterModel(7);
            }
            else if (comboBoxFilter.SelectedIndex == 8)
            {
                FilterForWithoutDate();
                FilterEquipmentType(8);
            }
            else if (comboBoxFilter.SelectedIndex == 9)
            {
                FilterForWithoutDate();
                FilterStuff(9);
            }
            else if (comboBoxFilter.SelectedIndex == 10)
            {
                dateTimePickerStart.Visible = false;
                dateTimePickerFinish.Visible = false;
                labelDateStart.Visible = false;
                labelDateFinish.Visible = false;
                labelFilter.Visible = true;
                comboBoxFilterAll.Visible = false;
                textBoxFilterAll.Visible = true;

            }
            comboBoxFilterAll.SelectedIndex = -1;
        }

        private void comboBoxFilterAll_KeyPress(object sender, KeyPressEventArgs e)
        {
            ((ComboBox)(sender)).DroppedDown = true;
            if ((char.IsControl(e.KeyChar)))
                return;
            string Str = ((ComboBox)(sender)).Text.Substring(0, ((ComboBox)(sender)).SelectionStart) + e.KeyChar;
            int Index = ((ComboBox)(sender)).FindStringExact(Str);
            if (Index == -1)
                Index = ((ComboBox)(sender)).FindString(Str);
            ((ComboBox)sender).SelectedIndex = Index;
            ((ComboBox)(sender)).SelectionStart = Str.Length;
            ((ComboBox)(sender)).SelectionLength = ((ComboBox)(sender)).Text.Length - ((ComboBox)(sender)).SelectionStart;
            e.Handled = true;
        }

        private void comboBoxFilterAll_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBoxFilterAll.DataSource = null;
            if (comboBoxFilter.SelectedIndex == 0)
                Filter(0);
            else if (comboBoxFilter.SelectedIndex == 1)
                Filter(1);
            else if (comboBoxFilter.SelectedIndex == 3)
                Filter(3);
            else if (comboBoxFilter.SelectedIndex == 4)
                Filter(4);
            else if (comboBoxFilter.SelectedIndex == 5)
                Filter(5);
            else if (comboBoxFilter.SelectedIndex == 6)
                Filter(6);
            else if (comboBoxFilter.SelectedIndex == 7)
                Filter(7);
            else if (comboBoxFilter.SelectedIndex == 8)
                Filter(8);
            else if (comboBoxFilter.SelectedIndex == 9)
                Filter(9);


        }
        private void FilterDateSpec(int a)
        {
            filteredList = rowsMain.Where(x =>
                DateTime.Parse(x[a]) >= (dateTimePickerStart.Value) &&
                DateTime.Parse(x[a]) <= (dateTimePickerFinish.Value)
                ).ToList();
            RefreshlistViewMain(filteredList);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FilterForWithoutDate()
        {
            dateTimePickerStart.Visible = false;
            dateTimePickerFinish.Visible = false;
            labelDateStart.Visible = false;
            labelDateFinish.Visible = false;
            labelFilter.Visible = true;
            comboBoxFilterAll.Visible = true;
            textBoxFilterAll.Visible = false;
        }
        private void FilterForWithtDate()
        {
            dateTimePickerStart.Visible = true;
            dateTimePickerFinish.Visible = true;
            labelDateStart.Visible = true;
            labelDateFinish.Visible = true;
            labelFilter.Visible = false;
            comboBoxFilterAll.Visible = false;
            textBoxFilterAll.Visible = false;
        }

        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            FilterDateSpec(2);
        }

        private void dateTimePickerFinish_ValueChanged(object sender, EventArgs e)
        {
            FilterDateSpec(2);
        }

        private void изменитьПарольToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChangeUserPaswword FormChangeUserPaswword = new FormChangeUserPaswword();

            FormChangeUserPaswword.userLogin = userLogin;
            FormChangeUserPaswword.oldUserPassword = oldUserPassword;

            FormChangeUserPaswword.ShowDialog();
        }

        private void textBoxFilterAll_TextChanged(object sender, EventArgs e)
        {
            //comboBoxFilterAll.DataSource = null;
            filteredList = rowsMain.Where(x =>
                (x[0].ToLower().Contains(textBoxFilterAll.Text.ToLower())) ||
                (x[1].ToLower().Contains(textBoxFilterAll.Text.ToLower())) ||
                (x[2].ToLower().Contains(textBoxFilterAll.Text.ToLower())) ||
                (x[3].ToLower().Contains(textBoxFilterAll.Text.ToLower())) ||
                (x[4].ToLower().Contains(textBoxFilterAll.Text.ToLower())) ||
                (x[5].ToLower().Contains(textBoxFilterAll.Text.ToLower())) ||
                (x[6].ToLower().Contains(textBoxFilterAll.Text.ToLower())) ||
                (x[7].ToLower().Contains(textBoxFilterAll.Text.ToLower())) ||
                (x[8].ToLower().Contains(textBoxFilterAll.Text.ToLower())) ||
                (x[9].ToLower().Contains(textBoxFilterAll.Text.ToLower()))
            ).ToList();
            RefreshlistViewMain(filteredList);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            comboBoxFilterAll.DropDownHeight = 200;
            columnHeaderInvent.Width = 110;
            columnHeaderLocation.Width = 200;
            columnHeaderDate.Width = 80;
            columnHeaderMOLFullName.Width = 120;
            columnHeaderDepatnment.Width = 120;
            columnHeaderItamNumber.Width = 120;
            columnHeaderManufacturer.Width = 120;
            columnHeaderModel.Width = 200;
            columnHeaderType.Width = 100;
            columnHeaderUser.Width = 105;
        }

        private void listViewMain_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelFilter_Click(object sender, EventArgs e)
        {

        }

        private void labelDateStart_Click(object sender, EventArgs e)
        {

        }

        private void labelDateFinish_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelUserLogin_Click(object sender, EventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа инвентаризации обордования\n\nАвтор: студент группы ИВТб19з Новик В.В.\n\n\t\t2023 г.");
        }

        private void listViewMain_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Получить новый столбец сортировки.
            ColumnHeader new_sorting_column = listViewMain.Columns[e.Column];

            // Извлеките новый порядок сортировки.
            System.Windows.Forms.SortOrder sort_order;
            if (SortingColumn == null)
            {
                // Новый столбец. Сортировать по возрастанию.
                sort_order = SortOrder.Ascending;
            }
            else
            {
                // См., Если это тот же самый столбец.
                if (new_sorting_column == SortingColumn)
                {
                    // Тот же столбец. Переключите порядок сортировки.
                    if (SortingColumn.Text.StartsWith("↓ "))
                    {
                        sort_order = SortOrder.Descending;
                    }
                    else
                    {
                        sort_order = SortOrder.Ascending;
                    }
                }
                else
                {
                    // Новый столбец. Сортировать по возрастанию.
                    sort_order = SortOrder.Ascending;
                }

                // Удаление старого индикатора сортировки.
                SortingColumn.Text = SortingColumn.Text.Substring(2);
            }

            // Отображение нового порядка сортировки.
            SortingColumn = new_sorting_column;
            if (sort_order == SortOrder.Ascending)
            {
                SortingColumn.Text = "↓ " + SortingColumn.Text;
            }
            else
            {
                SortingColumn.Text = "↑ " + SortingColumn.Text;
            }

            // Создаем компаратор.
            listViewMain.ListViewItemSorter =
                new ListViewComparer(e.Column, sort_order);

            // Сортировать.
            listViewMain.Sort();
        }
        // Сравнивает два элемента ListView на основе выбранного столбца.
        public class ListViewComparer : System.Collections.IComparer
        {
            private int ColumnNumber;
            private SortOrder SortOrder;

            public ListViewComparer(int column_number,
                SortOrder sort_order)
            {
                ColumnNumber = column_number;
                SortOrder = sort_order;
            }

            // Сравнение двух списков ListViewItems.
            public int Compare(object object_x, object object_y)
            {
                // Получить объекты как ListViewItems.
                ListViewItem item_x = object_x as ListViewItem;
                ListViewItem item_y = object_y as ListViewItem;

                // Получаем соответствующие значения подпозиции.
                string string_x;
                if (item_x.SubItems.Count <= ColumnNumber)
                {
                    string_x = "";
                }
                else
                {
                    string_x = item_x.SubItems[ColumnNumber].Text;
                }

                string string_y;
                if (item_y.SubItems.Count <= ColumnNumber)
                {
                    string_y = "";
                }
                else
                {
                    string_y = item_y.SubItems[ColumnNumber].Text;
                }

                // Сравните их.
                int result;
                double double_x, double_y;
                if (double.TryParse(string_x, out double_x) &&
                    double.TryParse(string_y, out double_y))
                {
                    // Обрабатываем как число.
                    result = double_x.CompareTo(double_y);
                }
                else
                {
                    DateTime date_x, date_y;
                    if (DateTime.TryParse(string_x, out date_x) &&
                        DateTime.TryParse(string_y, out date_y))
                    {
                        // Обработать как дату.
                        result = date_x.CompareTo(date_y);
                    }
                    else
                    {
                        // Обработать как строку.
                        result = string_x.CompareTo(string_y);
                    }
                }

                // Вернуть правильный результат в зависимости от того,
                // сортируем по возрастанию или по убыванию.
                if (SortOrder == SortOrder.Ascending)
                {
                    return result;
                }
                else
                {
                    return -result;
                }
            }
        }
    }
}
