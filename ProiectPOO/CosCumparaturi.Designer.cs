namespace ProiectPOO
{
    partial class CosCumparaturi
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ListaProduseFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.CosCumparaturiFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(1009, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cos Cumparaturi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(200, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lista Produse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(302, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 38);
            this.label2.TabIndex = 4;
            // 
            // ListaProduseFlow
            // 
            this.ListaProduseFlow.AutoScroll = true;
            this.ListaProduseFlow.Location = new System.Drawing.Point(44, 111);
            this.ListaProduseFlow.Name = "ListaProduseFlow";
            this.ListaProduseFlow.Size = new System.Drawing.Size(507, 664);
            this.ListaProduseFlow.TabIndex = 101;
            // 
            // CosCumparaturiFlow
            // 
            this.CosCumparaturiFlow.AutoScroll = true;
            this.CosCumparaturiFlow.Location = new System.Drawing.Point(879, 111);
            this.CosCumparaturiFlow.Name = "CosCumparaturiFlow";
            this.CosCumparaturiFlow.Size = new System.Drawing.Size(507, 664);
            this.CosCumparaturiFlow.TabIndex = 102;
            // 
            // CosCumparaturi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.CosCumparaturiFlow);
            this.Controls.Add(this.ListaProduseFlow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CosCumparaturi";
            this.Text = "CosCumparaturi";
            this.Load += new System.EventHandler(this.CosCumparaturi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel ListaProduseFlow;
        private System.Windows.Forms.FlowLayoutPanel CosCumparaturiFlow;
    }
}