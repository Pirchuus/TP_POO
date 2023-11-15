using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_POO.Enums;
using TP_POO.Class;

namespace TP_POO.Dados
{
    public class Utentes
    {
        /// <summary>
        /// List of patients.
        /// </summary>
        List<Utente> utentes = new List<Utente>();

        #region CONSTRUTOR
        /// <summary>
        /// Constructor of the class Utentes.
        /// </summary>
        public Utentes()
        {
            utentes.Add(new Utente { Nome = "Manuel Cristo", NumTelemovel = 789456123, Cidade = Enums.Cidade.Porto });
            utentes.Add(new Utente { Nome = "Francisca Castro", NumTelemovel = 321456789, Cidade = Enums.Cidade.Braga });
        }
        #endregion

        #region MÉTODOS
        /// <summary>
        /// Method that adds a patient to the list.
        /// </summary>
        /// <param name="novoUtente"></param>
        public void AddUtente(Utente novoUtente) => this.utentes.Add(novoUtente);

        /// <summary>
        /// Method that removes a patient from the list.
        /// </summary>
        /// <param name="utente"></param>
        public void RemoveUtente(Utente utente) => this.utentes.Remove(utente);

        /// <summary>
        /// Method that updates the information of a patient.
        /// </summary>
        /// <param name="utente"></param>
        /// <param name="nome"></param>
        /// <param name="numTelemovel"></param>
        /// <param name="cidade"></param>
        public void UpdateUtente(Utente utente)
        {
            int index = utentes.FindIndex(u => u.NumUtente == utente.NumUtente);
            if (index != -1)
            {
                utentes[index] = utente;
            }
        }
        #endregion
    }
}
