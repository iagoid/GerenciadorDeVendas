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
    public partial class frmCompras : Form
    {
        public frmCompras()
        {
            InitializeComponent();
        }

        private string VerificarCampos()
        {
            String message = "";
            if (string.IsNullOrEmpty(this.txtQuantidade.Text.Trim()))
            {
                message += "Campo Quantidade é obrigatório\n";
            }
            if (string.IsNullOrEmpty(this.cmbProdutos.Text.Trim()))
            {
                message += "Campo Produto é obrigatório\n";
            }
            return message;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {

                String message = VerificarCampos();
                if (!string.IsNullOrEmpty(message))
                {
                    MessageBox.Show(message);
                    return;
                }

                string valorUnitario = cmbProdutos.Text.Trim().
                        Substring(cmbProdutos.Text.LastIndexOf("R$") + 2);
                decimal valorTotal = decimal.Parse(valorUnitario) * int.Parse(txtQuantidade.Text);

                int idProduto = ((KeyValuePair<int, string>)cmbProdutos.SelectedItem).Key;

                ListViewItem ItemX = new ListViewItem(cmbProdutos.Text.Trim());
                ItemX.Tag = idProduto;
                ItemX.SubItems.Add(txtQuantidade.Text.Trim());
                ItemX.SubItems.Add(valorTotal.ToString());
                lstProdutos.Items.Add(ItemX);

                decimal totalAtual = string.IsNullOrEmpty(txtTotal.Text.Trim()) ? 0 : decimal.Parse(txtTotal.Text.Trim());
                decimal totalAtualizado = Math.Round(totalAtual + valorTotal, 2);

                txtTotal.Text = totalAtualizado.ToString();

                CalcularParcelas(totalAtualizado);

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }
        }

        private void lstProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lstProdutos.SelectedIndices.Count > 0)
            {
                btnExcluir.Enabled = true;
            }
            else
            {
                btnExcluir.Enabled = false;
            }
        }

        private void frmPedidos_Load(object sender, EventArgs e)
        {
            ListagemProdutos();
        }

        private void ListagemProdutos()
        {
            ProdutosEntidade entProdutos = new ProdutosEntidade();
            List<Produtos> listProdutos = entProdutos.Listar();

            Dictionary<int, string> valorCmb = new Dictionary<int, string>();

            foreach (Produtos c in listProdutos)
            {
                valorCmb.Add(c.CodProduto, $"{c.Nome} {c.Tamanho} R${c.ValorUnitario}".Trim());
            }

            cmbProdutos.DataSource = new BindingSource(valorCmb, null);
            cmbProdutos.DisplayMember = "Value";
            cmbProdutos.ValueMember = "Key";

        }

        private void cmbProdutos_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cmbProdutos.Text.Trim()))
            {
                foreach (var item in cmbProdutos.Items)
                {
                    string nomeProduto = ((KeyValuePair<int, string>)item).Value;
                    if (nomeProduto.Equals(cmbProdutos.Text.Trim(), StringComparison.OrdinalIgnoreCase))
                    {
                        cmbProdutos.Text = nomeProduto;
                        return;
                    }
                }

                cmbProdutos.Focus();
                MessageBox.Show("Selecione um produto válido");
            }
        }

        private void CalcularParcelas(decimal total)
        {
            Dictionary<int, string> valorCmb = new Dictionary<int, string>();

            for (int i = 1; i <= 10; i++)
            {
                valorCmb.Add(i, $"{i}X de {Math.Round(total / i, 2)}");
            }

            cmbParcelas.DataSource = new BindingSource(valorCmb, null);
            cmbParcelas.DisplayMember = "Value";
            cmbParcelas.ValueMember = "Key";

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                ComprasEntidade entPedido = new ComprasEntidade();
                string qtdParcelas = cmbParcelas.Text.Substring(0, cmbParcelas.Text.IndexOf('X')).Trim();
                string valorParcelas = cmbParcelas.Text.Substring(cmbParcelas.Text.IndexOf('X') + 1).Trim();

                entPedido.TotalParcelas = int.Parse(qtdParcelas);
                entPedido.ValorTotal = decimal.Parse(txtTotal.Text.Trim());

                entPedido.Adicionar(lstProdutos.Items);

                lstProdutos.Items.Clear();
                cmbParcelas.DataSource = null;
                cmbParcelas.Items.Clear();
                txtTotal.Text = "";

                MessageBox.Show("Compras Cadastradas");

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }

        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txt.Text.Contains(','));
                }
                else
                    e.Handled = true;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {

            ListViewItem item = lstProdutos.SelectedItems[0];

            DialogResult dr = MessageBox.Show($"Deseja excluir o produto {item.Text.Trim()}",
                "Deseja Excluir?", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                decimal totalAtual = string.IsNullOrEmpty(txtTotal.Text.Trim()) ? 0 : decimal.Parse(txtTotal.Text.Trim());
                decimal precoProduto = decimal.Parse(item.SubItems[2].Text);
                decimal totalAtualizado = Math.Round(totalAtual - precoProduto, 2);

                txtTotal.Text = totalAtualizado.ToString();

                CalcularParcelas(totalAtualizado);

                lstProdutos.SelectedItems[0].Remove();
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }



        }

        private void btnExcluir_EnabledChanged(object sender, EventArgs e)
        {
                if (btnExcluir.Enabled)
                {
                    btnExcluir.BackColor = Color.IndianRed;
                }
                else
                {
                    btnExcluir.BackColor = Color.LightGray;
                }
        }
    }
}
