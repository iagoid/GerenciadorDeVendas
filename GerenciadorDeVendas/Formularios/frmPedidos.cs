using GerenciadorDeVendas.Classes;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace GerenciadorDeVendas.Formularios
{
    public partial class frmPedidos : Form
    {
        public frmPedidos()
        {
            InitializeComponent();
        }

        private string VerificarCampos()
        {
            String message = "";
            if (string.IsNullOrEmpty(this.cmbClientes.Text))
            {
                message += "Campo Cliente é obrigatório\n";
            }
            if (string.IsNullOrEmpty(this.txtQuantidade.Text))
            {
                message += "Campo Quantidade é obrigatório\n";
            }
            if (string.IsNullOrEmpty(this.cmbProdutos.Text))
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

                string valorUnitario = cmbProdutos.Text.
                        Substring(cmbProdutos.Text.LastIndexOf("R$") + 2);
                decimal valorTotal = decimal.Parse(valorUnitario) * int.Parse(txtQuantidade.Text);

                int idProduto = ((KeyValuePair<int, string>)cmbProdutos.SelectedItem).Key;

                ListViewItem ItemX = new ListViewItem(cmbProdutos.Text);
                ItemX.Tag = idProduto;
                ItemX.SubItems.Add(txtQuantidade.Text);
                ItemX.SubItems.Add(valorTotal.ToString());
                lstProdutos.Items.Add(ItemX);

                decimal totalAtual = string.IsNullOrEmpty(txtTotal.Text) ? 0 : decimal.Parse(txtTotal.Text);
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        void Limpar()
        {

            txtTotal.Text = "";
            txtTotal.Text = "";
            txtQuantidade.Text = "";

            btnFinalizar.Text = "Editar";
            btnExcluir.Enabled = false;
            btnFinalizar.Enabled = false;
            btnInserir.Enabled = true;
            lstProdutos.Enabled = true;
        }

        private void btnInserir_EnabledChanged(object sender, EventArgs e)
        {
            if (btnInserir.Enabled)
            {
                btnInserir.BackColor = Color.ForestGreen;
            }
            else
            {
                btnInserir.BackColor = Color.LightGray;
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ListViewItem item = lstProdutos.SelectedItems[0];

            DialogResult dr = MessageBox.Show($"Deseja excluir o produto {item.Text}",
                "Deseja Excluir?", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                lstProdutos.SelectedItems[0].Remove();
            }
        }

        private void frmPedidos_Load(object sender, EventArgs e)
        {
            ListagemClientes();
            ListagemProdutos();
        }

        private void ListagemClientes()
        {
            ClientesEntidade entClientes = new ClientesEntidade();
            List<Clientes> listClientes = entClientes.Listar();

            Dictionary<int, string> valorCmb = new Dictionary<int, string>();

            foreach (Clientes c in listClientes)
            {
                valorCmb.Add(c.CodCliente, $"{c.Nome} {c.Endereco} Tel:{FormatPhoneNumber(long.Parse(c.Telefone))}".Trim());
            }

            cmbClientes.DataSource = new BindingSource(valorCmb, null);
            cmbClientes.DisplayMember = "Value";
            cmbClientes.ValueMember = "Key";

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

        private void cmbClientes_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cmbClientes.Text))
            {
                foreach (var item in cmbClientes.Items)
                {
                    string nomeCliente = ((KeyValuePair<int, string>)item).Value;
                    if (nomeCliente.Equals(cmbClientes.Text, StringComparison.OrdinalIgnoreCase))
                    {
                        cmbClientes.Text = nomeCliente;
                        return;
                    }
                }

                cmbProdutos.Focus();
                MessageBox.Show("Selecione um cliente válido");

            }
        }

        private void cmbProdutos_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cmbProdutos.Text))
            {
                foreach (var item in cmbProdutos.Items)
                {
                    string nomeProduto = ((KeyValuePair<int, string>)item).Value;
                    if (nomeProduto.Equals(cmbProdutos.Text, StringComparison.OrdinalIgnoreCase))
                    {
                        cmbProdutos.Text = nomeProduto;
                        return;
                    }
                }

                cmbClientes.Focus();
                MessageBox.Show("Selecione um produto válido");
            }
        }

        private string FormatPhoneNumber(long number)
        {
            return number.ToString(@"(00) 00000-0000");
        }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbClientes.Enabled = true;
        }

        private void CalcularParcelas(decimal total)
        {
            Dictionary<int, string> valorCmb = new Dictionary<int, string>();

            for (int i = 1; i <= 10; i++)
            {
                valorCmb.Add(i, $"{i}X de {Math.Round(total /i, 2)}");
            }

            cmbParcelas.DataSource = new BindingSource(valorCmb, null);
            cmbParcelas.DisplayMember = "Value";
            cmbParcelas.ValueMember = "Key";

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try { 
                PedidosEntidade entPedido = new PedidosEntidade();
                string qtdParcelas = cmbParcelas.Text.Substring(0, cmbParcelas.Text.IndexOf('X')).Trim();
                string valorParcelas = cmbParcelas.Text.Substring(cmbParcelas.Text.IndexOf('X') + 1).Trim();

                entPedido.CodCliente = ((KeyValuePair<int, string>)cmbClientes.SelectedItem).Key;
                entPedido.TotalParcelas = int.Parse(qtdParcelas);
                entPedido.ValorTotal = decimal.Parse(txtTotal.Text);

                entPedido.Adicionar(lstProdutos.Items);

                lstProdutos.Items.Clear();
                cmbParcelas.DataSource = null;
                cmbParcelas.Items.Clear();
                txtTotal.Text = "";

                MessageBox.Show("Pedido Realizado");

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
    }
}
