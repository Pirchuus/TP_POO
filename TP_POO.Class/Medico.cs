using System;
using TP_POO.Enums;

namespace TP_POO.Class
{
    public class Medico : Pessoa
    {
        #region ATRIBUTOS

        /// <summary>
        /// Atributo sobre a especialidade a que o m�dico pertence, sendo este um enumerado.
        /// </summary>
        public Especialidade especialidade { get; set; }

        /// <summary>
        /// Atributo referente ao n�mero de registo do m�dico, ou seja, o n�mero do profissional de sa�de do hospital
        /// </summary>
        public int NumRegistoMedico { get; private set; }

        #endregion

        #region M�TODOS

        // M�todo para Exibir as informa��es do m�dico
        public void ExibirMedico()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"N�mero de Telem�vel: {NumTelemovel}");
            Console.WriteLine($"Sexo: {Sexo}");
            Console.WriteLine($"Data de Nascimento: {DataNascimento}");
            Console.WriteLine($"Cidade: {Cidade}");
            Console.WriteLine($"Codigo Postal: {CodigoPostal}");
            Console.WriteLine($"Especialidade: {especialidade}");
            Console.WriteLine($"N�mero de Registo M�dico: {NumRegistoMedico}");
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
