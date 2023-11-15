using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_POO.Enums;

namespace TP_POO.Class
{
    /// <summary>
    /// Represents a clinical record for a patient.
    /// </summary>
    public class RegistoClinico
    {
        // Variable.
        private int numeroRegisto = 500;

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
        /// Attribute representing the examinations in the clinical record.
        /// </summary>
        public string Exames { get; set; }

        /// <summary>
        /// Attribute representing the annotations made by the doctor in the clinical record of a specific patient.
        /// </summary>
        public string Anotacoes { get; set; }

        /// <summary>
        /// Attribute representing the patient of the clinical record.
        /// </summary>
        public Utente Utente { get; set; }

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
            $"Diagnostico: {this.Diagnostico}\n" +
            $"Exames: {this.Exames}\n" +
            $"Anotacoes: {this.Anotacoes}\n";

        #endregion
        #endregion
    }
}
