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
    public partial class FormEquipment : Form
    {

        private List<string[]> filteredList = null;
        private List<string[]> rowsEquipment = new List<string[]>();
        MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["inventory"].ConnectionString);


        const string phraseEquipment = "Введите тип оборудования";
        private string EquipmentBuffType;
        private string EquipmentTypeMouse;


        public FormEquipment()
        {
            InitializeComponent();
            RefreshlistViewEquipment();
            zeroFildEquipment();

            columnEquipmentName.Width = 400;
        }


        private void RefreshlistViewEquipment(List<string[]> list)
        {
            listViewEquipment.Items.Clear();
            foreach (string[] s in list)
            {
                listViewEquipment.Items.Add(new ListViewItem(s));
            }
        }

        private void RefreshlistViewEquipment()
        {
            rowsEquipment.Clear();
            MySqlDataReader dataReader = null;
            string[] row;
            try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("SELECT equipment_name " +
                                                           "FROM type_equipment ", sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    row = new string[]
                    {
                        Convert.ToString(dataReader["equipment_name"]),
                    };
                    rowsEquipment.Add(row);
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
            listViewEquipment.Items.Clear();
            foreach (string[] s in rowsEquipment)
            {
                listViewEquipment.Items.Add(new ListViewItem(s));
            }
        }



        private void buttonAddNewEquipment_Click(object sender, EventArgs e)
        {
            if (textBoxAddNewEquipment.Text == phraseEquipment)
            {
                MessageBox.Show("Введите название локации!");
                return;
            }
            if (textBoxAddNewEquipment.TextLength >= 50)
            {
                MessageBox.Show("Некоректное название локации!\nМаксимум 50!", "Ошибка");
                zeroFildEquipment();
                return;
            }
            else { }

            ///////////////////////////////////////////////////////////////////////////// check new user to reapit
            MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["inventory"].ConnectionString);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `type_equipment` WHERE equipment_name = @equipment_name", sqlConnection);
            command.Parameters.Add("@equipment_name", MySqlDbType.VarChar).Value = textBoxAddNewEquipment.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Этот тип уже существует!\nИзменить название типа!", "Ошибка");
                return;
            }
            /////////////////////////////////////////////////////////////////////////////

            string query = "INSERT INTO type_equipment(`equipment_name`) " +
                "VALUES (@equipment_name)";
            MySqlCommand commandDatabase = new MySqlCommand(query, sqlConnection);

            commandDatabase.Parameters.Add("@equipment_name", MySqlDbType.VarChar).Value = textBoxAddNewEquipment.Text;

            commandDatabase.CommandTimeout = 60;
            //if (textBoxlAccountManagementUserLogin.TextLength <= 12 && textBoxlAccountManagementUserLogin.TextLength >= 5)
            {
                //if (textBoxAccountManagementUserPassword.TextLength >= 5)
                {
                    try
                    {
                        sqlConnection.Open();
                        MySqlDataReader myReader = commandDatabase.ExecuteReader();
                        MessageBox.Show("Тип успешно добавлена!", "Уведомление");
                        sqlConnection.Close();
                        zeroFildEquipment();
                    }
                    catch (Exception ex)
                    {
                        // Show any error message.
                        MessageBox.Show(ex.Message);
                    }
                }
                //else MessageBox.Show("Пароль пользователя слишком короткий!\nМинимум 5 знаков!", "Ошибка");
            }
            //else MessageBox.Show("Некоректное имя пользователя!\nМинимум 5 знаков и максимум 12!", "Ошибка");
        }

        private void FormEquipment_Activated(object sender, EventArgs e)
        {
            RefreshlistViewEquipment();
        }

        private void buttonEmptyFilter_Click(object sender, EventArgs e)
        {
            textBoxFilter.Text = "";
            RefreshlistViewEquipment();
        }

        private void buttonDeleteEquipment_Click(object sender, EventArgs e)
        {
            if (this.listViewEquipment.SelectedItems.Count != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить тип?", "Удаление типа", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string query = "DELETE FROM `type_equipment` WHERE `equipment_name` = @equipment_name";
                    MySqlCommand commandDatabase = new MySqlCommand(query, sqlConnection);
                    commandDatabase.Parameters.Add("@equipment_name", MySqlDbType.VarChar).Value = EquipmentTypeMouse;

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
                    RefreshlistViewEquipment();
                }
            }
            else
            {
                MessageBox.Show("Выберете тип!", "Ошибка");
            }
        }

        private void listViewEquipment_MouseDown(object sender, MouseEventArgs e)
        {
            {
                ListViewHitTestInfo info = listViewEquipment.HitTest(e.X, e.Y);
                ListViewItem item = info.Item;

                if (item != null)
                {
                    this.EquipmentTypeMouse = item.SubItems[0].Text;
                }
                else
                {
                    this.listViewEquipment.SelectedItems.Clear();
                }
            }
        }

        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            filteredList = rowsEquipment.Where(x =>
                (x[0].ToLower().Contains(textBoxFilter.Text.ToLower()))
                ).ToList();
            RefreshlistViewEquipment(filteredList);
        }

        private void textBoxAddNewEquipment_Enter(object sender, EventArgs e)
        {
            if (textBoxAddNewEquipment.Text == phraseEquipment)
            {
                textBoxAddNewEquipment.Text = "";
                textBoxAddNewEquipment.ForeColor = Color.Black;
            }
        }

        private void textBoxAddNewEquipment_Leave(object sender, EventArgs e)
        {
            if (textBoxAddNewEquipment.Text == "")
            {
                zeroFildEquipment();
            }
        }

        private void zeroFildEquipment()
        {
            textBoxAddNewEquipment.Text = phraseEquipment;
            textBoxAddNewEquipment.ForeColor = Color.Gray;
        }

        private void buttonChangeEquipment_Click(object sender, EventArgs e)
        {
            methodChangeEquipment();
        }

        private void methodChangeEquipment()
        {

            if (buttonChangeEquipment.Text == "Изменить")
            {
                if (this.listViewEquipment.SelectedItems.Count != 0)
                {
                    textBoxChangeEquipment.Text = EquipmentTypeMouse;
                    buttonChangeEquipment.Text = "Применить";
                    textBoxChangeEquipment.Visible = true;
                    EquipmentBuffType = EquipmentTypeMouse;
                    RefreshlistViewEquipment();
                }
                else
                {
                    MessageBox.Show("Выберете тип!", "Ошибка");
                }
            }
            else
            {

                ///////////////////////////////////////////////////////////////////////////// check new user to reapit
                MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["inventory"].ConnectionString);
                //DataTable table = new DataTable();
                //MySqlDataAdapter adapter = new MySqlDataAdapter();
                //MySqlCommand command = new MySqlCommand("SELECT * FROM `location` WHERE location_name = @location_name", sqlConnection);
                //command.Parameters.Add("@location_name", MySqlDbType.VarChar).Value = textBoxChangeLocation.Text;

                //adapter.SelectCommand = command;
                //adapter.Fill(table);


                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT * FROM `type_equipment` WHERE equipment_name = @equipment_name", sqlConnection);
                command.Parameters.Add("@equipment_name", MySqlDbType.VarChar).Value = textBoxChangeEquipment.Text;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Этот тип уже существует!\nИзмените тип!", "Ошибка");
                    return;
                }


                /////////////////////////////////////////////////////////////////////////////
                string location = textBoxChangeEquipment.Text;

                //MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["journal"].ConnectionString);
                string query = "UPDATE `type_equipment` " +
                    "SET `equipment_name`=@equipment_name " +
                    "WHERE equipment_name = @equipment_old_name";

                MySqlCommand commandDatabase = new MySqlCommand(query, sqlConnection);
                commandDatabase.Parameters.Add("@equipment_name", MySqlDbType.VarChar).Value = location;
                commandDatabase.Parameters.Add("@equipment_old_name", MySqlDbType.VarChar).Value = EquipmentBuffType;

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
                        MessageBox.Show("Тип изменён!", "Уведомление");
                        buttonChangeEquipment.Text = "Изменить";
                        textBoxChangeEquipment.Visible = false;
                        RefreshlistViewEquipment();
                    }
                    catch (Exception ex)
                    {
                        // Ops, maybe the id doesn't exists ?
                        MessageBox.Show(ex.Message);
                    }
                }
                //else MessageBox.Show("Пароль пользователя слишком короткий!\nMинимум 5 знаков!", "Ошибка");
            }

        }

        private void buttonCencel_Click(object sender, EventArgs e)
        {
            zeroFildEquipment();
            textBoxChangeEquipment.Visible = false;
        }
    }
}
