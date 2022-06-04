namespace Calcolatrife
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button0 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.labelRisultato = new System.Windows.Forms.Label();
            this.buttonAddizione = new System.Windows.Forms.Button();
            this.buttonMeno = new System.Windows.Forms.Button();
            this.buttonMoltiplicazione = new System.Windows.Forms.Button();
            this.buttonDiviso = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(118, 431);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(75, 75);
            this.button0.TabIndex = 0;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 75);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(118, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 75);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(199, 192);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 75);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(37, 269);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 75);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(118, 269);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 75);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(199, 269);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 75);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(37, 350);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 75);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(118, 350);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 75);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(199, 350);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 75);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // labelRisultato
            // 
            this.labelRisultato.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRisultato.ForeColor = System.Drawing.Color.White;
            this.labelRisultato.Location = new System.Drawing.Point(37, 9);
            this.labelRisultato.Name = "labelRisultato";
            this.labelRisultato.Size = new System.Drawing.Size(237, 171);
            this.labelRisultato.TabIndex = 10;
            this.labelRisultato.Text = "0";
            this.labelRisultato.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonAddizione
            // 
            this.buttonAddizione.Location = new System.Drawing.Point(12, 512);
            this.buttonAddizione.Name = "buttonAddizione";
            this.buttonAddizione.Size = new System.Drawing.Size(62, 29);
            this.buttonAddizione.TabIndex = 11;
            this.buttonAddizione.Text = "+";
            this.buttonAddizione.UseVisualStyleBackColor = true;
            this.buttonAddizione.Click += new System.EventHandler(this.buttonOperazione_Click);
            // 
            // buttonMeno
            // 
            this.buttonMeno.Location = new System.Drawing.Point(71, 512);
            this.buttonMeno.Name = "buttonMeno";
            this.buttonMeno.Size = new System.Drawing.Size(62, 29);
            this.buttonMeno.TabIndex = 12;
            this.buttonMeno.Text = "-";
            this.buttonMeno.UseVisualStyleBackColor = true;
            this.buttonMeno.Click += new System.EventHandler(this.buttonOperazione_Click);
            // 
            // buttonMoltiplicazione
            // 
            this.buttonMoltiplicazione.Location = new System.Drawing.Point(170, 512);
            this.buttonMoltiplicazione.Name = "buttonMoltiplicazione";
            this.buttonMoltiplicazione.Size = new System.Drawing.Size(62, 29);
            this.buttonMoltiplicazione.TabIndex = 13;
            this.buttonMoltiplicazione.Text = "x";
            this.buttonMoltiplicazione.UseVisualStyleBackColor = true;
            this.buttonMoltiplicazione.Click += new System.EventHandler(this.buttonOperazione_Click);
            // 
            // buttonDiviso
            // 
            this.buttonDiviso.Location = new System.Drawing.Point(228, 512);
            this.buttonDiviso.Name = "buttonDiviso";
            this.buttonDiviso.Size = new System.Drawing.Size(62, 29);
            this.buttonDiviso.TabIndex = 14;
            this.buttonDiviso.Text = "/";
            this.buttonDiviso.UseVisualStyleBackColor = true;
            this.buttonDiviso.Click += new System.EventHandler(this.buttonOperazione_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(12, 552);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(278, 29);
            this.button10.TabIndex = 15;
            this.button10.Text = "=";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.buttonRisultato_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(302, 593);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.buttonDiviso);
            this.Controls.Add(this.buttonMoltiplicazione);
            this.Controls.Add(this.buttonMeno);
            this.Controls.Add(this.buttonAddizione);
            this.Controls.Add(this.labelRisultato);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button0);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label labelRisultato;
        private System.Windows.Forms.Button buttonAddizione;
        private System.Windows.Forms.Button buttonMeno;
        private System.Windows.Forms.Button buttonMoltiplicazione;
        private System.Windows.Forms.Button buttonDiviso;
        private System.Windows.Forms.Button button10;
    }
}

