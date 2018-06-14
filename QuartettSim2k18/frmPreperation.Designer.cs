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
            this.panel_Decks = new System.Windows.Forms.Panel();
            this.label_GewähltesDeck = new System.Windows.Forms.Label();
            this.button_DeckDef = new System.Windows.Forms.Button();
            this.label_DeckDef = new System.Windows.Forms.Label();
            this.button_DeckWählen = new System.Windows.Forms.Button();
            this.label_Deck = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel_Decks.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_SpielStarten
            // 
            this.button_SpielStarten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SpielStarten.ForeColor = System.Drawing.Color.White;
            this.button_SpielStarten.Location = new System.Drawing.Point(15, 135);
            this.button_SpielStarten.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.button_SpielStarten.Name = "button_SpielStarten";
            this.button_SpielStarten.Size = new System.Drawing.Size(287, 56);
            this.button_SpielStarten.TabIndex = 0;
            this.button_SpielStarten.Text = "Spiel Starten";
            this.button_SpielStarten.UseVisualStyleBackColor = true;
            this.button_SpielStarten.Click += new System.EventHandler(this.button_SpielStarten_Click);
            // 
            // panel_Decks
            // 
            this.panel_Decks.Controls.Add(this.label_GewähltesDeck);
            this.panel_Decks.Controls.Add(this.button_DeckDef);
            this.panel_Decks.Controls.Add(this.label_DeckDef);
            this.panel_Decks.Controls.Add(this.button_DeckWählen);
            this.panel_Decks.Controls.Add(this.label_Deck);
            this.panel_Decks.Location = new System.Drawing.Point(15, 11);
            this.panel_Decks.Name = "panel_Decks";
            this.panel_Decks.Padding = new System.Windows.Forms.Padding(2);
            this.panel_Decks.Size = new System.Drawing.Size(287, 112);
            this.panel_Decks.TabIndex = 2;
            // 
            // label_GewähltesDeck
            // 
            this.label_GewähltesDeck.AutoSize = true;
            this.label_GewähltesDeck.Location = new System.Drawing.Point(4, 66);
            this.label_GewähltesDeck.Name = "label_GewähltesDeck";
            this.label_GewähltesDeck.Size = new System.Drawing.Size(184, 32);
            this.label_GewähltesDeck.TabIndex = 4;
            this.label_GewähltesDeck.Text = "Gewähltes Deck";
            // 
            // button_DeckDef
            // 
            this.button_DeckDef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DeckDef.Location = new System.Drawing.Point(202, 37);
            this.button_DeckDef.Name = "button_DeckDef";
            this.button_DeckDef.Size = new System.Drawing.Size(80, 29);
            this.button_DeckDef.TabIndex = 3;
            this.button_DeckDef.UseVisualStyleBackColor = true;
            this.button_DeckDef.Click += new System.EventHandler(this.button_DeckDef_Click);
            // 
            // label_DeckDef
            // 
            this.label_DeckDef.AutoSize = true;
            this.label_DeckDef.Location = new System.Drawing.Point(4, 34);
            this.label_DeckDef.Name = "label_DeckDef";
            this.label_DeckDef.Size = new System.Drawing.Size(199, 32);
            this.label_DeckDef.TabIndex = 2;
            this.label_DeckDef.Text = "Decks definieren:";
            // 
            // button_DeckWählen
            // 
            this.button_DeckWählen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DeckWählen.Location = new System.Drawing.Point(202, 5);
            this.button_DeckWählen.Name = "button_DeckWählen";
            this.button_DeckWählen.Size = new System.Drawing.Size(80, 29);
            this.button_DeckWählen.TabIndex = 1;
            this.button_DeckWählen.UseVisualStyleBackColor = true;
            this.button_DeckWählen.Click += new System.EventHandler(this.button_DeckWählen_Click);
            // 
            // label_Deck
            // 
            this.label_Deck.AutoSize = true;
            this.label_Deck.Location = new System.Drawing.Point(4, 2);
            this.label_Deck.Name = "label_Deck";
            this.label_Deck.Size = new System.Drawing.Size(192, 32);
            this.label_Deck.TabIndex = 0;
            this.label_Deck.Text = "Deck auswählen:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmPreperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(36)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(314, 210);
            this.Controls.Add(this.panel_Decks);
            this.Controls.Add(this.button_SpielStarten);
            this.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPreperation";
            this.Text = "frmPreperation";
            this.panel_Decks.ResumeLayout(false);
            this.panel_Decks.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_SpielStarten;
        private System.Windows.Forms.Panel panel_Decks;
        private System.Windows.Forms.Button button_DeckWählen;
        private System.Windows.Forms.Label label_Deck;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label_GewähltesDeck;
        private System.Windows.Forms.Button button_DeckDef;
        private System.Windows.Forms.Label label_DeckDef;
    }
}