using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GerenciadorDeVendas.Classes;
using GerenciadorDeVendas.Formularios;

namespace GerenciadorDeVendas.Formularios
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGerenciarClientes_Click(object sender, EventArgs e)
        {
            frmClientes frmClientes = new frmClientes();
            frmClientes.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnGerenciarPedidos_Click(object sender, EventArgs e)
        {
            frmListarPedidos frmListarPedidos = new frmListarPedidos();
            frmListarPedidos.Show();
        }

        private void btnGerenciarProdutos_Click(object sender, EventArgs e)
        {
            frmProdutos frmProdutos = new frmProdutos();
            frmProdutos.Show();
        }

        private void btnGerenciarFinancas_Click(object sender, EventArgs e)
        {
            frmFinancas frmFinancas = new frmFinancas();
            frmFinancas.Show();
        }

        private void btnGerenciarCompras_Click(object sender, EventArgs e)
        {
            frmCompras frmCompras = new frmCompras();
            frmCompras.ShowDialog();
        }
    }
}
