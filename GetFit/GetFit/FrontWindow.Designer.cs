namespace GetFit
{
    partial class FrontWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrontWindow));
            this.button_userentry = new System.Windows.Forms.Button();
            this.button_enquire = new System.Windows.Forms.Button();
            this.panel_login = new System.Windows.Forms.Panel();
            this.label_loginas = new System.Windows.Forms.Label();
            this.button_loginreset = new System.Windows.Forms.Button();
            this.comboBox_loginas = new System.Windows.Forms.ComboBox();
            this.button_login = new System.Windows.Forms.Button();
            this.login_password = new System.Windows.Forms.TextBox();
            this.email_or_id = new System.Windows.Forms.TextBox();
            this.label_get = new System.Windows.Forms.Label();
            this.label_fit = new System.Windows.Forms.Label();
            this.panel_button = new System.Windows.Forms.Panel();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_stocks = new System.Windows.Forms.Button();
            this.enquire = new System.Windows.Forms.Button();
            this.userentry = new System.Windows.Forms.Button();
            this.panel_login.SuspendLayout();
            this.panel_button.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_userentry
            // 
            this.button_userentry.BackColor = System.Drawing.Color.Tomato;
            this.button_userentry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_userentry.ForeColor = System.Drawing.Color.Black;
            this.button_userentry.Location = new System.Drawing.Point(33, 76);
            this.button_userentry.Name = "button_userentry";
            this.button_userentry.Size = new System.Drawing.Size(91, 71);
            this.button_userentry.TabIndex = 1;
            this.button_userentry.Text = "User Entry";
            this.button_userentry.UseVisualStyleBackColor = false;
            // 
            // button_enquire
            // 
            this.button_enquire.BackColor = System.Drawing.Color.YellowGreen;
            this.button_enquire.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_enquire.ForeColor = System.Drawing.Color.Black;
            this.button_enquire.Location = new System.Drawing.Point(33, 181);
            this.button_enquire.Name = "button_enquire";
            this.button_enquire.Size = new System.Drawing.Size(91, 71);
            this.button_enquire.TabIndex = 2;
            this.button_enquire.Text = "Enquire";
            this.button_enquire.UseVisualStyleBackColor = false;
            // 
            // panel_login
            // 
            this.panel_login.BackColor = System.Drawing.Color.Transparent;
            this.panel_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_login.BackgroundImage")));
            this.panel_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_login.Controls.Add(this.label_loginas);
            this.panel_login.Controls.Add(this.button_loginreset);
            this.panel_login.Controls.Add(this.comboBox_loginas);
            this.panel_login.Controls.Add(this.button_login);
            this.panel_login.Controls.Add(this.login_password);
            this.panel_login.Controls.Add(this.email_or_id);
            this.panel_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_login.Location = new System.Drawing.Point(717, 24);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(315, 239);
            this.panel_login.TabIndex = 9;
            // 
            // label_loginas
            // 
            this.label_loginas.AutoSize = true;
            this.label_loginas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_loginas.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label_loginas.Location = new System.Drawing.Point(20, 18);
            this.label_loginas.Name = "label_loginas";
            this.label_loginas.Size = new System.Drawing.Size(96, 25);
            this.label_loginas.TabIndex = 16;
            this.label_loginas.Text = "Login As";
            // 
            // button_loginreset
            // 
            this.button_loginreset.BackColor = System.Drawing.Color.Turquoise;
            this.button_loginreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_loginreset.Location = new System.Drawing.Point(159, 163);
            this.button_loginreset.Name = "button_loginreset";
            this.button_loginreset.Size = new System.Drawing.Size(126, 47);
            this.button_loginreset.TabIndex = 8;
            this.button_loginreset.Text = "Reset";
            this.button_loginreset.UseVisualStyleBackColor = false;
            this.button_loginreset.Click += new System.EventHandler(this.button_help_Click);
            // 
            // comboBox_loginas
            // 
            this.comboBox_loginas.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBox_loginas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_loginas.FormattingEnabled = true;
            this.comboBox_loginas.Items.AddRange(new object[] {
            "Stuff",
            "Admin"});
            this.comboBox_loginas.Location = new System.Drawing.Point(119, 18);
            this.comboBox_loginas.Name = "comboBox_loginas";
            this.comboBox_loginas.Size = new System.Drawing.Size(166, 28);
            this.comboBox_loginas.TabIndex = 15;
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.DarkOrange;
            this.button_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.Location = new System.Drawing.Point(25, 163);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(126, 47);
            this.button_login.TabIndex = 7;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // login_password
            // 
            this.login_password.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.login_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.login_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_password.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.login_password.Location = new System.Drawing.Point(25, 115);
            this.login_password.Multiline = true;
            this.login_password.Name = "login_password";
            this.login_password.Size = new System.Drawing.Size(260, 32);
            this.login_password.TabIndex = 7;
            this.login_password.Text = " Password";
            this.login_password.MouseClick += new System.Windows.Forms.MouseEventHandler(this.login_password_MouseClick);
            // 
            // email_or_id
            // 
            this.email_or_id.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.email_or_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email_or_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_or_id.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.email_or_id.Location = new System.Drawing.Point(25, 65);
            this.email_or_id.Multiline = true;
            this.email_or_id.Name = "email_or_id";
            this.email_or_id.Size = new System.Drawing.Size(260, 31);
            this.email_or_id.TabIndex = 4;
            this.email_or_id.Text = " Email";
            this.email_or_id.MouseClick += new System.Windows.Forms.MouseEventHandler(this.email_or_id_MouseClick);
            // 
            // label_get
            // 
            this.label_get.AutoSize = true;
            this.label_get.BackColor = System.Drawing.Color.Transparent;
            this.label_get.Font = new System.Drawing.Font("Microsoft YaHei UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_get.Location = new System.Drawing.Point(344, 433);
            this.label_get.Name = "label_get";
            this.label_get.Size = new System.Drawing.Size(250, 122);
            this.label_get.TabIndex = 10;
            this.label_get.Text = "Get ";
            // 
            // label_fit
            // 
            this.label_fit.AutoSize = true;
            this.label_fit.BackColor = System.Drawing.Color.Transparent;
            this.label_fit.Font = new System.Drawing.Font("Microsoft YaHei UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fit.ForeColor = System.Drawing.Color.White;
            this.label_fit.Location = new System.Drawing.Point(535, 433);
            this.label_fit.Name = "label_fit";
            this.label_fit.Size = new System.Drawing.Size(174, 122);
            this.label_fit.TabIndex = 11;
            this.label_fit.Text = "Fit";
            // 
            // panel_button
            // 
            this.panel_button.BackColor = System.Drawing.Color.Transparent;
            this.panel_button.Controls.Add(this.button_exit);
            this.panel_button.Controls.Add(this.button_stocks);
            this.panel_button.Controls.Add(this.enquire);
            this.panel_button.Controls.Add(this.userentry);
            this.panel_button.Location = new System.Drawing.Point(21, 49);
            this.panel_button.Name = "panel_button";
            this.panel_button.Size = new System.Drawing.Size(119, 546);
            this.panel_button.TabIndex = 12;
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.Gold;
            this.button_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exit.Location = new System.Drawing.Point(10, 417);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(99, 89);
            this.button_exit.TabIndex = 14;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_stocks
            // 
            this.button_stocks.BackColor = System.Drawing.Color.Tomato;
            this.button_stocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_stocks.Location = new System.Drawing.Point(10, 286);
            this.button_stocks.Name = "button_stocks";
            this.button_stocks.Size = new System.Drawing.Size(99, 91);
            this.button_stocks.TabIndex = 15;
            this.button_stocks.Text = "Stocks";
            this.button_stocks.UseVisualStyleBackColor = false;
            this.button_stocks.Click += new System.EventHandler(this.button_stocks_Click);
            // 
            // enquire
            // 
            this.enquire.BackColor = System.Drawing.Color.GreenYellow;
            this.enquire.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enquire.Location = new System.Drawing.Point(10, 162);
            this.enquire.Name = "enquire";
            this.enquire.Size = new System.Drawing.Size(99, 86);
            this.enquire.TabIndex = 14;
            this.enquire.Text = "Enquire";
            this.enquire.UseVisualStyleBackColor = false;
            this.enquire.Click += new System.EventHandler(this.enquire_Click);
            // 
            // userentry
            // 
            this.userentry.BackColor = System.Drawing.Color.DarkOrange;
            this.userentry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userentry.Location = new System.Drawing.Point(10, 31);
            this.userentry.Name = "userentry";
            this.userentry.Size = new System.Drawing.Size(99, 92);
            this.userentry.TabIndex = 13;
            this.userentry.Text = "User Entry";
            this.userentry.UseVisualStyleBackColor = false;
            this.userentry.Click += new System.EventHandler(this.userentry_Click);
            // 
            // FrontWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GetFit.Properties.Resources.A;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1080, 621);
            this.Controls.Add(this.label_fit);
            this.Controls.Add(this.label_get);
            this.Controls.Add(this.panel_login);
            
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrontWindow";
            this.Text = "Get Fit";
            this.Load += new System.EventHandler(this.FrontWindow_Load);
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            this.panel_button.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

      
        private System.Windows.Forms.Button button_userentry;
        private System.Windows.Forms.Button button_enquire;
        private System.Windows.Forms.Panel panel_login;
        private System.Windows.Forms.Label label_get;
        private System.Windows.Forms.Label label_fit;
        private System.Windows.Forms.Label label_loginas;
        private System.Windows.Forms.Button button_loginreset;
        private System.Windows.Forms.ComboBox comboBox_loginas;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.TextBox login_password;
        private System.Windows.Forms.TextBox email_or_id;
        private System.Windows.Forms.Panel panel_button;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_stocks;
        private System.Windows.Forms.Button enquire;
        private System.Windows.Forms.Button userentry;
        
       
    }
}