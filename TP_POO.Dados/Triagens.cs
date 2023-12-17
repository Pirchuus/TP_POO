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
        /// <summary>
        /// Construtor
        /// </summary>
        public Triagens()
        {
            triagens.Add(new Triagem
            {
                Gravidade = Enums.Gravidade.Grave,
                Sintomas = "Tem dores no braço e na perna. Apresenta-se com tonturas.",
                Prioridade = CalcularPrioridade(Enums.Gravidade.Grave, "Dor perna, braço e tonturas" ),
            });
        }
        #endregion

        #region MÉTODOS
        /// <summary>
        /// Calculates the priority of the patient based on severity and symptoms.
        /// </summary>
        /// <returns>The calculated priority value.</returns>
        private int CalcularPrioridade(Enums.Gravidade gravidade, string sintomas)
        {
            int priority = 0;

            // Assign priority based on severity
            switch (gravidade)
            {
                case Enums.Gravidade.PoucoGrave:
                    priority += 1;
                    break;
                case Enums.Gravidade.Grave:
                    priority += 2;
                    break;
                case Enums.Gravidade.MuitoGrave:
                    priority += 3;
                    break;
            }
            if (sintomas.Contains(""))
            {
                priority += 1;
            }

            return priority;
        }

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
            {
                Console.WriteLine(triagem.ToString());
            }
        }
        #endregion
    }
}
