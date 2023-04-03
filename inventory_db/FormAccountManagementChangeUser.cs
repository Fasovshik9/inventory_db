﻿using MySql.Data.MySqlClient;
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
    public partial class FormAccountManagementChangeUser : Form
    {
        const string phraseLogin = "Введите логин";
        const string phrasePass = "Введите пароль";
        const string phraseFullName = "Введите ФИО";
        bool boolAccountManagementUserPassword = false;


        public FormAccountManagementChangeUser()
        {
            InitializeComponent();
            zeroFildPass();
            this.comboBoxAccountManagementUserPrivilege.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAccountManagementUserPrivilege.SelectedIndex = 0;
        }

        private void buttonUserLogin_Click(object sender, EventArgs e)
        {
            if (textBoxlAccountManagementUserLogin.Text == phraseLogin || textBoxAccountManagementUserFullName.Text == phraseFullName)
            {
                MessageBox.Show("Все поля должны быть заполенны !");
                return;
                
            }
            if (boolAccountManagementUserPassword == true && textBoxAccountManagementUserPassword.Text == phrasePass)
            {
                MessageBox.Show("Все поля должны быть заполенны !");
                return;
            }
            if (textBoxlAccountManagementUserLogin.TextLength >= 20 && textBoxlAccountManagementUserLogin.TextLength <= 4)
            {
                MessageBox.Show("Некорректный имя пользователя!\nМинимум 5 знаков и максимум 20!", "Ошибка");
                return;
            }
            if (textBoxAccountManagementUserPassword.TextLength >= 20 && textBoxAccountManagementUserPassword.TextLength <= 4)
            {
                MessageBox.Show("Некорректный пароль!\nМинимум 5 знаков и максимум 20!", "Ошибка");
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
            /////////////////////////////////////////////////////////////////////////////
            string userLogin = textBoxlAccountManagementUserLogin.Text;
            string userFullName = textBoxAccountManagementUserFullName.Text;
            string userPass = textBoxAccountManagementUserPassword.Text;
            string userPrivilege = Convert.ToString(comboBoxAccountManagementUserPrivilege.Text);
            //string userPrivilege = Convert.ToString(comboBoxAccountManagementUserPrivilege.Items.IndexOf(comboBoxAccountManagementUserPrivilege.Text));

            //MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["journal"].ConnectionString);
            string query = "UPDATE `tb_authorization_staff` " +
                "SET `login_authorization_staff`=@login_authorization_staff,`col_full_name_staff`=@col_full_name_staff,`col_password_staff`=@col_password_staff,`col_status_level_staff`=@col_status_level_staff " +
                "WHERE login_authorization_staff = @login_authorization_staff";

            if (boolAccountManagementUserPassword == false)
            {
                query = "UPDATE `tb_authorization_staff` " +
                "SET `login_authorization_staff`=@login_authorization_staff,`col_full_name_staff`=@col_full_name_staff,`col_status_level_staff`=@col_status_level_staff " +
                "WHERE login_authorization_staff = @login_authorization_staff";
            }


            MySqlCommand commandDatabase = new MySqlCommand(query, sqlConnection);
            commandDatabase.Parameters.Add("@login_authorization_staff", MySqlDbType.VarChar).Value = userLogin;
            commandDatabase.Parameters.Add("@col_full_name_staff", MySqlDbType.VarChar).Value = userFullName;
            commandDatabase.Parameters.Add("@col_password_staff", MySqlDbType.VarChar).Value = userPass;
            commandDatabase.Parameters.Add("@col_status_level_staff", MySqlDbType.VarChar).Value = userPrivilege;

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
                    MessageBox.Show("Данные пользователя изменены!", "Уведомление");
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

        private void buttonExitProgram_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            textBoxAccountManagementUserPassword.Visible = true;
            labelAccountManagementUserPassword.Visible = true;
            boolAccountManagementUserPassword = true;
            buttonChangePassword.Visible = false;
        }
    }
}
