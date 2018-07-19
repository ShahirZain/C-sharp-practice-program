using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PracticeOfFiling
{
    public partial class writer : Form
    {
        Form1 f1;
        directory f2;
        public writer(Form1 ff1, directory ff2)
        {
            InitializeComponent();
            f1 = ff1;
            f2 = ff2;   
        }

        private void writer_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(this.textBox2.Text);
            sw.Write(this.textBox1.Text);
            MessageBox.Show("File Has Been Saved");
            sw.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            }

      
    }
}
