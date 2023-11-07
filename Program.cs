using System;
using System.Collections.Generic;
using TP_POO.Enums;

namespace SistemaUrgencias
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Utente pessoa1 = new Utente("Joao", 123456789, Sexo.Masculino, , Cidade.Braga, "4700-400", 13);
            pessoa1.ExibirInformacoes();

        }

    }
}
