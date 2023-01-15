using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            frmMenu mainMenu = new frmMenu();
            this.Hide();
            mainMenu.ShowDialog();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
