
namespace Sistema_Aethel___2019
{
    partial class mercadRelatorio
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
            this.lblMercadRelat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMercadRelat
            // 
            this.lblMercadRelat.AutoSize = true;
            this.lblMercadRelat.Font = new System.Drawing.Font("Palatino Linotype", 25F, System.Drawing.FontStyle.Bold);
            this.lblMercadRelat.Location = new System.Drawing.Point(336, 26);
            this.lblMercadRelat.Name = "lblMercadRelat";
            this.lblMercadRelat.Size = new System.Drawing.Size(410, 46);
            this.lblMercadRelat.TabIndex = 2;
            this.lblMercadRelat.Text = "Relatório de Mercadorias";
            // 
            // mercadRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1031, 587);
            this.Controls.Add(this.lblMercadRelat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mercadRelatorio";
            this.Text = "mercadRelatorio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMercadRelat;
    }
}