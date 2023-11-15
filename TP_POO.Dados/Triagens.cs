using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_POO.Class;

namespace TP_POO.Dados
{
    public class Triagens
    {

        #region MÉTODOS

        //Variáveis
        List<Triagem> triagens = new List<Triagem>();

        /// <summary>
        /// Construtor
        /// </summary>
        public Triagens()
        {
            triagens.Add(new Triagem
            {
                gravidade = Enums.Gravidade.MuitoGrave,
                Sintomas = new Sintomas("Tem dores no braço e na perna. Apresenta-se com tonturas."),
                Prioridade = CalcularPrioridade(),
            });
        }

        /// <summary>
        /// Calculates the priority of the patient based on severity and symptoms.
        /// </summary>
        /// <returns>The calculated priority value.</returns>
        private int CalcularPrioridade()
        {
            int gravidadeValor = (int)gravidade;

            string[] sintomasArray = Sintomas.Split(',');
            int numeroSintomas = sintomasArray.Length;

            int prioridade = gravidadeValor + numeroSintomas;

            return prioridade;
        }

        ///<summary>
        /// Adicionar nova triagem
        ///<summary>
        ///<param name="novoTriagem">nova triagem</param>
        public void Add(Triagem novaTriagem)
        {
            this.triagems.Add(novaTriagem);
        }

        ///<summary>
        /// Lista Triagens
        ///<summary>
        ///<param name="triagems">triagens</param>
        public void ListarTriagens(List<Triagem> triagems)
        {
            foreach (Triagem triagem in triagems)
                Console.WriteLine(triagems.ToString());
        }

        ///<summary>
        /// Listar todas as triagens
        ///<summary>
        ///<param name="triagens">triagens</param>
        public void ListarTriagensTodas(List<Triagem> triagens) => ListarTriagens(triagens);

        #endregion

    }
}
