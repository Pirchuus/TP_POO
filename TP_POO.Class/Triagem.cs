using System;
using TP_POO.Enums;

namespace TP_POO.Class
{
    /// <summary>
    /// Represents a triage process for a patient.
    /// </summary>
    public class Triagem
    {
        #region ATRIBUTOS
        /// <summary>
        /// Severity of the patient's discomfort.
        /// </summary>
        public Gravidade gravidade { get; set; }

        /// <summary>
        /// Symptoms presented by the patient.
        /// </summary>
        public string Sintomas { get; set; }

        /// <summary>
        /// Priority of the patient based on severity and symptoms.
        /// </summary>
        public int Prioridade { get; set; }

        #endregion

        #region MÉTODOS

        /// <summary>
        /// Calculates the priority of the patient based on severity and symptoms.
        /// </summary>
        /// <returns>The calculated priority value.</returns>
        private int CalcularPrioridade()
        {
            int gravidadeValor = (int)gravidade;

            string[] sintomasArray = Sintomas.Split(',');
            int numeroSintomas = sintomasArray.Length;

            int prioridade = gravidadeValor + numeroSintomas;

            return prioridade;
        }

        /// <summary>
        /// Displays the information of a triage process.
        /// </summary>
        public void ExibirTriagem()
        {
            Console.WriteLine($"Gravidade: {gravidade}");
            Console.WriteLine($"Sintomas: {Sintomas}");
            Console.WriteLine($"Prioridade: {Prioridade}");
        }

        #region CONSTRUTOR

        /// <summary>
        /// Initializes a new instance of the <see cref="Triagem"/> class.
        /// </summary>
        /// <param name="gravidade">Severity of the patient's discomfort.</param>
        /// <param name="sintomas">Symptoms presented by the patient.</param>
        public Triagem(Gravidade gravidade, string sintomas)
        {
            this.gravidade = gravidade;
            Sintomas = sintomas;

            Prioridade = CalcularPrioridade();
        }

        #endregion
        #endregion
    }
}
