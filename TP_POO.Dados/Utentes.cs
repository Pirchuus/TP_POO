using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_POO.Class;

namespace TP_POO.Dados
{
    public class Utentes
    {
        #region MÉTODOS

        // Variáveis
        List<Utente> utentes = new List<Utente>();

        /// <summary>
        /// Construtor
        /// </summary>
        public Utentes()
        {
            utentes.Add(new Utente { Nome = "Manuel Cristo", NumTelemovel = 789456123, Cidade = Enums.Cidade.Porto });
            utentes.Add(new Utente { Nome = "Francisca Castro", NumTelemovel = 321456789, Cidade = Enums.Cidade.Braga });
        }

        public void Add(Utente novoUtente)
        {
            // adiciona utente
            this.utentes.Add(novoUtente);
        }

        #endregion

    }

}
