using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kkk
{
    public partial class Form2 : Form
    {
        protected string ConnString = "Host=localhost;Username=postgres;Password=5974;Database=Customers";
        public Form2()
        {
            InitializeComponent();
            
        }

      

        public virtual void button_add_Click(object sender, EventArgs e)
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
                if (!Char.IsLetter(tb_City.Text[i])||tb_City.Text.Length>32)
                {
                    if (tb_City.Text[i] == '-') {  continue; }
                        MessageBox.Show("Field(City) can contain Customer's City(Only letters, lenght - 32)");
                    tb_City.Text = "";
                }
            }
            for (int i = 0; i < tb_name.Text.Length; i++)
            {
                if (!Char.IsLetter(tb_name.Text[i])||tb_name.Text.Length>32)
                    {
                    if (tb_name.Text[i] == '-') { continue; }
                    MessageBox.Show("Field(Name) can contain Customer's Name(Only letters, lenght - 32)");
                    tb_name.Text = "";
                }
            }



            if (tb_City.Text != "" && tb_phone.Text != "" && tb_name.Text != "" &&cb_status.Text!="")
            {
                using var connect = new NpgsqlConnection(ConnString);
                connect.Open();
                string command_text = $"INSERT INTO Customers(Phone,City,customer_name,customer_status) VALUES (@Phone,@City,@Name,@customer_status)";
                using var command = new NpgsqlCommand(command_text, connect);
                command.Parameters.AddWithValue("@Phone", tb_phone.Text);
                command.Parameters.AddWithValue("@City", tb_City.Text);
                command.Parameters.AddWithValue("@Name", tb_name.Text);
                command.Parameters.AddWithValue("@customer_status",cb_status.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Sucsesfull");


            }
            else
                MessageBox.Show("Customer has bo aded");
          
            tb_City.Text = "";
            tb_phone.Text = "";
           
          
           
            
        }

       
    }
}
