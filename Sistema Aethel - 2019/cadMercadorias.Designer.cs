
namespace Sistema_Aethel___2019
{
    partial class cadMercadorias
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
            this.lblCadMercad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCadMercad
            // 
            this.lblCadMercad.AutoSize = true;
            this.lblCadMercad.Font = new System.Drawing.Font("Palatino Linotype", 25F, System.Drawing.FontStyle.Bold);
            this.lblCadMercad.Location = new System.Drawing.Point(312, 26);
            this.lblCadMercad.Name = "lblCadMercad";
            this.lblCadMercad.Size = new System.Drawing.Size(406, 46);
            this.lblCadMercad.TabIndex = 1;
            this.lblCadMercad.Text = "Cadastro de Mercadorias";
            // 
            // cadMercadorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1031, 587);
            this.Controls.Add(this.lblCadMercad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cadMercadorias";
            this.Text = "Cadastro de Mercadoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCadMercad;
    }
}