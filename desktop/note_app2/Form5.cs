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
    public partial class Form5 : Form
    {
        List<string> username = new List<string>();
        string email = Form1.email;
        int note_id = Form2.noteid;
        int i = 0;
        int emtytxt = 0;


        private void current_note()
        {
            string kapcsolatString = "datasource=127.0.0.1;port=3306;username=root;password=;database=note_app;";
            string parancs3 = "SELECT shares.email FROM `notes`,shares,users WHERE `user_id`= users.id AND users.email = '" + email + "' AND shares.note_id = '" + note_id + "' AND shared=1  GROUP BY shares.email ";

            MySqlConnection adatbKapcsolat3 = new MySqlConnection(kapcsolatString);
            MySqlCommand commandDatabase3 = new MySqlCommand(parancs3, adatbKapcsolat3);
            commandDatabase3.CommandTimeout = 60;
            MySqlDataReader reader3;

            try
            {
                adatbKapcsolat3.Open();
                reader3 = commandDatabase3.ExecuteReader();

                if (reader3.HasRows)
                {
                    while (reader3.Read())
                    {
                        username.Add(Convert.ToString(reader3.GetString(0)));
                    }
                }
                else
                {

                }

                adatbKapcsolat3.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            for (int i = 0; i < username.Count; i++)
            {
                class4BindingSource.Add(new Class4() { Username = username[i] });
            }
        }

        private void share()
        {
            MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=note_app;");
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM note_app.users WHERE email = '" + txtemail.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            con.Close();


            int j = 0;
            string kapcsolatString2 = "datasource=127.0.0.1;port=3306;username=root;password=;database=note_app;";
            string parancs3 = "SELECT COUNT(email) FROM note_app.shares WHERE email = '" + txtemail.Text + "' AND note_id = '" + note_id + "'";

            MySqlConnection adatbKapcsolat3 = new MySqlConnection(kapcsolatString2);
            MySqlCommand commandDatabase3 = new MySqlCommand(parancs3, adatbKapcsolat3);
            commandDatabase3.CommandTimeout = 60;
            MySqlDataReader reader3;

            try
            {
                adatbKapcsolat3.Open();
                reader3 = commandDatabase3.ExecuteReader();

                if (reader3.HasRows)
                {
                    while (reader3.Read())
                    {
                        j = (Convert.ToInt32(reader3.GetInt32(0)));
                    }
                }
                else
                {

                }

                adatbKapcsolat3.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (txtemail.Text == "")
            {
                emtytxt = 1;
                panel1.BringToFront();
                panel1.BackColor = Color.Red;
                label1.ForeColor = Color.Red;
                label1.Text = "Please fill both of the text box!";
            }

            else if (txtemail.Text == email)
            {
                emtytxt = 1;
                panel1.BringToFront();
                panel1.BackColor = Color.Red;
                label1.ForeColor = Color.Red;
                label1.ForeColor = Color.Red;
                label1.Text = "You are not able to share with yourself!";
                txtemail.Text = "";
            }
            else if (j == 1)
            {
                emtytxt = 1;
                panel1.BringToFront();
                panel1.BackColor = Color.Red;
                label1.ForeColor = Color.Red;
                label1.ForeColor = Color.Red;
                label1.Text = "You have alredy shared with: "+ txtemail.Text;
                txtemail.Text = "";
            }

            else if (i == 1)
            {

                label1.ForeColor = Color.Green;
                label1.Text = "You  have successfully shared";
                string kapcsolatString = "datasource=127.0.0.1;port=3306;username=root;password=;database=note_app;";
                string parancs = "UPDATE `notes` SET `shared` = '1' WHERE `notes`.`note_id` = '" + note_id + "'";
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

                string parancs2 = "INSERT INTO `shares` (`note_id`, `email`) VALUES ('" + note_id + "','" + txtemail.Text + "');";
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
                txtemail.Text = "";

            }
            else if (i == 0)
            {
                txtemail.Text = "";
                emtytxt = 1;
                panel1.BringToFront();
                panel1.BackColor = Color.Red;
                label1.ForeColor = Color.Red;
                label1.Text = "Please enter the email address correctly!";
            }

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {
            if(txtemail.Text != "")
            {
                txtemail.BringToFront();
            }
            else
            {
                label5.BringToFront();
            }
            if (txtemail.Text != "")
            {
                txtemail.BringToFront();
            }

            if (emtytxt == 1)
            {
                if (txtemail.Text != "")
                {
                    txtemail.BringToFront();
                }
            }

        }

        public Form5()
        {
            InitializeComponent();
            current_note();
            Btback.TabStop = false;
            Btback.FlatStyle = FlatStyle.Flat;
            Btback.FlatAppearance.BorderSize = 0;

            BtShare.TabStop = false;
            BtShare.FlatStyle = FlatStyle.Flat;
            BtShare.FlatAppearance.BorderSize = 0;
        }

        private void Btback_Click(object sender, EventArgs e)
        {
            string kapcsolatString = "datasource=127.0.0.1;port=3306;username=root;password=;database=note_app;";
            string parancs = "SELECT COUNT(`note_id`) FROM `shares` WHERE shares.note_id = '" + note_id + "'";
            int number = 0;
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
                        number=(Convert.ToInt32(reader.GetInt32(0)));
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
            if(number == 0)
            {
                string parancs2 = "UPDATE `notes` SET `shared` = '0' WHERE `notes`.`note_id` = '" + note_id + "'";
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
            }
            Form2 F2 = new Form2();
            F2.Show();
            this.Hide();
        }

        private void BtShare_Click(object sender, EventArgs e)
        {
            share();
            dataGridView1.Rows.Clear();
            username.Clear();
            current_note();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Btback.TabStop = false;
            Btback.FlatStyle = FlatStyle.Flat;
            Btback.FlatAppearance.BorderSize = 0;
        }

       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.Value.ToString() == "Unshare with")
            {
                int row = dataGridView1.CurrentCell.RowIndex;
                string mail_address = username[row];
                string message = "Do you want to unshare this note with " + mail_address + '?';
                string title = "Unshare";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    string kapcsolatString = "datasource=127.0.0.1;port=3306;username=root;password=;database=note_app;";
                    string parancs = "DELETE FROM `shares` WHERE `note_id` = '"+ note_id +"' AND `email` = '" + mail_address + "'";
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
                    dataGridView1.Rows.RemoveAt(row);
                }
                else
                {

                }
            }
        }
    }
}
