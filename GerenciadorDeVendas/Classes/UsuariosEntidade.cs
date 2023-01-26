using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeVendas.Classes
{
    internal class UsuariosEntidade: Usuarios
    {
        public bool Login()
        {
            using (DatabaseEntities dbContext = new DatabaseEntities())
            {
                return dbContext.Usuarios
                    .Any(u => u.Nome == this.Nome && u.Senha == this.Senha);

            }
        }
    }
}
