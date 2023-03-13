using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace inventory_db
{
    public partial class FormAddNewEquipment : Form
    {

        public string fullNameMOLMouse;
        public string fullDepartmentMOL;

        private List<string[]> filteredList = null;
        private List<string[]> rowsEquipmentManufacturer = new List<string[]>();
        MySqlConnection sqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["inventory"].ConnectionString);




        public FormAddNewEquipment()
        {
            InitializeComponent();

            //List<ComboboxItem> result = new List<ComboboxItem>();
            //List <ComboboxItem> item = new List<ComboboxItem>();
            ////ComboboxItem item2 = new ComboboxItem();
            //result.Add(12);
            //result.("12");
            //item.Add.Value = 12;

            //comboBoxEquipmentManufacturer.Items.Add(item);
            //comboBoxEquipmentManufacturer.Items.Add(item2);
            //comboBoxEquipmentManufacturer.DisplayMember = "Text";
            //comboBoxEquipmentManufacturer.ValueMember = "Value";

            //comboBoxEquipmentManufacturer.Items.Add(new ComboboxItem() { Text = "Item 1", Value = 1 });
            //comboBoxEquipmentManufacturer.Items.Add(new ComboboxItem() { Text = "Item 2", Value = 2 });
            //comboBoxEquipmentManufacturer.Items.Add(new ComboboxItem() { Text = "Item 3", Value = 3 });
            FillComboBoxEquipmentManufacturer();

        }

        private void FormAddNewEquipment_Activated(object sender, EventArgs e)
        {

        }

        private void buttonAddNewEquipment_Click(object sender, EventArgs e)
        {
            //labelAccountManagementAddNewUser.Text = comboBoxEquipmentManufacturer.SelectedItem.ValueMember.ToString();
            labelAccountManagementAddNewUser.Text = comboBoxEquipmentManufacturer.SelectedValue.ToString();
        }


        private void FillComboBoxEquipmentManufacturer()
        {
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM tb_equipment_manufacturer", sqlConnection);
                //SqlDataAdapter da = new SqlDataAdapter(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable table = new DataTable();
                adapter.SelectCommand = command;


                sqlConnection.Open();
                DataSet ds = new DataSet(); 
                adapter.Fill(ds, "Fleet");
                comboBoxEquipmentManufacturer.DisplayMember = "col_equipment_manufacturer_name";
                comboBoxEquipmentManufacturer.ValueMember = "id_equipment_manufacturer";
                comboBoxEquipmentManufacturer.DataSource = ds.Tables["Fleet"];
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("Error occured!");
            }
        }
        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }


    }
}
