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
    public partial class Form3 : Form
    {
        public static int number = 0;
        public static int number2 = 0;
        public Form3()
        {
            InitializeComponent();
        }
        int empty_email = 0;
        int empty_passsword = 0;
        int empty_rpassword = 0;
        MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=note_app;");
        private void BtBack_Click(object sender, EventArgs e)
        {
            number2 = 1;
            Form1 F1 = new Form1();
            F1.Show();
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            BtBack.TabStop = false;
            BtBack.FlatStyle = FlatStyle.Flat;
            BtBack.FlatAppearance.BorderSize = 0;
        }
        private void BtLathatatlan_Click(object sender, EventArgs e)
        {
            if (txtpassword2.PasswordChar == '*')
            {
                BtLathato.BringToFront();
                txtpassword2.PasswordChar = '\0';
            }
        }

        private void BtLathato_Click(object sender, EventArgs e)
        {
            if (txtpassword2.PasswordChar == '\0')
            {
                BtLathatatlan.BringToFront();
                txtpassword2.PasswordChar = '*';
            }
        }

        private void BtInvisible_Click(object sender, EventArgs e)
        {
            if (txtjelszoujra2.PasswordChar == '*')
            {
                BtVisible.BringToFront();
                txtjelszoujra2.PasswordChar = '\0';
            }
        }

        private void BtVisible_Click(object sender, EventArgs e)
        {
            if (txtjelszoujra2.PasswordChar == '\0')
            {
                BtInvisible.BringToFront();
                txtjelszoujra2.PasswordChar = '*';
            }
        }
        private void BtRegistration_Click(object sender, EventArgs e)
        {
            regisztracio();
        }

        int error1 = 0;
        int error2 = 0;
        int error3 = 0;
        int error4 = 0;
        private void txtemail_TextChanged(object sender, EventArgs e)
        {
            if(error3 == 1)
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
            else
            {
                txtemail.BringToFront();
            }
        }

        private void txtpassword2_TextChanged(object sender, EventArgs e)
        {
            if(error1 == 1)
            {
                if(txtpassword2.Text != "")
                {
                    txtpassword2.BringToFront();
                }
            }
            if(error3 == 1)
            {
                if (txtpassword2.Text != "")
                {
                    txtpassword2.BringToFront();
                }
            }
            if (error4 == 1)
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

        private void txtjelszoujra2_TextChanged(object sender, EventArgs e)
        {
            if (error1 == 1)
            {
                if (txtjelszoujra2.Text != "")
                {
                    txtjelszoujra2.BringToFront();
                }

            }
            if (error2 == 1)
            {
                if (txtjelszoujra2.Text != "")
                {
                    txtjelszoujra2.BringToFront();
                }
            }
            if (error3 == 1)
            {
                if (txtjelszoujra2.Text != "")
                {
                    txtjelszoujra2.BringToFront();
                }
            }
            if (error4 == 1)
            {
                if (txtjelszoujra2.Text != "")
                {
                    txtjelszoujra2.BringToFront();
                }
            }
            else
            {
                txtjelszoujra2.BringToFront();
            }
        }
         
        private void regisztracio()
        {
            int error5 = 0;
            string kapcsolatString = "datasource=127.0.0.1;port=3306;username=root;password=;database=note_app;";

            string jelszo = txtpassword2.Text;
            HashSet<char> karakterek = new HashSet<char>();
            bool bennevan = false;

            foreach (char betu in jelszo)
            {

            }

            string parancs = null;
            if (txtpassword2.Text == txtjelszoujra2.Text || bennevan == true)
            {
                parancs = "INSERT INTO users(id,email,password)" + "VALUES (NULL, '" + txtemail.Text + "', '" + BCrypt.Net.BCrypt.HashPassword(txtpassword2.Text) + "')";
            }
           

            MySqlConnection adatbKapcsolat = new MySqlConnection(kapcsolatString);
            MySqlCommand commandDatabase = new MySqlCommand(parancs, adatbKapcsolat);
            commandDatabase.CommandTimeout = 60;
            if (true)
            {
                if(txtemail.Text == "")
                {
                    empty_email = 1;
                }
                else
                {
                    empty_email = 0;
                }

                if (txtpassword2.Text == "")
                {
                    empty_passsword = 1;
                }
                else
                {
                    empty_passsword = 0;
                }

                if(txtjelszoujra2.Text == "")
                {
                    empty_rpassword = 1;
                }
                else
                {

                    empty_rpassword = 0;
                }
            }
            if (txtjelszoujra2.Text != "" && txtpassword2.Text != "" && txtpassword2.Text != txtjelszoujra2.Text && txtemail.Text != "")
            {
                LbCheck.Text = "The two passwords are have to be the same!";
                txtpassword2.Text = "";
                txtjelszoujra2.Text = "";
                LbCheck.ForeColor = Color.Red;
                error1 = 1;
                error5 = 1;
                panel1.BringToFront();
                panel3.BringToFront();
                panel1.BackColor = Color.Red;
                panel3.BackColor = Color.Red;
            }
            else if (empty_rpassword+empty_passsword+empty_email == 3 || empty_rpassword + empty_passsword + empty_email == 2 || empty_email == 1 || empty_passsword == 1)
            {
                LbCheck.Text = "Please fill all of the text boxes!";
                txtemail.Text = "";
                txtpassword2.Text = "";
                txtjelszoujra2.Text = "";
                LbCheck.ForeColor = Color.Red;
                error3 = 1;
                panel1.BringToFront();
                panel2.BringToFront();
                panel3.BringToFront();
                panel1.BackColor = Color.Red;
                panel2.BackColor = Color.Red;
                panel3.BackColor = Color.Red;

            }
            if(empty_rpassword == 1 && empty_passsword+empty_email == 0)
            {
                LbCheck.Text = "Please add your password one more time!";
                error2 = 1;
                LbCheck.ForeColor = Color.Red;
                panel3.BringToFront();
                panel3.BackColor = Color.Red;
                txtjelszoujra2.Text = "";
            }
            if (txtemail.Text != "" && txtpassword2.Text != "" && txtjelszoujra2.Text != "")
            {
                try
                {
                    if(error1 == 0 || error5 == 0)
                    { 
                        int l = 0;
                        con.Open();
                        MySqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "SELECT * FROM note_app.users WHERE email = '" + txtemail.Text + "'";
                        cmd.ExecuteNonQuery();
                        DataTable dt = new DataTable();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        da.Fill(dt);
                        l = Convert.ToInt32(dt.Rows.Count.ToString());
                        con.Close();
                        if (l == 0)
                        {
                            number = 1;
                            adatbKapcsolat.Open();
                            MySqlDataReader myReader = commandDatabase.ExecuteReader();
                            adatbKapcsolat.Close();
                            Form1 F1 = new Form1();
                            F1.Show();
                            this.Hide();
                        }
                        else
                        {
                                error4 = 1;
                                LbCheck.Text = "This email is already used by someone else!";
                                LbCheck.ForeColor = Color.Red;
                                panel1.BringToFront();
                                panel2.BringToFront();
                                panel3.BringToFront();
                                panel1.BackColor = Color.Red;
                                panel2.BackColor = Color.Red;
                                panel3.BackColor = Color.Red;
                                txtemail.Text = "";
                                txtpassword2.Text = "";
                                txtjelszoujra2.Text = "";
                        }
                        error5 = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}