
namespace Speakerbooth.Forms
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Player1GrpBox = new System.Windows.Forms.GroupBox();
            this.Player1Tbl = new System.Windows.Forms.TableLayoutPanel();
            this.P1NameLabel = new System.Windows.Forms.Label();
            this.P1Name = new System.Windows.Forms.TextBox();
            this.Player1PoiWinTbl = new System.Windows.Forms.TableLayoutPanel();
            this.P1WinsLabel = new System.Windows.Forms.Label();
            this.P1PoisonLabel = new System.Windows.Forms.Label();
            this.P1Wins = new System.Windows.Forms.NumericUpDown();
            this.P1Poison = new System.Windows.Forms.NumericUpDown();
            this.P1ArchetypeLabel = new System.Windows.Forms.Label();
            this.P1Archetype = new System.Windows.Forms.TextBox();
            this.Player2GrpBox = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.P1Sub5Btn = new System.Windows.Forms.Button();
            this.P1Sub1Btn = new System.Windows.Forms.Button();
            this.P1Add1Btn = new System.Windows.Forms.Button();
            this.P1Add5Btn = new System.Windows.Forms.Button();
            this.P1LifeLabel = new System.Windows.Forms.Label();
            this.P1LifeValue = new System.Windows.Forms.Label();
            this.ImageActionPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.LoadCardBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.DeckListBtn = new System.Windows.Forms.Button();
            this.ResetLifePoisonBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.P2NameLabel = new System.Windows.Forms.Label();
            this.P2Name = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.P2WinsLabel = new System.Windows.Forms.Label();
            this.P2PoisonLabel = new System.Windows.Forms.Label();
            this.P2Wins = new System.Windows.Forms.NumericUpDown();
            this.P2Poison = new System.Windows.Forms.NumericUpDown();
            this.P2ArchetypeLabel = new System.Windows.Forms.Label();
            this.P2Archetype = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.P2LifeValue = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.P2Add5Btn = new System.Windows.Forms.Button();
            this.P2Add1Btn = new System.Windows.Forms.Button();
            this.P2Sub1Btn = new System.Windows.Forms.Button();
            this.P2Sub5Btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.SearchCard = new System.Windows.Forms.TextBox();
            this.CardPreview = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.Player1GrpBox.SuspendLayout();
            this.Player1Tbl.SuspendLayout();
            this.Player1PoiWinTbl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.P1Wins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P1Poison)).BeginInit();
            this.Player2GrpBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ImageActionPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.P2Wins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2Poison)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CardPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.Controls.Add(this.Player1GrpBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Player2GrpBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ImageActionPanel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Player1GrpBox
            // 
            this.Player1GrpBox.Controls.Add(this.Player1Tbl);
            this.Player1GrpBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Player1GrpBox.Location = new System.Drawing.Point(3, 3);
            this.Player1GrpBox.Name = "Player1GrpBox";
            this.Player1GrpBox.Size = new System.Drawing.Size(269, 409);
            this.Player1GrpBox.TabIndex = 0;
            this.Player1GrpBox.TabStop = false;
            this.Player1GrpBox.Text = "Spelare 1";
            // 
            // Player1Tbl
            // 
            this.Player1Tbl.ColumnCount = 1;
            this.Player1Tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Player1Tbl.Controls.Add(this.P1NameLabel, 0, 0);
            this.Player1Tbl.Controls.Add(this.P1Name, 0, 1);
            this.Player1Tbl.Controls.Add(this.Player1PoiWinTbl, 0, 4);
            this.Player1Tbl.Controls.Add(this.P1ArchetypeLabel, 0, 2);
            this.Player1Tbl.Controls.Add(this.P1Archetype, 0, 3);
            this.Player1Tbl.Controls.Add(this.panel1, 0, 5);
            this.Player1Tbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Player1Tbl.Location = new System.Drawing.Point(3, 19);
            this.Player1Tbl.Name = "Player1Tbl";
            this.Player1Tbl.RowCount = 6;
            this.Player1Tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.Player1Tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.Player1Tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.Player1Tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.Player1Tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.Player1Tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Player1Tbl.Size = new System.Drawing.Size(263, 387);
            this.Player1Tbl.TabIndex = 0;
            // 
            // P1NameLabel
            // 
            this.P1NameLabel.AutoSize = true;
            this.P1NameLabel.Location = new System.Drawing.Point(3, 0);
            this.P1NameLabel.Name = "P1NameLabel";
            this.P1NameLabel.Size = new System.Drawing.Size(40, 15);
            this.P1NameLabel.TabIndex = 0;
            this.P1NameLabel.Text = "Namn";
            // 
            // P1Name
            // 
            this.P1Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.P1Name.Location = new System.Drawing.Point(3, 19);
            this.P1Name.Name = "P1Name";
            this.P1Name.Size = new System.Drawing.Size(257, 23);
            this.P1Name.TabIndex = 1;
            this.P1Name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.P1Name_KeyDown);
            // 
            // Player1PoiWinTbl
            // 
            this.Player1PoiWinTbl.ColumnCount = 2;
            this.Player1PoiWinTbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Player1PoiWinTbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Player1PoiWinTbl.Controls.Add(this.P1WinsLabel, 0, 0);
            this.Player1PoiWinTbl.Controls.Add(this.P1PoisonLabel, 1, 0);
            this.Player1PoiWinTbl.Controls.Add(this.P1Wins, 0, 1);
            this.Player1PoiWinTbl.Controls.Add(this.P1Poison, 1, 1);
            this.Player1PoiWinTbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Player1PoiWinTbl.Location = new System.Drawing.Point(3, 95);
            this.Player1PoiWinTbl.Name = "Player1PoiWinTbl";
            this.Player1PoiWinTbl.RowCount = 2;
            this.Player1PoiWinTbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.Player1PoiWinTbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Player1PoiWinTbl.Size = new System.Drawing.Size(257, 49);
            this.Player1PoiWinTbl.TabIndex = 2;
            // 
            // P1WinsLabel
            // 
            this.P1WinsLabel.AutoSize = true;
            this.P1WinsLabel.Location = new System.Drawing.Point(3, 0);
            this.P1WinsLabel.Name = "P1WinsLabel";
            this.P1WinsLabel.Size = new System.Drawing.Size(33, 15);
            this.P1WinsLabel.TabIndex = 0;
            this.P1WinsLabel.Text = "Wins";
            // 
            // P1PoisonLabel
            // 
            this.P1PoisonLabel.AutoSize = true;
            this.P1PoisonLabel.Location = new System.Drawing.Point(131, 0);
            this.P1PoisonLabel.Name = "P1PoisonLabel";
            this.P1PoisonLabel.Size = new System.Drawing.Size(43, 15);
            this.P1PoisonLabel.TabIndex = 1;
            this.P1PoisonLabel.Text = "Poison";
            // 
            // P1Wins
            // 
            this.P1Wins.Location = new System.Drawing.Point(3, 19);
            this.P1Wins.Name = "P1Wins";
            this.P1Wins.Size = new System.Drawing.Size(120, 23);
            this.P1Wins.TabIndex = 2;
            this.P1Wins.ValueChanged += new System.EventHandler(this.P1Wins_ValueChanged);
            // 
            // P1Poison
            // 
            this.P1Poison.Location = new System.Drawing.Point(131, 19);
            this.P1Poison.Name = "P1Poison";
            this.P1Poison.Size = new System.Drawing.Size(120, 23);
            this.P1Poison.TabIndex = 3;
            this.P1Poison.ValueChanged += new System.EventHandler(this.P1Poison_ValueChanged);
            // 
            // P1ArchetypeLabel
            // 
            this.P1ArchetypeLabel.AutoSize = true;
            this.P1ArchetypeLabel.Location = new System.Drawing.Point(3, 46);
            this.P1ArchetypeLabel.Name = "P1ArchetypeLabel";
            this.P1ArchetypeLabel.Size = new System.Drawing.Size(48, 15);
            this.P1ArchetypeLabel.TabIndex = 3;
            this.P1ArchetypeLabel.Text = "Arketyp";
            // 
            // P1Archetype
            // 
            this.P1Archetype.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.P1Archetype.Location = new System.Drawing.Point(3, 65);
            this.P1Archetype.Name = "P1Archetype";
            this.P1Archetype.Size = new System.Drawing.Size(257, 23);
            this.P1Archetype.TabIndex = 4;
            this.P1Archetype.KeyDown += new System.Windows.Forms.KeyEventHandler(this.P1Archetype_KeyDown);
            // 
            // Player2GrpBox
            // 
            this.Player2GrpBox.Controls.Add(this.tableLayoutPanel2);
            this.Player2GrpBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Player2GrpBox.Location = new System.Drawing.Point(278, 3);
            this.Player2GrpBox.Name = "Player2GrpBox";
            this.Player2GrpBox.Size = new System.Drawing.Size(269, 409);
            this.Player2GrpBox.TabIndex = 1;
            this.Player2GrpBox.TabStop = false;
            this.Player2GrpBox.Text = "Spelare 2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.P1LifeValue);
            this.panel1.Controls.Add(this.P1LifeLabel);
            this.panel1.Controls.Add(this.P1Add5Btn);
            this.panel1.Controls.Add(this.P1Add1Btn);
            this.panel1.Controls.Add(this.P1Sub1Btn);
            this.panel1.Controls.Add(this.P1Sub5Btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 234);
            this.panel1.TabIndex = 5;
            // 
            // P1Sub5Btn
            // 
            this.P1Sub5Btn.Location = new System.Drawing.Point(3, 71);
            this.P1Sub5Btn.Name = "P1Sub5Btn";
            this.P1Sub5Btn.Size = new System.Drawing.Size(75, 23);
            this.P1Sub5Btn.TabIndex = 0;
            this.P1Sub5Btn.Text = "-5";
            this.P1Sub5Btn.UseVisualStyleBackColor = true;
            this.P1Sub5Btn.Click += new System.EventHandler(this.P1Life);
            // 
            // P1Sub1Btn
            // 
            this.P1Sub1Btn.Location = new System.Drawing.Point(3, 42);
            this.P1Sub1Btn.Name = "P1Sub1Btn";
            this.P1Sub1Btn.Size = new System.Drawing.Size(75, 23);
            this.P1Sub1Btn.TabIndex = 1;
            this.P1Sub1Btn.Text = "-1";
            this.P1Sub1Btn.UseVisualStyleBackColor = true;
            this.P1Sub1Btn.Click += new System.EventHandler(this.P1Life);
            // 
            // P1Add1Btn
            // 
            this.P1Add1Btn.Location = new System.Drawing.Point(176, 42);
            this.P1Add1Btn.Name = "P1Add1Btn";
            this.P1Add1Btn.Size = new System.Drawing.Size(75, 23);
            this.P1Add1Btn.TabIndex = 2;
            this.P1Add1Btn.Text = "+1";
            this.P1Add1Btn.UseVisualStyleBackColor = true;
            this.P1Add1Btn.Click += new System.EventHandler(this.P1Life);
            // 
            // P1Add5Btn
            // 
            this.P1Add5Btn.Location = new System.Drawing.Point(176, 71);
            this.P1Add5Btn.Name = "P1Add5Btn";
            this.P1Add5Btn.Size = new System.Drawing.Size(75, 23);
            this.P1Add5Btn.TabIndex = 3;
            this.P1Add5Btn.Text = "+5";
            this.P1Add5Btn.UseVisualStyleBackColor = true;
            this.P1Add5Btn.Click += new System.EventHandler(this.P1Life);
            // 
            // P1LifeLabel
            // 
            this.P1LifeLabel.AutoSize = true;
            this.P1LifeLabel.Location = new System.Drawing.Point(3, 0);
            this.P1LifeLabel.Name = "P1LifeLabel";
            this.P1LifeLabel.Size = new System.Drawing.Size(22, 15);
            this.P1LifeLabel.TabIndex = 4;
            this.P1LifeLabel.Text = "Liv";
            // 
            // P1LifeValue
            // 
            this.P1LifeValue.AutoSize = true;
            this.P1LifeValue.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.P1LifeValue.Location = new System.Drawing.Point(98, 42);
            this.P1LifeValue.Name = "P1LifeValue";
            this.P1LifeValue.Size = new System.Drawing.Size(58, 47);
            this.P1LifeValue.TabIndex = 5;
            this.P1LifeValue.Text = "20";
            // 
            // ImageActionPanel
            // 
            this.ImageActionPanel.Controls.Add(this.LoadCardBtn);
            this.ImageActionPanel.Controls.Add(this.button3);
            this.ImageActionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImageActionPanel.Location = new System.Drawing.Point(553, 418);
            this.ImageActionPanel.Name = "ImageActionPanel";
            this.ImageActionPanel.Size = new System.Drawing.Size(244, 29);
            this.ImageActionPanel.TabIndex = 3;
            // 
            // LoadCardBtn
            // 
            this.LoadCardBtn.Location = new System.Drawing.Point(3, 3);
            this.LoadCardBtn.Name = "LoadCardBtn";
            this.LoadCardBtn.Size = new System.Drawing.Size(127, 23);
            this.LoadCardBtn.TabIndex = 0;
            this.LoadCardBtn.Text = "Visa Kort i Fönster";
            this.LoadCardBtn.UseVisualStyleBackColor = true;
            this.LoadCardBtn.Click += new System.EventHandler(this.LoadCardBtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(136, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Dölj aktivt Kort";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.DeckListBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 418);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(269, 29);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.ResetLifePoisonBtn);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(278, 418);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(269, 29);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // DeckListBtn
            // 
            this.DeckListBtn.Location = new System.Drawing.Point(3, 3);
            this.DeckListBtn.Name = "DeckListBtn";
            this.DeckListBtn.Size = new System.Drawing.Size(75, 23);
            this.DeckListBtn.TabIndex = 0;
            this.DeckListBtn.Text = "Decklist";
            this.DeckListBtn.UseVisualStyleBackColor = true;
            this.DeckListBtn.Click += new System.EventHandler(this.EditDecklistBtn_Click);
            // 
            // ResetLifePoisonBtn
            // 
            this.ResetLifePoisonBtn.Location = new System.Drawing.Point(3, 3);
            this.ResetLifePoisonBtn.Name = "ResetLifePoisonBtn";
            this.ResetLifePoisonBtn.Size = new System.Drawing.Size(177, 23);
            this.ResetLifePoisonBtn.TabIndex = 0;
            this.ResetLifePoisonBtn.Text = "Nollställ Liv och Poison";
            this.ResetLifePoisonBtn.UseVisualStyleBackColor = true;
            this.ResetLifePoisonBtn.Click += new System.EventHandler(this.ResetLifePoisonBtn_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.P2NameLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.P2Name, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.P2ArchetypeLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.P2Archetype, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(263, 387);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // P2NameLabel
            // 
            this.P2NameLabel.AutoSize = true;
            this.P2NameLabel.Location = new System.Drawing.Point(3, 0);
            this.P2NameLabel.Name = "P2NameLabel";
            this.P2NameLabel.Size = new System.Drawing.Size(40, 15);
            this.P2NameLabel.TabIndex = 0;
            this.P2NameLabel.Text = "Namn";
            // 
            // P2Name
            // 
            this.P2Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.P2Name.Location = new System.Drawing.Point(3, 19);
            this.P2Name.Name = "P2Name";
            this.P2Name.Size = new System.Drawing.Size(257, 23);
            this.P2Name.TabIndex = 1;
            this.P2Name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.P2Name_KeyDown);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.P2WinsLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.P2PoisonLabel, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.P2Wins, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.P2Poison, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 95);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(257, 49);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // P2WinsLabel
            // 
            this.P2WinsLabel.AutoSize = true;
            this.P2WinsLabel.Location = new System.Drawing.Point(3, 0);
            this.P2WinsLabel.Name = "P2WinsLabel";
            this.P2WinsLabel.Size = new System.Drawing.Size(33, 15);
            this.P2WinsLabel.TabIndex = 0;
            this.P2WinsLabel.Text = "Wins";
            // 
            // P2PoisonLabel
            // 
            this.P2PoisonLabel.AutoSize = true;
            this.P2PoisonLabel.Location = new System.Drawing.Point(131, 0);
            this.P2PoisonLabel.Name = "P2PoisonLabel";
            this.P2PoisonLabel.Size = new System.Drawing.Size(43, 15);
            this.P2PoisonLabel.TabIndex = 1;
            this.P2PoisonLabel.Text = "Poison";
            // 
            // P2Wins
            // 
            this.P2Wins.Location = new System.Drawing.Point(3, 19);
            this.P2Wins.Name = "P2Wins";
            this.P2Wins.Size = new System.Drawing.Size(120, 23);
            this.P2Wins.TabIndex = 2;
            this.P2Wins.ValueChanged += new System.EventHandler(this.P2Wins_ValueChanged);
            // 
            // P2Poison
            // 
            this.P2Poison.Location = new System.Drawing.Point(131, 19);
            this.P2Poison.Name = "P2Poison";
            this.P2Poison.Size = new System.Drawing.Size(120, 23);
            this.P2Poison.TabIndex = 3;
            this.P2Poison.ValueChanged += new System.EventHandler(this.P2Poison_ValueChanged);
            // 
            // P2ArchetypeLabel
            // 
            this.P2ArchetypeLabel.AutoSize = true;
            this.P2ArchetypeLabel.Location = new System.Drawing.Point(3, 46);
            this.P2ArchetypeLabel.Name = "P2ArchetypeLabel";
            this.P2ArchetypeLabel.Size = new System.Drawing.Size(48, 15);
            this.P2ArchetypeLabel.TabIndex = 3;
            this.P2ArchetypeLabel.Text = "Arketyp";
            // 
            // P2Archetype
            // 
            this.P2Archetype.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.P2Archetype.Location = new System.Drawing.Point(3, 65);
            this.P2Archetype.Name = "P2Archetype";
            this.P2Archetype.Size = new System.Drawing.Size(257, 23);
            this.P2Archetype.TabIndex = 4;
            this.P2Archetype.KeyDown += new System.Windows.Forms.KeyEventHandler(this.P2Archetype_KeyDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.P2LifeValue);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.P2Add5Btn);
            this.panel2.Controls.Add(this.P2Add1Btn);
            this.panel2.Controls.Add(this.P2Sub1Btn);
            this.panel2.Controls.Add(this.P2Sub5Btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 234);
            this.panel2.TabIndex = 5;
            // 
            // P2LifeValue
            // 
            this.P2LifeValue.AutoSize = true;
            this.P2LifeValue.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.P2LifeValue.Location = new System.Drawing.Point(98, 42);
            this.P2LifeValue.Name = "P2LifeValue";
            this.P2LifeValue.Size = new System.Drawing.Size(58, 47);
            this.P2LifeValue.TabIndex = 5;
            this.P2LifeValue.Text = "20";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Liv";
            // 
            // P2Add5Btn
            // 
            this.P2Add5Btn.Location = new System.Drawing.Point(176, 71);
            this.P2Add5Btn.Name = "P2Add5Btn";
            this.P2Add5Btn.Size = new System.Drawing.Size(75, 23);
            this.P2Add5Btn.TabIndex = 3;
            this.P2Add5Btn.Text = "+5";
            this.P2Add5Btn.UseVisualStyleBackColor = true;
            this.P2Add5Btn.Click += new System.EventHandler(this.P2Life);
            // 
            // P2Add1Btn
            // 
            this.P2Add1Btn.Location = new System.Drawing.Point(176, 42);
            this.P2Add1Btn.Name = "P2Add1Btn";
            this.P2Add1Btn.Size = new System.Drawing.Size(75, 23);
            this.P2Add1Btn.TabIndex = 2;
            this.P2Add1Btn.Text = "+1";
            this.P2Add1Btn.UseVisualStyleBackColor = true;
            this.P2Add1Btn.Click += new System.EventHandler(this.P2Life);
            // 
            // P2Sub1Btn
            // 
            this.P2Sub1Btn.Location = new System.Drawing.Point(3, 42);
            this.P2Sub1Btn.Name = "P2Sub1Btn";
            this.P2Sub1Btn.Size = new System.Drawing.Size(75, 23);
            this.P2Sub1Btn.TabIndex = 1;
            this.P2Sub1Btn.Text = "-1";
            this.P2Sub1Btn.UseVisualStyleBackColor = true;
            this.P2Sub1Btn.Click += new System.EventHandler(this.P2Life);
            // 
            // P2Sub5Btn
            // 
            this.P2Sub5Btn.Location = new System.Drawing.Point(3, 71);
            this.P2Sub5Btn.Name = "P2Sub5Btn";
            this.P2Sub5Btn.Size = new System.Drawing.Size(75, 23);
            this.P2Sub5Btn.TabIndex = 0;
            this.P2Sub5Btn.Text = "-5";
            this.P2Sub5Btn.UseVisualStyleBackColor = true;
            this.P2Sub5Btn.Click += new System.EventHandler(this.P2Life);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.SearchCard, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.CardPreview, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(553, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(244, 409);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // SearchCard
            // 
            this.SearchCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchCard.Location = new System.Drawing.Point(3, 3);
            this.SearchCard.Name = "SearchCard";
            this.SearchCard.PlaceholderText = "Sök Kort";
            this.SearchCard.Size = new System.Drawing.Size(238, 23);
            this.SearchCard.TabIndex = 0;
            this.SearchCard.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchCard_KeyDown);
            // 
            // CardPreview
            // 
            this.CardPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CardPreview.Location = new System.Drawing.Point(3, 33);
            this.CardPreview.Name = "CardPreview";
            this.CardPreview.Size = new System.Drawing.Size(238, 373);
            this.CardPreview.TabIndex = 1;
            this.CardPreview.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(800, 480);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.Player1GrpBox.ResumeLayout(false);
            this.Player1Tbl.ResumeLayout(false);
            this.Player1Tbl.PerformLayout();
            this.Player1PoiWinTbl.ResumeLayout(false);
            this.Player1PoiWinTbl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.P1Wins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P1Poison)).EndInit();
            this.Player2GrpBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ImageActionPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.P2Wins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2Poison)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CardPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox Player1GrpBox;
        private System.Windows.Forms.TableLayoutPanel Player1Tbl;
        private System.Windows.Forms.Label P1NameLabel;
        private System.Windows.Forms.TextBox P1Name;
        private System.Windows.Forms.GroupBox Player2GrpBox;
        private System.Windows.Forms.TableLayoutPanel Player1PoiWinTbl;
        private System.Windows.Forms.Label P1WinsLabel;
        private System.Windows.Forms.Label P1PoisonLabel;
        private System.Windows.Forms.NumericUpDown P1Wins;
        private System.Windows.Forms.NumericUpDown P1Poison;
        private System.Windows.Forms.Label P1ArchetypeLabel;
        private System.Windows.Forms.TextBox P1Archetype;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label P1LifeValue;
        private System.Windows.Forms.Label P1LifeLabel;
        private System.Windows.Forms.Button P1Add5Btn;
        private System.Windows.Forms.Button P1Add1Btn;
        private System.Windows.Forms.Button P1Sub1Btn;
        private System.Windows.Forms.Button P1Sub5Btn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label P2NameLabel;
        private System.Windows.Forms.TextBox P2Name;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label P2WinsLabel;
        private System.Windows.Forms.Label P2PoisonLabel;
        private System.Windows.Forms.NumericUpDown P2Wins;
        private System.Windows.Forms.NumericUpDown P2Poison;
        private System.Windows.Forms.Label P2ArchetypeLabel;
        private System.Windows.Forms.TextBox P2Archetype;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label P2LifeValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button P2Add5Btn;
        private System.Windows.Forms.Button P2Add1Btn;
        private System.Windows.Forms.Button P2Sub1Btn;
        private System.Windows.Forms.Button P2Sub5Btn;
        private System.Windows.Forms.FlowLayoutPanel ImageActionPanel;
        private System.Windows.Forms.Button LoadCardBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button DeckListBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button ResetLifePoisonBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox SearchCard;
        private System.Windows.Forms.PictureBox CardPreview;
    }
}