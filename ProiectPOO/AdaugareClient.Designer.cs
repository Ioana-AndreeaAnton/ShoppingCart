namespace ProiectPOO
{
    partial class AdaugareClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nume = new System.Windows.Forms.TextBox();
            this.prenume = new System.Windows.Forms.TextBox();
            this.adresa = new System.Windows.Forms.TextBox();
            this.banca = new System.Windows.Forms.TextBox();
            this.cont = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(143, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Completati cu atentie spatiile urmatoare";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(105, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(105, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prenume";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(105, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adresa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(105, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Banca";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.OrangeRed;
            this.label6.Location = new System.Drawing.Point(105, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cont";
            // 
            // nume
            // 
            this.nume.Location = new System.Drawing.Point(315, 78);
            this.nume.Name = "nume";
            this.nume.Size = new System.Drawing.Size(100, 22);
            this.nume.TabIndex = 6;
            this.nume.TextChanged += new System.EventHandler(this.nume_TextChanged);
            // 
            // prenume
            // 
            this.prenume.Location = new System.Drawing.Point(315, 128);
            this.prenume.Name = "prenume";
            this.prenume.Size = new System.Drawing.Size(100, 22);
            this.prenume.TabIndex = 7;
            this.prenume.TextChanged += new System.EventHandler(this.prenume_TextChanged);
            // 
            // adresa
            // 
            this.adresa.Location = new System.Drawing.Point(315, 180);
            this.adresa.Name = "adresa";
            this.adresa.Size = new System.Drawing.Size(100, 22);
            this.adresa.TabIndex = 8;
            this.adresa.TextChanged += new System.EventHandler(this.adresa_TextChanged);
            // 
            // banca
            // 
            this.banca.Location = new System.Drawing.Point(315, 228);
            this.banca.Name = "banca";
            this.banca.Size = new System.Drawing.Size(100, 22);
            this.banca.TabIndex = 9;
            this.banca.TextChanged += new System.EventHandler(this.banca_TextChanged);
            // 
            // cont
            // 
            this.cont.Location = new System.Drawing.Point(315, 277);
            this.cont.Name = "cont";
            this.cont.Size = new System.Drawing.Size(100, 22);
            this.cont.TabIndex = 10;
            this.cont.TextChanged += new System.EventHandler(this.cont_TextChanged);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.OrangeRed;
            this.button1.Location = new System.Drawing.Point(528, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 40);
            this.button1.TabIndex = 11;
            this.button1.Text = "Inregistrare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdaugareClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cont);
            this.Controls.Add(this.banca);
            this.Controls.Add(this.adresa);
            this.Controls.Add(this.prenume);
            this.Controls.Add(this.nume);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdaugareClient";
            this.Text = "AdaugareClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nume;
        private System.Windows.Forms.TextBox prenume;
        private System.Windows.Forms.TextBox adresa;
        private System.Windows.Forms.TextBox banca;
        private System.Windows.Forms.TextBox cont;
        private System.Windows.Forms.Button button1;
    }
}