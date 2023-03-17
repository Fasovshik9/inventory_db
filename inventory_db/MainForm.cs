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
    public partial class MainForm : Form
    {

        private List<string[]> filteredList = null;
        private List<string[]> rowsMain = new List<string[]>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MenuItemAccountManagement_Click(object sender, EventArgs e)
        {
            FormAccountManagement FormAccountManagement = new FormAccountManagement();
            FormAccountManagement.ShowDialog();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //if (exitValue == true)
            {
                Environment.Exit(0);
            }
            this.Close();
        }

        private void ToolStripMenuItemLocation_Click(object sender, EventArgs e)
        {
            FormLocation FormLocation = new FormLocation();
            FormLocation.ShowDialog();
        }

        private void мОЛToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMOL FormMOL = new FormMOL();
            FormMOL.ShowDialog();
        }

        private void типыОборудованяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEquipmentType FormEquipment = new FormEquipmentType();
            FormEquipment.ShowDialog();
        }

        private void производительОборудованияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEquipmentManufacturer FormEquipmentManufacturer = new FormEquipmentManufacturer();
            FormEquipmentManufacturer.ShowDialog();
        }

        private void оборудованиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEquipmentModel FormEquipmentModel = new FormEquipmentModel();
            FormEquipmentModel.ShowDialog();
        }

        private void модельОборудованияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormItamNumber FormItamNumber = new FormItamNumber();
            FormItamNumber.ShowDialog();
        }


        private void RefreshlistViewMain()
        {
            MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["inventory"].ConnectionString);
            rowsMain.Clear();
            MySqlDataReader dataReader = null;
            string[] row;
            //try
            {
                sqlConnection.Open();
                MySqlCommand sqlCommand = new MySqlCommand(" " +
                                                           "SELECT tb_main.invent_number,  tb_location.col_location_name, tb_main.col_date,  tb_mol.col_mol_full_name, tb_mol.mol_department, tb_itam_number.item_number, tb_equipment_model.equipment_model_name, tb_equipment_manufacturer.col_equipment_manufacturer_name, tb_type_equipment.col_type_equipment_name,tb_authorization_staff.col_full_name_staff " +
                                                           "FROM  tb_main " +
                                                           "JOIN tb_location " +
                                                           "ON tb_main.id_col_location = tb_location.id_col_location " +
                                                           "JOIN tb_mol " +
                                                           "ON tb_main.mol_department = tb_mol.mol_department " +
                                                           "JOIN tb_itam_number " +
                                                           "ON tb_main.item_number = tb_itam_number.item_number " +
                                                           "JOIN tb_equipment_model " +
                                                           "ON tb_itam_number.equipment_model_name = tb_equipment_model.equipment_model_name " +
                                                           "JOIN tb_equipment_manufacturer " +
                                                           "ON tb_equipment_model.id_equipment_manufacturer = tb_equipment_manufacturer.id_equipment_manufacturer " +
                                                           "JOIN tb_type_equipment " +
                                                           "ON tb_equipment_model.id_type_equipment = tb_type_equipment.id_type_equipment " +
                                                           "JOIN tb_authorization_staff " +
                                                           "ON tb_main.login_authorization_staff = tb_authorization_staff.login_authorization_staff ", sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    row = new string[]
                    {
                        Convert.ToString(dataReader["invent_number"]),
                        Convert.ToString(dataReader["col_location_name"]),
                        Convert.ToString(dataReader["col_date"]),
                        Convert.ToString(dataReader["col_mol_full_name"]),
                        Convert.ToString(dataReader["mol_department"]),
                        Convert.ToString(dataReader["item_number"]),
                        Convert.ToString(dataReader["equipment_model_name"]),
                        Convert.ToString(dataReader["col_equipment_manufacturer_name"]),
                        Convert.ToString(dataReader["col_type_equipment_name"]),
                        Convert.ToString(dataReader["col_full_name_staff"])
                    };
                    rowsMain.Add(row);
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
            listViewMain.Items.Clear();
            foreach (string[] s in rowsMain)
            {
                listViewMain.Items.Add(new ListViewItem(s));
            }
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            RefreshlistViewMain();
        }
    }
}
