using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace insulation3
{
    public partial class Form1 : Form
    {
        Form2 conn = new Form2(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label1.Text = "Name";
            this.label2.Text = "ID";
            this.label3.Text =  " DOB";
            this.button1.Text = "Execute";
            this.button2.Text = "Clear";
            this.button3.Text = "Exit";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("insert into student (sname,sid,sdob,sadd,sdoby) values(@sname,@sid,@sdob,@sadd,@sdoby)", conn.oleDbConnection1);
            cmd.Parameters.AddWithValue("@sname",this.textBox1.Text);
            cmd.Parameters.AddWithValue("@sid", this.textBox2.Text);
            cmd.Parameters.AddWithValue("@sdob", dateTimePicker1);
            cmd.Parameters.AddWithValue("@sadd", textBox3.Text);
            cmd.Parameters.AddWithValue("@sdoby", Convert.ToInt32(this.textBox4.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("inserted");
            conn.oleDbConnection1.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
