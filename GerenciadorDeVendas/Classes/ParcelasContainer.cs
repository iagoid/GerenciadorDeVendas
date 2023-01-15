using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeVendas.Classes
{
    internal class ParcelasContainer
    {
        public int CodPedidoCliente { get; set; }
        public int CodPedidoFornecedor { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public System.DateTime DtPagamento { get; set; }
        
        public int TotalParcelas { get; set; }

    }
}
