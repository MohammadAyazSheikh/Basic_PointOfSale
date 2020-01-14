using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Medical
{
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
            panelAdd.Location = new Point(119, 3);
            panelUpdate.Location = new Point(119, 3);
            panelActive.Hide();
        }

        private void btnSerach_Click(object sender, EventArgs e)
        {
            panelActive.Location = new Point(btnSearch.Location.X - 13, btnSearch.Location.Y - 12);
            panelActive.Show();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            panelActive.Location = new Point(btnAdd.Location.X - 13, btnAdd.Location.Y - 12);
            panelAdd.Show();
            panelUpdate.Hide();

            panelActive.Show();
           
        }
        private void btnDlt_Click(object sender, EventArgs e)
        {
            panelActive.Location = new Point(btnDlt.Location.X - 13, btnDlt.Location.Y - 12);
            panelActive.Show();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            panelActive.Location = new Point(btnUpdate.Location.X - 13, btnUpdate.Location.Y - 12);
            panelAdd.Hide();
            panelUpdate.Show();
            panelActive.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            this.Hide();
            mf.Show();
        }
    }
}
