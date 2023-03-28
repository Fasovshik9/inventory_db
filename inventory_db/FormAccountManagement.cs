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
    public partial class FormAccountManagement : Form
    {
        private List<string[]> filteredList = null;
        private List<string[]> rowsUserAccountManagement = new List<string[]>();
        MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["inventory"].ConnectionString);


        public string userNameMouse;
        public string userFullNameMouse;
        public int userPrivilegeMouse;

        public FormAccountManagement()
        {
            InitializeComponent();
            RefreshlistViewAccountManagement();
        }

        private void RefreshlistViewAccountManagement(List<string[]> list)
        {
            listViewAccountManagement.Items.Clear();
            foreach (string[] s in list)
            {
                listViewAccountManagement.Items.Add(new ListViewItem(s));
            }
        }


        private void RefreshlistViewAccountManagement()
        {
            rowsUserAccountManagement.Clear();
            MySqlDataReader dataReader = null;
            string[] row;
            try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("SELECT login_authorization_staff, col_full_name_staff, col_status_level_staff FROM tb_authorization_staff", sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    row = new string[]
                    {
                        Convert.ToString(dataReader["login_authorization_staff"]),
                        Convert.ToString(dataReader["col_full_name_staff"]),
                        Convert.ToString(dataReader["col_status_level_staff"])
                    };
                    rowsUserAccountManagement.Add(row);
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
            listViewAccountManagement.Items.Clear();
            foreach (string[] s in rowsUserAccountManagement)
            {
                listViewAccountManagement.Items.Add(new ListViewItem(s));
            }
        }

        private void FormAccountManagement_Load(object sender, EventArgs e)
        {
            columnHeaderUserLogin.Width = 100;
            columnHeaderFullName.Width = 345;
            columnHeaderUserPrivilege.Width = 120;
        }

        private void buttonAddNewUser_Click(object sender, EventArgs e)
        {
            FormAccountManagementAddNewUser FormAccountManagementAddNewUser = new FormAccountManagementAddNewUser();
            FormAccountManagementAddNewUser.ShowDialog();
        }

        private void FormAccountManagement_Activated(object sender, EventArgs e)
        {
            RefreshlistViewAccountManagement();
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            if (this.listViewAccountManagement.SelectedItems.Count != 0)
            {
                //////
                MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["inventory"].ConnectionString);
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT * FROM `tb_equipment_report` " +
                                                        "WHERE login_authorization_staff = @login_authorization_staff", sqlConnection);
                command.Parameters.Add("@login_authorization_staff", MySqlDbType.VarChar).Value = userNameMouse;

                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    dialogResult = MessageBox.Show("Данный пользователь иммется в других таблицах\nПри его удалении, удаляться все записи с свзанные с ним!\nВы уверены что хотите удалить данного пользователя?", "Предупреждение", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string query = "DELETE FROM `tb_authorization_staff` WHERE `login_authorization_staff` = @login_authorization_staff";
                        MySqlCommand commandDatabase = new MySqlCommand(query, sqlConnection);
                        commandDatabase.Parameters.Add("@login_authorization_staff", MySqlDbType.VarChar).Value = userNameMouse;

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
                        RefreshlistViewAccountManagement();
                        return;
                    }
                    else
                        return;
                }
                ////////
                dialogResult = MessageBox.Show("Вы уверены, что хотите удалить пользователя?", "Удаление пользователя", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string query = "DELETE FROM `tb_authorization_staff` WHERE `login_authorization_staff` = @login_authorization_staff";
                    MySqlCommand commandDatabase = new MySqlCommand(query, sqlConnection);
                    commandDatabase.Parameters.Add("@login_authorization_staff", MySqlDbType.VarChar).Value = userNameMouse;

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
                    RefreshlistViewAccountManagement();
                }
            }
            else
            {
                MessageBox.Show("Выберете пользователя!", "Ошибка");
            }
        }

        private void listViewAccountManagement_MouseDown(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = listViewAccountManagement.HitTest(e.X, e.Y);
            ListViewItem item = info.Item;

            if (item != null)
            {
                this.userNameMouse = item.SubItems[0].Text;
                this.userFullNameMouse = item.SubItems[1].Text;
                //this.userPrivilegeMouse = item.SubItems[2].Text;
                if (item.SubItems[2].Text == "Администратор")
                    userPrivilegeMouse = 0;
                else if (item.SubItems[2].Text == "Пользователь")
                    userPrivilegeMouse = 1;
                else userPrivilegeMouse = 2;

            }
            else
            {
                this.listViewAccountManagement.SelectedItems.Clear();
            }
        }

        private void buttonChangeUser_Click(object sender, EventArgs e)
        {
            methodChangeUser();
        }
        private void methodChangeUser()
        {
            FormAccountManagementChangeUser FormAccountManagementChangeUser = new FormAccountManagementChangeUser();
            if (this.listViewAccountManagement.SelectedItems.Count != 0)
            {
                FormAccountManagementChangeUser.textBoxlAccountManagementUserLogin.Text = userNameMouse;
                FormAccountManagementChangeUser.textBoxAccountManagementUserFullName.Text = userFullNameMouse;
                FormAccountManagementChangeUser.comboBoxAccountManagementUserPrivilege.SelectedIndex = userPrivilegeMouse;
                FormAccountManagementChangeUser.ShowDialog();
                RefreshlistViewAccountManagement();
            }
            else
            {
                MessageBox.Show("Выберете пользвателя!", "Ошибка");
            }
        }

        private void listViewAccountManagement_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            methodChangeUser();
        }

        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {

            filteredList = rowsUserAccountManagement.Where(x =>
                (x[0].ToLower().Contains(textBoxFilter.Text.ToLower())) ||
                (x[1].ToLower().Contains(textBoxFilter.Text.ToLower())) ||
                (x[2].ToLower().Contains(textBoxFilter.Text.ToLower()))
            ).ToList();
            RefreshlistViewAccountManagement(filteredList);
        }

        private void buttonEmptyFilter_Click(object sender, EventArgs e)
        {
            textBoxFilter.Text = "";
            RefreshlistViewAccountManagement();
        }

        private void buttonCencel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labellAccountManagementFilter_Click(object sender, EventArgs e)
        {

        }

        private void listViewAccountManagement_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelAccountManagementAddNewUser_Click(object sender, EventArgs e)
        {

        }
    }
}
