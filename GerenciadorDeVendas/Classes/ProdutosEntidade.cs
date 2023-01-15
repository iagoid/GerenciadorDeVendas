using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeVendas.Classes
{
    internal class ProdutosEntidade:Produtos
    {
        public void Adicionar()
        {
            //Instanciando a conexão com a base de dados
            using (DatabaseEntities dbContext = new DatabaseEntities())
            {
                Produtos enProduto = new Produtos
                {
                    Nome = this.Nome,
                    Tamanho = this.Tamanho,
                    ValorUnitario = this.ValorUnitario,
                };

                dbContext.Produtos.Add(enProduto);
                dbContext.SaveChanges();
            }

        }

        public List<Produtos> Listar(string parametro = "")
        {
            using (DatabaseEntities dbContext = new DatabaseEntities())
            {
                return dbContext.Produtos.Where(m =>
                    m.Nome.StartsWith(parametro)).ToList();
            }
        }

        public void Editar()
        {
            using (DatabaseEntities dbContext = new DatabaseEntities())
            {
                Produtos enProduto = new Produtos
                {
                    CodProduto = this.CodProduto,
                    Nome = this.Nome,
                    Tamanho = this.Tamanho,
                    ValorUnitario = this.ValorUnitario
                };

                dbContext.Produtos.AddOrUpdate(enProduto);
                dbContext.SaveChanges();
            }
        }

        public void Excluir()
        {
            using (DatabaseEntities dbContext = new DatabaseEntities())
            {
                Produtos enProduto = new Produtos
                {
                    CodProduto = this.CodProduto,
                };

                dbContext.Produtos.Attach(enProduto);
                dbContext.Produtos.Remove(enProduto);
                dbContext.SaveChanges();
            }
        }
    }
}
