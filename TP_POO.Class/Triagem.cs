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

        #region OVERRIDES

        /// <summary>
        /// Override do Método ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"\tGravidade: {this.gravidade}\n" +
            $"Sintomas: {this.Sintomas}\n" +
            $"Prioridade: {this.Prioridade}";

        #endregion

        #endregion



    }
}
