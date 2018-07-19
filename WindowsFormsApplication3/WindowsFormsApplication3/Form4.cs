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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public void Form4_Load(object sender, EventArgs e)
        {
            this.Text = "Exist";
            this.label1.Text = "Complete path with extention";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String fileName = this.textBox1.Text;
            if (System.IO.File.Exists(fileName))
            {
                MessageBox.Show("file Exist");
            }
            else
                MessageBox.Show("file does not exist");
        }
    }
}
