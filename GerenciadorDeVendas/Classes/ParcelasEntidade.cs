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
        // Status 1 = Pagamento do Cliente
        // Status 2 = Compra com o fornecedor
        public List<ParcelasContainer> ListarCredito(DateTime date)
        {

            DateTime primeiroDia = new DateTime(date.Year, date.Month, 1);
            DateTime ultimoDia = primeiroDia.AddMonths(1).AddSeconds(-1);

            List<ParcelasContainer> parcelas = new List<ParcelasContainer> { };
   
            using (DatabaseEntities dbContext = new DatabaseEntities())
            {
                var list = (
                            from parcela in dbContext.Parcelas
                            join pecliente in dbContext.PedidoClientes
                                on parcela.CodPedidoCliente equals pecliente.CodPedidoC
                            where parcela.DtPagamento >= primeiroDia
                            where parcela.DtPagamento <= ultimoDia
                            select new
                            {
                                pecliente.Clientes.Nome,

                                parcela.CodPedidoCliente,
                                parcela.CodPedidoForncedor,
                                pecliente.ItemsPedidosClientes,
                                parcela.Valor,
                                parcela.DtPagamento,
                                pecliente.TotalParcelas
                            }).ToList();

                foreach (var item in list)
                {
                    ParcelasContainer parcelasContainer = new ParcelasContainer();
                    parcelasContainer.Nome = item.Nome;
                    parcelasContainer.DtPagamento = item.DtPagamento;
                    parcelasContainer.CodPedidoCliente = item.CodPedidoCliente;
                    parcelasContainer.CodPedidoFornecedor = item.CodPedidoForncedor;
                    parcelasContainer.Valor = item.Valor;
                    parcelas.Add(parcelasContainer);
                }

                return parcelas;

            }
        }


        public List<ParcelasContainer> ListarDebito(DateTime date)
        {

            DateTime primeiroDia = new DateTime(date.Year, date.Month, 1);
            DateTime ultimoDia = primeiroDia.AddMonths(1).AddSeconds(-1);

            List<ParcelasContainer> parcelas = new List<ParcelasContainer> { };

            using (DatabaseEntities dbContext = new DatabaseEntities())
            {
                var list = (
                            from parcela in dbContext.Parcelas
                            join peFornecedor in dbContext.PedidoFornecedores
                                on parcela.CodPedidoForncedor equals peFornecedor.CodPedidoF
                            join peItems in dbContext.ItemsPedidosFornecedor
                                on peFornecedor.CodPedidoF equals peItems.CodPedidoFornecedor
   
                            where parcela.DtPagamento >= primeiroDia
                            where parcela.DtPagamento <= ultimoDia
                            select new
                            {
                                peItems.Produtos.Nome,
                                parcela.Valor,
                                parcela.DtPagamento,
                               
                            }).ToList();

                foreach (var item in list)
                {
                    ParcelasContainer parcelasContainer = new ParcelasContainer();
                    parcelasContainer.Nome = $"{item.Nome}";
                    parcelasContainer.DtPagamento = item.DtPagamento;
                    parcelasContainer.Valor = item.Valor;
                    parcelas.Add(parcelasContainer);
                }

                return parcelas;

            }
        }
    }
}
