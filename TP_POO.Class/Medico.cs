using System;
using TP_POO.Enums;

namespace TP_POO.Class
{
    /// <summary>
    /// Represents a medical professional.
    /// </summary>
    public class Medico : Pessoa
    {
        #region ATRIBUTOS

        /// <summary>
        /// Attribute representing the specialty to which the doctor belongs, defined as an enumeration.
        /// </summary>
        public Especialidade especialidade { get; set; }

        /// <summary>
        /// Attribute representing the doctor's registration number, i.e., the health professional number in the hospital.
        /// </summary>
        public int NumRegistoMedico { get; private set; }

        #endregion

        #region MÉTODOS

        /// <summary>
        /// Displays the information of the doctor.
        /// </summary>
        public void ExibirMedico()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Número de Telemóvel: {NumTelemovel}");
            Console.WriteLine($"Sexo: {Sexo}");
            Console.WriteLine($"Data de Nascimento: {DataNascimento}");
            Console.WriteLine($"Cidade: {Cidade}");
            Console.WriteLine($"Codigo Postal: {CodigoPostal}");
            Console.WriteLine($"Especialidade: {especialidade}");
            Console.WriteLine($"Número de Registo Médico: {NumRegistoMedico}");
        }

        #region CONSTRUTOR

        /// <summary>
        /// Initializes a new instance of the <see cref="Medico"/> class.
        /// </summary>
        /// <param name="nome">The name of the doctor.</param>
        /// <param name="numTelemovel">The mobile phone number of the doctor.</param>
        /// <param name="sexo">The gender of the doctor.</param>
        /// <param name="dataNascimento">The birthdate of the doctor.</param>
        /// <param name="cidade">The city of the doctor.</param>
        /// <param name="codigoPostal">The postal code of the doctor.</param>
        /// <param name="especialidade">The specialty of the doctor.</param>
        /// <param name="numRegistoMedico">The registration number of the doctor.</param>
        public Medico(string nome, int numTelemovel, Sexo sexo, DateTime dataNascimento, Cidade cidade, string codigoPostal, Especialidade especialidade, int numRegistoMedico)
            : base(nome, numTelemovel, sexo, dataNascimento, cidade, codigoPostal)
        {
            this.especialidade = especialidade;
            NumRegistoMedico = numRegistoMedico;
        }

        #endregion
        #endregion
    }
}
