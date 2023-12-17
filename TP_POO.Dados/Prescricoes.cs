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
        /// <exception cref="DadoNulosException">prescricao nula</exception>
        /// <exception cref="DadoJaExisteException">prescricao a adicionar ja existe</exception>
        public void AddPrescricao(Prescricao prescricao)
        {
            if(prescricao is null)
                throw new DadoNulosException("Prescricao");

            if(this.prescricoes.Exists(p => p.IdMedicamento.Equals(prescricao.IdMedicamento)))
                throw new DadoJaExisteException("Prescricao");

            this.prescricoes.Add(prescricao);
        }

        /// <summary>
        /// Method that removes a prescription from the list.
        /// </summary>
        /// <param name="prescricao"></param>
        /// <exception cref="DadoNulosException">prescricao nula</exception>
        /// <exception cref="DadoNaoExisteException">prescricao a eliminar nao existe</exception>
        public void RemovePrescricao(Prescricao prescricao)
        {
            if (prescricao is null)
                throw new DadoNulosException("Prescricao");

            if (!this.prescricoes.Exists(p => p.IdMedicamento.Equals(prescricao.IdMedicamento)))
                throw new DadoNaoExisteException("Prescricao");

            int index = prescricoes.FindIndex(p => p.IdMedicamento == prescricao.IdMedicamento);
            prescricoes.RemoveAt(index);
        }

        /// <summary>
        /// Method that updates the information of a prescription.
        /// </summary>
        /// <param name="prescricao"></param>
        /// <exception cref="DadoNulosException">prescricao nula</exception>
        /// <exception cref="DadoNaoExisteException">prescricao a atualizar nao existe</exception>
        public void UpdatePrescricao(Prescricao prescricao)
        {
            if (prescricao is null)
                throw new DadoNulosException("Prescricao");

            if (!this.prescricoes.Exists(p => p.IdMedicamento.Equals(prescricao.IdMedicamento)))
                throw new DadoNaoExisteException("Prescricao");

            int index = prescricoes.FindIndex(p => p.IdMedicamento == prescricao.IdMedicamento);
            prescricoes[index] = prescricao;
        }


        /// <summary>
        /// Method to get a prescription by its ID.
        /// </summary>
        /// <param name="id">The ID of the prescription.</param>
        /// <returns>The prescription with the specified ID.</returns>
        /// <exception cref="DadoNaoExisteException">Thrown when the prescription is not found.</exception>
        public Prescricao GetPrescricaoById(int id)
        {
            var prescricao = prescricoes.FirstOrDefault(p => p.IdMedicamento == id);

            if (prescricao == null)
                throw new DadoNaoExisteException("Prescription with the given ID does not exist.");

            return prescricao;
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
