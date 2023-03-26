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
    public partial class FormAccountManagementAddNewUser : Form
    {
        const string phraseLogin = "Введите логин";
        const string phrasePass = "Введите пароль";
        const string phraseFullName = "Введите ФИО";
        public FormAccountManagementAddNewUser()
        {
            InitializeComponent();
            textBoxlAccountManagementUserLogin.Text = phraseLogin;
            textBoxAccountManagementUserFullName.Text = phraseFullName;
            textBoxAccountManagementUserPassword.Text = phrasePass;

            zeroFildLogin();
            zeroFildFullUserName();
            zeroFildPass();
            

            labelAccountManagementAddNewUser.Select();
        }

        private void buttonUserLogin_Click(object sender, EventArgs e)
        {
            if (textBoxlAccountManagementUserLogin.Text == phraseLogin || textBoxAccountManagementUserPassword.Text == phrasePass || textBoxAccountManagementUserFullName.Text == phraseFullName)
            {
                MessageBox.Show("Все поля должны быть заполенны !");
                return;
            }
            if (textBoxlAccountManagementUserLogin.TextLength <= 20 && textBoxlAccountManagementUserLogin.TextLength >= 5)
            {
                //if (textBoxAccountManagementUserFullName.TextLength >= 5)
                {
                    if (textBoxAccountManagementUserPassword.TextLength >= 5) {}
                    else
                    {
                        MessageBox.Show("Пароль пользователя слишком короткий!\nМинимум 5 знаков!", "Ошибка");
                        zeroFildPass();
                        return;
                    }
                }
                //else
                //{
                //    MessageBox.Show("!\nМинимум 5 знаков!", "Ошибка");
                //    zeroFildPass();
                //    return;
                //}
            }
            else
            {
                MessageBox.Show("Некоректное имя пользователя!\nМинимум 5 знаков и максимум 20!", "Ошибка");
                zeroFildPass();
                return;
            }

            ///////////////////////////////////////////////////////////////////////////// check new user to reapit
            MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["inventory"].ConnectionString);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `tb_authorization_staff` WHERE login_authorization_staff = @login_authorization_staff", sqlConnection);
            command.Parameters.Add("@login_authorization_staff", MySqlDbType.VarChar).Value = textBoxlAccountManagementUserLogin.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Этот пользователь уже существует!\nИзменить логин!", "Ошибка");
                return;
            }
            /////////////////////////////////////////////////////////////////////////////
            string userLogin = textBoxlAccountManagementUserLogin.Text;
            string userFullName = textBoxAccountManagementUserFullName.Text;
            string userPass = textBoxAccountManagementUserPassword.Text;
            string userPrivilege = Convert.ToString(comboBoxAccountManagementUserPrivilege.Items.IndexOf(comboBoxAccountManagementUserPrivilege.Text));

            string query = "INSERT INTO tb_authorization_staff(`login_authorization_staff`, `col_full_name_staff`, `col_password_staff`, `id_status_level_staff`) " +
                "VALUES (@login_authorization_staff, @col_full_name_staff,@col_password_staff, @id_status_level_staff)";
            MySqlCommand commandDatabase = new MySqlCommand(query, sqlConnection);

            commandDatabase.Parameters.Add("@login_authorization_staff", MySqlDbType.VarChar).Value = userLogin;
            commandDatabase.Parameters.Add("@col_full_name_staff", MySqlDbType.VarChar).Value = userFullName;
            commandDatabase.Parameters.Add("@col_password_staff", MySqlDbType.VarChar).Value = userPass;
            commandDatabase.Parameters.Add("@id_status_level_staff", MySqlDbType.VarChar).Value = userPrivilege;

            commandDatabase.CommandTimeout = 60;
            //if (textBoxlAccountManagementUserLogin.TextLength <= 12 && textBoxlAccountManagementUserLogin.TextLength >= 5)
            {
                //if (textBoxAccountManagementUserPassword.TextLength >= 5)
                {
                    try
                    {
                        sqlConnection.Open();
                        MySqlDataReader myReader = commandDatabase.ExecuteReader();
                        MessageBox.Show("Пользователь успешно зарегистрирован!", "Уведомление");
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

        private void FormAccountManagementAddNewUser_Load(object sender, EventArgs e)
        {
            this.comboBoxAccountManagementUserPrivilege.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAccountManagementUserPrivilege.SelectedIndex = 0;
        }

        private void buttonExitProgram_Click(object sender, EventArgs e)
        {
            labelAccountManagementAddNewUser.Text = comboBoxAccountManagementUserPrivilege.ValueMember;
            //this.Close();
        }
        private void zeroFildPass()
        {
            textBoxAccountManagementUserPassword.Text = phrasePass;
            textBoxAccountManagementUserPassword.ForeColor = Color.Gray;
            textBoxAccountManagementUserPassword.UseSystemPasswordChar = false;
        }
        private void zeroFildLogin()
        {
            textBoxlAccountManagementUserLogin.Text = phraseLogin;
            textBoxlAccountManagementUserLogin.ForeColor = Color.Gray;
        }
        private void zeroFildFullUserName()
        {
            textBoxAccountManagementUserFullName.Text = phraseFullName;
            textBoxAccountManagementUserFullName.ForeColor = Color.Gray;
        }

        private void textBoxlAccountManagementUserLogin_Leave(object sender, EventArgs e)
        {
            if (textBoxlAccountManagementUserLogin.Text == "")
            {
                zeroFildLogin();
            }
        }

        private void textBoxlAccountManagementUserLogin_Enter(object sender, EventArgs e)
        {
            if (textBoxlAccountManagementUserLogin.Text == phraseLogin)
            {
                textBoxlAccountManagementUserLogin.Text = "";
                textBoxlAccountManagementUserLogin.ForeColor = Color.Black;
            }
        }

        private void textBoxAccountManagementUserPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxAccountManagementUserPassword.Text == "")
            {
                zeroFildPass();
            }
        }

        private void textBoxAccountManagementUserPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxAccountManagementUserPassword.Text == phrasePass)
            {
                textBoxAccountManagementUserPassword.Text = "";
                textBoxAccountManagementUserPassword.ForeColor = Color.Black;
                textBoxAccountManagementUserPassword.UseSystemPasswordChar = true;
            }
        }

        private void textBoxAccountManagementUserFullName_Leave(object sender, EventArgs e)
        {
            if (textBoxAccountManagementUserFullName.Text == "")
            {
                zeroFildFullUserName();
            }
        }

        private void textBoxAccountManagementUserFullName_Enter(object sender, EventArgs e)
        {
            if (textBoxAccountManagementUserFullName.Text == phraseFullName)
            {
                textBoxAccountManagementUserFullName.Text = "";
                textBoxAccountManagementUserFullName.ForeColor = Color.Black;
            }
        }
    }
}
