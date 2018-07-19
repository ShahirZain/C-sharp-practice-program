using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PracticeOfFiling
{
    public partial class Form1 : Form
    {
        directory f2;
        Class1 c1;
        writer f3;
        FileInfo f4;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {  
           f2 = new directory(this,f3,f4);
           f3 = new writer(this,f2);
           f4 = new FileInfo();
           c1 = new Class1(this, f2,f3,f4);
           c1.designing();
           c1.Disable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c1.valueTrue();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c1.selection();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
