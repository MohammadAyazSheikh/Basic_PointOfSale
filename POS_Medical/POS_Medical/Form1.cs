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
    public partial class MainForm : Form
    {
        Timer timer;

        int panelW = 70;
        int panelH = 660;
        bool isOpen = false;
        public MainForm()
        {
            InitializeComponent();
          

        }



        //private void btnMenu_Click_1(object sender, EventArgs e)
        //{
        //    if (isOpen)
        //    {
        //        panelContainer.Width = panelW;
        //        btnCustomer.Width = 65;
        //        btnCustomer.Height = 55;
        //        btnOrder.Width = 65;
        //        btnOrder.Height = 55;
        //        btnProduct.Width = 65;
        //        btnProduct.Height = 55;
        //        btnMenu.Location = new Point(panelContainer.Width, btnMenu.Location.Y);
        //        isOpen = false;
        //        //btnMenu.BringToFront();

        //    }
        //    else
        //    {
        //        panelContainer.Width = 150;
        //        btnCustomer.Width = 145;
        //        btnCustomer.Height = 135;
        //        btnOrder.Width = 145;
        //        btnOrder.Height = 135;
        //        btnProduct.Width = 145;
        //        btnProduct.Height = 135;
        //        btnMenu.Location = new Point(panelContainer.Width, btnMenu.Location.Y);
        //        isOpen = true;
        //        //btnMenu.BringToFront();
        //    }
        //}


        private void btnProduct_Click(object sender, EventArgs e)
        {
            FormProduct fp = new FormProduct();
            fp.Show();
            this.Hide();
        }
    }
}
