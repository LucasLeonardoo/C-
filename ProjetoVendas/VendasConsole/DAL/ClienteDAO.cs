using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasConsole.Model;

namespace VendasConsole.DAL
{
    class ClienteDAO
    {
        private ClienteDAO() { }

        private static List<Cliente> clientes = new List<Cliente>();

        /// <summary>
        /// Descrição breve do que o método faz
        /// </summary>
        /// <param name="Informação sobre o parâmetro"></param>
        /// <returns>Retorna verdadeiro caso consiga realizar o cadastro</returns>
        public static bool CadastrarCliente(Cliente c)
        {

            foreach (var item in clientes)
            {
                if (item.Cpf.Equals(c.Cpf))
                {
                    return false;
                }
            }

            clientes.Add(c);
            return true;

            #region Método Alternativo
            //if (clientes.Count > 0)
            //{
            //    // Verifica se Existe o CPF
            //}
            //else
            //{
            //    clientes.Add(c);

            //    Console.WriteLine("\nCliente Cadastrado!");
            //}
            #endregion

        }

        public static List<Cliente> listaClientes()
        {
            return clientes;
        }

        //public static Boolean VerificaCpfExistente(Cliente c)
        //{
        //    foreach (var item in clientes)
        //    {
        //        if (item.Cpf.Equals(c.Cpf))
        //        {
        //            return true;
        //        }
        //    }

        //    return false;
        //}
    }
}
