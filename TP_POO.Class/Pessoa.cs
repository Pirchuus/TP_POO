using System;
using TP_POO.Enums;

namespace TP_POO.Class
{
    public abstract class Pessoa
    {
        #region ATRIBUTOS

        /// <summary>
        /// Atributo sobre o nome da pessoa
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Atributo do número de telemovel da pessoa
        /// </summary>
        public int NumTelemovel { get; set; }

        /// <summary>
        /// Atributo sobre o género da pessoa. Este é um enumerado.
        /// </summary>
        public Sexo Sexo { get; set; }

        /// <summary>
        /// Data de Nascimento da Pessoa
        /// </summary>
        public DateTime DataNascimento { get; set; }

        /// <summary>
        /// Cidade de onde a pessoa é
        /// </summary>
        public Cidade Cidade { get; set; }

        /// <summary>
        /// Código Postal da pessoa
        /// </summary>
        public string CodigoPostal { get; set; }

        #endregion

        #region MÉTODOS

        // Método para exibir as informações de uma pessoa, que neste projeto,
        // estas informações irão utilizadas nas classes referentes ao médico e utente
        public void ExibirPessoa()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Número de Telemóvel: {NumTelemovel}");
            Console.WriteLine($"Sexo: {Sexo}");
            Console.WriteLine($"Data de Nascimento: {DataNascimento}");
            Console.WriteLine($"Cidade: {Cidade}");
            Console.WriteLine($"Codigo Postal: {CodigoPostal}");
        }

        #region CONSTRUTOR
        protected Pessoa(string nome, int numTelemovel, Sexo sexo, DateTime dataNascimento, Cidade cidade, string codigoPostal)
        {
            Nome = nome;
            NumTelemovel = numTelemovel;
            Sexo = sexo;
            DataNascimento = dataNascimento;
            Cidade = cidade;
            CodigoPostal = codigoPostal;
        }

        #endregion
        #endregion
    }
}
