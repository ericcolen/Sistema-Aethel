
namespace Sistema_Aethel___2019
{
    partial class consulProdutos
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
            this.lblConsulProd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblConsulProd
            // 
            this.lblConsulProd.AutoSize = true;
            this.lblConsulProd.Font = new System.Drawing.Font("Palatino Linotype", 25F, System.Drawing.FontStyle.Bold);
            this.lblConsulProd.Location = new System.Drawing.Point(329, 26);
            this.lblConsulProd.Name = "lblConsulProd";
            this.lblConsulProd.Size = new System.Drawing.Size(356, 46);
            this.lblConsulProd.TabIndex = 0;
            this.lblConsulProd.Text = "Consulta de Produtos";
            // 
            // consulProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1015, 548);
            this.Controls.Add(this.lblConsulProd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "consulProdutos";
            this.Text = "consulProdutos";
            this.Load += new System.EventHandler(this.consulProdutos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConsulProd;
    }
}