using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CapitalLetterCounter
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
            int a = 0;
            StreamReader s = new StreamReader(this.textBox1.Text);
            Char []c = s.ReadLine().ToCharArray();
            for (int i = 0; i < c.Length; i++)
                if (c[i] >= 65 && c[i] <= 92) a++; 
                                                          
            MessageBox.Show(a.ToString());
       
        }
    }
}
