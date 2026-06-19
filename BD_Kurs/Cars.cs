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
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LoadCarsData();
        }
        private DataTable originalTable;
        private void LoadCarsData()
        {
            string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=TransportCompany;Integrated Security=True;TrustServerCertificate=True";
            string query = "SELECT * FROM Cars"; // Замените Cars на имя вашей таблицы

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

            string filter;
            if (column.Equals("Capacity", StringComparison.OrdinalIgnoreCase))
            {
                if (!decimal.TryParse(value, out decimal capacityValue))
                {
                    MessageBox.Show("Введите числовое значение для поиска", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                filter = $"[{column.Replace("'", "''")}] >= {capacityValue.ToString(System.Globalization.CultureInfo.InvariantCulture)}";
            }
            else
            {
                filter = string.Format("[{0}] = '{1}'", column.Replace("'", "''"), value.Replace("'", "''"));
            }

            DataRow[] foundRows = originalTable.Select(filter);

            if (foundRows.Length == 0)
            {
                MessageBox.Show("Совпадений не найдено.", "Результат поиска", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = originalTable;
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
