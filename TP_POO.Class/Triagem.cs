/*
* Diogo Pinheiro e Ana Pinto
* LEIM - 2º ano
* TP_POO - 2023/2024
* 
* Classe Triagem
**/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_POO.Enums;
namespace TP_POO.Class
{
    /// <summary>
    /// Represents a triage process for a patient.
    /// </summary>
    public class Triagem
    {
        // Variable.
        private static int idTriagem = 100;

        #region ATRIBUTOS
        /// <summary>
        /// Attribute representing the triage process number.
        /// </summary>
        public int IdTriagem { get; private set; }

        /// <summary>
        /// Severity of the patient's discomfort.
        /// </summary>
        public Gravidade Gravidade { get; set; }

        /// <summary>
        /// Symptoms presented by the patient.
        /// </summary>
        public string Sintomas { get; set; }

        /// <summary>
        /// Priority of the patient based on severity and symptoms.
        /// </summary>
        public int Prioridade { get; set; }

        /// <summary>
        /// Patient who is going through the triage process.
        /// </summary>
        public Utente Utente { get; set; }

        #endregion

        #region MÉTODOS

        #region CONSTRUTOR
        /// <summary>
        /// Constructor for the triage process.
        /// </summary>
        public Triagem() => this.IdTriagem = idTriagem++;
        #endregion

        #region OVERRIDES
        /// <summary>
        /// Overrides the ToString() method.
        /// </summary>
        /// <returns></returns>
        public override string ToString() => 
            $"Gravidade: {this.Gravidade}," +
            $" Sintomas: {this.Sintomas}," +
            $" Prioridade: {this.Prioridade}";
        #endregion
        #endregion
    }
}
