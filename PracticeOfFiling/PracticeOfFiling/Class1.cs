using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace PracticeOfFiling
{
    class Class1
    {
        Form1 f1;
        directory f2;
        writer f3;
        FileInfo f4;
        public Class1(){
        }
        public Class1(Form1 ff1,directory ff2, writer ff3,FileInfo ff4)
        {
            f1 = ff1;
            f2 = ff2;
            f3 = ff3;
            f4 = ff4;
            
        }
        public void Disable(){
            f1.radioButton1.Enabled = false;
            f1.radioButton2.Enabled = false;
            f1.radioButton3.Enabled = false;
            f1.radioButton4.Enabled = false;
            f1.button2.Visible = false;
            f1.button3.Visible = false;
        }
        public void designing() {
            f1.radioButton1.Text = "Directory";
            f1.radioButton2.Text = "Stream Reader";
            f1.radioButton3.Text = "Stream Writer";
            f1.radioButton4.Text = "File Info";
            f1.button1.Text = "Login";
            f1.label1.Text = "ID";
            f1.label2.Text = "Password";
            f1.button2.Text = "Select";
            f1.button3.Text = "Exit";
            f2.radioButton1.Text = "Create";
            f2.radioButton2.Text = "Delete";
            f2.button1.Text = "Select";
            f3.button1.Text = "Save";
            f3.button2.Text = "Cancel";
            f4.button1.Text = "Path";
            f4.label1.Text = "File Name";
            f4.label2.Text = "Time and  ength";
        }
        public void valueTrue() {
            if (f1.textBox1.Text =="a" && f1.textBox2.Text=="b") {
                f1.radioButton1.Enabled = true;
                f1.radioButton2.Enabled = true;
                f1.radioButton3.Enabled = true;
                f1.radioButton4.Enabled = true;
                f1.button2.Visible = true;
                f1.button3.Visible = true;
                f1.button1.Enabled = false;
                f1.textBox1.Enabled = false;
                f1.textBox2.Enabled = false;
            }
        }
        public void selection(){

            if(f1.radioButton1.Checked)
            {
                f2.ShowDialog();
            }
            if (f1.radioButton2.Checked)
            {
                SecondIf();
            }
            if (f1.radioButton3.Checked)
            {
                thirdIf();
            }
            if (f1.radioButton4.Checked)
            {
                fourthIf();
            }
        }

        public void directoryFormButton() {

            FolderBrowserDialog fd = new FolderBrowserDialog();
            String fname = "ok";
            DirectoryInfo di = new DirectoryInfo(fname);  
            if(f2.radioButton1.Checked){     
               if (di.Exists) MessageBox.Show("Created");
               else MessageBox.Show("Does not created");
            }
            if(f2.radioButton2.Checked){
                if (di.Exists) { di.Delete(); MessageBox.Show("Deleted"); }
                else MessageBox.Show("Does not deleted");
            }
             
        }
        public void SecondIf() {

            StreamReader sr = new StreamReader("C:\Users\UMARCOMPUTER\Documents\ac.txt");
            String s = sr.ReadLine();
            MessageBox.Show(s);
           
        }

        public void thirdIf() {
            f3.Show();
            
        }
        public void fourthIf() {
            f4.Show();
        }
        
    }
}
