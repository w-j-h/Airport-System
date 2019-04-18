using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=DESKTOP-7KB122K\\WASSIMSQL; initial catalog=airport; integrated security=true");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Passenger(Passenger_name,Passenger_username,Passenger_password) values(@p_name,@p_username,@p_password)", con);
            SqlParameter name = new SqlParameter("@p_name",textBox3.Text);
            cmd.Parameters.Add(name);
            SqlParameter username = new SqlParameter("@p_username", textBox1.Text);
            cmd.Parameters.Add(username);
            SqlParameter password = new SqlParameter("@p_password", textBox2.Text);
            cmd.Parameters.Add(password);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("saved");
            Form1 login = new Form1();
            login.Show();
            Visible = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
