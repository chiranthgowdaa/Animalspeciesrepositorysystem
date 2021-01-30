using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace asrs
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (!(ust.Text == string.Empty))
                {
                    if (!(pst.Text == string.Empty))
                    {
                        if ((pst.Text == pst2.Text))
                        {
                            if (uidt.Text == "123")
                            {
                                String b = ust.Text;
                                String c = pst.Text;

                                string query = "insert into asrs.user  values ('" + b + "','" + c + "')";

                                MySqlConnection sqlp = new MySqlConnection("server=localhost;User Id=root; password=root;database=asrs");


                                sqlp.Open();
                                MySqlCommand cmd = new MySqlCommand(query, sqlp);
                                cmd.ExecuteNonQuery();
                                sqlp.Close();
                                MessageBox.Show("added user sucessfully");
                                this.Hide();
                                    login l= new login();
                                    l.Show();
                            }
                            else { MessageBox.Show("Unique Id incorrect", "login page"); }
                        }
                        else { MessageBox.Show("password not matching", "login page"); }
                    }
                    else { MessageBox.Show("Fill the required field", "login page"); }
                    }
                    else { MessageBox.Show("Fill the required field", "login page"); }
                }
            

            catch (Exception)
            {
            }
        
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            login a = new login();
            a.Show();
        }

        private void loginhomebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

    }
}
