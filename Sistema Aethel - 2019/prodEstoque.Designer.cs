
namespace Sistema_Aethel___2019
{
    partial class prodEstoque
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
            this.lblProdEstq = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblProdEstq
            // 
            this.lblProdEstq.AutoSize = true;
            this.lblProdEstq.Font = new System.Drawing.Font("Palatino Linotype", 25F, System.Drawing.FontStyle.Bold);
            this.lblProdEstq.Location = new System.Drawing.Point(340, 25);
            this.lblProdEstq.Name = "lblProdEstq";
            this.lblProdEstq.Size = new System.Drawing.Size(350, 46);
            this.lblProdEstq.TabIndex = 2;
            this.lblProdEstq.Text = "Produtos em Estoque";
            // 
            // prodEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1031, 587);
            this.Controls.Add(this.lblProdEstq);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "prodEstoque";
            this.Text = "prodEstoque";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProdEstq;
    }
}