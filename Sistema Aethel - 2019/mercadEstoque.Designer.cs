
namespace Sistema_Aethel___2019
{
    partial class mercadEstoque
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
            this.lblMercadEstq = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMercadEstq
            // 
            this.lblMercadEstq.AutoSize = true;
            this.lblMercadEstq.Font = new System.Drawing.Font("Palatino Linotype", 25F, System.Drawing.FontStyle.Bold);
            this.lblMercadEstq.Location = new System.Drawing.Point(314, 26);
            this.lblMercadEstq.Name = "lblMercadEstq";
            this.lblMercadEstq.Size = new System.Drawing.Size(402, 46);
            this.lblMercadEstq.TabIndex = 3;
            this.lblMercadEstq.Text = "Mercadorias em Estoque";
            // 
            // mercadEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1031, 587);
            this.Controls.Add(this.lblMercadEstq);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mercadEstoque";
            this.Text = "mercadEstoque";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMercadEstq;
    }
}