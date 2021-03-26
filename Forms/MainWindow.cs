using System;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Windows.Forms;

namespace Speakerbooth.Forms
{
    public partial class MainWindow : Form
    {
        AutoCompleteStringCollection AutoComplete = new AutoCompleteStringCollection();
        ImageViewer Viewer = new ImageViewer();
        string CurrentImage = "";
        Player Player1 = new Player();
        Player Player2 = new Player();

        public MainWindow()
        {
            InitializeComponent();

            Icon = Properties.Resources.megaphone;
            Text += " - v" + Assembly.GetExecutingAssembly().GetName().Version.ToString();

            PopulateAutoList();

            SearchCard.AutoCompleteMode = AutoCompleteMode.Suggest;
            SearchCard.AutoCompleteSource = AutoCompleteSource.CustomSource;
            SearchCard.AutoCompleteCustomSource = AutoComplete;
            CardPreview.SizeMode = PictureBoxSizeMode.Zoom;

        }

        public SQLiteConnection GetDatabase()
        {
            string dbName = "mtg.db";
            string path = Path.Combine(Environment.CurrentDirectory, @"Database\", dbName);

            SQLiteConnection db = new SQLiteConnection("Data Source=" + path + ";Mode=ReadOnly;");

            try
            {
                db.Open();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception thrown when trying to open database.");
                Debug.WriteLine(ex.Message);
            }

            return db;

        }

        public void PopulateAutoList()
        {
            var db = GetDatabase();
            SQLiteCommand command = db.CreateCommand();

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
            db.Close();
        }

        private void P1Life(object sender, EventArgs e)
        {
            string action = (sender as Button).Text;

            switch (action)
            {
                case "+1":
                    Player1.Life += 1;
                    break;
                case "+5":
                    Player1.Life += 5;
                    break;
                case "-1":
                    Player1.Life -= 1;
                    break;
                case "-5":
                    Player1.Life -= 5;
                    break;
            }

            P1LifeValue.Text = Player1.Life.ToString();
            WriteFile("player1_life", P1LifeValue.Text);
        }

        private void P2Life(object sender, EventArgs e)
        {
            string action = (sender as Button).Text;

            switch (action)
            {
                case "+1":
                    Player2.Life += 1;
                    break;
                case "+5":
                    Player2.Life += 5;
                    break;
                case "-1":
                    Player2.Life -= 1;
                    break;
                case "-5":
                    Player2.Life -= 5;
                    break;
            }

            P2LifeValue.Text = Player2.Life.ToString();
            WriteFile("player2_life", P2LifeValue.Text);
        }

        private void EditDecklistBtn_Click(object sender, EventArgs e)
        {
            using (Form deckListForm = new DecklistForm() )
            { deckListForm.ShowDialog(); }
        }

        private void WriteFile(string file, string value)
        {
            string textPath = Path.Combine(Environment.CurrentDirectory, @"Player\", file + ".txt");
            try
            {
                File.WriteAllText(textPath, value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void P1Wins_ValueChanged(object sender, EventArgs e)
        {
            Player1.Wins = (int)(sender as NumericUpDown).Value;
            WriteFile("player1_wins", Player1.Wins.ToString());
        }

        private void P2Wins_ValueChanged(object sender, EventArgs e)
        {
            Player2.Wins = (int)(sender as NumericUpDown).Value;
            WriteFile("player2_wins", Player2.Wins.ToString());
        }

        private void P1Poison_ValueChanged(object sender, EventArgs e)
        {
            Player1.Poison = (int)(sender as NumericUpDown).Value;
            WriteFile("player1_poison", Player1.Poison.ToString());
        }

        private void P2Poison_ValueChanged(object sender, EventArgs e)
        {
            Player2.Poison = (int)(sender as NumericUpDown).Value;
            WriteFile("player2_poison", Player2.Poison.ToString());
        }

        private void P2Archetype_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Player2.Archetype = (sender as TextBox).Text;
                WriteFile("player2_archetype", Player2.Archetype);
            }
        }

        private void P1Archetype_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Player1.Archetype = (sender as TextBox).Text;
                WriteFile("player1_archetype", Player1.Archetype);
            }
        }

        private void P1Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Player1.Name = (sender as TextBox).Text;
                WriteFile("player1_name", Player1.Name);
            }
        }

        private void P2Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Player2.Name = (sender as TextBox).Text;
                WriteFile("player2_name", Player2.Name);
            }
        }

        private void SearchCard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var DB = GetDatabase();
                SQLiteCommand command = DB.CreateCommand();

                command.CommandText = "SELECT scryfallId FROM cards WHERE name = :name LIMIT 1";
                command.Parameters.AddWithValue(":name", SearchCard.Text);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {

                    if (reader.HasRows && reader.Read())
                    {
                        string scryID = reader.GetString(0);
                        string imgFile = scryID + ".png";

                        string imgPath = Path.Combine(Environment.CurrentDirectory, @"Images\", imgFile);

                        if (!File.Exists(imgPath))
                        {
                            // Download
                            using (WebClient client = new WebClient())
                            {
                                client.Headers.Add("Content-Type", "image/png");
                                string url = "https://api.scryfall.com/cards/" + scryID + "?format=image";
                                client.DownloadFile(new Uri(url), imgPath);
                                client.Dispose();
                            }

                        }

                        if (File.Exists(imgPath))
                        {
                            CurrentImage = imgPath;

                            if (CardPreview.Image != null)
                            {
                                CardPreview.Image.Dispose();
                            }

                            CardPreview.Image = (Image)new Bitmap(imgPath);
                        }

                    }
                    reader.Close();
                }
                DB.Close();
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Viewer.ToggleImage();
        }

        private void LoadCardBtn_Click(object sender, EventArgs e)
        {
            if (Viewer.IsDisposed)
            {
                Viewer = new ImageViewer();
            }

            Viewer.SetImage(CurrentImage);

            if (!Viewer.Visible)
            {
                Viewer.Show();
            }
        }

        private void ResetLifePoisonBtn_Click(object sender, EventArgs e)
        {
            Player1.Life = Player2.Life = 20;
            Player1.Poison = Player2.Poison = 0;

            P1LifeValue.Text = P2LifeValue.Text = Player1.Life.ToString();
            P1Poison.Value = P2Poison.Value = Player1.Poison;

            WriteFile("player1_life", P1LifeValue.Text);
            WriteFile("player2_life", P2LifeValue.Text);
            WriteFile("player1_poison", Player1.Poison.ToString());
            WriteFile("player2_poison", Player2.Poison.ToString());
        }
    }
}
