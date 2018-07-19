using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SearchInSystem
{
    public partial class Form1 : Form
    {
        Class1 c1;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            c1 = new Class1(new Form1());
            this.button1.Text = "Search";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DriveInfo[] di = DriveInfo.GetDrives();
            foreach(DriveInfo dr in di){
                this.textBox1.Text += dr.Name + "" + Environment.NewLine;
                if(dr.IsReady==true){
                    this.textBox1.Text += dr.TotalSize+ "" + Environment.NewLine;
                    this.textBox1.Text += dr.VolumeLabel + "" + Environment.NewLine;
                }
            }
        }
    }
}
