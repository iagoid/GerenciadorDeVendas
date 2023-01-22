using GerenciadorDeVendas.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GerenciadorDeVendas.Formularios
{
    public partial class frmClientes : Form
    {
        public frmClientes()
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
            if (string.IsNullOrEmpty(this.txtTelefone.Text))
            {
                message += "Campo Telefone é obrigatório\n";
            }
            else if(!long.TryParse(this.txtTelefone.Text, out _)) {
                message += "Campo Telefone é apenas numérico\n";
            }

            if (string.IsNullOrEmpty(this.txtCPF.Text))
            {
                message += "Campo CPF é obrigatório\n";
            }
            else if (!long.TryParse(this.txtCPF.Text, out _))
            {
                message += "Campo CPF é apenas numérico\n";
            }
            if (string.IsNullOrEmpty(this.txtEndereco.Text))
            {
                message += "Campo Endereço é obrigatório\n";
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
                MessageBox.Show("Cliente Inserido com sucesso");
                Limpar();
            } else
            {
                MessageBox.Show("Houve um erro ao inserir");
            }
        }

        private bool Inserir()
        {
            try
            {
                ClientesEntidade enClientes = new ClientesEntidade();
                enClientes.Nome = txtNome.Text;
                enClientes.Telefone = txtTelefone.Text;
                enClientes.CPF =  txtCPF.Text;
                enClientes.Endereco = txtEndereco.Text;

                enClientes.Adicionar();
                ListarClientes();
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
                ClientesEntidade enClientes = new ClientesEntidade();
                enClientes.CodCliente = int.Parse(txtID.Text);
                enClientes.Nome = txtNome.Text;
                enClientes.Telefone = txtTelefone.Text;
                enClientes.CPF = txtCPF.Text;
                enClientes.Endereco = txtEndereco.Text;

                enClientes.Editar();
                ListarClientes();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
                return false;
            }
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            ListarClientes();
        }

        private void ListarClientes()
        {
            try
            {
                this.lstClientes.Items.Clear();

                ClientesEntidade enCliente = new ClientesEntidade();
                List<Clientes> listaClientes = enCliente.Listar(txtBusca.Text);
                foreach (Clientes c in listaClientes)
                {
                    ListViewItem ItemX = new ListViewItem(c.Nome);
                    ItemX.Tag = c.CodCliente;
                    ItemX.SubItems.Add(c.Telefone);
                    ItemX.SubItems.Add(c.Endereco);
                    ItemX.SubItems.Add(c.CPF);
                    lstClientes.Items.Add(ItemX);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }
        }

        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lstClientes.SelectedIndices.Count > 0)
            {
                btnExcluir.Enabled = true;
                btnEditar.Enabled = true;
            } else
            {
                btnExcluir.Enabled = false;
                btnEditar.Enabled = false;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (btnEditar.Text == "Editar")
            {
                ListViewItem item = lstClientes.SelectedItems[0];
                txtID.Text = item.Tag.ToString();
                txtNome.Text = item.Text;
                txtTelefone.Text = item.SubItems[1].Text;
                txtEndereco.Text = item.SubItems[2].Text;
                txtCPF.Text = item.SubItems[3].Text;

                btnInserir.Enabled = false;
                btnExcluir.Enabled = false;
                btnEditar.Text = "Salvar";
                lstClientes.Enabled = false;
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
                        MessageBox.Show("Cliente Editado com Sucesso");
                    } else
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
            } else
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
            txtTelefone.Text = "";
            txtEndereco.Text = "";
            txtCPF.Text = "";

            btnEditar.Text = "Editar";
            btnExcluir.Enabled = false;
            btnEditar.Enabled = false;
            btnInserir.Enabled = true;
            lstClientes.Enabled = true;
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
                ListViewItem item = lstClientes.SelectedItems[0];

                DialogResult dr = MessageBox.Show($"Deseja excluir o cliente {item.Text}",
                    "Deseja Excluir?", MessageBoxButtons.YesNo);
                    
                if (dr == DialogResult.Yes)
                {

                    if (Excluir())
                    {
                        lstClientes.SelectedItems[0].Remove();
                        MessageBox.Show("Cliente deletado com sucesso");
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
                ListViewItem item = lstClientes.SelectedItems[0];
                ClientesEntidade enClientes = new ClientesEntidade();
                enClientes.CodCliente = int.Parse(item.Tag.ToString());

                enClientes.Excluir();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
                return false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ListarClientes();
        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }

}
