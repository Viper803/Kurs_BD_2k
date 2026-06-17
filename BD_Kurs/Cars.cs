using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_Kurs
{
    public partial class Cars : Form
    {
        public Cars()
        {
            InitializeComponent();
            LoadCarsData();
        }
        private void LoadCarsData()
        {
            string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=TransportCompany;Integrated Security=True;TrustServerCertificate=True";
            string query = "SELECT * FROM Cars"; // Замените Cars на имя вашей таблицы

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
            this.Hide();
        }
    }
}
