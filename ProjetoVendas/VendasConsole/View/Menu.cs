using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasConsole.View
{
    class Menu
    {
        public static void Renderizar()
        {
            Console.WriteLine("--|MENU VENDAS|--\n");
            Console.WriteLine("1 - Cadastrar Clientes");
            Console.WriteLine("2 - Listar Clientes\n");

            Console.WriteLine("0 - Sair");
        }
    }
}
