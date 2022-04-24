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
    public partial class Form1 : Form
    {

        //MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=note_app;");
        /*$cfg['Servers'][$i]['host'] = 'eu-cdbr-west-02.cleardb.net';
$cfg['Servers'][$i]['user'] = 'b7a161c4cbea52';
$cfg['Servers'][$i]['password'] = '388ed278';*/

        MySqlConnection con = new MySqlConnection("datasource=eu-cdbr-west-02.cleardb.net;username=b7a161c4cbea52;password=388ed278;database=heroku_afb9b8b1a529dbe;");
        int i;
        int error1 = 0;
        int error2 = 0;
        int error3 = 0;
        int error4 = 0;
        public static string email = "";
        public static int admin = 0;
        public static int note_id;
        string dani = "";
        string jozsef = "";


        private void btexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void txtemail_TextChanged(object sender, EventArgs e)
        {
            if (error3 == 1)
            {
                if (txtemail.Text != "")
                {
                    txtemail.BringToFront();
                }
            }
            if (error4 == 1)
            {
                if (txtemail.Text != "")
                {
                    txtemail.BringToFront();
                }
            }
            if (error2 == 1)
            {
                if (txtemail.Text != "")
                {
                    txtemail.BringToFront();
                }
            }
            else
            {
                txtemail.BringToFront();
            }
        }
        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            if (error3 == 1)
            {
                if (txtpassword.Text != "")
                {
                    txtpassword.BringToFront();
                }
            }
            if (error4 == 1)
            {
                if (txtpassword.Text != "")
                {
                    txtpassword.BringToFront();
                }
            }
            if (error2 == 1)
            {
                if (txtpassword.Text != "")
                {
                    txtpassword.BringToFront();
                }
            }
            if (error1 == 1)
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

        private void btlogin_Click(object sender, EventArgs e)
        {
            i = 0;
            string kapcsolatString21 = "datasource=eu-cdbr-west-02.cleardb.net;port=3306;username=b7a161c4cbea52;password=388ed278;database=heroku_afb9b8b1a529dbe;";
            // Select all
            string parancs21 = "SELECT `password` FROM `users` WHERE email='"+txtemail.Text+"'";
            string titkos_jelszo = "";
            MySqlConnection adatbKapcsolat21 = new MySqlConnection(kapcsolatString21);
            MySqlCommand commandDatabase21 = new MySqlCommand(parancs21, adatbKapcsolat21);
            commandDatabase21.CommandTimeout = 60;
            MySqlDataReader reader21;

            try
            {
                adatbKapcsolat21.Open();
                reader21 = commandDatabase21.ExecuteReader();

                if (reader21.HasRows)
                {
                    while (reader21.Read())
                    {
                        titkos_jelszo = (Convert.ToString(reader21.GetString(0)));
                    }
                }
                else
                {
                }

                adatbKapcsolat21.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (titkos_jelszo != "")
            {
                try
                {
                    bool isvalid = BCrypt.Net.BCrypt.Verify(txtpassword.Text, titkos_jelszo);
                    if (isvalid == true)
                    {
                        i = 1;
                        string parancs4 = "SELECT `id` FROM `users` WHERE `email` = '" + txtemail.Text + "'";
                        MySqlConnection adatbKapcsolat4 = new MySqlConnection(kapcsolatString21);
                        MySqlCommand commandDatabase4 = new MySqlCommand(parancs4, adatbKapcsolat4);
                        commandDatabase4.CommandTimeout = 60;
                        MySqlDataReader reader4;
                        try
                        {
                            adatbKapcsolat4.Open();
                            reader4 = commandDatabase4.ExecuteReader();

                            if (reader4.HasRows)
                            {
                                while (reader4.Read())
                                {
                                    note_id = (Convert.ToInt32(reader4.GetInt32(0)));
                                }
                            }
                            else
                            {

                            }

                            adatbKapcsolat4.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        string kapcsolatString = "datasource=eu-cdbr-west-02.cleardb.net;port=3306;username=b7a161c4cbea52;password=388ed278;database=heroku_afb9b8b1a529dbe;";

                        string admin1 = "SELECT `email` FROM `users` WHERE `id`=1";
                        MySqlConnection adatbKapcsolat = new MySqlConnection(kapcsolatString);
                        MySqlCommand commandDatabase = new MySqlCommand(admin1, adatbKapcsolat);
                        commandDatabase.CommandTimeout = 60;
                        MySqlDataReader reader;

                        try
                        {
                            adatbKapcsolat.Open();
                            reader = commandDatabase.ExecuteReader();

                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    jozsef = (Convert.ToString(reader.GetString(0)));
                                }
                            }
                            else
                            {

                            }

                            adatbKapcsolat.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }


                        string kapcsolatString2 = "datasource=eu-cdbr-west-02.cleardb.net;port=3306;username=b7a161c4cbea52;password=388ed278;database=heroku_afb9b8b1a529dbe;";

                        string admin2 = "SELECT `email` FROM `users` WHERE `id`=2";
                        
                        MySqlConnection adatbKapcsolat2 = new MySqlConnection(kapcsolatString2);
                        MySqlCommand commandDatabase2 = new MySqlCommand(admin2, adatbKapcsolat2);
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
                                    dani = (Convert.ToString(reader2.GetString(0)));
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
                        if (txtemail.Text == jozsef && i == 1)
                        {
                            admin = 1;
                        }
                        if (txtemail.Text == dani && i == 1)
                        {

                            admin = 1;
                        }
                    }
                    else
                    {
                    }
                }
                catch
                {

                }  
            }
            
            if (txtpassword.Text != "" && txtemail.Text != "" && i == 0)
            {
                lbhelyese.Text = "Wrong email or password!";
                txtemail.Text = "";
                txtpassword.Text = "";
                error3 = 1;
                lbhelyese.ForeColor = Color.Red;
                panel1.BringToFront();
                panel2.BringToFront();
                panel1.BackColor = Color.Red;
                panel2.BackColor = Color.Red;
            }

            if (txtemail.Text != "" && txtpassword.Text == "")
            {
                error1 = 1;
                lbhelyese.Text = "Please add your password!";
                txtpassword.Text = "";
                lbhelyese.ForeColor = Color.Red;
                panel1.BringToFront();
                panel1.BackColor = Color.Red;
            }
            if(error3 != 1)
            {
                lbhelyese.Text = "Please fill all the text boxes!";
                txtemail.Text = "";
                txtpassword.Text = "";
                error2 = 1;
                lbhelyese.ForeColor = Color.Red;
                panel1.BringToFront();
                panel2.BringToFront();
                panel1.BackColor = Color.Red;
                panel2.BackColor = Color.Red;
            }
            

           
            

            
            if (i == 1)
            {
                
                email = txtemail.Text;
                Form2 F2 = new Form2();
                F2.Show();
                this.Hide();
            }
        }
        private void btlathatatlan_Click(object sender, EventArgs e)
        {
            if(txtpassword.PasswordChar=='*')
            {
                btlathato.BringToFront();
                txtpassword.PasswordChar = '\0';
            }
        }
        private void btlathato_Click(object sender, EventArgs e)
        {
            if (txtpassword.PasswordChar == '\0')
            {
                btlathatatlan.BringToFront();
                txtpassword.PasswordChar = '*';
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            BtRegistration.TabStop = false;
            BtRegistration.FlatStyle = FlatStyle.Flat;
            BtRegistration.FlatAppearance.BorderSize = 0;
            
        }
        private void BtRegistration_Click(object sender, EventArgs e)
        {
            Form3 F3 = new Form3();
            F3.Show();
            this.Hide();
        }
        public Form1()
        {
            InitializeComponent();
            if (Form3.number == 1)
            {
                lbhelyese.ForeColor = Color.Green;
                lbhelyese.Text = "Successfull registration!";
            }
            else if(Form3.number2 == 1)
            {
                lbhelyese.Text = "";
            }
            if (Form2.number == 1)
            {
                lbhelyese.Text = "";
                Form2.number = 0;
            }
        }
    }
}
