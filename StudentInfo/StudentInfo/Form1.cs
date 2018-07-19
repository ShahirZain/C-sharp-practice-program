using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace StudentInfo
{
    public partial class Form1 : Form
    {
        Class1 c;
        String check = "view";
        myConn conn = new myConn();
        public Form1()
        {
            InitializeComponent();
           
        }

        public void Form1_Load(object sender, EventArgs e)
        {
           
            c = new Class1(this);
            c.hidingOnload();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Select sname , spswd from student " ,conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
           if(dr.Read()){
                if (dr["sname"].ToString()==this.textBox1.Text && dr["spswd"].ToString()==this.textBox2.Text)
                {
                    MessageBox.Show("Login");
                }
                 
            }
            conn.oleDbConnection1.Close();
            c.hiding();
            c.show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox6.Visible = false;
            this.button9.Visible = false;
            this.button7.Visible = false;
            this.button6.Visible = false;
            c.textBoxes();
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Select * from student ", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["sid"].ToString());
            }
            conn.oleDbConnection1.Close();
            c.hiding();
            c.show();
            c.showViewData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (check == "view")
            {
                conn.oleDbConnection1.Open();
                OleDbCommand cmd = new OleDbCommand("Select * from student where sid = '" + comboBox1.Text + "'", conn.oleDbConnection1);
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    this.textBox3.Text = dr["sname"].ToString();
                    this.textBox4.Text = dr["sadd"].ToString();
                    this.textBox5.Text = dr["sdoby"].ToString();

                }
                conn.oleDbConnection1.Close();
            }
            if (check == "delete") {
                conn.oleDbConnection1.Open();
                OleDbCommand cmd = new OleDbCommand("Select * from student where sid = '" + comboBox1.Text + "'", conn.oleDbConnection1);
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    this.textBox3.Text = dr["sname"].ToString();
                    this.textBox4.Text = dr["sadd"].ToString();
                    this.textBox5.Text = dr["sdoby"].ToString();

                }
                conn.oleDbConnection1.Close();
            }
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.button9.Visible = false;
            c.textBoxes();
            this.button6.Visible = true;
            check = "update";
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Select * from student ", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["sid"].ToString());
            }
            conn.oleDbConnection1.Close();
            c.hiding();
            c.show();
            c.showViewData();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("update student set sname = @sname , sadd = @sadd , sdoby= @sdoby where sid=@sid", conn.oleDbConnection1);
            cmd.Parameters.AddWithValue("@sname", this.textBox3.Text);
            cmd.Parameters.AddWithValue("@add", this.textBox4.Text);
            cmd.Parameters.AddWithValue("@sdoby", this.textBox5.Text);
            cmd.Parameters.AddWithValue("@sid", this.comboBox1.Text);
            cmd.ExecuteNonQuery();
            conn.oleDbConnection1.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox6.Visible = false;
            this.button9.Visible = false;
            this.button7.Visible = true;
            check = "delete";
            c.textBoxes();
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Select * from student ", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["sid"].ToString());
            }
            conn.oleDbConnection1.Close();
            c.deleteHide();
            c.show();
            c.showViewData();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("delete * from student where sid = '"+comboBox1.Text+"' ", conn.oleDbConnection1);
            cmd.ExecuteNonQuery();
            conn.oleDbConnection1.Close();
            MessageBox.Show("DLTD");
            c.textBoxes();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.button8.Visible = false;
            c.hidingOnload();
            c.logoutHide();
            c.logoutShowAndClear();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            this.button9.Visible = true;
            this.textBox6.Visible = true;
            c.deleteHide();
            c.hiding();
            c.textBoxes();
            c.showViewData();
            this.comboBox1.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("insert into student (sid,sname, sadd,sdoby) Values ('" + this.textBox6.Text + "','" + this.textBox3.Text + "','" + this.textBox4.Text + "' ,'" + this.textBox5.Text + "')", conn.oleDbConnection1);
            cmd.ExecuteNonQuery();
            MessageBox.Show("EDITED");
            conn.oleDbConnection1.Close();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}