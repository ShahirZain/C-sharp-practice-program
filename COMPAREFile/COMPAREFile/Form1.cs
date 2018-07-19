using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace COMPAREFile
{
    public partial class Form1 : Form
    {
        String file,file1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label1.Text = "FILE 1";
            this.label6.Text = "FILE 2";
            this.label2.Text = "Partition";
            this.label5.Text = "Partition";
            this.label3.Text = "F with E";
            this.label4.Text = "F with E";
            this.button1.Text = "Compare";
            this.button2.Text = "Exit";
            this.textBox1.Text = "E:\\";
            this.textBox4.Text = "E:\\";
            this.textBox2.Text = "a.txt";
            this.textBox3.Text = "b.txt";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            file = this.textBox1.Text + this.textBox2.Text;
            FileStream FS = new FileStream(file, FileMode.Open, FileAccess.Read);
            byte[] bb = new byte[100];
            char[] cc = new char[100];
            FS.Read(bb, 0, bb.Length);
            Decoder De0 = Encoding.UTF8.GetDecoder();
            De0.GetChars(bb, 0, bb.Length, cc, 0, true);

            file1 = this.textBox4.Text + this.textBox3.Text;
            FileStream FS1 = new FileStream(file1, FileMode.Open, FileAccess.Read);
            byte[] bb1 = new byte[100];
            char[] cc1 = new char[100];
            FS1.Read(bb1, 0, bb1.Length);
            Decoder De = Encoding.UTF8.GetDecoder();
            De.GetChars(bb1, 0, bb1.Length, cc1, 0, true);
            int flag = 0;
            for (int i = 0; i < 100; i++)
            {
                
                if (cc1[i] == cc[i])
                {
                   
                    this.textBox1.Text = "FIle same";
                    
                }
                else
                {
                    
                    flag = 0;
                    this.textBox1.Text = "FIle DOES NOT same";
                }
            }
       

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
