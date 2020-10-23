namespace ProiectPOO
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AdaugaClient = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.VeziClienti = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.CosCumparaturi = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.EmitereFactura = new System.Windows.Forms.ToolStripButton();
            this.ProdusAlimentarButton = new System.Windows.Forms.Button();
            this.ProdusNealimentarButton = new System.Windows.Forms.Button();
            this.produseflow2 = new System.Windows.Forms.FlowLayoutPanel();
            this.produseFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.toolStrip1.SuspendLayout();
            this.produseFlow.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AdaugaClient,
            this.toolStripSeparator4,
            this.VeziClienti,
            this.toolStripSeparator5,
            this.CosCumparaturi,
            this.toolStripSeparator6,
            this.EmitereFactura});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(55, 1055);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AdaugaClient
            // 
            this.AdaugaClient.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AdaugaClient.Image = ((System.Drawing.Image)(resources.GetObject("AdaugaClient.Image")));
            this.AdaugaClient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AdaugaClient.Name = "AdaugaClient";
            this.AdaugaClient.Size = new System.Drawing.Size(52, 54);
            this.AdaugaClient.Text = "Adauga Client Nou";
            this.AdaugaClient.Click += new System.EventHandler(this.AdaugaClient_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(52, 6);
            // 
            // VeziClienti
            // 
            this.VeziClienti.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.VeziClienti.Image = ((System.Drawing.Image)(resources.GetObject("VeziClienti.Image")));
            this.VeziClienti.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.VeziClienti.Name = "VeziClienti";
            this.VeziClienti.Size = new System.Drawing.Size(52, 54);
            this.VeziClienti.Text = "Lista Clienti";
            this.VeziClienti.Click += new System.EventHandler(this.VeziClienti_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(52, 6);
            // 
            // CosCumparaturi
            // 
            this.CosCumparaturi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CosCumparaturi.Image = ((System.Drawing.Image)(resources.GetObject("CosCumparaturi.Image")));
            this.CosCumparaturi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CosCumparaturi.Name = "CosCumparaturi";
            this.CosCumparaturi.Size = new System.Drawing.Size(52, 54);
            this.CosCumparaturi.Text = "Cos Cumparaturi";
            this.CosCumparaturi.Click += new System.EventHandler(this.CosCumparaturi_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(52, 6);
            // 
            // EmitereFactura
            // 
            this.EmitereFactura.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EmitereFactura.Image = ((System.Drawing.Image)(resources.GetObject("EmitereFactura.Image")));
            this.EmitereFactura.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EmitereFactura.Name = "EmitereFactura";
            this.EmitereFactura.Size = new System.Drawing.Size(52, 54);
            this.EmitereFactura.Text = "Emitere Factura";
            // 
            // ProdusAlimentarButton
            // 
            this.ProdusAlimentarButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ProdusAlimentarButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.ProdusAlimentarButton.Location = new System.Drawing.Point(243, 40);
            this.ProdusAlimentarButton.Name = "ProdusAlimentarButton";
            this.ProdusAlimentarButton.Size = new System.Drawing.Size(210, 58);
            this.ProdusAlimentarButton.TabIndex = 3;
            this.ProdusAlimentarButton.Text = "Produse Alimentare";
            this.ProdusAlimentarButton.UseVisualStyleBackColor = true;
            this.ProdusAlimentarButton.Click += new System.EventHandler(this.ProdusAlimentarButton_Click);
            // 
            // ProdusNealimentarButton
            // 
            this.ProdusNealimentarButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ProdusNealimentarButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.ProdusNealimentarButton.Location = new System.Drawing.Point(1074, 40);
            this.ProdusNealimentarButton.Name = "ProdusNealimentarButton";
            this.ProdusNealimentarButton.Size = new System.Drawing.Size(206, 58);
            this.ProdusNealimentarButton.TabIndex = 4;
            this.ProdusNealimentarButton.Text = "Produse Nealimentare";
            this.ProdusNealimentarButton.UseVisualStyleBackColor = true;
            this.ProdusNealimentarButton.Click += new System.EventHandler(this.ProdusNealimentarButton_Click);
            // 
            // produseflow2
            // 
            this.produseflow2.AutoScroll = true;
            this.produseflow2.Location = new System.Drawing.Point(3, 3);
            this.produseflow2.Name = "produseflow2";
            this.produseflow2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.produseflow2.Size = new System.Drawing.Size(1308, 623);
            this.produseflow2.TabIndex = 0;
            
            // 
            // produseFlow
            // 
            this.produseFlow.Controls.Add(this.produseflow2);
            this.produseFlow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.produseFlow.Location = new System.Drawing.Point(121, 130);
            this.produseFlow.Name = "produseFlow";
            this.produseFlow.Size = new System.Drawing.Size(1311, 626);
            this.produseFlow.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.produseFlow);
            this.Controls.Add(this.ProdusNealimentarButton);
            this.Controls.Add(this.ProdusAlimentarButton);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Store";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.produseFlow.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AdaugaClient;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton VeziClienti;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton CosCumparaturi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton EmitereFactura;
        private System.Windows.Forms.Button ProdusAlimentarButton;
        private System.Windows.Forms.Button ProdusNealimentarButton;
        private System.Windows.Forms.FlowLayoutPanel produseflow2;
        private System.Windows.Forms.FlowLayoutPanel produseFlow;
    }
}

