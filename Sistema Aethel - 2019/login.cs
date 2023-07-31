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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            DataTableReader dataTableReader = new DataTableReader(bdaethelDataSet.administrador);
            DataTableReader read = dataTableReader;
            bool logado = false;
            if (String.Compare(txtLogin.Text, "") != 0 && (String.Compare(txtSenha.Text, "") != 0) && (String.Compare(cbNivel.Text, "") != 0))
            {
                while (read.Read()) { if (String.Compare(txtLogin.Text, read.GetString(0)) == 0 && (String.Compare(txtSenha.Text, read.GetString(1))) == 0 && (String.Compare(cbNivel.Text, read.GetString(2))) == 0) logado = true; }
                if (logado)
                {
                    if (cbNivel.Text == "ADMINISTRADOR")
                    {
                        frmInicio abr = new frmInicio();
                        abr.panelProdutos.Enabled = true;
                        abr.Show();
                    }
                }
                else
                {
                    frmInicio abr = new frmInicio();
                    abr.panelEstoque.Enabled = false;
                    abr.panelVendas.Enabled = false;
                    abr.Show();
                }
            }
            else { MessageBox.Show("Login ou Senha incorretos"); }
        }

        private void btnFecharApp_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
