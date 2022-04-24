namespace note_app2
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btexit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.BtSettings = new System.Windows.Forms.Button();
            this.BtChangepass = new System.Windows.Forms.Button();
            this.BtChangeemail = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.From = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btadmin = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.noteTitleDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteContentDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.noteTitleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteContentDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class2BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.noteTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteContentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.class2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.class2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.class6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numbersofnotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numbersofsharednotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numbersofpublicnotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.class3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.class2BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.class2BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.class2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.class6BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btexit
            // 
            this.btexit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btexit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btexit.Location = new System.Drawing.Point(0, 417);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(142, 37);
            this.btexit.TabIndex = 0;
            this.btexit.Text = "Exit";
            this.btexit.UseVisualStyleBackColor = false;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(0, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "My notes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(0, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 37);
            this.button2.TabIndex = 4;
            this.button2.Text = "Publical notes";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(0, 176);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 37);
            this.button3.TabIndex = 5;
            this.button3.Text = "Shared notes";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noteTitleDataGridViewTextBoxColumn,
            this.noteContentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.class1BindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(234, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(779, 185);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowDrop = true;
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noteTitleDataGridViewTextBoxColumn1,
            this.noteContentDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.class2BindingSource2;
            this.dataGridView2.Location = new System.Drawing.Point(234, 133);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(528, 119);
            this.dataGridView2.TabIndex = 9;
            // 
            // BtSettings
            // 
            this.BtSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.BtSettings.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtSettings.Location = new System.Drawing.Point(0, 219);
            this.BtSettings.Name = "BtSettings";
            this.BtSettings.Size = new System.Drawing.Size(142, 37);
            this.BtSettings.TabIndex = 16;
            this.BtSettings.Text = "Settings";
            this.BtSettings.UseVisualStyleBackColor = false;
            this.BtSettings.Click += new System.EventHandler(this.BtSettings_Click);
            // 
            // BtChangepass
            // 
            this.BtChangepass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.BtChangepass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtChangepass.Location = new System.Drawing.Point(0, 262);
            this.BtChangepass.Name = "BtChangepass";
            this.BtChangepass.Size = new System.Drawing.Size(142, 37);
            this.BtChangepass.TabIndex = 17;
            this.BtChangepass.Text = "Change password";
            this.BtChangepass.UseVisualStyleBackColor = false;
            this.BtChangepass.Click += new System.EventHandler(this.BtChangepass_Click);
            // 
            // BtChangeemail
            // 
            this.BtChangeemail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.BtChangeemail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtChangeemail.Location = new System.Drawing.Point(0, 305);
            this.BtChangeemail.Name = "BtChangeemail";
            this.BtChangeemail.Size = new System.Drawing.Size(142, 37);
            this.BtChangeemail.TabIndex = 18;
            this.BtChangeemail.Text = "Change email";
            this.BtChangeemail.UseVisualStyleBackColor = false;
            this.BtChangeemail.Click += new System.EventHandler(this.BtChangeemail_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.Btadmin);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.BtSettings);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.BtChangeemail);
            this.panel1.Controls.Add(this.btexit);
            this.panel1.Controls.Add(this.BtChangepass);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 454);
            this.panel1.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(142, 71);
            this.panel3.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(36)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(142, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(930, 71);
            this.panel4.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bodoni MT Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(425, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 32);
            this.label1.TabIndex = 18;
            this.label1.Text = "HOME";
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(0, 262);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(142, 100);
            this.panel5.TabIndex = 18;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowDrop = true;
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noteTitleDataGridViewTextBoxColumn2,
            this.noteContentDataGridViewTextBoxColumn2,
            this.From});
            this.dataGridView3.DataSource = this.class3BindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(234, 133);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView3.Size = new System.Drawing.Size(538, 117);
            this.dataGridView3.TabIndex = 10;
            // 
            // From
            // 
            this.From.DataPropertyName = "From";
            this.From.HeaderText = "From";
            this.From.Name = "From";
            this.From.ReadOnly = true;
            // 
            // Btadmin
            // 
            this.Btadmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.Btadmin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btadmin.Location = new System.Drawing.Point(0, 219);
            this.Btadmin.Name = "Btadmin";
            this.Btadmin.Size = new System.Drawing.Size(142, 37);
            this.Btadmin.TabIndex = 19;
            this.Btadmin.Text = "Note app statics";
            this.Btadmin.UseVisualStyleBackColor = false;
            this.Btadmin.Click += new System.EventHandler(this.Btadmin_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(0, 219);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 37);
            this.button4.TabIndex = 16;
            this.button4.Text = "Settings";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.BtSettings_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowDrop = true;
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView4.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView4.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.numbersofnotesDataGridViewTextBoxColumn,
            this.numbersofsharednotesDataGridViewTextBoxColumn,
            this.numbersofpublicnotesDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.class6BindingSource;
            this.dataGridView4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView4.Location = new System.Drawing.Point(445, 149);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView4.RowHeadersVisible = false;
            this.dataGridView4.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView4.Size = new System.Drawing.Size(444, 150);
            this.dataGridView4.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(200, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(42, 111);
            this.panel2.TabIndex = 18;
            // 
            // noteTitleDataGridViewTextBoxColumn2
            // 
            this.noteTitleDataGridViewTextBoxColumn2.DataPropertyName = "Note_Title";
            this.noteTitleDataGridViewTextBoxColumn2.HeaderText = "Note_Title";
            this.noteTitleDataGridViewTextBoxColumn2.Name = "noteTitleDataGridViewTextBoxColumn2";
            this.noteTitleDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // noteContentDataGridViewTextBoxColumn2
            // 
            this.noteContentDataGridViewTextBoxColumn2.DataPropertyName = "Note_Content";
            this.noteContentDataGridViewTextBoxColumn2.HeaderText = "Note_Content";
            this.noteContentDataGridViewTextBoxColumn2.Name = "noteContentDataGridViewTextBoxColumn2";
            this.noteContentDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // class3BindingSource
            // 
            this.class3BindingSource.DataSource = typeof(note_app2.Class3);
            // 
            // noteTitleDataGridViewTextBoxColumn1
            // 
            this.noteTitleDataGridViewTextBoxColumn1.DataPropertyName = "Note_Title";
            this.noteTitleDataGridViewTextBoxColumn1.HeaderText = "Note_Title";
            this.noteTitleDataGridViewTextBoxColumn1.Name = "noteTitleDataGridViewTextBoxColumn1";
            this.noteTitleDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // noteContentDataGridViewTextBoxColumn1
            // 
            this.noteContentDataGridViewTextBoxColumn1.DataPropertyName = "Note_Content";
            this.noteContentDataGridViewTextBoxColumn1.HeaderText = "Note_Content";
            this.noteContentDataGridViewTextBoxColumn1.Name = "noteContentDataGridViewTextBoxColumn1";
            this.noteContentDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // class2BindingSource2
            // 
            this.class2BindingSource2.DataSource = typeof(note_app2.Class2);
            // 
            // noteTitleDataGridViewTextBoxColumn
            // 
            this.noteTitleDataGridViewTextBoxColumn.DataPropertyName = "Note_Title";
            this.noteTitleDataGridViewTextBoxColumn.HeaderText = "Note_Title";
            this.noteTitleDataGridViewTextBoxColumn.Name = "noteTitleDataGridViewTextBoxColumn";
            this.noteTitleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noteContentDataGridViewTextBoxColumn
            // 
            this.noteContentDataGridViewTextBoxColumn.DataPropertyName = "Note_Content";
            this.noteContentDataGridViewTextBoxColumn.HeaderText = "Note_Content";
            this.noteContentDataGridViewTextBoxColumn.Name = "noteContentDataGridViewTextBoxColumn";
            this.noteContentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // class1BindingSource
            // 
            this.class1BindingSource.DataSource = typeof(note_app2.Class1);
            // 
            // class2BindingSource1
            // 
            this.class2BindingSource1.DataSource = typeof(note_app2.Class2);
            // 
            // class2BindingSource
            // 
            this.class2BindingSource.DataSource = typeof(note_app2.Class2);
            // 
            // class6BindingSource
            // 
            this.class6BindingSource.DataSource = typeof(note_app2.Class6);
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numbersofnotesDataGridViewTextBoxColumn
            // 
            this.numbersofnotesDataGridViewTextBoxColumn.DataPropertyName = "Numbers_of_notes";
            this.numbersofnotesDataGridViewTextBoxColumn.HeaderText = "Numbers_of_notes";
            this.numbersofnotesDataGridViewTextBoxColumn.Name = "numbersofnotesDataGridViewTextBoxColumn";
            this.numbersofnotesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numbersofsharednotesDataGridViewTextBoxColumn
            // 
            this.numbersofsharednotesDataGridViewTextBoxColumn.DataPropertyName = "Numbers_of_shared_notes";
            this.numbersofsharednotesDataGridViewTextBoxColumn.HeaderText = "Numbers_of_shared_notes";
            this.numbersofsharednotesDataGridViewTextBoxColumn.Name = "numbersofsharednotesDataGridViewTextBoxColumn";
            this.numbersofsharednotesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numbersofpublicnotesDataGridViewTextBoxColumn
            // 
            this.numbersofpublicnotesDataGridViewTextBoxColumn.DataPropertyName = "Numbers_of_public_notes";
            this.numbersofpublicnotesDataGridViewTextBoxColumn.HeaderText = "Numbers_of_public_notes";
            this.numbersofpublicnotesDataGridViewTextBoxColumn.Name = "numbersofpublicnotesDataGridViewTextBoxColumn";
            this.numbersofpublicnotesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1056, 455);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Click += new System.EventHandler(this.Form2_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.class3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.class2BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.class2BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.class2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.class6BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource class1BindingSource;
        private System.Windows.Forms.BindingSource class2BindingSource;
        private System.Windows.Forms.BindingSource class2BindingSource1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource class2BindingSource2;
        private System.Windows.Forms.BindingSource class3BindingSource;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteTitleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteContentDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button BtSettings;
        private System.Windows.Forms.Button BtChangepass;
        private System.Windows.Forms.Button BtChangeemail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteContentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteTitleDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteContentDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn From;
        private System.Windows.Forms.Button Btadmin;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numbersofnotesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numbersofsharednotesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numbersofpublicnotesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource class6BindingSource;
    }
}