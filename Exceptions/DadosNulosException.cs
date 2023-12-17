using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO.Exceptions
{
    public class DadosNulosException : Exception
    {
        /// <summary>
        /// construtor
        /// </summary>
        /// <param name="origem">onde a excecao foi atirada</param>
        public DadosNulosException(string origem) => this.Source = origem;


        /// <summary>
        /// mensagem da excecao
        /// </summary>
        public override string Message => "O que prentende adicionar ja existe no sistema!";
    }
}
