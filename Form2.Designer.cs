namespace Sistema_Aethel
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panel1 = new Panel();
            PictureBox1 = new PictureBox();
            label3 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            panel3 = new Panel();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 55, 61);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(PictureBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(92, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(375, 365);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = (Image)resources.GetObject("PictureBox1.Image");
            PictureBox1.Location = new Point(29, 97);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(313, 166);
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox1.TabIndex = 2;
            PictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.Font = new Font("Copperplate Gothic Light", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(29, 313);
            label3.Name = "label3";
            label3.Size = new Size(313, 26);
            label3.TabIndex = 1;
            label3.Text = "Seja bem-vindo ao sistema";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Palatino Linotype", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(16, 12);
            label1.Name = "label1";
            label1.Size = new Size(338, 49);
            label1.TabIndex = 0;
            label1.Text = "Painel de Controle";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(38, 43, 46);
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(464, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(375, 365);
            panel2.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(141, 281);
            button1.Name = "button1";
            button1.Size = new Size(84, 32);
            button1.TabIndex = 2;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(40, 97);
            panel3.Name = "panel3";
            panel3.Size = new Size(296, 242);
            panel3.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(130, 116);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(119, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(130, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(119, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(38, 116);
            label6.Name = "label6";
            label6.Size = new Size(64, 25);
            label6.TabIndex = 0;
            label6.Text = "Senha:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(38, 39);
            label5.Name = "label5";
            label5.Size = new Size(60, 25);
            label5.TabIndex = 0;
            label5.Text = "Login:";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Palatino Linotype", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.ImageAlign = ContentAlignment.MiddleRight;
            label4.Location = new Point(16, 12);
            label4.Name = "label4";
            label4.Size = new Size(338, 49);
            label4.TabIndex = 0;
            label4.Text = "Login";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(385, 459);
            button2.Name = "button2";
            button2.Size = new Size(161, 35);
            button2.TabIndex = 4;
            button2.Text = "Fechar Aplicativo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 43, 46);
            ClientSize = new Size(931, 515);
            Controls.Add(button2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private PictureBox PictureBox1;
        private Label label3;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Label label4;
        private Label label6;
        private Label label5;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
    }
}