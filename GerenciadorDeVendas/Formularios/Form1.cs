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

namespace GerenciadorDeVendas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string message = "";
            if (string.IsNullOrEmpty(this.txtUsuario.Text.Trim()))
            {
                message += "O campo usuário é obrigatório\n";
            }
            if (string.IsNullOrEmpty(this.txtSenha.Text.Trim()))
            {
                message += "O campo senha é obrigatório\n";
            }
            if (!string.IsNullOrEmpty(message))
            {
                MessageBox.Show(message);
                return;
            }

            UsuariosEntidade user = new UsuariosEntidade
            {
                Nome = this.txtUsuario.Text.Trim(),
                Senha = this.txtSenha.Text.Trim()
            };

            if (user.Login()) {
                frmMenu mainMenu = new frmMenu(this.txtUsuario.Text);
                this.Hide();
                mainMenu.ShowDialog();
                this.Close();
            } else
            {
                MessageBox.Show("Seu usuário ou senha estão incorretos");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
