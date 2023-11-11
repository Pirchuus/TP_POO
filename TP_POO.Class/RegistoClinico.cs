using System;

namespace TP_POO.Class
{
    public class RegistoClinico
    {
        #region ATRIBUTOS
        /// <summary>
        /// Atributo do diagn�stico do paciente registado no registo cl�nico
        /// </summary>
        public string Diagnostico { get; set; }

        /// <summary>
        /// Atributo dos Exames que est�o no registo cl�nico
        /// </summary>
        public string Exames { get; set; }

        /// <summary>
        /// Atributo das anota��es feitas pelo m�dico no registo cl�nnico de um determinado paciente
        /// </summary>
        public string Anotacoes { get; set; }

        #endregion

        #region M�TODOS
        public void ExibirRegisto()
        {
            Console.WriteLine($"Diagn�stico: {Diagnostico}");
            Console.WriteLine($"Exames: {Exames}");
            Console.WriteLine($"Anota��es: {Anotacoes}");
        }

        #region CONTRUTOR
        public RegistoClinico(string diagnostico, string exames, string anotacoes)
        {
            Diagnostico = diagnostico;
            Exames = exames;
            Anotacoes = anotacoes;
        }

        #endregion
        #endregion
    }
}
