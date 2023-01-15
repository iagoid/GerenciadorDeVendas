using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace GerenciadorDeVendas.Classes
{
    internal class ParcelasEntidade : Parcelas
    {

        public List<object> Listar(DateTime date)
        {

            DateTime primeiroDia = new DateTime(date.Year, date.Month, 1);
            DateTime ultimoDia = primeiroDia.AddMonths(1).AddSeconds(-1);
   
            using (DatabaseEntities dbContext = new DatabaseEntities())
            {
                var a = (
                            from parcela in dbContext.Parcelas
                            join pecliente in dbContext.PedidoClientes
                                on parcela.CodPedidoCliente equals pecliente.CodPedidoC
                                where parcela.DtPagamento >= primeiroDia
                                where parcela.DtPagamento <= ultimoDia
                          select new 
                          {
                              parcela.CodPedidoCliente,
                              parcela.CodPedidoForncedor,
                              pecliente.ItemsPedidosClientes,
                              parcela.Valor,
                              parcela.DtPagamento,
                              pecliente.TotalParcelas
                          }).ToList();

                //return a.OfType<ParcelasContainer>;

                //var innerJoin = dbContext.Parcelas.Join(
                //      dbContext.Produtos,  
                //      PedidoClientes =>  PedidoClientes.CodPedidoCliente,   
                //      Produtos => Produtos.CodProduto, 

                //      (Parcelas, PedidoClientes, Produtos) => new ParcelasContainer // result selector
                //      {
                //            CodPedidoCliente = CodPedidoCliente,
                //            CodPedidoFornecedor = CodPedidoForncedor,
                //            Nome = Nome,
                //            Valor = Valor,
                //            DtPagamento = DtPagamento,
                //            TotalParcelas = TotalParcelas
                //      });

                return new List<object> { };
                //List<ParcelasContainer> query =  dbContext.Parcelas
                //    .Join(dbContext.PedidoClientes, 
                //        pa => pa.CodPedidoCliente, 
                //        pe=> pe.CodProduto,
                //        (pa, pe) => new {Parcelas = pa, PedidoClientes = pe })
                //    .Join(dbContext.Produtos,
                //        x => x.PedidoClientes.CodProduto,
                //        pr => pr.CodProduto,
                //        (x, pr) => new { Parcelas = x, Produtos = pr })

                //    .Where(x => x.Parcelas.DtPagamento > primeiroDia 
                //    && x.Parcelas.DtPagamento < ultimoDia).ToList();


            }
        }
    }
}
