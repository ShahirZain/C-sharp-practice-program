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
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            f1.textBox1.Visible = true;
            f1.textBox2.Visible = true;
        }
    }
}
