namespace note_app2
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.BtBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtRegistration = new System.Windows.Forms.Button();
            this.BtLathato = new System.Windows.Forms.Button();
            this.BtLathatatlan = new System.Windows.Forms.Button();
            this.BtVisible = new System.Windows.Forms.Button();
            this.BtInvisible = new System.Windows.Forms.Button();
            this.txtemail = new SoftControlsLibrary.CustomBorder();
            this.txtpassword2 = new SoftControlsLibrary.CustomBorder();
            this.txtjelszoujra2 = new SoftControlsLibrary.CustomBorder();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LbCheck = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtBack
            // 
            this.BtBack.BackColor = System.Drawing.SystemColors.Window;
            this.BtBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtBack.Location = new System.Drawing.Point(72, 37);
            this.BtBack.Name = "BtBack";
            this.BtBack.Size = new System.Drawing.Size(76, 28);
            this.BtBack.TabIndex = 1;
            this.BtBack.Text = "Login";
            this.BtBack.UseVisualStyleBackColor = false;
            this.BtBack.Click += new System.EventHandler(this.BtBack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(200, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Registration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Password confirmation";
            // 
            // BtRegistration
            // 
            this.BtRegistration.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtRegistration.Location = new System.Drawing.Point(145, 300);
            this.BtRegistration.Name = "BtRegistration";
            this.BtRegistration.Size = new System.Drawing.Size(75, 23);
            this.BtRegistration.TabIndex = 30;
            this.BtRegistration.Text = "Registration";
            this.BtRegistration.UseVisualStyleBackColor = false;
            this.BtRegistration.Click += new System.EventHandler(this.BtRegistration_Click);
            // 
            // BtLathato
            // 
            this.BtLathato.BackColor = System.Drawing.Color.Red;
            this.BtLathato.Location = new System.Drawing.Point(302, 180);
            this.BtLathato.Name = "BtLathato";
            this.BtLathato.Size = new System.Drawing.Size(23, 23);
            this.BtLathato.TabIndex = 32;
            this.BtLathato.UseVisualStyleBackColor = false;
            this.BtLathato.Click += new System.EventHandler(this.BtLathato_Click);
            // 
            // BtLathatatlan
            // 
            this.BtLathatatlan.BackColor = System.Drawing.Color.Blue;
            this.BtLathatatlan.Location = new System.Drawing.Point(302, 180);
            this.BtLathatatlan.Name = "BtLathatatlan";
            this.BtLathatatlan.Size = new System.Drawing.Size(23, 23);
            this.BtLathatatlan.TabIndex = 33;
            this.BtLathatatlan.UseVisualStyleBackColor = false;
            this.BtLathatatlan.Click += new System.EventHandler(this.BtLathatatlan_Click);
            // 
            // BtVisible
            // 
            this.BtVisible.BackColor = System.Drawing.Color.Red;
            this.BtVisible.Location = new System.Drawing.Point(302, 221);
            this.BtVisible.Name = "BtVisible";
            this.BtVisible.Size = new System.Drawing.Size(23, 23);
            this.BtVisible.TabIndex = 34;
            this.BtVisible.UseVisualStyleBackColor = false;
            this.BtVisible.Click += new System.EventHandler(this.BtVisible_Click);
            // 
            // BtInvisible
            // 
            this.BtInvisible.BackColor = System.Drawing.Color.Blue;
            this.BtInvisible.Location = new System.Drawing.Point(302, 221);
            this.BtInvisible.Name = "BtInvisible";
            this.BtInvisible.Size = new System.Drawing.Size(23, 23);
            this.BtInvisible.TabIndex = 35;
            this.BtInvisible.UseVisualStyleBackColor = false;
            this.BtInvisible.Click += new System.EventHandler(this.BtInvisible_Click);
            // 
            // txtemail
            // 
            this.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtemail.BottomBorderOnFocusColor = System.Drawing.Color.Blue;
            this.txtemail.ButtomBorderColor = System.Drawing.Color.Black;
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtemail.Location = new System.Drawing.Point(145, 135);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(180, 21);
            this.txtemail.TabIndex = 36;
            this.txtemail.TextChanged += new System.EventHandler(this.txtemail_TextChanged);
            // 
            // txtpassword2
            // 
            this.txtpassword2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpassword2.BottomBorderOnFocusColor = System.Drawing.Color.Blue;
            this.txtpassword2.ButtomBorderColor = System.Drawing.Color.Black;
            this.txtpassword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtpassword2.Location = new System.Drawing.Point(145, 182);
            this.txtpassword2.Name = "txtpassword2";
            this.txtpassword2.PasswordChar = '*';
            this.txtpassword2.Size = new System.Drawing.Size(157, 21);
            this.txtpassword2.TabIndex = 37;
            this.txtpassword2.TextChanged += new System.EventHandler(this.txtpassword2_TextChanged);
            // 
            // txtjelszoujra2
            // 
            this.txtjelszoujra2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtjelszoujra2.BottomBorderOnFocusColor = System.Drawing.Color.Blue;
            this.txtjelszoujra2.ButtomBorderColor = System.Drawing.Color.Black;
            this.txtjelszoujra2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtjelszoujra2.Location = new System.Drawing.Point(145, 223);
            this.txtjelszoujra2.Name = "txtjelszoujra2";
            this.txtjelszoujra2.PasswordChar = '*';
            this.txtjelszoujra2.Size = new System.Drawing.Size(157, 21);
            this.txtjelszoujra2.TabIndex = 38;
            this.txtjelszoujra2.TextChanged += new System.EventHandler(this.txtjelszoujra2_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel2.Location = new System.Drawing.Point(145, 154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 2);
            this.panel2.TabIndex = 42;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel1.Location = new System.Drawing.Point(145, 201);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 2);
            this.panel1.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel3.Location = new System.Drawing.Point(145, 242);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(157, 2);
            this.panel3.TabIndex = 43;
            // 
            // LbCheck
            // 
            this.LbCheck.AutoSize = true;
            this.LbCheck.Location = new System.Drawing.Point(103, 250);
            this.LbCheck.Name = "LbCheck";
            this.LbCheck.Size = new System.Drawing.Size(0, 13);
            this.LbCheck.TabIndex = 44;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel4.Location = new System.Drawing.Point(183, 62);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(133, 2);
            this.panel4.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(209, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "E-mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(200, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Location = new System.Drawing.Point(200, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Password";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(398, 347);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.LbCheck);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtjelszoujra2);
            this.Controls.Add(this.txtpassword2);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.BtInvisible);
            this.Controls.Add(this.BtVisible);
            this.Controls.Add(this.BtLathatatlan);
            this.Controls.Add(this.BtLathato);
            this.Controls.Add(this.BtRegistration);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "REGISTRATION";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtRegistration;
        private System.Windows.Forms.Button BtLathato;
        private System.Windows.Forms.Button BtLathatatlan;
        private System.Windows.Forms.Button BtVisible;
        private System.Windows.Forms.Button BtInvisible;
        private SoftControlsLibrary.CustomBorder txtemail;
        private SoftControlsLibrary.CustomBorder txtpassword2;
        private SoftControlsLibrary.CustomBorder txtjelszoujra2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LbCheck;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}