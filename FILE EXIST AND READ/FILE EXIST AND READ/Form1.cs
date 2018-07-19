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
            this.radioButton2.Text = "FILE EXISTING";
            this.radioButton1.Text = "FILE READING";
            this.button1.Text = ">";
            this.button2.Text = "Exit";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked)
            {
                Form2 F2 = new Form2();
                F2.ShowDialog();
            }
            if (this.radioButton2.Checked)
            {
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
        }
    }
    }
