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
            this.label1.Text = "Start IND";
            this.label2.Text = "End IND";
            this.label3.Text = " Table No. ";
            this.button1.Text = "Clean";
            this.button2.Text = "Close";
            this.button3.Text = "Generate";
            this.Text = "Table  Generator";
            this.AcceptButton = button3;
            this.CancelButton = button1;
            this.Opacity = 0.5;
            this.Opacity = 0.7;
            this.Opacity = 0.8;
            this.Opacity = 1;
            this.button2.BackColor = Color.Red;
            this.textBox4.ScrollBars = ScrollBars.Both;
            this.ForeColor = Color.Wheat;
            this.BackColor = Color.Black;
            this.button1.BackColor = Color.LightBlue;
            this.button3.BackColor = Color.LightGreen;
            this.button1.ForeColor = Color.Black;
            this.button2.ForeColor = Color.Black;
            this.button3.ForeColor = Color.Black;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
            this.textBox3.Clear();
            this.textBox4.Clear();
            this.button3.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int start = Convert.ToInt32(textBox1.Text);
            int End = Convert.ToInt32(textBox2.Text);
            int tableno = Convert.ToInt32(textBox3.Text);
            for (int i = start; i <= End; i++)
            {
                this.textBox4.Text += tableno.ToString()+ " * " + i + " = " + (tableno*i).ToString()+Environment.NewLine;
            }
            this.button3.Enabled = false;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
                   }
    }
    
}
