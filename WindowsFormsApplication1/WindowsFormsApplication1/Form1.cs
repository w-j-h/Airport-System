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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("data source=DESKTOP-7KB122K\\WASSIMSQL; initial catalog=airport; integrated security=true");

            if (checkBox1.Checked)
            {
                SqlCommand li = new SqlCommand("select * from Admin where admin_name = @name and admin_password = @pass", con);
                con.Open();
                SqlParameter pass = new SqlParameter("@pass", textBox1.Text);
                SqlParameter name = new SqlParameter("@name", E_mail.Text);
                li.Parameters.Add(name);
                li.Parameters.Add(pass);
                SqlDataReader myreader = li.ExecuteReader();
                if (myreader.Read())
                {
                    this.Hide();
                    admin admin = new admin(E_mail.Text);
                    admin.Show();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("the username or the password is invalid");
                    E_mail.Clear();
                    textBox1.Clear();
                    E_mail.Focus();
                    con.Close();
                }

            }
            else
            {
            SqlCommand li2 = new SqlCommand("select * from Passenger where Passenger_username = @name and Passenger_password = @pass", con);
                con.Open();
                
                SqlParameter pass = new SqlParameter("@pass", textBox1.Text);
                SqlParameter name = new SqlParameter("@name", E_mail.Text);
                li2.Parameters.Add(name);
                li2.Parameters.Add(pass);
                SqlDataReader myreader = li2.ExecuteReader();
                
                if (myreader.Read())
                {
                    this.Hide();
                    user user = new user(E_mail.Text);
                    user.Show();
                    con.Close();
                
                    
                }
                else
                {
                    MessageBox.Show("the username or the password is invalid");

                    E_mail.Clear();
                    textBox1.Clear();
                    E_mail.Focus();
                    myreader.Close();
                    con.Close();
                }
 
            }
            con.Close();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 signup = new Form2();
            signup.Show();
            Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult form1 = MessageBox.Show("Do you really want to close the program?",
                "Exit", MessageBoxButtons.YesNo);


            if (form1 == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }

        }
    }
}
