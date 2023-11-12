using System;
using TP_POO.Enums;

namespace TP_POO.Class
{
    /// <summary>
    /// Represents an abstract class for a person.
    /// </summary>
    public abstract class Pessoa
    {
        #region ATRIBUTOS

        /// <summary>
        /// Attribute representing the name of the person.
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Attribute representing the mobile phone number of the person.
        /// </summary>
        public int NumTelemovel { get; set; }

        /// <summary>
        /// Attribute representing the gender of the person. This is an enumeration.
        /// </summary>
        public Sexo Sexo { get; set; }

        /// <summary>
        /// Date of birth of the person.
        /// </summary>
        public DateTime DataNascimento { get; set; }

        /// <summary>
        /// City where the person is from.
        /// </summary>
        public Cidade Cidade { get; set; }

        /// <summary>
        /// Postal code of the person.
        /// </summary>
        public string CodigoPostal { get; set; }

        #endregion

        #region MÉTODOS

        /// <summary>
        /// Displays the information of a person.
        /// </summary>
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

        /// <summary>
        /// Initializes a new instance of the <see cref="Pessoa"/> class.
        /// </summary>
        /// <param name="nome">The name of the person.</param>
        /// <param name="numTelemovel">The mobile phone number of the person.</param>
        /// <param name="sexo">The gender of the person.</param>
        /// <param name="dataNascimento">The birthdate of the person.</param>
        /// <param name="cidade">The city of the person.</param>
        /// <param name="codigoPostal">The postal code of the person.</param>
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
