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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "Copy";
            this.label1.Text = "folder";
            this.label2.Text = "file";
            this.label3.Text = "destination";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String fileName = this.textBox1.Text +"//" + this.textBox2.Text;
            String destName = this.textBox3.Text + "//"+ this.textBox2.Text;
            String sourcePath = System.IO.Path.Combine(this.textBox1.Text,this.textBox2.Text);
            String destPath = System.IO.Path.Combine(this.textBox3.Text, this.textBox2.Text);
            if(System.IO.File.Exists(destName)){
                DialogResult dr = MessageBox.Show("Do u wnat to replace file");
                if (dr ==  DialogResult.OK){
                    System.IO.File.Delete(destPath);
                    System.IO.File.Copy(sourcePath, destPath);
                    MessageBox.Show("File has been copied");
                }
            }
            else{
                System.IO.File.Copy(sourcePath, destPath);
            MessageBox.Show("File has been copied");
            }
        }
    }
}
