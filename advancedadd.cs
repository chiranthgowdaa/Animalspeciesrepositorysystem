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
    public partial class advancedadd : Form
    {
        public advancedadd()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            panel7.Visible = true;
            panel8.Visible = false;
            panel9.Visible = false;

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            if (!((textBox1.Text == "") || (textBox2.Text == "") ))
            {
                String a1 = textBox1.Text;

                int a3 = int.Parse(textBox2.Text);
            
                try
                {
                    string q3 = "insert into db.category values('" + a3 + "','" + a1 + "')";

                    MySqlConnection sqlp = new MySqlConnection("server=localhost;User Id=root; password=root;database=db");


                    sqlp.Open();
                    MySqlCommand cmd2 = new MySqlCommand(q3, sqlp);
                    cmd2.ExecuteNonQuery();
                    sqlp.Close();
                    MessageBox.Show("done");
                }
                catch (Exception)
                {
                    MessageBox.Show("state exist");
                }
            }
            else { MessageBox.Show("fill all the fields"); }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            panel8.Visible = true;
            panel9.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel9.Visible = true; 
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel7.Visible = true;
            panel8.Visible = false;
            panel9.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            panel7.Visible = true;
            panel8.Visible = false;
            panel9.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel8.Visible = true;
            panel9.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            panel8.Visible = true;
            panel9.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            panel9.Visible = true; 
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

            if (!((textBox6.Text == "") || (textBox5.Text == "") ))
            {
                String a1 = textBox6.Text;
            
                int a3 = int.Parse(textBox5.Text);
               
                try
                {
                    string q3 = "insert into db.state values('" + a3+ "','" + a1 + "')";

                    MySqlConnection sqlp = new MySqlConnection("server=localhost;User Id=root; password=root;database=db");


                    sqlp.Open();
                    MySqlCommand cmd2 = new MySqlCommand(q3, sqlp);
                    cmd2.ExecuteNonQuery();
                    sqlp.Close();
                    MessageBox.Show("done");
                }
                catch (Exception)
                {
                    MessageBox.Show("state exist");
                }
            }
            else { MessageBox.Show("fill all the fields"); }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            
            if (!((textBox3.Text == "") || (textBox4.Text == "")||(textBox7.Text=="") ))
            {
                String a1 = textBox3.Text;
            
                int a3 = int.Parse(textBox4.Text);
               int a4 = int.Parse(textBox7.Text);
                try
                {
                    string q3 = "insert into db.subcategory values('" + a3+ "','" + a1 + "','"+a4+"')";

                    MySqlConnection sqlp = new MySqlConnection("server=localhost;User Id=root; password=root;database=db");


                    sqlp.Open();
                    MySqlCommand cmd2 = new MySqlCommand(q3, sqlp);
                    cmd2.ExecuteNonQuery();
                    sqlp.Close();
                    MessageBox.Show("done");
                }
                catch (Exception)
                {
                    MessageBox.Show("state exist");
                }
            }
            else { MessageBox.Show("fill all the fields"); }
        }

        }
    }

