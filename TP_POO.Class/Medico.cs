using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_POO.Enums;

namespace TP_POO.Class
{
    /// <summary>
    /// Represents a medical professional.
    /// </summary>
    public class Medico : Pessoa
    {
        /// <summary>
        /// Variable
        /// </summary>
        private int numeroMedico = 3000;

        /// <summary>
        /// Attribute representing the doctor's registration number, i.e., the health professional number in the hospital.
        /// </summary>
        public int NumRegistoMedico { get; private set; }

        #region ATRIBUTOS
        /// <summary>
        /// Attribute representing the specialty to which the doctor belongs, defined as an enumeration.
        /// </summary>
        public Especialidade Especialidade { get; set; }
        #endregion

        #region MÉTODOS

        #region CONSTRUTOR
        /// <summary>
        /// Constructor of the class Medico.
        /// </summary>
        public Medico() => this.NumRegistoMedico = numeroMedico++;
        #endregion
        #endregion
    }
}
