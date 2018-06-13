namespace QuartettSim2k18
{
    partial class frmPreperation
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
            this.button_SpielStarten = new System.Windows.Forms.Button();
            this.panel_Gegner = new System.Windows.Forms.Panel();
            this.button2_Gegner = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label_Gegnerzahl = new System.Windows.Forms.Label();
            this.panel_Decks = new System.Windows.Forms.Panel();
            this.label_GewähltesDeck = new System.Windows.Forms.Label();
            this.button_DeckDef = new System.Windows.Forms.Button();
            this.label_DeckDef = new System.Windows.Forms.Label();
            this.button_DeckWählen = new System.Windows.Forms.Button();
            this.label_Deck = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton_QuartettAnzahl = new System.Windows.Forms.RadioButton();
            this.radioButton_LastManStanding = new System.Windows.Forms.RadioButton();
            this.radioButton_Zeit = new System.Windows.Forms.RadioButton();
            this.panel_Gegner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel_Decks.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_SpielStarten
            // 
            this.button_SpielStarten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SpielStarten.ForeColor = System.Drawing.Color.White;
            this.button_SpielStarten.Location = new System.Drawing.Point(17, 394);
            this.button_SpielStarten.Margin = new System.Windows.Forms.Padding(8);
            this.button_SpielStarten.Name = "button_SpielStarten";
            this.button_SpielStarten.Size = new System.Drawing.Size(301, 58);
            this.button_SpielStarten.TabIndex = 0;
            this.button_SpielStarten.Text = "Spiel Starten";
            this.button_SpielStarten.UseVisualStyleBackColor = true;
            this.button_SpielStarten.Click += new System.EventHandler(this.button_SpielStarten_Click);
            // 
            // panel_Gegner
            // 
            this.panel_Gegner.Controls.Add(this.button2_Gegner);
            this.panel_Gegner.Controls.Add(this.numericUpDown1);
            this.panel_Gegner.Controls.Add(this.label_Gegnerzahl);
            this.panel_Gegner.Location = new System.Drawing.Point(17, 12);
            this.panel_Gegner.Name = "panel_Gegner";
            this.panel_Gegner.Padding = new System.Windows.Forms.Padding(2);
            this.panel_Gegner.Size = new System.Drawing.Size(306, 100);
            this.panel_Gegner.TabIndex = 1;
            // 
            // button2_Gegner
            // 
            this.button2_Gegner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2_Gegner.Location = new System.Drawing.Point(11, 55);
            this.button2_Gegner.Name = "button2_Gegner";
            this.button2_Gegner.Size = new System.Drawing.Size(290, 40);
            this.button2_Gegner.TabIndex = 2;
            this.button2_Gegner.Text = "Gegner definieren";
            this.button2_Gegner.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(251, 5);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(50, 41);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label_Gegnerzahl
            // 
            this.label_Gegnerzahl.AutoSize = true;
            this.label_Gegnerzahl.Location = new System.Drawing.Point(5, 7);
            this.label_Gegnerzahl.Name = "label_Gegnerzahl";
            this.label_Gegnerzahl.Size = new System.Drawing.Size(177, 33);
            this.label_Gegnerzahl.TabIndex = 0;
            this.label_Gegnerzahl.Text = "Anzahl Gegner";
            // 
            // panel_Decks
            // 
            this.panel_Decks.Controls.Add(this.label_GewähltesDeck);
            this.panel_Decks.Controls.Add(this.button_DeckDef);
            this.panel_Decks.Controls.Add(this.label_DeckDef);
            this.panel_Decks.Controls.Add(this.button_DeckWählen);
            this.panel_Decks.Controls.Add(this.label_Deck);
            this.panel_Decks.Location = new System.Drawing.Point(17, 118);
            this.panel_Decks.Name = "panel_Decks";
            this.panel_Decks.Padding = new System.Windows.Forms.Padding(2);
            this.panel_Decks.Size = new System.Drawing.Size(306, 116);
            this.panel_Decks.TabIndex = 2;
            // 
            // label_GewähltesDeck
            // 
            this.label_GewähltesDeck.AutoSize = true;
            this.label_GewähltesDeck.Location = new System.Drawing.Point(5, 68);
            this.label_GewähltesDeck.Name = "label_GewähltesDeck";
            this.label_GewähltesDeck.Size = new System.Drawing.Size(192, 33);
            this.label_GewähltesDeck.TabIndex = 4;
            this.label_GewähltesDeck.Text = "Gewähltes Deck";
            // 
            // button_DeckDef
            // 
            this.button_DeckDef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DeckDef.Location = new System.Drawing.Point(209, 39);
            this.button_DeckDef.Name = "button_DeckDef";
            this.button_DeckDef.Size = new System.Drawing.Size(92, 29);
            this.button_DeckDef.TabIndex = 3;
            this.button_DeckDef.UseVisualStyleBackColor = true;
            this.button_DeckDef.Click += new System.EventHandler(this.button_DeckDef_Click);
            // 
            // label_DeckDef
            // 
            this.label_DeckDef.AutoSize = true;
            this.label_DeckDef.Location = new System.Drawing.Point(5, 35);
            this.label_DeckDef.Name = "label_DeckDef";
            this.label_DeckDef.Size = new System.Drawing.Size(213, 33);
            this.label_DeckDef.TabIndex = 2;
            this.label_DeckDef.Text = "Decks definieren:";
            // 
            // button_DeckWählen
            // 
            this.button_DeckWählen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DeckWählen.Location = new System.Drawing.Point(209, 6);
            this.button_DeckWählen.Name = "button_DeckWählen";
            this.button_DeckWählen.Size = new System.Drawing.Size(92, 29);
            this.button_DeckWählen.TabIndex = 1;
            this.button_DeckWählen.UseVisualStyleBackColor = true;
            this.button_DeckWählen.Click += new System.EventHandler(this.button_DeckWählen_Click);
            // 
            // label_Deck
            // 
            this.label_Deck.AutoSize = true;
            this.label_Deck.Location = new System.Drawing.Point(5, 2);
            this.label_Deck.Name = "label_Deck";
            this.label_Deck.Size = new System.Drawing.Size(197, 33);
            this.label_Deck.TabIndex = 0;
            this.label_Deck.Text = "Deck auswählen:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton_QuartettAnzahl);
            this.panel1.Controls.Add(this.radioButton_LastManStanding);
            this.panel1.Controls.Add(this.radioButton_Zeit);
            this.panel1.Location = new System.Drawing.Point(17, 240);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(2);
            this.panel1.Size = new System.Drawing.Size(306, 130);
            this.panel1.TabIndex = 3;
            // 
            // radioButton_QuartettAnzahl
            // 
            this.radioButton_QuartettAnzahl.AutoSize = true;
            this.radioButton_QuartettAnzahl.Location = new System.Drawing.Point(17, 88);
            this.radioButton_QuartettAnzahl.Name = "radioButton_QuartettAnzahl";
            this.radioButton_QuartettAnzahl.Size = new System.Drawing.Size(154, 37);
            this.radioButton_QuartettAnzahl.TabIndex = 2;
            this.radioButton_QuartettAnzahl.TabStop = true;
            this.radioButton_QuartettAnzahl.Text = "4 Quartett";
            this.radioButton_QuartettAnzahl.UseVisualStyleBackColor = true;
            this.radioButton_QuartettAnzahl.Visible = false;
            // 
            // radioButton_LastManStanding
            // 
            this.radioButton_LastManStanding.AutoSize = true;
            this.radioButton_LastManStanding.Location = new System.Drawing.Point(17, 48);
            this.radioButton_LastManStanding.Name = "radioButton_LastManStanding";
            this.radioButton_LastManStanding.Size = new System.Drawing.Size(231, 37);
            this.radioButton_LastManStanding.TabIndex = 1;
            this.radioButton_LastManStanding.TabStop = true;
            this.radioButton_LastManStanding.Text = "Last man standing";
            this.radioButton_LastManStanding.UseVisualStyleBackColor = true;
            this.radioButton_LastManStanding.Visible = false;
            // 
            // radioButton_Zeit
            // 
            this.radioButton_Zeit.AutoSize = true;
            this.radioButton_Zeit.Location = new System.Drawing.Point(17, 5);
            this.radioButton_Zeit.Name = "radioButton_Zeit";
            this.radioButton_Zeit.Size = new System.Drawing.Size(128, 37);
            this.radioButton_Zeit.TabIndex = 0;
            this.radioButton_Zeit.TabStop = true;
            this.radioButton_Zeit.Text = "Auf Zeit";
            this.radioButton_Zeit.UseVisualStyleBackColor = true;
            this.radioButton_Zeit.Visible = false;
            // 
            // frmPreperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(36)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(335, 469);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_Decks);
            this.Controls.Add(this.panel_Gegner);
            this.Controls.Add(this.button_SpielStarten);
            this.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPreperation";
            this.Text = "frmPreperation";
            this.panel_Gegner.ResumeLayout(false);
            this.panel_Gegner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel_Decks.ResumeLayout(false);
            this.panel_Decks.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_SpielStarten;
        private System.Windows.Forms.Panel panel_Gegner;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label_Gegnerzahl;
        private System.Windows.Forms.Button button2_Gegner;
        private System.Windows.Forms.Panel panel_Decks;
        private System.Windows.Forms.Button button_DeckWählen;
        private System.Windows.Forms.Label label_Deck;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label_GewähltesDeck;
        private System.Windows.Forms.Button button_DeckDef;
        private System.Windows.Forms.Label label_DeckDef;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton_QuartettAnzahl;
        private System.Windows.Forms.RadioButton radioButton_LastManStanding;
        private System.Windows.Forms.RadioButton radioButton_Zeit;
    }
}