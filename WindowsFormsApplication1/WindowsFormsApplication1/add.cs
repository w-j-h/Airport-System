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
    public partial class add : Form
    {
        public add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("data source=DESKTOP-7KB122K\\WASSIMSQL; initial catalog=airport; integrated security=true");
                con.Open();
                SqlCommand cmd = new SqlCommand("insert_flights", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(
                    new SqlParameter("@companyid", textBox1.Text));
                cmd.Parameters.Add(
                    new SqlParameter("@duration", textBox2.Text));
                cmd.Parameters.Add(
                   new SqlParameter("@flightdistination", textBox3.Text));
                cmd.Parameters.Add(
                   new SqlParameter("@thedate", textBox4.Text));
                SqlDataReader reader = cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("the flight added");
                this.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
