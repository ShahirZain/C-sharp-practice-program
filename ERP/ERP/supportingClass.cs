using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace ERP
{
    class supportingClass
    {
        int CID = 11;
     public   int[] pPrice = new int[50];
     public   int[] pQty = new int[50];
        String[] pName = new String[50];
     public   String[] pModel = new String[50];
        int poCounter = 0;
        myConn con1 = new myConn();
        Form1 f1;

       public supportingClass(Form1 ff1) {
            f1 = ff1;
        }

     
        //Customer Related Work 

       public void showVendorAndCustomer()
       {
           f1.bunifuDropdown2.Visible = true;
           f1.bunifuDropdown3.Visible = true;
           f1.bunifuThinButton25.Visible = true;
           f1.label2.Visible = true;
           f1.label3.Visible = true;
           f1.label4.Visible = true;
           f1.label5.Visible = true;
           f1.label6.Visible = true;
           f1.label7.Visible = true;
           f1.label8.Visible = true;
           f1.label9.Visible = true;
           f1.bunifuMaterialTextbox3.Visible = true;
           f1.bunifuMaterialTextbox4.Visible = true;
           f1.bunifuMaterialTextbox5.Visible = true;
           f1.bunifuMaterialTextbox6.Visible = true;
           f1.bunifuMaterialTextbox7.Visible = true;
           f1.bunifuMaterialTextbox8.Visible = true;
           f1.bunifuMaterialTextbox9.Visible = true;
           f1.bunifuMaterialTextbox3.Visible = true;
           f1.bunifuMaterialTextbox10.Visible = true;
           f1.bunifuDropdown2.Visible = true;
           f1.bunifuThinButton22.Visible = true;
           f1.bunifuThinButton23.Visible = true;
           f1.bunifuThinButton24.Visible = true;

       }

       public void hideVendorandCustomer() {

           f1.groupBox2.Visible = false;
           f1.panel3.Visible = false;
           f1.panel4.Visible = false;
           f1.dataGridView1.Visible = false;
           f1.panel2.Visible = false;
           f1.dataGridView2.Visible = false;


           //customer

           f1.groupBox2.Visible = false;
           f1.dataGridView1.Visible = false;
           f1.panel2.Visible = false;
       }


       public void Customer() {
           f1.bunifuGradientPanel3.Show();
           f1.bunifuGradaientPanel4.Hide();
           f1.bunifuThinButton22.ButtonText = "Customer Data";
           f1.bunifuThinButton23.ButtonText = "Update Customer";
           f1.bunifuThinButton24.ButtonText = "View Customer";
           f1.label2.Text = "Customer ID";
           f1.label3.Text = "Customer Name";
           f1.label4.Text = "Customer Address";
           f1.groupBox1.Visible = false;
           f1.groupBox2.Visible = false;
           f1.groupBox3.Visible = false;
           f1.bunifuThinButton27.Visible = false;
           f1.label11.Visible = true;
           f1.bunifuDropdown2.Visible = true;
           f1.bunifuDropdown3.Visible = false;
       }

       //Automatic generation of ID

       public void CustomerId()
       {

           f1.bunifuDropdown1.Clear();
           f1.bunifuDropdown3.Clear();
           con1.oleDbConnection1.Open();

           OleDbCommand cmd = new OleDbCommand("select * from Customer", con1.oleDbConnection1);
           OleDbDataReader dr = cmd.ExecuteReader();
           while (dr.Read())
               f1.bunifuDropdown1.AddItem(dr["CG"].ToString());

           if (f1.person == 1)
           {

               OleDbCommand cmd1 = new OleDbCommand("select count(CID) from Customer", con1.oleDbConnection1);
               OleDbDataReader dr1 = cmd1.ExecuteReader();
               if (dr1.Read())
               {
                   CID = Convert.ToInt32(dr1[0]); CID++;
               }
               f1.bunifuMaterialTextbox3.Text = "C00-" + CID + "-" + System.DateTime.Today.Year;

           }
           con1.oleDbConnection1.Close();
       }

       //Add Customer combo me addititon
       public void CustomerAdd() {
           
           //add customer
           if (f1.CustomerFlag == 1)
           {
               con1.oleDbConnection1.Open();
               try
               {
                   OleDbCommand cmd = new OleDbCommand("insert into Customer(CID,Cname,CAddress,PH1,CP,CPPH,CEmail,CL,CStatus,CG) values(@CID,@Cname,@CAddress,@PH1,@CP,@CPPH,@CEmail,@CL,@CStatus,@CG)", con1.oleDbConnection1);
                   cmd.Parameters.AddWithValue("@CID", f1.bunifuMaterialTextbox3.Text);
                   cmd.Parameters.AddWithValue("@Cname", f1.bunifuMaterialTextbox4.Text);
                   cmd.Parameters.AddWithValue("@CAdress", f1.bunifuMaterialTextbox5.Text);
                   cmd.Parameters.AddWithValue("@PH1", f1.bunifuMaterialTextbox6.Text);
                   cmd.Parameters.AddWithValue("@CP", f1.bunifuMaterialTextbox10.Text);
                   cmd.Parameters.AddWithValue("@CPPH", f1.bunifuMaterialTextbox8.Text);
                   cmd.Parameters.AddWithValue("@CEmail", f1.bunifuMaterialTextbox9.Text);
                   cmd.Parameters.AddWithValue("@CL", f1.bunifuMaterialTextbox7.Text);
                   cmd.Parameters.AddWithValue("@CStatus", f1.bunifuDropdown2.selectedValue);
                   cmd.Parameters.AddWithValue("@CG", f1.bunifuDropdown1.selectedValue);


                   cmd.ExecuteNonQuery();
               }
               catch (Exception e)
               {
                   System.Windows.Forms.MessageBox.Show("Please fill all values");
               }

               con1.oleDbConnection1.Close();

           }
           //update customer
           if (f1.CustomerFlag == 2) {
               try
               {
                   con1.oleDbConnection1.Open();
                   OleDbCommand cmd = new OleDbCommand("Update Customer set Cname = @Cname,CAddress=@CAddress,PH1=@PH1,CP=@CP,CPPH=@CPPH,CEmail=@CEmail,CL=@CL,CStatus=@CStatus,CG=@CG where CID = '" + f1.bunifuDropdown3.selectedValue + "'", con1.oleDbConnection1);

                   cmd.Parameters.AddWithValue("@Cname", f1.bunifuMaterialTextbox4.Text);
                   cmd.Parameters.AddWithValue("@CAdress", f1.bunifuMaterialTextbox5.Text);
                   cmd.Parameters.AddWithValue("@PH1", f1.bunifuMaterialTextbox6.Text);
                   cmd.Parameters.AddWithValue("@CP", f1.bunifuMaterialTextbox10.Text);
                   cmd.Parameters.AddWithValue("@CPPH", f1.bunifuMaterialTextbox8.Text);
                   cmd.Parameters.AddWithValue("@CEmail", f1.bunifuMaterialTextbox9.Text);
                   cmd.Parameters.AddWithValue("@CL", f1.bunifuMaterialTextbox7.Text);
                   cmd.Parameters.AddWithValue("@CStatus", f1.bunifuDropdown2.selectedValue);
                   cmd.Parameters.AddWithValue("@CG", f1.bunifuDropdown1.selectedValue.ToString());


                   cmd.ExecuteNonQuery();

               }
               catch(Exception e){
                   System.Windows.Forms.MessageBox.Show("Please fill all values");
               }
               con1.oleDbConnection1.Close();
           }
           if(f1.CustomerFlag==3){
               f1.bunifuGradaientPanel4.Hide();
           }
        
           }

       

        //Customer Update  and view  single method for two thing 

       public void customerUpdateDropDown() {
           con1.oleDbConnection1.Open();
           f1.bunifuDropdown1.Clear();
           f1.bunifuDropdown3.Clear();
           OleDbCommand cmd = new OleDbCommand("select * from Customer ", con1.oleDbConnection1);
           OleDbDataReader dr = cmd.ExecuteReader();
           while (dr.Read())
               f1.bunifuDropdown3.AddItem(dr["CID"].ToString());
           con1.oleDbConnection1.Close();
       }


        //Customer update and view  which is obtained by dropdown 3 we use singal method because we have to project values in both case i.e. view and 
        // update. the method that is use for update is just for this method
       public void customerUpdateValue() {

           try
           {
               con1.oleDbConnection1.Open();
               OleDbCommand cmd = new OleDbCommand("select * from Customer where CID = '" + f1.bunifuDropdown3.selectedValue.ToString() + "'", con1.oleDbConnection1);
               OleDbDataReader dr = cmd.ExecuteReader();
               if (dr.Read())
               {

                   f1.bunifuMaterialTextbox4.Text = dr["cname"].ToString();
                   f1.bunifuMaterialTextbox5.Text = dr["CAddress"].ToString();
                   f1.bunifuMaterialTextbox6.Text = dr["PH1"].ToString();
                   f1.bunifuMaterialTextbox10.Text = dr["CP"].ToString();
                   f1.bunifuMaterialTextbox9.Text = dr["CEmail"].ToString();
                   f1.bunifuMaterialTextbox8.Text = dr["CPPH"].ToString();
                   f1.bunifuMaterialTextbox7.Text = dr["CL"].ToString();
                   f1.bunifuMaterialTextbox11.Text = dr["CG"].ToString();



               }
           }
           catch (Exception e)
           {
               System.Windows.Forms.MessageBox.Show("Please fill all values");
           }
           con1.oleDbConnection1.Close();
       }



        //Vendor Related Tools 

        public void Vendor()
       {

           f1.bunifuGradientPanel3.Show();
           f1.bunifuGradaientPanel4.Hide();
           f1.bunifuThinButton22.ButtonText = "Vendor Data";
           f1.bunifuThinButton23.ButtonText = "Update Vendor";
           f1.bunifuThinButton24.ButtonText = "View Vendor";
           f1.label6.Text = "Fax";
           f1.label2.Text = "Vendor ID";
           f1.label3.Text = "Vendor Name";
           f1.label4.Text = "Vendor Address";
           f1.groupBox1.Visible = false;
           f1.groupBox2.Visible = false;
           f1.groupBox3.Visible = false;
           f1.bunifuThinButton27.Visible = false;

       }
        //Vendor ID here dropdown 1 populated with VG
       public void vendorId() {
           f1.bunifuDropdown1.Clear();
           f1.bunifuDropdown3.Clear();
           //Automatic generation of ID
           con1.oleDbConnection1.Open();

           OleDbCommand cmd = new OleDbCommand("select * from Vendor", con1.oleDbConnection1);
           OleDbDataReader dr = cmd.ExecuteReader();
           while (dr.Read())
               f1.bunifuDropdown1.AddItem(dr["VG"].ToString());

           if (f1.person == 2)      //Automatic generation of ID for vendor
           {

               OleDbCommand cmd1 = new OleDbCommand("select count(VID) from Vendor", con1.oleDbConnection1);
               OleDbDataReader dr1 = cmd1.ExecuteReader();
               if (dr1.Read())
               {
                   CID = Convert.ToInt32(dr1[0]);
                   CID++;
               }
               f1.bunifuMaterialTextbox3.Text = "V00-" + CID + "-" + System.DateTime.Today.Year;

           }
           con1.oleDbConnection1.Close();
       }

       public void VendorAdd()
       {
           //Add Customer combo me addititon
           if (f1.VendorFlag == 1)
           {
               try
               {
                   con1.oleDbConnection1.Open();
                   OleDbCommand cmd = new OleDbCommand("insert into Vendor(VID,VName,VAddress,PH1,CP,CPPH,VEmail,VFax,VStatus,VG) values(@VID,@VName,@VAddress,@PH1,@CP,@CPPH,@VEmail,@VFax,@VStatus,@VG)", con1.oleDbConnection1);
                   cmd.Parameters.AddWithValue("@VID", f1.bunifuMaterialTextbox3.Text);
                   cmd.Parameters.AddWithValue("@VName", f1.bunifuMaterialTextbox4.Text);
                   cmd.Parameters.AddWithValue("@VAdress", f1.bunifuMaterialTextbox5.Text);
                   cmd.Parameters.AddWithValue("@PH1", Convert.ToInt64(f1.bunifuMaterialTextbox6.Text));
                   cmd.Parameters.AddWithValue("@CP", f1.bunifuMaterialTextbox10.Text);
                   cmd.Parameters.AddWithValue("@CPPH", Convert.ToInt32(f1.bunifuMaterialTextbox8.Text));
                   cmd.Parameters.AddWithValue("@VEmail", f1.bunifuMaterialTextbox9.Text);
                   cmd.Parameters.AddWithValue("@VFax", f1.bunifuMaterialTextbox7.Text);
                   cmd.Parameters.AddWithValue("@VStatus", "inactive");
                   cmd.Parameters.AddWithValue("@VG", f1.bunifuDropdown1.selectedValue);

                   cmd.ExecuteNonQuery();
               }
               catch (Exception e)
               {
                   System.Windows.Forms.MessageBox.Show("Please fill all values");
               }

               con1.oleDbConnection1.Close();
           }
           if (f1.VendorFlag == 2 || f1.VendorFlag==3) //Upadte value
           {
               try
               {
                   con1.oleDbConnection1.Open();
                   OleDbCommand cmd = new OleDbCommand("Update Vendor set Vid =@vid , VName = @VName,VAddress=@VAddress,PH1=@PH1,CP=@CP,CPPH=@CPPH,VEmail=@VEmail,CFax=@CFax,VStatus=@VStatus,VG=@VG where VID = '" + f1.bunifuDropdown3.selectedValue + "'", con1.oleDbConnection1);
                   cmd.Parameters.AddWithValue("@Vid", "123");
                   cmd.Parameters.AddWithValue("@VName", f1.bunifuMaterialTextbox4.Text);
                   cmd.Parameters.AddWithValue("@VAdress", f1.bunifuMaterialTextbox5.Text);
                   cmd.Parameters.AddWithValue("@PH1", Convert.ToInt32(f1.bunifuMaterialTextbox6.Text));
                   cmd.Parameters.AddWithValue("@CP", f1.bunifuMaterialTextbox10.Text);
                   cmd.Parameters.AddWithValue("@CPPH", Convert.ToInt32(f1.bunifuMaterialTextbox8.Text));
                   cmd.Parameters.AddWithValue("@VEmail", f1.bunifuMaterialTextbox9.Text);
                   cmd.Parameters.AddWithValue("@VFax", f1.bunifuMaterialTextbox7.Text);
                   cmd.Parameters.AddWithValue("@VStatus", "inactive");
                   cmd.Parameters.AddWithValue("@VG", "a");

                   cmd.ExecuteNonQuery();

               }
               catch (Exception e)
               {
                   System.Windows.Forms.MessageBox.Show("Please fill all values");
               }
               con1.oleDbConnection1.Close();
           }
           if(f1.VendorFlag ==3){   // update
               con1.oleDbConnection1.Open();
               OleDbCommand cmd = new OleDbCommand("select * from Vendor where VStatus = inactive", con1.oleDbConnection1);
               OleDbDataReader dr = cmd.ExecuteReader();
               while (dr.Read())
                   f1.bunifuDropdown3.AddItem(dr["VID"].ToString());


               con1.oleDbConnection1.Close();
           }
           if (f1.CustomerFlag == 3)
           {
               f1.bunifuGradaientPanel4.Hide();
           }

       }

       public void vendorupdatedropDown() {
           if(f1.VendorFlag==2){
           con1.oleDbConnection1.Open();
           f1.bunifuDropdown1.Clear();
           f1.bunifuDropdown3.Clear();
           OleDbCommand cmd = new OleDbCommand("select * from Vendor ", con1.oleDbConnection1);
           OleDbDataReader dr = cmd.ExecuteReader();
           while (dr.Read())
               f1.bunifuDropdown3.AddItem(dr["VID"].ToString());
           con1.oleDbConnection1.Close();
           }
           if(f1.VendorFlag==3){
               con1.oleDbConnection1.Open();
               f1.bunifuDropdown1.Clear();
               //f1.bunifuDropdown3.Clear();
               OleDbCommand cmd1 = new OleDbCommand("select * from Vendor where VStatus = 'Active' ", con1.oleDbConnection1);
               OleDbDataReader dr1 = cmd1.ExecuteReader();
               while (dr1.Read())
               {
                   f1.bunifuDropdown3.AddItem(dr1["VID"].ToString());
               }
               con1.oleDbConnection1.Close();
               f1.bunifuThinButton25.ButtonText = "Approve or Reject";
           }
       }


       public void vendorUpdateValue()
       {

           con1.oleDbConnection1.Open();
           OleDbCommand cmd = new OleDbCommand("select * from vendor where VID = '" + f1.bunifuDropdown3.selectedValue.ToString() + "'", con1.oleDbConnection1);
           OleDbDataReader dr = cmd.ExecuteReader();
           if (dr.Read())
           {

               f1.bunifuMaterialTextbox4.Text = dr["VName"].ToString();
               f1.bunifuMaterialTextbox5.Text = dr["VAddress"].ToString();
               f1.bunifuMaterialTextbox6.Text = dr["PH1"].ToString();
               f1.bunifuMaterialTextbox10.Text = dr["CP"].ToString();
               f1.bunifuMaterialTextbox9.Text = dr["VEmail"].ToString();
               f1.bunifuMaterialTextbox8.Text = dr["CPPH"].ToString();
               f1.bunifuMaterialTextbox7.Text = dr["VFax"].ToString();
               f1.bunifuMaterialTextbox11.Text = dr["VG"].ToString();



           }
           con1.oleDbConnection1.Close();
       }







       public void PO() {
           f1.bunifuGradientPanel3.Show();
           f1.bunifuGradaientPanel4.Hide();
           f1.bunifuThinButton22.ButtonText = "ADD PO";
           f1.bunifuThinButton23.ButtonText = "Update PO ";
           f1.bunifuThinButton24.ButtonText = "View PO";
           
       }
       public void HidePOSupport() {
           
           f1.bunifuDropdown2.Visible = false;
           f1.bunifuDropdown3.Visible = false;
           f1.bunifuThinButton25.Visible = false;
           f1.label2.Visible = false;
           f1.label3.Visible = false;
           f1.label4.Visible = false;
           f1.label5.Visible = false;
           f1.label6.Visible = false;
           f1.label7.Visible = false;
           f1.label8.Visible = false;
           f1.label9.Visible = false;
           f1.label10.Visible = false;
           f1.label11.Visible = false;
           f1.bunifuMaterialTextbox3.Visible = false;
           f1.bunifuMaterialTextbox4.Visible = false;
           f1.bunifuMaterialTextbox5.Visible = false;
           f1.bunifuMaterialTextbox6.Visible = false;
           f1.bunifuMaterialTextbox7.Visible = false;
           f1.bunifuMaterialTextbox8.Visible = false;
           f1.bunifuMaterialTextbox9.Visible = false;
           f1.bunifuMaterialTextbox3.Visible = false;
           f1.bunifuMaterialTextbox10.Visible = false;
           f1.bunifuDropdown2.Visible = false;
           f1.label11.Visible = false;
           f1.bunifuMaterialTextbox3.Visible = false;
           f1.dataGridView1.Visible = false;
           f1.panel2.Visible = false;
         
       }
      
       public void showButton() {
           f1.bunifuGradaientPanel4.Show();
           f1.groupBox1.Visible = true;
           f1.groupBox2.Visible = true;
           f1.groupBox3.Visible = true;
           f1.bunifuThinButton27.Visible = true;
       }
       public void POCombo1() {
           con1.oleDbConnection1.Open();
           OleDbCommand cmd = new OleDbCommand("select * from Vendor", con1.oleDbConnection1);
           OleDbDataReader dr = cmd.ExecuteReader();
           while (dr.Read())
               f1.comboBox1.Items.Add(dr["VG"].ToString());
           con1.oleDbConnection1.Close();
       }
       public void POID() {
           con1.oleDbConnection1.Open();
           OleDbCommand cmd1 = new OleDbCommand("select count(POID) from PO", con1.oleDbConnection1);
           OleDbDataReader dr1 = cmd1.ExecuteReader();
           if (dr1.Read())
           {
               CID = Convert.ToInt32(dr1[0]); 
               CID++;
           }
           f1.textBox1.Text = f1.comboBox1.Text + CID + "-" + System.DateTime.Today.Year;
           con1.oleDbConnection1.Close();
       }
       public void POCombo2() {
           con1.oleDbConnection1.Open();
           OleDbCommand cmd = new OleDbCommand("select * from Vendor where VG= '"+f1.comboBox1.Text+"'", con1.oleDbConnection1);
           OleDbDataReader dr = cmd.ExecuteReader();
           while (dr.Read())
               f1.comboBox2.Items.Add(dr["VID"].ToString());
           con1.oleDbConnection1.Close();

       }
       public void POVendorCombo() {
           con1.oleDbConnection1.Open();
           OleDbCommand cmd = new OleDbCommand("select * from Vendor where VID= '" + f1.comboBox2.Text + "'", con1.oleDbConnection1);
           OleDbDataReader dr = cmd.ExecuteReader();
           while(dr.Read()){
               f1.textBox2.Text = dr["VName"].ToString();
               f1.textBox3.Text = dr["CP"].ToString();
               f1.textBox4.Text = dr["PH1"].ToString();
               
           }
           con1.oleDbConnection1.Close();

       }
       public void POcombo3PM() {           //combo 3 for product model and it populated at combo 2

           con1.oleDbConnection1.Open();
           OleDbCommand cmd = new OleDbCommand("select * from Products",con1.oleDbConnection1);
           OleDbDataReader dr = cmd.ExecuteReader();
           while (dr.Read())
               f1.comboBox3.Items.Add(dr["pname"].ToString());
           con1.oleDbConnection1.Close();
       }

        //ye combo3 k selected index k upar lage ga
       public void POCombo3selected() {
           con1.oleDbConnection1.Open();
           OleDbCommand cmd = new OleDbCommand("select * from products where pname= '" + f1.comboBox3.Text + "'", con1.oleDbConnection1);
           OleDbDataReader dr = cmd.ExecuteReader();
           while (dr.Read())
           {
               f1.textBox6.Text = dr["price"].ToString();
               f1.textBox7.Text = dr["pname"].ToString();
           }
           OleDbCommand cmd1 = new OleDbCommand("select count(POID) from PO", con1.oleDbConnection1);
           OleDbDataReader dr1 = cmd1.ExecuteReader();
           if (dr1.Read())
           {
               CID = Convert.ToInt32(dr1[0]); CID++;
           }
           f1.textBox7.Text = "P-" + CID;

           con1.oleDbConnection1.Close();
           
       }
        //product count its mean how different product user inserted
       public void poOrderCounter() {

           try
           {
               int price = Convert.ToInt32(f1.textBox6.Text) * Convert.ToInt32(f1.textBox5.Text);
               con1.oleDbConnection1.Open();
               OleDbCommand cmd = new OleDbCommand("insert into PO(POID,DDATE,Status,approve,vdept,vname,vid,vcp,vcpph,tprice) values(@POID,@DDATE,@Status,@approve,@vdept,@vname,@vid,@vcp,@vcpph,@tprice)", con1.oleDbConnection1);
               cmd.Parameters.AddWithValue("@POID", f1.textBox7.Text);
               cmd.Parameters.AddWithValue("@DDATE", f1.dateTimePicker1);
               cmd.Parameters.AddWithValue("@Status", "open");
               cmd.Parameters.AddWithValue("@approve", "approve");
               cmd.Parameters.AddWithValue("@Vdept", f1.comboBox1.Text);
               cmd.Parameters.AddWithValue("@Vname", f1.textBox2.Text);
               cmd.Parameters.AddWithValue("@Vid", f1.comboBox2.Text);
               cmd.Parameters.AddWithValue("@vcp", f1.textBox3.Text);
               cmd.Parameters.AddWithValue("@vccph", Convert.ToInt32(f1.textBox4.Text));
               cmd.Parameters.AddWithValue("@tprice", price);
               cmd.ExecuteNonQuery();
           }
           catch (Exception e)
           {
               System.Windows.Forms.MessageBox.Show("Please fill all values");
           }
           con1.oleDbConnection1.Close();

           /*
           pModel[poCounter] = f1.comboBox3.Text;
           pName[poCounter] = f1.textBox7.Text;
           pQty[poCounter] = Convert.ToInt32(f1.textBox5.Text);
           pPrice[poCounter] = Convert.ToInt32(f1.textBox6.Text) * pQty[poCounter];
           
           poCounter++;
           */
       }

       public void poCreation() {



       }
       public void grnCombo() {
           con1.oleDbConnection1.Open();
           OleDbCommand cmd = new OleDbCommand("select * from PO ", con1.oleDbConnection1);
           OleDbDataReader dr = cmd.ExecuteReader();
           while (dr.Read())
           {
               f1.bunifuDropdown4.AddItem(dr["POID"].ToString());
           }

           OleDbCommand cmd1 = new OleDbCommand("select count(GRNID) from GRN", con1.oleDbConnection1);
           OleDbDataReader dr1 = cmd1.ExecuteReader();
           if (dr1.Read())
               {
                   CID = Convert.ToInt32(dr1[0]); 
                   CID++;
               }
               f1.bunifuMaterialTextbox12.Text = "GRN-" + CID + "-" + System.DateTime.Today.Year;

           con1.oleDbConnection1.Close();

       }
       public void grnComboSelected() {
           con1.oleDbConnection1.Open();
           OleDbCommand cmd = new OleDbCommand("select * from PO where poid='" + f1.bunifuDropdown4.selectedValue + "'", con1.oleDbConnection1);
           OleDbDataReader dr = cmd.ExecuteReader();
           while (dr.Read())
           {
               f1.bunifuMaterialTextbox14.Text = dr["VNAME"].ToString();
               f1.bunifuMaterialTextbox13.Text = dr["DDATE"].ToString();
               f1.bunifuMaterialTextbox15.Text = dr["vid"].ToString();
              // f1.bunifuMaterialTextbox14.Text = dr["DDATE"].ToString();
               f1.bunifuMaterialTextbox18.Text = dr["tprice"].ToString();

           }
           con1.oleDbConnection1.Close();
       }
       public void createGrn() {
           try
           {
               con1.oleDbConnection1.Open();
               OleDbCommand cmd = new OleDbCommand("insert into GRN(GRNID,POID,status,Vname,ddate,GRDate) values (@GRNID,@POID,@status,@Vname,@ddate,@GRDate)", con1.oleDbConnection1);
               cmd.Parameters.AddWithValue("@Grnid", f1.bunifuDropdown4.selectedValue);
               cmd.Parameters.AddWithValue("@POID", f1.bunifuMaterialTextbox12.Text);
               cmd.Parameters.AddWithValue("@status", "open");
               cmd.Parameters.AddWithValue("@vname", f1.bunifuMaterialTextbox14.Text);
               cmd.Parameters.AddWithValue("@ddate", f1.bunifuMaterialTextbox13.Text);
               cmd.Parameters.AddWithValue("@GRDate", f1.dateTimePicker1);
               cmd.ExecuteNonQuery();
           }
           catch (Exception e)
           {
               System.Windows.Forms.MessageBox.Show("Please fill all values");
           }
           con1.oleDbConnection1.Close();
       }
       public void inovoicedrop() {
              con1.oleDbConnection1.Open();
           OleDbCommand cmd = new OleDbCommand("select * from PO ", con1.oleDbConnection1);
           OleDbDataReader dr = cmd.ExecuteReader();
           while (dr.Read())
           {
               f1.bunifuDropdown5.AddItem(dr["POID"].ToString());
           }
           con1.oleDbConnection1.Close();
       }
       public void invoiceSelected() { 
        con1.oleDbConnection1.Open();
           //po se vendor ka name ka id contact person or vccp nikale ga
        OleDbCommand cmd0 = new OleDbCommand("select * from PO where poid='" + f1.bunifuDropdown5.selectedValue + "'", con1.oleDbConnection1);
        OleDbDataReader dr0 = cmd0.ExecuteReader();
           //grn se grnid grn date ,ddate
           OleDbCommand cmd = new OleDbCommand("select * from grn where grnid='" + f1.bunifuDropdown5.selectedValue + "'", con1.oleDbConnection1);
           OleDbDataReader dr = cmd.ExecuteReader();
           while (dr.Read()&& dr0.Read())
           {
               f1.bunifuMaterialTextbox21.Text = dr0["VNAME"].ToString();
               f1.bunifuMaterialTextbox20.Text = dr0["vid"].ToString();
               f1.bunifuMaterialTextbox22.Text = dr0["VCP"].ToString();
               f1.bunifuMaterialTextbox23.Text = dr0["VCPPH"].ToString();
               f1.bunifuMaterialTextbox25.Text = dr0["tprice"].ToString();
               f1.bunifuMaterialTextbox17.Text = dr["GRNID"].ToString();
               f1.bunifuMaterialTextbox24.Text = dr["GRDate"].ToString();
               f1.bunifuMaterialTextbox26.Text = dr["ddate"].ToString();
           }
           OleDbCommand cmd1 = new OleDbCommand("select count(InvoiceID) from invoice", con1.oleDbConnection1);
           OleDbDataReader dr1 = cmd1.ExecuteReader();
           if (dr1.Read())
           {
               CID = Convert.ToInt32(dr1[0]); CID++;
           }
           f1.bunifuMaterialTextbox19.Text = "INC-" + CID;
           con1.oleDbConnection1.Close();
       }
       public void inoviceInsert() {
           con1.oleDbConnection1.Open();
           try
           {
               OleDbCommand cmd = new OleDbCommand("insert into invoice(InvoiceID,vendorid,VendorName,cp,cpph,ddate,GRNDate,amountpayable,grnid) values (@invoiceId,@vendorid,@VendorName,@cp,@cpph,@ddate,@GRNDate,@amountpayable,@grnid)", con1.oleDbConnection1);
               cmd.Parameters.AddWithValue("@InvoiceID", f1.bunifuMaterialTextbox19.Text);
               cmd.Parameters.AddWithValue("@vendorid", f1.bunifuMaterialTextbox20.Text);
               cmd.Parameters.AddWithValue("@VendorName", f1.bunifuMaterialTextbox21.Text);
               cmd.Parameters.AddWithValue("@cp", f1.bunifuMaterialTextbox22.Text);
               cmd.Parameters.AddWithValue("@cpph", 23);
               cmd.Parameters.AddWithValue("@ddate", f1.bunifuMaterialTextbox13.Text);
               cmd.Parameters.AddWithValue("@GRNDate", f1.bunifuMaterialTextbox24.Text);
               cmd.Parameters.AddWithValue("@amountpayable", 22);
               cmd.Parameters.AddWithValue("@grnid", f1.bunifuMaterialTextbox17.Text);
               cmd.Parameters.AddWithValue("@cdate", f1.bunifuMaterialTextbox24.Text);
               cmd.ExecuteNonQuery();
           }
           catch (Exception e)
           {
               System.Windows.Forms.MessageBox.Show("Please fill all values");
           }

           OleDbCommand cmd1 = new OleDbCommand("Update PO set status = @status where poid = '" + f1.bunifuDropdown5.selectedValue + "'", con1.oleDbConnection1);

           cmd1.Parameters.AddWithValue("@status", "close");

           cmd1.ExecuteNonQuery();
           con1.oleDbConnection1.Close();
       }
       public void inactiveButton() {
           f1.button3.Enabled = false;
           f1.button4.Enabled = false;
           f1.button5.Enabled = false;
           f1.button6.Enabled = false;
           f1.button7.Enabled = false;
           f1.button8.Enabled = false;
           f1.button9.Enabled = false;
           f1.button10.Enabled = false;
           
       
       }
       public void activeButton() { 
           f1.button3.Enabled = true;
           f1.button4.Enabled = true;
           f1.button5.Enabled = true;
           f1.button6.Enabled = true;
           f1.button7.Enabled = true;
           f1.button8.Enabled = true;
           f1.button9.Enabled = true;
           f1.button10.Enabled = true;
       }
       public void clearControl() {
           f1.bunifuMaterialTextbox3.Text = "";
           f1.bunifuMaterialTextbox4.Text = "";
           f1.bunifuMaterialTextbox5.Text = "";
           f1.bunifuMaterialTextbox6.Text = "";
           f1.bunifuMaterialTextbox7.Text = "";
           f1.bunifuMaterialTextbox8.Text = "";
           f1.bunifuMaterialTextbox9.Text = "";
           f1.bunifuMaterialTextbox10.Text = "";
       }

        /// <summary>
        /// Sales Cycle
        /// </summary>




      
       public void SOCombo1()
       {
           con1.oleDbConnection1.Open();
           OleDbCommand cmd = new OleDbCommand("select * from customer", con1.oleDbConnection1);
           OleDbDataReader dr = cmd.ExecuteReader();
           while (dr.Read())
               f1.comboBox5.Items.Add(dr["CG"].ToString());
           con1.oleDbConnection1.Close();
       }
       public void SOID()
       {
           con1.oleDbConnection1.Open();
           OleDbCommand cmd1 = new OleDbCommand("select count(CID) from customer", con1.oleDbConnection1);
           OleDbDataReader dr1 = cmd1.ExecuteReader();
           if (dr1.Read())
           {
               CID = Convert.ToInt32(dr1[0]);
               CID++;
           }
           f1.textBox11.Text = f1.comboBox5.Text + CID + "-" + System.DateTime.Today.Year;
           con1.oleDbConnection1.Close();
       }
       public void SOCombo2()
       {
           con1.oleDbConnection1.Open();
           OleDbCommand cmd = new OleDbCommand("select * from customer where CG= '" + f1.comboBox5.Text + "'", con1.oleDbConnection1);
           OleDbDataReader dr = cmd.ExecuteReader();
           while (dr.Read())
               f1.comboBox6.Items.Add(dr["CID"].ToString());
           con1.oleDbConnection1.Close();

       }
       public void SOVendorCombo()
       {
           con1.oleDbConnection1.Open();
           OleDbCommand cmd = new OleDbCommand("select * from customer where CID= '" + f1.comboBox6.Text + "'", con1.oleDbConnection1);
           OleDbDataReader dr = cmd.ExecuteReader();
           while (dr.Read())
           {
               f1.textBox14.Text = dr["CName"].ToString();
               f1.textBox13.Text = dr["CP"].ToString();
               f1.textBox12.Text = dr["PH1"].ToString();

           }
           con1.oleDbConnection1.Close();

       }
       public void SOcombo3PM()
       {           //combo 3 for product model and it populated at combo 2

           con1.oleDbConnection1.Open();
           OleDbCommand cmd = new OleDbCommand("select * from Products", con1.oleDbConnection1);
           OleDbDataReader dr = cmd.ExecuteReader();
           while (dr.Read())
               f1.comboBox7.Items.Add(dr["pname"].ToString());
           con1.oleDbConnection1.Close();
       }

       //ye combo3 k selected index k upar lage ga
       public void SOCombo3selected()
       {
           con1.oleDbConnection1.Open();
           OleDbCommand cmd = new OleDbCommand("select * from products where pname= '" + f1.comboBox7.Text + "'", con1.oleDbConnection1);
           OleDbDataReader dr = cmd.ExecuteReader();
           while (dr.Read())
           {
               f1.textBox16.Text = dr["price"].ToString();
               f1.textBox17.Text = dr["pname"].ToString();
           }
           OleDbCommand cmd1 = new OleDbCommand("select count(ID) from SO", con1.oleDbConnection1);
           OleDbDataReader dr1 = cmd1.ExecuteReader();
           if (dr1.Read())
           {
               CID = Convert.ToInt32(dr1[0]); CID++;
           }
           f1.textBox17.Text = "P-" + CID;

           con1.oleDbConnection1.Close();

       }
       //product count its mean how different product user inserted
       public void SoOrderCounter()
       {
           try
           {
               int price = Convert.ToInt32(f1.textBox16.Text) * Convert.ToInt32(f1.textBox15.Text);
               con1.oleDbConnection1.Open();
               OleDbCommand cmd = new OleDbCommand("insert into SO(ID,RDATE,Status,cdept,cname,cid,CPerson,cpph,TotalAmount,pname,price,pquantity) values(@ID,@RDATE,@Status,@cdept,@cname,@cid,@CPerson,@cpph,@TotalAmount,@pname,@price,@pquantity)", con1.oleDbConnection1);
               cmd.Parameters.AddWithValue("@ID", f1.textBox17.Text);
               cmd.Parameters.AddWithValue("@RDATE", f1.dateTimePicker3.Text);
               cmd.Parameters.AddWithValue("@Status", "close");
               cmd.Parameters.AddWithValue("@cdept", f1.comboBox5.Text);
               cmd.Parameters.AddWithValue("@cname", f1.textBox14.Text);
               cmd.Parameters.AddWithValue("@cid", f1.comboBox6.Text);
               cmd.Parameters.AddWithValue("@CPerson", f1.textBox13.Text);
               cmd.Parameters.AddWithValue("@CPPH", f1.textBox12.Text);
               cmd.Parameters.AddWithValue("@TotalAmount", price.ToString());
               cmd.Parameters.AddWithValue("@pname", f1.comboBox7.Text);
               cmd.Parameters.AddWithValue("@price", f1.textBox16.Text);
               cmd.Parameters.AddWithValue("@pquantity", f1.textBox15.Text);


               cmd.ExecuteNonQuery();
           }
           catch (Exception e)
           {
               System.Windows.Forms.MessageBox.Show("Please fill all values");
           }
           con1.oleDbConnection1.Close();

           /*
           pModel[poCounter] = f1.comboBox3.Text;
           pName[poCounter] = f1.textBox7.Text;
           pQty[poCounter] = Convert.ToInt32(f1.textBox5.Text);
           pPrice[poCounter] = Convert.ToInt32(f1.textBox6.Text) * pQty[poCounter];
           
           poCounter++;
       */
          }
       
       //DELIVERY CHALLAN


       public void DCCombo()
       {
           con1.oleDbConnection1.Open();
           OleDbCommand cmd = new OleDbCommand("select * from sO ", con1.oleDbConnection1);
           OleDbDataReader dr = cmd.ExecuteReader();
           while (dr.Read())
           {
               f1.bunifuDropdown6.AddItem(dr["ID"].ToString());
           }

           OleDbCommand cmd1 = new OleDbCommand("select count(ID) from SO", con1.oleDbConnection1);
           OleDbDataReader dr1 = cmd1.ExecuteReader();
           if (dr1.Read())
           {
               CID = Convert.ToInt32(dr1[0]);
               CID++;
           }
           f1.bunifuMaterialTextbox34.Text = "SO-" + CID + "-" + System.DateTime.Today.Year;

           con1.oleDbConnection1.Close();

       }
       public void SOComboSelected()
       {
           con1.oleDbConnection1.Open();
           OleDbCommand cmd = new OleDbCommand("select * from sO where id='" + f1.bunifuDropdown6.selectedValue + "'", con1.oleDbConnection1);
           OleDbDataReader dr = cmd.ExecuteReader();
           while (dr.Read())
           {
               f1.bunifuMaterialTextbox14.Text = dr["CNAME"].ToString();
               f1.bunifuMaterialTextbox31.Text = dr["RDATE"].ToString();
               f1.bunifuMaterialTextbox32.Text = dr["pname"].ToString();
               f1.bunifuMaterialTextbox33.Text = dr["price"].ToString();
               f1.bunifuMaterialTextbox29.Text = dr["Cid"].ToString();
               f1.bunifuMaterialTextbox30.Text = dr["Cname"].ToString();
            //   f1.bunifuMaterialTextbox14.Text = dr["status"].ToString();
               f1.bunifuMaterialTextbox28.Text = dr["TotalAmount"].ToString();
               f1.bunifuMaterialTextbox35.Text = dr["cdept"].ToString();
               f1.bunifuMaterialTextbox36.Text = dr["cperson"].ToString();
               f1.bunifuMaterialTextbox37.Text = dr["cpph"].ToString();

           }
           con1.oleDbConnection1.Close();
       }
       public void SOcreateDC()
       {
           con1.oleDbConnection1.Open();
           try
           {
               OleDbCommand cmd = new OleDbCommand("insert into Dc(id,status,cname,rdate,sdDate,totalAmount) values (@ID,@status,@cname,@rdate,@sdDate,@totalAmount)", con1.oleDbConnection1);
               cmd.Parameters.AddWithValue("@id", f1.bunifuMaterialTextbox34.Text);
               cmd.Parameters.AddWithValue("@status", "close");
               cmd.Parameters.AddWithValue("@cname", f1.bunifuMaterialTextbox30.Text);
               cmd.Parameters.AddWithValue("@rdate", f1.bunifuMaterialTextbox28.Text);
               cmd.Parameters.AddWithValue("@sdDate", f1.dateTimePicker4);
               cmd.Parameters.AddWithValue("@totalAmount", f1.bunifuMaterialTextbox28.Text);
               cmd.ExecuteNonQuery();
           }
           catch (Exception e)
           {
               System.Windows.Forms.MessageBox.Show("Please fill all values");
           }
           con1.oleDbConnection1.Close();
       }


       public void invoiceDropdown() {

           con1.oleDbConnection1.Open();
           OleDbCommand cmd0 = new OleDbCommand("select * from dc", con1.oleDbConnection1);
           OleDbDataReader dr0 = cmd0.ExecuteReader();
           while(dr0.Read()){
               f1.bunifuDropdown7.AddItem(dr0["cname"].ToString());
              
           }

           con1.oleDbConnection1.Close();
       }


       public void invoiceId() {

           con1.oleDbConnection1.Open();

       OleDbCommand cmd1 = new OleDbCommand("select count(id) from invoiceso", con1.oleDbConnection1);
               OleDbDataReader dr1 = cmd1.ExecuteReader();
               if (dr1.Read())
               {
                   CID = Convert.ToInt32(dr1[0]);
                   CID++;
               }
               f1.bunifuMaterialTextbox46.Text = "IV00-" + CID + "-" + System.DateTime.Today.Year;

           
           con1.oleDbConnection1.Close();
    
    }
       public void invoiceDropdown0() {
           con1.oleDbConnection1.Open();
           OleDbCommand cmd = new OleDbCommand("select * from customer where cname='"+f1.bunifuDropdown7.selectedValue+"'", con1.oleDbConnection1);
           OleDbDataReader dr = cmd.ExecuteReader();
           while (dr.Read())
           {
               f1.bunifuMaterialTextbox45.Text = dr["cID"].ToString();
               f1.bunifuMaterialTextbox44.Text = dr["cname"].ToString();
               f1.bunifuMaterialTextbox43.Text = dr["cp"].ToString();
               f1.bunifuMaterialTextbox42.Text = dr["cpph"].ToString();
           }

           OleDbCommand cmd0 = new OleDbCommand("select * from dc where cname='" + f1.bunifuDropdown7.selectedValue + "'", con1.oleDbConnection1);
           OleDbDataReader dr0 = cmd0.ExecuteReader();
           while (dr0.Read()){

           f1.bunifuMaterialTextbox38.Text = dr0["sddate"].ToString();
           f1.bunifuMaterialTextbox40.Text = dr0["TotalAmount"].ToString();
           
       }
           OleDbCommand cmd1 = new OleDbCommand("select * from so  where cname='" + f1.bunifuDropdown7.selectedValue + "'", con1.oleDbConnection1);
           OleDbDataReader dr1 = cmd1.ExecuteReader();
           while (dr1.Read())
           {

               f1.bunifuMaterialTextbox41.Text = dr1["pquantity"].ToString();
               f1.bunifuMaterialTextbox39.Text = dr1["pname"].ToString();

           }
           con1.oleDbConnection1.Close();
       }

       public void SoinoviceInsert()
       {
           con1.oleDbConnection1.Open();
           try
           {
               OleDbCommand cmd = new OleDbCommand("insert into invoiceso(cID,cName,rdate,sdDate,AmountReceiveable,PModel,PQuantity,sdnid) values (@cID,@cName,@rdate,@sdDate,@AmountReceiveable,@PModel,@PQuantity,@sdnid)", con1.oleDbConnection1);
               cmd.Parameters.AddWithValue("@cid", f1.bunifuMaterialTextbox45.Text);
               cmd.Parameters.AddWithValue("@cname", f1.bunifuMaterialTextbox44.Text);
               cmd.Parameters.AddWithValue("@rdate", f1.bunifuDatepicker2.ToString());
               cmd.Parameters.AddWithValue("@sddate", f1.bunifuMaterialTextbox38.Text);
               cmd.Parameters.AddWithValue("@AmountReceiveable", f1.bunifuMaterialTextbox40.Text);
               cmd.Parameters.AddWithValue("@PModel", f1.bunifuMaterialTextbox39.Text);
               cmd.Parameters.AddWithValue("@PQuantity", f1.bunifuMaterialTextbox41.Text);
               cmd.Parameters.AddWithValue("@sdnid", f1.bunifuMaterialTextbox46.Text);
               cmd.ExecuteNonQuery();
           }
           catch (Exception e)
           {
               System.Windows.Forms.MessageBox.Show("Please fill all values");
           }
           con1.oleDbConnection1.Close();
       }

    }
}
