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
    public partial class FormEquipmentModel : Form
    {

        private List<string[]> filteredList = null;
        private List<string[]> rowsEquipmentModel = new List<string[]>();
        MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["inventory"].ConnectionString);

        private string rowsEquipmentModelBuffName;
        private string rowsEquipmentModelMameMouse;



        public FormEquipmentModel()
        {
            InitializeComponent();
            RefreshlistViewEquipmentModel();
        }

        private void buttonAddNewEquipmentModel_Click(object sender, EventArgs e)
        {

        }

        private void RefreshlistViewEquipmentModel(List<string[]> list)
        {
            listViewEquipmentModel.Items.Clear();
            foreach (string[] s in list)
            {
                listViewEquipmentModel.Items.Add(new ListViewItem(s));
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
                MySqlCommand sqlCommand = new MySqlCommand("SELECT equipment_model_name, col_equipment_manufacturer_name, col_type_equipment_name " +
                                                            "FROM tb_equipment_model " +
                                                            "JOIN tb_equipment_manufacturer " +
                                                            "ON tb_equipment_model.id_equipment_manufacturer = tb_equipment_manufacturer.id_equipment_manufacturer " +
                                                            "JOIN tb_type_equipment " +
                                                            "ON tb_equipment_model.id_type_equipment = tb_type_equipment.id_type_equipment", sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    row = new string[]
                    {
                        Convert.ToString(dataReader["equipment_model_name"]),
                        Convert.ToString(dataReader["col_equipment_manufacturer_name"]),
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
            listViewEquipmentModel.Items.Clear();
            foreach (string[] s in rowsEquipmentModel)
            {
                listViewEquipmentModel.Items.Add(new ListViewItem(s));
            }
        }


    }
}
