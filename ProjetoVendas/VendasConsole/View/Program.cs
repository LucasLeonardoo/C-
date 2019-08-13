using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasConsole.DAL;
using VendasConsole.Model;

namespace VendasConsole.View
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;

            do
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.Clear();

                Menu.Renderizar();

                Console.WriteLine("");

                Console.WriteLine("Selecione a Opção Desejada!");

                op = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                
                switch (op)
                {
                    case 1:

                        CadastrarCliente.Renderizar();

                        break;

                    case 2:

                        #region Testando Override Equals
                        //Cliente c1 = new Cliente();

                        //c1.Nome = "Lucas";
                        //c1.Cpf = "1234567";

                        //Cliente c2 = new Cliente();

                        //c2.Nome = "Lucas";
                        //c2.Cpf = "1234567";

                        //if (c1.Equals(c2))
                        //{
                        //    Console.WriteLine("Igual");
                        //} else
                        //{
                        //    Console.WriteLine("Diferente");
                        //}
                        #endregion

                        ListarClientes.Renderizar();

                        break;

                    case 0:

                        Console.WriteLine("Saindo!");

                        break;

                    default:
                        Console.WriteLine("Opção Inválida!");
                        break;
                }

                Console.WriteLine("\nAperte qualquer tecla para continuar... ");
                Console.ReadKey();

            } while (op != 0);

        }

    }
}
