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
    public partial class frmProdutos : Form
    {
        public frmProdutos()
        {
            InitializeComponent();
        }

        private string VerificarCampos()
        {
            String message = "";
            if (string.IsNullOrEmpty(this.txtNome.Text))
            {
                message += "Campo Nome é obrigatório\n";
            }
            if (string.IsNullOrEmpty(this.txtValor.Text))
            {
                message += "Campo Valor é obrigatório\n";
            }
            if (string.IsNullOrEmpty(this.txtTamanho.Text))
            {
                message += "Campo Tamanho é obrigatório\n";
            }
            return message;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

            String message = VerificarCampos();
            if (!string.IsNullOrEmpty(message))
            {
                MessageBox.Show(message);
                return;
            }

            if (Inserir())
            {
                MessageBox.Show("Produto Inserido com sucesso");
                Limpar();
            }
            else
            {
                MessageBox.Show("Houve um erro ao inserir");
            }
        }

        private bool Inserir()
        {
            try
            {
                ProdutosEntidade enProdutos = new ProdutosEntidade();
                enProdutos.Nome = txtNome.Text;
                enProdutos.Tamanho = txtTamanho.Text;
                enProdutos.ValorUnitario = Decimal.Parse(txtValor.Text);

                enProdutos.Adicionar();
                ListarProdutos();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
                return false;
            }
        }

        private bool Editar()
        {
            try
            {
                ProdutosEntidade enProdutos = new ProdutosEntidade();
                enProdutos.CodProduto = int.Parse(txtID.Text);
                enProdutos.Nome = txtNome.Text;
                enProdutos.Tamanho = txtTamanho.Text;
                enProdutos.ValorUnitario = Decimal.Parse(txtValor.Text);

                enProdutos.Editar();
                ListarProdutos();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
                return false;
            }
        }

        private void ListarProdutos()
        {
            try
            {
                this.lstProdutos.Items.Clear();

                ProdutosEntidade enProdutos = new ProdutosEntidade();
                List<Produtos> listaProdutos = enProdutos.Listar(txtBusca.Text);
                foreach (Produtos p in listaProdutos)
                {
                    ListViewItem ItemX = new ListViewItem(p.Nome);
                    ItemX.Tag = p.CodProduto;
                    ItemX.SubItems.Add(p.ValorUnitario.ToString());
                    ItemX.SubItems.Add(p.Tamanho);
                    lstProdutos.Items.Add(ItemX);
                }
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

                btnEditar.Enabled = true;
            }
            else
            {
                btnExcluir.Enabled = false;
                btnEditar.Enabled = false;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (btnEditar.Text == "Editar")
            {
                ListViewItem item = lstProdutos.SelectedItems[0];
                txtID.Text = item.Tag.ToString();
                txtNome.Text = item.Text;
                txtValor.Text = item.SubItems[1].Text;
                txtTamanho.Text = item.SubItems[2].Text;

                btnInserir.Enabled = false;
                btnExcluir.Enabled = false;
                btnEditar.Text = "Salvar";
                lstProdutos.Enabled = false;
            }
            else
            {
                try
                {
                    String message = VerificarCampos();
                    if (!string.IsNullOrEmpty(message))
                    {
                        MessageBox.Show(message);
                        return;
                    }

                    if (Editar())
                    {
                        btnEditar.Text = "Editar";
                        btnExcluir.Enabled = true;
                        btnInserir.Enabled = true;
                        Limpar();
                        MessageBox.Show("Produto Editado com Sucesso");
                    }
                    else
                    {
                        MessageBox.Show("Houve um erro ao atualizar o cliente");
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show("ERRO: " + ex.Message);
                }
            }
        }

        private void btnEditar_EnabledChanged(object sender, EventArgs e)
        {
            if (btnEditar.Enabled)
            {
                btnEditar.BackColor = Color.DodgerBlue;
            }
            else
            {
                btnEditar.BackColor = Color.LightGray;
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        void Limpar()
        {
            txtID.Text = "";
            txtNome.Text = "";
            txtValor.Text = "";
            txtValor.Text = "";
            txtTamanho.Text = "";

            btnEditar.Text = "Editar";
            btnExcluir.Enabled = false;
            btnEditar.Enabled = false;
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

            DialogResult dr = MessageBox.Show($"Deseja excluir o cliente {item.Text}",
                "Deseja Excluir?", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {

                if (Excluir())
                {
                    lstProdutos.SelectedItems[0].Remove();
                    MessageBox.Show("Produto deletado com sucesso");
                }
                else
                {
                    MessageBox.Show("Houve um erro ao deletar o cliente");
                }
            }
        }

        private bool Excluir()
        {
            try
            {
                ListViewItem item = lstProdutos.SelectedItems[0];
                ProdutosEntidade enProdutos = new ProdutosEntidade();
                enProdutos.CodProduto = int.Parse(item.Tag.ToString());

                enProdutos.Excluir();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
                return false;
            }
        }

        private void txtEndereco_KeyPress(object sender, KeyPressEventArgs e)
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

        private void frmProdutos_Load(object sender, EventArgs e)
        {
            ListarProdutos();
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            ListarProdutos();
        }
    }
}
