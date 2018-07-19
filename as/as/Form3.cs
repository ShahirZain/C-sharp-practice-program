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
    public partial class Form3 : Form
    {
        Form2 f2;
        public Form3( Form2 ff2)
        {
            f2 = ff2;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.label1.Text = "vp";
            this.label2.Text = "ds";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            float percent;
            int vp = Convert.ToInt32(this.textBox1.Text);
            int ds = Convert.ToInt32(this.textBox2.Text);
            percent = ((vp + ds) / 200) * 100;
            f2.textBox5.Text = percent.ToString();
            f2.textBox6.Text = "Vp marks " + vp + "" + Environment.NewLine + " DS marks " +ds;
            f2.Show();
        }
    }
}
