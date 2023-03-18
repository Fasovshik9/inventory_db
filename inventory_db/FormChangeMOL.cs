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
    public partial class FormChangeMOL : Form
    {


        const string phraseFullNameMOL = "Введите ФИО МОЛ'а";
        const string phraseDepatmentMOLL = "Введите подразделение МОЛ'а";
        public string oldDepartmentMOL;

        public FormChangeMOL()
        {
            InitializeComponent();
        }

        private void buttonExitFromForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonChangeMOL_Click(object sender, EventArgs e)
        {
            if (textBoxlChangeMOL.Text == phraseFullNameMOL || textBoxChangeDepartmentMOL.Text == phraseDepatmentMOLL)
            {
                MessageBox.Show("Все поля должны быть заполенны !");
                return;
            }
            if (textBoxlChangeMOL.TextLength <= 20 && textBoxlChangeMOL.TextLength >= 1)
            {
                if (textBoxChangeDepartmentMOL.TextLength >= 20)
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
            command.Parameters.Add("@mol_department", MySqlDbType.VarChar).Value = textBoxChangeDepartmentMOL.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0 && oldDepartmentMOL != textBoxChangeDepartmentMOL.Text)
            {
                MessageBox.Show("У отдела уже есть МОЛ!\nИзменить отдел!", "Ошибка");
                return;
            }
            /////////////////////////////////////////////////////////////////////////////


            //MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["journal"].ConnectionString);
            string query = "UPDATE `tb_mol` " +
                "SET `col_mol_full_name`=@col_mol_full_name,`mol_department`=@mol_department " +
                "WHERE mol_department = @MOL_old_department";

            //if (boolAccountManagementUserPassword == false)
            //{
            //    query = "UPDATE `authorization_staff` " +
            //    "SET `user_login_staff`=@user_login_staff,`full_name_staff`=@full_name_staff,`id_privilege_staff`=@id_privilege_staff " +
            //    "WHERE user_login_staff = @user_login_staff";
            //}


            MySqlCommand commandDatabase = new MySqlCommand(query, sqlConnection);
            commandDatabase.Parameters.Add("@col_mol_full_name", MySqlDbType.VarChar).Value = textBoxlChangeMOL.Text;
            commandDatabase.Parameters.Add("@mol_department", MySqlDbType.VarChar).Value = textBoxChangeDepartmentMOL.Text;
            commandDatabase.Parameters.Add("@MOL_old_department", MySqlDbType.VarChar).Value = oldDepartmentMOL;

            
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
                    MessageBox.Show("Данные МОЛ'a изменены!", "Уведомление");
                    this.Close();
                }
                catch (Exception ex)
                {
                    // Ops, maybe the id doesn't exists ?
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void zeroFullNameMOL()
        {
            textBoxlChangeMOL.Text = phraseFullNameMOL;
            textBoxlChangeMOL.ForeColor = Color.Gray;
        }
        private void zeroDepartmentMOL()
        {
            textBoxChangeDepartmentMOL.Text = phraseDepatmentMOLL;
            textBoxChangeDepartmentMOL.ForeColor = Color.Gray;
        }

        private void textBoxlChangeMOL_Enter(object sender, EventArgs e)
        {
            if (textBoxlChangeMOL.Text == phraseFullNameMOL)
            {
                textBoxlChangeMOL.Text = "";
                textBoxlChangeMOL.ForeColor = Color.Black;
            }
        }

        private void textBoxChangeDepartmentMOL_Enter(object sender, EventArgs e)
        {
            if (textBoxChangeDepartmentMOL.Text == phraseDepatmentMOLL)
            {
                textBoxChangeDepartmentMOL.Text = "";
                textBoxChangeDepartmentMOL.ForeColor = Color.Black;
            }
        }

        private void textBoxlChangeMOL_Leave(object sender, EventArgs e)
        {
            if (textBoxlChangeMOL.Text == "")
            {
                zeroFullNameMOL();
            }
        }

        private void textBoxChangeDepartmentMOL_Leave(object sender, EventArgs e)
        {
            if (textBoxChangeDepartmentMOL.Text == "")
            {
                zeroDepartmentMOL();
            }
        }
    }
}
