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
    public partial class MainForm : Form
    {
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
            FormEquipment FormEquipment = new FormEquipment();
            FormEquipment.ShowDialog();
        }
    }
}
