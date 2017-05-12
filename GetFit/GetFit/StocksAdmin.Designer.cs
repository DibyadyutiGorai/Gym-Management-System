namespace GetFit
{
    partial class StocksAdmin
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
            this.panel_insertitem = new System.Windows.Forms.Panel();
            this.button_viewall = new System.Windows.Forms.Button();
            this.button_searchp = new System.Windows.Forms.Button();
            this.button_resetp = new System.Windows.Forms.Button();
            this.button_deletep = new System.Windows.Forms.Button();
            this.button_updatep = new System.Windows.Forms.Button();
            this.button_insertp = new System.Windows.Forms.Button();
            this.label_placerin = new System.Windows.Forms.Label();
            this.comboBox_placedin = new System.Windows.Forms.ComboBox();
            this.label_entryas = new System.Windows.Forms.Label();
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.panel_doe = new System.Windows.Forms.Panel();
            this.label_doe = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.productname = new System.Windows.Forms.TextBox();
            this.makers = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.panel_userEn = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_userentry = new System.Windows.Forms.Label();
            this.panel_producttable = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stocksBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new GetFit.Database1DataSet1();
            this.stocksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new GetFit.Database1DataSet();
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stocksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stocksTableAdapter = new GetFit.Database1DataSet1TableAdapters.stocksTableAdapter();
            this.panel_insertitem.SuspendLayout();
            this.panel_doe.SuspendLayout();
            this.panel_userEn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_producttable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_insertitem
            // 
            this.panel_insertitem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_insertitem.Controls.Add(this.button_viewall);
            this.panel_insertitem.Controls.Add(this.button_searchp);
            this.panel_insertitem.Controls.Add(this.button_resetp);
            this.panel_insertitem.Controls.Add(this.button_deletep);
            this.panel_insertitem.Controls.Add(this.button_updatep);
            this.panel_insertitem.Controls.Add(this.button_insertp);
            this.panel_insertitem.Controls.Add(this.label_placerin);
            this.panel_insertitem.Controls.Add(this.comboBox_placedin);
            this.panel_insertitem.Controls.Add(this.label_entryas);
            this.panel_insertitem.Controls.Add(this.comboBox_category);
            this.panel_insertitem.Controls.Add(this.panel_doe);
            this.panel_insertitem.Controls.Add(this.productname);
            this.panel_insertitem.Controls.Add(this.makers);
            this.panel_insertitem.Controls.Add(this.id);
            this.panel_insertitem.Location = new System.Drawing.Point(41, 57);
            this.panel_insertitem.Name = "panel_insertitem";
            this.panel_insertitem.Size = new System.Drawing.Size(497, 208);
            this.panel_insertitem.TabIndex = 3;
            // 
            // button_viewall
            // 
            this.button_viewall.BackColor = System.Drawing.Color.YellowGreen;
            this.button_viewall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_viewall.Location = new System.Drawing.Point(184, 161);
            this.button_viewall.Name = "button_viewall";
            this.button_viewall.Size = new System.Drawing.Size(92, 31);
            this.button_viewall.TabIndex = 31;
            this.button_viewall.Text = "View All";
            this.button_viewall.UseVisualStyleBackColor = false;
            this.button_viewall.Click += new System.EventHandler(this.button_viewall_Click);
            // 
            // button_searchp
            // 
            this.button_searchp.BackColor = System.Drawing.Color.Tomato;
            this.button_searchp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_searchp.Location = new System.Drawing.Point(395, 15);
            this.button_searchp.Name = "button_searchp";
            this.button_searchp.Size = new System.Drawing.Size(92, 31);
            this.button_searchp.TabIndex = 30;
            this.button_searchp.Text = "Search";
            this.button_searchp.UseVisualStyleBackColor = false;
            this.button_searchp.Click += new System.EventHandler(this.button_searchp_Click);
            // 
            // button_resetp
            // 
            this.button_resetp.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_resetp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_resetp.Location = new System.Drawing.Point(395, 161);
            this.button_resetp.Name = "button_resetp";
            this.button_resetp.Size = new System.Drawing.Size(92, 31);
            this.button_resetp.TabIndex = 29;
            this.button_resetp.Text = "Reset";
            this.button_resetp.UseVisualStyleBackColor = false;
            this.button_resetp.Click += new System.EventHandler(this.button_resetp_Click);
            // 
            // button_deletep
            // 
            this.button_deletep.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button_deletep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_deletep.Location = new System.Drawing.Point(395, 112);
            this.button_deletep.Name = "button_deletep";
            this.button_deletep.Size = new System.Drawing.Size(92, 31);
            this.button_deletep.TabIndex = 28;
            this.button_deletep.Text = "Delete";
            this.button_deletep.UseVisualStyleBackColor = false;
            this.button_deletep.Click += new System.EventHandler(this.button_deletep_Click);
            // 
            // button_updatep
            // 
            this.button_updatep.BackColor = System.Drawing.Color.GreenYellow;
            this.button_updatep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_updatep.Location = new System.Drawing.Point(395, 62);
            this.button_updatep.Name = "button_updatep";
            this.button_updatep.Size = new System.Drawing.Size(92, 31);
            this.button_updatep.TabIndex = 27;
            this.button_updatep.Text = "Update";
            this.button_updatep.UseVisualStyleBackColor = false;
            this.button_updatep.Click += new System.EventHandler(this.button_updatep_Click);
            // 
            // button_insertp
            // 
            this.button_insertp.BackColor = System.Drawing.Color.Orange;
            this.button_insertp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_insertp.Location = new System.Drawing.Point(289, 161);
            this.button_insertp.Name = "button_insertp";
            this.button_insertp.Size = new System.Drawing.Size(92, 31);
            this.button_insertp.TabIndex = 26;
            this.button_insertp.Text = "Insert";
            this.button_insertp.UseVisualStyleBackColor = false;
            this.button_insertp.Click += new System.EventHandler(this.button_insertp_Click);
            // 
            // label_placerin
            // 
            this.label_placerin.AutoSize = true;
            this.label_placerin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_placerin.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label_placerin.Location = new System.Drawing.Point(205, 118);
            this.label_placerin.Name = "label_placerin";
            this.label_placerin.Size = new System.Drawing.Size(64, 16);
            this.label_placerin.TabIndex = 25;
            this.label_placerin.Text = "Placed In";
            // 
            // comboBox_placedin
            // 
            this.comboBox_placedin.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBox_placedin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_placedin.FormattingEnabled = true;
            this.comboBox_placedin.Items.AddRange(new object[] {
            "ROOM101",
            "ROOM102(AC)",
            "ROOM103(AC)",
            "ROOM104"});
            this.comboBox_placedin.Location = new System.Drawing.Point(269, 112);
            this.comboBox_placedin.Name = "comboBox_placedin";
            this.comboBox_placedin.Size = new System.Drawing.Size(115, 28);
            this.comboBox_placedin.TabIndex = 24;
            // 
            // label_entryas
            // 
            this.label_entryas.AutoSize = true;
            this.label_entryas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_entryas.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label_entryas.Location = new System.Drawing.Point(9, 118);
            this.label_entryas.Name = "label_entryas";
            this.label_entryas.Size = new System.Drawing.Size(63, 16);
            this.label_entryas.TabIndex = 23;
            this.label_entryas.Text = "Category";
            // 
            // comboBox_category
            // 
            this.comboBox_category.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBox_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_category.FormattingEnabled = true;
            this.comboBox_category.Items.AddRange(new object[] {
            "Cardio",
            "Upper Body",
            "Mid Zone",
            "Lower Body",
            "Bench",
            "Multi Functional",
            "Dumbbell",
            "Weight Lifting"});
            this.comboBox_category.Location = new System.Drawing.Point(72, 112);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(115, 28);
            this.comboBox_category.TabIndex = 22;
            // 
            // panel_doe
            // 
            this.panel_doe.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel_doe.Controls.Add(this.label_doe);
            this.panel_doe.Controls.Add(this.dateTimePicker);
            this.panel_doe.Location = new System.Drawing.Point(211, 63);
            this.panel_doe.Name = "panel_doe";
            this.panel_doe.Size = new System.Drawing.Size(173, 31);
            this.panel_doe.TabIndex = 21;
            // 
            // label_doe
            // 
            this.label_doe.AutoSize = true;
            this.label_doe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_doe.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label_doe.Location = new System.Drawing.Point(3, 8);
            this.label_doe.Name = "label_doe";
            this.label_doe.Size = new System.Drawing.Size(69, 13);
            this.label_doe.TabIndex = 1;
            this.label_doe.Text = "Date of Entry";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(73, 4);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(92, 20);
            this.dateTimePicker.TabIndex = 0;
            this.dateTimePicker.Value = new System.DateTime(2017, 5, 8, 0, 0, 0, 0);
            // 
            // productname
            // 
            this.productname.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.productname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productname.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.productname.Location = new System.Drawing.Point(211, 15);
            this.productname.Multiline = true;
            this.productname.Name = "productname";
            this.productname.Size = new System.Drawing.Size(173, 31);
            this.productname.TabIndex = 18;
            this.productname.Text = "Name";
            this.productname.MouseClick += new System.Windows.Forms.MouseEventHandler(this.productname_MouseClick);
            // 
            // makers
            // 
            this.makers.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.makers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.makers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makers.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.makers.Location = new System.Drawing.Point(12, 63);
            this.makers.Multiline = true;
            this.makers.Name = "makers";
            this.makers.Size = new System.Drawing.Size(175, 31);
            this.makers.TabIndex = 19;
            this.makers.Text = "Makers Name";
            this.makers.MouseClick += new System.Windows.Forms.MouseEventHandler(this.makers_MouseClick);
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.id.Location = new System.Drawing.Point(12, 15);
            this.id.Multiline = true;
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(175, 31);
            this.id.TabIndex = 17;
            this.id.Text = "Product Id";
            this.id.MouseClick += new System.Windows.Forms.MouseEventHandler(this.id_MouseClick);
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // panel_userEn
            // 
            this.panel_userEn.BackColor = System.Drawing.Color.Transparent;
            this.panel_userEn.Controls.Add(this.pictureBox1);
            this.panel_userEn.Controls.Add(this.label_userentry);
            this.panel_userEn.Controls.Add(this.panel_producttable);
            this.panel_userEn.Controls.Add(this.panel_insertitem);
            this.panel_userEn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_userEn.Location = new System.Drawing.Point(159, 50);
            this.panel_userEn.Name = "panel_userEn";
            this.panel_userEn.Size = new System.Drawing.Size(897, 547);
            this.panel_userEn.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GetFit.Properties.Resources.L090;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(558, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 465);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label_userentry
            // 
            this.label_userentry.AutoSize = true;
            this.label_userentry.BackColor = System.Drawing.Color.Transparent;
            this.label_userentry.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_userentry.ForeColor = System.Drawing.Color.Gold;
            this.label_userentry.Location = new System.Drawing.Point(276, 0);
            this.label_userentry.Name = "label_userentry";
            this.label_userentry.Size = new System.Drawing.Size(319, 42);
            this.label_userentry.TabIndex = 6;
            this.label_userentry.Text = "Equipment Stocks";
            // 
            // panel_producttable
            // 
            this.panel_producttable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_producttable.Controls.Add(this.dataGridView1);
            this.panel_producttable.Location = new System.Drawing.Point(41, 284);
            this.panel_producttable.Name = "panel_producttable";
            this.panel_producttable.Size = new System.Drawing.Size(497, 238);
            this.panel_producttable.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView1.DataSource = this.stocksBindingSource2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(495, 236);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Category";
            this.dataGridViewTextBoxColumn3.HeaderText = "Category";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Entry";
            this.dataGridViewTextBoxColumn4.HeaderText = "Entry";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PlacedIn";
            this.dataGridViewTextBoxColumn5.HeaderText = "PlacedIn";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Makers";
            this.dataGridViewTextBoxColumn6.HeaderText = "Makers";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // stocksBindingSource2
            // 
            this.stocksBindingSource2.DataMember = "stocks";
            this.stocksBindingSource2.DataSource = this.database1DataSet1;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stocksBindingSource1
            // 
            this.stocksBindingSource1.DataMember = "stocks";
            this.stocksBindingSource1.DataSource = this.database1DataSet1;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // database1DataSetBindingSource
            // 
            this.database1DataSetBindingSource.DataSource = this.database1DataSet;
            this.database1DataSetBindingSource.Position = 0;
            // 
            // database1DataSetBindingSource1
            // 
            this.database1DataSetBindingSource1.DataSource = this.database1DataSet;
            this.database1DataSetBindingSource1.Position = 0;
            // 
            // stocksBindingSource
            // 
            this.stocksBindingSource.DataMember = "stocks";
            this.stocksBindingSource.DataSource = this.database1DataSet1;
            // 
            // stocksTableAdapter
            // 
            this.stocksTableAdapter.ClearBeforeFill = true;
            // 
            // StocksAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GetFit.Properties.Resources.B;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1080, 621);
            this.Controls.Add(this.panel_userEn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "StocksAdmin";
            this.Text = "Get Fit";
            this.panel_insertitem.ResumeLayout(false);
            this.panel_insertitem.PerformLayout();
            this.panel_doe.ResumeLayout(false);
            this.panel_doe.PerformLayout();
            this.panel_userEn.ResumeLayout(false);
            this.panel_userEn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_producttable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_insertitem;
        public System.Windows.Forms.Panel panel_userEn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_searchp;
        private System.Windows.Forms.Button button_resetp;
        private System.Windows.Forms.Button button_deletep;
        private System.Windows.Forms.Button button_updatep;
        private System.Windows.Forms.Button button_insertp;
        private System.Windows.Forms.Label label_placerin;
        private System.Windows.Forms.ComboBox comboBox_placedin;
        private System.Windows.Forms.Label label_entryas;
        private System.Windows.Forms.ComboBox comboBox_category;
        private System.Windows.Forms.Panel panel_doe;
        private System.Windows.Forms.Label label_doe;
        private System.Windows.Forms.TextBox productname;
        private System.Windows.Forms.TextBox makers;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Panel panel_producttable;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource1;
        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource stocksBindingSource;
        private Database1DataSet1TableAdapters.stocksTableAdapter stocksTableAdapter;
        private System.Windows.Forms.Button button_viewall;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placedInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makersDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource stocksBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource stocksBindingSource2;
        private System.Windows.Forms.Label label_userentry;

    }
}