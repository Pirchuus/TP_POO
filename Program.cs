using System;
using System.Collections.Generic;
using TP_POO.Enums;

namespace SistemaUrgencias
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataNascimento = new DateTime(1990, 5, 15);
            Utente pessoa1 = new Utente("Joao", 123456789, Sexo.Masculino, dataNascimento, Cidade.Braga, "4700-400", 13);
            pessoa1.ExibirInformacoes();
            Console.ReadKey();

        }

    }
}
