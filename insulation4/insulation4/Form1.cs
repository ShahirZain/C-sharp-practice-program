using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace insulation4
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
            OleDbCommand cmd = new OleDbCommand("select * from student",conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            while( dr.Read()){
                comboBox1.Items.Add(dr["sid"]);
            }
            conn.oleDbConnection1.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select * from student where sid ='"+comboBox1.Text+"'" ,conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read()) {
                this.textBox1.Text = dr["sname"].ToString();
                this.textBox2.Text = dr["sadd"].ToString();
                this.dateTimePicker1.Text = dr["sdob"].ToString();
                this.textBox4.Text = dr["sdoby"].ToString();
            }
            conn.oleDbConnection1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select * from student",conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            conn.oleDbConnection1.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("update student set sname = @sname , sadd = @sadd where sid=@sid",conn.oleDbConnection1);
            cmd.Parameters.AddWithValue("@sname",this.textBox1.Text);
            cmd.Parameters.AddWithValue("@add", this.textBox2.Text);
            cmd.Parameters.AddWithValue("@sid", this.comboBox1.Text);
            cmd.ExecuteNonQuery();
            conn.oleDbConnection1.Close();
        }
    }
}
