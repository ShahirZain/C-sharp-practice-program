using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PracticeOfFiling
{
    
    public partial class directory : Form
    {
        Form1 f1;
        Class1 c1;
        writer f3;
        FileInfo f4;
        public directory(Form1 ff1,writer ff3,FileInfo ff4)
        {
            InitializeComponent();
            
            f1 = ff1;
            f3 = ff3;
            f4 = ff4;
        }

        private void directory_Load(object sender, EventArgs e)
        {
            c1 = new Class1(f1,this,f3,f4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c1.directoryFormButton();
        }
    }
}
