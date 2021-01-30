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
    public partial class upanimal : Form
    {
        public upanimal()
        {
            InitializeComponent();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DataSet d = new DataSet();
            try
            {
                MySqlConnection sql_con = new MySqlConnection("server=localhost;User Id=root; password=root;database=db");
                String str_query = "select categoryname,cid from db.category group by cid ";
                sql_con.Open();
                MySqlDataAdapter DTA = new MySqlDataAdapter(str_query, sql_con);
                DTA.Fill(d);
                sql_con.Close();

            }
            catch (Exception)
            {


            }


            dataGridView1.DataSource = d.Tables[0];
        }

        private void stateid_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            String an = a.Text;
            DataSet d = new DataSet();
            try
            {
                MySqlConnection sql_con = new MySqlConnection("server=localhost;User Id=root; password=root;database=db");
                String str_query = "select animalid, animalname from db.animal where animalname ='" + an + "'";
                sql_con.Open();
                MySqlDataAdapter DTA = new MySqlDataAdapter(str_query, sql_con);
                DTA.Fill(d);
                sql_con.Close();

            }
            catch (Exception)
            {


            }

            dataGridView1.DataSource = d.Tables[0];
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DataSet d = new DataSet();
            try
            {
                MySqlConnection sql_con = new MySqlConnection("server=localhost;User Id=root; password=root;database=db");
                String str_query = "select subcategoryname,scid from db.subcategory group by scid ";
                sql_con.Open();
                MySqlDataAdapter DTA = new MySqlDataAdapter(str_query, sql_con);
                DTA.Fill(d);
                sql_con.Close();

            }
            catch (Exception)
            {


            }


            dataGridView1.DataSource = d.Tables[0];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!((a1.Text == "") || (a2.Text == "")
           || (a3.Text == "") || (a4.Text == "") || (
           a5.Text == "")||(textBox1.Text=="")))
            {
                String aa = a1.Text;
                String ab = a2.Text;
                int ac = int.Parse(a3.Text);
                int ad = int.Parse(a4.Text);
                int ae = int.Parse(a5.Text);
                int az = int.Parse(textBox1.Text);
                try
                {
                    string query = "update db.animal set animalname='" + a1.Text + "',scientificname='" + a2.Text + "' ,averageheight='" + a3.Text + "' ,averageweight='" + a4.Text + "' ,lifespan='" + a5.Text + "'where animalid='" + az + "'";
               

                    MySqlConnection sqlp = new MySqlConnection("server=localhost;User Id=root; password=root;database=db");


                    sqlp.Open();
                    MySqlCommand cmd = new MySqlCommand(query, sqlp);
                    cmd.ExecuteNonQuery();
                    sqlp.Close();
                    MessageBox.Show("done");
                }
                catch (Exception)
                {

                }
            }
            else { MessageBox.Show("Enter every field"); }

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void l_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
