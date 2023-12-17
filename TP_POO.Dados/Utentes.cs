using TP_POO.Class;
using TP_POO.Enums;
using TP_POO.Exceptions;

namespace TP_POO.Dados
{
    public class Utentes
    {
        /// <summary>
        /// List of patients.
        /// </summary>
        List<Utente> utentes = new List<Utente>();

        #region CONSTRUTOR
        /// <summary>
        /// Constructor of the class Utentes.
        /// </summary>
        public Utentes()
        {
            utentes.Add(new Utente { Nome = "Manuel Cristo", NumTelemovel = 789456123, Cidade = Enums.Cidade.Porto, 
                DataNascimento = new DateOnly(1990, 10, 10), Sexo = Sexo.Masculino, CodigoPostal = "4100-007" });

            utentes.Add(new Utente { Nome = "Francisca Castro", NumTelemovel = 321456789, Cidade = Enums.Cidade.Braga,
                DataNascimento = new DateOnly(2007, 12, 04), Sexo = Sexo.Feminino, CodigoPostal = "4200-008" });
            
            utentes.Add(new Utente {Nome = "Joao Reis", NumTelemovel = 963214578, Cidade = Enums.Cidade.Guimaraes, 
                DataNascimento = new DateOnly(1997, 08, 19), Sexo = Sexo.Masculino, CodigoPostal = "4300-009" });
            
            utentes.Add(new Utente {Nome = "Joana Filipa", NumTelemovel = 925458705, Cidade = Enums.Cidade.Barcelos, 
                DataNascimento = new DateOnly(2000, 04, 14), Sexo = Sexo.Feminino, CodigoPostal = "4400-010" });
        }
        #endregion

        #region MÉTODOS
        /// <summary>
        /// Method that adds a patient to the list.
        /// </summary>
        /// <param name="novoUtente"></param>
        /// <exception cref="DadoNulosException">novo Utente nulo</exception>
        /// <exception cref="DadoJaExisteException">o utente a adicionar ja existe</exception>
        public void AddUtente(Utente novoUtente)
        {
            if (novoUtente is null)
                throw new DadoNulosException("Utente");

            if (this.utentes.Exists(u => u.NumUtente.Equals(novoUtente.NumUtente)))
                throw new DadoJaExisteException("Utente");

            this.utentes.Add(novoUtente);
        }

        /// <summary>
        /// Method that removes a patient from the list.
        /// </summary>
        /// <param name="utente"></param>
        /// <exception cref="DadoNulosException">utente nulo</exception>
        /// <exception cref="DadoNaoExisteException">utente a eliminar nao exite</exception>
        public void RemoveUtente(Utente utente)
        {
            if (utente is null)
                throw new DadoNulosException("Utente");

            if (!this.utentes.Exists(u => u.NumUtente.Equals(utente.NumUtente)))
                throw new DadoNaoExisteException("Utente");

            int index = this.utentes.FindIndex(u => u.NumUtente.Equals(utente.NumUtente));
            
            utentes.RemoveAt(index);
        }

        /// <summary>
        /// Method that updates the information of a patient.
        /// </summary>
        /// <param name="utente"></param>
        /// <exception cref="DadoNulosException">utente nulo</exception>
        /// <exception cref="DadoNaoExisteException">utente a atualizar nao existe</exception>
        public void UpdateUtente(Utente utente)
        {
            if(utente is null)
                throw new DadoNulosException("Utente");

            if (!this.utentes.Exists(u => u.NumUtente.Equals(utente.NumUtente)))
                throw new DadoNaoExisteException("Utente");

            int index = utentes.FindIndex(u => u.NumUtente == utente.NumUtente);
            utentes[index] = utente;
        }

        /// <summary>
        /// Method that shows the list of patients.
        /// </summary>
        public void ShowUtentes()
        {
            Console.WriteLine($"Total de utentes: {utentes.Count}");
            if (utentes.Count == 0)
            {
                Console.WriteLine("Nao ha utentes no sistema.");
                return;
            }

            foreach (Utente utente in utentes)
                Console.WriteLine(utente.ToString());
        }

        /// <summary>
        /// Method that returns a patient by its ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Utente GetUtenteById(int id)
        {
            return utentes.FirstOrDefault(u => u.NumUtente == id);
        }
        #endregion
    }
}
