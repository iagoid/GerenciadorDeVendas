using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeVendas.Classes
{
    internal class ComprasEntidade: PedidoFornecedores
    {
        public void Adicionar(ListView.ListViewItemCollection list)
        {
            //Instanciando a conexão com a base de dados
            using (DatabaseEntities dbContext = new DatabaseEntities())
            {
                ItemsPedidosFornecedor itens = new ItemsPedidosFornecedor();
                Parcelas parcelas = new Parcelas();

                PedidoFornecedores enPedidos = new PedidoFornecedores
                {
                    CodPedidoF = this.CodPedidoF,
                    ValorTotal = this.ValorTotal,
                    TotalParcelas = this.TotalParcelas,
                    Status = "1",
                    Data = DateTime.Now,

                };

                foreach (ListViewItem item in list)
                {
                    itens.CodPedidoFornecedor = this.CodPedidoF;
                    itens.CodProduto = (int)item.Tag;
                    itens.Quantidade = int.Parse(item.SubItems[1].Text);
                    itens.PedidoFornecedores = enPedidos;

                    dbContext.ItemsPedidosFornecedor.Add(itens);
                }

                DateTime dataParcela = DateTime.Now;
                for (int i = 0; i < this.TotalParcelas; i++)
                {
                    dataParcela = dataParcela.AddMonths(1);
                    dbContext.Parcelas.Add(new Parcelas
                    {
                        PedidoFornecedores = enPedidos,
                        DtPagamento = dataParcela,
                        Valor = Math.Round(this.ValorTotal / this.TotalParcelas, 2),
                        Status = "2"
                    });
                    
                }


                dbContext.PedidoFornecedores.Add(enPedidos);
                dbContext.SaveChanges();
            }

        }

        public List<PedidoFornecedores> Listar(string parametro = "")
        {
            using (DatabaseEntities dbContext = new DatabaseEntities())
            {
                return dbContext.PedidoFornecedores.Where(m =>
                    m.Status.StartsWith(parametro)).ToList();
            }
        }
    }
}
