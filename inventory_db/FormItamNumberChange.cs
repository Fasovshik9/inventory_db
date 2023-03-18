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
    public partial class FormItamNumberChange : Form
    {
        private List<string[]> filteredList = null;
        private List<string[]> rowsItamNumber = new List<string[]>();
        MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["inventory"].ConnectionString);

        const string phraseFullItamNumber = "Номенклатурный артикуль";


        public string rowsItamNumberMouseBuff;
        public string rowsEquipmentModelMouseBuff;
        public string rowsEquipmentManufacturerMouseBuff;
        public string rowsEquipmentTypeMouseBuff;

        const string phraseEquipmentModelChange = "Номенклатурный номер";

        public FormItamNumberChange()
        {
            InitializeComponent();
            FillComboBoxEquipmentManufacturer();
            FillComboBoxEquipmentType();
            FillComboBoxModel();
        }

        private void buttonItamNumberChange_Click(object sender, EventArgs e)
        {
            if (textBoxItamNumberChange.Text == phraseFullItamNumber || comboBoxModelChange.Text == "" || comboBoxEquipmentTypeChange.Text == "" || comboBoxEquipmentManufacturerChange.Text == "")
            {
                MessageBox.Show("Все поля должны быть заполенны !");
                return;
            }
            if (textBoxItamNumberChange.TextLength <= 1 && textBoxItamNumberChange.TextLength >= 20)
            {

                MessageBox.Show("Номенклатурный артикуль слишком длинный!\nМаксимум 20 знаков!", "Ошибка");
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

            command.Parameters.Add("@item_number", MySqlDbType.VarChar).Value = textBoxItamNumberChange.Text;
            command.Parameters.Add("@equipment_model_name", MySqlDbType.VarChar).Value = comboBoxModelChange.SelectedValue.ToString();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Номенклатурный артикуль с такой моделью уже существует!\nИзменить название модели или номеклатурного артикуля!", "Ошибка");
                return;
            }

            /////////////////////////////////////////////////////////////////////////////
            if (textBoxItamNumberChange.Text != rowsItamNumberMouseBuff)
            {
                MySqlConnection sqlConnection2 = new MySqlConnection(ConfigurationManager.ConnectionStrings["inventory"].ConnectionString);
                DataTable table2 = new DataTable();
                MySqlDataAdapter adapter2 = new MySqlDataAdapter();
                MySqlCommand command2 = new MySqlCommand("SELECT *" +
                                                        "FROM tb_itam_number  " +
                                                        "WHERE item_number = @item_number2 ", sqlConnection2);

                command2.Parameters.Add("@item_number2", MySqlDbType.VarChar).Value = textBoxItamNumberChange.Text;

                adapter2.SelectCommand = command2;
                adapter2.Fill(table2);

                if (table2.Rows.Count > 0)
                {
                    MessageBox.Show("Такой номенклатурный артикуль уже существует!\nИзменить номенклатурный артикуль!", "Ошибка");
                    return;
                }
            }

            /////////////////////////////////////////////////////////////////////////////
            //MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["journal"].ConnectionString);
            string query = "UPDATE `tb_itam_number` " +
                "SET `item_number`=@item_number,`equipment_model_name`=@equipment_model_name " +
                "WHERE item_number = @item_old_number";

            MySqlCommand commandDatabase = new MySqlCommand(query, sqlConnection);
            commandDatabase.Parameters.Add("@item_number", MySqlDbType.VarChar).Value = textBoxItamNumberChange.Text;
            commandDatabase.Parameters.Add("@equipment_model_name", MySqlDbType.VarChar).Value = comboBoxModelChange.SelectedValue.ToString();
            commandDatabase.Parameters.Add("@item_old_number", MySqlDbType.VarChar).Value = rowsItamNumberMouseBuff;

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
                    MessageBox.Show("Номенклатурный артикуль изменент!", "Уведомление");
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

        private void comboBoxModelChange_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyPress(sender, e);
        }


        private void keyPress(object sender, KeyPressEventArgs e)
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

        private void comboBoxEquipmentManufacturerChange_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyPress(sender, e);
        }

        private void comboBoxEquipmentTypeChange_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyPress(sender, e);
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
                comboBoxEquipmentManufacturerChange.DisplayMember = "col_equipment_manufacturer_name";
                comboBoxEquipmentManufacturerChange.ValueMember = "id_equipment_manufacturer";
                comboBoxEquipmentManufacturerChange.DataSource = ds.Tables["Fleet"];
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
                comboBoxEquipmentTypeChange.DisplayMember = "col_type_equipment_name";
                comboBoxEquipmentTypeChange.ValueMember = "id_type_equipment";
                comboBoxEquipmentTypeChange.DataSource = ds.Tables["Fleet"];
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
                comboBoxModelChange.DisplayMember = "equipment_model_name";
                comboBoxModelChange.ValueMember = "equipment_model_name";
                comboBoxModelChange.DataSource = ds.Tables["Fleet"];
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("Error occured!");
            }
        }

        private void FormItamNumberChange_Load(object sender, EventArgs e)
        {
            textBoxItamNumberChange.Text = rowsItamNumberMouseBuff;
            comboBoxModelChange.Text = rowsEquipmentModelMouseBuff;
            comboBoxEquipmentManufacturerChange.Text = rowsEquipmentManufacturerMouseBuff;
            comboBoxEquipmentTypeChange.Text = rowsEquipmentTypeMouseBuff;
        }

        private void buttonCencel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
