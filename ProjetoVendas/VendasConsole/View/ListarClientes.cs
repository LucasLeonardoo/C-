using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasConsole.DAL;

namespace VendasConsole.View
{
    class ListarClientes
    {
        public static void Renderizar()
        {

            Console.Clear();

            //List<Cliente> cs = new List<Cliente>();

            //cs = ClienteDAO.listaClientes();

            Console.WriteLine(" --- Lista de Clientes ---");

            foreach (var item in ClienteDAO.listaClientes())
            {
                Console.WriteLine("\nNome: " + item.Nome);
                Console.WriteLine("Cpf: " + item.Cpf);
                Console.WriteLine("\n---------------------------");
            }

        }
    }
}
