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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NatureHabitat
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Products_Load(object sender, EventArgs e)
        {
            comboBStatus.SelectedIndex = 0;
            LoadData();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-71OIJB32\\NATUREHABITAT;Initial Catalog=NatureHabitat;Integrated Security=True");
            //Insert Logic
            con.Open();
            bool status = false;
            if (comboBStatus.SelectedIndex == 0)
            {
                status = true;
            }
            else
            {
                status = false;
            }

            var sqlQuery = "";
            if (IfProductsExists(con, txtPCode.Text))
            {
                sqlQuery = @"UPDATE[Products] SET[ProductName] = '" + txtPName.Text + "' ,[ProductStatus] = '" + status + "' WHERE[ProductCode] = '" + txtPCode.Text + "'";
            }
            else
            {
                sqlQuery = @" INSERT INTO [NatureHabitat].[dbo].[Products] ([ProductCode],[ProductName],[ProductStatus]) Values 
                            ('" + txtPCode.Text + "','" + txtPName.Text + "','" + status + "')";
            }

            SqlCommand cmd = new SqlCommand
                (sqlQuery, con);
            cmd.ExecuteNonQuery();
            con.Close();

            //Reading Data
            LoadData();
        }

        private bool IfProductsExists(SqlConnection con, string productCode)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELect 1 From [Products] Where [ProductCode]='" + productCode + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
        public void LoadData()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-71OIJB32\\NATUREHABITAT;Initial Catalog=NatureHabitat;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELect * From [dbo].[Products]", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridProducts.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridProducts.Rows.Add();
                dataGridProducts.Rows[n].Cells[0].Value = item["ProductCode"].ToString();
                dataGridProducts.Rows[n].Cells[1].Value = item["ProductName"].ToString();
                if ((bool)item["ProductStatus"])
                {
                    dataGridProducts.Rows[n].Cells[2].Value = "Active";
                }
                else
                {
                    dataGridProducts.Rows[n].Cells[2].Value = "Deactive";
                }
            }
        }

        private void dataGridProducts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtPCode.Text = dataGridProducts.SelectedRows[0].Cells[0].Value.ToString();
            txtPName.Text = dataGridProducts.SelectedRows[0].Cells[1].Value.ToString();
            if (dataGridProducts.SelectedRows[0].Cells[2].Value.ToString() == "Active")
            {
                comboBStatus.SelectedIndex = 0;
            }
            else
            {
                comboBStatus.SelectedIndex = 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-71OIJB32\\NATUREHABITAT;Initial Catalog=NatureHabitat;Integrated Security=True");
            var sqlQuery = "";
            if (IfProductsExists(con, txtPCode.Text))
            {
                con.Open();
                sqlQuery = @"DELETE FROM [Products] WHERE[ProductCode] = '" + txtPCode.Text + "'";
                SqlCommand cmd = new SqlCommand
                (sqlQuery, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                MessageBox.Show("Record Not Exists....!");
            }
            //Reading Data
            LoadData();
        }
    }
}
