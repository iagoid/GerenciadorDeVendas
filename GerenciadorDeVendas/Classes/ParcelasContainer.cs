using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeVendas.Classes
{
    internal class ParcelasContainer
    {
        //public Clientes Clientes { get; set; }

        //public PedidoClientes Pedido { get; set; }

        //public  Parcelas Parcelas { get; set; }
        public Nullable<int> CodPedidoCliente { get; set; }

        public Nullable<int> CodPedidoFornecedor { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public System.DateTime DtPagamento { get; set; }
        
        //public int TotalParcelas { get; set; }

    }
}
