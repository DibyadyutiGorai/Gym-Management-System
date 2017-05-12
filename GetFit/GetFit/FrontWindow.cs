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
    public partial class FrontWindow : Form
    {
        Enquire en = new Enquire();
        UserEntry ue = new UserEntry();
        Stocks st=new Stocks() ;
        StocksAdmin sta = new StocksAdmin();
        bool adminLoggedIn = false;
        public FrontWindow()
        {
           
            InitializeComponent();
           
        }


        private void FrontWindow_Load(object sender, EventArgs e)
        {
            
        }
       

      

        private void button_login_Click(object sender, EventArgs e)
        {
            bool isFill = true;
            if (comboBox_loginas.Text == "") isFill = false;
            if (email_or_id.Text == " Email" || email_or_id.Text == "") isFill = false;
            if (login_password.Text == " Password" || login_password.Text == "") isFill = false;
            if (isFill)
            {
                if (comboBox_loginas.Text == "Stuff")
                {
                    try
                    {
                       
                        SqlConnection scon = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Dibya\Documents\Visual Studio 2010\Projects\GetFit\GetFit\GymSystem.mdf;Integrated Security=True;User Instance=True");
                        SqlCommand cmd = new SqlCommand();
                        SqlDataAdapter da;
                        DataTable dt;
                        scon.Open();
                        cmd.Connection = scon;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "select * from userentry where email='" + email_or_id.Text + "' and password='" + login_password.Text + "'";
                        cmd.ExecuteNonQuery();
                    
                   
                        da = new SqlDataAdapter(cmd);
                        dt = new DataTable();
                        da.Fill(dt);
                        int count = dt.Rows.Count;
                        if (count == 1)
                        {
                            this.Controls.Remove(this.panel_login);
                            this.Controls.Remove(this.label_fit);
                            this.Controls.Remove(this.label_get);
                            this.Controls.Add(this.panel_button);
                            this.BackgroundImage = global::GetFit.Properties.Resources.B;
                            this.Controls.Add(ue.panel_userEn);
                           
                        }
                        else
                        {
                            MessageBox.Show("Error : Wrong Email or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    catch (Exception ex) { MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else
                {
                    if (email_or_id.Text == "abc@gmail.com" && login_password.Text == "dibyaAdmin1234")
                    {

                        adminLoggedIn = true;
                        this.Controls.Remove(this.panel_login);
                        this.Controls.Remove(this.label_fit);
                        this.Controls.Remove(this.label_get);
                        this.Controls.Add(this.panel_button);
                        this.BackgroundImage = global::GetFit.Properties.Resources.B;
                        this.Controls.Add(ue.panel_userEn);
                    }
                    else
                    {
                        MessageBox.Show("Error : Wrong Id or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
               
                MessageBox.Show("All Field Value Required", "Field Value required",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            //activateEvents();
            
        }

        

    
        private void email_or_id_MouseClick(object sender, MouseEventArgs e)
        {
            if (email_or_id.Text == " Email") email_or_id.Text = "";

            if (login_password.Text == "") login_password.Text =" Password";
        }

        private void login_password_MouseClick(object sender, MouseEventArgs e)
        {
            if (email_or_id.Text == "") email_or_id.Text = " Email";

            if (login_password.Text == " Password") login_password.Text ="" ;
        }

        private void button_help_Click(object sender, EventArgs e)
        {
            email_or_id.Text = " Email";
            login_password.Text = " Password";
            comboBox_loginas.Text = "";
        }

        private void userentry_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(en.panel_userEn);
            this.Controls.Remove(sta.panel_userEn);
            this.Controls.Remove(st.panel_userEn);
            this.Controls.Add(ue.panel_userEn);
                       

        }

        private void enquire_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(ue.panel_userEn);
            this.Controls.Remove(sta.panel_userEn);
            this.Controls.Remove(st.panel_userEn);
            this.Controls.Add(en.panel_userEn);
                       
        }

        private void button_stocks_Click(object sender, EventArgs e)
        {
     
        
          
            this.Controls.Remove(ue.panel_userEn);
            this.Controls.Remove(en.panel_userEn);
            if (adminLoggedIn) this.Controls.Add(sta.panel_userEn);
            else this.Controls.Add(st.panel_userEn);
            
        }

        private void button_payment_Click(object sender, EventArgs e)
        {

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(ue.panel_userEn);
            this.Controls.Remove(en.panel_userEn);
            this.Controls.Remove(sta.panel_userEn);
            this.Controls.Remove(st.panel_userEn);
            this.Controls.Remove(this.panel_button);
            this.BackgroundImage = global::GetFit.Properties.Resources.A;
            this.Controls.Add(this.panel_login);
            this.Controls.Add(this.label_fit);
            this.Controls.Add(this.label_get);
            email_or_id.Text = " Email";
            login_password.Text = " Password";
            comboBox_loginas.Text = "";
        }

    }
}
