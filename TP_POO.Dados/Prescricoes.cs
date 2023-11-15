using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_POO.Enums;
using TP_POO.Class;

namespace TP_POO.Dados
{
    public class Prescricoes
    {
        /// <summary>
        /// Lista of prescriptions.
        /// </summary>
        List<Prescricao> prescricoes = new List<Prescricao>();

        #region CONSTRUTOR
        /// <summary>
        /// Constructor of the class Prescricoes.
        /// </summary>
        public Prescricoes()
        {
            prescricoes.Add(new Prescricao() { Medicamento = "Paracetamol", Dosagem = 500, Instrucoes = "Tomar 1 comprimido de 8 em 8 horas." });
            prescricoes.Add(new Prescricao() { Medicamento = "Ibuprofeno", Dosagem = 400, Instrucoes = "Tomar 1 comprimido de 8 em 8 horas." });
            prescricoes.Add(new Prescricao() { Medicamento = "Aspirina", Dosagem = 500, Instrucoes = "Tomar 1 comprimido de 8 em 8 horas." });
        }
        #endregion

        #region METODOS
        /// <summary>
        /// Method that adds a prescription to the list.
        /// </summary>
        /// <param name="prescricao"></param>
        public void AddPrescricao(Prescricao prescricao) => prescricoes.Add(prescricao);

        /// <summary>
        /// Method that removes a prescription from the list.
        /// </summary>
        /// <param name="prescricao"></param>
        public void RemovePrescricao(Prescricao prescricao) => prescricoes.Remove(prescricao);

        /// <summary>
        /// Method that updates the information of a prescription.
        /// </summary>
        /// <param name="prescricao"></param>
        public void UpdatePrescricao(Prescricao prescricao)
        {
            int index = prescricoes.FindIndex(p => p.IdMedicamento == prescricao.IdMedicamento);
            if (index != -1)
            {
                prescricoes[index] = prescricao;
            }
        }
        #endregion
    }
}
