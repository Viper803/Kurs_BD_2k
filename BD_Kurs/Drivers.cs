using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
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
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LoadDriversData();
        }
        private DataTable originalTable;
        private void LoadDriversData()
        {
            string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=TransportCompany;Integrated Security=True;TrustServerCertificate=True";
            string query = "SELECT * FROM Drivers";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                originalTable = dt; // сохраняем оригинал
                dataGridView1.DataSource = dt;
                comboBox1.Items.Clear();
                foreach (DataColumn column in dt.Columns)
                {
                    comboBox1.Items.Add(column.ColumnName);
                }
                if (comboBox1.Items.Count > 0)
                    comboBox1.SelectedIndex = 0;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Выберите столбец для поиска.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string column = comboBox1.SelectedItem.ToString();
            string value = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(value))
            {
                MessageBox.Show("Введите значение для поиска.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (originalTable == null) return;

            string filter = string.Format("[{0}] = '{1}'", column.Replace("'", "''"), value.Replace("'", "''"));
            DataRow[] foundRows = originalTable.Select(filter);

            if (foundRows.Length == 0)
            {
                MessageBox.Show("Совпадений не найдено.", "Результат поиска", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = originalTable; // Показываем все данные
            }
            else
            {
                DataTable result = originalTable.Clone();
                foreach (DataRow row in foundRows)
                    result.ImportRow(row);
                dataGridView1.DataSource = result;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (originalTable != null)
            {
                dataGridView1.DataSource = originalTable;
            }
        }
    }
}
