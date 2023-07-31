
namespace Sistema_Aethel___2019
{
    partial class feiraVendas
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
            this.lblFeiraVendas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFeiraVendas
            // 
            this.lblFeiraVendas.AutoSize = true;
            this.lblFeiraVendas.Font = new System.Drawing.Font("Palatino Linotype", 25F, System.Drawing.FontStyle.Bold);
            this.lblFeiraVendas.Location = new System.Drawing.Point(373, 26);
            this.lblFeiraVendas.Name = "lblFeiraVendas";
            this.lblFeiraVendas.Size = new System.Drawing.Size(268, 46);
            this.lblFeiraVendas.TabIndex = 3;
            this.lblFeiraVendas.Text = "Vendas na Feira";
            // 
            // feiraVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1015, 548);
            this.Controls.Add(this.lblFeiraVendas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "feiraVendas";
            this.Text = "feiraVendas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFeiraVendas;
    }
}