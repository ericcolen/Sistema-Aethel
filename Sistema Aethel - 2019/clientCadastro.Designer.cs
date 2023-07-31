
namespace Sistema_Aethel___2019
{
    partial class clientCadastro
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
            this.lblClientCad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblClientCad
            // 
            this.lblClientCad.AutoSize = true;
            this.lblClientCad.Font = new System.Drawing.Font("Palatino Linotype", 25F, System.Drawing.FontStyle.Bold);
            this.lblClientCad.Location = new System.Drawing.Point(352, 26);
            this.lblClientCad.Name = "lblClientCad";
            this.lblClientCad.Size = new System.Drawing.Size(327, 46);
            this.lblClientCad.TabIndex = 2;
            this.lblClientCad.Text = "Cadastro de Cliente";
            // 
            // clientCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1031, 587);
            this.Controls.Add(this.lblClientCad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "clientCadastro";
            this.Text = "clientCadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClientCad;
    }
}