/*
* Diogo Pinheiro e Ana Pinto
* LEIM - 2º ano
* TP_POO - 2023/2024
* 
* Exception para quando se tenta adicionar um dado que nao existe no sistema
**/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO.Exceptions
{
    public class DadoNaoExisteException : Exception
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="origem">onde a excecao foi atirada</param>
        public DadoNaoExisteException(string origem) => this.Source = origem;

        /// <summary>
        /// Message of the exception.
        /// </summary>
        public override string Message => "O que pretende realizar é impossível, dado nao existente";

    }
}
