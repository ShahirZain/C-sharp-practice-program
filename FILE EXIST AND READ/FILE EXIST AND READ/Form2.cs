using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        Form1 F1 = new Form1();
        String file;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.button1.Text = ">";
            String[] rng = { ".txt", ".html" };
            this.comboBox1.Items.AddRange(rng);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (F1.radioButton1.Checked)
            {
                byte[] bb = new byte[100];
                char[] cc = new char[100];
                file = this.textBox1.Text + this.comboBox1.Text;
                FileStream FS = new FileStream(file, FileMode.Open, FileAccess.Read);
                FS.Read(bb, 0, 100);
                Decoder DE = Encoding.UTF8.GetDecoder();
                DE.GetChars(bb, 0, bb.Length, cc, 0);
                foreach (char c in cc)
                {
                    this.textBox2.Text += c;
                    
                }
            }

            if (F1.radioButton2.Checked )
            {
                file = this.textBox1.Text + this.comboBox1.Text;
                if (File.Exists(file))
                {
                    this.textBox2.Text = "File EXIST";
                }
                else
                {
                    this.textBox2.Text = "File DOES NOT EXIST";
                }
            }
        }

    }
}

