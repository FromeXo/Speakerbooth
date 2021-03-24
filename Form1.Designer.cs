
namespace Speakerbooth
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pwin = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.P1Poi = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.P2Poison = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.seachBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pwin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P1Poi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2Poison)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Spelare 1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.P1Name);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Namn";
            // 
            // pwin
            // 
            this.pwin.Location = new System.Drawing.Point(61, 101);
            this.pwin.Name = "pwin";
            this.pwin.Size = new System.Drawing.Size(40, 23);
            this.pwin.TabIndex = 3;
            this.pwin.ValueChanged += new System.EventHandler(this.P1Wins);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vinster";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Poison";
            // 
            // P1Poi
            // 
            this.P1Poi.Location = new System.Drawing.Point(156, 101);
            this.P1Poi.Name = "P1Poi";
            this.P1Poi.Size = new System.Drawing.Size(38, 23);
            this.P1Poi.TabIndex = 6;
            this.P1Poi.ValueChanged += new System.EventHandler(this.P1Pois);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Liv";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "-1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.P1Life);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "-5";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.P1Life);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(136, 162);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "+1";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.P1Life);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(136, 184);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(58, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "+5";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.P1Life);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(76, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 45);
            this.label6.TabIndex = 12;
            this.label6.Text = "20";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(331, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 45);
            this.label7.TabIndex = 25;
            this.label7.Text = "20";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(391, 184);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(58, 23);
            this.button5.TabIndex = 24;
            this.button5.Text = "+5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.P2Life);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(391, 162);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(58, 23);
            this.button6.TabIndex = 23;
            this.button6.Text = "+1";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.P2Life);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(267, 184);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(58, 23);
            this.button7.TabIndex = 22;
            this.button7.Text = "-5";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.P2Life);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(267, 162);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(58, 23);
            this.button8.TabIndex = 21;
            this.button8.Text = "-1";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.P2Life);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(267, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "Liv";
            // 
            // P2Poison
            // 
            this.P2Poison.Location = new System.Drawing.Point(411, 101);
            this.P2Poison.Name = "P2Poison";
            this.P2Poison.Size = new System.Drawing.Size(38, 23);
            this.P2Poison.TabIndex = 19;
            this.P2Poison.ValueChanged += new System.EventHandler(this.P2Pois);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(362, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Poison";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(267, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "Vinster";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(316, 101);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(40, 23);
            this.numericUpDown4.TabIndex = 16;
            this.numericUpDown4.ValueChanged += new System.EventHandler(this.P2Wins);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(267, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 15);
            this.label11.TabIndex = 15;
            this.label11.Text = "Namn";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(267, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(182, 23);
            this.textBox2.TabIndex = 14;
            this.textBox2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.P2Name);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(267, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 30);
            this.label12.TabIndex = 13;
            this.label12.Text = "Spelare 2";
            // 
            // seachBox
            // 
            this.seachBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.seachBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.seachBox.Location = new System.Drawing.Point(516, 42);
            this.seachBox.Name = "seachBox";
            this.seachBox.PlaceholderText = "Ex ... Thoughtseize";
            this.seachBox.Size = new System.Drawing.Size(272, 23);
            this.seachBox.TabIndex = 26;
            this.seachBox.TextChanged += new System.EventHandler(this.seachBox_TextChanged);
            this.seachBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.seachBox_KeyUp);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(516, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 30);
            this.label13.TabIndex = 27;
            this.label13.Text = "Sök kort";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(541, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 310);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(615, 349);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 29;
            this.button9.Text = "Visa";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(12, 349);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(163, 23);
            this.button10.TabIndex = 30;
            this.button10.Text = "Nollställ Liv och Poison";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 386);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.seachBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.P2Poison);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.P1Poi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pwin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(810, 425);
            this.MinimumSize = new System.Drawing.Size(810, 425);
            this.Name = "Form1";
            this.Text = "SpeakerBooth";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.button10_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pwin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P1Poi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2Poison)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown pwin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown P1Poi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown P2Poison;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox seachBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.NumericUpDown P1Poison;
        private System.Windows.Forms.Button button10;
    }
}

