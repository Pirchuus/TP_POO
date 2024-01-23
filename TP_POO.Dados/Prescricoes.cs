/*
* Diogo Pinheiro e Ana Pinto
* LEIM - 2º ano
* TP_POO - 2023/2024
* 
* Classe dados Prescricoes
**/

using TP_POO.Class;
using TP_POO.Exceptions;

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
        /// <returns></returns>
        /// <exception cref="DadoNulosException"></exception>
        /// <exception cref="DadoJaExisteException"></exception>
        public bool AddPrescricao(Prescricao prescricao)
        {
            if (prescricao is null)
                throw new DadoNulosException("Prescricao");

            foreach (var p in prescricoes)
            {
                if (p.IdMedicamento == prescricao.IdMedicamento)
                    throw new DadoJaExisteException("Prescricao");
            }

            prescricoes.Add(prescricao);
            return true;
        }

        /// <summary>
        /// Method that removes a prescription from the list.
        /// </summary>
        /// <param name="idPrescricao"></param>
        /// <returns></returns>
        /// <exception cref="DadoNaoExisteException"></exception>
        public bool RemovePrescricao(int idPrescricao)
        {
            int index = -1;

            for (int i = 0; i < prescricoes.Count; i++)
            {
                if (prescricoes[i].IdMedicamento == idPrescricao)
                {
                    index = i;
                    break;
                }
            }

            if (index == -1)
                throw new DadoNaoExisteException("Prescrição");

            prescricoes.RemoveAt(index);
            return true;
        }

        /// <summary>
        /// Method that updates a prescription.
        /// </summary>
        /// <param name="prescricao"></param>
        /// <returns></returns>
        /// <exception cref="DadoNulosException"></exception>
        /// <exception cref="DadoNaoExisteException"></exception>
        public bool UpdatePrescricao(Prescricao prescricao)
        {
            if (prescricao is null)
                throw new DadoNulosException("Prescricao");

            for (int i = 0; i < prescricoes.Count; i++)
            {
                if (prescricoes[i].IdMedicamento == prescricao.IdMedicamento)
                {
                    prescricoes[i] = prescricao;
                    return true;
                }
            }

            throw new DadoNaoExisteException("Prescricao");
        }

        /// <summary>
        /// Method that gets a prescription by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="DadoNaoExisteException"></exception>
        public Prescricao GetPrescricaoById(int id)
        {
            foreach (var prescricao in prescricoes)
            {
                if (prescricao.IdMedicamento == id)
                    return prescricao;
            }

            throw new DadoNaoExisteException("Prescricao");
        }

        /// <summary>
        /// Method that shows the prescriptions.
        /// </summary>
        public void ShowPrescricoes()
        {
            foreach (Prescricao prescricao in prescricoes)
            {
                Console.WriteLine(prescricao.ToString());
            }
        }
        #endregion
    }
}
