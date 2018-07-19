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
    public partial class forget : Form
    {
        myConn conn = new myConn();
        Form1 f1;
        public forget(Form1 ff1)
        {
            InitializeComponent();
            f1 = ff1;
        }

        private void forget_Load(object sender, EventArgs e)
        {
            this.label1.Text = "New";
            this.label2.Text = "Conform";
            this.button1.Text = "Finish";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == this.textBox2.Text)
            {
                conn.oleDbConnection1.Open();
                OleDbCommand cmd = new OleDbCommand("update login set  password = @password ", conn.oleDbConnection1);
                cmd.Parameters.AddWithValue("@password", this.textBox2.Text);
                cmd.ExecuteNonQuery();
                conn.oleDbConnection1.Close();
            }
            else
                MessageBox.Show("Password miss match");
        }
    }
}
