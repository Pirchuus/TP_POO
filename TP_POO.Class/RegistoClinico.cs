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

        /// <summary>
        /// Displays the information of a clinical record.
        /// </summary>
        public void ExibirRegisto()
        {
            Console.WriteLine($"Diagnóstico: {Diagnostico}");
            Console.WriteLine($"Exames: {Exames}");
            Console.WriteLine($"Anotações: {Anotacoes}");
        }

        #region CONTRUTOR

        /// <summary>
        /// Initializes a new instance of the <see cref="RegistoClinico"/> class.
        /// </summary>
        /// <param name="diagnostico">The diagnosis of the patient.</param>
        /// <param name="exames">The examinations in the clinical record.</param>
        /// <param name="anotacoes">The annotations made by the doctor.</param>
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
