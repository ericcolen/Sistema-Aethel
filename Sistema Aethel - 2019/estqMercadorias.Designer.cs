﻿
namespace Sistema_Aethel___2019
{
    partial class estqMercadorias
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
            this.lblEstqMercad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEstqMercad
            // 
            this.lblEstqMercad.AutoSize = true;
            this.lblEstqMercad.Font = new System.Drawing.Font("Palatino Linotype", 25F, System.Drawing.FontStyle.Bold);
            this.lblEstqMercad.Location = new System.Drawing.Point(319, 26);
            this.lblEstqMercad.Name = "lblEstqMercad";
            this.lblEstqMercad.Size = new System.Drawing.Size(393, 46);
            this.lblEstqMercad.TabIndex = 1;
            this.lblEstqMercad.Text = "Estoque de Mercadorias";
            // 
            // estqMercadorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1031, 587);
            this.Controls.Add(this.lblEstqMercad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "estqMercadorias";
            this.Text = "Estoque de Mercadoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstqMercad;
    }
}