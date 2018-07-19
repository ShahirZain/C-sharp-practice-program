using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;

namespace insulation2
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
            this.label1.Text = "Name";
            this.label2.Text = "Add";
            this.button1.Text = "Table";
            comboBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Select * from student", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            conn.oleDbConnection1.Close();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Select * from student where sid = '"+comboBox1.Text+"'", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read()) {
                this.textBox1.Text = dr["sname"].ToString();
                this.textBox2.Text = dr["sadd"].ToString();
            }
            conn.oleDbConnection1.Close();
        }
        public void comboBox() {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Select * from student ", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["sid"].ToString());
            }
            conn.oleDbConnection1.Close();
        }
    }
}
