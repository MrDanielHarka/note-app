namespace note_app2
{
    partial class Form5
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
            this.BtShare = new System.Windows.Forms.Button();
            this.Btback = new System.Windows.Forms.Button();
            this.txtemail = new SoftControlsLibrary.CustomBorder();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Unshare = new System.Windows.Forms.DataGridViewButtonColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.class2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.class4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.class2BindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtShare
            // 
            this.BtShare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(36)))));
            this.BtShare.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtShare.Location = new System.Drawing.Point(136, 243);
            this.BtShare.Name = "BtShare";
            this.BtShare.Size = new System.Drawing.Size(98, 23);
            this.BtShare.TabIndex = 1;
            this.BtShare.Text = "Share";
            this.BtShare.UseVisualStyleBackColor = false;
            this.BtShare.Click += new System.EventHandler(this.BtShare_Click);
            // 
            // Btback
            // 
            this.Btback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.Btback.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btback.Location = new System.Drawing.Point(0, 278);
            this.Btback.Name = "Btback";
            this.Btback.Size = new System.Drawing.Size(70, 23);
            this.Btback.TabIndex = 2;
            this.Btback.Text = "Back";
            this.Btback.UseVisualStyleBackColor = false;
            this.Btback.Click += new System.EventHandler(this.Btback_Click);
            // 
            // txtemail
            // 
            this.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtemail.BottomBorderOnFocusColor = System.Drawing.Color.Blue;
            this.txtemail.ButtomBorderColor = System.Drawing.Color.Black;
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtemail.Location = new System.Drawing.Point(153, 152);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(144, 23);
            this.txtemail.TabIndex = 3;
            this.txtemail.TextChanged += new System.EventHandler(this.txtemail_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Unshare,
            this.usernameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.class4BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(332, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(301, 139);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel1.Location = new System.Drawing.Point(153, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 2);
            this.panel1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "E-mail";
            // 
            // Unshare
            // 
            this.Unshare.DataPropertyName = "Username";
            this.Unshare.HeaderText = "Unshare";
            this.Unshare.Name = "Unshare";
            this.Unshare.Text = "Unshare with";
            this.Unshare.UseColumnTextForButtonValue = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            this.usernameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // class4BindingSource
            // 
            this.class4BindingSource.DataSource = typeof(note_app2.Class4);
            // 
            // class2BindingSource
            // 
            this.class2BindingSource.DataSource = typeof(note_app2.Class2);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.Btback);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(70, 310);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(70, 70);
            this.panel3.TabIndex = 62;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(36)))));
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(70, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(590, 70);
            this.panel4.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(259, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 63;
            this.label3.Text = "Sharing";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(654, 313);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.BtShare);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.class4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.class2BindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtShare;
        private System.Windows.Forms.Button Btback;
        private SoftControlsLibrary.CustomBorder txtemail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource class2BindingSource;
        private System.Windows.Forms.BindingSource class4BindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewButtonColumn Unshare;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
    }
}