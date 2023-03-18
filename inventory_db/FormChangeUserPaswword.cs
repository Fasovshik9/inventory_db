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
    public partial class FormChangeUserPaswword : Form
    {
        public string userLogin;
        public string oldUserPassword;

        const string phraseNewPass = "Введите пароль";
        const string phraseOldPass = "Введите старый пароль";
        const string phraseRepPass = "Введите новый пароль";

        public FormChangeUserPaswword()
        {
            InitializeComponent();
            zerotextBoxOldPassword();
            zerotextBoxNewPassword();
            zerotextBoxNewPasswordRepead();
        }

        private void buttonItamNumberChange_Click(object sender, EventArgs e)
        {
            MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["inventory"].ConnectionString);

            if (textBoxOldPassword.Text == phraseOldPass || textBoxNewPassword.Text == phraseNewPass || textBoxNewPasswordRepead.Text == phraseRepPass)
            {
                MessageBox.Show("Все поля должны быть заполнены!", "Ошибка");
                return;
            }

            string query = "UPDATE `tb_authorization_staff` " +
                            "SET `col_password_staff`=@col_password_staff " +
                            "WHERE login_authorization_staff = @login_authorization_staff";

            MySqlCommand commandDatabase = new MySqlCommand(query, sqlConnection);

            commandDatabase.Parameters.Add("@login_authorization_staff", MySqlDbType.VarChar).Value = userLogin;
            commandDatabase.Parameters.Add("@col_password_staff", MySqlDbType.VarChar).Value = textBoxNewPassword.Text;


            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;



            if (textBoxOldPassword.Text != "" && textBoxNewPassword.Text != "" && textBoxNewPasswordRepead.Text != "")
            {
                if (oldUserPassword == textBoxOldPassword.Text)
                {
                    if (textBoxOldPassword.Text != textBoxNewPassword.Text)
                    {
                        if (textBoxNewPassword.Text == textBoxNewPasswordRepead.Text)
                        {
                            if (textBoxNewPassword.TextLength >= 5)
                            {
                                try
                                {
                                    sqlConnection.Open();
                                    reader = commandDatabase.ExecuteReader();
                                    // Succesfully updated
                                    sqlConnection.Close();
                                    MessageBox.Show("Вы успешно изменили ваш пароль!", "Уведомление");
                                }
                                catch (Exception ex)
                                {
                                    // Ops, maybe the id doesn't exists ?
                                    MessageBox.Show(ex.Message);
                                }
                            }
                            else MessageBox.Show("Пароль слишком короткий! Минимум 5 знаков!", "Ошибка");
                        }
                        else MessageBox.Show("Введенный второй раз пароль не совпадает!", "Ошибка");
                    }
                    else MessageBox.Show("Старый и новый пароль одинаковые!", "Ошибка");
                }
                else MessageBox.Show("Вы ввели неверный старый пароль!", "Ошибка");
            }
            else MessageBox.Show("Все поля должны быть заполнены!", "Ошибка");
        }

        private void buttonCencel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void zerotextBoxOldPassword()
        {
            textBoxOldPassword.Text = phraseOldPass;
            textBoxOldPassword.ForeColor = Color.Gray;
            textBoxOldPassword.UseSystemPasswordChar = false;
        }
        private void zerotextBoxNewPassword()
        {
            textBoxNewPassword.Text = phraseNewPass; 
            textBoxNewPassword.ForeColor = Color.Gray;
            textBoxNewPassword.UseSystemPasswordChar = false;
        }
        private void zerotextBoxNewPasswordRepead()
        {
            textBoxNewPasswordRepead.Text = phraseRepPass;
            textBoxNewPasswordRepead.ForeColor = Color.Gray;
            textBoxNewPasswordRepead.UseSystemPasswordChar = false;
        }

        private void textBoxOldPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxOldPassword.Text == phraseOldPass)
            {
                textBoxOldPassword.Text = "";
                textBoxOldPassword.ForeColor = Color.Black;
                textBoxOldPassword.UseSystemPasswordChar = true;
            }
        }

        private void textBoxNewPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxNewPassword.Text == phraseNewPass)
            {
                textBoxNewPassword.Text = "";
                textBoxNewPassword.ForeColor = Color.Black;
                textBoxNewPassword.UseSystemPasswordChar = true;
            }
        }

        private void textBoxNewPasswordRepead_Enter(object sender, EventArgs e)
        {
            if (textBoxNewPasswordRepead.Text == phraseRepPass)
            {
                textBoxNewPasswordRepead.Text = "";
                textBoxNewPasswordRepead.ForeColor = Color.Black;
                textBoxNewPasswordRepead.UseSystemPasswordChar = true;
            }
        }

        private void textBoxOldPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxOldPassword.Text == "")
            {
                zerotextBoxOldPassword();
            }
        }

        private void textBoxNewPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxNewPassword.Text == "")
            {
                zerotextBoxNewPassword();
            }
        }

        private void textBoxNewPasswordRepead_Leave(object sender, EventArgs e)
        {
            if (textBoxNewPasswordRepead.Text == "")
            {
                zerotextBoxNewPasswordRepead();
            }
        }
    }
}
