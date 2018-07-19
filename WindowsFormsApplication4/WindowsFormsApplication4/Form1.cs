using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string myfile;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label1.Text = "Source";
            this.label3.Text = "Extension";
            this.textBox3.ReadOnly = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            myfile = this.textBox1.Text;
            DirectoryInfo dr = new DirectoryInfo(@"C:");
            
            FileInfo[] fi = dr.GetFiles();
            foreach(FileInfo f in fi){
                this.textBox3.Text += f.Name + " " + f.Length + " " + f.CreationTime + " " + f.Attributes.ToString() + Environment.NewLine;
            }

        }
        
       
    }
}
