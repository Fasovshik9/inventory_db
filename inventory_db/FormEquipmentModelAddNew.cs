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
    public partial class FormEquipmentModelAddNew : Form
    {
        private List<string[]> filteredList = null;
        private List<string[]> rowsEquipmentModel = new List<string[]>();
        //MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["inventory"].ConnectionString);
        const string phraseFullEquipmentModelAddNew = "Введите модель";




        public FormEquipmentModelAddNew()
        {
            InitializeComponent();
            FillComboBoxEquipmentManufacturer();
            FillComboBoxEquipmentType();
            zerophraseEquipmentModelAddNew();

        }

        private void buttonAddNewEquipmentModel_Click(object sender, EventArgs e)
        {
            if (textBoxEquipmentModelAddNew.Text == phraseFullEquipmentModelAddNew || comboBoxEquipmentManufacturer.Text == "" || comboBoxEquipmentType.Text == "")
            {
                MessageBox.Show("Все поля должны быть заполенны !");
                return;
            }
            if (textBoxEquipmentModelAddNew.TextLength <= 1 && textBoxEquipmentModelAddNew.TextLength >= 20)
            {

                MessageBox.Show("Название модели слишком длинное!\nМаксимум 20 знаков!", "Ошибка");
                //zeroFildPass();
                return;
            }

            ///////////////////////////////////////////////////////////////////////////// check new user to reapit
            MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["inventory"].ConnectionString);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM tb_equipment_model WHERE equipment_model_name = @equipment_model_name", sqlConnection);

            command.Parameters.Add("@equipment_model_name", MySqlDbType.VarChar).Value = textBoxEquipmentModelAddNew.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такая модель уже существует!\nИзменить название модели!", "Ошибка");
                return;
            }
            /////////////////////////////////////////////////////////////////////////////
            string query = "INSERT INTO tb_equipment_model(`equipment_model_name`, `id_equipment_manufacturer`, `id_type_equipment`) " +
                "VALUES (@equipment_model_name, @id_equipment_manufacturer, @id_type_equipment)";
            MySqlCommand commandDatabase = new MySqlCommand(query, sqlConnection);

            commandDatabase.Parameters.Add("@equipment_model_name", MySqlDbType.VarChar).Value = textBoxEquipmentModelAddNew.Text;
            commandDatabase.Parameters.Add("@id_equipment_manufacturer", MySqlDbType.VarChar).Value = comboBoxEquipmentManufacturer.SelectedValue.ToString();
            commandDatabase.Parameters.Add("@id_type_equipment", MySqlDbType.VarChar).Value = comboBoxEquipmentType.SelectedValue.ToString();

            commandDatabase.CommandTimeout = 60;
            //if (textBoxlAccountManagementUserLogin.TextLength <= 12 && textBoxlAccountManagementUserLogin.TextLength >= 5)
            {
                //if (textBoxAccountManagementUserPassword.TextLength >= 5)
                {
                    try
                    {
                        sqlConnection.Open();
                        MySqlDataReader myReader = commandDatabase.ExecuteReader();
                        MessageBox.Show("Модель успешно добавлен!", "Уведомление");
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

        private void buttonCencel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxEquipmentManufacturer_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBoxEquipmentManufacturer_KeyPress(object sender, KeyPressEventArgs e)
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

        private void comboBoxEquipmentType_KeyPress(object sender, KeyPressEventArgs e)
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


        private void zerophraseEquipmentModelAddNew()
        {
            textBoxEquipmentModelAddNew.Text = phraseFullEquipmentModelAddNew;
            textBoxEquipmentModelAddNew.ForeColor = Color.Gray;
        }

        private void textBoxEquipmentModelAddNew_Enter(object sender, EventArgs e)
        {
            if (textBoxEquipmentModelAddNew.Text == phraseFullEquipmentModelAddNew)
            {
                textBoxEquipmentModelAddNew.Text = "";
                textBoxEquipmentModelAddNew.ForeColor = Color.Black;
            }
        }

        private void textBoxEquipmentModelAddNew_Leave(object sender, EventArgs e)
        {
            if (textBoxEquipmentModelAddNew.Text == "")
            {
                zerophraseEquipmentModelAddNew();
            }
        }
    }
}
