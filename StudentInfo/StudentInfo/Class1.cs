using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentInfo
{
    class Class1
    {
        Form1 f1;
      public  Class1(Form1 ff1)
        {
            f1 = ff1;
        }
      public void hidingOnload() {
          f1.label3.Visible = false;
          f1.label4.Visible = false;
          f1.label5.Visible = false;
          f1.textBox3.Visible = false;
          f1.textBox4.Visible = false;
          f1.textBox5.Visible = false;
          f1.comboBox1.Visible = false;
      }
      public void showViewData() {
          f1.label3.Visible = true;
          f1.label4.Visible = true;
          f1.label5.Visible = true;
          f1.textBox3.Visible = true;
          f1.textBox4.Visible = true;
          f1.textBox5.Visible = true;
          f1.comboBox1.Visible = true;
          f1.label6.Visible = true;
          
      }
      public void deleteHide() {
          f1.label1.Visible = false;
          f1.label2.Visible = false;

          f1.textBox1.Visible = false;
          f1.textBox2.Visible = false;
          f1.button1.Visible = false;
          f1.button6.Visible = false;
      }
        public void hiding() {
            f1.label1.Visible = false;
            f1.label2.Visible = false;
           
            f1.textBox1.Visible = false;
            f1.textBox2.Visible = false;
            f1.button1.Visible = false;
            f1.button7.Visible = false;

        }
        public void show() {
            f1.button2.Visible = true;
            f1.button3.Visible = true;
            f1.button4.Visible = true;
            f1.button5.Visible = true;
            f1.button8.Visible = true;
        }
        public void textBoxes() {
            f1.textBox3.Clear();
            f1.textBox4.Clear();
            f1.textBox5.Clear();
            f1.comboBox1.Items.Clear();
        }
        public void logoutHide() {
            f1.button3.Visible = false;
            f1.button5.Visible = false;
            f1.button4.Visible = false;
            f1.button2.Visible = false;
            f1.button6.Visible = false;
            f1.button7.Visible = false;
            f1.label6.Visible = false;

        }
        public void logoutShowAndClear() {
            f1.label1.Visible = true;
            f1.label2.Visible = true;
            f1.textBox1.Visible = true;
            f1.textBox2.Visible = true;
            f1.button1.Visible = true;
            f1.textBox1.Clear();
            f1.textBox2.Clear();
        }

    }
}
