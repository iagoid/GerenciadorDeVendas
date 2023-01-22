using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeVendas.Classes
{
    internal class PedidosContainer
    {
        public int CodPedidoCliente { get; set; }
        public string NomeCliente { get; set; }
        public string Produto { get; set; }
        public int Quantidade { get; set; }

    }
}
