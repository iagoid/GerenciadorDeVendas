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
    public partial class frmFinancas : Form
    {
        public frmFinancas()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            try
            {
                this.lstCredito.Items.Clear();
                this.lstDebito.Items.Clear();

                ParcelasEntidade enParcelas = new ParcelasEntidade();
                List<object> listaParcelas = enParcelas.Listar(dtFiltro.Value);
                foreach (ParcelasContainer p in listaParcelas)
                {
                    ListViewItem ItemX = new ListViewItem(p.Nome);
                    ItemX.SubItems.Add(p.Valor.ToString());
                    ItemX.SubItems.Add(p.DtPagamento.ToString());

                    if (p.CodPedidoCliente == 0)
                    {
                        lstDebito.Items.Add(ItemX);
                    }
                    else
                    {
                        lstCredito.Items.Add(ItemX);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }
        }

        private void dtFiltro_Leave(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
