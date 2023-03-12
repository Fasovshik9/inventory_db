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
    public partial class FormNomenclatureArticles : Form
    {

        private List<string[]> filteredList = null;
        private List<string[]> rowsNomenclatureArticles = new List<string[]>();
        MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["inventory"].ConnectionString);


        const string phraseLocation = "Введите Название артикуля";
        private string locationBuffNomenclatureArticles;
        private string locationNomenclatureArticlesMouse;



        public FormNomenclatureArticles()
        {
            InitializeComponent();


            //zeroFildNomenclatureArticles();
            columnNomenclatureArticles.Width = 400;
        }

        private void buttonEmptyFilter_Click(object sender, EventArgs e)
        {
            textBoxFilter.Text = "";
            RefreshlistViewNomenclatureArticles();
        }

        private void buttonAddNewNomenclatureArticles_Click(object sender, EventArgs e)
        {
            if (textBoxAddNewNomenclatureArticles.Text == phraseLocation)
            {
                MessageBox.Show("Введите название локации!");
                return;
            }
            if (textBoxAddNewNomenclatureArticles.TextLength >= 50)
            {
                MessageBox.Show("Некоректное название локации!\nМаксимум 50!", "Ошибка");
                zeroFildNomenclatureArticles();
                return;
            }
            else { }

            ///////////////////////////////////////////////////////////////////////////// check new user to reapit
            MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["inventory"].ConnectionString);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `nomenclature_articles` WHERE nomenclature_article_name = @nomenclature_article_name", sqlConnection);
            command.Parameters.Add("@nomenclature_article_name", MySqlDbType.VarChar).Value = textBoxAddNewNomenclatureArticles.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Этот артикуль уже существует!\nИзменить название артикуля!", "Ошибка");
                return;
            }
            /////////////////////////////////////////////////////////////////////////////
            string locationName = textBoxAddNewNomenclatureArticles.Text;

            string query = "INSERT INTO nomenclature_articles(`nomenclature_article_name`) " +
                "VALUES (@nomenclature_article_name)";
            MySqlCommand commandDatabase = new MySqlCommand(query, sqlConnection);

            commandDatabase.Parameters.Add("@nomenclature_article_name", MySqlDbType.VarChar).Value = locationName;

            commandDatabase.CommandTimeout = 60;
            //if (textBoxlAccountManagementUserLogin.TextLength <= 12 && textBoxlAccountManagementUserLogin.TextLength >= 5)
            {
                //if (textBoxAccountManagementUserPassword.TextLength >= 5)
                {
                    try
                    {
                        sqlConnection.Open();
                        MySqlDataReader myReader = commandDatabase.ExecuteReader();
                        MessageBox.Show("Артикуль успешно добавлена!", "Уведомление");
                        sqlConnection.Close();
                        zeroFildNomenclatureArticles();
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
        private void RefreshlistViewNomenclatureArticles(List<string[]> list)
        {
            listViewNomenclatureArticles.Items.Clear();
            foreach (string[] s in list)
            {
                listViewNomenclatureArticles.Items.Add(new ListViewItem(s));
            }
        }

        private void RefreshlistViewNomenclatureArticles()
        {
            rowsNomenclatureArticles.Clear();
            MySqlDataReader dataReader = null;
            string[] row;
            try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("SELECT nomenclature_article_name " +
                                                           "FROM nomenclature_articles ", sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    row = new string[]
                    {
                        Convert.ToString(dataReader["nomenclature_article_name"]),
                    };
                    rowsNomenclatureArticles.Add(row);
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
            listViewNomenclatureArticles.Items.Clear();
            foreach (string[] s in rowsNomenclatureArticles)
            {
                listViewNomenclatureArticles.Items.Add(new ListViewItem(s));
            }
        }

        private void buttonCencel_Click(object sender, EventArgs e)
        {
            zeroFildNomenclatureArticles();
            textBoxChangeNomenclatureArticles.Visible = false;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormNomenclatureArticles_Activated(object sender, EventArgs e)
        {
            RefreshlistViewNomenclatureArticles();
        }

        private void buttonDeleteNomenclatureArticles_Click(object sender, EventArgs e)
        {
            if (this.listViewNomenclatureArticles.SelectedItems.Count != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить номенклатурный артикуль?", "Удаление номенклутурного артикуля", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string query = "DELETE FROM `nomenclature_articles` WHERE `nomenclature_article_name` = @nomenclature_article_name";
                    MySqlCommand commandDatabase = new MySqlCommand(query, sqlConnection);
                    commandDatabase.Parameters.Add("@nomenclature_article_name", MySqlDbType.VarChar).Value = locationNomenclatureArticlesMouse;

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
                    RefreshlistViewNomenclatureArticles();
                }
            }
            else
            {
                MessageBox.Show("Выберете номенклатурный артикуль!", "Ошибка");
            }
        }

        private void listViewNomenclatureArticles_MouseDown(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = listViewNomenclatureArticles.HitTest(e.X, e.Y);
            ListViewItem item = info.Item;

            if (item != null)
            {
                this.locationNomenclatureArticlesMouse = item.SubItems[0].Text;
            }
            else
            {
                this.listViewNomenclatureArticles.SelectedItems.Clear();
            }
        }

        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            filteredList = rowsNomenclatureArticles.Where(x =>
                (x[0].ToLower().Contains(textBoxFilter.Text.ToLower()))
                ).ToList();
            RefreshlistViewNomenclatureArticles(filteredList);
        }

        private void textBoxAddNewNomenclatureArticles_Enter(object sender, EventArgs e)
        {
            if (textBoxAddNewNomenclatureArticles.Text == phraseLocation)
            {
                textBoxAddNewNomenclatureArticles.Text = "";
                textBoxAddNewNomenclatureArticles.ForeColor = Color.Black;
            }
        }

        private void listViewNomenclatureArticles_MouseLeave(object sender, EventArgs e)
        {
            if (textBoxAddNewNomenclatureArticles.Text == "")
            {
                zeroFildNomenclatureArticles();
            }
        }
        private void zeroFildNomenclatureArticles()
        {
            textBoxAddNewNomenclatureArticles.Text = phraseLocation;
            textBoxAddNewNomenclatureArticles.ForeColor = Color.Gray;
        }

        private void buttonChangeNomenclatureArticles_Click(object sender, EventArgs e)
        {
            if (buttonChangeNomenclatureArticles.Text == "Изменить")
            {
                if (this.listViewNomenclatureArticles.SelectedItems.Count != 0)
                {
                    textBoxChangeNomenclatureArticles.Text = locationNomenclatureArticlesMouse;
                    buttonChangeNomenclatureArticles.Text = "Применить";
                    textBoxChangeNomenclatureArticles.Visible = true;
                    locationBuffNomenclatureArticles = locationNomenclatureArticlesMouse;
                    RefreshlistViewNomenclatureArticles();
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
                //MySqlCommand command = new MySqlCommand("SELECT * FROM `location` WHERE location_name = @location_name", sqlConnection);
                //command.Parameters.Add("@location_name", MySqlDbType.VarChar).Value = textBoxChangeLocation.Text;

                //adapter.SelectCommand = command;
                //adapter.Fill(table);


                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT * FROM `nomenclature_articles` WHERE nomenclature_article_name = @nomenclature_article_name", sqlConnection);
                command.Parameters.Add("@nomenclature_article_name", MySqlDbType.VarChar).Value = textBoxChangeNomenclatureArticles.Text;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Этот локация уже существует!\nИзменить логин!", "Ошибка");
                    return;
                }


                /////////////////////////////////////////////////////////////////////////////


                //MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["journal"].ConnectionString);
                string query = "UPDATE `nomenclature_articles` " +
                    "SET `nomenclature_article_name`=@nomenclature_article_name " +
                    "WHERE nomenclature_article_name = @nomenclature_old_article_name";

                MySqlCommand commandDatabase = new MySqlCommand(query, sqlConnection);
                commandDatabase.Parameters.Add("@nomenclature_article_name", MySqlDbType.VarChar).Value = textBoxChangeNomenclatureArticles.Text;
                commandDatabase.Parameters.Add("@nomenclature_old_article_name", MySqlDbType.VarChar).Value = locationBuffNomenclatureArticles;

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
                        buttonChangeNomenclatureArticles.Text = "Изменить";
                        textBoxChangeNomenclatureArticles.Visible = false;
                        RefreshlistViewNomenclatureArticles();
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
    }
}
