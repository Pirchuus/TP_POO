using System;
using TP_POO.Enums;
using SexoEnum = TP_POO.Enums.Sexo;
using CidadeEnum = TP_POO.Enums.Cidade;

namespace TP_POO.Class
{
    public class Utente : Pessoa
    {
        #region ATRIBUTOS
        /// <summary>
        /// Número do utente
        /// </summary>
        public int NumUtente { get; private set; }
        #endregion

        #region MÉTODOS
        public void ExibirUtente()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Numero de Telemovel: {NumTelemovel}");
            Console.WriteLine($"Sexo: {Sexo}");
            Console.WriteLine($"Data de Nascimento: {DataNascimento.ToString("yyyy-MM-dd")}");
            Console.WriteLine($"Cidade: {Cidade}");
            Console.WriteLine($"Codigo Postal: {CodigoPostal}");
            Console.WriteLine($"Numero de Utente: {NumUtente}");
        }

        public static Utente ObterUtente()
        {
            Console.Clear();
            Console.WriteLine("**************** Adicionar Utente ****************");

            // Variables to store user input
            string nome, codigoPostal, sexoStr, cidadeStr;
            DateTime dataNascimento;
            int numeroTelemovel, numeroUtente;
            SexoEnum sexo;
            CidadeEnum cidade;

            // Obtain data from the console
            Console.Write("Nome do Utente: ");
            nome = Console.ReadLine();
            Console.Write("Número de Telemóvel: ");
            numeroTelemovel = int.Parse(Console.ReadLine());

            Console.Write("Sexo do Utente: ");
            sexoStr = Console.ReadLine();
            if (!Enum.TryParse(sexoStr, true, out sexo))
            {
                Console.WriteLine("Sexo inválido. Use 'Masculino' ou 'Feminino'.");
                return null;
            }

            Console.Write("Data de Nascimento (yyyy-MM-dd): ");
            if (!DateTime.TryParse(Console.ReadLine(), out dataNascimento))
            {
                Console.WriteLine("Data de Nascimento inválida. Use o formato 'yyyy-MM-dd'.");
                return null;
            }

            Console.Write("Cidade do Utente: ");
            cidadeStr = Console.ReadLine();
            if (!Enum.TryParse(cidadeStr, true, out cidade))
            {
                Console.WriteLine("Cidade inválida. Use as cidades que são válidas.");
                return null;
            }

            Console.Write("Código Postal: ");
            codigoPostal = Console.ReadLine();
            Console.Write("Número de Utente: ");
            numeroUtente = int.Parse(Console.ReadLine());

            // Create the Utente object using the obtained data
            Utente utente = new Utente(nome, numeroTelemovel, sexo, dataNascimento, cidade, codigoPostal, numeroUtente);

            return utente;
        }

        #region CONSTRUTOR
        public Utente(string nome, int numTelemovel, Sexo sexo, DateTime dataNascimento, Cidade cidade, string codigoPostal, int numUtente)
            : base(nome, numTelemovel, sexo, dataNascimento, cidade, codigoPostal)
        {
            NumUtente = numUtente;
        }

        #endregion
        #endregion
    }

}