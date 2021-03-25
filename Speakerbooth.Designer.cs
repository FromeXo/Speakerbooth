
namespace Speakerbooth
{
    partial class Speakerbooth
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HeaderPlayer1 = new System.Windows.Forms.Label();
            this.TextBoxPlayer1Name = new System.Windows.Forms.TextBox();
            this.LabelPlayer1Name = new System.Windows.Forms.Label();
            this.pwin = new System.Windows.Forms.NumericUpDown();
            this.LabelPlayer1Wins = new System.Windows.Forms.Label();
            this.LabelPlayer1Poison = new System.Windows.Forms.Label();
            this.P1Poison = new System.Windows.Forms.NumericUpDown();
            this.HeaderPlayer1Life = new System.Windows.Forms.Label();
            this.Player1Sub1Life = new System.Windows.Forms.Button();
            this.Player1Sub5Life = new System.Windows.Forms.Button();
            this.Player1Add1Life = new System.Windows.Forms.Button();
            this.Player1Add5Life = new System.Windows.Forms.Button();
            this.LifePlayer1 = new System.Windows.Forms.Label();
            this.LifePlayer2 = new System.Windows.Forms.Label();
            this.Player2Add5Life = new System.Windows.Forms.Button();
            this.Player2Add1Life = new System.Windows.Forms.Button();
            this.Player2Sub5Life = new System.Windows.Forms.Button();
            this.Player2Sub1Life = new System.Windows.Forms.Button();
            this.HeaderPlayer2Life = new System.Windows.Forms.Label();
            this.P2Poison = new System.Windows.Forms.NumericUpDown();
            this.LabelPlayer2Poison = new System.Windows.Forms.Label();
            this.LabelPlayer2Wins = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.LabelPlayer2Name = new System.Windows.Forms.Label();
            this.TextBoxPlayer2Name = new System.Windows.Forms.TextBox();
            this.HeaderPlayer2 = new System.Windows.Forms.Label();
            this.SeachBox = new System.Windows.Forms.TextBox();
            this.HeaderSearchCard = new System.Windows.Forms.Label();
            this.CardPreview = new System.Windows.Forms.PictureBox();
            this.ShowCard = new System.Windows.Forms.Button();
            this.ResetLifeAndPoison = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pwin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P1Poison)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2Poison)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderPlayer1
            // 
            this.HeaderPlayer1.AutoSize = true;
            this.HeaderPlayer1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeaderPlayer1.Location = new System.Drawing.Point(12, 9);
            this.HeaderPlayer1.Name = "HeaderPlayer1";
            this.HeaderPlayer1.Size = new System.Drawing.Size(98, 30);
            this.HeaderPlayer1.TabIndex = 0;
            this.HeaderPlayer1.Text = "Spelare 1";
            // 
            // TextBoxPlayer1Name
            // 
            this.TextBoxPlayer1Name.Location = new System.Drawing.Point(12, 72);
            this.TextBoxPlayer1Name.Name = "TextBoxPlayer1Name";
            this.TextBoxPlayer1Name.Size = new System.Drawing.Size(182, 23);
            this.TextBoxPlayer1Name.TabIndex = 1;
            this.TextBoxPlayer1Name.KeyUp += new System.Windows.Forms.KeyEventHandler(this.P1Name);
            // 
            // LabelPlayer1Name
            // 
            this.LabelPlayer1Name.AutoSize = true;
            this.LabelPlayer1Name.Location = new System.Drawing.Point(12, 54);
            this.LabelPlayer1Name.Name = "LabelPlayer1Name";
            this.LabelPlayer1Name.Size = new System.Drawing.Size(40, 15);
            this.LabelPlayer1Name.TabIndex = 2;
            this.LabelPlayer1Name.Text = "Namn";
            // 
            // pwin
            // 
            this.pwin.Location = new System.Drawing.Point(61, 101);
            this.pwin.Name = "pwin";
            this.pwin.Size = new System.Drawing.Size(40, 23);
            this.pwin.TabIndex = 3;
            this.pwin.ValueChanged += new System.EventHandler(this.P1Wins);
            // 
            // LabelPlayer1Wins
            // 
            this.LabelPlayer1Wins.AutoSize = true;
            this.LabelPlayer1Wins.Location = new System.Drawing.Point(12, 103);
            this.LabelPlayer1Wins.Name = "LabelPlayer1Wins";
            this.LabelPlayer1Wins.Size = new System.Drawing.Size(43, 15);
            this.LabelPlayer1Wins.TabIndex = 4;
            this.LabelPlayer1Wins.Text = "Vinster";
            // 
            // LabelPlayer1Poison
            // 
            this.LabelPlayer1Poison.AutoSize = true;
            this.LabelPlayer1Poison.Location = new System.Drawing.Point(107, 103);
            this.LabelPlayer1Poison.Name = "LabelPlayer1Poison";
            this.LabelPlayer1Poison.Size = new System.Drawing.Size(43, 15);
            this.LabelPlayer1Poison.TabIndex = 5;
            this.LabelPlayer1Poison.Text = "Poison";
            // 
            // P1Poison
            // 
            this.P1Poison.Location = new System.Drawing.Point(156, 101);
            this.P1Poison.Name = "P1Poison";
            this.P1Poison.Size = new System.Drawing.Size(38, 23);
            this.P1Poison.TabIndex = 6;
            this.P1Poison.ValueChanged += new System.EventHandler(this.P1Pois);
            // 
            // HeaderPlayer1Life
            // 
            this.HeaderPlayer1Life.AutoSize = true;
            this.HeaderPlayer1Life.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeaderPlayer1Life.Location = new System.Drawing.Point(12, 134);
            this.HeaderPlayer1Life.Name = "HeaderPlayer1Life";
            this.HeaderPlayer1Life.Size = new System.Drawing.Size(35, 25);
            this.HeaderPlayer1Life.TabIndex = 7;
            this.HeaderPlayer1Life.Text = "Liv";
            // 
            // Player1Sub1Life
            // 
            this.Player1Sub1Life.Location = new System.Drawing.Point(12, 162);
            this.Player1Sub1Life.Name = "Player1Sub1Life";
            this.Player1Sub1Life.Size = new System.Drawing.Size(58, 23);
            this.Player1Sub1Life.TabIndex = 8;
            this.Player1Sub1Life.Text = "-1";
            this.Player1Sub1Life.UseVisualStyleBackColor = true;
            this.Player1Sub1Life.Click += new System.EventHandler(this.P1Life);
            // 
            // Player1Sub5Life
            // 
            this.Player1Sub5Life.Location = new System.Drawing.Point(12, 184);
            this.Player1Sub5Life.Name = "Player1Sub5Life";
            this.Player1Sub5Life.Size = new System.Drawing.Size(58, 23);
            this.Player1Sub5Life.TabIndex = 9;
            this.Player1Sub5Life.Text = "-5";
            this.Player1Sub5Life.UseVisualStyleBackColor = true;
            this.Player1Sub5Life.Click += new System.EventHandler(this.P1Life);
            // 
            // Player1Add1Life
            // 
            this.Player1Add1Life.Location = new System.Drawing.Point(136, 162);
            this.Player1Add1Life.Name = "Player1Add1Life";
            this.Player1Add1Life.Size = new System.Drawing.Size(58, 23);
            this.Player1Add1Life.TabIndex = 10;
            this.Player1Add1Life.Text = "+1";
            this.Player1Add1Life.UseVisualStyleBackColor = true;
            this.Player1Add1Life.Click += new System.EventHandler(this.P1Life);
            // 
            // Player1Add5Life
            // 
            this.Player1Add5Life.Location = new System.Drawing.Point(136, 184);
            this.Player1Add5Life.Name = "Player1Add5Life";
            this.Player1Add5Life.Size = new System.Drawing.Size(58, 23);
            this.Player1Add5Life.TabIndex = 11;
            this.Player1Add5Life.Text = "+5";
            this.Player1Add5Life.UseVisualStyleBackColor = true;
            this.Player1Add5Life.Click += new System.EventHandler(this.P1Life);
            // 
            // LifePlayer1
            // 
            this.LifePlayer1.AutoSize = true;
            this.LifePlayer1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LifePlayer1.Location = new System.Drawing.Point(76, 162);
            this.LifePlayer1.Name = "LifePlayer1";
            this.LifePlayer1.Size = new System.Drawing.Size(54, 45);
            this.LifePlayer1.TabIndex = 12;
            this.LifePlayer1.Text = "20";
            // 
            // LifePlayer2
            // 
            this.LifePlayer2.AutoSize = true;
            this.LifePlayer2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LifePlayer2.Location = new System.Drawing.Point(331, 162);
            this.LifePlayer2.Name = "LifePlayer2";
            this.LifePlayer2.Size = new System.Drawing.Size(54, 45);
            this.LifePlayer2.TabIndex = 25;
            this.LifePlayer2.Text = "20";
            // 
            // Player2Add5Life
            // 
            this.Player2Add5Life.Location = new System.Drawing.Point(391, 184);
            this.Player2Add5Life.Name = "Player2Add5Life";
            this.Player2Add5Life.Size = new System.Drawing.Size(58, 23);
            this.Player2Add5Life.TabIndex = 24;
            this.Player2Add5Life.Text = "+5";
            this.Player2Add5Life.UseVisualStyleBackColor = true;
            this.Player2Add5Life.Click += new System.EventHandler(this.P2Life);
            // 
            // Player2Add1Life
            // 
            this.Player2Add1Life.Location = new System.Drawing.Point(391, 162);
            this.Player2Add1Life.Name = "Player2Add1Life";
            this.Player2Add1Life.Size = new System.Drawing.Size(58, 23);
            this.Player2Add1Life.TabIndex = 23;
            this.Player2Add1Life.Text = "+1";
            this.Player2Add1Life.UseVisualStyleBackColor = true;
            this.Player2Add1Life.Click += new System.EventHandler(this.P2Life);
            // 
            // Player2Sub5Life
            // 
            this.Player2Sub5Life.Location = new System.Drawing.Point(267, 184);
            this.Player2Sub5Life.Name = "Player2Sub5Life";
            this.Player2Sub5Life.Size = new System.Drawing.Size(58, 23);
            this.Player2Sub5Life.TabIndex = 22;
            this.Player2Sub5Life.Text = "-5";
            this.Player2Sub5Life.UseVisualStyleBackColor = true;
            this.Player2Sub5Life.Click += new System.EventHandler(this.P2Life);
            // 
            // Player2Sub1Life
            // 
            this.Player2Sub1Life.Location = new System.Drawing.Point(267, 162);
            this.Player2Sub1Life.Name = "Player2Sub1Life";
            this.Player2Sub1Life.Size = new System.Drawing.Size(58, 23);
            this.Player2Sub1Life.TabIndex = 21;
            this.Player2Sub1Life.Text = "-1";
            this.Player2Sub1Life.UseVisualStyleBackColor = true;
            this.Player2Sub1Life.Click += new System.EventHandler(this.P2Life);
            // 
            // HeaderPlayer2Life
            // 
            this.HeaderPlayer2Life.AutoSize = true;
            this.HeaderPlayer2Life.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeaderPlayer2Life.Location = new System.Drawing.Point(267, 134);
            this.HeaderPlayer2Life.Name = "HeaderPlayer2Life";
            this.HeaderPlayer2Life.Size = new System.Drawing.Size(35, 25);
            this.HeaderPlayer2Life.TabIndex = 20;
            this.HeaderPlayer2Life.Text = "Liv";
            // 
            // P2Poison
            // 
            this.P2Poison.Location = new System.Drawing.Point(411, 101);
            this.P2Poison.Name = "P2Poison";
            this.P2Poison.Size = new System.Drawing.Size(38, 23);
            this.P2Poison.TabIndex = 19;
            this.P2Poison.ValueChanged += new System.EventHandler(this.P2Pois);
            // 
            // LabelPlayer2Poison
            // 
            this.LabelPlayer2Poison.AutoSize = true;
            this.LabelPlayer2Poison.Location = new System.Drawing.Point(362, 103);
            this.LabelPlayer2Poison.Name = "LabelPlayer2Poison";
            this.LabelPlayer2Poison.Size = new System.Drawing.Size(43, 15);
            this.LabelPlayer2Poison.TabIndex = 18;
            this.LabelPlayer2Poison.Text = "Poison";
            // 
            // LabelPlayer2Wins
            // 
            this.LabelPlayer2Wins.AutoSize = true;
            this.LabelPlayer2Wins.Location = new System.Drawing.Point(267, 103);
            this.LabelPlayer2Wins.Name = "LabelPlayer2Wins";
            this.LabelPlayer2Wins.Size = new System.Drawing.Size(43, 15);
            this.LabelPlayer2Wins.TabIndex = 17;
            this.LabelPlayer2Wins.Text = "Vinster";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(316, 101);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(40, 23);
            this.numericUpDown4.TabIndex = 16;
            this.numericUpDown4.ValueChanged += new System.EventHandler(this.P2Wins);
            // 
            // LabelPlayer2Name
            // 
            this.LabelPlayer2Name.AutoSize = true;
            this.LabelPlayer2Name.Location = new System.Drawing.Point(267, 54);
            this.LabelPlayer2Name.Name = "LabelPlayer2Name";
            this.LabelPlayer2Name.Size = new System.Drawing.Size(40, 15);
            this.LabelPlayer2Name.TabIndex = 15;
            this.LabelPlayer2Name.Text = "Namn";
            // 
            // TextBoxPlayer2Name
            // 
            this.TextBoxPlayer2Name.Location = new System.Drawing.Point(267, 72);
            this.TextBoxPlayer2Name.Name = "TextBoxPlayer2Name";
            this.TextBoxPlayer2Name.Size = new System.Drawing.Size(182, 23);
            this.TextBoxPlayer2Name.TabIndex = 14;
            this.TextBoxPlayer2Name.KeyUp += new System.Windows.Forms.KeyEventHandler(this.P2Name);
            // 
            // HeaderPlayer2
            // 
            this.HeaderPlayer2.AutoSize = true;
            this.HeaderPlayer2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeaderPlayer2.Location = new System.Drawing.Point(267, 9);
            this.HeaderPlayer2.Name = "HeaderPlayer2";
            this.HeaderPlayer2.Size = new System.Drawing.Size(98, 30);
            this.HeaderPlayer2.TabIndex = 13;
            this.HeaderPlayer2.Text = "Spelare 2";
            // 
            // SeachBox
            // 
            this.SeachBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.SeachBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.SeachBox.Location = new System.Drawing.Point(516, 42);
            this.SeachBox.Name = "SeachBox";
            this.SeachBox.PlaceholderText = "Ex ... Thoughtseize";
            this.SeachBox.Size = new System.Drawing.Size(272, 23);
            this.SeachBox.TabIndex = 26;
            this.SeachBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.seachBox_KeyUp);
            // 
            // HeaderSearchCard
            // 
            this.HeaderSearchCard.AutoSize = true;
            this.HeaderSearchCard.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeaderSearchCard.Location = new System.Drawing.Point(516, 9);
            this.HeaderSearchCard.Name = "HeaderSearchCard";
            this.HeaderSearchCard.Size = new System.Drawing.Size(88, 30);
            this.HeaderSearchCard.TabIndex = 27;
            this.HeaderSearchCard.Text = "Sök kort";
            // 
            // CardPreview
            // 
            this.CardPreview.Location = new System.Drawing.Point(541, 71);
            this.CardPreview.Name = "CardPreview";
            this.CardPreview.Size = new System.Drawing.Size(223, 310);
            this.CardPreview.TabIndex = 28;
            this.CardPreview.TabStop = false;
            // 
            // ShowCard
            // 
            this.ShowCard.Location = new System.Drawing.Point(438, 320);
            this.ShowCard.Name = "ShowCard";
            this.ShowCard.Size = new System.Drawing.Size(97, 23);
            this.ShowCard.TabIndex = 29;
            this.ShowCard.Text = "Ladda Kort";
            this.ShowCard.UseVisualStyleBackColor = true;
            this.ShowCard.Click += new System.EventHandler(this.button9_Click);
            // 
            // ResetLifeAndPoison
            // 
            this.ResetLifeAndPoison.Location = new System.Drawing.Point(12, 349);
            this.ResetLifeAndPoison.Name = "ResetLifeAndPoison";
            this.ResetLifeAndPoison.Size = new System.Drawing.Size(163, 23);
            this.ResetLifeAndPoison.TabIndex = 30;
            this.ResetLifeAndPoison.Text = "Nollställ Liv och Poison";
            this.ResetLifeAndPoison.UseVisualStyleBackColor = true;
            this.ResetLifeAndPoison.Click += new System.EventHandler(this.ResetWindsAndPoison);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(438, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Visa/Dölj Kort";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Speakerbooth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 386);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ResetLifeAndPoison);
            this.Controls.Add(this.ShowCard);
            this.Controls.Add(this.CardPreview);
            this.Controls.Add(this.HeaderSearchCard);
            this.Controls.Add(this.SeachBox);
            this.Controls.Add(this.LifePlayer2);
            this.Controls.Add(this.Player2Add5Life);
            this.Controls.Add(this.Player2Add1Life);
            this.Controls.Add(this.Player2Sub5Life);
            this.Controls.Add(this.Player2Sub1Life);
            this.Controls.Add(this.HeaderPlayer2Life);
            this.Controls.Add(this.P2Poison);
            this.Controls.Add(this.LabelPlayer2Poison);
            this.Controls.Add(this.LabelPlayer2Wins);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.LabelPlayer2Name);
            this.Controls.Add(this.TextBoxPlayer2Name);
            this.Controls.Add(this.HeaderPlayer2);
            this.Controls.Add(this.LifePlayer1);
            this.Controls.Add(this.Player1Add5Life);
            this.Controls.Add(this.Player1Add1Life);
            this.Controls.Add(this.Player1Sub5Life);
            this.Controls.Add(this.Player1Sub1Life);
            this.Controls.Add(this.HeaderPlayer1Life);
            this.Controls.Add(this.P1Poison);
            this.Controls.Add(this.LabelPlayer1Poison);
            this.Controls.Add(this.LabelPlayer1Wins);
            this.Controls.Add(this.pwin);
            this.Controls.Add(this.LabelPlayer1Name);
            this.Controls.Add(this.TextBoxPlayer1Name);
            this.Controls.Add(this.HeaderPlayer1);
            this.MaximumSize = new System.Drawing.Size(810, 425);
            this.MinimumSize = new System.Drawing.Size(810, 425);
            this.Name = "Speakerbooth";
            this.Text = "SpeakerBooth";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pwin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P1Poison)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2Poison)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderPlayer1;
        private System.Windows.Forms.TextBox TextBoxPlayer1Name;
        private System.Windows.Forms.Label LabelPlayer1Name;
        private System.Windows.Forms.NumericUpDown pwin;
        private System.Windows.Forms.Label LabelPlayer1Wins;
        private System.Windows.Forms.Label LabelPlayer1Poison;
        private System.Windows.Forms.NumericUpDown P1Poi;
        private System.Windows.Forms.Label HeaderPlayer1Life;
        private System.Windows.Forms.Button Player1Sub1Life;
        private System.Windows.Forms.Button Player1Sub5Life;
        private System.Windows.Forms.Button Player1Add1Life;
        private System.Windows.Forms.Button Player1Add5Life;
        private System.Windows.Forms.Label LifePlayer1;
        private System.Windows.Forms.Label LifePlayer2;
        private System.Windows.Forms.Button Player2Add5Life;
        private System.Windows.Forms.Button Player2Add1Life;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button Player2Sub1Life;
        private System.Windows.Forms.Label HeaderPlayer2Life;
        private System.Windows.Forms.NumericUpDown P2Poison;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LabelPlayer2Wins;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label LabelPlayer2Name;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label HeaderPlayer2;
        private System.Windows.Forms.TextBox SeachBox;
        private System.Windows.Forms.Label HeaderSearchCard;
        private System.Windows.Forms.PictureBox CardPreview;
        private System.Windows.Forms.Button ShowCard;
        private System.Windows.Forms.NumericUpDown P1Poison;
        private System.Windows.Forms.Button ResetLifeAndPoison;
        private System.Windows.Forms.TextBox TextBoxPlayer2Name;
        private System.Windows.Forms.Label LabelPlayer2Poison;
        private System.Windows.Forms.Button Player2Sub5Life;
        private System.Windows.Forms.Button button1;
    }
}

