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
            listViewItamNumber.Items.Clear();
            foreach (string[] s in rowsEquipmentModel)
            {
                listViewItamNumber.Items.Add(new ListViewItem(s));
            }
        }

        private void FormItamNumber_Activated(object sender, EventArgs e)
        {
            RefreshlistViewEquipmentModel();
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
    }
}
