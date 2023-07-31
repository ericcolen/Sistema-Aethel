
namespace Sistema_Aethel___2019
{
    partial class funcioCadastro
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
            this.lblFuncCad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFuncCad
            // 
            this.lblFuncCad.AutoSize = true;
            this.lblFuncCad.Font = new System.Drawing.Font("Palatino Linotype", 25F, System.Drawing.FontStyle.Bold);
            this.lblFuncCad.Location = new System.Drawing.Point(338, 26);
            this.lblFuncCad.Name = "lblFuncCad";
            this.lblFuncCad.Size = new System.Drawing.Size(327, 46);
            this.lblFuncCad.TabIndex = 3;
            this.lblFuncCad.Text = "Cadastro de Cliente";
            // 
            // funcioCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1031, 587);
            this.Controls.Add(this.lblFuncCad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "funcioCadastro";
            this.Text = "funcioCadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFuncCad;
    }
}