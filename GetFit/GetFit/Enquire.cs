using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GetFit
{
    public partial class Enquire : Form
    {
        SqlConnection scon = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Dibya\Documents\Visual Studio 2010\Projects\GetFit\GetFit\GymSystem.mdf;Integrated Security=True;User Instance=True");
        //SqlConnection scon = new SqlConnection(@"Data Source=C:\Users\Dibya\documents\visual studio 2010\Projects\GetFit\GetFit\GymSystem.sdf");
        SqlCommand cmd = new SqlCommand();
        SqlCommandBuilder scb;
        DataTable dt;
        SqlDataAdapter da;
        //string quString1= "select fname as 'First Name',lname as 'Last Name',email as 'Email',mobile as 'Mobile',address as 'Address',dob as 'Date of Birth',gender as 'Gender',entryas as 'Entry As' from userentry";
        string quString = "select fname,lname,email,mobile,address,dob,gender,entryas from userentry";
        string query=""; 
        string queryDel = "delete from userentry";
        bool isNotFill = true;
        int search = 1;
        int delete = 2;
        public Enquire()
        {
            InitializeComponent();
            query = quString; 
        }

        private void comboBox_entryas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Enquire_Load(object sender, EventArgs e)
        {
           
            
           this.userentryTableAdapter.Fill(this.gymSystemDataSet.userentry);

        }

       
        private void displayData(string query,int n)
        {
            try
            {
            scon.Open();
            cmd.Connection = scon;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            int count;
            if (n == 1)
            {
               
               cmd.ExecuteNonQuery(); 
                da = new SqlDataAdapter(cmd);
                dt=new DataTable();
                da.Fill(dt);  
                count = dt.Rows.Count;
                dataGridView1.DataSource = dt;
            
                if (count == 0 || count == 1) MessageBox.Show(count.ToString() + " Record is Found.", "Record Found",
                      MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                else
                    MessageBox.Show(count.ToString() + " Records Are Found.", "Record Found",
                       MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            if (n == 2)
            {
                
                cmd.ExecuteNonQuery(); 
                
                 da = new SqlDataAdapter(cmd);
                 dt = new DataTable();
                da.Fill(dt);
                count = dt.Rows.Count;
                dataGridView1.DataSource = dt;

                if (count == 0 ) MessageBox.Show(" 0 Record is Found.", "information",
                      MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (count == 1)
                {
                   DialogResult result= MessageBox.Show("1 Record is Found. Do you want to Delete the record?", "Record Found",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                   if (result == DialogResult.Yes)
                   {
                       cmd.CommandText = buildQuery(queryDel);
                       MessageBox.Show(cmd.CommandText);
                       cmd.ExecuteNonQuery();
                       da = new SqlDataAdapter(cmd);
                       dt = new DataTable();
                       da.Fill(dt);
                       dataGridView1.DataSource = dt;
                       MessageBox.Show("The Record has Deleted Sucessfully.", "information",
                       MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                   }
                   if (result == DialogResult.No) { ; }
                }
                if (count > 1) 
                {

                    DialogResult result = MessageBox.Show(count.ToString() + " Records Are Found.Pressing OK , all Records of Same Attribute will be Deleted. Do you want to Delete the records?", "Record Found",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (result == DialogResult.Yes)
                    {
                        cmd.CommandText = buildQuery(queryDel);
                      
                        cmd.ExecuteNonQuery();
                        dt = new DataTable();
                        da = new SqlDataAdapter(cmd);
                        dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                        MessageBox.Show("The Records are Deleted Sucessfully.", "information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    if (result == DialogResult.No) { ; }
                }
            }
         
            cmd.Clone();
            scon.Close();
           }
          catch (Exception ex) { MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private string radioButtonText()
        {
            if (radioButton_male.Checked)
            {
                return radioButton_male.Text;
            }
            else
            {
                return radioButton_female.Text;
            }
        }
        private string buildQuery(string q)
        {
            isNotFill = true;
            string que = q+" where ";
            string[] qu = new string[6];
            int ctr = -1;
            DateTime today = DateTime.Today;
         

            if (!(email.Text == "" || email.Text == "Email"))
            {
                isNotFill = false;
                que += "email='" + email.Text + "'";
            }
            else
            {
                if (!(fname.Text == "First Name" || fname.Text == ""))
                {
                    isNotFill = false;
                    ctr++;
                    qu[ctr] = "fname='" + fname.Text + "'";

                }
                if (!(lname.Text == "" || lname.Text == "Last Name"))
                {
                    isNotFill = false;
                    ctr++;
                    qu[ctr] = "lname='" + lname.Text + "'";
                }
                if (!(mobile.Text == "" || mobile.Text == "Mobile"))
                {
                    isNotFill = false;
                    ctr++;
                    qu[ctr] = "mobile='" + mobile.Text + "'";
                }
                if (dateTimePicker.Text != today.ToString("dd/MM/yyyy"))
                {
                    isNotFill = false;
                    ctr++;
                    qu[ctr] = "dob='" + dateTimePicker.Text + "'";
                }

                if (radioButton_male.Checked || radioButton_female.Checked)
                {
                    isNotFill = false;
                    ctr++;
                    qu[ctr] = "gender='" + radioButtonText() + "'";

                }
                if (comboBox_entryas.Text != "")
                {
                    isNotFill = false;
                    ctr++;
                    qu[ctr] = "entryas='" + comboBox_entryas.Text + "'";
                }
                if (ctr == 0) que += qu[0];
                if (ctr > 0)
                {
                    que += qu[0];
                    for (int i = 1; i < 5; i++)
                    {
                        if (qu[i] != null) que += " and " + qu[i];
                    }

                }


            }
            if (isNotFill) return q;
            else  return que;
        }

        private void button_showalldata_Click(object sender, EventArgs e)
        {
           
            displayData(query, search);
            
        }

        private void button_search_Click(object sender, EventArgs e)
        {
         
            query = buildQuery(query);
            if (isNotFill)
            {
                MessageBox.Show("Atleast One Field Value Required", "Field Value required",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
   
   
    
            }
            else
            {
                displayData(query,search);
                query = quString;
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
           
            query = buildQuery(query);
           

            if (isNotFill)
            {
                MessageBox.Show("Atleast One Field Value Required", "Field Value required",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

            }
            else
            {
                displayData(query, delete);
                query = quString;
                queryDel = "delete from userentry";
            }
        }
        private void fname_MouseClick(object sender, MouseEventArgs e)
        {
            if (fname.Text == "First Name") fname.Text = "";
            if (lname.Text == "") lname.Text = "Last Name";
            if (email.Text == "") email.Text = "Email";
            if (mobile.Text == "") mobile.Text = "Mobile";

        }

        private void mobile_MouseClick(object sender, MouseEventArgs e)
        {
            if (fname.Text == "") fname.Text = "First Name";
            if (lname.Text == "") lname.Text = "Last Name";
            if (email.Text == "") email.Text = "Email";
            if (mobile.Text == "Mobile") mobile.Text = "";
        }

        private void email_MouseClick(object sender, MouseEventArgs e)
        {
            if (fname.Text == "") fname.Text = "First Name";
            if (lname.Text == "") lname.Text = "Last Name";
            if (email.Text == "Email") email.Text = "";
            if (mobile.Text == "") mobile.Text = "Mobile";
        }

        private void lname_MouseClick(object sender, MouseEventArgs e)
        {
            if (lname.Text == "Last Name") lname.Text = "";
            if (fname.Text == "") fname.Text = "First Name";
            if (email.Text == "") email.Text = "Email";
            if (mobile.Text == "") mobile.Text = "Mobile";
        }


        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (dt != null)
                {
                    scb = new SqlCommandBuilder(da);
                    da.Update(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show("Records Updated.", "information",
                      MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            query = quString;
            queryDel = "delete from userentry where ";
            fname.Text = "First Name";
            lname.Text = "Last Name";
            email.Text = "Email";
            mobile.Text = "Mobile";
            comboBox_entryas.Text = "";
            radioButton_male.Checked = false;
            radioButton_female.Checked = false;
            DateTime today = DateTime.Today;
            dateTimePicker.Text = today.ToString("dd/MM/yyyy");
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
          
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

       

      
    }
}
