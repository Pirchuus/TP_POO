using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_POO.Enums;
using TP_POO.Class;

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

        ///<summary>
        /// Method that adds a triage to the list.
        ///<summary>
        ///<param name="novoTriagem">nova triagem</param>
        public void AddTriagem(Triagem novaTriagem)
        {
            this.triagens.Add(novaTriagem);
        }

        /// <summary>
        /// Method that removes a triage from the list.
        /// </summary>
        /// <param name="triagem"></param>
        public void RemoveTriagem(Triagem triagem)
        {
            this.triagens.Remove(triagem);
        }

        /// <summary>
        /// Method that updates a triage from the list.
        /// </summary>
        /// <param name="triagem"></param>
        public void UpdateTriagem(Triagem triagem)
        {
            int index = this.triagens.IndexOf(triagem);
            if (index != -1) 
            {
                this.triagens[index] = triagem;
            }
        }
        #endregion
    }
}
