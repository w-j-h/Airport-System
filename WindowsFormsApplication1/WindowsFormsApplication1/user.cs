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
    public partial class user : Form
    {
        private string n;

        public user(string value)
        {
            InitializeComponent();
            label1.Text = "Welcome: " + value;
            string n = value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            book b = new book();
            b.Show();
        }

        private void user_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            deletebook delb = new deletebook();
            delb.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=DESKTOP-7KB122K\\WASSIMSQL; initial catalog=airport; integrated security=true");
            con.Open();
            SqlCommand cmd = new SqlCommand("select Flight_no, Flight_Destination, company_name, Date from Flight inner join Company on Flight.Company_ID = Company.Company_ID where Flight.Flight_Destination = @dist", con);
            SqlParameter dist = new SqlParameter("@dist", textBox1.Text);
            cmd.Parameters.Add(dist);
            if (textBox1.Text == "all")
            {
                cmd = new SqlCommand("select Flight_no, Flight_Destination, company_name, Date from Flight inner join Company on Flight.Company_ID = Company.Company_ID", con);
            }
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtbl = new DataTable();
            adapter.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            con.Close();
        }
    }
}
