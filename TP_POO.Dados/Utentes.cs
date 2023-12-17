using TP_POO.Class;
using TP_POO.Exceptions;

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
        /// <exception cref="DadoNulosException">novo Utente nulo</exception>
        /// <exception cref="DadoJaExisteException">o utente a adicionar ja existe</exception>
        public void AddUtente(Utente novoUtente)
        {
            if (novoUtente is null)
                throw new DadoNulosException("Utente");

            if (this.utentes.Exists(u => u.NumUtente.Equals(novoUtente.NumUtente)))
                throw new DadoJaExisteException("Utente");

            this.utentes.Add(novoUtente);
        }

        /// <summary>
        /// Method that removes a patient from the list.
        /// </summary>
        /// <param name="utente"></param>
        /// <exception cref="DadoNulosException">utente nulo</exception>
        /// <exception cref="DadoNaoExisteException">utente a eliminar nao exite</exception>
        public void RemoveUtente(Utente utente)
        {
            if (utente is null)
                throw new DadoNulosException("Utente");

            if (!this.utentes.Exists(u => u.NumUtente.Equals(utente.NumUtente)))
                throw new DadoNaoExisteException("Utente");

            int index = this.utentes.FindIndex(u => u.NumUtente.Equals(utente.NumUtente));
            
            utentes.RemoveAt(index);
        }

        /// <summary>
        /// Method that updates the information of a patient.
        /// </summary>
        /// <param name="utente"></param>
        /// <exception cref="DadoNulosException">utente nulo</exception>
        /// <exception cref="DadoNaoExisteException">utente a atualizar nao existe</exception>
        public void UpdateUtente(Utente utente)
        {
            if(utente is null)
                throw new DadoNulosException("Utente");

            if (!this.utentes.Exists(u => u.NumUtente.Equals(utente.NumUtente)))
                throw new DadoNaoExisteException("Utente");

            int index = utentes.FindIndex(u => u.NumUtente == utente.NumUtente);
            utentes[index] = utente;
        }

        /// <summary>
        /// Method that shows the list of patients.
        /// </summary>
        public void ShowUtentes(List<Utente> utentes)
        {
            foreach (Utente utente in utentes)
                Console.WriteLine(utente);
        }
        #endregion
    }
}
