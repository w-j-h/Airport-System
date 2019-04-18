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
    public partial class deletebook : Form
    {
        public deletebook()
        {
            InitializeComponent();
        }

        private void deletebook_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
       
            SqlConnection con = new SqlConnection("data source=DESKTOP-7KB122K\\WASSIMSQL; initial catalog=airport; integrated security=true");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete_booking", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(
                new SqlParameter("@username", textBox1.Text));
            cmd.Parameters.Add(
                new SqlParameter("@flightno", textBox2.Text));
            DialogResult form1 = MessageBox.Show("Do you really want to cancel this booking?",
                "Exit", MessageBoxButtons.YesNo);


            if (form1 == DialogResult.Yes)
            {
                SqlDataReader reader = cmd.ExecuteReader();
                MessageBox.Show("the book deleted");
                this.Hide();
            }
            con.Close();
           
        }
    }
}
