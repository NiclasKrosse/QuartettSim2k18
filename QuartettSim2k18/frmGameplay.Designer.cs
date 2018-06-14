namespace QuartettSim2k18
{
    partial class frmGameplay
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
            this.components = new System.ComponentModel.Container();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.label_Kartenname = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_P1 = new System.Windows.Forms.Label();
            this.label_P2 = new System.Windows.Forms.Label();
            this.label_P3 = new System.Windows.Forms.Label();
            this.label_P4 = new System.Windows.Forms.Label();
            this.label_P5 = new System.Windows.Forms.Label();
            this.label_P6 = new System.Windows.Forms.Label();
            this.label_Status = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label_KartenGegner = new System.Windows.Forms.Label();
            this.label_KartenDu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label_Kartenname
            // 
            this.label_Kartenname.AutoSize = true;
            this.label_Kartenname.Font = new System.Drawing.Font("Cooper Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Kartenname.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_Kartenname.Location = new System.Drawing.Point(16, 26);
            this.label_Kartenname.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label_Kartenname.Name = "label_Kartenname";
            this.label_Kartenname.Size = new System.Drawing.Size(103, 17);
            this.label_Kartenname.TabIndex = 2;
            this.label_Kartenname.Text = "Kartenname";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 51);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 263);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label_P1
            // 
            this.label_P1.AutoSize = true;
            this.label_P1.Font = new System.Drawing.Font("Cooper Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_P1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_P1.Location = new System.Drawing.Point(16, 322);
            this.label_P1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label_P1.Name = "label_P1";
            this.label_P1.Size = new System.Drawing.Size(68, 21);
            this.label_P1.TabIndex = 4;
            this.label_P1.Tag = "0";
            this.label_P1.Text = "label1";
            this.label_P1.Click += new System.EventHandler(this.EigenschaftSelected);
            // 
            // label_P2
            // 
            this.label_P2.AutoSize = true;
            this.label_P2.Font = new System.Drawing.Font("Cooper Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_P2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_P2.Location = new System.Drawing.Point(14, 354);
            this.label_P2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label_P2.Name = "label_P2";
            this.label_P2.Size = new System.Drawing.Size(68, 21);
            this.label_P2.TabIndex = 4;
            this.label_P2.Tag = "1";
            this.label_P2.Text = "label2";
            this.label_P2.Click += new System.EventHandler(this.EigenschaftSelected);
            // 
            // label_P3
            // 
            this.label_P3.AutoSize = true;
            this.label_P3.Font = new System.Drawing.Font("Cooper Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_P3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_P3.Location = new System.Drawing.Point(16, 392);
            this.label_P3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label_P3.Name = "label_P3";
            this.label_P3.Size = new System.Drawing.Size(68, 21);
            this.label_P3.TabIndex = 4;
            this.label_P3.Tag = "2";
            this.label_P3.Text = "label3";
            this.label_P3.Click += new System.EventHandler(this.EigenschaftSelected);
            // 
            // label_P4
            // 
            this.label_P4.AutoSize = true;
            this.label_P4.Font = new System.Drawing.Font("Cooper Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_P4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_P4.Location = new System.Drawing.Point(14, 430);
            this.label_P4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label_P4.Name = "label_P4";
            this.label_P4.Size = new System.Drawing.Size(68, 21);
            this.label_P4.TabIndex = 4;
            this.label_P4.Tag = "3";
            this.label_P4.Text = "label4";
            this.label_P4.Click += new System.EventHandler(this.EigenschaftSelected);
            // 
            // label_P5
            // 
            this.label_P5.AutoSize = true;
            this.label_P5.Font = new System.Drawing.Font("Cooper Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_P5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_P5.Location = new System.Drawing.Point(14, 468);
            this.label_P5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label_P5.Name = "label_P5";
            this.label_P5.Size = new System.Drawing.Size(68, 21);
            this.label_P5.TabIndex = 4;
            this.label_P5.Tag = "4";
            this.label_P5.Text = "label5";
            this.label_P5.Click += new System.EventHandler(this.EigenschaftSelected);
            // 
            // label_P6
            // 
            this.label_P6.AutoSize = true;
            this.label_P6.Font = new System.Drawing.Font("Cooper Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_P6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_P6.Location = new System.Drawing.Point(14, 506);
            this.label_P6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label_P6.Name = "label_P6";
            this.label_P6.Size = new System.Drawing.Size(68, 21);
            this.label_P6.TabIndex = 4;
            this.label_P6.Tag = "5";
            this.label_P6.Text = "label6";
            this.label_P6.Click += new System.EventHandler(this.EigenschaftSelected);
            // 
            // label_Status
            // 
            this.label_Status.Font = new System.Drawing.Font("Cooper Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Status.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_Status.Location = new System.Drawing.Point(341, 61);
            this.label_Status.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(193, 51);
            this.label_Status.TabIndex = 2;
            this.label_Status.Text = "Fragen ob anderer \r\nSpieler Kleinwagen\r\nhat\r\n";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cooper Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label12.Location = new System.Drawing.Point(222, 312);
            this.label12.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 21);
            this.label12.TabIndex = 6;
            // 
            // label_KartenGegner
            // 
            this.label_KartenGegner.AutoSize = true;
            this.label_KartenGegner.Font = new System.Drawing.Font("Cooper Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_KartenGegner.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_KartenGegner.Location = new System.Drawing.Point(341, 133);
            this.label_KartenGegner.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label_KartenGegner.Name = "label_KartenGegner";
            this.label_KartenGegner.Size = new System.Drawing.Size(58, 34);
            this.label_KartenGegner.TabIndex = 2;
            this.label_KartenGegner.Text = "COM1:\r\n\r\n";
            // 
            // label_KartenDu
            // 
            this.label_KartenDu.AutoSize = true;
            this.label_KartenDu.Font = new System.Drawing.Font("Cooper Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_KartenDu.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_KartenDu.Location = new System.Drawing.Point(341, 167);
            this.label_KartenDu.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label_KartenDu.Name = "label_KartenDu";
            this.label_KartenDu.Size = new System.Drawing.Size(35, 34);
            this.label_KartenDu.TabIndex = 2;
            this.label_KartenDu.Text = "Du:\r\n\r\n";
            // 
            // frmGameplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orchid;
            this.ClientSize = new System.Drawing.Size(550, 575);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label_P6);
            this.Controls.Add(this.label_P5);
            this.Controls.Add(this.label_P4);
            this.Controls.Add(this.label_P3);
            this.Controls.Add(this.label_P2);
            this.Controls.Add(this.label_P1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_KartenDu);
            this.Controls.Add(this.label_KartenGegner);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.label_Kartenname);
            this.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "frmGameplay";
            this.Text = "frmGameplay";
            this.TransparencyKey = System.Drawing.Color.WhiteSmoke;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Label label_Kartenname;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_P1;
        private System.Windows.Forms.Label label_P2;
        private System.Windows.Forms.Label label_P3;
        private System.Windows.Forms.Label label_P4;
        private System.Windows.Forms.Label label_P5;
        private System.Windows.Forms.Label label_P6;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label_KartenGegner;
        private System.Windows.Forms.Label label_KartenDu;
    }
}