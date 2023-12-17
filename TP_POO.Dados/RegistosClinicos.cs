using TP_POO.Enums;
using TP_POO.Class;
using TP_POO.Exceptions;

namespace TP_POO.Dados
{
    public class RegistosClinicos
    {
        /// <summary>
        /// List of clinical records.
        /// </summary>
        List<RegistoClinico> registoClinicos = new List<RegistoClinico>();

        #region CONSTRUTOR
        /// <summary>
        /// Constructor of the class RegistosClinicos.
        /// </summary>
        public RegistosClinicos()
        {
            registoClinicos.Add(new RegistoClinico
            {
                Diagnostico = "Tem um braço partido e uma fratura na perna",
                Exames = "Raio-x 2 Membros",
                Anotacoes = "É um utente com diabetes.",
                Utente = new Utente
                {
                    Nome = "Maria Joao",
                    DataNascimento = new DateOnly(1990, 10, 10),
                    Sexo = Sexo.Feminino,
                    NumTelemovel = 912345678,
                    Cidade = Cidade.Porto,
                    CodigoPostal = "4000-007"
                }
            });
        }
        #endregion

        #region METODOS
        /// <summary>
        /// Method that adds a clinical record to the list.
        /// <summary>
        /// <param name="novoRegistoClinico">novo registo clinico</param>
        /// <exception cref="DadoNulosException">Se o registo clinico for nulo</exception>
        /// <exception cref="DadoJaExisteException">Se o registo clinico ja existir</exception>
        public void AddRegisto(RegistoClinico novoRegistoClinico)
        {
            if(novoRegistoClinico is null)
                throw new DadoNulosException("RegistoClinico");

            if(this.registoClinicos.Exists(rc => rc.NumeroRegisto.Equals(novoRegistoClinico.NumeroRegisto)))
                throw new DadoJaExisteException("RegistoClinico");

            this.registoClinicos.Add(novoRegistoClinico);
        }

        /// <summary>
        /// Method that removes a clinical record from the list.
        /// </summary>
        /// <param name="registoClinico"></param>
        /// <exception cref="DadoNulosException">Se o registo clinico for nulo</exception>
        /// <exception cref="DadoNaoExisteException">Se o registo clinico nao existir</exception>
        public void RemoveRegisto(RegistoClinico registoClinico)
        {
            if (registoClinico is null)
                throw new DadoNulosException("RegistoClinico");

            if (!this.registoClinicos.Exists(rc => rc.NumeroRegisto.Equals(registoClinico.NumeroRegisto)))
                throw new DadoNaoExisteException("RegistoClinico");

            int index = this.registoClinicos.FindIndex(rc => rc.NumeroRegisto.Equals(registoClinico.NumeroRegisto));
            registoClinicos.RemoveAt(index);
        }

        /// <summary>
        /// Method that updates the information of a clinical record.
        /// </summary>
        /// <param name="registoClinico"></param>
        /// <exception cref="DadoNulosException">Se o registo clinico for nulo</exception>
        /// <exception cref="DadoNaoExisteException">Se o registo clinico nao existir</exception>
        public void UpdateRegisto(RegistoClinico registoClinico)
        {
            if(registoClinico is null)
                throw new DadoNulosException("RegistoClinico");

            if (!this.registoClinicos.Exists(rc => rc.NumeroRegisto.Equals(registoClinico.NumeroRegisto)))
                throw new DadoNaoExisteException("RegistoClinico");

            int index = registoClinicos.FindIndex(r => r.NumeroRegisto == registoClinico.NumeroRegisto);
            registoClinicos[index] = registoClinico;
        }

        /// <summary>
        /// Method that shows the clinical records.
        /// </summary>
        /// <param name="registoClinicos"></param>
        public void ShowRgistosClinicos(List<RegistoClinico> registoClinicos)
        {
            foreach (RegistoClinico registo in registoClinicos)
            {
                Console.WriteLine(registo.ToString());
            }
        }
        #endregion
    }
}
