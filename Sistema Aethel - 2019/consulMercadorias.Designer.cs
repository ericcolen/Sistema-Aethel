
namespace Sistema_Aethel___2019
{
    partial class consulMercadorias
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
            this.lblConsulMercad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblConsulMercad
            // 
            this.lblConsulMercad.AutoSize = true;
            this.lblConsulMercad.BackColor = System.Drawing.Color.White;
            this.lblConsulMercad.Font = new System.Drawing.Font("Palatino Linotype", 25F, System.Drawing.FontStyle.Bold);
            this.lblConsulMercad.Location = new System.Drawing.Point(311, 26);
            this.lblConsulMercad.Name = "lblConsulMercad";
            this.lblConsulMercad.Size = new System.Drawing.Size(408, 46);
            this.lblConsulMercad.TabIndex = 1;
            this.lblConsulMercad.Text = "Consulta de Mercadorias";
            // 
            // consulMercadorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1031, 587);
            this.ControlBox = false;
            this.Controls.Add(this.lblConsulMercad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "consulMercadorias";
            this.Text = "Consulta de Mercadoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConsulMercad;
    }
}