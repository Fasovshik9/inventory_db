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
    public partial class FormMOL : Form
    {
        public string fullNameMOLMouse;
        public string fullDepartmentMOL;

        private List<string[]> filteredList = null;
        private List<string[]> rowsMOL = new List<string[]>();
        MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["inventory"].ConnectionString);


        public FormMOL()
        {
            InitializeComponent();
            columnHeaderFullNameMOL.Width = 250;
            columnHeaderMOLDepartment.Width = 150;

            RefreshlistViewMOL();
        }

        private void RefreshlistViewMOL(List<string[]> list)
        {
            listViewMOL.Items.Clear();
            foreach (string[] s in list)
            {
                listViewMOL.Items.Add(new ListViewItem(s));
            }
        }


        private void RefreshlistViewMOL()
        {
            rowsMOL.Clear();
            MySqlDataReader dataReader = null;
            string[] row;
            try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("SELECT col_mol_full_name, mol_department " +
                                                           "FROM tb_mol", sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    row = new string[]
                    {
                        Convert.ToString(dataReader["col_mol_full_name"]),
                        Convert.ToString(dataReader["mol_department"])
                    };
                    rowsMOL.Add(row);
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
            listViewMOL.Items.Clear();
            foreach (string[] s in rowsMOL)
            {
                listViewMOL.Items.Add(new ListViewItem(s));
            }
        }

        private void buttonAddNewMOL_Click(object sender, EventArgs e)
        {
            FormAddNewMOL FormAddNewMOL = new FormAddNewMOL();
            FormAddNewMOL.ShowDialog();
        }

        private void FormMOL_Activated(object sender, EventArgs e)
        {
            RefreshlistViewMOL();
            columnHeaderFullNameMOL.Width = 200;
            columnHeaderMOLDepartment.Width = 200;
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            if (this.listViewMOL.SelectedItems.Count != 0)
            {
                //////
                MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["inventory"].ConnectionString);
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT * FROM `tb_main` " +
                                                        "WHERE mol_department = @mol_department", sqlConnection);
                command.Parameters.Add("@mol_department", MySqlDbType.VarChar).Value = fullDepartmentMOL;

                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    dialogResult = MessageBox.Show("Данное подразделение иммется в других таблицах\nПри его удалении, удаляться все записи с свзанные с ним!\nВы уверены что хотите удалить данное подразделение?", "Предупреждение", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string query = "DELETE FROM `tb_mol` WHERE `mol_department` = @mol_department";
                        MySqlCommand commandDatabase = new MySqlCommand(query, sqlConnection);
                        commandDatabase.Parameters.Add("@mol_department", MySqlDbType.VarChar).Value = fullDepartmentMOL;

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
                        RefreshlistViewMOL();
                        return;
                    }
                    else
                        return;
                }
                ///////
                dialogResult = MessageBox.Show("Вы уверены, что хотите удалить МОЛ'а?", "Удаление МОЛ'а", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string query = "DELETE FROM `tb_mol` WHERE `mol_department` = @mol_department";
                    MySqlCommand commandDatabase = new MySqlCommand(query, sqlConnection);
                    commandDatabase.Parameters.Add("@mol_department", MySqlDbType.VarChar).Value = fullDepartmentMOL;

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
                    RefreshlistViewMOL();
                }
            }
            else
            {
                MessageBox.Show("Выберете МОЛ'а!", "Ошибка");
            }
        }

        private void listViewMOL_MouseDown(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = listViewMOL.HitTest(e.X, e.Y);
            ListViewItem item = info.Item;

            if (item != null)
            {
                this.fullNameMOLMouse = item.SubItems[0].Text;
                this.fullDepartmentMOL = item.SubItems[1].Text;
    
            }
            else
            {
                this.listViewMOL.SelectedItems.Clear();
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {

            filteredList = rowsMOL.Where(x =>
                (x[0].ToLower().Contains(textBoxFilter.Text.ToLower())) ||
                (x[1].ToLower().Contains(textBoxFilter.Text.ToLower()))
            ).ToList();
            RefreshlistViewMOL(filteredList);
        }

        private void buttonEmptyFilter_Click(object sender, EventArgs e)
        {
            textBoxFilter.Text = "";
            RefreshlistViewMOL();
        }

        private void buttonChangeMOL_Click(object sender, EventArgs e)
        {
            methodChangeMOL();
        }


        private void methodChangeMOL()
        {
            FormChangeMOL FormChangeMOL = new FormChangeMOL();
            if (this.listViewMOL.SelectedItems.Count != 0)
            {
                FormChangeMOL.textBoxlChangeMOL.Text = fullNameMOLMouse;
                FormChangeMOL.textBoxChangeDepartmentMOL.Text = fullDepartmentMOL;
                FormChangeMOL.oldDepartmentMOL = fullDepartmentMOL;
                FormChangeMOL.ShowDialog();
                RefreshlistViewMOL();
            }
            else
            {
                MessageBox.Show("Выберете строку!", "Ошибка");
            }
        }
    }

}
