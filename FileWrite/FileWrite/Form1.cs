using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FileWrite
{
    public partial class Form1 : Form
    {
        String file;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.button1.Text = "SAVE";
            this.label1.Text = "Partition";
            this.label2.Text = "File with Extension";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] cc = new char[100];
            cc = this.textBox1.Text.ToCharArray() ;
            file = this.textBox2.Text + this.textBox3.Text;
            FileStream FS = new FileStream(file , FileMode.Create, FileAccess.Write);
            byte[] bb = new byte[100];
            Encoder EC = Encoding.UTF8.GetEncoder();
            EC.GetBytes(cc, 0, cc.Length, bb, 0, true);
            FS.Write(bb, 0, bb.Length);
            FS.Close();
        }
    }
}
