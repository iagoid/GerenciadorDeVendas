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
            decimal totalDebito = 0, totalCredito = 0;

            try
            {
                this.lstCredito.Items.Clear();
                this.lstDebito.Items.Clear();

                ParcelasEntidade enParcelas = new ParcelasEntidade();
                var listaParcelas = enParcelas.ListarCredito(dtFiltro.Value);
                foreach (ParcelasContainer p in listaParcelas)
                {
                    ListViewItem ItemX = new ListViewItem(p.Nome);
                    ItemX.SubItems.Add(p.Valor.ToString());
                    ItemX.SubItems.Add(p.DtPagamento.ToShortDateString());
                    totalCredito += p.Valor;
                    lstCredito.Items.Add(ItemX);
                }


                ParcelasEntidade enParcelas2 = new ParcelasEntidade();
                var listaParcelas2 = enParcelas.ListarDebito(dtFiltro.Value);
                foreach (ParcelasContainer p in listaParcelas2)
                {
                    ListViewItem ItemX = new ListViewItem(p.Nome);
                    ItemX.SubItems.Add(p.Valor.ToString());
                    ItemX.SubItems.Add(p.DtPagamento.ToShortDateString());
                    totalDebito += p.Valor;
                    lstDebito.Items.Add(ItemX);
                }

                lblCredito.Text = "R$" + totalCredito.ToString();
                lblDebito.Text = "R$" +totalDebito.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }
        }

        private void dtFiltro_Validated(object sender, EventArgs e)
        {
            Listar();
        }


        private void dtFiltro_CloseUp(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
