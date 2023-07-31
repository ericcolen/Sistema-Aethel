
namespace Sistema_Aethel___2019
{
    partial class frmInicio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.panelCadastrar = new System.Windows.Forms.Panel();
            this.menuStrip6 = new System.Windows.Forms.MenuStrip();
            this.toolStripCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.subClientesCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.subFuncionariosCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.panelRelatorios = new System.Windows.Forms.Panel();
            this.menuStrip4 = new System.Windows.Forms.MenuStrip();
            this.toolStripRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.subProdutosRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.subMercadoriasRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.subVendasRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.panelVendas = new System.Windows.Forms.Panel();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.toolStripVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.subFeiraVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMercadorias = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMercadorias = new System.Windows.Forms.ToolStripMenuItem();
            this.subCadastrarMercadorias = new System.Windows.Forms.ToolStripMenuItem();
            this.subEstoqueMercadorias = new System.Windows.Forms.ToolStripMenuItem();
            this.subConsultaMercadorias = new System.Windows.Forms.ToolStripMenuItem();
            this.panelProdutos = new System.Windows.Forms.Panel();
            this.menuStrip5 = new System.Windows.Forms.MenuStrip();
            this.toolStripProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.subCadastrarProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.subEstoqueProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.subConsultaProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.panelEstoque = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.subProdutosEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.subMercadoriasEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.hora = new System.Windows.Forms.Timer(this.components);
            this.lblHora = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelCadastrar.SuspendLayout();
            this.menuStrip6.SuspendLayout();
            this.panelRelatorios.SuspendLayout();
            this.menuStrip4.SuspendLayout();
            this.panelVendas.SuspendLayout();
            this.menuStrip3.SuspendLayout();
            this.panelMercadorias.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.panelProdutos.SuspendLayout();
            this.menuStrip5.SuspendLayout();
            this.panelEstoque.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(47)))), ((int)(((byte)(105)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.panelCadastrar);
            this.panel1.Controls.Add(this.panelRelatorios);
            this.panel1.Controls.Add(this.panelVendas);
            this.panel1.Controls.Add(this.panelMercadorias);
            this.panel1.Controls.Add(this.panelProdutos);
            this.panel1.Controls.Add(this.panelEstoque);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 586);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Palatino Linotype", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnSair.Location = new System.Drawing.Point(31, 539);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // panelCadastrar
            // 
            this.panelCadastrar.Controls.Add(this.menuStrip6);
            this.panelCadastrar.Location = new System.Drawing.Point(1, 374);
            this.panelCadastrar.Name = "panelCadastrar";
            this.panelCadastrar.Size = new System.Drawing.Size(130, 31);
            this.panelCadastrar.TabIndex = 1;
            // 
            // menuStrip6
            // 
            this.menuStrip6.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCadastrar});
            this.menuStrip6.Location = new System.Drawing.Point(0, 0);
            this.menuStrip6.Name = "menuStrip6";
            this.menuStrip6.Size = new System.Drawing.Size(130, 24);
            this.menuStrip6.TabIndex = 0;
            this.menuStrip6.Text = "menuStrip6";
            // 
            // toolStripCadastrar
            // 
            this.toolStripCadastrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subClientesCadastrar,
            this.subFuncionariosCadastrar});
            this.toolStripCadastrar.Name = "toolStripCadastrar";
            this.toolStripCadastrar.Size = new System.Drawing.Size(69, 20);
            this.toolStripCadastrar.Text = "Cadastrar";
            // 
            // subClientesCadastrar
            // 
            this.subClientesCadastrar.Name = "subClientesCadastrar";
            this.subClientesCadastrar.Size = new System.Drawing.Size(180, 22);
            this.subClientesCadastrar.Text = "Clientes";
            this.subClientesCadastrar.Click += new System.EventHandler(this.subClientesCadastrar_Click);
            // 
            // subFuncionariosCadastrar
            // 
            this.subFuncionariosCadastrar.Name = "subFuncionariosCadastrar";
            this.subFuncionariosCadastrar.Size = new System.Drawing.Size(180, 22);
            this.subFuncionariosCadastrar.Text = "Funcionários";
            this.subFuncionariosCadastrar.Click += new System.EventHandler(this.subFuncionariosCadastrar_Click);
            // 
            // panelRelatorios
            // 
            this.panelRelatorios.Controls.Add(this.menuStrip4);
            this.panelRelatorios.Location = new System.Drawing.Point(1, 337);
            this.panelRelatorios.Name = "panelRelatorios";
            this.panelRelatorios.Size = new System.Drawing.Size(130, 31);
            this.panelRelatorios.TabIndex = 1;
            // 
            // menuStrip4
            // 
            this.menuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripRelatorios});
            this.menuStrip4.Location = new System.Drawing.Point(0, 0);
            this.menuStrip4.Name = "menuStrip4";
            this.menuStrip4.Size = new System.Drawing.Size(130, 24);
            this.menuStrip4.TabIndex = 0;
            this.menuStrip4.Text = "menuStrip5";
            // 
            // toolStripRelatorios
            // 
            this.toolStripRelatorios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subProdutosRelatorios,
            this.subMercadoriasRelatorios,
            this.subVendasRelatorios});
            this.toolStripRelatorios.Name = "toolStripRelatorios";
            this.toolStripRelatorios.Size = new System.Drawing.Size(71, 20);
            this.toolStripRelatorios.Text = "Relatórios";
            // 
            // subProdutosRelatorios
            // 
            this.subProdutosRelatorios.Name = "subProdutosRelatorios";
            this.subProdutosRelatorios.Size = new System.Drawing.Size(180, 22);
            this.subProdutosRelatorios.Text = "Produtos";
            this.subProdutosRelatorios.Click += new System.EventHandler(this.subProdutosRelatorios_Click);
            // 
            // subMercadoriasRelatorios
            // 
            this.subMercadoriasRelatorios.Name = "subMercadoriasRelatorios";
            this.subMercadoriasRelatorios.Size = new System.Drawing.Size(180, 22);
            this.subMercadoriasRelatorios.Text = "Mercadorias";
            this.subMercadoriasRelatorios.Click += new System.EventHandler(this.subMercadoriasRelatorios_Click);
            // 
            // subVendasRelatorios
            // 
            this.subVendasRelatorios.Name = "subVendasRelatorios";
            this.subVendasRelatorios.Size = new System.Drawing.Size(180, 22);
            this.subVendasRelatorios.Text = "Vendas";
            this.subVendasRelatorios.Click += new System.EventHandler(this.subVendasRelatorios_Click);
            // 
            // panelVendas
            // 
            this.panelVendas.Controls.Add(this.menuStrip3);
            this.panelVendas.Location = new System.Drawing.Point(1, 300);
            this.panelVendas.Name = "panelVendas";
            this.panelVendas.Size = new System.Drawing.Size(130, 31);
            this.panelVendas.TabIndex = 1;
            // 
            // menuStrip3
            // 
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripVendas});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(130, 24);
            this.menuStrip3.TabIndex = 0;
            this.menuStrip3.Text = "menuStrip4";
            // 
            // toolStripVendas
            // 
            this.toolStripVendas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subFeiraVendas});
            this.toolStripVendas.Name = "toolStripVendas";
            this.toolStripVendas.Size = new System.Drawing.Size(56, 20);
            this.toolStripVendas.Text = "Vendas";
            // 
            // subFeiraVendas
            // 
            this.subFeiraVendas.Name = "subFeiraVendas";
            this.subFeiraVendas.Size = new System.Drawing.Size(180, 22);
            this.subFeiraVendas.Text = "Feira";
            this.subFeiraVendas.Click += new System.EventHandler(this.subFeiraVendas_Click);
            // 
            // panelMercadorias
            // 
            this.panelMercadorias.Controls.Add(this.menuStrip2);
            this.panelMercadorias.Location = new System.Drawing.Point(1, 226);
            this.panelMercadorias.Name = "panelMercadorias";
            this.panelMercadorias.Size = new System.Drawing.Size(130, 31);
            this.panelMercadorias.TabIndex = 1;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMercadorias});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(130, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMercadorias
            // 
            this.toolStripMercadorias.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subCadastrarMercadorias,
            this.subEstoqueMercadorias,
            this.subConsultaMercadorias});
            this.toolStripMercadorias.Name = "toolStripMercadorias";
            this.toolStripMercadorias.Size = new System.Drawing.Size(84, 20);
            this.toolStripMercadorias.Text = "Mercadorias";
            // 
            // subCadastrarMercadorias
            // 
            this.subCadastrarMercadorias.Name = "subCadastrarMercadorias";
            this.subCadastrarMercadorias.Size = new System.Drawing.Size(180, 22);
            this.subCadastrarMercadorias.Text = "Cadastrar";
            this.subCadastrarMercadorias.Click += new System.EventHandler(this.subCadastrarMercadorias_Click);
            // 
            // subEstoqueMercadorias
            // 
            this.subEstoqueMercadorias.Name = "subEstoqueMercadorias";
            this.subEstoqueMercadorias.Size = new System.Drawing.Size(180, 22);
            this.subEstoqueMercadorias.Text = "Estoque";
            this.subEstoqueMercadorias.Click += new System.EventHandler(this.subEstoqueMercadorias_Click);
            // 
            // subConsultaMercadorias
            // 
            this.subConsultaMercadorias.Name = "subConsultaMercadorias";
            this.subConsultaMercadorias.Size = new System.Drawing.Size(180, 22);
            this.subConsultaMercadorias.Text = "Consulta";
            this.subConsultaMercadorias.Click += new System.EventHandler(this.subConsultaMercadorias_Click);
            // 
            // panelProdutos
            // 
            this.panelProdutos.Controls.Add(this.menuStrip5);
            this.panelProdutos.Location = new System.Drawing.Point(1, 189);
            this.panelProdutos.Name = "panelProdutos";
            this.panelProdutos.Size = new System.Drawing.Size(130, 31);
            this.panelProdutos.TabIndex = 1;
            // 
            // menuStrip5
            // 
            this.menuStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProdutos});
            this.menuStrip5.Location = new System.Drawing.Point(0, 0);
            this.menuStrip5.Name = "menuStrip5";
            this.menuStrip5.Size = new System.Drawing.Size(130, 24);
            this.menuStrip5.TabIndex = 0;
            this.menuStrip5.Text = "menuStrip1";
            // 
            // toolStripProdutos
            // 
            this.toolStripProdutos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subCadastrarProdutos,
            this.subEstoqueProdutos,
            this.subConsultaProdutos});
            this.toolStripProdutos.Name = "toolStripProdutos";
            this.toolStripProdutos.Size = new System.Drawing.Size(67, 20);
            this.toolStripProdutos.Text = "Produtos";
            // 
            // subCadastrarProdutos
            // 
            this.subCadastrarProdutos.Name = "subCadastrarProdutos";
            this.subCadastrarProdutos.Size = new System.Drawing.Size(180, 22);
            this.subCadastrarProdutos.Text = "Cadastrar";
            this.subCadastrarProdutos.Click += new System.EventHandler(this.subCadastrarProdutos_Click);
            // 
            // subEstoqueProdutos
            // 
            this.subEstoqueProdutos.Name = "subEstoqueProdutos";
            this.subEstoqueProdutos.Size = new System.Drawing.Size(180, 22);
            this.subEstoqueProdutos.Text = "Estoque";
            this.subEstoqueProdutos.Click += new System.EventHandler(this.subEstoqueProdutos_Click);
            // 
            // subConsultaProdutos
            // 
            this.subConsultaProdutos.Name = "subConsultaProdutos";
            this.subConsultaProdutos.Size = new System.Drawing.Size(180, 22);
            this.subConsultaProdutos.Text = "Consulta";
            this.subConsultaProdutos.Click += new System.EventHandler(this.subConsultaProdutos_Click);
            // 
            // panelEstoque
            // 
            this.panelEstoque.Controls.Add(this.menuStrip1);
            this.panelEstoque.Location = new System.Drawing.Point(1, 263);
            this.panelEstoque.Name = "panelEstoque";
            this.panelEstoque.Size = new System.Drawing.Size(130, 31);
            this.panelEstoque.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripEstoque});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(130, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip3";
            // 
            // toolStripEstoque
            // 
            this.toolStripEstoque.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subProdutosEstoque,
            this.subMercadoriasEstoque});
            this.toolStripEstoque.Name = "toolStripEstoque";
            this.toolStripEstoque.Size = new System.Drawing.Size(61, 20);
            this.toolStripEstoque.Text = "Estoque";
            // 
            // subProdutosEstoque
            // 
            this.subProdutosEstoque.Name = "subProdutosEstoque";
            this.subProdutosEstoque.Size = new System.Drawing.Size(139, 22);
            this.subProdutosEstoque.Text = "Produtos";
            this.subProdutosEstoque.Click += new System.EventHandler(this.subProdutosEstoque_Click);
            // 
            // subMercadoriasEstoque
            // 
            this.subMercadoriasEstoque.Name = "subMercadoriasEstoque";
            this.subMercadoriasEstoque.Size = new System.Drawing.Size(139, 22);
            this.subMercadoriasEstoque.Text = "Mercadorias";
            this.subMercadoriasEstoque.Click += new System.EventHandler(this.subMercadoriasEstoque_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.White;
            this.panelPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPrincipal.Location = new System.Drawing.Point(159, 26);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1031, 587);
            this.panelPrincipal.TabIndex = 1;
            // 
            // hora
            // 
            this.hora.Enabled = true;
            this.hora.Tick += new System.EventHandler(this.hora_Tick);
            // 
            // lblHora
            // 
            this.lblHora.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(1108, 616);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(99, 23);
            this.lblHora.TabIndex = 2;
            this.lblHora.Text = "Hora";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(43)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1205, 639);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(12, 27);
            this.MaximizeBox = false;
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Painel de Controle";
            this.panel1.ResumeLayout(false);
            this.panelCadastrar.ResumeLayout(false);
            this.panelCadastrar.PerformLayout();
            this.menuStrip6.ResumeLayout(false);
            this.menuStrip6.PerformLayout();
            this.panelRelatorios.ResumeLayout(false);
            this.panelRelatorios.PerformLayout();
            this.menuStrip4.ResumeLayout(false);
            this.menuStrip4.PerformLayout();
            this.panelVendas.ResumeLayout(false);
            this.panelVendas.PerformLayout();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.panelMercadorias.ResumeLayout(false);
            this.panelMercadorias.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panelProdutos.ResumeLayout(false);
            this.panelProdutos.PerformLayout();
            this.menuStrip5.ResumeLayout(false);
            this.menuStrip5.PerformLayout();
            this.panelEstoque.ResumeLayout(false);
            this.panelEstoque.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.MenuStrip menuStrip4;
        private System.Windows.Forms.ToolStripMenuItem toolStripRelatorios;
        private System.Windows.Forms.ToolStripMenuItem subProdutosRelatorios;
        private System.Windows.Forms.ToolStripMenuItem subMercadoriasRelatorios;
        private System.Windows.Forms.ToolStripMenuItem subVendasRelatorios;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem toolStripVendas;
        private System.Windows.Forms.ToolStripMenuItem subFeiraVendas;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMercadorias;
        private System.Windows.Forms.ToolStripMenuItem subCadastrarMercadorias;
        private System.Windows.Forms.ToolStripMenuItem subEstoqueMercadorias;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripEstoque;
        private System.Windows.Forms.ToolStripMenuItem subProdutosEstoque;
        private System.Windows.Forms.ToolStripMenuItem subMercadoriasEstoque;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Timer hora;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.MenuStrip menuStrip6;
        private System.Windows.Forms.ToolStripMenuItem toolStripCadastrar;
        private System.Windows.Forms.ToolStripMenuItem subClientesCadastrar;
        private System.Windows.Forms.ToolStripMenuItem subFuncionariosCadastrar;
        private System.Windows.Forms.ToolStripMenuItem subCadastrarProdutos;
        private System.Windows.Forms.ToolStripMenuItem subEstoqueProdutos;
        private System.Windows.Forms.ToolStripMenuItem subConsultaMercadorias;
        private System.Windows.Forms.ToolStripMenuItem subConsultaProdutos;
        public System.Windows.Forms.ToolStripMenuItem toolStripProdutos;
        public System.Windows.Forms.MenuStrip menuStrip5;
        public System.Windows.Forms.Panel panelProdutos;
        public System.Windows.Forms.Panel panelRelatorios;
        public System.Windows.Forms.Panel panelVendas;
        public System.Windows.Forms.Panel panelMercadorias;
        public System.Windows.Forms.Panel panelEstoque;
        public System.Windows.Forms.Panel panelCadastrar;
    }
}