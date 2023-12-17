using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_POO.Enums;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TP_POO.Class
{
    /// <summary>
    /// Represents a clinical record for a patient.
    /// </summary>
    public class RegistoClinico
    {
        // Variable.
        private static int numeroRegisto = 500;

        #region ATRIBUTOS
        /// <summary>
        /// Attribute representing the clinical record number.
        /// </summary>
        public int NumeroRegisto { get; private set; }

        /// <summary>
        /// Attribute representing the diagnosis of the patient recorded in the clinical record.
        /// </summary>
        public string Diagnostico { get; set; }

        /// <summary>
        /// Attribute representing the patient of the clinical record.
        /// </summary>
        public Utente Utente { get; set; }

        /// <summary>
        /// Attribute representing the date of the clinical record.
        /// </summary>
        public DateTime Data { get; set; }

        /// <summary>
        /// Attribute representing the prescriptions made by the doctor for the patient.
        /// </summary>
        public Prescricao Prescricao { get; set; }

        /// <summary>
        /// Attribute representing the instructions for the prescription.
        /// </summary>
        public string Instrucoes { get; set; }


        /// <summary>
        /// Attribute representing the dosage for the prescription.
        /// </summary>
        public string Dosagem { get; set; }

        /// <summary>
        /// Attribute representing the symptoms of the patient.
        /// </summary>
        public string Sintomas { get; set; }

        #endregion

        #region MÉTODOS

        #region CONSTRUTOR
        /// <summary>
        /// Constructor for the clinical record.
        /// </summary>
        public RegistoClinico() => this.NumeroRegisto = numeroRegisto++;
        #endregion

        #region OVERRIDES
        /// <summary>
        /// Override of the ToString() method.
        /// </summary>
        /// <returns></returns>
        public override string ToString() =>
            $"Registo: {NumeroRegisto}, " +
            $"Utente: {Utente.Nome}, " +
            $"Data: {Data.ToShortDateString()}, " +
            $"Diagnostico: {Diagnostico}, ";
    }

    #endregion
    #endregion
}