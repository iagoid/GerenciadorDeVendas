using GerenciadorDeVendas.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeVendas.Formularios
{
    public partial class frmListarPedidos : Form
    {
        public frmListarPedidos()
        {
            InitializeComponent();
        }

        private void ListarPedidos()
        {
            try
            {
                this.lstClientes.Items.Clear();

                PedidosEntidade enPedidos = new PedidosEntidade();
                List<PedidosContainer> listaClientes = enPedidos.ListarPedidosClientes(txtBusca.Text);
                foreach (PedidosContainer p in listaClientes)
                {
                    ListViewItem ItemX = new ListViewItem(p.NomeCliente);
                    ItemX.Tag = p.CodPedidoCliente;
                    ItemX.SubItems.Add(p.Produto);
                    ItemX.SubItems.Add(p.Quantidade.ToString());
                    lstClientes.Items.Add(ItemX);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }
        }

        private void btnNovoPedido_Click(object sender, EventArgs e)
        {
            frmPedidos frmPedidos = new frmPedidos();
            frmPedidos.ShowDialog();
        }

        private void frmListarPedidos_Load(object sender, EventArgs e)
        {
            ListarPedidos();
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            ListarPedidos();
        }
    }
}
