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
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.label1.Text = " Complete path with extention";
            this.Text = "delete";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String fileName = this.textBox1.Text;
            if(System.IO.File.Exists(fileName)){
                System.IO.File.Delete(fileName);
                MessageBox.Show("file has been deleted");
            }
            else
                MessageBox.Show("file does not exist");
        }
    }
}
