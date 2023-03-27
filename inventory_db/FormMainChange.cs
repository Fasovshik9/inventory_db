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
    public partial class FormMainChange : Form
    {

        private List<string[]> filteredList = null;
        private List<string[]> rowsMainChange = new List<string[]>();
        MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["inventory"].ConnectionString);

        public string textBoxInventNumberBuff;
        public string comboBoxLocationBuff;
        public string dateTimePicker1Buff;
        public string comboBoxDepartmentBuff;
        public string comboBoxMOLBuff;
        public string comboBoxItamNumberBuff;
        public string comboBoxModelBuff;
        public string comboBoxEquipmentManufacturerBuff;
        public string comboBoxEquipmentTypeBuff;
        public string comboBoxStuffBuff;


        public FormMainChange()
        {
            InitializeComponent();

            FillComboBoxLocation();
            FillComboBoxDepartment();
            FillComboBoxMOL();
            FillComboBoxItamNumber();
            FillComboBoxModel();
            FillComboBoxEquipmentManufacturer();
            FillComboBoxEquipmentType();
            FillComboBoxStuff();
        }
        private void FillComboBoxes_Department_MOL()
        {
            rowsMainChange.Clear();
            MySqlDataReader dataReader = null;
            string[] row;
            try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("SELECT tb_mol.col_mol_full_name " +
                                                            "FROM tb_mol " +
                                                            "WHERE tb_mol.mol_department=@department", sqlConnection);

                sqlCommand.Parameters.Add("@department", MySqlDbType.VarChar).Value = comboBoxDepartment.Text;

                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    row = new string[]
                    {
                        Convert.ToString(dataReader["col_mol_full_name"]),
                    };
                    rowsMainChange.Add(row);
                }
                sqlConnection.Close();
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (dataReader != null && !dataReader.IsClosed)
                {
                    dataReader.Close();
                }
            }
            if (comboBoxDepartment.Text != "")
            {
                comboBoxMOL.Text = rowsMainChange[0][0].ToString();
            }
        }

        private void FillComboBoxes_ItamNumber_Model_EquipmentManufacturer_EquipmentType()
        {
            rowsMainChange.Clear();
            MySqlDataReader dataReader = null;
            string[] row;
            try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("SELECT tb_itam_number.equipment_model_name, tb_equipment_manufacturer.col_equipment_manufacturer_name, tb_type_equipment.col_type_equipment_name " +
                                                            "FROM tb_itam_number " +
                                                            "JOIN tb_equipment_model " +
                                                            "ON tb_itam_number.equipment_model_name = tb_equipment_model.equipment_model_name " +
                                                            "JOIN tb_equipment_manufacturer " +
                                                            "ON tb_equipment_model.id_equipment_manufacturer = tb_equipment_manufacturer.id_equipment_manufacturer " +
                                                            "JOIN tb_type_equipment " +
                                                            "ON tb_equipment_model.id_type_equipment = tb_type_equipment.id_type_equipment " +
                                                            "WHERE tb_itam_number.item_number=@itamNumber", sqlConnection);

                sqlCommand.Parameters.Add("@itamNumber", MySqlDbType.VarChar).Value = comboBoxItamNumber.Text;

                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    row = new string[]
                    {
                        Convert.ToString(dataReader["equipment_model_name"]),
                        Convert.ToString(dataReader["col_equipment_manufacturer_name"]),
                        Convert.ToString(dataReader["col_type_equipment_name"])

                    };
                    rowsMainChange.Add(row);
                }
                sqlConnection.Close();
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (dataReader != null && !dataReader.IsClosed)
                {
                    dataReader.Close();
                }
            }
            if (comboBoxItamNumber.Text != "")
            {
                comboBoxModel.Text = rowsMainChange[0][0].ToString();
                comboBoxEquipmentManufacturer.Text = rowsMainChange[0][1].ToString();
                comboBoxEquipmentType.Text = rowsMainChange[0][2].ToString();
            }
        }


        private void comboBoxKeyPress(object sender, KeyPressEventArgs e)
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

        private void comboBoxLocation_KeyPress(object sender, KeyPressEventArgs e)
        {
            comboBoxKeyPress(sender, e);
        }

        private void comboBoxDepartment_KeyPress(object sender, KeyPressEventArgs e)
        {
            comboBoxKeyPress(sender, e);
        }

        private void comboBoxMOL_KeyPress(object sender, KeyPressEventArgs e)
        {
            comboBoxKeyPress(sender, e);
        }

        private void comboBoxItamNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            comboBoxKeyPress(sender, e);
        }

        private void comboBoxModel_KeyPress(object sender, KeyPressEventArgs e)
        {
            comboBoxKeyPress(sender, e);
        }

        private void comboBoxEquipmentManufacturer_KeyPress(object sender, KeyPressEventArgs e)
        {
            comboBoxKeyPress(sender, e);
        }

        private void comboBoxEquipmentType_KeyPress(object sender, KeyPressEventArgs e)
        {
            comboBoxKeyPress(sender, e);
        }

        private void comboBoxStuff_KeyPress(object sender, KeyPressEventArgs e)
        {
            comboBoxKeyPress(sender, e);
        }

        private void FillComboBoxLocation()
        {
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
                comboBoxLocation.DisplayMember = "col_location_name";
                comboBoxLocation.ValueMember = "id_col_location";
                comboBoxLocation.DataSource = ds.Tables["Fleet"];
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("Error occured!");
            }
        }

        private void FillComboBoxDepartment()
        {
            MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["inventory"].ConnectionString);
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM tb_mol", sqlConnection);
                //SqlDataAdapter da = new SqlDataAdapter(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable table = new DataTable();
                adapter.SelectCommand = command;


                sqlConnection.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Fleet");
                comboBoxDepartment.DisplayMember = "mol_department";
                comboBoxDepartment.ValueMember = "mol_department";
                comboBoxDepartment.DataSource = ds.Tables["Fleet"];
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("Error occured!");
            }
        }

        private void FillComboBoxMOL()
        {
            MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["inventory"].ConnectionString);
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM tb_mol", sqlConnection);
                //SqlDataAdapter da = new SqlDataAdapter(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable table = new DataTable();
                adapter.SelectCommand = command;


                sqlConnection.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Fleet");
                comboBoxMOL.DisplayMember = "col_mol_full_name";
                comboBoxMOL.ValueMember = "mol_department";
                comboBoxMOL.DataSource = ds.Tables["Fleet"];
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("Error occured!");
            }
        }

        private void FillComboBoxItamNumber()
        {
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
                comboBoxItamNumber.DisplayMember = "item_number";
                comboBoxItamNumber.ValueMember = "item_number";
                comboBoxItamNumber.DataSource = ds.Tables["Fleet"];
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("Error occured!");
            }
        }

        private void FillComboBoxModel()
        {
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
                comboBoxModel.DisplayMember = "equipment_model_name";
                comboBoxModel.ValueMember = "equipment_model_name";
                comboBoxModel.DataSource = ds.Tables["Fleet"];
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("Error occured!");
            }
        }

        private void FillComboBoxEquipmentManufacturer()
        {
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
                comboBoxEquipmentManufacturer.DisplayMember = "col_equipment_manufacturer_name";
                comboBoxEquipmentManufacturer.ValueMember = "id_equipment_manufacturer";
                comboBoxEquipmentManufacturer.DataSource = ds.Tables["Fleet"];
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("Error occured!");
            }
        }
        private void FillComboBoxEquipmentType()
        {
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
                comboBoxEquipmentType.DisplayMember = "col_type_equipment_name";
                comboBoxEquipmentType.ValueMember = "id_type_equipment";
                comboBoxEquipmentType.DataSource = ds.Tables["Fleet"];
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("Error occured!");
            }
        }

        private void FillComboBoxStuff()
        {
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
                comboBoxStuff.DisplayMember = "col_full_name_staff";
                comboBoxStuff.ValueMember = "login_authorization_staff";
                comboBoxStuff.DataSource = ds.Tables["Fleet"];
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("Error occured!");
            }
        }

        private void buttonMainChange_Click(object sender, EventArgs e)
        {
            if (comboBoxLocation.Text == "" ||
                comboBoxDepartment.Text == "" || comboBoxItamNumber.Text == "" ||
                comboBoxStuff.Text == "")
            {
                MessageBox.Show("Все поля должны быть заполенны !");
                return;
            }

            /////////////////////////////////////////////////////////////////////////////
            //MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["journal"].ConnectionString);
            string query = "UPDATE `tb_main` " +
                "SET `id_col_location`=@id_col_location, `col_date`=@col_date, `mol_department`=@mol_department, `item_number`=@item_number, `login_authorization_staff`=@login_authorization_staff " +
                "WHERE invent_number = @invent_number";

            MySqlCommand commandDatabase = new MySqlCommand(query, sqlConnection);

            commandDatabase.Parameters.Add("@invent_number", MySqlDbType.VarChar).Value = textBoxInventNumberBuff;
            commandDatabase.Parameters.Add("@id_col_location", MySqlDbType.VarChar).Value = comboBoxLocation.SelectedValue.ToString();
            commandDatabase.Parameters.Add("@col_date", MySqlDbType.VarChar).Value = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            commandDatabase.Parameters.Add("@mol_department", MySqlDbType.VarChar).Value = comboBoxDepartment.SelectedValue.ToString();
            commandDatabase.Parameters.Add("@item_number", MySqlDbType.VarChar).Value = comboBoxItamNumber.SelectedValue.ToString();
            commandDatabase.Parameters.Add("@login_authorization_staff", MySqlDbType.VarChar).Value = comboBoxStuff.SelectedValue.ToString();

            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            //if (textBoxAccountManagementUserPassword.TextLength >= 5)
            {
                try
                {
                    sqlConnection.Open();
                    reader = commandDatabase.ExecuteReader();
                    // Succesfully updated
                    sqlConnection.Close();
                    MessageBox.Show("Оборудование изменено!", "Уведомление");
                    this.Close();
                }
                catch (Exception ex)
                {
                    // Ops, maybe the id doesn't exists ?
                    MessageBox.Show(ex.Message);
                }
            }
            //else MessageBox.Show("Пароль пользователя слишком короткий!\nMинимум 5 знаков!", "Ошибка");
        }

        private void comboBoxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillComboBoxes_Department_MOL();
        }

        private void comboBoxItamNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillComboBoxes_ItamNumber_Model_EquipmentManufacturer_EquipmentType();
        }

        private void FormMainChange_Load(object sender, EventArgs e)
        {
            comboBoxItamNumber.DropDownHeight = 200;
            textBoxInventNumber.Text = textBoxInventNumberBuff;
            comboBoxLocation.Text = comboBoxLocationBuff;
            dateTimePicker1.Text = dateTimePicker1Buff;
            comboBoxDepartment.Text = comboBoxDepartmentBuff;
            comboBoxMOL.Text = comboBoxMOLBuff;
            comboBoxItamNumber.Text = comboBoxItamNumberBuff;
            comboBoxModel.Text = comboBoxModelBuff;
            comboBoxEquipmentManufacturer.Text = comboBoxEquipmentManufacturerBuff;
            comboBoxEquipmentType.Text = comboBoxEquipmentTypeBuff;
            comboBoxStuff.Text = comboBoxStuffBuff;
        }
    }


}
