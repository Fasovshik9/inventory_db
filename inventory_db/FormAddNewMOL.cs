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
    public partial class FormAddNewMOL : Form
    {
        const string phraseFullNameMOL = "Введите ФИО МОЛ'а";
        const string phraseDepatmentMOLL = "Введите подразделение МОЛ'а";

        public FormAddNewMOL()
        {
            InitializeComponent();
            labelAddNewMOL.Select();
            zeroFullNameMOL();
            zeroDepartmentMOL();
        }

        private void buttonAddMOL_Click(object sender, EventArgs e)
        {
            if (textBoxlNewMOL.Text == phraseFullNameMOL || textBoxDepartmentMOL.Text == phraseDepatmentMOLL)
            {
                MessageBox.Show("Все поля должны быть заполенны !");
                return;
            }
            if (textBoxlNewMOL.TextLength <= 20 && textBoxlNewMOL.TextLength >= 1)
            {
                if (textBoxDepartmentMOL.TextLength >= 20)
                {
                    MessageBox.Show("Название отдела слишком длинное!\nМаксимум 20 знаков!", "Ошибка");
                    zeroDepartmentMOL();
                    return;
                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("Некоректное имя МОЛ'а!\nМаксимум 20 знаков!", "Ошибка");
                zeroFullNameMOL();
                return;
            }

            ///////////////////////////////////////////////////////////////////////////// check new user to reapit
            MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["inventory"].ConnectionString);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `tb_mol` WHERE mol_department = @mol_department", sqlConnection);
            command.Parameters.Add("@mol_department", MySqlDbType.VarChar).Value = textBoxDepartmentMOL.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой отдел уже сущществует\nИзменить отдел!", "Ошибка");
                return;
            }
            /////////////////////////////////////////////////////////////////////////////
            string fullNameMOL = textBoxlNewMOL.Text;
            string departmentMOL = textBoxDepartmentMOL.Text;

            string query = "INSERT INTO tb_mol(`col_mol_full_name`, `mol_department`) " +
                "VALUES (@col_mol_full_name, @mol_department)";
            MySqlCommand commandDatabase = new MySqlCommand(query, sqlConnection);

            commandDatabase.Parameters.Add("@col_mol_full_name", MySqlDbType.VarChar).Value = textBoxlNewMOL.Text;
            commandDatabase.Parameters.Add("@mol_department", MySqlDbType.VarChar).Value = textBoxDepartmentMOL.Text;


            commandDatabase.CommandTimeout = 60;
            //if (textBoxlAccountManagementUserLogin.TextLength <= 12 && textBoxlAccountManagementUserLogin.TextLength >= 5)
            {
                //if (textBoxAccountManagementUserPassword.TextLength >= 5)
                {
                    try
                    {
                        sqlConnection.Open();
                        MySqlDataReader myReader = commandDatabase.ExecuteReader();
                        MessageBox.Show("МОЛ успешно добавлен!", "Уведомление");
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

        private void zeroFullNameMOL()
        {
            textBoxlNewMOL.Text = phraseFullNameMOL;
            textBoxlNewMOL.ForeColor = Color.Gray;
        }
        private void zeroDepartmentMOL()
        {
            textBoxDepartmentMOL.Text = phraseDepatmentMOLL;
            textBoxDepartmentMOL.ForeColor = Color.Gray;
        }

        private void textBoxlNewMOL_Leave(object sender, EventArgs e)
        {
            if (textBoxlNewMOL.Text == "")
            {
                zeroFullNameMOL();
            }
        }

        private void textBoxlNewMOL_Enter(object sender, EventArgs e)
        {
            if (textBoxlNewMOL.Text == phraseFullNameMOL)
            {
                textBoxlNewMOL.Text = "";
                textBoxlNewMOL.ForeColor = Color.Black;
            }
        }

        private void textBoxDepartmentMOL_Leave(object sender, EventArgs e)
        {
            if (textBoxDepartmentMOL.Text == "")
            {
                zeroDepartmentMOL();
            }
        }

        private void textBoxDepartmentMOL_Enter(object sender, EventArgs e)
        {
            if (textBoxDepartmentMOL.Text == phraseDepatmentMOLL)
            {
                textBoxDepartmentMOL.Text = "";
                textBoxDepartmentMOL.ForeColor = Color.Black;
            }
        }
    }
}
