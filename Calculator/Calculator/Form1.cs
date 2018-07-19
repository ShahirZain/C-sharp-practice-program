using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        String textBoxText;
        Single text1, text2;
        double result, ans, base1;
        int count;
        long num=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonGroupText();
            this.label1.Visible = false;
            this.label1.Text = "";
            this.label2.Text = "";
            this.textBox1.Text = "0";
            this.label2.Visible = false;
           // this.checkBox1.Checked = true;

        }


        void buttonGroupText()
        {
            this.button1.Text = "9";
            this.button2.Text = "8";
            this.button3.Text = "7";
            this.button4.Text = "6";
            this.button5.Text = "5";
            this.button6.Text = "4";
            this.button7.Text = "3";
            this.button8.Text = "2";
            this.button9.Text = "1";
            this.button10.Text = "0";
            this.button11.Text = ".";
            this.button12.Text = "=";
            this.button13.Text = "AC";
            this.button14.Text = "C";
            this.button15.Text = "/";
            this.button16.Text = "+";
            this.button17.Text = "ANS";
            this.button18.Text = "*";
            this.button19.Text = "-";
            this.button20.Text = "%";
            this.button21.Text = "X inverse";
            this.button22.Text = "P";
            this.button23.Text = "cube";
            this.button24.Text = "fraction";
            this.button25.Text = ".,";
            this.button26.Text = "log";
            this.button27.Text = "sin";
            this.button28.Text = "cos";
            this.button29.Text = "tan";
            this.button30.Text = "Arcsin";
            this.button31.Text = "Arccos";
            this.button32.Text = "Arctan";
            this.button33.Text = "EXP";
            this.button34.Text = "X^y";
            this.button35.Text = "root";
            this.button36.Text = "x!";
            this.button37.Text = "ln";
            this.button38.Text = "e^x";
            this.button39.Text = "(";
            this.button40.Text = ")";
            this.checkBox1.Text = "Degree";
            this.checkBox2.Text = "Radian";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "9";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "7";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "6";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "1";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += ".";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //= button
            this.label2.Text += this.textBox1.Text.ToString();
            cal();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //Clear Button
            this.textBox1.Clear();
            this.label1.Text = "";
            this.label2.Text = "";
            text1 = 0; text2 = 0;
            count = 0;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //AC button
            textBoxText = textBox1.Text;
            if (textBoxText.Length > 0)
            {
                textBoxText = textBoxText.Substring(0, textBoxText.Length - 1);
            }
            else
            {
                textBox1.Clear();
            }

            textBox1.Text = textBoxText;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // / button
            this.label1.Visible = true;
            text1 += Convert.ToSingle(this.textBox1.Text.ToString());
            this.label1.Text = this.textBox1.Text.ToString() + " / ";
            this.textBox1.Clear();
            count = 4;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.label1.Visible = true;
            text1 += Convert.ToSingle(this.textBox1.Text.ToString());
            this.label1.Text = this.textBox1.Text.ToString() + " * ";
            this.textBox1.Clear();
            count = 3;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.label1.Visible = true;
            this.label2.Visible = true;
            this.label2.Text += this.textBox1.Text.ToString() + " + ";
            text1 += Convert.ToSingle(this.textBox1.Text.ToString());
            this.label1.Text = this.textBox1.Text.ToString() + " + ";

            this.textBox1.Clear();
            count = 1;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.label1.Visible = true;
            text1 += Convert.ToSingle(this.textBox1.Text.ToString());
            this.label1.Text = this.textBox1.Text.ToString() + " - ";

            this.textBox1.Clear();
            count = 2;
        }

        private void button17_Click(object sender, EventArgs e)
        {

            this.textBox1.Text = ans.ToString();

        }




        public void cal()
        {
            switch (count)
            {
                case 1:
                    this.label1.Text += this.textBox1.Text;
                    text2 = Convert.ToSingle(this.textBox1.Text);
                    result = text1 + text2;
                    text2 = 0;
                    text1 = 0;
                    this.label1.Text = result.ToString();
                    this.textBox1.Text = result.ToString();
                    text2 = Convert.ToSingle(result);
                    ans = result;
                    result = 0;
                    break;
                case 2:
                    this.label1.Text += this.textBox1.Text;
                    text2 = Convert.ToSingle(this.textBox1.Text);
                    result = text1 - text2;
                    text2 = 0;
                    text1 = 0;
                    this.label1.Text = result.ToString();
                    this.textBox1.Text = result.ToString();
                    text2 = Convert.ToSingle(result);
                    ans = result;
                    result = 0;
                    break;
                case 3:
                    this.label1.Text += this.textBox1.Text;
                    text2 = Convert.ToSingle(this.textBox1.Text);
                    result = text1 * text2;
                    text2 = 0;
                    text1 = 0;
                    this.label1.Text = result.ToString();
                    this.textBox1.Text = result.ToString();
                    text2 = Convert.ToSingle(result);
                    ans = result;
                    result = 0;
                    break;
                case 4:
                    this.label1.Text += this.textBox1.Text;
                    text2 = Convert.ToSingle(this.textBox1.Text);
                    try { result = text1 / text2; }
                    catch (ArithmeticException e)
                    {
                        this.textBox1.Text = "Math ERROR" + e;
                    }
                    text2 = 0;
                    text1 = 0;
                    this.label1.Text = result.ToString();
                    this.textBox1.Text = result.ToString();
                    text2 = Convert.ToSingle(result);
                    ans = result;
                    result = 0;
                    break;
                case 5:
                    result = Math.Pow(base1, Convert.ToDouble(textBox1.Text));
                    this.label1.Visible = true;
                    this.label1.Text = result.ToString();
                    break;
                default:
                    this.label1.Text = this.textBox1.Text;
                    break;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            text1 = Convert.ToInt32(this.label1.Text = this.textBox1.Text);
            text2 = Convert.ToInt32(this.textBox1.Text);
            result = Convert.ToDouble(Math.Pow(Convert.ToInt32(text1), Convert.ToInt32(text2)));
        }

        private void button31_Click(object sender, EventArgs e)
        {
            this.label1.Visible = true;
            this.label1.Text = Math.Acos(Convert.ToSingle(textBox1.Text.ToString())).ToString();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            this.label1.Visible = true;
            this.label1.Text = Math.Asin(Convert.ToSingle(textBox1.Text.ToString())).ToString();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            this.label1.Visible = true;
            this.label1.Text = Math.Atan(Convert.ToSingle(textBox1.Text.ToString())).ToString();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            this.label1.Visible = true;

            
            if (checkBox1.Checked) {
                checkBox2.Checked = false;
                this.label1.Text = Math.Sin(DegreeToRadian(Convert.ToSingle(textBox1.Text.ToString()))).ToString();
            }
            else if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                this.label1.Text = Math.Sin(RadianToDegree(Convert.ToSingle(textBox1.Text.ToString()))).ToString();
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            this.label1.Visible = true;
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
                this.label1.Text = Math.Cos(DegreeToRadian(Convert.ToSingle(textBox1.Text.ToString()))).ToString();
            }
            else if (checkBox2.Checked) {
                checkBox1.Checked = false;
                this.label1.Text = Math.Cos(RadianToDegree(Convert.ToSingle(textBox1.Text.ToString()))).ToString();
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            this.label1.Visible = true;
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
                this.label1.Text = Math.Tan(DegreeToRadian(Convert.ToSingle(textBox1.Text.ToString()))).ToString();
            }
            else if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                this.label1.Text = Math.Tan(RadianToDegree(Convert.ToSingle(textBox1.Text.ToString()))).ToString();
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            this.label1.Visible = true;
            this.label1.Text = Math.Log(Convert.ToSingle(textBox1.Text.ToString())).ToString();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            this.label1.Visible = true;
            this.label1.Text = Math.Log10(Convert.ToSingle(textBox1.Text.ToString())).ToString();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            this.label1.Visible = true;
            this.label1.Text = Math.Sqrt(Convert.ToSingle(textBox1.Text.ToString())).ToString();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            this.label1.Visible = true;
            this.label1.Text = Math.Exp(Convert.ToSingle(textBox1.Text.ToString())).ToString();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            this.label2.Visible = true;
            base1 = Convert.ToDouble(this.textBox1.Text);
            this.label2.Text = base1.ToString() + "^";
            this.textBox1.Clear();
            count = 5;
        }



        private void button36_Click(object sender, EventArgs e)
        {
            num = Convert.ToInt64(this.textBox1.Text);
            fact();     
        }
        public void fact()
        {
            for (int i = 1; i < num; i++)
            {
                num = num * i;
            }
            this.label1.Visible = true;
            this.label1.Text = num.ToString();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "(";
        }

        private void button40_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += ")";
        }

        private double DegreeToRadian(double angle)
        {
            return Math.PI * angle / 180.0;
        }
        private double RadianToDegree(double angle)
        {
            return angle * (180.0 / Math.PI);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.checkBox1.Checked = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.checkBox2.Checked = false;
        }
    }
}
