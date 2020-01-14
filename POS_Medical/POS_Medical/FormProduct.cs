using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            panelSearchandDlt.Location = new Point(119, 3);
            panelActive.Hide();

            panelActive.Location = new Point(btnAdd.Location.X - 13, btnAdd.Location.Y - 12);
            panelAdd.Show();
            panelSearchandDlt.Hide();
            panelUpdate.Hide();
            panelActive.Show();
        }

        List<Product> getProduct()
        {
            List<Product> lstPro = new List<Product>();
            SqlCommand sc = new SqlCommand("GetAllProduct", Connection.GetConnection());
            sc.CommandType = CommandType.StoredProcedure;
            SqlDataReader sdr = sc.ExecuteReader();
            while (sdr.Read())
            {
                lstPro.Add(new Product()
                {
                    ID = (int)sdr[0],
                    Name = (string)sdr[1],
                    price = (float)sdr[2]
                });

            }
            sdr.Close();
         
            return lstPro;
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
            panelSearchandDlt.Hide();
            panelUpdate.Hide();
            panelActive.Show();
           
        }
        private void btnDlt_Click(object sender, EventArgs e)
        {
            panelActive.Location = new Point(btnDlt.Location.X - 13, btnDlt.Location.Y - 12);
            panelAdd.Hide();
            panelSearchandDlt.Show();
            panelUpdate.Hide();
            panelActive.Show();

            //dgv.DataSource = getProduct();

            SqlDataAdapter sd = new SqlDataAdapter("select * from  POS_DB.dbo.Product;",Connection.GetConnection());
            DataTable Dt = new DataTable();
            sd.Fill(Dt);
            dgv.AutoGenerateColumns = false;
            dgv.DataSource = Dt;
            
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            panelActive.Location = new Point(btnUpdate.Location.X - 13, btnUpdate.Location.Y - 12);
            panelAdd.Hide();
            panelSearchandDlt.Hide();
            panelUpdate.Show();
            panelActive.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            this.Hide();
            mf.Show();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            SqlCommand sc = new SqlCommand("AddProduct", Connection.GetConnection());
            sc.CommandType = CommandType.StoredProcedure;
            sc.Parameters.AddWithValue("Name", txtNameAdd.Text);
            sc.Parameters.AddWithValue("Price", txtPriceAdd.Value);
            sc.ExecuteNonQuery();
        }

    

    
    }
}
