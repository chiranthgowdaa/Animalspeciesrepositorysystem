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
    public partial class junk : Form
    {
        public junk()
        {
            InitializeComponent();
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ab = int.Parse(a.Text);
            String s = b.Text;
            DataSet d = new DataSet();
            try
            {
                MySqlConnection con = new MySqlConnection("server=localhost;User Id=root; password=root;database=db");
                DataTable dt = new DataTable();
                con.Open();
             
                MySqlCommand c = new MySqlCommand("select statename from db.state where stateid='"+ab+"' ",con);
                MySqlDataReader ra=null;

                ra = c.ExecuteReader();
                while (ra.Read())
                {b.Text= (ra["statename"].ToString());
                } con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

         
        }
    }
}
