using System;
using TP_POO.Enums;
using SexoEnum = TP_POO.Enums.Sexo;
using CidadeEnum = TP_POO.Enums.Cidade;

namespace TP_POO.Class
{
    /// <summary>
    /// Represents a patient in the system.
    /// </summary>
    public class Utente : Pessoa
    {
        #region ATRIBUTOS

        /// <summary>
        /// Patient's identification number.
        /// </summary>
        public int NumUtente { get; private set; }

        #endregion

        #region MÉTODOS

        #region OVERRIDES

        /// <summary>
        /// Override do Método ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"\tUtente n{this.NumUtente}\n\n" +
            $"Nome: {this.Nome}\nData de Nascimento: {this.DataNascimento}\n" +
            $"Sexo: {this.Sexo}\n" +
            $"Numero de Telemovel: {this.NumTelemovel}\n" +
            $"Cidade: {this.Cidade}\n" +
            $"Codigo Postal: {this.CodigoPostal}\n";

        #endregion

        #endregion

    }
}
