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
        String text=null;
        public Form1()
        {
            InitializeComponent();
            
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "NotePad --";
            this.replaceToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.R;
            this.fontToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
            this.helpToolStripMenuItem1.ShortcutKeys = Keys.F1;
            this.openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            this.saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            this.newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            openFileDialog1.Filter = "Text Files|*.txt";
            saveFileDialog1.Filter = "Text Files|*.txt";
            this.textBox1.ScrollBars = ScrollBars.Both;
            this.fontDialog1.Font = new Font("Cambria", 11);
            this.textBox1.Font = new Font("Cambria", 11);
            this.label1.Text = DateTime.Now.ToString();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Copy();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.SelectAll();
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.wordWrapToolStripMenuItem.Checked == true)
            {
                this.textBox1.WordWrap = true;
            }
            else
            {
                this.textBox1.WordWrap = false;
            }
        }

    //    private void newToolStripMenuItem_Click(object sender, EventArgs e)
      //  {
         //   this.textBox1.Clear();
        //}

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult DR = this.openFileDialog1.ShowDialog();
            if (DR == DialogResult.OK)
            {
                String fname = openFileDialog1.FileName;
                this.textBox1.Text = File.ReadAllText(fname);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult DR = this.saveFileDialog1.ShowDialog();
            if (DR == DialogResult.OK)
            {
                String fname = saveFileDialog1.FileName + ".txt";

                File.WriteAllText(fname, this.textBox1.Text);
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.fontDialog1.ShowColor = true;
            DialogResult DR = this.fontDialog1.ShowDialog();
            if (DR == DialogResult.OK)
            {
                this.textBox1.Font = this.fontDialog1.Font;

            }
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this);
            f2.Show();
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this);
            f2.label1.Visible = false;
            f2.label2.Visible = false;
            f2.button1.Visible = false;
            f2.textBox2.Visible = false;
            f2.textBox3.Visible = false;
            f2.textBox1.Text = "Software is under development";
            f2.textBox1.ReadOnly = true;
            f2.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this);
            f2.label1.Visible = false;
            f2.label2.Visible = false;
            f2.button1.Visible = false;
            f2.textBox2.Visible = false;
            f2.textBox3.Visible = false;
            f2.textBox1.Text = "Mujhe smjhne k lye apka smjhdar hona zaruri hy";
            f2.textBox1.ReadOnly = true;
            f2.ShowDialog();
        }

        public void newSave() {
            if(this.textBox1.Text==null){
                this.textBox1.Clear();
            }
            
            if (text == this.textBox1.Text)
            {
                this.textBox1.Clear();
            }
            else
            {
                text = this.textBox1.Text;
                Form3 f3 = new Form3();
                f3.ShowDialog();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newSave();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text = "";
            if (text != this.textBox1.Text)
            {
                Form3 f3 = new Form3();
                f3.ShowDialog();
                text = textBox1.Text;
            }
            else
            Application.Exit();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        

      

       

       
    }
}
