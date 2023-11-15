using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_POO.Enums;
using TP_POO.Class;

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
        ///<summary>
        /// Method that adds a clinical record to the list.
        ///<summary>
        ///<param name="novoRegistoClinico">novo registo clinico</param>
        public void AddRegisto(RegistoClinico novoRegistoClinico)
        {
            this.registoClinicos.Add(novoRegistoClinico);
        }

        /// <summary>
        /// Method that removes a clinical record from the list.
        /// </summary>
        /// <param name="registoClinico"></param>
        public void RemoveRegisto(RegistoClinico registoClinico)
        {
            this.registoClinicos.Remove(registoClinico);
        }

        /// <summary>
        /// Method that updates the information of a clinical record.
        /// </summary>
        /// <param name="registoClinico"></param>
        public void UpdateRegisto(RegistoClinico registoClinico)
        {
            int index = registoClinicos.FindIndex(r => r.NumeroRegisto == registoClinico.NumeroRegisto);
            if (index != -1)
            {
                registoClinicos[index] = registoClinico;
            }
        }
        #endregion
    }
}
