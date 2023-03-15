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
    public partial class FormEquipmentModel : Form
    {

        private List<string[]> filteredList = null;
        private List<string[]> rowsEquipmentModel = new List<string[]>();
        MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["inventory"].ConnectionString);

        private string rowsEquipmentModelChange;
        private string rowsEquipmentManufacturerMouse;
        private string rowsEquipmentTypeMouse;



        public FormEquipmentModel()
        {
            InitializeComponent();
            RefreshlistViewEquipmentModel();
        }

        private void buttonAddNewEquipmentModel_Click(object sender, EventArgs e)
        {
            FormEquipmentModelAddNew FormEquipmentModelAddNew = new FormEquipmentModelAddNew();
            FormEquipmentModelAddNew.ShowDialog();
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
            listViewEquipmentModel.Items.Clear();
            foreach (string[] s in rowsEquipmentModel)
            {
                listViewEquipmentModel.Items.Add(new ListViewItem(s));
            }
        }

        private void FormEquipmentModel_Activated(object sender, EventArgs e)
        {
            RefreshlistViewEquipmentModel();
        }

        private void buttonDeleteEquipmentModel_Click(object sender, EventArgs e)
        {
            if (this.listViewEquipmentModel.SelectedItems.Count != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить модель?", "Удаление пользователя", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string query = "DELETE FROM `tb_equipment_model` WHERE `equipment_model_name` = @equipment_model_name";
                    MySqlCommand commandDatabase = new MySqlCommand(query, sqlConnection);
                    commandDatabase.Parameters.Add("@equipment_model_name", MySqlDbType.VarChar).Value = rowsEquipmentModelChange;

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
                MessageBox.Show("Выберете модель!", "Ошибка");
            }
        }

        private void listViewEquipmentModel_MouseDown(object sender, MouseEventArgs e)
        {
            {
                ListViewHitTestInfo info = listViewEquipmentModel.HitTest(e.X, e.Y);
                ListViewItem item = info.Item;

                if (item != null)
                {
                    this.rowsEquipmentManufacturerMouse = item.SubItems[0].Text;
                    this.rowsEquipmentModelChange = item.SubItems[1].Text;
                    this.rowsEquipmentTypeMouse = item.SubItems[2].Text;
                }
                else
                {
                    this.listViewEquipmentModel.SelectedItems.Clear();
                }
            }
        }

        private void buttonCencel_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void buttonChangeEquipmentModel_Click(object sender, EventArgs e)
        {

            FormEquipmentModelChange FormEquipmentModelChange = new FormEquipmentModelChange();

            if (this.listViewEquipmentModel.SelectedItems.Count != 0)
            {
                FormEquipmentModelChange.textBoxEquipmentModelChange.Text = rowsEquipmentModelChange;
                FormEquipmentModelChange.EquipmentManufacturerBuff = rowsEquipmentManufacturerMouse;
                FormEquipmentModelChange.EquipmentTypeBuff = rowsEquipmentTypeMouse;
                FormEquipmentModelChange.ShowDialog();
                RefreshlistViewEquipmentModel();
            }
            else
            {
                MessageBox.Show("Выберете модель!", "Ошибка");
            }
        }

        private void FormEquipmentModel_Load(object sender, EventArgs e)
        {

        }
    }
}
