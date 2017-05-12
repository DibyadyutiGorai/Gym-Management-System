namespace GetFit
{
    partial class Enquire
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
            this.components = new System.ComponentModel.Container();
            this.gymSystemDataSet = new GetFit.GymSystemDataSet();
            this.userentryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userentryTableAdapter = new GetFit.GymSystemDataSetTableAdapters.userentryTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userentryBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.gymSystemDataSet2 = new GetFit.GymSystemDataSet2();
            this.panel_userEn = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_search = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_showalldata = new System.Windows.Forms.Button();
            this.panel_userentry = new System.Windows.Forms.Panel();
            this.button_update = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.label_entryas = new System.Windows.Forms.Label();
            this.comboBox_entryas = new System.Windows.Forms.ComboBox();
            this.panel_dob = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lname = new System.Windows.Forms.TextBox();
            this.radioButton_female = new System.Windows.Forms.RadioButton();
            this.radioButton_male = new System.Windows.Forms.RadioButton();
            this.label_gender = new System.Windows.Forms.Label();
            this.mobile = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.fname = new System.Windows.Forms.TextBox();
            this.userentryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.userentryTableAdapter1 = new GetFit.GymSystemDataSet2TableAdapters.userentryTableAdapter();
            this.label_userentry = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gymSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userentryBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userentryBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymSystemDataSet2)).BeginInit();
            this.panel_userEn.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_userentry.SuspendLayout();
            this.panel_dob.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userentryBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // gymSystemDataSet
            // 
            this.gymSystemDataSet.DataSetName = "GymSystemDataSet";
            this.gymSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userentryBindingSource
            // 
            this.userentryBindingSource.DataMember = "userentry";
            this.userentryBindingSource.DataSource = this.gymSystemDataSet;
            // 
            // userentryTableAdapter
            // 
            this.userentryTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(16, 270);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(866, 257);
            this.panel2.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fnameDataGridViewTextBoxColumn,
            this.lnameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.mobileDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.dobDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.entryasDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.userentryBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(16, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(826, 231);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "fname";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "fname";
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            // 
            // lnameDataGridViewTextBoxColumn
            // 
            this.lnameDataGridViewTextBoxColumn.DataPropertyName = "lname";
            this.lnameDataGridViewTextBoxColumn.HeaderText = "lname";
            this.lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.DataPropertyName = "mobile";
            this.mobileDataGridViewTextBoxColumn.HeaderText = "mobile";
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // dobDataGridViewTextBoxColumn
            // 
            this.dobDataGridViewTextBoxColumn.DataPropertyName = "dob";
            this.dobDataGridViewTextBoxColumn.HeaderText = "dob";
            this.dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // entryasDataGridViewTextBoxColumn
            // 
            this.entryasDataGridViewTextBoxColumn.DataPropertyName = "entryas";
            this.entryasDataGridViewTextBoxColumn.HeaderText = "entryas";
            this.entryasDataGridViewTextBoxColumn.Name = "entryasDataGridViewTextBoxColumn";
            // 
            // userentryBindingSource2
            // 
            this.userentryBindingSource2.DataMember = "userentry";
            this.userentryBindingSource2.DataSource = this.gymSystemDataSet2;
            // 
            // gymSystemDataSet2
            // 
            this.gymSystemDataSet2.DataSetName = "GymSystemDataSet2";
            this.gymSystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel_userEn
            // 
            this.panel_userEn.BackColor = System.Drawing.Color.Transparent;
            this.panel_userEn.Controls.Add(this.label_userentry);
            this.panel_userEn.Controls.Add(this.panel2);
            this.panel_userEn.Controls.Add(this.panel1);
            this.panel_userEn.Controls.Add(this.panel_userentry);
            this.panel_userEn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_userEn.Location = new System.Drawing.Point(159, 50);
            this.panel_userEn.Name = "panel_userEn";
            this.panel_userEn.Size = new System.Drawing.Size(897, 547);
            this.panel_userEn.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button_search);
            this.panel1.Controls.Add(this.button_delete);
            this.panel1.Controls.Add(this.button_showalldata);
            this.panel1.Location = new System.Drawing.Point(692, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 205);
            this.panel1.TabIndex = 6;
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.Cyan;
            this.button_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.Location = new System.Drawing.Point(27, 141);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(139, 50);
            this.button_search.TabIndex = 8;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.DarkOrange;
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.Location = new System.Drawing.Point(27, 79);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(139, 50);
            this.button_delete.TabIndex = 7;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_showalldata
            // 
            this.button_showalldata.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_showalldata.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_showalldata.Location = new System.Drawing.Point(27, 15);
            this.button_showalldata.Name = "button_showalldata";
            this.button_showalldata.Size = new System.Drawing.Size(139, 50);
            this.button_showalldata.TabIndex = 0;
            this.button_showalldata.Text = "Show Full List";
            this.button_showalldata.UseVisualStyleBackColor = false;
            this.button_showalldata.Click += new System.EventHandler(this.button_showalldata_Click);
            // 
            // panel_userentry
            // 
            this.panel_userentry.BackColor = System.Drawing.Color.Transparent;
            this.panel_userentry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_userentry.Controls.Add(this.button_update);
            this.panel_userentry.Controls.Add(this.button_reset);
            this.panel_userentry.Controls.Add(this.label_entryas);
            this.panel_userentry.Controls.Add(this.comboBox_entryas);
            this.panel_userentry.Controls.Add(this.panel_dob);
            this.panel_userentry.Controls.Add(this.lname);
            this.panel_userentry.Controls.Add(this.radioButton_female);
            this.panel_userentry.Controls.Add(this.radioButton_male);
            this.panel_userentry.Controls.Add(this.label_gender);
            this.panel_userentry.Controls.Add(this.mobile);
            this.panel_userentry.Controls.Add(this.email);
            this.panel_userentry.Controls.Add(this.fname);
            this.panel_userentry.Location = new System.Drawing.Point(16, 48);
            this.panel_userentry.Name = "panel_userentry";
            this.panel_userentry.Size = new System.Drawing.Size(652, 205);
            this.panel_userentry.TabIndex = 5;
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.Location = new System.Drawing.Point(360, 149);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(128, 50);
            this.button_update.TabIndex = 18;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_reset
            // 
            this.button_reset.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reset.Location = new System.Drawing.Point(509, 150);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(124, 50);
            this.button_reset.TabIndex = 17;
            this.button_reset.Text = "Reset";
            this.button_reset.UseVisualStyleBackColor = false;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // label_entryas
            // 
            this.label_entryas.AutoSize = true;
            this.label_entryas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_entryas.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label_entryas.Location = new System.Drawing.Point(355, 107);
            this.label_entryas.Name = "label_entryas";
            this.label_entryas.Size = new System.Drawing.Size(93, 25);
            this.label_entryas.TabIndex = 16;
            this.label_entryas.Text = "Entry As";
            // 
            // comboBox_entryas
            // 
            this.comboBox_entryas.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBox_entryas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_entryas.FormattingEnabled = true;
            this.comboBox_entryas.Items.AddRange(new object[] {
            "Trainee",
            "Trainer",
            "Stuff",
            "Other"});
            this.comboBox_entryas.Location = new System.Drawing.Point(455, 107);
            this.comboBox_entryas.Name = "comboBox_entryas";
            this.comboBox_entryas.Size = new System.Drawing.Size(178, 28);
            this.comboBox_entryas.TabIndex = 15;
            this.comboBox_entryas.SelectedIndexChanged += new System.EventHandler(this.comboBox_entryas_SelectedIndexChanged);
            // 
            // panel_dob
            // 
            this.panel_dob.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel_dob.Controls.Add(this.label3);
            this.panel_dob.Controls.Add(this.dateTimePicker);
            this.panel_dob.Location = new System.Drawing.Point(16, 104);
            this.panel_dob.Name = "panel_dob";
            this.panel_dob.Size = new System.Drawing.Size(272, 31);
            this.panel_dob.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(19, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "DOB";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(69, 5);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 0;
            // 
            // lname
            // 
            this.lname.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lname.Location = new System.Drawing.Point(361, 15);
            this.lname.Multiline = true;
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(272, 31);
            this.lname.TabIndex = 4;
            this.lname.Text = "Last Name";
            this.lname.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lname_MouseClick);
            // 
            // radioButton_female
            // 
            this.radioButton_female.AutoSize = true;
            this.radioButton_female.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_female.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.radioButton_female.Location = new System.Drawing.Point(128, 170);
            this.radioButton_female.Name = "radioButton_female";
            this.radioButton_female.Size = new System.Drawing.Size(101, 29);
            this.radioButton_female.TabIndex = 11;
            this.radioButton_female.TabStop = true;
            this.radioButton_female.Text = "Female";
            this.radioButton_female.UseVisualStyleBackColor = true;
            // 
            // radioButton_male
            // 
            this.radioButton_male.AutoSize = true;
            this.radioButton_male.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_male.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.radioButton_male.Location = new System.Drawing.Point(128, 141);
            this.radioButton_male.Name = "radioButton_male";
            this.radioButton_male.Size = new System.Drawing.Size(77, 29);
            this.radioButton_male.TabIndex = 10;
            this.radioButton_male.TabStop = true;
            this.radioButton_male.Text = "Male";
            this.radioButton_male.UseVisualStyleBackColor = true;
            // 
            // label_gender
            // 
            this.label_gender.AutoSize = true;
            this.label_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gender.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label_gender.Location = new System.Drawing.Point(11, 161);
            this.label_gender.Name = "label_gender";
            this.label_gender.Size = new System.Drawing.Size(83, 25);
            this.label_gender.TabIndex = 9;
            this.label_gender.Text = "Gender";
            // 
            // mobile
            // 
            this.mobile.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.mobile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobile.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.mobile.Location = new System.Drawing.Point(360, 59);
            this.mobile.Multiline = true;
            this.mobile.Name = "mobile";
            this.mobile.Size = new System.Drawing.Size(273, 31);
            this.mobile.TabIndex = 5;
            this.mobile.Text = "Mobile";
            this.mobile.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mobile_MouseClick);
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.email.Location = new System.Drawing.Point(16, 59);
            this.email.Multiline = true;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(274, 31);
            this.email.TabIndex = 4;
            this.email.Text = "Email";
            this.email.MouseClick += new System.Windows.Forms.MouseEventHandler(this.email_MouseClick);
            // 
            // fname
            // 
            this.fname.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.fname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.fname.Location = new System.Drawing.Point(16, 15);
            this.fname.Multiline = true;
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(274, 30);
            this.fname.TabIndex = 3;
            this.fname.Text = "First Name";
            this.fname.MouseClick += new System.Windows.Forms.MouseEventHandler(this.fname_MouseClick);
            // 
            // userentryBindingSource1
            // 
            this.userentryBindingSource1.DataMember = "userentry";
            this.userentryBindingSource1.DataSource = this.gymSystemDataSet;
            // 
            // userentryTableAdapter1
            // 
            this.userentryTableAdapter1.ClearBeforeFill = true;
            // 
            // label_userentry
            // 
            this.label_userentry.AutoSize = true;
            this.label_userentry.BackColor = System.Drawing.Color.Transparent;
            this.label_userentry.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_userentry.ForeColor = System.Drawing.Color.Gold;
            this.label_userentry.Location = new System.Drawing.Point(352, 3);
            this.label_userentry.Name = "label_userentry";
            this.label_userentry.Size = new System.Drawing.Size(147, 42);
            this.label_userentry.TabIndex = 8;
            this.label_userentry.Text = "Enquire";
            // 
            // Enquire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GetFit.Properties.Resources.B;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1080, 621);
            this.Controls.Add(this.panel_userEn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Enquire";
            this.Text = "Get Fit";
            this.Load += new System.EventHandler(this.Enquire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gymSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userentryBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userentryBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymSystemDataSet2)).EndInit();
            this.panel_userEn.ResumeLayout(false);
            this.panel_userEn.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel_userentry.ResumeLayout(false);
            this.panel_userentry.PerformLayout();
            this.panel_dob.ResumeLayout(false);
            this.panel_dob.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userentryBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GymSystemDataSet gymSystemDataSet;
        private System.Windows.Forms.BindingSource userentryBindingSource;
        private GymSystemDataSetTableAdapters.userentryTableAdapter userentryTableAdapter;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel_userEn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_showalldata;
        private System.Windows.Forms.Panel panel_userentry;
        private System.Windows.Forms.Label label_entryas;
        private System.Windows.Forms.ComboBox comboBox_entryas;
        private System.Windows.Forms.Panel panel_dob;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.RadioButton radioButton_female;
        private System.Windows.Forms.RadioButton radioButton_male;
        private System.Windows.Forms.Label label_gender;
        private System.Windows.Forms.TextBox mobile;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource userentryBindingSource1;
        private GymSystemDataSet2 gymSystemDataSet2;
        private System.Windows.Forms.BindingSource userentryBindingSource2;
        private GymSystemDataSet2TableAdapters.userentryTableAdapter userentryTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryasDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label_userentry;
    }
}