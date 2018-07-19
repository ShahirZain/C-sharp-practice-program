using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ERP
{
    public partial class Form1 : Form
    {
        myConn con = new myConn();
        public int flag = 0;
        public int person = 0;
        public int CustomerFlag = 0;
        public int VendorFlag = 0;
        public int PO = 0;
        public int POFlag = 0;
        public int Customer = 0;
        public int vendor = 0;
        public int admin = 0;
        supportingClass c;
        int a = 0;
        myConn con1 = new myConn();
        public Form1()
        {
            InitializeComponent();
          //  
            
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            c = new supportingClass(this);
            this.bunifuGradientPanel1.Show();
            this.bunifuGradientPanel3.Hide();
            this.panel2.Show();
            c.inactiveButton();
            this.dataGridView1.Visible = false;
            this.panel2.Visible = false;
        }
        //Login and Password
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            using (myConn con = new myConn())
            {
                con.oleDbConnection1.Open();
                try
                {
                    OleDbCommand cmd = new OleDbCommand("select * from Login where un='" + bunifuMaterialTextbox1.Text + "' and '" + bunifuMaterialTextbox2.Text + "'", con.oleDbConnection1);
                    OleDbDataReader dr = cmd.ExecuteReader();
              
                if (dr.Read())
                {

                    MessageBox.Show("accessed");
                    c.activeButton();

                }
                else
                    MessageBox.Show("User name or password ghalat");

                }
                catch (Exception g)
                {
                    System.Windows.Forms.MessageBox.Show("Please fill all values");
                }
            }

        }
        private void bunifuMaterialTextbox1_Enter(object sender, EventArgs e)
        {
            if (this.bunifuMaterialTextbox1.Text == "User name")
                this.bunifuMaterialTextbox1.Text = "";
        }

        private void bunifuMaterialTextbox1_Leave(object sender, EventArgs e)
        {
            if (this.bunifuMaterialTextbox1.Text == "")
                this.bunifuMaterialTextbox1.Text = "User name";
        }

        private void bunifuMaterialTextbox2_Enter(object sender, EventArgs e)
        {
            if (this.bunifuMaterialTextbox2.Text == "Password")
                this.bunifuMaterialTextbox2.Text = "";
        }

        private void bunifuMaterialTextbox2_Leave(object sender, EventArgs e)
        {
            if (this.bunifuMaterialTextbox2.Text == "")
                this.bunifuMaterialTextbox2.Text = "Password";
        }

        //exit button
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        //Supervisor Button

        private void button2_Click(object sender, EventArgs e)
        {
            PO = -1;
            POFlag = -1;
            CustomerFlag = -1;
            Customer = -1;
            person = 2;
            vendor = 1;
            c.Vendor();
            c.vendorId();
            admin = 1;
            VendorFlag = 3;
            this.bunifuThinButton23.Visible = true;
            this.bunifuThinButton24.Visible = false;
            this.bunifuThinButton22.Visible = false;
            this.bunifuThinButton23.ButtonText = "Approval";
            this.dataGridView1.Visible = false;
            this.panel2.Visible = false;
            this.panel3.Visible = false;
            this.panel4.Visible = false;
            this.dataGridView2.Visible = false;
            this.groupBox2.Visible = false;
        }

        //Customer Related Button on side bar
        private void button3_Click(object sender, EventArgs e)
        {

            this.bunifuMaterialTextbox3.Enabled = false;
            c.showVendorAndCustomer(); 
            c.Customer();
            c.hideVendorandCustomer();
            admin = -1;
            person = 1;
            Customer = 1;
            VendorFlag = -1;
            vendor = -1;
            PO = -1;
            POFlag = -1;
            
        }

       

        //Add Button
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            c.clearControl();
            if (Customer == 1)          //Customer related work of Add button
            {
                this.bunifuDropdown2.Visible = true;
                this.label11.Visible = true;
                CustomerFlag = 1;
                this.bunifuMaterialTextbox11.Visible = false;
                c.CustomerId();
                this.bunifuGradaientPanel4.Show();
                this.bunifuThinButton25.ButtonText = "Add";
                this.bunifuMaterialTextbox3.Visible = true;
                this.groupBox2.Visible = false;
            }
            if (vendor == 1)
            {      // vendor related work of Add button
                VendorFlag = 1;
                this.bunifuMaterialTextbox11.Visible = false;
                this.bunifuGradaientPanel4.Show();
                this.bunifuThinButton25.ButtonText = "Add";
                this.bunifuDropdown3.Visible = false;
                this.bunifuMaterialTextbox3.Visible = true;
                this.bunifuDropdown2.Visible = false;
                this.label11.Visible = false;
                this.groupBox2.Visible = false;
                c.vendorId();
            }
            if (PO == 1) {          // PO related because in PO we use only add button
                POFlag = 1;
                c.HidePOSupport();
                c.showButton();
                c.POCombo1();
                this.groupBox2.Visible = true;
            }
        }

        //Update Button
        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            c.clearControl();
            if (Customer == 1)      //Update button for Customer 
            {
                this.bunifuDropdown2.Visible = true;
                this.label11.Visible = true;
                CustomerFlag = 2;       //Customer Flag it shows that  we are in Update 
                this.bunifuDropdown1.Clear();
                this.bunifuDropdown3.Clear();
                this.bunifuMaterialTextbox11.Visible = false;
                this.bunifuThinButton25.ButtonText = "Update";
                this.bunifuMaterialTextbox3.Visible = false;
                this.bunifuDropdown3.Visible = true;
                this.bunifuGradaientPanel4.Show();
                c.customerUpdateDropDown();     // Customer ID drop down for update
            }
            if(vendor==1){
                VendorFlag = 2;     //Vendor flag that shows we are in update button
                this.bunifuDropdown1.Clear();
                this.bunifuDropdown3.Clear();
                this.bunifuMaterialTextbox11.Visible = false;
                this.bunifuThinButton25.ButtonText = "Update";
                this.bunifuMaterialTextbox3.Visible = false;
                this.bunifuDropdown3.Visible = true;
                this.bunifuGradaientPanel4.Show();
                this.bunifuDropdown2.Visible = false;
                this.label11.Visible = false;
                
                if (admin == 1) //ye admin k click hone per run hoga q k agr admin ka button click hua to ye id block chale ga
                {
                    this.bunifuDropdown2.Visible = true;
                    this.label11.Visible = true;
                    VendorFlag = 3;
                }
                c.vendorupdatedropDown(); // vemdor drop down for update
            }
        }
        //View Button
        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            c.clearControl();
            if (Customer == 1)  //Customer view
            {
                CustomerFlag = 3;
                this.bunifuMaterialTextbox11.Visible = true;
                if (flag == 0)
                {
                    this.bunifuMaterialTextbox3.Visible = false;
                    this.label11.Visible = false;
                    this.bunifuDropdown2.Visible = false;
                    this.bunifuDropdown3.Visible = true;
                }
                this.bunifuThinButton25.ButtonText = "Back";
                this.bunifuGradaientPanel4.Show();
                c.customerUpdateDropDown(); // customer drop down for selection
            }
            if (vendor == 1) {  //Vendor view
                VendorFlag = 2;
                this.bunifuGradaientPanel4.Show();
                this.bunifuMaterialTextbox11.Visible = true;
                if (flag == 0)
                {
                    this.bunifuMaterialTextbox3.Visible = false;
                    this.label11.Visible = false;
                    this.bunifuDropdown2.Visible = false;
                    this.bunifuDropdown3.Visible = true;
                }
                c.vendorupdatedropDown();   //vendor drop down for selection
                
                this.bunifuThinButton25.ButtonText = "Back";
                vendor = 0;
                VendorFlag = 4; //vendor flag 4 set krne per panel show hojai ga
                
            }
        }
        //Submit Button
        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            if (Customer == 1)
            {
                c.CustomerAdd();
                if (CustomerFlag == 1 || CustomerFlag == 2)
                    MessageBox.Show("Submitted");
                if (CustomerFlag == 3)
                    this.bunifuGradientPanel3.Show();
            }
            if (vendor == 1) {
                c.VendorAdd();
                if(VendorFlag==1 || VendorFlag==2)
                    MessageBox.Show("Submitted");
            }
            if (VendorFlag == 4)
            {   
                this.bunifuGradaientPanel4.Hide();
                this.bunifuGradientPanel3.Show();
                vendor = 1;
            }
            if(VendorFlag == 3){
            
            }
            

        }
        private void button4_Click(object sender, EventArgs e)  //Button 4 for vendor
        {
            c.Vendor(); 
            c.showVendorAndCustomer();
            c.hideVendorandCustomer();
            admin = -1;
            PO = -1;
            POFlag = -1;
            CustomerFlag = -1;
            Customer = -1;
            person = 2;
            vendor = 1;
            
          
        }

        private void button5_Click(object sender, EventArgs e)  //PO button
        {

            this.groupBox2.Visible = true; 
            this.panel3.Visible = false;
            this.panel4.Visible = false;
            admin = -1;
            person = -1;
            Customer = -1;
            CustomerFlag = -1;
            Customer = -1;
            PO = 1;
            POFlag = 1; //PO flag
            c.HidePOSupport();  //PO hide
            c.PO(); //PO method
            this.bunifuThinButton23.Visible = false;
            this.bunifuThinButton24.Visible = false;
            this.dataGridView2.Visible = false;
            this.bunifuMaterialTextbox11.Visible = false;
            
            this.panel2.Visible = false;
        }

        //drop down 3 of different controll
        private void bunifuDropdown3_onItemSelected(object sender, EventArgs e)
        {
            if(Customer==1){
            c.customerUpdateValue();
            this.bunifuDropdown1.Clear();
            con.oleDbConnection1.Open();

            OleDbCommand cmd1 = new OleDbCommand("select * from Customer", con.oleDbConnection1); //load Customer grp drop down
            OleDbDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
                this.bunifuDropdown1.AddItem(dr1["CG"].ToString());

            
                con.oleDbConnection1.Close();
            }
            if (vendor == 0) {
                c.vendorUpdateValue();
                this.bunifuDropdown1.Clear();
                con.oleDbConnection1.Open();

                OleDbCommand cmd1 = new OleDbCommand("select * from Vendor", con.oleDbConnection1); //load Customer grp drop down
                OleDbDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    this.bunifuDropdown1.AddItem(dr1["VG"].ToString());
                }

                con.oleDbConnection1.Close();
            }
            if(admin==1){
                c.vendorUpdateValue();
                con.oleDbConnection1.Open();

                OleDbCommand cmd1 = new OleDbCommand("select * from Vendor", con.oleDbConnection1); //load Customer grp drop down
                OleDbDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    this.bunifuDropdown1.AddItem(dr1["VG"].ToString());
                }

                con.oleDbConnection1.Close();
            }
           
        }
        
        //combobox 1 selected index change for PO

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            c.POID();
            c.POCombo2();
        }

        //PO vendor combo
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            c.POVendorCombo();
            c.POcombo3PM();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            c.POCombo3selected();  
        } 

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {

            MessageBox.Show("PRODUCT ADDED");
            c.poOrderCounter();
          //  MessageBox.Show(c.pPrice[a].ToString());
          //  MessageBox.Show(c.pModel[a].ToString());
          //  a++;
        }

        //GRN BUTTON SHOW CLICK EVENT WHICH SHOW GRN TABLE
        private void button6_Click(object sender, EventArgs e)
        {
            this.groupBox2.Visible = false;
            this.dataGridView2.Visible = false;
            this.panel3.Visible = false;
            this.panel4.Visible = false;
            this.dataGridView1.Visible = false;
            this.bunifuGradientPanel2.Show();
            this.bunifuGradientPanel3.Show();
            this.bunifuGradaientPanel4.Show();
            this.panel2.Show();
            c.grnCombo();
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Visible = true;
            con1.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select * from Po where Approve='not approve'", con1.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            con1.oleDbConnection1.Close();
           // c.poCreation();
            MessageBox.Show("inserted");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuDropdown4_onItemSelected(object sender, EventArgs e)
        {
            c.grnComboSelected();
        }

        private void bunifuThinButton28_Click(object sender, EventArgs e)
        {
            c.createGrn();
            MessageBox.Show("GRN  has created");
        }

        private void bunifuMaterialTextbox19_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox20_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox23_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.groupBox2.Visible = false;
            this.dataGridView2.Visible = false;
            this.panel1.Visible = true;
            this.panel2.Visible = true;
            this.panel3.Visible = true;
            this.panel4.Visible = false;
            this.bunifuGradientPanel2.Show();
            this.bunifuGradientPanel3.Show();
            this.bunifuGradaientPanel4.Show();
            this.panel3.Show();
            this.panel4.Hide();
            c.inovoicedrop();
        }

        private void bunifuDropdown5_onItemSelected(object sender, EventArgs e)
        {
            c.invoiceSelected();
        }

        private void bunifuThinButton29_Click(object sender, EventArgs e)
        {
            c.inoviceInsert();
            MessageBox.Show("Invoice payable has created");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.groupBox2.Visible = false;
            this.panel1.Visible = true;
            this.panel2.Visible = true;
            this.panel3.Visible = true;
            //this.panel3.Visible = true;
            this.panel4.Visible = true;
            this.dataGridView2.Visible = false;
            this.bunifuGradientPanel2.Show();
            this.bunifuGradientPanel3.Show();
            this.bunifuGradaientPanel4.Show();
            this.panel3.Show();
            this.panel4.Show();
            this.panel5.Hide();
            c.SOCombo1();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            c.SOID();
            c.SOCombo2();
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            c.SOCombo3selected();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            c.SOVendorCombo();
            c.SOcombo3PM();
        }

        private void bunifuThinButton212_Click(object sender, EventArgs e)
        {
            c.SoOrderCounter();
            MessageBox.Show("Product added");
        }

        private void bunifuThinButton211_Click(object sender, EventArgs e)
        {
            this.dataGridView2.Visible = true;
            con1.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select * from so where Status='close'", con1.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView2.DataSource = dt;
            con1.oleDbConnection1.Close();
            // c.poCreation();
            MessageBox.Show("inserted");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.groupBox2.Visible = false;
            this.bunifuDropdown6.Clear();
            this.panel1.Visible = true;
            this.panel2.Visible = true;
            this.panel3.Visible = true;
            this.panel4.Visible = true;
            this.dataGridView2.Visible = false;
            this.bunifuGradientPanel2.Show();
            this.bunifuGradientPanel3.Show();
            this.bunifuGradaientPanel4.Show();
            this.panel3.Show();
            this.panel4.Show();
            this.panel5.Show();
            this.panel6.Hide();
            c.DCCombo();
            this.dataGridView2.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.groupBox2.Visible = false;
            this.panel1.Visible = true;
            this.panel2.Visible = true;
            this.panel3.Visible = true;
            this.panel4.Visible = true;
            this.dataGridView2.Visible = false;
            this.bunifuGradientPanel2.Show();
            this.bunifuGradientPanel3.Show();
            this.bunifuGradaientPanel4.Show();
            this.panel3.Show();
            this.panel4.Show();
            this.panel5.Show();
            this.panel6.Show();
            this.dataGridView2.Visible = false;
            c.invoiceDropdown();
            c.invoiceId();
        }

        private void bunifuDropdown6_onItemSelected(object sender, EventArgs e)
        {
            c.SOComboSelected();
        }

        private void bunifuThinButton213_Click(object sender, EventArgs e)
        {
            c.SOcreateDC();
            MessageBox.Show("Challan  has created");
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton214_Click(object sender, EventArgs e)
        {
            c.SoinoviceInsert();
            MessageBox.Show("Invoice Receivable has created");

        }

        private void bunifuDropdown7_onItemSelected(object sender, EventArgs e)
        {
            c.invoiceDropdown0();
        }

       


       


        

       

       
    }
}

