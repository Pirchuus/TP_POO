using System;
using TP_POO.Enums;

namespace TP_POO.Class
{
    public class Medico : Pessoa
    {
        #region ATRIBUTOS

        /// <summary>
        /// Atributo sobre a especialidade a que o médico pertence, sendo este um enumerado.
        /// </summary>
        public Especialidade especialidade { get; set; }

        /// <summary>
        /// Atributo referente ao número de registo do médico, ou seja, o número do profissional de saúde do hospital
        /// </summary>
        public int NumRegistoMedico { get; private set; }

        #endregion

        #region MÉTODOS

        // Método para Exibir as informações do médico
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
