using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label1.Text = "Name";
            this.label2.Text = "Password";
            this.button1.Text = "OK";
            this.button2.Text = "Clear";
            this.button3.Text = "Exit";
            this.textBox2.PasswordChar = '*';
            this.textBox1.Text = "user name";
            this.textBox2.Text = "password";
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "pc" || this.textBox2.Text == "abc")
            {
                Form2 f2 = new Form2();
                f2.ShowDialog();
                this.Hide();
                              
            }
            else {
                MessageBox.Show("Youser name or password error ");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            this.textBox2.Clear();
        }

        
    }
}
