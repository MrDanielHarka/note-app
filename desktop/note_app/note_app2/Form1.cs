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

        MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=note_app;");
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
        int btdb3 = 0;

        private void btreg()
        {
            panel6.BringToFront();
            panel8.BringToFront();
            btpublic.BackColor = Color.FromArgb(51, 51, 76);
            label4.Text = "Login/Registration";
            loginbt.BackColor = Color.Blue;
            panel4.BackColor = Color.Blue;
            panel7.BackColor = Color.DarkBlue;
        }

        private void publcal_notes()
        {
            btdb3++;
            List<string> title = new List<string>();
            List<string> content = new List<string>();
            string kapcsolatString = "datasource=127.0.0.1;port=3306;username=root;password=;database=note_app;";


            string parancs = "SELECT notes.title FROM `notes` WHERE notes.public = 1";
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
                        title.Add(Convert.ToString(reader.GetString(0)));
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

            string parancs2 = "SELECT notes.content FROM `notes` WHERE notes.public = 1";
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
                        content.Add(Convert.ToString(reader2.GetString(0)));
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
            // publikus
            for (int i = 0; i < content.Count; i++)
            {
                string phrase = content[i];
                string[] words = phrase.Split(' ');
                string text = "";
                int counter1 = 0;
                int counter2 = 0;
                int counter3 = 0;
                int counter4 = 0;
                foreach (var word in words)
                {
                    text = text + " " + word;
                    counter1++;
                    counter4++;
                    for (int j = 0; j < words.Length; j++)
                    {
                        counter3++;
                    }
                    if (counter3 < 5 && counter4 == 1)
                    {
                        class2BindingSource2.Add(new Class2() { Note_Title = title[i], Note_Content = content[i] });
                    }
                    if (counter1 > 5)
                    {
                        counter2++;
                        if (counter2 == 1)
                        {
                            class2BindingSource2.Add(new Class2() { Note_Title = title[i], Note_Content = text });
                        }
                        else
                        {
                            class2BindingSource2.Add(new Class2() { Note_Title = "", Note_Content = text });
                        }
                        text = "";
                        counter1 = 0;
                    }
                }
            }
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
            if (txtpassword.Text != "")
            {
                btlathato.BringToFront();
                btlathatatlan.BringToFront();
            }
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
            string kapcsolatString21 = "datasource=127.0.0.1;port=3306;username=root;password=;database=note_app;";
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
                        Form3.number3 = 0;
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

                        string kapcsolatString = "datasource=127.0.0.1;port=3306;username=root;password=;database=note_app;";

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


                        string kapcsolatString2 = "datasource=127.0.0.1;port=3306;username=root;password=;database=note_app;";

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
                        else if (txtemail.Text == dani && i == 1)
                        {
                            admin = 1;
                        }
                        else
                        {
                            admin = 0;
                        }
                        email = txtemail.Text;
                        Form2 F2 = new Form2();
                        F2.Show();
                        this.Hide();
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
            btlathatatlan.BringToFront();
            if(Form3.number3 == 1)
            {
                btreg();
            }
            BtRegistration.TabStop = false;
            BtRegistration.FlatStyle = FlatStyle.Flat;
            BtRegistration.FlatAppearance.BorderSize = 0;

            btexit.TabStop = false;
            btexit.FlatStyle = FlatStyle.Flat;
            btexit.FlatAppearance.BorderSize = 0;

            loginbt.TabStop = false;
            loginbt.FlatStyle = FlatStyle.Flat;
            loginbt.FlatAppearance.BorderSize = 0;

            btpublic.TabStop = false;
            btpublic.FlatStyle = FlatStyle.Flat;
            btpublic.FlatAppearance.BorderSize = 0;
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
        

        private void loginbt_Click(object sender, EventArgs e)
        {
            btreg();
            Form3.number3 = 1;
        }
       
        private void btpublic_Click(object sender, EventArgs e)
        {
            panel6.BringToFront();
            dataGridView2.BringToFront();

            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.Red;

            if (btdb3 == 0)
            {
                publcal_notes();
            }
            else
            {
                dataGridView2.Rows.Clear();
                publcal_notes();
            }
            loginbt.BackColor = Color.FromArgb(51, 51, 76);
            label4.Text = "Public notes";
            btpublic.BackColor = Color.Red;
            panel4.BackColor = Color.Red;
            panel7.BackColor = Color.DarkRed;

        }

        private void btexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
