using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnterpriseResourcePlanning
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.panel3.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Hide();
            panel2.Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.panel1.Visible = true;
            this.panel3.Visible = true;
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBox1.Text = this.comboBox1.Text;
        }

        
    }
}
