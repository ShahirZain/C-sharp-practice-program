using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SearchInSystem
{
    class Class1
    {
        Form1 f1;
        
      public  Class1(Form1 ff1) {
            f1 = ff1;
        }
      
       
        public void searchItem() {
            string s = f1.textBox1.Text;
            string[] dirs = Directory.GetFiles(@"e:\", ".txt");
            foreach (string dir in dirs)
            {
                f1.textBox1.Text = dir.Length.ToString();
            }
        }
    }
}
