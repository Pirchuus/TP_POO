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
        /// Atributo do n�mero de telemovel da pessoa
        /// </summary>
        public int NumTelemovel { get; set; }

        /// <summary>
        /// Atributo sobre o g�nero da pessoa. Este � um enumerado.
        /// </summary>
        public Sexo Sexo { get; set; }

        /// <summary>
        /// Data de Nascimento da Pessoa
        /// </summary>
        public DateTime DataNascimento { get; set; }

        /// <summary>
        /// Cidade de onde a pessoa �
        /// </summary>
        public Cidade Cidade { get; set; }

        /// <summary>
        /// C�digo Postal da pessoa
        /// </summary>
        public string CodigoPostal { get; set; }

        #endregion

        #region M�TODOS

        // M�todo para exibir as informa��es de uma pessoa, que neste projeto,
        // estas informa��es ir�o utilizadas nas classes referentes ao m�dico e utente
        public void ExibirPessoa()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"N�mero de Telem�vel: {NumTelemovel}");
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
