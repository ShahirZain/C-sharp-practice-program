using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace Word_counting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i=0;
            StreamReader sr = new StreamReader(this.textBox1.Text);
            char[] s = sr.ReadToEnd().ToCharArray();
            foreach(Char c in s)
                        if(c == ' ') i++;
            
                        i++;
            MessageBox.Show(i.ToString());
        }
    }
}
