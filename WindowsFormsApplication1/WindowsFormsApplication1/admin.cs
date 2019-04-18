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
    public partial class admin : Form
    {
        public admin(string value)
        {
            InitializeComponent();
            label1.Text = "Welcome: "+ value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            delete del = new delete();
            del.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            add add = new add();
            add.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            update up = new update();
            up.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            updatedist updist = new updatedist();
            updist.Show();
        }

        private void admin_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=DESKTOP-7KB122K\\WASSIMSQL; initial catalog=airport; integrated security=true");
            con.Open();
            SqlCommand cmd = new SqlCommand("select Flight_no,Flight_Destination,company_name,Date from Flight inner join Company on Flight.Company_ID = Company.Company_ID where Flight.Flight_Destination = @dist", con);
            SqlParameter dist = new SqlParameter("@dist", textBox1.Text);
            cmd.Parameters.Add(dist);
            if (textBox1.Text=="all")
            {
                cmd = new SqlCommand("select Flight_no, Flight_Destination, company_name, Date from Flight inner join Company on Flight.Company_ID = Company.Company_ID",con);
            }
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtbl = new DataTable();
            adapter.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            con.Close();
        }
    }
}
