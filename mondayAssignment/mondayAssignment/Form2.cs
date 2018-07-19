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
    public partial class Form2 : Form
    {
        Form1 f1;
        public Form2(Form1 ff1)
        {
            f1 = ff1;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.label1.Text = "FileName";

            this.button1.Text = "Open";
            this.button2.Text = "save";
            this.button3.Text = "Ok";

            this.textBox1.Visible = false;
            this.button3.Visible = false;
            this.label1.Visible = false;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.textBox1.Visible = true;
            this.button3.Visible = true;
            this.label1.Visible = true;

            f1.textBox2.Text = this.textBox1.Text;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            f1.textBox2.Text = f1.textBox1.Text;
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            f1.textBox2.Text = this.textBox1.Text;
            this.Close();
        }
    }
}
