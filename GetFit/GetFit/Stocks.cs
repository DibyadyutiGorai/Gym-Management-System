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

    public partial class Stocks : Form
    {
        SqlConnection scon = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Dibya\Documents\Visual Studio 2010\Projects\GetFit\GetFit\GymSystem.mdf;Integrated Security=True;User Instance=True");
        SqlCommand cmd = new SqlCommand();
        
        DataTable dt;
        SqlDataAdapter da;
        string msg = "Must Fill : ";
        string quString = "select * from stocks";
        string query = "";
        string queryDel = "delete from stocks";
        bool isNotFill = true;
        int search = 1;
        int delete = 2;
        int insert = 3;
        DateTime today = DateTime.Today;
        Admin a;
        public Stocks()
        {
           
            InitializeComponent();
            query = quString; 
        }
        
        private void displayData(string query, int n)
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
                    dt = new DataTable();
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

                    if (count == 0) MessageBox.Show(" 0 Record is Found.", "information",
                         MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    if (count == 1)
                    {
                        DialogResult result = MessageBox.Show("1 Record is Found. Do you want to Delete the record?", "Record Found",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        if (result == DialogResult.Yes)
                        {
                            cmd.CommandText = buildQuery(queryDel);
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
                if (n == 3)
                {

                    cmd.ExecuteNonQuery();
                    da = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    da.Fill(dt);
                    count = dt.Rows.Count;
                    dataGridView1.DataSource = dt;
                }

                cmd.Clone();
                scon.Close();
            }
            catch (Exception ex) { MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private string buildQuery(string q)
        {
            isNotFill = true;
            string que = q + " where ";
            string[] qu = new string[6];
            int ctr = -1;
            DateTime today = DateTime.Today;


            if (!(id.Text == "" || id.Text == "Product Id"))
            {
                isNotFill = false;
                que += "Id='" + id.Text + "'";
            }
            else
            {
                if (!(productname.Text == "Name" || productname.Text == ""))
                {
                    isNotFill = false;
                    ctr++;
                    qu[ctr] = "Name='" + productname.Text + "'";

                }
                if (comboBox_category.Text != "")
                {
                    isNotFill = false;
                    ctr++;
                    qu[ctr] = "Category='" + comboBox_category.Text + "'";
                }
             
                if (dateTimePicker.Text != today.ToString("dd/MM/yyyy"))
                {
                    isNotFill = false;
                    ctr++;
                    qu[ctr] = "Entry='" + dateTimePicker.Text + "'";
                }
                if (comboBox_placedin.Text != "")
                {
                    isNotFill = false;
                    ctr++;
                    qu[ctr] = "PlacedIn='" + comboBox_placedin.Text + "'";
                }

                if (!(makers.Text == "Makers Name" || makers.Text == ""))
                {
                    isNotFill = false;
                    ctr++;
                    qu[ctr] = "Makers='" + makers.Text + "'";

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
            else return que;
        }
     
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
           
        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void productname_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_MouseClick(object sender, MouseEventArgs e)
        {
            if (id.Text == "Product Id") id.Text = "";
            if (productname.Text == "") productname.Text = "Name";
            if (makers.Text == "") makers.Text = "Makers Name";
   
        }

        private void productname_MouseClick(object sender, MouseEventArgs e)
        {
            if (id.Text == "") id.Text = "Product Id";
            if (productname.Text == "Name") productname.Text = "";
            if (makers.Text == "") makers.Text = "Makers Name";
        }

        private void makers_MouseClick(object sender, MouseEventArgs e)
        {
            if (id.Text == "Product Id") id.Text = "Product Id";
            if (productname.Text == "") productname.Text = "Name";
            if (makers.Text == "Makers Name") makers.Text = "";
        }

        private void button_resetp_Click(object sender, EventArgs e)
        {
            id.Text = "Product Id";
            productname.Text = "Name";
            makers.Text = "Makers Name";
            comboBox_category.Text = "";
            comboBox_placedin.Text = "";
            DateTime today = DateTime.Today;
            dateTimePicker.Text = today.ToString("dd/MM/yyyy");
        }

        private void button_insertp_Click(object sender, EventArgs e)
        {

            MessageBox.Show("you are not allowed to insert", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private bool isEntryValid()
        {
            bool b = false;
            if (id.Text == "Product Id" || id.Text == "") msg += "Product id\n";
            if (productname.Text == "" || productname.Text == "Name") msg += "Name\n";
            if (makers.Text == "" || makers.Text == "Makers Name") msg += "Makers Name\n";
            if (comboBox_category.Text == "") msg += "Category\n";
            if (comboBox_placedin.Text == "") msg += "Placed in\n";
            if (msg == "Must Fill : ") b = true;
            return b;
        }

        private void panel_userEn_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Stocks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.stocks' table. You can move, or remove it, as needed.
            this.stocksTableAdapter.Fill(this.database1DataSet1.stocks);
            
        }

        private void button_searchp_Click(object sender, EventArgs e)
        {
            
                query = buildQuery(query);
                if (isNotFill)
                {
                    MessageBox.Show("Atleast One Field Value Required", "Field Value required",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);



                }
                else
                {
                    displayData(query, search);
                    query = quString;
                }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_updatep_Click(object sender, EventArgs e)
        {
            
             
                    MessageBox.Show("you are not allowed to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            
        }

        private void button_viewall_Click(object sender, EventArgs e)
        {
           
            displayData(query, search);
        
        }

        private void button_deletep_Click(object sender, EventArgs e)
        {

            MessageBox.Show("you are not allowed to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void makers_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {

                string imgName = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Image img;
                img = Image.FromFile(@"C:\Users\Dibya\Documents\Visual Studio 2010\Projects\GetFit\GetFit\gymeq\" + imgName + ".JPG");
                pictureBox1.Image = img;
            }
            catch { MessageBox.Show("Image is Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
      
    }
}
