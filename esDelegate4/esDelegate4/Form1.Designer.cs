
namespace esDelegate4
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
            this.btnMedia = new System.Windows.Forms.Button();
            this.btnMulticast = new System.Windows.Forms.Button();
            this.btnMex = new System.Windows.Forms.Button();
            this.lbNum1 = new System.Windows.Forms.Label();
            this.lbNum2 = new System.Windows.Forms.Label();
            this.tbNum1 = new System.Windows.Forms.TextBox();
            this.tbNum2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMedia
            // 
            this.btnMedia.Location = new System.Drawing.Point(198, 151);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(102, 42);
            this.btnMedia.TabIndex = 0;
            this.btnMedia.Text = "calcola media";
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // btnMulticast
            // 
            this.btnMulticast.Location = new System.Drawing.Point(92, 270);
            this.btnMulticast.Name = "btnMulticast";
            this.btnMulticast.Size = new System.Drawing.Size(183, 62);
            this.btnMulticast.TabIndex = 1;
            this.btnMulticast.Text = "media, max, ipotenusa";
            this.btnMulticast.UseVisualStyleBackColor = true;
            this.btnMulticast.Click += new System.EventHandler(this.btnMulticast_Click);
            // 
            // btnMex
            // 
            this.btnMex.Location = new System.Drawing.Point(68, 151);
            this.btnMex.Name = "btnMex";
            this.btnMex.Size = new System.Drawing.Size(87, 42);
            this.btnMex.TabIndex = 2;
            this.btnMex.Text = "messaggio";
            this.btnMex.UseVisualStyleBackColor = true;
            this.btnMex.Click += new System.EventHandler(this.btnMex_Click);
            // 
            // lbNum1
            // 
            this.lbNum1.AutoSize = true;
            this.lbNum1.Location = new System.Drawing.Point(484, 143);
            this.lbNum1.Name = "lbNum1";
            this.lbNum1.Size = new System.Drawing.Size(38, 13);
            this.lbNum1.TabIndex = 3;
            this.lbNum1.Text = "Num1 ";
            // 
            // lbNum2
            // 
            this.lbNum2.AutoSize = true;
            this.lbNum2.Location = new System.Drawing.Point(635, 143);
            this.lbNum2.Name = "lbNum2";
            this.lbNum2.Size = new System.Drawing.Size(35, 13);
            this.lbNum2.TabIndex = 4;
            this.lbNum2.Text = "Num2";
            // 
            // tbNum1
            // 
            this.tbNum1.Location = new System.Drawing.Point(432, 184);
            this.tbNum1.Name = "tbNum1";
            this.tbNum1.Size = new System.Drawing.Size(124, 20);
            this.tbNum1.TabIndex = 5;
            // 
            // tbNum2
            // 
            this.tbNum2.Location = new System.Drawing.Point(593, 184);
            this.tbNum2.Name = "tbNum2";
            this.tbNum2.Size = new System.Drawing.Size(124, 20);
            this.tbNum2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbNum2);
            this.Controls.Add(this.tbNum1);
            this.Controls.Add(this.lbNum2);
            this.Controls.Add(this.lbNum1);
            this.Controls.Add(this.btnMex);
            this.Controls.Add(this.btnMulticast);
            this.Controls.Add(this.btnMedia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Button btnMulticast;
        private System.Windows.Forms.Button btnMex;
        private System.Windows.Forms.Label lbNum1;
        private System.Windows.Forms.Label lbNum2;
        private System.Windows.Forms.TextBox tbNum1;
        private System.Windows.Forms.TextBox tbNum2;
    }
}

