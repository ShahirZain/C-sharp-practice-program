using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Insulation6
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
            this.label2.Text = "Password";
            this.label3.Text = "forget?";
            this.button1.Text = "Login";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select * from login",conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            if(dr.Read()){
                if(dr["name"].ToString()==this.textBox1.Text && dr["password"].ToString()==this.textBox2.Text){
                    MessageBox.Show("login");
                }
            }
            conn.oleDbConnection1.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           forget f2= new forget(this);
           f2.ShowDialog();
        }
    }
}
