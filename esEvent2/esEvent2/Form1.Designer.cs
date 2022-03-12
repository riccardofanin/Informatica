
namespace esEvent2
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbCognome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIndirizzo = new System.Windows.Forms.TextBox();
            this.dwda = new System.Windows.Forms.Label();
            this.tbImporto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSaldo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOME";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(189, 91);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(156, 20);
            this.tbNome.TabIndex = 1;
            // 
            // tbCognome
            // 
            this.tbCognome.Location = new System.Drawing.Point(189, 117);
            this.tbCognome.Name = "tbCognome";
            this.tbCognome.Size = new System.Drawing.Size(156, 20);
            this.tbCognome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "COGNOME";
            // 
            // tbIndirizzo
            // 
            this.tbIndirizzo.Location = new System.Drawing.Point(189, 143);
            this.tbIndirizzo.Name = "tbIndirizzo";
            this.tbIndirizzo.Size = new System.Drawing.Size(156, 20);
            this.tbIndirizzo.TabIndex = 5;
            // 
            // dwda
            // 
            this.dwda.AutoSize = true;
            this.dwda.Location = new System.Drawing.Point(126, 146);
            this.dwda.Name = "dwda";
            this.dwda.Size = new System.Drawing.Size(62, 13);
            this.dwda.TabIndex = 4;
            this.dwda.Text = "INDIRIZZO";
            // 
            // tbImporto
            // 
            this.tbImporto.Location = new System.Drawing.Point(189, 252);
            this.tbImporto.Name = "tbImporto";
            this.tbImporto.Size = new System.Drawing.Size(156, 20);
            this.tbImporto.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "IMPORTO";
            // 
            // tbSaldo
            // 
            this.tbSaldo.Location = new System.Drawing.Point(387, 357);
            this.tbSaldo.Name = "tbSaldo";
            this.tbSaldo.Size = new System.Drawing.Size(156, 20);
            this.tbSaldo.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "SALDO DISPONIBILE";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(470, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 46);
            this.button1.TabIndex = 10;
            this.button1.Text = "NUOVO CLIENTE";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(470, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 46);
            this.button2.TabIndex = 11;
            this.button2.Text = "VERSAMENTO";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(470, 255);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 46);
            this.button3.TabIndex = 12;
            this.button3.Text = "PRELEVAMENTO";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbSaldo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbImporto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbIndirizzo);
            this.Controls.Add(this.dwda);
            this.Controls.Add(this.tbCognome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbCognome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbIndirizzo;
        private System.Windows.Forms.Label dwda;
        private System.Windows.Forms.TextBox tbImporto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSaldo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

