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
    public partial class FormEquipmentModelChange : Form
    {
        private List<string[]> filteredList = null;
        private List<string[]> rowsEquipmentModel = new List<string[]>();

        public string EquipmentModelBuff;
        public string EquipmentManufacturerBuff;
        public string EquipmentTypeBuff;
        const string phraseEquipmentModelChange = "Введите модель";


        public FormEquipmentModelChange()
        {
            InitializeComponent();
            FillComboBoxEquipmentManufacturer();
            FillComboBoxEquipmentType();
        }

        private void buttonCencel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAEquipmentModelChange_Click(object sender, EventArgs e)
        {
            if (comboBoxEquipmentManufacturer.Text == "" || comboBoxEquipmentType.Text == "" || textBoxEquipmentModelChange.Text == phraseEquipmentModelChange)
            {
                MessageBox.Show("Все поля должны быть заполенны !");
                return;
            }
            if (textBoxEquipmentModelChange.TextLength >= 40)
            {

                MessageBox.Show("Название модели слишком длинное!\nМаксимум 40 знаков!", "Ошибка");
                //zeroFildPass();
                return;
            }

            ///////////////////////////////////////////////////////////////////////////// check new user to reapit
            MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["inventory"].ConnectionString);
            if (textBoxEquipmentModelChange.Text != EquipmentModelBuff)
            { 
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT * FROM `tb_equipment_model` WHERE equipment_model_name = @equipment_model_name", sqlConnection);
                command.Parameters.Add("@equipment_model_name", MySqlDbType.VarChar).Value = textBoxEquipmentModelChange.Text;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Такая модель уже существует!\nИзменить название модели!", "Ошибка");
                    return;
                }
            }

            /////////////////////////////////////////////////////////////////////////////
            //MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["journal"].ConnectionString);
            string query = "UPDATE `tb_equipment_model` " +
                "SET `equipment_model_name`=@equipment_model_name,`id_equipment_manufacturer`=@id_equipment_manufacturer,`id_type_equipment`=@id_type_equipment " +
                "WHERE equipment_model_name = @equipment_old_model_name";

            MySqlCommand commandDatabase = new MySqlCommand(query, sqlConnection);
            commandDatabase.Parameters.Add("@id_equipment_manufacturer", MySqlDbType.VarChar).Value = comboBoxEquipmentManufacturer.SelectedValue.ToString();
            commandDatabase.Parameters.Add("@equipment_model_name", MySqlDbType.VarChar).Value = textBoxEquipmentModelChange.Text;
            commandDatabase.Parameters.Add("@equipment_old_model_name", MySqlDbType.VarChar).Value = EquipmentModelBuff;
            commandDatabase.Parameters.Add("@id_type_equipment", MySqlDbType.VarChar).Value = comboBoxEquipmentType.SelectedValue.ToString();

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
                    MessageBox.Show("Модель изменена!", "Уведомление");
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



        private void FormEquipmentModelChange_Activated(object sender, EventArgs e)
        {
            
        }

        private void FormEquipmentModelChange_Load(object sender, EventArgs e)
        {
            comboBoxEquipmentManufacturer.Text = EquipmentManufacturerBuff;
            comboBoxEquipmentType.Text = EquipmentTypeBuff;
            textBoxEquipmentModelChange.Text = EquipmentModelBuff;
        }
    }
}
