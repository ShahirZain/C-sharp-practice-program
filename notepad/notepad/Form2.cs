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
        }

        public void Form2_Load(object sender, EventArgs e)
        {
            this.label1.Text = "Search";
            this.label2.Text = "Replace";
            this.button1.Text = ">";
        }

        public void button1_Click(object sender, EventArgs e)
        {
            f1 = new Form1();  
            f1.textBox1.Text = f1.textBox1.Text.Replace(this.textBox2.Text,this.textBox3.Text);
            
        }

        

        
    }
}
