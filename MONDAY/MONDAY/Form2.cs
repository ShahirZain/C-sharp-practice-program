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

        public void Form2_Load(object sender, EventArgs e)
        {
            this.regularToolStripMenuItem.ShortcutKeys = Keys.F1;
            this.withColorToolStripMenuItem.ShortcutKeys = Keys.F2;
            this.colorToolStripMenuItem.ShortcutKeys = Keys.F3;
            this.textBox2.Visible = false;
            this.textBox3.Visible = false;
            this.label1.Visible = false;
            this.label2.Visible = false;
            this.button1.Visible = false;
            this.label1.Text = "Search";
            this.label2.Text = "Replace";
            this.button1.Text = "OK";
        }

        private void regularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.fontDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.textBox1.Font = this.fontDialog1.Font;
            }

        }

        private void withColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.fontDialog1.ShowColor = true;
            DialogResult dr = this.fontDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.textBox1.Font = this.fontDialog1.Font;
                this.textBox1.ForeColor = this.fontDialog1.Color;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.colorDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.textBox1.ForeColor = this.colorDialog1.Color;
            }
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.label1.Visible == true)
            {
                this.textBox2.Visible = false;
                this.textBox3.Visible = false;
                this.label1.Visible = false;
                this.label2.Visible = false;
                this.button1.Visible = false;
            }
            else
            {
                this.textBox2.Visible = true;
                this.textBox3.Visible = true;
                this.label1.Visible = true;
                this.label2.Visible = true;
                this.button1.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text.Replace(this.textBox2.Text,this.textBox3.Text);
            this.textBox2.Visible = false;
            this.textBox3.Visible = false;
            this.label1.Visible = false;
            this.label2.Visible = false;
            this.button1.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
