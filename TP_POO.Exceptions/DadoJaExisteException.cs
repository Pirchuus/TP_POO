﻿/*
* Diogo Pinheiro e Ana Pinto
* LEIM - 2º ano
* TP_POO - 2023/2024
* 
* Exception para quando se tenta adicionar um dado que ja existe no sistema
**/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO.Exceptions
{
    public class DadoJaExisteException : Exception
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="origem">onde a excecao foi atirada</param>
        public DadoJaExisteException(string origem) => this.Source = origem;

        /// <summary>
        /// Message of the exception.
        /// </summary>
        public override string Message => "O que prentende adicionar ja existe no sistema!";
    }
}
