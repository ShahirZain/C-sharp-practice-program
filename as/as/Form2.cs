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
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.label1.Text = " Name ";
            this.label2.Text = " Class ";
            this.label3.Text = " Section ";
            this.label4.Text = " Year ";
            this.label5.Text = " percentage";
            this.button1.Text = "Clear ";
            this.button2.Text = " Cancel ";
            this.button3.Text = "Extra marks "; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(this);
            f3.Show();
        }
    }
}
