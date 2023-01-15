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
            this.Hide();
            frmClientes.ShowDialog();
            this.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnGerenciarPedidos_Click(object sender, EventArgs e)
        {
            frmPedidos frmPedido = new frmPedidos();
            this.Hide();
            frmPedido.ShowDialog();
            this.Show();
        }

        private void btnGerenciarProdutos_Click(object sender, EventArgs e)
        {
            frmProdutos frmProdutos = new frmProdutos();
            this.Hide();
            frmProdutos.ShowDialog();
            this.Show();
        }

        private void btnGerenciarFinancas_Click(object sender, EventArgs e)
        {
            frmFinancas frmFinancas = new frmFinancas();
            this.Hide();
            frmFinancas.ShowDialog();
            this.Show();
        }
    }
}
