using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasConsole.DAL;
using VendasConsole.Model;

namespace VendasConsole.View
{
    class CadastrarCliente
    {

        public static void Renderizar()
        {
            Console.WriteLine("Cadastrar Cliente!");

            Cliente c = new Cliente();

            Console.WriteLine("\nNome do Cliente: ");
            c.Nome = Console.ReadLine();

            Console.WriteLine("\nCPF do Cliente: ");
            c.Cpf = Console.ReadLine();

            if (ClienteDAO.CadastrarCliente(c))
            {
                Console.WriteLine("\nCliente Cadastrado!");
            } else
            {
                Console.WriteLine("\nCPF já foi cadastrado!");
            }
        }
    }
}
