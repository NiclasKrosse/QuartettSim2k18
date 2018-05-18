namespace QuartettSim2k18
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Spielregeln = new System.Windows.Forms.Button();
            this.button_Start = new System.Windows.Forms.Button();
            this.label_Überschrift = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Spielregeln
            // 
            this.button_Spielregeln.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Spielregeln.Location = new System.Drawing.Point(317, 113);
            this.button_Spielregeln.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.button_Spielregeln.Name = "button_Spielregeln";
            this.button_Spielregeln.Size = new System.Drawing.Size(204, 57);
            this.button_Spielregeln.TabIndex = 0;
            this.button_Spielregeln.Text = "Spielregeln";
            this.button_Spielregeln.UseVisualStyleBackColor = true;
            // 
            // button_Start
            // 
            this.button_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Start.Location = new System.Drawing.Point(16, 113);
            this.button_Start.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(204, 57);
            this.button_Start.TabIndex = 1;
            this.button_Start.Text = "Loslegen";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // label_Überschrift
            // 
            this.label_Überschrift.AutoSize = true;
            this.label_Überschrift.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Überschrift.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(56)))), ((int)(((byte)(168)))));
            this.label_Überschrift.Location = new System.Drawing.Point(59, 9);
            this.label_Überschrift.Name = "label_Überschrift";
            this.label_Überschrift.Size = new System.Drawing.Size(423, 57);
            this.label_Überschrift.TabIndex = 2;
            this.label_Überschrift.Text = "Quartettsimulator 2018";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 187);
            this.Controls.Add(this.label_Überschrift);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.button_Spielregeln);
            this.Font = new System.Drawing.Font("Segoe Marker", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Quartettsimulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Spielregeln;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Label label_Überschrift;
    }
}

