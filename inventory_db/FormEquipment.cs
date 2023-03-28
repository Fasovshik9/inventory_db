using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_db
{
    public partial class FormEquipment : Form
    {
        public FormEquipment()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddNewEquipment_Click(object sender, EventArgs e)
        {
            FormAddNewEquipment FormAddNewEquipment = new FormAddNewEquipment();
            FormAddNewEquipment.ShowDialog();
        }

        private void buttonChangeEquipment_Click(object sender, EventArgs e)
        {

        }
    }
}
