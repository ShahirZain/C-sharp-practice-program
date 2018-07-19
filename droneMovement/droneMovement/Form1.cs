using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace droneMovement
{
    public partial class Form1 : Form
    {
        int startFlag = 0;
        int returnFlag = 0;
        int InvoiceFlag = 0;
        public Point MouseDownLocation, startPosition;
        public Point endPosition;
        int X;
        int Y;
       // Point point = new Point(360, 180);
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.pictureBox1.Hide();
            startPosition = new Point(126,117);
           endPosition = new Point(252, 224);
            this.pictureBox1.Location = startPosition;
            X = endPosition.X - startPosition.X;
            Y = endPosition.Y - startPosition.Y;
        }


        //Set POsition
        private void label4_Click(object sender, EventArgs e)
        {
            this.label5.Visible = false;
            this.pictureBox1.Show();
            
        }

    /*    
        private void pictureBox1_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                endPosition = e.Location;
                MouseDownLocation = e.Location;
            }
        }




        private void pictureBox1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pictureBox1.Left = e.X + MouseDownLocation.X;
                pictureBox1.Top = e.Y + MouseDownLocation.Y;
            }
        }

        */




        private void label1_Click(object sender, EventArgs e) //Start label
        {

        }

        private void label2_Click(object sender, EventArgs e) //Return label
        {

        }

        private void label3_Click(object sender, EventArgs e) //Invoice label
        {

        }

 

        private void pictureBox1_LocationChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            MessageBox.Show("" + this.pictureBox1.Location);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (endPosition.X - startPosition.X != X && endPosition.Y - startPosition.Y != Y)
            {
                this.pictureBox1.Location = endPosition;
                
                

            }
           // MessageBox.Show("" + pictureBox1.Location);
        }


       

       
    }
}
