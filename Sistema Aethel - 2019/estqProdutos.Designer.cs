
namespace Sistema_Aethel___2019
{
    partial class estqProdutos
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
            this.lblEstqProd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEstqProd
            // 
            this.lblEstqProd.AutoSize = true;
            this.lblEstqProd.BackColor = System.Drawing.Color.White;
            this.lblEstqProd.Font = new System.Drawing.Font("Palatino Linotype", 25F, System.Drawing.FontStyle.Bold);
            this.lblEstqProd.Location = new System.Drawing.Point(345, 26);
            this.lblEstqProd.Name = "lblEstqProd";
            this.lblEstqProd.Size = new System.Drawing.Size(341, 46);
            this.lblEstqProd.TabIndex = 2;
            this.lblEstqProd.Text = "Estoque de Produtos";
            // 
            // estqProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1031, 587);
            this.Controls.Add(this.lblEstqProd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "estqProdutos";
            this.Text = "Estoque de Produtos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstqProd;
    }
}