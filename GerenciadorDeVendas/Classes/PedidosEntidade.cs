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

                
                //

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
                    enPedidos.ItemsPedidosClientes.Add(new ItemsPedidosClientes
                    {
                        CodProduto = int.Parse((string)item.Tag),
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
