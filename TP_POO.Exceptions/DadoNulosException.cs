using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO.Exceptions
{
    public class DadoNulosException : Exception
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="origem">onde a excecao foi atirada</param>
        public DadoNulosException(string origem) => this.Source = origem;


        /// <summary>
        /// Message of the exception.
        /// </summary>
        public override string Message => "Os dados não podem ser nulos para efetuar esta operacao";
    }
}
