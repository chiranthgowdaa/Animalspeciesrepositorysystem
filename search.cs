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
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            signup s = new signup();
            s.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            login l = new login();
            l.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
                f.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (!(comboBox1.Text == ""))
            {
                if (comboBox1.Text == "Search by name ")
                { sbn.Visible = true;
                sbp.Visible = false;
                sbs.Visible = false;
                sbc.Visible = false;
                sbe.Visible = false;
                }
            
                else if (comboBox1.Text == "Search by Population")
                { sbp.Visible = true;
                sbs.Visible = false;
                sbc.Visible = false;
                sbe.Visible = false;
                }
            
                else if (comboBox1.Text == "Search by State")
                { sbs.Visible = true;
                sbc.Visible = false;
                sbe.Visible = false;
                }
            
                else if (comboBox1.Text == "Search by catagory")
                { sbc.Visible = true;
                sbe.Visible = false;
                }
            
                else if (comboBox1.Text == "Search by endanger level")
                { sbe.Visible = true; }
                else { }


            }
            else { MessageBox.Show("Enter the way how you want to search"); }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
          


        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (!((comboBox6.Text == "") || (textBox4.Text == "")))
            {
                DataSet d = new DataSet();
                try
                {
                    MySqlConnection sql_con = new MySqlConnection("server=localhost;User Id=root; password=root;database=asrs");
                    String str_query = "select a.animalname,p.population,s.statename from db.animal a,db.detail p,db.state s where s.statename='" + comboBox6.SelectedItem.ToString() + "' and p.population>'" + int.Parse(textBox4.Text)+ "'and s.stateid=p.sid and p.aid=a.animalid";

                    sql_con.Open();
                    MySqlDataAdapter DTA = new MySqlDataAdapter(str_query, sql_con);
                    DTA.Fill(d);
                    sql_con.Close();

                }
                catch (Exception)
                {
                    MessageBox.Show("Not found");

                }

                dataGridView1.DataSource = d.Tables[0];
            }
            else { MessageBox.Show("enter the fields"); }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (!(comboBox2.Text == "") )
            {
                String endanger="";
                if (i.Checked)
                {
                    endanger = "yes";
                }
                else if (h.Checked)
                {
                    endanger = "no";
                }
                DataSet d = new DataSet();
                try
                {
                    MySqlConnection sql_con = new MySqlConnection("server=localhost;User Id=root; password=root;database=db");
                    String str_query = "select a.animalname,p.population,s.statename,p.endanger from db.animal a,db.detail p,db.state s where s.statename='" + comboBox2.SelectedItem.ToString() + "' and p.endanger='"+endanger+"' and s.stateid=p.sid and p.aid=a.animalid";

                    sql_con.Open();
                    MySqlDataAdapter DTA = new MySqlDataAdapter(str_query, sql_con);
                    DTA.Fill(d);
                    sql_con.Close();

                }
                catch (Exception)
                {
                    MessageBox.Show("Not found");

                }

                dataGridView1.DataSource = d.Tables[0];
            }
            else { MessageBox.Show("Enter any field"); }

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            if (!((textBox1.Text == "") ))
            {
                if (!(textBox1.Text == ""))
                {
                    
                 
                    DataSet d = new DataSet();
                    try
                    {
                        MySqlConnection sql_con = new MySqlConnection("server=localhost;User Id=root; password=root;database=db");
                        String str_query = ("select animalname,animalid,lifespan, averageheight,averageweight from db.animal where animalname='" + textBox1.Text + "' ");
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
                else { MessageBox.Show("Enter valid name"); }
            }
            else { MessageBox.Show("Enter any field"); }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (!(comboBox6.Text == ""))
            {


                DataSet d = new DataSet();
                try
                {
                    MySqlConnection sql_con = new MySqlConnection("server=localhost;User Id=root; password=root;database=db");
                    String str_query = ("select s.stateid,s.statename,a.animalname,a.animalid,a.lifespan, a.averageheight,a.averageweight from db.animal a, db.state s,db.detail d where s.statename='" + comboBox6.SelectedItem.ToString() + "' and s.stateid=d.sid  and d.aid=a.animalid ");
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
            else { }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
         if (!(textBox10.Text == ""))
               
                {
                    
                 
                    DataSet d = new DataSet();
                    try
                    {
                        MySqlConnection sql_con = new MySqlConnection("server=localhost;User Id=root; password=root;database=db");
                        String str_query = ("select a.animalname,a.animalid,a.lifespan ,a.averageheight,a.averageweight,c.categoryname from db.animal a,db.category c where c.categoryname='" + textBox10.Text + "' and c.cid=a.cid");
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
                else { MessageBox.Show("Enter valid name"); }
            
        }

        
    }
}
