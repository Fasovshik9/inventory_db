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
    public partial class FormItamNumberAddNew : Form
    {

        private List<string[]> filteredList = null;
        private List<string[]> rowsItamNumber = new List<string[]>();
        MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["inventory"].ConnectionString);

        const string phraseFullItamNumber = "Номенклатурный артикуль";


        public FormItamNumberAddNew()
        {
            InitializeComponent();
            FillComboBoxEquipmentManufacturer();
            FillComboBoxEquipmentType();
            FillComboBoxModel();
        }

        private void buttonAddNewItamNumber_Click(object sender, EventArgs e)
        {
            if (textBoxItamNumber.Text == phraseFullItamNumber || comboBoxModel.Text == "" || comboBoxEquipmentType.Text == "" || comboBoxEquipmentManufacturer.Text == "")
            {
                MessageBox.Show("Все поля должны быть заполенны !");
                return;
            }
            if (textBoxItamNumber.TextLength <= 1 && textBoxItamNumber.TextLength >= 20)
            {

                MessageBox.Show("Номенклатурный артикуль слишком короткий!\nМинимум 5 знаков!", "Ошибка");
                //zeroFildPass();
                return;
            }

            ///////////////////////////////////////////////////////////////////////////// check new user to reapit
            MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["inventory"].ConnectionString);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT tb_itam_number.item_number, tb_equipment_model.equipment_model_name " +
                                                    "FROM tb_itam_number  " +
                                                    "JOIN tb_equipment_model " +
                                                    "ON tb_itam_number.equipment_model_name = tb_equipment_model.equipment_model_name " +
                                                    "WHERE tb_itam_number.item_number = @item_number and tb_equipment_model.equipment_model_name = @equipment_model_name", sqlConnection);

            command.Parameters.Add("@item_number", MySqlDbType.VarChar).Value = textBoxItamNumber.Text;
            command.Parameters.Add("@equipment_model_name", MySqlDbType.VarChar).Value = comboBoxModel.SelectedValue.ToString();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Номенклатурный артикуль с такой моделью уже существует!\nИзменить название модели!", "Ошибка");
                return;
            }
            /////////////////////////////////////////////////////////////////////////////
            string query = "INSERT INTO tb_itam_number(`item_number`, `equipment_model_name`) " +
                           "VALUES (@item_number, @equipment_model_name)";
            MySqlCommand commandDatabase = new MySqlCommand(query, sqlConnection);

            commandDatabase.Parameters.Add("@item_number", MySqlDbType.VarChar).Value = textBoxItamNumber.Text;
            commandDatabase.Parameters.Add("@equipment_model_name", MySqlDbType.VarChar).Value = comboBoxModel.SelectedValue.ToString();


            commandDatabase.CommandTimeout = 60;
            //if (textBoxlAccountManagementUserLogin.TextLength <= 12 && textBoxlAccountManagementUserLogin.TextLength >= 5)
            {
                //if (textBoxAccountManagementUserPassword.TextLength >= 5)
                {
                    try
                    {
                        sqlConnection.Open();
                        MySqlDataReader myReader = commandDatabase.ExecuteReader();
                        MessageBox.Show("Номенклатурный артикуль успешно добавлен!", "Уведомление");
                        sqlConnection.Close();
                    }
                    catch (Exception ex)
                    {
                        // Show any error message.
                        MessageBox.Show(ex.Message);
                    }
                    this.Close();
                }
                //else MessageBox.Show("Пароль пользователя слишком короткий!\nМинимум 5 знаков!", "Ошибка");
            }
            //else MessageBox.Show("Некоректное имя пользователя!\nМинимум 5 знаков и максимум 12!", "Ошибка");
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

        private void FillComboBoxModel()
        {
            MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["inventory"].ConnectionString);
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT tb_equipment_model.equipment_model_name FROM tb_equipment_model", sqlConnection);
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

        private void comboBoxModel_KeyPress(object sender, KeyPressEventArgs e)
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

        private void FillComboBoxes()
        {
            rowsItamNumber.Clear();
            MySqlDataReader dataReader = null;
            string[] row;
            try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("SELECT col_equipment_manufacturer_name, col_type_equipment_name " +
                                                            "FROM tb_equipment_model " +
                                                            "JOIN tb_equipment_manufacturer " +
                                                            "ON tb_equipment_model.id_equipment_manufacturer = tb_equipment_manufacturer.id_equipment_manufacturer " +
                                                            "JOIN tb_type_equipment " +
                                                            "ON tb_equipment_model.id_type_equipment = tb_type_equipment.id_type_equipment " +
                                                            "WHERE tb_equipment_model.equipment_model_name=@equipment_model_name ", sqlConnection);

                sqlCommand.Parameters.Add("@equipment_model_name", MySqlDbType.VarChar).Value = comboBoxModel.Text;

                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    row = new string[]
                    {
                        Convert.ToString(dataReader["col_equipment_manufacturer_name"]),
                        Convert.ToString(dataReader["col_type_equipment_name"])
                    };
                    rowsItamNumber.Add(row);
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
            if (comboBoxModel.Text != "")
            {
                comboBoxEquipmentManufacturer.Text = rowsItamNumber[0][0].ToString();
                comboBoxEquipmentType.Text = rowsItamNumber[0][1].ToString();
            }
        }


        private void buttonCencel_Click(object sender, EventArgs e)
        {
            rowsItamNumber.Clear();
            MySqlDataReader dataReader = null;
            string[] row;
            try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("SELECT col_equipment_manufacturer_name, col_type_equipment_name " +
                                                            "FROM tb_equipment_model " +
                                                            "JOIN tb_equipment_manufacturer " +
                                                            "ON tb_equipment_model.id_equipment_manufacturer = tb_equipment_manufacturer.id_equipment_manufacturer " +
                                                            "JOIN tb_type_equipment " +
                                                            "ON tb_equipment_model.id_type_equipment = tb_type_equipment.id_type_equipment " +
                                                            "WHERE tb_equipment_model.equipment_model_name=@equipment_model_name ", sqlConnection);

                sqlCommand.Parameters.Add("@equipment_model_name", MySqlDbType.VarChar).Value = comboBoxModel.Text;

                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    row = new string[]
                    {
                        Convert.ToString(dataReader["col_equipment_manufacturer_name"]),
                        Convert.ToString(dataReader["col_type_equipment_name"])
                    };
                    rowsItamNumber.Add(row);
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
            if (comboBoxModel.Text == "")
            {
                comboBoxEquipmentManufacturer.Text = rowsItamNumber[0][0].ToString();
                comboBoxEquipmentType.Text = rowsItamNumber[0][1].ToString();
            }

        }

        private void comboBoxModel_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            FillComboBoxes();
        }

        private void comboBoxModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillComboBoxes();
        }
    }
}
