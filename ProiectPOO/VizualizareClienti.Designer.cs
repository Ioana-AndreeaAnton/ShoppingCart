namespace ProiectPOO
{
    partial class VizualizareClienti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VizualizareClienti));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.filtru = new System.Windows.Forms.TextBox();
            this.cauta = new System.Windows.Forms.Button();
            this.l1 = new System.Windows.Forms.ListBox();
            this.listeaza = new System.Windows.Forms.Button();
            this.of = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(60, 60);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 67);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(64, 64);
            this.toolStripButton1.Text = "Cauta Fisier";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 67);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(64, 64);
            this.toolStripButton2.Text = "Iesire";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // filtru
            // 
            this.filtru.Location = new System.Drawing.Point(12, 89);
            this.filtru.Name = "filtru";
            this.filtru.Size = new System.Drawing.Size(520, 22);
            this.filtru.TabIndex = 1;
            // 
            // cauta
            // 
            this.cauta.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cauta.ForeColor = System.Drawing.Color.OrangeRed;
            this.cauta.Location = new System.Drawing.Point(607, 89);
            this.cauta.Name = "cauta";
            this.cauta.Size = new System.Drawing.Size(160, 34);
            this.cauta.TabIndex = 2;
            this.cauta.Text = "Cauta Client";
            this.cauta.UseVisualStyleBackColor = true;
            this.cauta.Click += new System.EventHandler(this.button1_Click);
            // 
            // l1
            // 
            this.l1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l1.FormattingEnabled = true;
            this.l1.ItemHeight = 20;
            this.l1.Location = new System.Drawing.Point(12, 129);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(520, 244);
            this.l1.TabIndex = 3;
            // 
            // listeaza
            // 
            this.listeaza.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listeaza.ForeColor = System.Drawing.Color.OrangeRed;
            this.listeaza.Location = new System.Drawing.Point(607, 333);
            this.listeaza.Name = "listeaza";
            this.listeaza.Size = new System.Drawing.Size(160, 56);
            this.listeaza.TabIndex = 4;
            this.listeaza.Text = "Afiseaza Toti Clientii";
            this.listeaza.UseVisualStyleBackColor = true;
            this.listeaza.Click += new System.EventHandler(this.listeaza_Click);
            // 
            // of
            // 
            this.of.FileName = "openFileDialog1";
            this.of.FileOk += new System.ComponentModel.CancelEventHandler(this.of_FileOk);
            // 
            // VizualizareClienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listeaza);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.cauta);
            this.Controls.Add(this.filtru);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "VizualizareClienti";
            this.Text = "VizualizareClienti";
            this.Load += new System.EventHandler(this.VizualizareClienti_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.TextBox filtru;
        private System.Windows.Forms.Button cauta;
        private System.Windows.Forms.ListBox l1;
        private System.Windows.Forms.Button listeaza;
        private System.Windows.Forms.OpenFileDialog of;
    }
}