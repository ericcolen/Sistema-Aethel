﻿
namespace Sistema_Aethel___2019
{
    partial class vendaRelatorio
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
            this.lblVendRelat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblVendRelat
            // 
            this.lblVendRelat.AutoSize = true;
            this.lblVendRelat.Font = new System.Drawing.Font("Palatino Linotype", 25F, System.Drawing.FontStyle.Bold);
            this.lblVendRelat.Location = new System.Drawing.Point(349, 26);
            this.lblVendRelat.Name = "lblVendRelat";
            this.lblVendRelat.Size = new System.Drawing.Size(333, 46);
            this.lblVendRelat.TabIndex = 3;
            this.lblVendRelat.Text = "Relatório de Vendas";
            // 
            // vendaRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1031, 587);
            this.Controls.Add(this.lblVendRelat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "vendaRelatorio";
            this.Text = "vendaRelatorio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVendRelat;
    }
}