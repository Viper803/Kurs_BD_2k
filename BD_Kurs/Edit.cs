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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BD_Kurs
{
    public partial class Edit : Form
    {
        private readonly string connectionString =
            "Data Source=.\\SQLEXPRESS;Initial Catalog=TransportCompany;Integrated Security=True;TrustServerCertificate=True";
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable table;
        public Edit()

        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            dataGridView1.DataSource = null;

            comboBox1.Items.Add("Trips");
            comboBox1.Items.Add("Drivers");
            comboBox1.Items.Add("Cars");
            comboBox1.Items.Add("CargoTypes");

            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSelectedTable();
        }
        private void LoadSelectedTable()
        {
            if (comboBox1.SelectedItem == null)
                return;

            string tableName = comboBox1.SelectedItem.ToString();

            adapter = new SqlDataAdapter($"SELECT * FROM {tableName}", connection);

            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            table = new DataTable();
            adapter.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (adapter == null || table == null)
            {
                MessageBox.Show("Сначала выберите таблицу.");
                return;
            }

            try
            {
                dataGridView1.EndEdit();

                adapter.Update(table);

                MessageBox.Show("Изменения сохранены.", "Успешно",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения: " + ex.Message,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;

            if (!dataGridView1.CurrentRow.IsNewRow)
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadSelectedTable();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
            this.Hide();
        }
    }
}
