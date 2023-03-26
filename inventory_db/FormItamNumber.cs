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
    public partial class FormItamNumber : Form
    {

        private List<string[]> filteredList = null;
        private List<string[]> rowsEquipmentModel = new List<string[]>();
        MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["inventory"].ConnectionString);

        private string rowsItamNumberMouse;
        private string rowsEquipmentManufacturerMouse;
        private string rowsEquipmentModelMouse;
        private string rowsEquipmentTypeMouse;

        public FormItamNumber()
        {
            InitializeComponent();

        }

        private void buttonAddNewItamNumber_Click(object sender, EventArgs e)
        {
            FormItamNumberAddNew ItamNumberAddNew = new FormItamNumberAddNew();
            ItamNumberAddNew.ShowDialog();
        }

        private void RefreshlistViewEquipmentModel(List<string[]> list)
        {
            listViewItamNumber.Items.Clear();
            foreach (string[] s in list)
            {
                listViewItamNumber.Items.Add(new ListViewItem(s));
            }
        }


        private void RefreshlistViewEquipmentModel()
        {
            rowsEquipmentModel.Clear();
            MySqlDataReader dataReader = null;
            string[] row;
            //try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand("SELECT tb_itam_number.item_number, tb_itam_number.equipment_model_name, tb_equipment_manufacturer.col_equipment_manufacturer_name, tb_type_equipment.col_type_equipment_name " +
                                                            "FROM tb_itam_number JOIN tb_equipment_model " +
                                                            "ON tb_itam_number.equipment_model_name = tb_equipment_model.equipment_model_name " +
                                                            "JOIN tb_equipment_manufacturer " +
                                                            "ON tb_equipment_model.id_equipment_manufacturer = tb_equipment_manufacturer.id_equipment_manufacturer " +
                                                            "JOIN tb_type_equipment " +
                                                            "ON tb_equipment_model.id_type_equipment = tb_type_equipment.id_type_equipment", sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    row = new string[]
                    {
                        Convert.ToString(dataReader["item_number"]),
                        Convert.ToString(dataReader["col_equipment_manufacturer_name"]),
                        Convert.ToString(dataReader["equipment_model_name"]),
                        Convert.ToString(dataReader["col_type_equipment_name"])
                    };
                    rowsEquipmentModel.Add(row);
                }
                sqlConnection.Close();
                dataReader.Close();
            }
            //catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            //finally
            {
                if (dataReader != null && !dataReader.IsClosed)
                {
                    dataReader.Close();
                }
            }
            listViewItamNumber.Items.Clear();
            foreach (string[] s in rowsEquipmentModel)
            {
                listViewItamNumber.Items.Add(new ListViewItem(s));
            }
        }

        private void FormItamNumber_Activated(object sender, EventArgs e)
        {
            RefreshlistViewEquipmentModel();
            columnHeaderItamNumber.Width = 150;
            columnHeaderEquipmentManufacturerName.Width = 200;
            columnHeadeEquipmentModel.Width = 350;
            columnHeaderTypeEquipment.Width = 150;
        }

        private void buttonChangeItamNumber_Click(object sender, EventArgs e)
        {
            FormItamNumberChange FormItamNumberChange = new FormItamNumberChange();

            if (this.listViewItamNumber.SelectedItems.Count != 0)
            {
                FormItamNumberChange.rowsItamNumberMouseBuff = rowsItamNumberMouse;
                FormItamNumberChange.rowsEquipmentManufacturerMouseBuff = rowsEquipmentManufacturerMouse;
                FormItamNumberChange.rowsEquipmentModelMouseBuff = rowsEquipmentModelMouse;
                FormItamNumberChange.rowsEquipmentTypeMouseBuff = rowsEquipmentTypeMouse;
                FormItamNumberChange.ShowDialog();
                RefreshlistViewEquipmentModel();
            }
            else
            {
                MessageBox.Show("Выберете строку!", "Ошибка");
            }
        }

        private void listViewItamNumber_MouseDown(object sender, MouseEventArgs e)
        {
            {
                ListViewHitTestInfo info = listViewItamNumber.HitTest(e.X, e.Y);
                ListViewItem item = info.Item;

                if (item != null)
                {
                    this.rowsItamNumberMouse = item.SubItems[0].Text;
                    this.rowsEquipmentManufacturerMouse = item.SubItems[1].Text;
                    this.rowsEquipmentModelMouse = item.SubItems[2].Text;
                    this.rowsEquipmentTypeMouse = item.SubItems[3].Text;
                }
                else
                {
                    this.listViewItamNumber.SelectedItems.Clear();
                }
            }
        }

        private void buttonDeleteItamNumber_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            if (this.listViewItamNumber.SelectedItems.Count != 0)
            {
                //////
                MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["inventory"].ConnectionString);
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT * FROM `tb_main` " +
                                                        "WHERE item_number = @item_number", sqlConnection);
                command.Parameters.Add("@item_number", MySqlDbType.VarChar).Value = rowsItamNumberMouse;

                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    dialogResult = MessageBox.Show("Данный номенклатурный артикул иммется в других таблицах\nПри удалении, удаляться все записи с свзанные с ним!\nВы уверены что хотите удалить номеклатурный артикул?", "Предупреждение", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string query = "DELETE FROM `tb_itam_number` WHERE `item_number` = @item_number";
                        MySqlCommand commandDatabase = new MySqlCommand(query, sqlConnection);
                        commandDatabase.Parameters.Add("@item_number", MySqlDbType.VarChar).Value = rowsItamNumberMouse;

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
                        RefreshlistViewEquipmentModel();
                        return;
                    }
                    else
                        return;
                }
                dialogResult = MessageBox.Show("Вы уверены, что хотите удалить нуменклатурный номер?", "Удаление типа", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string query = "DELETE FROM `tb_itam_number` WHERE `item_number` = @item_number";
                    MySqlCommand commandDatabase = new MySqlCommand(query, sqlConnection);
                    commandDatabase.Parameters.Add("@item_number", MySqlDbType.VarChar).Value = rowsItamNumberMouse;

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
                    RefreshlistViewEquipmentModel();
                }
            }
            else
            {
                MessageBox.Show("Выберете тип!", "Ошибка");
            }
        }

        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            filteredList = rowsEquipmentModel.Where(x =>
                (x[0].ToLower().Contains(textBoxFilter.Text.ToLower())) ||
                (x[1].ToLower().Contains(textBoxFilter.Text.ToLower())) ||
                (x[2].ToLower().Contains(textBoxFilter.Text.ToLower())) ||
                (x[3].ToLower().Contains(textBoxFilter.Text.ToLower()))
            ).ToList();
            RefreshlistViewEquipmentModel(filteredList);
        }

        private void buttonEmptyFilter_Click(object sender, EventArgs e)
        {
            textBoxFilter.Text = "";
        }

        private void buttonCencel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
