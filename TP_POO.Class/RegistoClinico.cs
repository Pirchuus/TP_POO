using System;

namespace TP_POO.Class
{
    /// <summary>
    /// Represents a clinical record for a patient.
    /// </summary>
    public class RegistoClinico
    {
        #region ATRIBUTOS
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

        #endregion

        #region MÉTODOS

        #region OVERRIDES

        /// <summary>
        /// Override do Método ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"Diagnostico: {this.Diagnostico}\n" +
            $"Exames: {this.Exames}\n" +
            $"Anotacoes: {this.Anotacoes}\n";

        #endregion

        #endregion

    }
}
