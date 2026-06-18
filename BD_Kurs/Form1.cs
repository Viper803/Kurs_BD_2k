using System.Data;
using System.Data.SqlClient;
namespace BD_Kurs
{

    public partial class Form1 : Form
    {
        /*void LoadData()
        {
            string connectionString =
                "Data Source=localhost;Initial Catalog=YourDatabaseName;Integrated Security=True";

            string query = "SELECT * FROM Drivers"; // имя таблицы

            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }*/
        public Form1()
        {
            InitializeComponent();
            /*LoadData();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cars carsForm = new Cars();
            carsForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Drivers DriversForm = new Drivers();
            DriversForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Trips TripsForm = new Trips();
            TripsForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Edit EditForm = new Edit();
            EditForm.Show();
            this.Hide();
        }
    }
}
