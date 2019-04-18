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
    public partial class book : Form
    {
        public book()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("data source=DESKTOP-7KB122K\\WASSIMSQL; initial catalog=airport; integrated security=true");
                con.Open();
                SqlCommand cmd = new SqlCommand("book", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(
                    new SqlParameter("@username", textBox1.Text));
                cmd.Parameters.Add(
                    new SqlParameter("@flightno", textBox2.Text));
                SqlDataReader reader = cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("the flight booked");
                this.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void book_Load(object sender, EventArgs e)
        {

        }
    }
}
