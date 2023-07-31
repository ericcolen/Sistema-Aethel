using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Aethel___2019
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmLogin outro = new frmLogin();
            outro.Show();
            this.Visible = false;
        }

        private void hora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH : mm: ss");
        }

        private void subCadastrarProdutos_Click(object sender, EventArgs e)
        {
            cadProdutos cadProd = new cadProdutos();
            cadProd.TopLevel = false;
            panelPrincipal.Controls.Add(cadProd);
            cadProd.BringToFront();
            cadProd.Show(); 
        }

        private void subEstoqueProdutos_Click(object sender, EventArgs e)
        {
            estqProdutos estqProd = new estqProdutos();
            estqProd.TopLevel = false;
            panelPrincipal.Controls.Add(estqProd);
            estqProd.BringToFront();
            estqProd.Show();
        }

        private void subConsultaProdutos_Click(object sender, EventArgs e)
        {
            consulProdutos consulProd = new consulProdutos();
            consulProd.TopLevel = false;
            panelPrincipal.Controls.Add(consulProd);
            consulProd.BringToFront();
            consulProd.Show();
        }

        private void subCadastrarMercadorias_Click(object sender, EventArgs e)
        {
            cadMercadorias cadMercad = new cadMercadorias();
            cadMercad.TopLevel = false;
            panelPrincipal.Controls.Add(cadMercad);
            cadMercad.BringToFront();
            cadMercad.Show();
        }

        private void subEstoqueMercadorias_Click(object sender, EventArgs e)
        {
            estqMercadorias estqMercad = new estqMercadorias();
            estqMercad.TopLevel = false;
            panelPrincipal.Controls.Add(estqMercad);
            estqMercad.BringToFront();
            estqMercad.Show();
        }

        private void subConsultaMercadorias_Click(object sender, EventArgs e)
        {
            consulMercadorias consulMercad= new consulMercadorias();
            consulMercad.TopLevel = false;
            panelPrincipal.Controls.Add(consulMercad);
            consulMercad.BringToFront();
            consulMercad.Show();
        }

        private void subProdutosEstoque_Click(object sender, EventArgs e)
        {
            prodEstoque prodEstq = new prodEstoque();
            prodEstq.TopLevel = false;
            panelPrincipal.Controls.Add(prodEstq);
            prodEstq.BringToFront();
            prodEstq.Show();
        }

        private void subMercadoriasEstoque_Click(object sender, EventArgs e)
        {
            mercadEstoque mercadEstq = new mercadEstoque();
            mercadEstq.TopLevel = false;
            panelPrincipal.Controls.Add(mercadEstq);
            mercadEstq.BringToFront();
            mercadEstq.Show();
        }

        private void subFeiraVendas_Click(object sender, EventArgs e)
        {
            feiraVendas fV= new feiraVendas();
            fV.TopLevel = false;
            panelPrincipal.Controls.Add(fV);
            fV.BringToFront();
            fV.Show();
        }

        private void subProdutosRelatorios_Click(object sender, EventArgs e)
        {
            prodRelatorio prodRelat = new prodRelatorio();
            prodRelat.TopLevel = false;
            panelPrincipal.Controls.Add(prodRelat);
            prodRelat.BringToFront();
            prodRelat.Show();
        }

        private void subMercadoriasRelatorios_Click(object sender, EventArgs e)
        {
            mercadRelatorio mercadRelat = new mercadRelatorio();
            mercadRelat.TopLevel = false;
            panelPrincipal.Controls.Add(mercadRelat);
            mercadRelat.BringToFront();
            mercadRelat.Show();
        }

        private void subVendasRelatorios_Click(object sender, EventArgs e)
        {
            vendaRelatorio vendRelat= new vendaRelatorio();
            vendRelat.TopLevel = false;
            panelPrincipal.Controls.Add(vendRelat);
            vendRelat.BringToFront();
            vendRelat.Show();
        }

        private void subClientesCadastrar_Click(object sender, EventArgs e)
        {
            clientCadastro clientCad = new clientCadastro();
            clientCad.TopLevel = false;
            panelPrincipal.Controls.Add(clientCad);
            clientCad.BringToFront();
            clientCad.Show();
        }

        private void subFuncionariosCadastrar_Click(object sender, EventArgs e)
        {
            funcioCadastro funcCad= new funcioCadastro();
            funcCad.TopLevel = false;
            panelPrincipal.Controls.Add(funcCad);
            funcCad.BringToFront();
            funcCad.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
