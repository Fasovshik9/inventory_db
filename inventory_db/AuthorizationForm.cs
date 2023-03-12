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
    public partial class AuthorizationForm : Form
    {
        const string phraseLogin = "Введите логин";
        const string phrasePass = "Введите пароль";

        public AuthorizationForm()
        {
            InitializeComponent();
            textBoxUserLogin.ForeColor = Color.Gray;
            textBoxUserLogin.Text = phraseLogin;
            textBoxUserPassword.Text = phrasePass;
            textBoxUserPassword.ForeColor = Color.Gray;
            labelAuthorization.Select();
        }

        private void buttonUserLogin_Click(object sender, EventArgs e)
        {
            string loginUser = textBoxUserLogin.Text;
            string passUser = textBoxUserPassword.Text;

            try
            {
                MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["inventory"].ConnectionString);
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT * FROM `authorization_staff` " +
                    "                                    WHERE `user_login_staff` = @user_login_staff AND `password_staff` = @password_staff", sqlConnection);

                command.Parameters.Add("@user_login_staff", MySqlDbType.VarChar).Value = loginUser;
                command.Parameters.Add("@password_staff", MySqlDbType.VarChar).Value = passUser;

                adapter.SelectCommand = command;
                adapter.Fill(table);



                if (textBoxUserLogin.Text == phraseLogin || textBoxUserPassword.Text == phrasePass)
                {
                    MessageBox.Show("Введите логин и пароль!", "Ошибка");
                    return;
                }
                else
                {
                    if (table.Rows.Count > 0)
                    {
                        Hide();
                        using (MainForm MainForm = new MainForm())
                        {
                            //idValueUser = Convert.ToString(table.Rows[0].ItemArray[0]);
                            //privilegeUser = Convert.ToString(table.Rows[0].ItemArray[3]);
                            //MainForm.userNameLabel.Text = this.textBoxUserLogin.Text;
                            //MainForm.oldUserPass = textBoxUserPassword.Text;
                            //MainForm.idValueUser = idValueUser;
                            //MainForm.privilegeUser = privilegeUser;
                            MainForm.ShowDialog();
                        }
                        Show();
                    }
                    else
                    {
                        zeroFildPass();
                        MessageBox.Show("Неправльный логин или пароль!", "Ошибка");
                    }

                }
            }
            catch (Exception ex)
            {
                if (MessageBox.Show("Error message:\n" + ex.Message, "Unable to connect to database!",
                MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }

        private void buttonExitProgram_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {
            MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["inventory"].ConnectionString);
            try
            {
                sqlConnection.Open();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                if (MessageBox.Show("Error message:\n" + ex.Message, "Unable to connect to database!",
                MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void AuthorizationForm_Activated(object sender, EventArgs e)
        {
            //textboxuserlogin.text = phraseLogin;
            //textboxuserlogin.forecolor = color.gray;
            //textboxuserpassword.text = phrasePass;
            //textboxuserpassword.forecolor = color.gray;
            //textboxuserpassword.usesystempasswordchar = false;
        }

        private void zeroFildPass()
        {
            textBoxUserPassword.Text = phrasePass;
            textBoxUserPassword.ForeColor = Color.Gray;
            textBoxUserPassword.UseSystemPasswordChar = false;
        }
        private void zeroFildLogin()
        {
            textBoxUserLogin.Text = phraseLogin;
            textBoxUserLogin.ForeColor = Color.Gray;
        }




        private void textBoxUserLogin_Enter(object sender, EventArgs e)
        {
            if (textBoxUserLogin.Text == phraseLogin)
            {
                textBoxUserLogin.Text = "";
                textBoxUserLogin.ForeColor = Color.Black;
            }
        }

        private void textBoxUserPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxUserPassword.Text == phrasePass)
            {
                textBoxUserPassword.Text = "";
                textBoxUserPassword.ForeColor = Color.Black;
                textBoxUserPassword.UseSystemPasswordChar = true;
            }
        }

        private void textBoxUserLogin_Leave(object sender, EventArgs e)
        {
            if (textBoxUserLogin.Text == "")
            {
                zeroFildLogin();
            }
        }

        private void textBoxUserPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxUserPassword.Text == "")
            {
                zeroFildPass();
            }
        }
    }
}
