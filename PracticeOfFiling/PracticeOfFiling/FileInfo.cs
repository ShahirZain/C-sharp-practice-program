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
    public partial class FileInfo : Form
        
    {
        Class1 c1;

        public FileInfo()
        {
            InitializeComponent();
            c1 = new Class1();
        }

        private void FileInfo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String myfile = this.textBox1.Text;
            DirectoryInfo dr = new DirectoryInfo(myfile);
            System.IO.FileInfo[] fi=dr.GetFiles("*.txt");

            foreach(System.IO.FileInfo f in fi){
                this.textBox2.Text += "Name: " + f.Name;
                this.textBox3.Text += "Data: " + f.Length;
            }
        }
    }
}
