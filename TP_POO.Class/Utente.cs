using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_POO.Enums;

namespace TP_POO.Class
{
    /// <summary>
    /// Represents a patient in the system.
    /// </summary>
    public class Utente : Pessoa
    {
        //Variable.
        private int numUtente = 1000;

        #region ATRIBUTOS
        /// <summary>
        /// Patient's identification number.
        /// </summary>
        public int NumUtente { get; private set; }
        #endregion

        #region MÉTODOS

        #region CONSTRUTOR
        /// <summary>
        /// Constructor for the patient.
        /// </summary>
        public Utente() => this.NumUtente = numUtente++;
        #endregion

        #region OVERRIDES
        /// <summary>
        /// Override of the ToString() method.
        /// </summary>
        /// <returns></returns>
        public override string ToString() => 
            $"\tUtente n{this.NumUtente}\n\n" +
            $"Nome: {this.Nome}\n" +
            $"Data de Nascimento: {this.DataNascimento} ({2022 - this.DataNascimento.Year} anos)\n" +
            $"Sexo: {this.Sexo}\n " +
            $"Numero de Telemovel: {this.NumTelemovel}\n" +
            $"Cidade: {this.Cidade}\n" +
            $"Codigo Postal: {this.CodigoPostal}\n";
        #endregion
        #endregion
    }
}
