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
        /// <exception cref="DadoNulosException">Se o medico for nulo</exception>
        /// <exception cref="DadoJaExisteException">Se o medcio ja existir</exception>
        public void AddMedico(Medico medico)
        {
            if (medico is null)
                throw new DadoNulosException("Medico");

            if (this.medicos.Exists(d => d.NumRegistoMedico.Equals(medico.NumRegistoMedico)))
                throw new DadoJaExisteException("Medico");

            this.medicos.Add(medico);
        }

        /// <summary>
        /// Method that removes a doctor from the list.
        /// </summary>
        /// <param name="medico"></param>
        /// <exception cref="DadoNulosException">Se o medico for nulo</exception>
        /// <exception cref="DadoNaoExisteException">Se o medico a eliminar nao existe</exception>
        public void RemoveMedico(Medico medico)
        {
            if (medico is null)
                throw new DadoNulosException("Medico");

            if (!this.medicos.Exists(d => d.NumRegistoMedico.Equals(medico.NumRegistoMedico)))
                throw new DadoNaoExisteException("Medico");

            int index = medicos.FindIndex(d => d.NumRegistoMedico.Equals(medico.NumRegistoMedico));
            medicos.RemoveAt(index);
        }

        /// <summary>
        /// Method that updates the information of a doctor.
        /// </summary>
        /// <param name="medico"></param>
        /// <exception cref="DadoNulosException">Se o medico for nulo</exception>
        /// <exception cref="DadoNaoExisteException">Se o medico a atualizar nao existir</exception>
        public void UpdateMedico(Medico medico)
        {
            if(medico is null)
                throw new DadoNulosException("Medico");

            if (!this.medicos.Exists(d => d.NumRegistoMedico.Equals(medico.NumRegistoMedico)))
                throw new DadoNaoExisteException("Medico");

            int index = medicos.FindIndex(m => m.NumRegistoMedico == medico.NumRegistoMedico);

            medicos[index] = medico;
        }

        /// <summary>
        /// Method that shows the list of doctors.
        /// </summary>
        /// <param name="medicos"></param>
        public void ShowMedicos(List<Medico> medicos)
        {
            foreach (Medico medico in medicos)
                Console.WriteLine(medicos.ToString());
        }
        #endregion
    }
}