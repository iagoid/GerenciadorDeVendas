using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeVendas.Classes
{
    internal class PedidosEntidade: PedidoClientes
    {
        // Status 1 = Pedido Realidado Pelo Cliente
        // Status 2 = Pedido Enviado ao Fornecedor

        public void Adicionar(ListView.ListViewItemCollection list)
        {
            //Instanciando a conexão com a base de dados
            using (DatabaseEntities dbContext = new DatabaseEntities())
            {
                ItemsPedidosClientes itensClientes = new ItemsPedidosClientes();
                Parcelas parcelas = new Parcelas();

                PedidoClientes enPedidos = new PedidoClientes
                {
                    CodCliente = this.CodCliente,
                    ValorTotal = this.ValorTotal,
                    TotalParcelas = this.TotalParcelas,
                    Status = "1",
                    Data = DateTime.Now,

                };

                foreach (ListViewItem item in list)
                {
                    itensClientes.CodPedidoCliente = this.CodCliente;
                    itensClientes.CodProduto = (int)item.Tag;
                    itensClientes.Quantidade = int.Parse(item.SubItems[1].Text);
                    itensClientes.PedidoClientes = enPedidos;

                    dbContext.ItemsPedidosClientes.Add(itensClientes);
                }

                DateTime dataParcela = DateTime.Now;
                for (int i = 0; i < this.TotalParcelas; i++)
                {
                    dataParcela = dataParcela.AddMonths(1);
                    dbContext.Parcelas.Add(new Parcelas
                    {
                        PedidoClientes = enPedidos,
                        DtPagamento = dataParcela,
                        Valor = Math.Round(this.ValorTotal / this.TotalParcelas, 2),
                        Status = "1"
                    });
                    
                }


                dbContext.PedidoClientes.Add(enPedidos);
                dbContext.SaveChanges();
            }

        }

        public List<PedidoClientes> Listar(string parametro = "")
        {
            using (DatabaseEntities dbContext = new DatabaseEntities())
            {
                return dbContext.PedidoClientes.Where(m =>
                    m.Status.StartsWith(parametro)).ToList();
            }
        }

        //public void Editar()
        //{
        //    using (DatabaseEntities dbContext = new DatabaseEntities())
        //    {
        //        PedidoClientes entPedidos = new PedidoClientes
        //        {
        //            CodPedidoC = this.CodPedidoC,
        //            CodCliente = this.CodCliente,
        //            ValorTotal = this.ValorTotal,
        //            TotalParcelas = this.TotalParcelas,
        //            Status = this.Status,
        //            Data = this.Data,
        //        };

        //        dbContext.PedidoClientes.AddOrUpdate(entPedidos);
        //        dbContext.SaveChanges();
        //    }
        //}

        //public void Excluir()
        //{
        //    using (DatabaseEntities dbContext = new DatabaseEntities())
        //    {
        //        PedidoClientes entPedidos = new PedidoClientes
        //        {
        //            CodPedidoC = this.CodPedidoC,
        //        };

        //        dbContext.PedidoClientes.Attach(entPedidos);
        //        dbContext.PedidoClientes.Remove(entPedidos);
        //        dbContext.SaveChanges();
        //    }
        //}
    }
}
