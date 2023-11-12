using System;

namespace TP_POO.Class
{
    /// <summary>
    /// Represents a prescription made by a doctor for a patient.
    /// </summary>
    public class Prescricao
    {
        #region ATRIBUTOS

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

        /// <summary>
        /// Displays the information of the prescription.
        /// </summary>
        public void ExibirPrescricao()
        {
            Console.WriteLine($"Medicamento: {Medicamento}");
            Console.WriteLine($"Dosagem: {Dosagem}");
            Console.WriteLine($"Instruções: {Instrucoes}");
        }

        #region CONSTRUTOR

        /// <summary>
        /// Initializes a new instance of the <see cref="Prescricao"/> class.
        /// </summary>
        /// <param name="medicamento">The medication in the prescription.</param>
        /// <param name="dosagem">The dosage prescribed.</param>
        /// <param name="instrucoes">Instructions for taking the medication.</param>
        public Prescricao(string medicamento, double dosagem, string instrucoes)
        {
            Medicamento = medicamento;
            Dosagem = dosagem;
            Instrucoes = instrucoes;
        }

        #endregion
        #endregion
    }
}
