using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeVendas.Classes
{
    internal class ClientesEntidade:Clientes
    {
        public void Adicionar()
        {
            //Instanciando a conexão com a base de dados
            using (DatabaseEntities dbContext = new DatabaseEntities())
            {
                Clientes entCliente = new Clientes
                {
                    Nome = this.Nome,
                    Telefone = this.Telefone,
                    CPF = this.CPF,
                    Endereco = this.Endereco
                };

                dbContext.Clientes.Add(entCliente);
                dbContext.SaveChanges();
            }

        }

        public List<Clientes> Listar(string parametro = "")
        {
            using (DatabaseEntities dbContext = new DatabaseEntities())
            {
                return dbContext.Clientes.Where(m =>
                    m.Nome.StartsWith(parametro)).OrderBy(m => m.Nome).ToList();
            }
        }

        public void Editar()
        {
            using (DatabaseEntities dbContext = new DatabaseEntities())
            {
                Clientes entCliente = new Clientes
                {
                    CodCliente = this.CodCliente,
                    Nome = this.Nome,
                    Telefone = this.Telefone,
                    CPF = this.CPF,
                    Endereco = this.Endereco
                };

                dbContext.Clientes.AddOrUpdate(entCliente);
                dbContext.SaveChanges();
            }
        }

        public void Excluir()
        {
            using (DatabaseEntities dbContext = new DatabaseEntities())
            {
                Clientes entCliente = new Clientes
                {
                    CodCliente = this.CodCliente,
                };

                dbContext.Clientes.Attach(entCliente);
                dbContext.Clientes.Remove(entCliente);
                dbContext.SaveChanges();
            }
        }
    }
}
