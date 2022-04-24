using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace note_app2
{
    public partial class Form6 : Form
    {
        public static int number = 0;
        public Form6()
        {
            InitializeComponent();
        }
        string email = Form1.email;
        int error = 0;
        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            if (error == 1)
            {
                if (txtpassword.Text != "")
                {
                    txtpassword.BringToFront();
                }
            }
            else
            {
                txtpassword.BringToFront();
            }
        }

        private void txtpassword2_TextChanged(object sender, EventArgs e)
        {
            if (error == 1)
            {
                if (txtpassword2.Text != "")
                {
                    txtpassword2.BringToFront();
                }
            }
            else
            {
                txtpassword2.BringToFront();
            }
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            btexit.BringToFront();
            btexit.TabStop = false;
            btexit.FlatStyle = FlatStyle.Flat;
            btexit.FlatAppearance.BorderSize = 0;

            button3.TabStop = false;
            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string o_password = "";
            string kapcsolatString = "datasource=eu-cdbr-west-02.cleardb.net;port=3306;username=b7a161c4cbea52;password=388ed278;database=heroku_afb9b8b1a529dbe;";
            string parancs2 = "SELECT `password` FROM `users` WHERE `email`= '"+email+"'";

            MySqlConnection adatbKapcsolat2 = new MySqlConnection(kapcsolatString);
            MySqlCommand commandDatabase2 = new MySqlCommand(parancs2, adatbKapcsolat2);
            commandDatabase2.CommandTimeout = 60;
            MySqlDataReader reader2;
            try
            {
                adatbKapcsolat2.Open();
                reader2 = commandDatabase2.ExecuteReader();

                if (reader2.HasRows)
                {
                    while (reader2.Read())
                    {
                        o_password = (Convert.ToString(reader2.GetString(0)));
                    }
                }
                else
                {

                }

                adatbKapcsolat2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            int i = 0;

             try
                {
                    bool isvalid = BCrypt.Net.BCrypt.Verify(txtpassword.Text, o_password);
                    if (isvalid == true)
                    {
                        i = 1;
                    }
                    else
                    {
                    }
                }
                catch
                {

                }

            string password = txtpassword.Text;

            if(txtpassword.Text == "" || txtpassword2.Text == "")
            {
                label1.Text = "Please fill both of the textbox!";
                label1.ForeColor = Color.Red;
                txtpassword.Text = "";
                txtpassword2.Text = "";
                error = 1;
                panel1.BringToFront();
                panel1.BackColor = Color.Red;
                panel3.BringToFront();
                panel3.BackColor = Color.Red;
            }
            else if(txtpassword.Text != txtpassword2.Text)
            {
                label1.Text = "The password are note the same!";
                label1.ForeColor = Color.Red;
                txtpassword.Text = "";
                txtpassword2.Text = "";
                error = 1;
                panel1.BringToFront();
                panel1.BackColor = Color.Red;
                panel3.BringToFront();
                panel3.BackColor = Color.Red;

            }
            else if(i == 1)
            {
                label1.Text = "Your new password can not be the old one!";
                label1.ForeColor = Color.Red;
                txtpassword.Text = "";
                txtpassword2.Text = "";
                error = 1;
                panel1.BringToFront();
                panel1.BackColor = Color.Red;
                panel3.BringToFront();
                panel3.BackColor = Color.Red;

            }
            else
            {
                string parancs = "UPDATE `users` SET `password` = '" + BCrypt.Net.BCrypt.HashPassword(txtpassword.Text) + "' WHERE `email`= '" + email + "'";
                MySqlConnection adatbKapcsolat = new MySqlConnection(kapcsolatString);
                MySqlCommand commandDatabase = new MySqlCommand(parancs, adatbKapcsolat);
                commandDatabase.CommandTimeout = 60;
                try
                {
                    adatbKapcsolat.Open();
                    commandDatabase.ExecuteNonQuery();
                    adatbKapcsolat.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                number = 1;
                Form2 F2 = new Form2();
                F2.Show();
                this.Hide();
            }
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
            F2.Show();
            this.Hide();
        }

        private void btlathato_Click(object sender, EventArgs e)
        {
            if (txtpassword.PasswordChar == '\0')
            {
                btlathatatlan.BringToFront();
                txtpassword.PasswordChar = '*';
            }
        }

        private void btlathatatlan_Click(object sender, EventArgs e)
        {
            if (txtpassword.PasswordChar == '*')
            {
                btlathato.BringToFront();
                txtpassword.PasswordChar = '\0';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtpassword2.PasswordChar == '\0')
            {
                button1.BringToFront();
                txtpassword2.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            if (txtpassword2.PasswordChar == '*')
            {
                button2.BringToFront();
                txtpassword2.PasswordChar = '\0';
            }
        }
    }
}
