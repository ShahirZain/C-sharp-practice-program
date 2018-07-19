using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label1.Text = "source";
            this.label2.Text = "file";
            this.label3.Text = "destination";
            this.button1.Text = "Copy";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileName = this.textBox1.Text + "\\"+ this.textBox2.Text;
            string destFile = this.textBox3.Text + "\\" + this.textBox2.Text;
            File.Copy(fileName,destFile);
        }
    }
}
