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
            this.checkBox1.Text = "Visual Programming";
            this.checkBox2.Text = "Data Structure";
            this.checkBox3.Text = "DataBase";
            this.button1.Text = "Clear";
            this.button2.Text = "Exit";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            this.checkBox1.Checked = false;
            this.checkBox2.Checked = false;
            this.checkBox3.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {

                this.checkBox2.Checked = false;
                this.checkBox3.Checked = false;
                this.textBox1.Text = "Course Instrucutor Uzma Afzal" + Environment.NewLine +
                    "Graudated From K.U";
            }
            else {
                this.textBox1.Text = "";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {

                this.checkBox1.Checked = false;
                this.checkBox3.Checked = false;
                this.textBox1.Text = "Course Instrucutor Farhan Shafeeq" + Environment.NewLine +
                    "Graudated From K.U";
            }
            else
            {
                this.textBox1.Text = "";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {

                this.checkBox2.Checked = false;
                this.checkBox1.Checked = false;
                this.textBox1.Text = "Course Instrucutor Kashif Rizwan" + Environment.NewLine +
                    "Graudated From K.U";
            }
            else
            {
                this.textBox1.Text = "";
            }
        }

    }
}
