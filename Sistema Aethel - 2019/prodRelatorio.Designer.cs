
namespace Sistema_Aethel___2019
{
    partial class prodRelatorio
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
            this.lblProdRelat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblProdRelat
            // 
            this.lblProdRelat.AutoSize = true;
            this.lblProdRelat.Font = new System.Drawing.Font("Palatino Linotype", 25F, System.Drawing.FontStyle.Bold);
            this.lblProdRelat.Location = new System.Drawing.Point(336, 26);
            this.lblProdRelat.Name = "lblProdRelat";
            this.lblProdRelat.Size = new System.Drawing.Size(358, 46);
            this.lblProdRelat.TabIndex = 1;
            this.lblProdRelat.Text = "Relatório de Produtos";
            // 
            // prodRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1031, 587);
            this.Controls.Add(this.lblProdRelat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "prodRelatorio";
            this.Text = "prodRelatorio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProdRelat;
    }
}