using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_POO.Enums;
using TP_POO.Class;

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
        public void AddMedico(Medico medico) => medicos.Add(medico);

        /// <summary>
        /// Method that removes a doctor from the list.
        /// </summary>
        /// <param name="medico"></param>
        public void RemoveMedico(Medico medico) => medicos.Remove(medico);

        /// <summary>
        /// Method that updates the information of a doctor.
        /// </summary>
        /// <param name="medico"></param>
        public void UpdateMedico(Medico medico)
        {
            int index = medicos.FindIndex(m => m.NumRegistoMedico == medico.NumRegistoMedico);
            if (index != -1)
            {
                medicos[index] = medico;
            }
        }
        #endregion
    }
}