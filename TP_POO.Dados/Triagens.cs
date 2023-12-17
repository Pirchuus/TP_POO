using TP_POO.Class;
using TP_POO.Exceptions;

namespace TP_POO.Dados
{
    public class Triagens
    {
        /// <summary>
        /// List of triages.
        /// </summary>
        List<Triagem> triagens = new List<Triagem>();

        #region CONSTRUTOR
        #endregion

        #region MÉTODOS

        /// <summary>
        /// Method that adds a triage to the list.
        /// <summary>
        /// <param name="novoTriagem">nova triagem</param>
        /// <exception cref="DadoNulosException">Se a nova triagem for nula</exception>
        /// <exception cref="DadoJaExisteException">Se a nova triagem ja existir</exception>
        public void AddTriagem(Triagem novaTriagem)
        {
            if (novaTriagem is null)
                throw new DadoNulosException("Triagem");

            if (this.triagens.Contains(novaTriagem))
                throw new DadoJaExisteException("Triagem");

            this.triagens.Add(novaTriagem);
        }

        /// <summary>
        /// Method that removes a triage from the list.
        /// </summary>
        /// <param name="triagem"></param>
        /// <exception cref="DadoNulosException">Se a triagem for nula</exception>
        /// <exception cref="DadoNaoExisteException">Se a triagem nao existir</exception>
        public void RemoveTriagem(Triagem triagem)
        {
            if (triagem is null)
                throw new DadoNulosException("Triagem");

            if (!this.triagens.Exists(t => t.IdTriagem.Equals(triagem.IdTriagem)))
                throw new DadoNaoExisteException("Triagem");
            
            int index = this.triagens.FindIndex(t => t.IdTriagem.Equals(triagem.IdTriagem));
            triagens.RemoveAt(index);
        }

        /// <summary>
        /// Method that updates a triage from the list.
        /// </summary>
        /// <param name="triagem"></param>
        /// <exception cref="DadoNulosException">Se a triagem for nula</exception>
        /// <exception cref="DadoNaoExisteException">Se a triagem nao existir</exception>
        public void UpdateTriagem(Triagem triagem)
        {
            if (triagem is null)
                throw new DadoNulosException("Triagem");

            if (!this.triagens.Exists(t => t.IdTriagem.Equals(triagem.IdTriagem)))
                throw new DadoNaoExisteException("Triagem");

            int index = triagens.FindIndex(t => t.IdTriagem.Equals(triagem.IdTriagem));
            triagens[index] = triagem;
        }

        /// <summary>
        /// Method that shows all triages.
        /// </summary>
        public void ShowTriagens()
        {
            foreach (Triagem triagem in triagens)
                Console.WriteLine(triagem.ToString());
        }
        #endregion
    }
}
