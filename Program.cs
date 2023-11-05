using System;

namespace TP_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa("João", 30);
            pessoa1.ExibirInformacoes();

            Pessoa pessoa2 = new Pessoa();
            pessoa2.Nome = "Maria";
            pessoa2.DataNascimento = ("12/05/2023");
            pessoa2.ExibirInformacoes();

        }
    }
}

