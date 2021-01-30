using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Media;
namespace asrs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
           ppo.Ctlcontrols.stop();
            this.Hide();
            login l = new login();
            l.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            home1 h = new home1();
            h.Show();

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            signup s = new signup();
            s.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ppo.Ctlcontrols.stop();
            this.Hide();
            signup s = new signup();
            s.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
                     if (!(textBox1.Text == ""))
            {
                ppo.Visible = false;
                String a1 = a.Text;
                     String    a2 = b.Text;
                          String a3 =c.Text;
                         String a4 = h.Text;
                       String   a5 = z.Text;
                ppo.Ctlcontrols.stop();
                DataSet d = new DataSet();
                try
                {
                    MySqlConnection sql_con = new MySqlConnection("server=localhost;User Id=root; password=root;database=db");
          
                    sql_con.Open();

                    MySqlCommand cm = new MySqlCommand("select a.animalname,a.animalid,a.lifespan, a.averageheight,a.averageweight,c.categoryname,s.subcategoryname from db.animal a, db.category c, db.subcategory s where animalname='" + textBox1.Text + "' and s.cid=a.cid and c.cid=a.cid ",sql_con);
                    MySqlDataReader r;
                    r = cm.ExecuteReader();
                    while (r.Read())
                    {
                        b.Text = r["animalid"].ToString();
                        a.Text = r["animalname"].ToString();
                        h.Text = r["averageheight"].ToString();
                        z.Text = r["averageweight"].ToString();
                        c.Text = r["lifespan"].ToString();
                        x.Text = r["categoryname"].ToString();
                        y.Text = r["subcategoryname"].ToString();
                       
                    }
                    sql_con.Close();

                }
                catch (Exception)
                { 
                   
                    }
               
            }
            else { MessageBox.Show("Enter valid name"); }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

         
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ppo.Ctlcontrols.stop();
            this.Hide();
            search s = new search();
            s.Show();

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
           
      

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void ppo_Enter(object sender, EventArgs e)
        {
            ppo.Ctlcontrols.stop();
           
        }

        private void ppo_Enter_1(object sender, EventArgs e)
        {
            ppo.Ctlcontrols.stop();

        }

        private void ppo_Enter_2(object sender, EventArgs e)
        {
            ppo.Ctlcontrols.stop();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ppo_Enter_3(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        
      
     
  
    }
}
