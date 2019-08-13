using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasConsole.Model
{
    class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }

        public Cliente()
        {
            
        }

        public override string ToString()
        {
            return "Nome: " + this.Nome 
                + "\nCPF: " + this.Cpf;
        }

        #region Override Equals ( Comparando propriedades "NOME E CPF" de dois objetos "CLIENTE" )
        //public override bool Equals(object obj)
        //{
        //    return ((Cliente)obj).Nome == Nome && ((Cliente)obj).Cpf == Cpf;
        //}
        #endregion

        #region contrutor com parâmetros obrigatórios
        //public Cliente(string nome, string cpf)
        //{

        //}
        #endregion

        #region JAVA
        //private string Nome;
        //private string Cpf;

        //public string GetNome()
        //{
        //    return this.Nome;
        //}

        //public void SetNome(string nome)
        //{
        //    this.Nome = nome;
        //}

        //public string GetCpf()
        //{
        //    return this.Cpf;
        //}

        //public void SetCpf(string cpf)
        //{
        //    this.Cpf = cpf;
        //}

        #endregion
    }
}
