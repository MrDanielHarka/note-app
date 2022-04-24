namespace note_app2
{
    partial class Form1
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
            this.btexit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btlogin = new System.Windows.Forms.Button();
            this.lbhelyese = new System.Windows.Forms.Label();
            this.btlathato = new System.Windows.Forms.Button();
            this.btlathatatlan = new System.Windows.Forms.Button();
            this.BtRegistration = new System.Windows.Forms.Button();
            this.txtemail = new SoftControlsLibrary.CustomBorder();
            this.txtpassword = new SoftControlsLibrary.CustomBorder();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btexit
            // 
            this.btexit.Location = new System.Drawing.Point(226, 215);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(75, 23);
            this.btexit.TabIndex = 13;
            this.btexit.Text = "Exit";
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(72, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "E-mail";
            // 
            // btlogin
            // 
            this.btlogin.Location = new System.Drawing.Point(43, 215);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(75, 23);
            this.btlogin.TabIndex = 8;
            this.btlogin.Text = "Login";
            this.btlogin.UseVisualStyleBackColor = true;
            this.btlogin.Click += new System.EventHandler(this.btlogin_Click);
            // 
            // lbhelyese
            // 
            this.lbhelyese.AutoSize = true;
            this.lbhelyese.ForeColor = System.Drawing.SystemColors.Control;
            this.lbhelyese.Location = new System.Drawing.Point(118, 178);
            this.lbhelyese.Name = "lbhelyese";
            this.lbhelyese.Size = new System.Drawing.Size(0, 13);
            this.lbhelyese.TabIndex = 14;
            // 
            // btlathato
            // 
            this.btlathato.BackColor = System.Drawing.Color.Red;
            this.btlathato.Location = new System.Drawing.Point(255, 146);
            this.btlathato.Name = "btlathato";
            this.btlathato.Size = new System.Drawing.Size(23, 23);
            this.btlathato.TabIndex = 16;
            this.btlathato.UseVisualStyleBackColor = false;
            this.btlathato.Click += new System.EventHandler(this.btlathato_Click);
            // 
            // btlathatatlan
            // 
            this.btlathatatlan.BackColor = System.Drawing.Color.Blue;
            this.btlathatatlan.Location = new System.Drawing.Point(255, 146);
            this.btlathatatlan.Name = "btlathatatlan";
            this.btlathatatlan.Size = new System.Drawing.Size(23, 23);
            this.btlathatatlan.TabIndex = 17;
            this.btlathatatlan.UseVisualStyleBackColor = false;
            this.btlathatatlan.Click += new System.EventHandler(this.btlathatatlan_Click);
            // 
            // BtRegistration
            // 
            this.BtRegistration.BackColor = System.Drawing.SystemColors.Window;
            this.BtRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtRegistration.Location = new System.Drawing.Point(192, 30);
            this.BtRegistration.Name = "BtRegistration";
            this.BtRegistration.Size = new System.Drawing.Size(109, 30);
            this.BtRegistration.TabIndex = 18;
            this.BtRegistration.Text = "Registration";
            this.BtRegistration.UseVisualStyleBackColor = false;
            this.BtRegistration.Click += new System.EventHandler(this.BtRegistration_Click);
            // 
            // txtemail
            // 
            this.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtemail.BottomBorderOnFocusColor = System.Drawing.Color.Blue;
            this.txtemail.ButtomBorderColor = System.Drawing.Color.Black;
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtemail.Location = new System.Drawing.Point(98, 91);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(180, 21);
            this.txtemail.TabIndex = 19;
            this.txtemail.TextChanged += new System.EventHandler(this.txtemail_TextChanged);
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpassword.BottomBorderOnFocusColor = System.Drawing.Color.Blue;
            this.txtpassword.ButtomBorderColor = System.Drawing.Color.Black;
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtpassword.Location = new System.Drawing.Point(98, 144);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(157, 21);
            this.txtpassword.TabIndex = 20;
            this.txtpassword.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel1.Location = new System.Drawing.Point(98, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 2);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel2.Location = new System.Drawing.Point(98, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 2);
            this.panel2.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Location = new System.Drawing.Point(35, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(133, 2);
            this.panel3.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(398, 277);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.BtRegistration);
            this.Controls.Add(this.btlathatatlan);
            this.Controls.Add(this.btlathato);
            this.Controls.Add(this.lbhelyese);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btlogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btlogin;
        private System.Windows.Forms.Label lbhelyese;
        private System.Windows.Forms.Button btlathato;
        private System.Windows.Forms.Button btlathatatlan;
        private System.Windows.Forms.Button BtRegistration;
        private SoftControlsLibrary.CustomBorder txtemail;
        private SoftControlsLibrary.CustomBorder txtpassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

