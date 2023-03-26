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
    public partial class FormLocation : Form
    {
        private List<string[]> filteredList = null;
        private List<string[]> rowsLocation = new List<string[]>();
        MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["inventory"].ConnectionString);
        
        
        const string phraseLocation = "Введите Название локации";
        private string locationBuffName;
        private string locationMameMouse;

        public FormLocation()
        {
            InitializeComponent();
            RefreshlistViewLocation();

            zeroFildLocation();
            columnLocationName.Width = 400;
        }

        private void buttonAddNewLocation_Click(object sender, EventArgs e)
        {
            if (textBoxAddNewLocation.Text == phraseLocation)
            {
                MessageBox.Show("Введите название локации!");
                return;
            }
            if (textBoxAddNewLocation.TextLength >= 50)
            {
                MessageBox.Show("Некоректное название локации!\nМаксимум 50!", "Ошибка");
                zeroFildLocation();
                return;
            }
            else {}

            ///////////////////////////////////////////////////////////////////////////// check new user to reapit
            MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["inventory"].ConnectionString);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `tb_location` WHERE col_location_name = @col_location_name", sqlConnection);
            command.Parameters.Add("@col_location_name", MySqlDbType.VarChar).Value = textBoxAddNewLocation.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Этот локация уже существует!\nИзменить название локации!", "Ошибка");
                return;
            }
            /////////////////////////////////////////////////////////////////////////////
            string locationName = textBoxAddNewLocation.Text;

            string query = "INSERT INTO tb_location(`col_location_name`) " +
                "VALUES (@col_location_name)";
            MySqlCommand commandDatabase = new MySqlCommand(query, sqlConnection);

            commandDatabase.Parameters.Add("@col_location_name", MySqlDbType.VarChar).Value = locationName;

            commandDatabase.CommandTimeout = 60;
            //if (textBoxlAccountManagementUserLogin.TextLength <= 12 && textBoxlAccountManagementUserLogin.TextLength >= 5)
            {
                //if (textBoxAccountManagementUserPassword.TextLength >= 5)
                {
                    try
                    {
                        sqlConnection.Open();
                        MySqlDataReader myReader = commandDatabase.ExecuteReader();
                        MessageBox.Show("Локация успешно добавлена!", "Уведомление");
                        sqlConnection.Close();
                        zeroFildLocation();
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
            RefreshlistViewLocation();
        }

        private void RefreshlistViewLocation(List<string[]> list)
        {
            listViewLocation.Items.Clear();
            foreach (string[] s in list)
            {
                listViewLocation.Items.Add(new ListViewItem(s));
            }
        }

        private void RefreshlistViewLocation()
        {
            rowsLocation.Clear();
            MySqlDataReader dataReader = null;
            string[] row;
            try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("SELECT col_location_name " +
                                                           "FROM tb_location ", sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    row = new string[]
                    {
                        Convert.ToString(dataReader["col_location_name"]),
                    };
                    rowsLocation.Add(row);
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
            listViewLocation.Items.Clear();
            foreach (string[] s in rowsLocation)
            {
                listViewLocation.Items.Add(new ListViewItem(s));
            }
        }

        private void buttonCencel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLocation_Load(object sender, EventArgs e)
        {
            RefreshlistViewLocation();
        }

        private void FormLocation_Activated(object sender, EventArgs e)
        {
            RefreshlistViewLocation();
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            if (this.listViewLocation.SelectedItems.Count != 0)
            {
                //////
                MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["inventory"].ConnectionString);
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT * FROM `tb_main` " +
                                                        "JOIN tb_location " +
                                                        "ON tb_main.id_col_location = tb_location.id_col_location " +
                                                        "WHERE col_location_name = @col_location_name", sqlConnection);
                command.Parameters.Add("@col_location_name", MySqlDbType.VarChar).Value = locationMameMouse;

                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    dialogResult = MessageBox.Show("Данная локация иммется в других таблицах\nПри удалении, удаляться все записи с свзанные с ней!\nВы уверены что хотите удалить локацию?", "Предупреждение", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string query = "DELETE FROM `tb_location` WHERE `col_location_name` = @col_location_name";
                        MySqlCommand commandDatabase = new MySqlCommand(query, sqlConnection);
                        commandDatabase.Parameters.Add("@col_location_name", MySqlDbType.VarChar).Value = locationMameMouse;

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
                        RefreshlistViewLocation();
                        return;
                    }
                    else
                        return;
                }

                dialogResult = MessageBox.Show("Вы уверены, что хотите удалить Локацию?", "Удаление локации", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string query = "DELETE FROM `tb_location` WHERE `col_location_name` = @col_location_name";
                    MySqlCommand commandDatabase = new MySqlCommand(query, sqlConnection);
                    commandDatabase.Parameters.Add("@col_location_name", MySqlDbType.VarChar).Value = locationMameMouse;

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
                    RefreshlistViewLocation();
                }
            }
            else
            {
                MessageBox.Show("Выберете локацию!", "Ошибка");
            }
        }

        private void listViewAccountManagement_MouseDown(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = listViewLocation.HitTest(e.X, e.Y);
            ListViewItem item = info.Item;

            if (item != null)
            {
                this.locationMameMouse = item.SubItems[0].Text;
            }
            else
            {
                this.listViewLocation.SelectedItems.Clear();
            }
        }

        private void textBoxAddNewLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            filteredList = rowsLocation.Where(x =>
                (x[0].ToLower().Contains(textBoxFilter.Text.ToLower()))
                ).ToList();
            RefreshlistViewLocation(filteredList);
        }

        private void textBoxAddNewLocation_Enter(object sender, EventArgs e)
        {
            if (textBoxAddNewLocation.Text == phraseLocation)
            {
                textBoxAddNewLocation.Text = "";
                textBoxAddNewLocation.ForeColor = Color.Black;
            }
        }

        private void textBoxAddNewLocation_Leave(object sender, EventArgs e)
        {
            if (textBoxAddNewLocation.Text == "")
            {
                zeroFildLocation();
            }
        }
        private void zeroFildLocation()
        {
            textBoxAddNewLocation.Text = phraseLocation;
            textBoxAddNewLocation.ForeColor = Color.Gray;
        }

        private void buttonChangeLocation_Click(object sender, EventArgs e)
        {
            methodChangeLocation();
        }

        private void methodChangeLocation()
        {
            
            if (buttonChangeLocation.Text == "Изменить")
            {
                if (this.listViewLocation.SelectedItems.Count != 0)
                {
                    textBoxChangeLocation.Text = locationMameMouse;
                    buttonChangeLocation.Text = "Применить";
                    textBoxChangeLocation.Visible = true;
                    locationBuffName = locationMameMouse;
                    RefreshlistViewLocation();
                }
                else
                {
                    MessageBox.Show("Выберете локацию!", "Ошибка");
                }
            }
            else
            {

                ///////////////////////////////////////////////////////////////////////////// check new user to reapit
                MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["inventory"].ConnectionString);
                //DataTable table = new DataTable();
                //MySqlDataAdapter adapter = new MySqlDataAdapter();
                //MySqlCommand command = new MySqlCommand("SELECT * FROM `location` WHERE col_location_name = @col_location_name", sqlConnection);
                //command.Parameters.Add("@col_location_name", MySqlDbType.VarChar).Value = textBoxChangeLocation.Text;

                //adapter.SelectCommand = command;
                //adapter.Fill(table);

                
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT * FROM `tb_location` WHERE col_location_name = @col_location_name", sqlConnection);
                command.Parameters.Add("@col_location_name", MySqlDbType.VarChar).Value = textBoxChangeLocation.Text;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Этот локация уже существует!\nИзменить логин!", "Ошибка");
                    return;
                }


                /////////////////////////////////////////////////////////////////////////////
                string location = textBoxChangeLocation.Text;

                //MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["journal"].ConnectionString);
                string query = "UPDATE `tb_location` " +
                    "SET `col_location_name`=@col_location_name " +
                    "WHERE col_location_name = @location_old_name";

                MySqlCommand commandDatabase = new MySqlCommand(query, sqlConnection);
                commandDatabase.Parameters.Add("@col_location_name", MySqlDbType.VarChar).Value = location;
                commandDatabase.Parameters.Add("@location_old_name", MySqlDbType.VarChar).Value = locationBuffName;

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
                        MessageBox.Show("Локация изменена!", "Уведомление");
                        buttonChangeLocation.Text = "Изменить";
                        textBoxChangeLocation.Visible = false;
                        RefreshlistViewLocation();
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

        private void listViewLocation_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //methodChangeLocation();
        }

        private void buttonCensel_Click(object sender, EventArgs e)
        {
            zeroFildLocation();
            buttonChangeLocation.Text = "Изменить";
            textBoxChangeLocation.Visible=false;    
        }

        private void listViewLocation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelAccountManagementAddNewUser_Click(object sender, EventArgs e)
        {

        }

        private void textBoxChangeLocation_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
