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
    public partial class FormEquipmentManufacturer : Form
    {

        private List<string[]> filteredList = null;
        private List<string[]> rowsEquipmentManufacturer = new List<string[]>();
        MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["inventory"].ConnectionString);


        const string phraseEquipmentManufacturer = "Введите производителя оборудования";
        private string EquipmentManufacturerBuffName;
        private string EquipmentManufacturerMameMouse;



        public FormEquipmentManufacturer()
        {
            InitializeComponent();
            RefreshlistViewEquipmentManufacturer();
            zeroFildEquipmentManufacturer();
            columnEquipmentManufacturer.Width = 400;
        }

        private void buttonAddNewEquipmentManufacturer_Click(object sender, EventArgs e)
        {
            if (textBoxAddNewEquipmentManufacturer.Text == phraseEquipmentManufacturer)
            {
                MessageBox.Show("Введите производителя!");
                return;
            }
            if (textBoxAddNewEquipmentManufacturer.TextLength >= 40)
            {
                MessageBox.Show("Некоректное название производителя!\nМаксимум 40!", "Ошибка");
                return;
            }
            else { }

            ///////////////////////////////////////////////////////////////////////////// check new user to reapit
            MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["inventory"].ConnectionString);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `tb_equipment_manufacturer` WHERE col_equipment_manufacturer_name = @col_equipment_manufacturer_name", sqlConnection);
            command.Parameters.Add("@col_equipment_manufacturer_name", MySqlDbType.VarChar).Value = textBoxAddNewEquipmentManufacturer.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Этот производитель уже существует!\nИзменить название производителя!", "Ошибка");
                return;
            }
            /////////////////////////////////////////////////////////////////////////////
            string EquipmentManufacturerName = textBoxAddNewEquipmentManufacturer.Text;

            string query = "INSERT INTO tb_equipment_manufacturer(`col_equipment_manufacturer_name`) " +
                "VALUES (@col_equipment_manufacturer_name)";
            MySqlCommand commandDatabase = new MySqlCommand(query, sqlConnection);

            commandDatabase.Parameters.Add("@col_equipment_manufacturer_name", MySqlDbType.VarChar).Value = EquipmentManufacturerName;

            commandDatabase.CommandTimeout = 60;
            //if (textBoxlAccountManagementUserLogin.TextLength <= 12 && textBoxlAccountManagementUserLogin.TextLength >= 5)
            {
                //if (textBoxAccountManagementUserPassword.TextLength >= 5)
                {
                    try
                    {
                        sqlConnection.Open();
                        MySqlDataReader myReader = commandDatabase.ExecuteReader();
                        MessageBox.Show("производитель успешно добавлен!", "Уведомление");
                        sqlConnection.Close();
                        zeroFildEquipmentManufacturer();
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

        private void buttonEmptyFilter_Click(object sender, EventArgs e)
        {
            textBoxFilter.Text = "";
            RefreshlistViewEquipmentManufacturer();
        }


        private void RefreshlistViewEquipmentManufacturer(List<string[]> list)
        {
            listViewEquipmentManufacturer.Items.Clear();
            foreach (string[] s in list)
            {
                listViewEquipmentManufacturer.Items.Add(new ListViewItem(s));
            }
        }

        private void RefreshlistViewEquipmentManufacturer()
        {
            rowsEquipmentManufacturer.Clear();
            MySqlDataReader dataReader = null;
            string[] row;
            try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("SELECT col_equipment_manufacturer_name " +
                                                           "FROM tb_equipment_manufacturer ", sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    row = new string[]
                    {
                        Convert.ToString(dataReader["col_equipment_manufacturer_name"]),
                    };
                    rowsEquipmentManufacturer.Add(row);
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
            listViewEquipmentManufacturer.Items.Clear();
            foreach (string[] s in rowsEquipmentManufacturer)
            {
                listViewEquipmentManufacturer.Items.Add(new ListViewItem(s));
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEquipmentManufacturer_Activated(object sender, EventArgs e)
        {
            RefreshlistViewEquipmentManufacturer();
        }

        private void buttonDeleteEquipmentManufacturer_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            if (this.listViewEquipmentManufacturer.SelectedItems.Count != 0)
            {
                //////
                MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["inventory"].ConnectionString);
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT * FROM `tb_equipment_model` " +
                                                        "JOIN tb_equipment_manufacturer " +
                                                        "ON tb_equipment_model.id_equipment_manufacturer = tb_equipment_manufacturer.id_equipment_manufacturer " +
                                                        "WHERE col_equipment_manufacturer_name = @col_equipment_manufacturer_name", sqlConnection);
                command.Parameters.Add("@col_equipment_manufacturer_name", MySqlDbType.VarChar).Value = EquipmentManufacturerMameMouse;

                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    dialogResult = MessageBox.Show("Данный производитель иммется в других таблицах\nПри удалении, удаляться все записи с свзанные с ним!\nВы уверены что хотите удалить производителя?", "Предупреждение", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string query = "DELETE FROM `tb_equipment_manufacturer` WHERE `col_equipment_manufacturer_name` = @col_equipment_manufacturer_name";
                        MySqlCommand commandDatabase = new MySqlCommand(query, sqlConnection);
                        commandDatabase.Parameters.Add("@col_equipment_manufacturer_name", MySqlDbType.VarChar).Value = EquipmentManufacturerMameMouse;

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
                        RefreshlistViewEquipmentManufacturer();
                        return;
                    }
                    else
                        return;
                }

                dialogResult = MessageBox.Show("Вы уверены, что хотите удалить производителя?", "Удаление производителя", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string query = "DELETE FROM `tb_equipment_manufacturer` WHERE `col_equipment_manufacturer_name` = @col_equipment_manufacturer_name";
                    MySqlCommand commandDatabase = new MySqlCommand(query, sqlConnection);
                    commandDatabase.Parameters.Add("@col_equipment_manufacturer_name", MySqlDbType.VarChar).Value = EquipmentManufacturerMameMouse;

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
                    RefreshlistViewEquipmentManufacturer();
                }
            }
            else
            {
                MessageBox.Show("Выберете производителя!", "Ошибка");
            }
        }

        private void listViewEquipmentManufacturer_MouseDown(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = listViewEquipmentManufacturer.HitTest(e.X, e.Y);
            ListViewItem item = info.Item;

            if (item != null)
            {
                this.EquipmentManufacturerMameMouse = item.SubItems[0].Text;
            }
            else
            {
                this.listViewEquipmentManufacturer.SelectedItems.Clear();
            }
        }

        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            filteredList = rowsEquipmentManufacturer.Where(x =>
                (x[0].ToLower().Contains(textBoxFilter.Text.ToLower()))
                ).ToList();
            RefreshlistViewEquipmentManufacturer(filteredList);
        }

        private void textBoxAddNewEquipmentManufacturer_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void textBoxAddNewEquipmentManufacturer_Leave(object sender, EventArgs e)
        {
            if (textBoxAddNewEquipmentManufacturer.Text == "")
            {
                zeroFildEquipmentManufacturer();
            }
        }

        private void zeroFildEquipmentManufacturer()
        {
            textBoxAddNewEquipmentManufacturer.Text = phraseEquipmentManufacturer;
            textBoxAddNewEquipmentManufacturer.ForeColor = Color.Gray;
        }

        private void buttonChangeEquipmentManufacturer_Click(object sender, EventArgs e)
        {
            if (buttonChangeEquipmentManufacturer.Text == "Изменить")
            {
                if (this.listViewEquipmentManufacturer.SelectedItems.Count != 0)
                {
                    textBoxChangeEquipmentManufacturer.Text = EquipmentManufacturerMameMouse;
                    buttonChangeEquipmentManufacturer.Text = "Применить";
                    textBoxChangeEquipmentManufacturer.Visible = true;
                    EquipmentManufacturerBuffName = EquipmentManufacturerMameMouse;
                    RefreshlistViewEquipmentManufacturer();
                }
                else
                {
                    MessageBox.Show("Выберете производителя!", "Ошибка");
                }
            }
            else
            {
                if (textBoxChangeEquipmentManufacturer.TextLength >= 40)
                {
                    MessageBox.Show("Некоректное название производителя!\nМаксимум 40!", "Ошибка");
                    return;
                }
                else { }

                ///////////////////////////////////////////////////////////////////////////// check new user to reapit
                MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["inventory"].ConnectionString);
                //DataTable table = new DataTable();
                //MySqlDataAdapter adapter = new MySqlDataAdapter();
                //MySqlCommand command = new MySqlCommand("SELECT * FROM `EquipmentManufacturer` WHERE col_equipment_manufacturer_name = @col_equipment_manufacturer_name", sqlConnection);
                //command.Parameters.Add("@col_equipment_manufacturer_name", MySqlDbType.VarChar).Value = textBoxChangeEquipmentManufacturer.Text;

                //adapter.SelectCommand = command;
                //adapter.Fill(table);


                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT * FROM `tb_equipment_manufacturer` WHERE col_equipment_manufacturer_name = @col_equipment_manufacturer_name", sqlConnection);
                command.Parameters.Add("@col_equipment_manufacturer_name", MySqlDbType.VarChar).Value = textBoxChangeEquipmentManufacturer.Text;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Этот производитель уже существует!\nИзменить название производителя!", "Ошибка");
                    return;
                }


                /////////////////////////////////////////////////////////////////////////////
                string EquipmentManufacturer = textBoxChangeEquipmentManufacturer.Text;

                //MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["journal"].ConnectionString);
                string query = "UPDATE `tb_equipment_manufacturer` " +
                    "SET `col_equipment_manufacturer_name`=@col_equipment_manufacturer_name " +
                    "WHERE col_equipment_manufacturer_name = @EquipmentManufacturer_old_name";

                MySqlCommand commandDatabase = new MySqlCommand(query, sqlConnection);
                commandDatabase.Parameters.Add("@col_equipment_manufacturer_name", MySqlDbType.VarChar).Value = EquipmentManufacturer;
                commandDatabase.Parameters.Add("@EquipmentManufacturer_old_name", MySqlDbType.VarChar).Value = EquipmentManufacturerBuffName;

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
                        MessageBox.Show("Название производителя изменено!", "Уведомление");
                        buttonChangeEquipmentManufacturer.Text = "Изменить";
                        textBoxChangeEquipmentManufacturer.Visible = false;
                        RefreshlistViewEquipmentManufacturer();
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
            zeroFildEquipmentManufacturer();
            buttonChangeEquipmentManufacturer.Text = "Изменить";
            textBoxChangeEquipmentManufacturer.Visible=false;    
        }

        private void textBoxAddNewEquipmentManufacturer_Enter(object sender, EventArgs e)
        {
            if (textBoxAddNewEquipmentManufacturer.Text == phraseEquipmentManufacturer)
            {
                textBoxAddNewEquipmentManufacturer.Text = "";
                textBoxAddNewEquipmentManufacturer.ForeColor = Color.Black;
            }
        }
    }
}
