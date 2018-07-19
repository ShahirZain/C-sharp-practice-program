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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.button1.Text = ">";
            this.label1.Text = "Enter Folder Name";
            this.label2.Text = "Select Drive";
            this.checkBox1.Text = "C:";
            this.checkBox2.Text = "D:";
            this.checkBox3.Text = "E:";
            this.textBox2.ReadOnly = true;
            this.textBox2.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DriveInfo[]Di = DriveInfo.GetDrives();
            if(checkBox2.Checked){
                String fileName = Di[0].ToString();

                DirectoryInfo di = new DirectoryInfo(fileName);
                if (di.Exists) MessageBox.Show("exist");
                else MessageBox.Show("does not exist");
            }
        }

        
    }
}
