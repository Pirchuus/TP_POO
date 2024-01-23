/*
* Diogo Pinheiro e Ana Pinto
* LEIM - 2º ano
* TP_POO - 2023/2024
* 
* Classe dados Triagens
**/

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

        #region MÉTODOS
        /// <summary>
        /// Method that adds a triage to the list.
        /// </summary>
        /// <param name="novaTriagem"></param>
        /// <returns></returns>
        /// <exception cref="DadoNulosException"></exception>
        /// <exception cref="DadoJaExisteException"></exception>
        public bool AddTriagem(Triagem novaTriagem)
        {
            if (novaTriagem is null)
                throw new DadoNulosException("Triagem");

            foreach (var t in triagens)
            {
                if (t.IdTriagem.Equals(novaTriagem.IdTriagem))
                    throw new DadoJaExisteException("Triagem");
            }

            triagens.Add(novaTriagem);
            return true;
        }
        
        /// <summary>
        /// Method that removes a triage from the list.
        /// </summary>
        /// <param name="numTriagem"></param>
        /// <returns></returns>
        /// <exception cref="DadoNaoExisteException"></exception>
        public bool RemoveTriagem(int numTriagem)
        {
            bool found = false;

            for (int i = 0; i < triagens.Count; i++)
            {
                if (triagens[i].IdTriagem.Equals(numTriagem))
                {
                    triagens.RemoveAt(i);
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                throw new DadoNaoExisteException("Triagens");
            }

            return true;
        }

        /// <summary>
        /// Method that updates a triage.
        /// </summary>
        /// <param name="triagem"></param>
        /// <returns></returns>
        /// <exception cref="DadoNulosException"></exception>
        /// <exception cref="DadoNaoExisteException"></exception>
        public bool UpdateTriagem(Triagem triagem)
        {
            if (triagem is null)
                throw new DadoNulosException("Triagem");

            for (int i = 0; i < triagens.Count; i++)
            {
                if (triagens[i].IdTriagem.Equals(triagem.IdTriagem))
                {
                    triagens[i] = triagem;
                    return true;
                }
            }

            throw new DadoNaoExisteException("Triagem");
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
