//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GerenciadorDeVendas
{
    using System;
    using System.Collections.Generic;
    
    public partial class ItemsPedidosFornecedor
    {
        public int CodItemPedido { get; set; }
        public int Quantidade { get; set; }
        public int CodProduto { get; set; }
        public int CodPedidoFornecedor { get; set; }
    
        public virtual Produtos Produtos { get; set; }
        public virtual PedidoFornecedores PedidoFornecedores { get; set; }
    }
}
