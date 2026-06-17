using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace BD_Kurs
{
    public partial class Drivers : Form
    {
        public Drivers()
        {
            InitializeComponent();
            LoadDriversData();
        }
        private void LoadDriversData()
        {
            string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=TransportCompany;Integrated Security=True;TrustServerCertificate=True";
            string query = "SELECT * FROM Drivers"; // Замените Cars на имя вашей таблицы

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
