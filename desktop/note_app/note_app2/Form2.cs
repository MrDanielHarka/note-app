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
using System.IO;

namespace note_app2
{
    public partial class Form2 : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=note_app;");
        public Form2()
        {
            if(Form6.number == 1)
            {
                Form6.number = 0;
                MessageBox.Show("You have successfully changed your password!");
            }
     
            InitializeComponent();
        }
        public static int number = 0;
        private void btexit_Click(object sender, EventArgs e)
        {
            number = 1;
            Form1 F1 = new Form1();
            F1.Show();
            this.Close();
        }
        List<int> numbers = new List<int>();

        private void Form2_Load(object sender, EventArgs e)
        {
            numbers.Add(0);

            if (Form1.admin == 1)
            {
                BtSettings.Location = new Point(0, 333);
                panel5.Location = new Point(0, 376);
                BtChangepass.Location = new Point(0, 376);
                BtChangeemail.Location = new Point(0, 419);
            }
            BtSettings.BringToFront();
            
            panel3.BringToFront();

            button1.TabStop = false;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;

            button2.TabStop = false;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;

            button3.TabStop = false;
            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 0;

            BtSettings.TabStop = false;
            BtSettings.FlatStyle = FlatStyle.Flat;
            BtSettings.FlatAppearance.BorderSize = 0;

            BtChangepass.TabStop = false;
            BtChangepass.FlatStyle = FlatStyle.Flat;
            BtChangepass.FlatAppearance.BorderSize = 0;

            BtChangeemail.TabStop = false;
            BtChangeemail.FlatStyle = FlatStyle.Flat;
            BtChangeemail.FlatAppearance.BorderSize = 0;

            btexit.TabStop = false;
            btexit.FlatStyle = FlatStyle.Flat;
            btexit.FlatAppearance.BorderSize = 0;

            Btadmin.TabStop = false;
            Btadmin.FlatStyle = FlatStyle.Flat;
            Btadmin.FlatAppearance.BorderSize = 0;

            newnoteBt.TabStop = false;
            newnoteBt.FlatStyle = FlatStyle.Flat;
            newnoteBt.FlatAppearance.BorderSize = 0;
        }
        string email = Form1.email;
        int userid = Form1.note_id;
        List<int> Note_id = new List<int>();
        List<int> Publical = new List<int>();
        List<string> Fcolumn = new List<string>();

        int btdb = 0;
        int btdb2 = 0;
        int btdb3 = 0;
        int btdb4 = 0;

        List<string> title = new List<string>();
        List<string> content = new List<string>();
        List<int> shared = new List<int>();
        int counter = 0;

        public static int noteid = 0;

        private void notes()
        {
                btdb++;
                string kapcsolatString = "datasource=127.0.0.1;port=3306;username=root;password=;database=note_app;";
               

                string parancs2 = "SELECT `title` FROM `notes`,`users` WHERE `user_id`= users.id AND users.id ='" + userid + "'";

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
                            title.Add(Convert.ToString(reader2.GetString(0)));
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
                // content

                string parancs3 = "SELECT `content` FROM `notes`,`users` WHERE `user_id`= users.id AND users.id ='" + userid + "'";

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
                            content.Add(Convert.ToString(reader3.GetString(0)));
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
                //public
                string parancs4 = "SELECT `public` FROM `notes`,`users` WHERE `user_id`= users.id AND users.id ='" + userid + "'";

                MySqlConnection adatbKapcsolat4 = new MySqlConnection(kapcsolatString);
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
                            Publical.Add(Convert.ToInt32(reader4.GetInt32(0)));
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
                // note_id

                string parancs51 = "SELECT `note_id` FROM `notes`,users WHERE `user_id`=users.id AND users.id='" + userid + "'";

                MySqlConnection adatbKapcsolat51 = new MySqlConnection(kapcsolatString);
                MySqlCommand commandDatabase51 = new MySqlCommand(parancs51, adatbKapcsolat51);
                commandDatabase51.CommandTimeout = 60;
                MySqlDataReader reader51;

                try
                {
                    adatbKapcsolat51.Open();
                    reader51 = commandDatabase51.ExecuteReader();

                    if (reader51.HasRows)
                    {
                        while (reader51.Read())
                        {
                            Note_id.Add(Convert.ToInt32(reader51.GetInt32(0)));
                        }
                    }
                    else
                    {

                    }
                    adatbKapcsolat51.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            // jegyzeteim
            for (int i = 0; i < title.Count; i++)
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
                    for (int j = 0;j<words.Length;j++)
                    {
                        counter3++;
                    }
                    if (counter3 < 5 && counter4 == 1)
                    {
                        class1BindingSource.Add(new Class1() { Note_Title = title[i], Note_Content = content[i] });
                        Fcolumn.Add(title[i]);
                    }
                    if (counter1 > 5)
                    {
                        counter2++;
                        if (counter2 == 1)
                        {
                            class1BindingSource.Add(new Class1() { Note_Title = title[i], Note_Content = text });
                            Fcolumn.Add(title[i]);
                        }
                        else
                        {
                            class1BindingSource.Add(new Class1() { Note_Title = "", Note_Content = text });
                            Fcolumn.Add("");
                        }

                        text = "";
                        counter1 = 0;
                    }
                }
            }

            DataGridViewButtonColumn Bt = new DataGridViewButtonColumn();
            Bt.HeaderText = "Public";
            Bt.Name = "Public";
            Bt.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(Bt);
               
            string parancs5 = "SELECT `shared` FROM `notes`,users WHERE users.id=user_id AND users.id='" + userid + "'";
            MySqlConnection adatbKapcsolat5 = new MySqlConnection(kapcsolatString);
            MySqlCommand commandDatabase5 = new MySqlCommand(parancs5, adatbKapcsolat5);
            commandDatabase5.CommandTimeout = 60;
            MySqlDataReader reader5;

            try
            {
                adatbKapcsolat5.Open();
                reader5 = commandDatabase5.ExecuteReader();
                
                if (reader5.HasRows)
                {
                    while (reader5.Read())
                    {
                        shared.Add(Convert.ToInt32(reader5.GetInt32(0)));
                    }
                }
                else
                {

                }

                adatbKapcsolat5.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DataGridViewButtonColumn Bt2 = new DataGridViewButtonColumn();
            Bt2.HeaderText = "Share";
            Bt2.Name = "Shared";
            Bt2.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(Bt2);
           
            DataGridViewButtonColumn Bt4 = new DataGridViewButtonColumn();
            Bt4.HeaderText = "Save";
            Bt4.Name = "Save";
            dataGridView1.Columns.Add(Bt4);
            Bt4.UseColumnTextForButtonValue = true;
            for (int i = 0;i < Fcolumn.Count;i++)
            {
                if(Fcolumn[i] == "")
                {
                    DataGridViewButtonCell ButtonCell = new DataGridViewButtonCell();
                    dataGridView1[4, i] = ButtonCell;
                    dataGridView1[4, i].Value = "";
                }
                else
                {
                    DataGridViewButtonCell ButtonCell = new DataGridViewButtonCell();
                    dataGridView1[4, i] = ButtonCell;
                    dataGridView1[4, i].Value = "Save as";
                }
            }
           

            DataGridViewButtonColumn Bt3 = new DataGridViewButtonColumn();
            Bt3.HeaderText = "Delete";
            Bt3.Name = "Delete";
            dataGridView1.Columns.Add(Bt3);
            Bt3.UseColumnTextForButtonValue = true;
            for (int i = 0; i < Fcolumn.Count; i++)
            {
                if (Fcolumn[i] == "")
                {
                    DataGridViewButtonCell ButtonCell = new DataGridViewButtonCell();
                    dataGridView1[5, i] = ButtonCell;
                    dataGridView1[5, i].Value = "";
                }
                else
                {
                    DataGridViewButtonCell ButtonCell = new DataGridViewButtonCell();
                    dataGridView1[5, i] = ButtonCell;
                    dataGridView1[5, i].Value = "Delete";
                }
            }

        }

        private void Bt1_click()
        {
            label1.Text = "My Notes";
            button2.BackColor = Color.FromArgb(51, 51, 76);
            button3.BackColor = Color.FromArgb(51, 51, 76);
            Btadmin.BackColor = Color.FromArgb(51, 51, 76);
            newnoteBt.BackColor = Color.FromArgb(51, 51, 76);

            button1.BackColor = Color.Red;
            panel4.BackColor = Color.Red;
            panel3.BackColor = Color.DarkRed;

            if (btdb == 0)
            {
                notes();
            }
            else
            {
                dataGridView1.Columns.Remove("Public");
                dataGridView1.Columns.Remove("Shared");
                dataGridView1.Columns.Remove("Save");
                dataGridView1.Columns.Remove("Delete");
                dataGridView1.Rows.Clear();
                Fcolumn.Clear();
                Note_id.Clear();
                Publical.Clear();
                title.Clear();
                content.Clear();
                shared.Clear();
                notes();
            }

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Red;

            int counter = 0;
            int counter2 = 0;
            List<int> size_of_numbers = new List<int>();
            for (int k = 0; k < Fcolumn.Count; k++)
            {
                if (Fcolumn[k] == "")
                {
                    counter++;
                }
                if (k < Fcolumn.Count - 1)
                {
                    if (Fcolumn[k + 1] != "")
                    {
                        numbers.Add(counter);
                        counter = 0;
                    }
                }
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i == 0)
                {
                    counter2 = numbers[i] + counter2;
                    size_of_numbers.Add(counter2);
                }
                else
                {
                    counter2 = numbers[i] + counter2;
                    size_of_numbers.Add(counter2);
                }
            }

            for (int j = 0; j < title.Count; j++)
            {
                if (Publical[j] == 0)
                {
                    DataGridViewButtonCell ButtonCell2 = new DataGridViewButtonCell();
                    dataGridView1[2, j + size_of_numbers[j]] = ButtonCell2;
                    dataGridView1[2, j + size_of_numbers[j]].Value = "Private";
                }
                else if ((Publical[j] == 1))
                {
                    DataGridViewButtonCell ButtonCell = new DataGridViewButtonCell();
                    dataGridView1[2, j + size_of_numbers[j]] = ButtonCell;
                    dataGridView1[2, j + size_of_numbers[j]].Value = "Public";
                }
            }

            for (int j = 0; j < title.Count; j++)
            {
                if (shared[j] == 0)
                {
                    DataGridViewButtonCell ButtonCell2 = new DataGridViewButtonCell();
                    dataGridView1[3, j + size_of_numbers[j]] = ButtonCell2;// 
                    dataGridView1[3, j + size_of_numbers[j]].Value = " Private ";//
                }
                else if ((shared[j] == 1))
                {
                    DataGridViewButtonCell ButtonCell = new DataGridViewButtonCell();
                    dataGridView1[3, j + size_of_numbers[j]] = ButtonCell;//
                    dataGridView1[3, j + size_of_numbers[j]].Value = "Shared";// 
                }
            }

            for (int i = 0; i < Fcolumn.Count; i++)
            {
                if (Fcolumn[i] == "")
                {
                    DataGridViewButtonCell ButtonCell = new DataGridViewButtonCell();
                    dataGridView1[3, i] = ButtonCell;
                    dataGridView1[3, i].Value = "";
                }
            }
            for (int i = 0; i < Fcolumn.Count; i++)
            {
                if (Fcolumn[i] == "")
                {
                    DataGridViewButtonCell ButtonCell = new DataGridViewButtonCell();
                    dataGridView1[2, i] = ButtonCell;
                    dataGridView1[2, i].Value = "";
                }
                else
                {
                }
            }
            for (int i = 0; i < Fcolumn.Count; i++)
            {
                if (Fcolumn[i] == "")
                {
                    for (int j = 0; j < 4; j++)
                    {
                        var cell = ((DataGridViewButtonCell)dataGridView1.Rows[i].Cells[j + 2]);
                        cell.FlatStyle = FlatStyle.Flat;
                        dataGridView1.Rows[i].Cells[j + 2].Style.ForeColor = Color.White;
                    }
                }
            }

            panel2.BringToFront();
            dataGridView1.BringToFront();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "My Notes";
            button2.BackColor = Color.FromArgb(51, 51, 76);
            button3.BackColor = Color.FromArgb(51, 51, 76);
            Btadmin.BackColor = Color.FromArgb(51, 51, 76);
            newnoteBt.BackColor = Color.FromArgb(51, 51, 76);

            button1.BackColor = Color.Red;
            panel4.BackColor = Color.Red;
            panel3.BackColor = Color.DarkRed;

            if (btdb == 0)
            {
                notes();
            }
            else
            {
                dataGridView1.Columns.Remove("Public");
                dataGridView1.Columns.Remove("Shared");
                dataGridView1.Columns.Remove("Save");
                dataGridView1.Columns.Remove("Delete");
                dataGridView1.Rows.Clear();
                Fcolumn.Clear();
                Note_id.Clear();
                Publical.Clear();
                title.Clear();
                content.Clear();
                shared.Clear();
                notes();
            }

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Red;

            int counter = 0;
            int counter2 = 0;
            List<int> size_of_numbers = new List<int>();
            for (int k = 0; k < Fcolumn.Count; k++)
            {
                if (Fcolumn[k] == "")
                {
                    counter++;
                }
                if (k < Fcolumn.Count - 1)
                {
                    if (Fcolumn[k + 1] != "")
                    {
                        numbers.Add(counter);
                        counter = 0;
                    }
                }
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i == 0)
                {
                    counter2 = numbers[i] + counter2;
                    size_of_numbers.Add(counter2);
                }
                else
                {
                    counter2 = numbers[i] + counter2;
                    size_of_numbers.Add(counter2);
                }
            }

            for (int j = 0; j < title.Count; j++)
            {
                if (Publical[j] == 0)
                {
                    DataGridViewButtonCell ButtonCell2 = new DataGridViewButtonCell();
                    dataGridView1[2, j + size_of_numbers[j]] = ButtonCell2;
                    dataGridView1[2, j + size_of_numbers[j]].Value = "Private";
                }
                else if ((Publical[j] == 1))
                {
                    DataGridViewButtonCell ButtonCell = new DataGridViewButtonCell();
                    dataGridView1[2, j + size_of_numbers[j]] = ButtonCell;
                    dataGridView1[2, j + size_of_numbers[j]].Value = "Public";
                }
            }

            for (int j = 0; j < title.Count; j++)
            {
                if (shared[j] == 0)
                {
                    DataGridViewButtonCell ButtonCell2 = new DataGridViewButtonCell();
                    dataGridView1[3, j + size_of_numbers[j]] = ButtonCell2;// 
                    dataGridView1[3, j + size_of_numbers[j]].Value = " Private ";//
                }
                else if ((shared[j] == 1))
                {
                    DataGridViewButtonCell ButtonCell = new DataGridViewButtonCell();
                    dataGridView1[3, j + size_of_numbers[j]] = ButtonCell;//
                    dataGridView1[3, j + size_of_numbers[j]].Value = "Shared";// 
                }
            }

            for (int i = 0; i < Fcolumn.Count; i++)
            {
                if (Fcolumn[i] == "")
                {
                    DataGridViewButtonCell ButtonCell = new DataGridViewButtonCell();
                    dataGridView1[3, i] = ButtonCell;
                    dataGridView1[3, i].Value = "";
                }
            }
            for (int i = 0; i < Fcolumn.Count; i++)
            {
                if (Fcolumn[i] == "")
                {
                    DataGridViewButtonCell ButtonCell = new DataGridViewButtonCell();
                    dataGridView1[2, i] = ButtonCell;
                    dataGridView1[2, i].Value = "";
                }
                else
                {
                }
            }
            for (int i = 0; i < Fcolumn.Count; i++)
            {
                if (Fcolumn[i] == "")
                {
                    for (int j = 0; j < 4; j++)
                    {
                        var cell = ((DataGridViewButtonCell)dataGridView1.Rows[i].Cells[j + 2]);
                        cell.FlatStyle = FlatStyle.Flat;
                        dataGridView1.Rows[i].Cells[j + 2].Style.ForeColor = Color.White;
                    }
                }
            }

            panel2.BringToFront();
            dataGridView1.BringToFront();
        }
        private void Form2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView1.CurrentCell.RowIndex;
            if (dataGridView1.CurrentCell.Value.ToString() == "")
            {// enter
            }
            if (dataGridView1.CurrentCell.Value.ToString() == "Private")
            {
                string message = "Do you want to make this note public?";
                string title = "Public";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    int counter = -1;
                    for (int i = 0; i < Fcolumn.Count; i++)
                    {
                        if (Fcolumn[i] != "")
                        {
                            counter++;
                            if (counter == row)
                            {
                                break;
                            }
                        }
                    }
                    string kapcsolatString = "datasource=127.0.0.1;port=3306;username=root;password=;database=note_app;";
                    string parancs = " UPDATE `notes` SET `public` = '1' WHERE `notes`.`note_id` ='" + Note_id[counter] +"'";
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
                    DataGridViewButtonCell ButtonCell = new DataGridViewButtonCell();
                    dataGridView1[2, row] = ButtonCell;
                    dataGridView1[2, row].Value = "Public";
                }
                else
                {
                }
            }
            else if (dataGridView1.CurrentCell.Value.ToString() == "Public")
            {
                string message = "Do you want to make this note private?";
                string title = "Private";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    int counter = -1;
                    for (int i = 0; i < Fcolumn.Count; i++)
                    {
                        if (Fcolumn[i] != "")
                        {
                            counter++;
                            if (counter == row)
                            {
                                break;
                            }
                        }
                    }
                    string kapcsolatString = "datasource=127.0.0.1;port=3306;username=root;password=;database=note_app;";
                    string parancs = " UPDATE `notes` SET `public` = '0' WHERE `notes`.`note_id` ='" + Note_id[counter] + "'";
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
                    DataGridViewButtonCell ButtonCell = new DataGridViewButtonCell();
                    dataGridView1[2, row] = ButtonCell;
                    dataGridView1[2, row].Value = "Private";
                }
                else
                {
                }
            }
            int darab = 0;
            if (dataGridView1.CurrentCell.Value.ToString() == "Delete")
            {
                string message = "Are you sure you want to delete this note";
                string boxtitle = "Delete";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, boxtitle, buttons);
                if (result == DialogResult.Yes)
                {
                    int counter = -1;
                    for(int i = 0;i<Fcolumn.Count;i++)
                    {
                        if(Fcolumn[i] != "")
                        {
                            counter++;
                            if(counter == row)
                            {
                                break;
                            }
                        }
                    }
                    string kapcsolatString2 = "datasource=127.0.0.1;port=3306;username=root;password=;database=note_app;";
                    string parancs2 = "SELECT COUNT(note_id) FROM `shares` WHERE `note_id`='" + Note_id[counter] + "'";
                    MySqlConnection adatbKapcsolat2 = new MySqlConnection(kapcsolatString2);
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
                                darab = (Convert.ToInt32(reader2.GetInt32(0)));
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

                    if (darab > 0)
                    {
                        string kapcsolatString21 = "datasource=127.0.0.1;port=3306;username=root;password=;database=note_app;";
                        string parancs21 = "DELETE FROM shares WHERE shares.note_id='" + Note_id[counter] + "'";
                        MySqlConnection adatbKapcsolat21 = new MySqlConnection(kapcsolatString21);
                        MySqlCommand commandDatabase21 = new MySqlCommand(parancs21, adatbKapcsolat21);
                        commandDatabase21.CommandTimeout = 60;
                        try
                        {
                            adatbKapcsolat21.Open();
                            commandDatabase21.ExecuteNonQuery();
                            adatbKapcsolat21.Close();
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    string kapcsolatString3 = "datasource=127.0.0.1;port=3306;username=root;password=;database=note_app;";
                    string parancs3 = "DELETE FROM notes WHERE notes.note_id='" + Note_id[counter] + "'";
                    MySqlConnection adatbKapcsolat3 = new MySqlConnection(kapcsolatString3);
                    MySqlCommand commandDatabase3 = new MySqlCommand(parancs3, adatbKapcsolat3);
                    commandDatabase3.CommandTimeout = 60;
                    try
                    {
                        adatbKapcsolat3.Open();
                        commandDatabase3.ExecuteNonQuery();
                        adatbKapcsolat3.Close();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    dataGridView1.Columns.Remove("Public");
                    dataGridView1.Columns.Remove("Shared");
                    dataGridView1.Columns.Remove("Save");
                    dataGridView1.Columns.Remove("Delete");
                    dataGridView1.Rows.Clear();
                    Fcolumn.Clear();
                    Note_id.Clear();
                    Publical.Clear();
                    title.Clear();
                    content.Clear();
                    shared.Clear();
                    notes();
                    Bt1_click();


                    dataGridView1.EnableHeadersVisualStyles = false;
                    dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Red;


                    for (int i = 0; i < Fcolumn.Count; i++)
                    {
                        if (Fcolumn[i] == "")
                        {
                            DataGridViewButtonCell ButtonCell = new DataGridViewButtonCell();
                            dataGridView1[3, i] = ButtonCell;
                            dataGridView1[3, i].Value = "";
                        }
                    }
                    for (int i = 0; i < Fcolumn.Count; i++)
                    {
                        if (Fcolumn[i] == "")
                        {
                            DataGridViewButtonCell ButtonCell = new DataGridViewButtonCell();
                            dataGridView1[2, i] = ButtonCell;
                            dataGridView1[2, i].Value = "";
                        }
                        else
                        {
                            List<int> numbers = new List<int>();
                            int counter2 = 0;
                            numbers.Add(0);
                            for (int k = 0; k < Fcolumn.Count; k++)
                            {
                                if (Fcolumn[k] == "")
                                {
                                    counter2++;
                                }
                                if (k < Fcolumn.Count - 1)
                                {
                                    if (Fcolumn[k + 1] != "")
                                    {
                                        numbers.Add(counter2);
                                        counter2 = 0;
                                    }
                                }
                            }

                            for (int j = 0; j < title.Count; j++)
                            {
                                if (Publical[j] == 0)
                                {
                                    DataGridViewButtonCell ButtonCell2 = new DataGridViewButtonCell();
                                    dataGridView1[2, j + numbers[j]] = ButtonCell2;
                                    dataGridView1[2, j + numbers[j]].Value = "Private";
                                }
                                else if ((Publical[j] == 1))
                                {
                                    DataGridViewButtonCell ButtonCell = new DataGridViewButtonCell();
                                    dataGridView1[2, j + numbers[j]] = ButtonCell;
                                    dataGridView1[2, j + numbers[j]].Value = "Public";
                                }
                            }

                            for (int j = 0; j < title.Count; j++)
                            {
                                if (shared[j] == 0)
                                {
                                    DataGridViewButtonCell ButtonCell2 = new DataGridViewButtonCell();
                                    dataGridView1[3, j + numbers[j]] = ButtonCell2;// 
                                    dataGridView1[3, j + numbers[j]].Value = " Private ";//
                                }
                                else if ((shared[j] == 1))
                                {
                                    DataGridViewButtonCell ButtonCell = new DataGridViewButtonCell();
                                    dataGridView1[3, j + numbers[j]] = ButtonCell;//
                                    dataGridView1[3, j + numbers[j]].Value = "Shared";// 
                                }
                            }
                        }
                    }
                    for (int i = 0; i < Fcolumn.Count; i++)
                    {
                        if (Fcolumn[i] == "")
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                var cell = ((DataGridViewButtonCell)dataGridView1.Rows[i].Cells[j + 2]);
                                cell.FlatStyle = FlatStyle.Flat;
                                dataGridView1.Rows[i].Cells[j + 2].Style.ForeColor = Color.White;
                            }
                        }
                    }


                }
            }
            else
            {

            }
            if(dataGridView1.CurrentCell.Value.ToString() == " Private ")
            {
                int counter = -1;
                for (int i = 0; i < Fcolumn.Count; i++)
                {
                    if (Fcolumn[i] != "")
                    {
                        counter++;
                        if (counter == row)
                        {
                            break;
                        }
                    }
                }
                noteid =Note_id[counter];
                Form5 F5 = new Form5();
                F5.Show();
                this.Hide();
            }
            if (dataGridView1.CurrentCell.Value.ToString() == "Shared")
            {
                string message = "Do you want to share this note with someone else?";
                string title = "Share";
                int counter = -1;
                for (int i = 0; i < Fcolumn.Count; i++)
                {
                    if (Fcolumn[i] != "")
                    {
                        counter++;
                        if (counter == row)
                        {
                            break;
                        }
                    }
                }
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    noteid = Note_id[counter];
                    Form5 F5 = new Form5();
                    F5.Show();
                    this.Hide();
                }
                else
                {
                    string message2 = "Do you want to make this note private?";
                    string title2 = "Share";
                    MessageBoxButtons buttons2 = MessageBoxButtons.YesNo;
                   
                    DialogResult result2 = MessageBox.Show(message2, title2, buttons2);
                    if (result2 == DialogResult.Yes)
                    {
                        string kapcsolatString3 = "datasource=127.0.0.1;port=3306;username=root;password=;database=note_app;";
                        string parancs3 = "DELETE FROM `shares` WHERE `note_id`='" + Note_id[counter] + "'";
                        MySqlConnection adatbKapcsolat3 = new MySqlConnection(kapcsolatString3);
                        MySqlCommand commandDatabase3 = new MySqlCommand(parancs3, adatbKapcsolat3);
                        commandDatabase3.CommandTimeout = 60;
                        try
                        {
                            adatbKapcsolat3.Open();
                            commandDatabase3.ExecuteNonQuery();
                            adatbKapcsolat3.Close();
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }


                        string kapcsolatString = "datasource=127.0.0.1;port=3306;username=root;password=;database=note_app;";
                        string parancs = "UPDATE `notes` SET `shared` = '0' WHERE `notes`.`note_id` ='" + Note_id[counter] + "'";
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
                        DataGridViewButtonCell ButtonCell = new DataGridViewButtonCell();
                        dataGridView1[3, row] = ButtonCell;
                        dataGridView1[3, row].Value = " Private ";
                    }
                    else
                    {

                    }
                }
            }
            if(dataGridView1.CurrentCell.Value.ToString() == "Save as")
            {
                try
                {
                    saveFileDialog1.ShowDialog();
                    string faljnev = saveFileDialog1.FileName;
                    StreamWriter ki = new StreamWriter(faljnev);
                    ki.WriteLine(title[row]);
                    ki.WriteLine();
                    ki.WriteLine(content[row]);
                    ki.Close();
                }
                catch
                {

                }
            }

        }
        private void shares()
        {
            btdb2++;
            List<string> title = new List<string>();
            List<string> content = new List<string>();
            List<string> username = new List<string>();

            string kapcsolatString = "datasource=127.0.0.1;port=3306;username=root;password=;database=note_app;";


            string parancs2 = "SELECT notes.title FROM `shares`,`notes`,`users` WHERE shares.email = '" + email + "' AND shares.note_id = notes.note_id AND notes.user_id = users.id GROUP BY notes.note_id";

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
                        title.Add(Convert.ToString(reader2.GetString(0)));
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

            string parancs3 = "SELECT notes.content FROM `shares`,`notes`,`users` WHERE shares.email = '" + email + "' AND shares.note_id = notes.note_id AND notes.user_id = users.id GROUP BY notes.note_id";

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
                        content.Add(Convert.ToString(reader3.GetString(0)));
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


            string parancs4 = "SELECT users.email FROM `shares`,`notes`,`users` WHERE shares.email = '" + email + "' AND shares.note_id = notes.note_id AND notes.user_id = users.id GROUP BY notes.note_id";

            MySqlConnection adatbKapcsolat4 = new MySqlConnection(kapcsolatString);
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
                        username.Add(Convert.ToString(reader4.GetString(0)));
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
            // megosztott
            for(int i = 0;i < content.Count;i++)
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
                        class3BindingSource.Add(new Class3() { Note_Title = title[i], Note_Content = content[i], From = username[i] });
                    }
                    if (counter1 > 5)
                    {
                        counter2++;
                        if (counter2 == 1)
                        {
                            class3BindingSource.Add(new Class3() { Note_Title = title[i], Note_Content = text, From = username[i] });
                        }
                        else
                        {
                            class3BindingSource.Add(new Class3() { Note_Title = "", Note_Content = text, From = "" });
                        }
                        text = "";
                        counter1 = 0;
                    }
                }
            }
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
                        class2BindingSource2.Add(new Class2() { Note_Title = title[i], Note_Content = content[i]});
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
        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Public Notes";

            

            button1.BackColor = Color.FromArgb(51,51,76);
            button3.BackColor = Color.FromArgb(51, 51, 76);
            Btadmin.BackColor = Color.FromArgb(51, 51, 76);
            newnoteBt.BackColor = Color.FromArgb(51, 51, 76);


            button2.BackColor = Color.Blue;
            panel4.BackColor = Color.Blue;
            panel3.BackColor = Color.DarkBlue;

            if (btdb3 == 0)
            {
                publcal_notes();
            }
            else
            {
                dataGridView2.Rows.Clear();
                publcal_notes();
            }

            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;

            panel2.BringToFront();
            dataGridView2.BringToFront();
     
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Shared Notes";


            button1.BackColor = Color.FromArgb(51, 51, 76);
            button2.BackColor = Color.FromArgb(51, 51, 76);
            Btadmin.BackColor = Color.FromArgb(51, 51, 76);
            newnoteBt.BackColor = Color.FromArgb(51, 51, 76);

            button3.BackColor = Color.Orange;
            panel4.BackColor = Color.Orange;
            panel3.BackColor = Color.DarkOrange;

            if (btdb2 == 0)
            {
                shares();
            }
            else
            {
                dataGridView3.Rows.Clear();
                shares();
            }

            dataGridView3.EnableHeadersVisualStyles = false;
            dataGridView3.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView3.ColumnHeadersDefaultCellStyle.BackColor = Color.Orange;

            panel2.BringToFront();
            dataGridView3.BringToFront();
            
        }
       

        private void BtSettings_Click(object sender, EventArgs e)
        {
            counter++;
            newnoteBt.BackColor = Color.FromArgb(51, 51, 76);

            if (counter % 2 != 0)
            {
                BtChangepass.BringToFront();
                BtChangeemail.BringToFront();

                BtChangepass.BackColor = Color.FromArgb(39, 39, 58);
                BtChangeemail.BackColor = Color.FromArgb(39, 39, 58);
            }
            else 
            {
                panel5.BringToFront();
            }
           
        }

        private void BtChangepass_Click(object sender, EventArgs e)
        {
            Form6 F6 = new Form6();
            F6.Show();
            this.Hide();
        }

        private void BtChangeemail_Click(object sender, EventArgs e)
        {
            Form4 F4 = new Form4();
            F4.Show();
            this.Hide();
        }
        private void admin()
        {
            btdb4++;
            List<string> users = new List<string>();
            List<int> Numbers_of_notes = new List<int>();
            List<int> Numbers_of_shared_notes = new List<int>();
            List<int> Numbers_of_public_notes = new List<int>();
            string kapcsolatString = "datasource=127.0.0.1;port=3306;username=root;password=;database=note_app;";


            string parancs = "SELECT `email` FROM `users` WHERE 1";

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
                        users.Add(Convert.ToString(reader.GetString(0)));
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

            for (int i = 0; i < users.Count; i++)
            {
                

                string parancs2 = "SELECT COUNT(`note_id`) FROM `notes`,users WHERE notes.user_id = users.id AND users.email = '" + users[i] + "'";

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
                            Numbers_of_notes.Add(Convert.ToInt32(reader2.GetInt32(0)));
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

                string parancs3 = "SELECT COUNT(`note_id`) FROM `notes`,users WHERE notes.user_id = users.id AND users.email = '" + users[i] + "' AND public = 1;";

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
                            Numbers_of_public_notes.Add(Convert.ToInt32(reader3.GetInt32(0)));
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

                string parancs4 = "SELECT COUNT(`note_id`) FROM `notes`,users WHERE notes.user_id = users.id AND users.email = '" + users[i] + "' AND shared = 1;";

                MySqlConnection adatbKapcsolat4 = new MySqlConnection(kapcsolatString);
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
                            Numbers_of_shared_notes.Add(Convert.ToInt32(reader4.GetInt32(0)));
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
            }
            for (int i = 0; i < users.Count; i++)
            {
                class6BindingSource.Add(new Class6() { Username = users[i], Numbers_of_notes = Numbers_of_notes[i], Numbers_of_public_notes = Numbers_of_public_notes[i], Numbers_of_shared_notes = Numbers_of_shared_notes[i]});
            }
            
        }
        private void Btadmin_Click(object sender, EventArgs e)
        {
            label1.Text = "Note app statics";

            if(btdb4 == 0)
            {
                admin();
            }

            button1.BackColor = Color.FromArgb(51, 51, 76);
            button2.BackColor = Color.FromArgb(51, 51, 76);
            button3.BackColor = Color.FromArgb(51, 51, 76);
            newnoteBt.BackColor = Color.FromArgb(51, 51, 76);

            Btadmin.BackColor = Color.SlateBlue;
            panel4.BackColor = Color.SlateBlue;
            panel3.BackColor = Color.DarkSlateBlue;

            panel2.BringToFront();
            dataGridView4.BringToFront();

            dataGridView4.EnableHeadersVisualStyles = false;
            dataGridView4.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView4.ColumnHeadersDefaultCellStyle.BackColor = Color.SlateBlue;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void newnoteBt_Click(object sender, EventArgs e)
        {
            int newnoteBtcounter = 0;
            newnoteBtcounter++;
            button1.BackColor = Color.FromArgb(51, 51, 76);
            button2.BackColor = Color.FromArgb(51, 51, 76);
            button3.BackColor = Color.FromArgb(51, 51, 76);
            Btadmin.BackColor = Color.FromArgb(51, 51, 76);

            newnoteBt.BackColor = Color.SeaGreen;
            panel4.BackColor = Color.SeaGreen;
            panel3.BackColor = Color.DarkSeaGreen;

            label4.BringToFront();
            label1.Text = "New Note";
            panel2.BringToFront();
            panel6.BringToFront();
            panel6.BackColor = Color.SeaGreen;
            textBox1.BringToFront();
            textBox2.BringToFront();
            BtSave.BringToFront();

            if(newnoteBtcounter == 1)
            {
                label2.BringToFront();
                label3.BringToFront();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox1.BringToFront();
            }
            else
            {
                label2.BringToFront();
            }
            if (textBox1.Text != "")
            {
                label4.Text = "";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                textBox2.BringToFront();
            }
            else
            {
                label3.BringToFront();
            }
            if (textBox2.Text != "")
            {
                label4.Text = "";
            }
        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text == "")
            {
                label4.ForeColor = Color.Red;
                label4.Text = "Fill up both of the text boxes!";
            }

            if(textBox1.Text != "" || textBox2.Text != "")
            {
                label4.ForeColor = Color.White;
                label4.Text = "You have successfully made a new note!";
                string kapcsolatString = "datasource=127.0.0.1;port=3306;username=root;password=;database=note_app;";
                string username;
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
                            username = (Convert.ToString(reader.GetString(0)));
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

                string parancs2 = "INSERT INTO `notes` (`note_id`, `user_id`, `title`, `content`, `public`, `shared`) VALUES (NULL, '" + userid + "', '" + textBox1.Text + "', '" + textBox2.Text + "', '0', '0');";
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

                textBox1.Text = "";
                textBox2.Text = "";
            }
        }
    }
}
