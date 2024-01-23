/*
* Diogo Pinheiro e Ana Pinto
* LEIM - 2º ano
* TP_POO - 2023/2024
* 
* Classe dados Medicos
**/

using TP_POO.Enums;
using TP_POO.Class;
using TP_POO.Exceptions;

namespace TP_POO.Dados
{
    public class Medicos
    {
        /// <summary>
        /// List of doctors.
        /// </summary>
        List<Medico> medicos = new List<Medico>();

        #region CONSTRUTOR
        /// <summary>
        /// Constructor of the class Medicos.
        /// </summary>
        public Medicos()
        {
            medicos.Add(new Medico { Nome = "Jose Maria", Especialidade = Especialidade.MedicinaGeral });
            medicos.Add(new Medico { Nome = "Joao Pedro", Especialidade = Especialidade.Cardiologia });
            medicos.Add(new Medico { Nome = "Joana Almeida", Especialidade = Especialidade.Pediatria });
        }
        #endregion

        #region METODOS
        /// <summary>
        /// Method that adds a doctor to the list.
        /// </summary>
        /// <param name="medico"></param>
        /// <returns></returns>
        /// <exception cref="DadoNulosException"></exception>
        /// <exception cref="DadoJaExisteException"></exception>
        public bool AddMedico(Medico medico)
        {
            if (medico is null)
                throw new DadoNulosException("Medico");

            foreach (var d in medicos)
            {
                if (d.NumRegistoMedico.Equals(medico.NumRegistoMedico))
                    throw new DadoJaExisteException("Medico");
            }

            medicos.Add(medico);
            return true;
        }
        
        /// <summary>
        /// Method that removes a doctor from the list.
        /// </summary>
        /// <param name="idMedico"></param>
        /// <returns></returns>
        /// <exception cref="DadoNaoExisteException"></exception>
        public bool RemoveMedico(int idMedico)
        {
            bool found = false;

            for (int i = 0; i < medicos.Count; i++)
            {
                if (medicos[i].NumRegistoMedico.Equals(idMedico))
                {
                    medicos.RemoveAt(i);
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                throw new DadoNaoExisteException("Medicos");
            }

            return true;
        }

        /// <summary>
        /// Method that updates a doctor.
        /// </summary>
        /// <param name="medico"></param>
        /// <returns></returns>
        /// <exception cref="DadoNulosException"></exception>
        /// <exception cref="DadoNaoExisteException"></exception>
        public bool UpdateMedico(Medico medico)
        {
            if (medico is null)
                throw new DadoNulosException("Medico");

            for (int i = 0; i < medicos.Count; i++)
            {
                if (medicos[i].NumRegistoMedico.Equals(medico.NumRegistoMedico))
                {
                    medicos[i] = medico;
                    return true;
                }
            }

            throw new DadoNaoExisteException("Medico");
        }

        /// <summary>
        /// Method that shows the list of doctors.
        /// </summary>
        public void ShowMedicos()
        {
            Console.WriteLine($"Total de médicos: {medicos.Count}");
            if (medicos.Count == 0)
            {
                Console.WriteLine("Nao ha medicos no sistema.");
                return;
            }

            foreach (Medico medico in medicos)
                Console.WriteLine(medico.ToString());
        }
        #endregion
    }
}