using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO.Exceptions
{
    public class ErrorOpenFileException : Exception
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="origem">onde a excecao foi atirada</param>
        public ErrorOpenFileException(string origem) => this.Source = origem;

        /// <summary>
        /// Message of the exception.
        /// </summary>
        public override string Message => "Erro na leitura do ficheiro";
    }
}
