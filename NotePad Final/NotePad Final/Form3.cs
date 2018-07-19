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
    public partial class Form3 : Form
    {
        Form1 f1 = new Form1();
        public Form3()
        {
            InitializeComponent();
        }

        public void Form3_Load(object sender, EventArgs e)
        {
            this.label1.Text = "Do you want to save Changes to Untitled? ";
            this.button1.Text = "Save";
            this.button2.Text = "Don't Save";
            this.button3.Text = "Cancel";
            this.label1.ForeColor = Color.Blue;
            f1.openFileDialog1.Filter = "Text Files|*.txt";
            f1.saveFileDialog1.Filter = "Text Files|*.txt";
            this.textBox1.ReadOnly = true;
            //this.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult DR = f1.saveFileDialog1.ShowDialog();
            if (DR == DialogResult.OK)
            {
                String fname = f1.saveFileDialog1.FileName + ".txt";

                File.WriteAllText(fname, f1.textBox1.Text);
                this.Close();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

       

    }
}
