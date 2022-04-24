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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        int error = 0;
        string email = Form1.email;
        int userid = Form1.note_id;   
        private void btexit_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
            F2.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            btexit.TabStop = false;
            btexit.FlatStyle = FlatStyle.Flat;
            btexit.FlatAppearance.BorderSize = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=eu-cdbr-west-02.cleardb.net;port=3306;username=b7a161c4cbea52;password=388ed278;database=heroku_afb9b8b1a529dbe;");
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


            string kapcsolatString = "datasource=eu-cdbr-west-02.cleardb.net;port=3306;username=b7a161c4cbea52;password=388ed278;database=heroku_afb9b8b1a529dbe;";
            string useramail = "";
            string parancs = "SELECT `email` FROM `users` WHERE `id` = '" + userid + "'";
            MySqlConnection adatbKapcsolat = new MySqlConnection(kapcsolatString);
            MySqlCommand commandDatabase = new MySqlCommand(parancs, adatbKapcsolat);
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
                        useramail = (Convert.ToString(reader.GetString(0)));
                    }
                }

                adatbKapcsolat.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (txtemail.Text == "")
            {
                error = 1;
                label1.Text = "Please fill the text box!";
                panel1.BringToFront();
                panel1.BackColor = Color.Red;
                label1.ForeColor = Color.Red;
            }
            else if (l == 1 && txtemail.Text != useramail)
            {
                error = 1;
                label1.Text = "This e-mail is already used by someone!";
                txtemail.Text = "";
                panel1.BringToFront();
                panel1.BackColor = Color.Red;
                label1.ForeColor = Color.Red;
                MessageBox.Show(useramail);
                
            }
            else if (txtemail.Text == useramail)
            {
                error = 1;
                label1.Text = "You are not able to change your email to your old one!";
                panel1.BringToFront();
                panel1.BackColor = Color.Red;
                label1.ForeColor = Color.Red;
            }
            else 
            {
                

                string parancs2 = "UPDATE `users` SET `email` = '" + txtemail.Text + "' WHERE `users`.`id` = '" + userid + "'";
                MySqlConnection adatbKapcsolat2 = new MySqlConnection(kapcsolatString);
                MySqlCommand commandDatabase2 = new MySqlCommand(parancs2, adatbKapcsolat2);
                commandDatabase2.CommandTimeout = 60;
                try
                {
                    adatbKapcsolat2.Open();
                    commandDatabase2.ExecuteNonQuery();
                    adatbKapcsolat2.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show("You have successfully changed your email!");
                Form2 F2 = new Form2();
                F2.Show();
                this.Hide();
            }
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {
            if (error == 1)
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
    }
}
