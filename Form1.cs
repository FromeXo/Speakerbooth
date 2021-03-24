using System;
using System.IO;
using System.Reflection;
using System.Data.SQLite;
using System.Diagnostics;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net;
using System.Drawing;

namespace Speakerbooth
{
    public partial class Form1 : Form
    {
        ImageViewer Viewer = new ImageViewer();
        Player Player1 = new Player();
        Player Player2 = new Player();

        static bool Reading = false;
        string CurrentImage = "";
        static SQLiteConnection DB;

        AutoCompleteStringCollection AutoComplete = new AutoCompleteStringCollection();

        public Form1()
        {
            OpenDatabase();
            InitializeComponent();
            Icon = Properties.Resources.megaphone;
            Text = Text + " - v" +Assembly.GetExecutingAssembly().GetName().Version.ToString();


        }

        public void OpenDatabase()
        {
            string dbName = "mtg.db";
            string path = Path.Combine(Environment.CurrentDirectory, @"Database\", dbName);

            DB = new SQLiteConnection("Data Source=" + path + ";Mode=ReadOnly;");

            try
            {
                DB.Open();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception thrown when trying to open database.");
                Debug.WriteLine(ex.Message);
            }

        }

        public void PopulateAutoList()
        {
            SQLiteCommand command = DB.CreateCommand();
            
            command.CommandText = "SELECT `name` FROM `cards` ORDER BY LENGTH(`name`) ASC";

            using (SQLiteDataReader reader = command.ExecuteReader())
            {

                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        string name = reader.GetString(0);
                        if (name.Length > 0) { AutoComplete.Add(name); }
                    }
                }

                reader.Close();
            }
        }

        public void SearchCard(string query)
        {
            Debug.WriteLine("SeachCard");
            Reading = true;

            SQLiteCommand command = DB.CreateCommand();

            command.CommandText = "SELECT DISTINCT `name` FROM `cards` WHERE `name` LIKE :query ORDER BY LENGTH(`name`) ASC LIMIT 10";
            command.Parameters.AddWithValue(":query", query + "%");

            List<string> myList = new List<string>();

            using (SQLiteDataReader reader = command.ExecuteReader())
            {

                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        string name = reader.GetString(0);
                        if (name.Length > 0)
                        {

                            AutoComplete.Add(name);
                        }

                    }
                    Debug.WriteLine(String.Join(",", myList.ToArray()));



                }
                else
                {
                    Debug.WriteLine("I has NOT rows");
                }
                reader.Close();
            }
            Reading = false;
            Debug.WriteLine("SeachCard Done");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Debug.WriteLine("Form1_Load");
            PopulateAutoList();
            seachBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            seachBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            seachBox.AutoCompleteCustomSource = AutoComplete;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if ( Viewer.Visible )
            {
                Viewer.Close();
            }
            DB.Close();
        }
        
        private void seachBox_TextChanged(object sender, EventArgs e){}

        private void seachBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                SQLiteCommand command = DB.CreateCommand();

                command.CommandText = "SELECT scryfallId FROM cards WHERE name = :name LIMIT 1";
                command.Parameters.AddWithValue(":name", seachBox.Text);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {

                    if (reader.HasRows && reader.Read())
                    {
                        string scryID = reader.GetString(0);
                        string imgFile = scryID + ".png";

                        string imgPath = Path.Combine(Environment.CurrentDirectory, @"Images\", imgFile);

                        if ( ! File.Exists(imgPath)  )
                        {
                            // Download
                            using (WebClient client = new WebClient())
                            {
                                client.Headers.Add("Content-Type", "image/png");
                                string url = "https://api.scryfall.com/cards/" + scryID + "?format=image";
                                client.DownloadFile(new Uri(url), imgPath);
                            }

                        }

                        if ( File.Exists(imgPath) ) { 
                            CurrentImage = imgPath;
                            Bitmap cardImage = new Bitmap(imgPath);
                            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                            pictureBox1.Image = (Image)cardImage;
                        }

                    }
                    reader.Close();
                }

                string path = Path.Combine(Environment.CurrentDirectory, @"images\");

                e.Handled = true;
            }
        }

        
        private void button9_Click(object sender, EventArgs e)
        {
            if ( Viewer.IsDisposed )
            {
                Viewer = new ImageViewer();
            }

            Viewer.SetImage(CurrentImage);

            if ( ! Viewer.Visible )
            {
                Viewer.Show();
            }

        }
        
        private void P2Name(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Player2.Name = (sender as TextBox).Text;
                WriteFile("player2_name", Player2.Name);
            }

        }

        private void P1Name(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Enter )
            {
                Player1.Name = (sender as TextBox).Text;
                WriteFile("player1_name", Player1.Name);
            }
            
        }

        private void P2Pois(object sender, EventArgs e)
        {
            Player2.Poison = (int)(sender as NumericUpDown).Value;
            WriteFile("player2_poison", Player2.Poison.ToString());
        }

        private void P1Pois(object sender, EventArgs e)
        {
            Player1.Poison = (int)(sender as NumericUpDown).Value;
            WriteFile("player1_poison", Player1.Poison.ToString());
        }

        private void P2Wins(object sender, EventArgs e)
        {
            Player2.Wins = (int) (sender as NumericUpDown).Value;
            WriteFile("player2_wins", Player2.Wins.ToString());
        }

        private void P1Wins(object sender, EventArgs e)
        {
            Player1.Wins = (int)(sender as NumericUpDown).Value;
            WriteFile("player1_wins", Player1.Wins.ToString());
        }

        private void P1Life(object sender, EventArgs e)
        {
            string action = (sender as Button).Text;

            switch( action )
            {
                case "+1":
                    Player1.Add1ToLife();
                    break;
                case "+5":
                    Player1.Add5ToLife();
                    break;
                case "-1":
                    Player1.Sub1FromLife();
                    break;
                case "-5":
                    Player1.Sub5FromLife();
                    break;
            }

            label6.Text = Player1.Life.ToString();
            WriteFile("player1_life", label6.Text);

        }

        private void P2Life(object sender, EventArgs e)
        {
            string action = (sender as Button).Text;

            switch (action)
            {
                case "+1":
                    Player2.Add1ToLife();
                    break;
                case "+5":
                    Player2.Add5ToLife();
                    break;
                case "-1":
                    Player2.Sub1FromLife();
                    break;
                case "-5":
                    Player2.Sub5FromLife();
                    break;
            }

            label7.Text = Player2.Life.ToString();
            WriteFile("player2_life", label7.Text);

        }

        private void WriteFile(string filename, string value)
        {
            string textPath = Path.Combine(Environment.CurrentDirectory, @"Player\", filename + ".txt");
            File.WriteAllText(textPath, value);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Player1.Life = Player2.Life = 20;
            Player1.Poison = Player2.Poison = 0;

            label6.Text = Player1.Life.ToString();
            WriteFile("player1_life", label6.Text);

            label7.Text = Player2.Life.ToString();
            WriteFile("player2_life", label7.Text);

            P1Poi.Value = (decimal) Player1.Poison;
            WriteFile("player1_poison", Player1.Poison.ToString());

            P2Poison.Value = (decimal) Player2.Poison;
            WriteFile("player2_poison", Player2.Poison.ToString());

        }
    }
}
