using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Speakerbooth.Forms
{
    public partial class DecklistForm : Form
    {
        string BasePath;

        string Player1Decklist = "player1_decklist.txt";
        string Player1Sideboard = "player1_sideboard.txt";
        string Player2Decklist = "player2_decklist.txt";
        string Player2Sideboard = "player2_sideboard.txt";

        public DecklistForm()
        {
            BasePath = Path.Combine(Environment.CurrentDirectory, @"Player\");
            Debug.WriteLine("DecklistForm - InitializeComponent");
            InitializeComponent();
            Icon = Properties.Resources.megaphone;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            if ( File.Exists(BasePath + Player1Decklist) )
            { P1Decklist.Text = File.ReadAllText(BasePath + Player1Decklist); }

            if (File.Exists(BasePath + Player1Sideboard))
            { P1Sideboard.Text = File.ReadAllText(BasePath + Player1Sideboard); }

            if (File.Exists(BasePath + Player2Decklist))
            { P2Decklist.Text = File.ReadAllText(BasePath + Player2Decklist); }

            if (File.Exists(BasePath + Player2Sideboard))
            { P2Sideboard.Text = File.ReadAllText(BasePath + Player2Sideboard); }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("DecklistForm - SaveBtn_Click");
            try
            {
                File.WriteAllText(BasePath + Player1Decklist, P1Decklist.Text);
                File.WriteAllText(BasePath + Player1Sideboard, P1Sideboard.Text);
                File.WriteAllText(BasePath + Player2Decklist, P2Decklist.Text);
                File.WriteAllText(BasePath + Player2Sideboard, P2Sideboard.Text);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DecklistForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }
    }
}
