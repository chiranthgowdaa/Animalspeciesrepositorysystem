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
    public partial class home1 : Form
    {
        public home1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            login l = new login();
            l.Show();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void home1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           
            rm.Visible = true;
          
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ap.Visible = true;
            up.Visible = false;
            rm.Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            up.Visible = true;
            rm.Visible = false;
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ap_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {


            if (!((a.Text=="")||(b.Text=="")||(c.Text=="")||(d.Text=="")||(f.Text=="")||(g.Text=="")||(h.Text=="")||(i.Text=="")||(j.Text=="")||(k.Text=="")||(l.Text=="")))
            {
                String a1 = a.Text;
                String a2 = b.Text;
                int a3 = int.Parse(c.Text);
                int a4 = int.Parse(d.Text);
                int a5 = int.Parse(f.Text);
                String endanger = "";
                if (g.Checked)
                {
                    endanger = "yes";
                }
                else if (h.Checked)
                {
                    endanger = "no";
                }
                String a6 = i.SelectedItem.ToString();
                int a7 = int.Parse(j.Text);
                int a8 = int.Parse(k.Text);
                String a9 = l.Text;
                int a10 = int.Parse(m.Text);
                int a11 = int.Parse(n.Text);
                Random rnd = new Random();
                int rn = rnd.Next(0, 1000);
                int rndm = rn;
                try
                {
                string q3 = "insert into db.animal values('"+rndm+"','"+a1+"','"+a2+"','"+a4+"','"+a5+"','"+a3+"','"+a10+"','"+a11+"')";
          
                string q5 = "insert into db.detail values('" + rndm + "','" +a7 + "','" + a8 + "','" + endanger + "')";
                string q6 = "insert into db.fact values('" + rndm + "','" + a9 + "')";
                MySqlConnection sqlp = new MySqlConnection("server=localhost;User Id=root; password=root;database=db");

              
                    sqlp.Open();
                    MySqlCommand cmd2 = new MySqlCommand(q3, sqlp);
                    cmd2.ExecuteNonQuery();
                    MySqlCommand cmd4 = new MySqlCommand(q5, sqlp);
                    cmd4.ExecuteNonQuery();
                    MySqlCommand cmd5 = new MySqlCommand(q6, sqlp);
                    cmd5.ExecuteNonQuery();
                    sqlp.Close();
                   MessageBox.Show("done");
                }
                catch (Exception )
                {
                    MessageBox.Show("animal exist");
                }
            }
            else { MessageBox.Show("fill all the fields"); }


        }
        

        private void stateid_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        
            DataSet d = new DataSet();
            try
            {
                MySqlConnection sql_con = new MySqlConnection("server=localhost;User Id=root; password=root;database=db");
                String str_query = "select * from db.state";
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

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DataSet d = new DataSet();
            try
            {
                MySqlConnection sql_con = new MySqlConnection("server=localhost;User Id=root; password=root;database=db");
                String str_query = "select s.stateid, s.statename from db.detail p, db.state s where p.aid='"+textBox24.Text+"'and p.sid=s.stateid";
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

        private void button7_Click(object sender, EventArgs e)
        {
            if (!((textBox24.Text == "") || (textBox20.Text == "")
              || (comboBox4.Text == "") || (textBox6.Text == "") || (
              textBox3.Text == "")  || (richTextBox2.Text == "")))
            {
                string aid = textBox24.Text;
                string name = textBox20.Text;
              
                string stn = comboBox4.Text;
                int sid = int.Parse(textBox6.Text);
                int pp = int.Parse(textBox3.Text);
              
                string rt = richTextBox2.Text;
                String endanger = "";

                if (radioButton3.Checked)
                {
                    endanger = "yes";
                }
                else if (radioButton4.Checked)
                {
                    endanger = "no";
                }
                displaylistbox.Items.Add("Unique animal Id :" + aid);
                displaylistbox.Items.Add("Name :" + name);

                displaylistbox.Items.Add("State name:" + stn);
                displaylistbox.Items.Add("state id :" + sid);
                displaylistbox.Items.Add("population :" + pp);

                displaylistbox.Items.Add("Information :" + rt);
                displaylistbox.Items.Add("Endanger :" + endanger);
            }
            else { MessageBox.Show("Fill the required fileld"); }
        }

        private void button8_Click(object sender, EventArgs e)
        {
           if (!((a.Text=="")||(b.Text=="")||(c.Text=="")||(d.Text=="")||(f.Text=="")||(g.Text=="")||(h.Text=="")||(i.Text=="")||(j.Text=="")||(k.Text=="")||(l.Text=="")))
            {
                String a1 = a.Text;
                String a2 = b.Text;
                int a3 = int.Parse(c.Text);
                int a4 = int.Parse(d.Text);
                int a5 = int.Parse(f.Text);
                String endanger = "";
                if (g.Checked)
                {
                    endanger = "yes";
                }
                else if (h.Checked)
                {
                    endanger = "no";
                }
                String a6 = i.SelectedItem.ToString();
                int a7 = int.Parse(j.Text);
                int a8 = int.Parse(k.Text);
                String a9 = l.Text;
                int a10 = int.Parse(m.Text);
                int a11 = int.Parse(n.Text);

                displaylistbox.Items.Add("Name :" + a1);
                displaylistbox.Items.Add("Scientific name :" + a2);
                displaylistbox.Items.Add("Life Span :" + a3);
                displaylistbox.Items.Add("Average height :" + a4);
                displaylistbox.Items.Add("Average weight:" + a5);
                displaylistbox.Items.Add("State name:" + a6);
                displaylistbox.Items.Add("state id :" + a7);
                displaylistbox.Items.Add("population :" + a8);
               
                displaylistbox.Items.Add("category id :" + a10);
                
                displaylistbox.Items.Add("Sub-category id :" + a11);
                displaylistbox.Items.Add("Information :" + a9);
                displaylistbox.Items.Add("Endanger :" + endanger);
            }
            else{
            MessageBox.Show("Fill the fields");}

        }

        private void displaylistbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void up_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            search s = new search();
            s.Show();

        }

        private void rm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (!((comboBox5.Text=="")||(textBox21.Text == "") || (textBox22.Text == "") || (textBox25.Text == "")))
            {
                String a = textBox21.Text;
                int b = int.Parse(textBox22.Text);
                int c = int.Parse(textBox25.Text);
                String p = comboBox6.SelectedItem.ToString();
                DataSet d = new DataSet();
                try
                {
                    MySqlConnection sql_con = new MySqlConnection("server=localhost;User Id=root; password=root;database=db");
                    String str_query = "delete from db.detail where aid='" + c + "' and sid='"+b+"'";
                    sql_con.Open();
                    MySqlDataAdapter DTA = new MySqlDataAdapter(str_query, sql_con);
                    DTA.Fill(d);
                    sql_con.Close();
                    MessageBox.Show("Deleted");

                }
                catch (Exception)
                {


                }
            }
            else { MessageBox.Show("Fill the fields"); }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!(comboBox6.Text == ""))
            {
                DataSet d = new DataSet();
                try
                {

                    MySqlConnection sql_con = new MySqlConnection("server=localhost;User Id=root; password=root;database=db");
                  
                    sql_con.Open();
                    MySqlCommand cm = new MySqlCommand("select stateid from db.state where statename='"+comboBox6.SelectedItem.ToString()+"'", sql_con);
                    MySqlDataReader r;
                    r = cm.ExecuteReader();
                    while (r.Read())
                    {
                        textBox22.Text = r["stateid"].ToString(); 
                    }
                    sql_con.Close();
             



                }
                catch (Exception)
                {


                }
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!(textBox21.Text == ""))
            {
                String a = textBox21.Text;
                DataSet d = new DataSet();
                try
                {
                    MySqlConnection sql_con = new MySqlConnection("server=localhost;User Id=root; password=root;database=db");
                  
                    sql_con.Open();

                    MySqlCommand cm = new MySqlCommand("select animalid from db.animal where animalname ='" + a + "'", sql_con);
                MySqlDataReader r;
                    r=cm.ExecuteReader();
                    while (r.Read())
                    {
                        textBox25.Text = r["animalid"].ToString();
                    }
                    sql_con.Close();

                }
                catch (Exception)
                {


                }

             
            }
            else { MessageBox.Show("enter all the fields"); }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (!((textBox24.Text == "") || (textBox20.Text == "")
              || (comboBox4.Text == "") || (textBox6.Text == "") || (
              textBox3.Text == "") || (richTextBox2.Text == "")))
            {
                string aid = textBox24.Text;
                string name = textBox20.Text;

                string stn = comboBox4.SelectedItem.ToString();
                int sid = int.Parse(textBox6.Text);
                int pp = int.Parse(textBox3.Text);

                string rt = richTextBox2.Text;
                String endanger = "";

                if (radioButton4.Checked)
                {
                    endanger = "yes";
                }
                else if (radioButton3.Checked)
                {
                    endanger = "no";
                }
                try
                {
                string query = "update db.detail set population='"+pp+"',endanger='"+endanger+"' where aid='"+aid+"' and sid ='"+sid+"'";
                string query1 = "update db.fact set fact='" + richTextBox2.Text + "'where aid='" + aid + "'";
                
                MySqlConnection sqlp = new MySqlConnection("server=localhost;User Id=root; password=root;database=db");
                
                
                    sqlp.Open();
                    MySqlCommand cmd = new MySqlCommand(query, sqlp);
                    cmd.ExecuteNonQuery();
                    MySqlCommand cmd1 = new MySqlCommand(query1, sqlp);
                    cmd1.ExecuteNonQuery();
                    sqlp.Close();
                    MessageBox.Show("done");
                }
                catch (Exception)
                {
                 
                }

            }
            else { MessageBox.Show("Enter all the field"); }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            String a = textBox20.Text;
            DataSet d = new DataSet();
            try
            {
                MySqlConnection sql_con = new MySqlConnection("server=localhost;User Id=root; password=root;database=db");
                String str_query = "select animalid, animalname from db.animal where animalname ='"+a+"'";
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

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            String a = textBox20.Text;
            DataSet d = new DataSet();
            try
            {
                MySqlConnection sql_con = new MySqlConnection("server=localhost;User Id=root; password=root;database=asrs");
                String str_query = "select animalid,animalname from animal";
                sql_con.Open();
                MySqlDataAdapter DTA = new MySqlDataAdapter(str_query, sql_con);
                DTA.Fill(d);
                sql_con.Close();

            }
            catch (Exception)
            {


            }
            MessageBox.Show("Assign a unique id :");

            dataGridView1.DataSource = d.Tables[0];
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
            DataSet d = new DataSet();
            try
            {
                MySqlConnection sql_con = new MySqlConnection("server=localhost;User Id=root; password=root;database=asrs");
                String str_query = "select categoryid,categoryname from asrs.categoryid group by categoryid ";
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
                MySqlConnection sql_con = new MySqlConnection("server=localhost;User Id=root; password=root;database=asrs");
                String str_query = "select subcategory,subid from asrs.subcategory group by subid ";
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

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
           
        }





        public string idt { get; set; }

        private void linkLabel6_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void linkLabel7_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel5_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            String a = textBox2.Text;
            DataSet d = new DataSet();
            try
            {
                MySqlConnection sql_con = new MySqlConnection("server=localhost;User Id=root; password=root;database=db");
                String str_query = "select animalid, animalname from db.animal where animalname ='" + a + "'";
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

        private void button11_Click(object sender, EventArgs e)
        {
            if (!((textBox1.Text == "") || (textBox2.Text == "")||(comboBox1.Text=="")))
            {
                String a = textBox2.Text;
                int b = int.Parse(textBox1.Text);
                DataSet d = new DataSet();
                try
                {
                    MySqlConnection sql_con = new MySqlConnection("server=localhost;User Id=root; password=root;database=db");
                    String str_query = "delete from db.animal where animalid='"+b+"'";
                    sql_con.Open();
                    MySqlDataAdapter DTA = new MySqlDataAdapter(str_query, sql_con);
                    DTA.Fill(d);
                    sql_con.Close();
                    MessageBox.Show("Deleted");

                }
                catch (Exception)
                {


                }
            }
            else { MessageBox.Show("Enter all the field"); }
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            upanimal u = new upanimal();
            u.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            advancedadd a = new advancedadd();
            a.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ap.Visible = true;
            up.Visible = false;
            rm.Visible = false;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            ap.Visible = true;
            up.Visible = false;
            rm.Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            up.Visible = true;
            rm.Visible = false;
        }

        private void label22_Click(object sender, EventArgs e)
        {

            up.Visible = true;
            rm.Visible = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            rm.Visible = true;
        }

        private void label23_Click(object sender, EventArgs e)
        {
            rm.Visible = true;
        }
    }
}
