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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void loginmiddlepannel_Paint(object sender, PaintEventArgs e)
        {

        }

    
        private void loginhomebutton_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 f = new Form1();
            f.Show();
        }

        private void passwordtextbox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void usernametextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernametextbox_Enter(object sender, EventArgs e)
        {

        }

 
        private void usernametextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(usernametextbox.Text == string.Empty))
                {
                    if (!(passwordtextbox.Text == string.Empty))
                    {
                     
                        string str = @"server=localhost;User Id=root; password=root;database=asrs";
                        String query = "select * from asrs.user where username = '" + usernametextbox.Text + "'and password = '" + this.passwordtextbox.Text + "'";
                        MySqlConnection con = new MySqlConnection(str);
                        MySqlCommand cmd = new MySqlCommand(query, con);
                        MySqlDataReader dbr;
                        con.Open();
                        dbr = cmd.ExecuteReader();
                        int count = 0;
                        while (dbr.Read())
                        {
                            count = count + 1;
                        }
                        if (count == 1)
                        {
                            home1 a = new home1();
                            a.Show();
                            this.Hide();

                        }
                        else if (count > 1)
                        {
                            MessageBox.Show("Duplicate username and password", "login page");
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password", "login page");
                        }
                  
                    }
                    else
                    {
                        MessageBox.Show("Enter password ", "login page");
                    }
                }

                else
                {
                    MessageBox.Show("Enter username", "login page");
                }
                

            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            signup j = new signup();
            j.Show();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(usernametextbox.Text == string.Empty))
                {
                    if (!(passwordtextbox.Text == string.Empty))
                    {

                        string str = @"server=localhost;User Id=root; password=root;database=asrs";
                        String query = "select * from asrs.user where username = '" + usernametextbox.Text + "'and password = '" + this.passwordtextbox.Text + "'";
                        MySqlConnection con = new MySqlConnection(str);
                        MySqlCommand cmd = new MySqlCommand(query, con);
                        MySqlDataReader dbr;
                        con.Open();
                        dbr = cmd.ExecuteReader();
                        int count = 0;
                        while (dbr.Read())
                        {
                            count = count + 1;
                        }
                        if (count == 1)
                        {
                            home1 a = new home1();
                            a.Show();
                            this.Hide();

                        }
                        else if (count > 1)
                        {
                            MessageBox.Show("Duplicate username and password", "login page");
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password", "login page");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Enter password ", "login page");
                    }
                }

                else
                {
                    MessageBox.Show("Enter username", "login page");
                }


            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);

            }
        }

        private void llabel_Click(object sender, EventArgs e)
        {

        }

        
        


      
    }
}
