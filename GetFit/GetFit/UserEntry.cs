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
    public partial class UserEntry : Form
    {
        SqlConnection scon = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Dibya\Documents\Visual Studio 2010\Projects\GetFit\GetFit\GymSystem.mdf;Integrated Security=True;User Instance=True");
        SqlCommand cmd = new SqlCommand();
        DataTable dt;
        SqlDataAdapter da;
        string msg = "Must Fill : ";
        string mobCheck = "";
        string mailCheck = "";
        string passCheck = "";
        public UserEntry()
        {
            InitializeComponent();
            
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
        private void button_submit_Click(object sender, EventArgs e)
        {
            if (isEntryValid())
            {
                try
                {
                    scon.Open();
                    cmd.Connection = scon;
                    cmd.CommandType = CommandType.Text;
                    string query= "select * from userentry where email='" + email.Text + "'";
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    da = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    da.Fill(dt);
                    int count = dt.Rows.Count;
                    if (count == 0)
                    {
                        cmd.CommandText = "insert into userentry values('" + fname.Text + "','" + lname.Text + "','" + email.Text + "','" + mobile.Text + "','" + address.Text + "','" + dateTimePicker.Text + "','" + radioButtonText() + "','" + comboBox_entryas.Text + "','" + confirmpassword.Text + "')";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("You have registered Sucessfully", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        MessageBox.Show("Mail id is already registered", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }
                    cmd.Clone();
                    scon.Close();
                }
                catch (Exception ex)
                { MessageBox.Show("Error\n" +ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
               
            }
            else
            {
                bool bo=true;
                if (msg != "Must Fill : ")
                {
                    bo = false;
                    MessageBox.Show(msg, "Field Value required",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    
                   
                }
                if (bo && mailCheck != "")
                {
                    bo = false;
                    MessageBox.Show("Error\n" +mailCheck, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  
                }
                if(bo && mobCheck!="")
                {
                    bo = false;
                    MessageBox.Show("Error\n" + mobCheck, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (bo && passCheck != "")
                {
                    bo = false;
                    MessageBox.Show("Error\n" + passCheck, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
            msg = "Must Fill : ";
            mailCheck = "";
            mobCheck = "";
            passCheck = "";

            
        }

        private void fname_MouseClick(object sender, MouseEventArgs e)
        {
            if (fname.Text == "First Name") fname.Text = "";
            if (lname.Text == "") lname.Text = "Last Name";
            if (email.Text == "") email.Text = "Email";
            if (mobile.Text == "") mobile.Text = "Mobile";
            if (address.Text == "") address.Text = "Address";
            if (createpassword.Text == "") createpassword.Text = "Create Password";
            if (confirmpassword.Text == "") confirmpassword.Text = "Confirm Password";

        }

        private void lname_TextChanged(object sender, EventArgs e)
        {

        }


        private bool isEntryValid()
        {
            bool b = false;
            if (fname.Text == "First Name" || fname.Text == "") msg += "First Name\n";
            if (lname.Text == "" || lname.Text == "Last Name") msg += "Lirst Name\n";
            if (email.Text == "" || email.Text == "Email") msg += "Email\n";
            if (mobile.Text == "" || mobile.Text == "Mobile") msg += "Mobile\n";
            if (address.Text == "" || address.Text == "Address") msg += "Address\n";
            if (!radioButton_male.Checked && !radioButton_female.Checked) msg += "Gender\n";
            if (comboBox_entryas.Text == "") msg += "Entryas\n";
            if (createpassword.Text == "" || createpassword.Text == "Create Password") msg += "Password\n";
            if (confirmpassword.Text == "" || confirmpassword.Text == "Confirm Password") msg += "Confirm Password\n";

            // Mail Checking//
            string s = email.Text;
            if ((s.Length - s.LastIndexOf(".com")) != 4 || s.LastIndexOf('@') == -1 || s.IndexOf('@') == 0 || (s.IndexOf('@') - s.LastIndexOf('@')) != 0) 
            {
                mailCheck = "Please put Correct Email id !";
            }

            //Mobile number checking//
            string mob = mobile.Text;
            if (mob.Length != 10)
            {
                mobCheck = "Please put Correct Mobile Number !";
            }
            else
            {
                try { long n = long.Parse(mob); }
                catch(FormatException fe){ mobCheck = "Please put Correct Mobile Number !";}
            }

            //password Checking///
            string p = createpassword.Text;
            string q = confirmpassword.Text;
            if (!p.Equals(q)) passCheck = "confirmd password must be same as password";


            if(msg == "Must Fill : " && mailCheck=="" && mobCheck=="" && passCheck=="") b=true;
            return b;
        }
        private void lname_MouseClick(object sender, MouseEventArgs e)
        {
            if (lname.Text == "Last Name") lname.Text = "";
            if (fname.Text == "") fname.Text = "First Name";
            if (email.Text == "") email.Text = "Email";
            if (mobile.Text == "") mobile.Text = "Mobile";
            if (address.Text == "") address.Text = "Address";
            if (createpassword.Text == "") createpassword.Text = "Create Password";
            if (confirmpassword.Text == "") confirmpassword.Text = "Confirm Password";
            

        }

        private void email_MouseClick(object sender, MouseEventArgs e)
        {
            if (fname.Text == "") fname.Text = "First Name";
            if (lname.Text == "") lname.Text = "Last Name";
            if (email.Text == "Email") email.Text = "";
            if (mobile.Text == "") mobile.Text = "Mobile";
            if (address.Text == "") address.Text = "Address";
            if (createpassword.Text == "") createpassword.Text = "Create Password";
            if (confirmpassword.Text == "") confirmpassword.Text = "Confirm Password";
        }

        private void mobile_MouseClick(object sender, MouseEventArgs e)
        {
            if (fname.Text == "") fname.Text = "First Name";
            if (lname.Text == "") lname.Text = "Last Name";
            if (email.Text == "") email.Text = "Email";
            if (mobile.Text == "Mobile") mobile.Text = "";
            if (address.Text == "") address.Text = "Address";
            if (createpassword.Text == "") createpassword.Text = "Create Password";
            if (confirmpassword.Text == "") confirmpassword.Text = "Confirm Password";

        }

        private void address_MouseClick(object sender, MouseEventArgs e)
        {
            if (fname.Text == "") fname.Text = "First Name";
            if (lname.Text == "") lname.Text = "Last Name";
            if (email.Text == "") email.Text = "Email";
            if (mobile.Text == "") mobile.Text = "Mobile";
            if (address.Text == "Address") address.Text = "";
            if (createpassword.Text == "") createpassword.Text = "Create Password";
            if (confirmpassword.Text == "") confirmpassword.Text = "Confirm Password";
        }

        private void createpassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (fname.Text == "") fname.Text = "First Name";
            if (lname.Text == "") lname.Text = "Last Name";
            if (email.Text == "") email.Text = "Email";
            if (mobile.Text == "") mobile.Text = "Mobile";
            if (address.Text == "") address.Text = "Address";
            if (createpassword.Text == "Create Password") createpassword.Text = "";
            if (confirmpassword.Text == "") confirmpassword.Text = "Confirm Password";

        }

        private void confirmpassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (fname.Text == "") fname.Text = "First Name";
            if (lname.Text == "") lname.Text = "Last Name";
            if (email.Text == "") email.Text = "Email";
            if (mobile.Text == "") mobile.Text = "Mobile";
            if (address.Text == "") address.Text = "Address";
            if (createpassword.Text == "") createpassword.Text = "Create Password";
            if (confirmpassword.Text == "Confirm Password") confirmpassword.Text = "";

        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            fname.Text = "First Name";
            lname.Text = "Last Name";
            email.Text = "Email";
            mobile.Text = "Mobile";
            address.Text = "Address";
            comboBox_entryas.Text = "";
            radioButton_male.Checked=false;
            radioButton_female.Checked = false;
            createpassword.Text = "Create Password";
            confirmpassword.Text = "Confirm Password";
            DateTime today = DateTime.Today;
            dateTimePicker.Text = today.ToString("dd/MM/yyyy");
        }

       

       

    }
}
