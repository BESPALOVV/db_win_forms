using Npgsql;
using System.Data;
using System.Windows.Forms;
namespace kkk
{

    public partial class Form1 : Form
    {
        string ConnString = "Host=localhost;Username=postgres;Password=5974;Database=Customers";

        public Form1()
        {

            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            using NpgsqlConnection npgsqlConnection = new NpgsqlConnection(ConnString);
            npgsqlConnection.Open();
            //if (npgsqlConnection.FullState == ConnectionState.Open)
            //    MessageBox.Show(ConnString);
            using var command = new NpgsqlCommand();
            command.Connection = npgsqlConnection;
            command.CommandText = "SELECT * FROM Customers ORDER BY customer_id";
            using NpgsqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader.GetInt32(0), reader.GetString(3), reader.GetString(1), reader.GetString(2), reader.GetString(4));

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var f = new Form2();
            f.Show();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            string row;
            string command_text = "DELETE FROM Customers WHERE customer_id= @customer_id";



            if (dataGridView1.CurrentCell != null && dataGridView1.CurrentCell.Value != null && dataGridView1.CurrentCell.ColumnIndex == 0)
            {
                row = dataGridView1.CurrentCell.Value.ToString();
                using var connection = new NpgsqlConnection(ConnString);
                connection.Open();
                using var command = new NpgsqlCommand();
                command.Connection = connection;
                command.CommandText = command_text;
                command.Parameters.AddWithValue("@customer_id", Convert.ToInt32(row));
                command.ExecuteNonQuery();
                MessageBox.Show("Deleted Sucsessful");
            }
            else
                MessageBox.Show("Select id cell");

            
            button1_Click(sender, e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rewrite_button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 0 && dataGridView1.CurrentCell.Value != null)
            {
                string id = dataGridView1.CurrentCell.Value.ToString();
                var form = new Form3(id, dataGridView1);
                form.Show();
            }
            else
            {
                MessageBox.Show("Select id cell!");
            }
           

        }
    }
}
