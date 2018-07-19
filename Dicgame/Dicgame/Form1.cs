using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using WMPLib;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        int count = 0 ,a,b,c,d,e,f,resultNumber;
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.Black;
            this.button1.Text = "START";
            this.button2.Text = "ABOUT";
            this.button3.Text = "EXIT";
            this.button1.ForeColor = Color.Wheat;
            this.button2.ForeColor = Color.Wheat;
            this.button3.ForeColor = Color.Red;
            this.button1.BackColor = Color.Gray;
            this.button2.BackColor = Color.Gray;
            this.button3.BackColor = Color.Gray;
            this.label1.Visible = false;
            this.label2.Visible = false;
            this.label3.Visible = false;
            this.label4.Visible = false;
            this.label5.Visible = false;
            this.label6.Visible = false;
            this.label7.Visible = false;
            this.label8.Visible = false;
            this.label9.Visible = false;
            this.button4.Visible = false;
            this.button5.Visible = false;
            this.button6.Visible = false;
            this.button5.Enabled = false;
            this.button5.Enabled = false;
            this.button7.Visible = false;
            this.label1.BackColor = Color.Transparent;
            this.label2.BackColor = Color.Transparent; 
            this.label3.BackColor = Color.Transparent;
            this.label4.BackColor = Color.Transparent;
            this.label5.BackColor = Color.Transparent;
            this.label6.BackColor = Color.Transparent;
            this.label7.BackColor = Color.Transparent;
            this.label8.BackColor = Color.Transparent;
            this.label9.BackColor = Color.Transparent;
            this.button1.Cursor = Cursors.Hand;
            this.button2.Cursor = Cursors.Hand;
            this.button3.Cursor = Cursors.Hand;
            this.button4.Cursor = Cursors.Hand;
            this.button5.Cursor = Cursors.Hand;
            this.button6.Cursor = Cursors.Hand;
            this.button7.Text = "Back";
            this.button4.Text = "GO";
            this.button5.Text = "Press Me";
            this.button6.Text = "Close";
            this.label8.Text = "A game is a system in which players engage in an artificial\nconflictdefined by rules, that results in a quantifiable outcome.\n A game is a form of art in which participants, termed players,\n make decisions in order to manage\n resources through game tokens in the pursuit of a goal.";
            this.button6.ForeColor = Color.Snow;
        }

        private void button1_Click(object sender, EventArgs e)
        {
             this.BackgroundImage = new Bitmap(@"E:\Projects\Dicgame\Dicgame\pic.jpeg");
             this.button4.BackgroundImage = new Bitmap(@"E:\Projects\Dicgame\Dicgame\b1.jpg");
            this.button5.BackgroundImage = new Bitmap(@"E:\Projects\Dicgame\Dicgame\b2.jpeg");
            this.button6.BackgroundImage = new Bitmap(@"E:\Projects\Dicgame\Dicgame\b3.jpg");
            this.button4.Visible = true;
            this.button5.Visible = true;
            this.button6.Visible = true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.button1.Visible = false;
            this.button2.Visible = false;
            this.button3.Visible = false;
            this.BackColor = Color.PowderBlue;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            label1.Font = new Font("Arial", 24, FontStyle.Bold);
            this.label1.Visible = true;
            this.button5.Enabled = true;
            this.button4.Enabled = false;
            this.label1.Text = r.Next(0,36).ToString();   
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.label1.Visible = false;
            this.label2.Visible = false;
            this.label3.Visible = false;
            this.label4.Visible = false;
            this.label5.Visible = false;
            this.label6.Visible = false;
            this.label7.Visible = false;
            this.button4.Visible = false;
            this.button5.Visible = false;
            this.button6.Visible = false;
            this.button1.Visible = false;
            this.button2.Visible = false;
            this.button3.Visible = false;
            this.label8.Visible = true;
            this.label8.ForeColor = Color.White;
            this.button7.Visible = true;
        }

       
        private void button5_MouseClick(object sender, MouseEventArgs e)
        {
            cal();
        }
        public void cal() {

            count++;
            if (count == 1)
            {
                
                label2.Font = new Font("Arial", 24, FontStyle.Bold);
                this.label2.Visible = true;
                this.label2.Text = r.Next(0, 6).ToString();
                a = Convert.ToInt32(label2.Text);
                if (a >= Convert.ToInt32(label1.Text)){
                    this.label9.Visible = true;
                    this.label9.Text = "Congrats";
                    this.button5.Enabled = false;
                    player.URL = "sound.mp3";
                    player.controls.play();
                }
            }
            else if (count == 2)
            {
                
                this.label3.Visible = true;
                label3.Font = new Font("Arial", 24, FontStyle.Bold);
                this.label3.Text = r.Next(0, 6).ToString();
                b = Convert.ToInt32(label3.Text);
                if ((a+b) >= Convert.ToInt32(label1.Text))
                {
                    this.label9.Visible = true;
                    this.label9.Text = "Congrats";
                    this.button5.Enabled = false;
                    player.URL = "sound.mp3";
                    player.controls.play();
                }
            }
            else if (count == 3)
            {
                
                this.label4.Visible = true;
                label4.Font = new Font("Arial", 24, FontStyle.Bold);
                this.label4.Text = r.Next(0, 6).ToString();
                c = Convert.ToInt32(label4.Text);
                if ((a + b + c) >= Convert.ToInt32(label1.Text))
                {
                    this.label9.Visible = true;
                    this.label9.Text = "Congrats";
                    this.button5.Enabled = false;
                    player.URL = "sound.mp3";
                    player.controls.play();
                }
            }
            else if (count == 4)
            {
                
                label5.Font = new Font("Arial", 24, FontStyle.Bold);
                this.label5.Visible = true;
                this.label5.Text = r.Next(0, 6).ToString();
                d = Convert.ToInt32(label5.Text);
                if ((a + b + c + d) >= Convert.ToInt32(label1.Text))
                {
                    this.label9.Visible = true;
                    this.label9.Text = "Congrats";
                    this.button5.Enabled = false;
                    player.URL = "sound.mp3";
                    player.controls.play();
                }
            }
            else if (count == 5)
            {
                
                label6.Font = new Font("Arial", 24, FontStyle.Bold);
                this.label6.Visible = true;
                this.label6.Text = r.Next(0, 6).ToString();
                e = Convert.ToInt32(label6.Text);
                if ((a + b + c + d + e) >= Convert.ToInt32(label1.Text))
                {
                    this.label9.Visible = true;
                    this.label9.Text = "Congrats";
                    this.button5.Enabled = false;
                    player.URL = "sound.mp3";
                    player.controls.play();
                }
            }
            else if (count == 6)
            {
                label7.Font = new Font("Arial", 24, FontStyle.Bold);
                this.label7.Visible = true;
                this.label7.Text = r.Next(0, 6).ToString();
                this.button5.Enabled = false;
                f = Convert.ToInt32(label7.Text);
                result();
            }
        }
        public void  result() {
             
            this.label9.Visible = true;
            resultNumber = a + b + c + d + e + f;
             if (resultNumber >= Convert.ToInt32(label1.Text) )
                
            {
                this.label9.Text = "Congrats";
                player.URL = "sound.mp3";
                player.controls.play();
            }
            else {
                this.label9.Text = "failed";
                player.URL = "sound.mp3";
                player.controls.play();
                this.button7.Text = "restart";
                bTN6();
            }
        }

        private void label9_TextChanged(object sender, EventArgs e)
        {
            label9.Font = new Font("Arial", 24, FontStyle.Bold);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            Form1_Load(e,e);
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        public void bTN6() {

            button6_Click(new object(), new EventArgs());
            {
                this.button6.Text = "";
               // this.Controls.Clear();
                //InitializeComponent();
               // Form1_Load(new object(), new EventArgs());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }



    }
}
