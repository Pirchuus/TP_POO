using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_POO.Enums;

namespace TP_POO.Class
{
    /// <summary>
    /// Represents a prescription made by a doctor for a patient.
    /// </summary>
    public class Prescricao
    {
        // Variable
        private static int idMedicamento = 100;

        #region ATRIBUTOS
        /// <summary>
        /// Prescription ID.
        /// </summary>
        public int IdMedicamento { get; private set; }

        /// <summary>
        /// Medication included in the prescription made by the doctor for the patient.
        /// </summary>
        public string Medicamento { get; set; }

        /// <summary>
        /// Dosage prescribed for the patient for the medication(s).
        /// </summary>
        public double Dosagem { get; set; }

        /// <summary>
        /// Correct instructions for the patient to take the medication properly.
        /// </summary>
        public string Instrucoes { get; set; }
        #endregion

        #region MÉTODOS
        
        #region CONSTRUTOR
        /// <summary>
        /// Constructor for the prescription.
        /// </summary>
        public Prescricao() => this.IdMedicamento = idMedicamento++;
        #endregion

        #region OVERRIDES
        /// <summary>
        /// Override of the ToString() method.
        /// </summary>
        /// <returns></returns>
        public override string ToString() => 
            $"ID: {IdMedicamento}," +
            $" Medicamento: {Medicamento}," +
            $" Dosagem: {Dosagem}," +
            $" Instruções: {Instrucoes}";
        #endregion
        #endregion
    }
}
