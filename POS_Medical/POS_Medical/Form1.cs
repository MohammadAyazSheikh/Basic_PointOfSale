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

        int panelW = 150;
        int panelH = 660;
        public MainForm()
        {
            InitializeComponent();
           
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            //panelContainer.Size = new Size(660,150);
            panelContainer.Width = panelW;
            btnMenu.Location = new Point(panelContainer.Width, btnMenu.Location.Y);
        }
    }
}
