using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeVendas.Classes
{
    static class Utils
    {
        public static string FormatPhoneNumber(long number)
        {
            return number.ToString(@"(00) 00000-0000");
        }
    }
}
