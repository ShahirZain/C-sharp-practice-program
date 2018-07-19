using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Insulation1
{
    public partial class Form1 : Form
    {
        myConn conn = new myConn();
        
        public Form1()
        {
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select cname from countries ", conn.oleDbConnection1);
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr["cname"].ToString());
            }
            conn.oleDbConnection1.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select ciname from cities where cname ='" + comboBox1.Text + "'", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            this.comboBox2.Items.Clear();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr["ciname"].ToString());
            }
            conn.oleDbConnection1.Close();



        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Select * from cities where ciname  = '" + comboBox2.Text + "'", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                this.textBox1.Text = dr["cname"].ToString();
                this.textBox2.Text = dr["ciname"].ToString();
            }
            conn.oleDbConnection1.Close();
        }
    }
}
