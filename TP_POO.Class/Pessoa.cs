/*
* Diogo Pinheiro e Ana Pinto
* LEIM - 2º ano
* TP_POO - 2023/2024
* 
* Classe Pessoa
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
    /// Represents an abstract class for a person.
    /// </summary>
    public abstract class Pessoa
    {
        #region ATRIBUTOS
        /// <summary>
        /// Attribute representing the name of the person.
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Attribute representing the mobile phone number of the person.
        /// </summary>
        public int NumTelemovel { get; set; }

        /// <summary>
        /// Attribute representing the gender of the person. This is an enumeration.
        /// </summary>
        public Sexo Sexo { get; set; }

        /// <summary>
        /// Date of birth of the person.
        /// </summary>
        public DateOnly DataNascimento { get; set; }

        /// <summary>
        /// City where the person is from.
        /// </summary>
        public Cidade Cidade { get; set; }

        /// <summary>
        /// Postal code of the person.
        /// </summary>
        public string CodigoPostal { get; set; }
        #endregion
    }
}
