using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kkk
{
    public partial class Form3 : Form
    {
        string ConnString = "Host=localhost;Username=postgres;Password=5974;Database=Customers";
        DataGridView dataGridView1;
        int X;
        public Form3()
        {
            InitializeComponent();


        }
        public Form3(string x,DataGridView dataGridView) 
        {
            InitializeComponent();
            dataGridView1 = dataGridView;
            X = Convert.ToInt32(x);
            using var connect = new NpgsqlConnection(ConnString);
            connect.Open();
            string command_text = "SELECT * FROM Customers WHERE customer_id=@customer_id";
            using var command = new NpgsqlCommand(command_text,connect);
            command.Parameters.AddWithValue("@customer_id", X);
            using NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                tb_name1.Text = reader.GetString(3);
                tb_City.Text = reader.GetString(2);
                tb_phone.Text = reader.GetString(1);
                cb_status.Text = reader.GetString(4);
            }
        }
        private void button_add_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tb_phone.Text.Length; i++)
            {
                if (!Char.IsDigit(tb_phone.Text[i]))
                {
                    if (tb_phone.Text[i] == '+') { continue; }
                    MessageBox.Show("Field(Phone) can contain phone number\n Example-89387775974\\+79387775974");
                    tb_phone.Text = "";
                }

            }
            for (int i = 0; i < tb_City.Text.Length; i++)
            {
                if (!Char.IsLetter(tb_City.Text[i]) || tb_City.Text.Length > 32)
                {
                    if (tb_City.Text[i] == '-') { continue; }
                    MessageBox.Show("Field(City) can contain Customer's City(Only letters, lenght - 32)");
                    tb_City.Text = "";
                }
            }
            for (int i = 0; i < tb_name1.Text.Length; i++)
            {
                if (!Char.IsLetter(tb_name1.Text[i]) || tb_name1.Text.Length > 32)
                {
                    if (tb_name1.Text[i] == '-') { continue; }
                    MessageBox.Show("Field(Name) can contain Customer's Name(Only letters, lenght - 32)");
                    tb_name1.Text = "";
                }
            }



            if (tb_City.Text != "" && tb_phone.Text != "" && tb_name1.Text != "" && cb_status.Text != "")
            {
                using var connect = new NpgsqlConnection(ConnString);
                connect.Open();
                string command_text = $"UPDATE Customers SET phone=@Phone,city=@City,customer_name=@Name,customer_status=@customer_status";
                using var command = new NpgsqlCommand(command_text, connect);
                command.Parameters.AddWithValue("@Phone", tb_phone.Text);
                command.Parameters.AddWithValue("@City", tb_City.Text);
                command.Parameters.AddWithValue("@Name", tb_name1.Text);
                command.Parameters.AddWithValue("@customer_status", cb_status.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Sucsesfull");

                Close();
            }
            else
                MessageBox.Show("Customer has no changed");

            tb_City.Text = "";
            tb_phone.Text = "";



            
        }
    }
}
