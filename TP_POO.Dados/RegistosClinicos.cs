using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_POO.Class;

namespace TP_POO.Dados
{
    public class RegistosClinicos
    {
        #region MÉTODOS
        /// Variáveis
        List<RegistoClinico> registoClinicos = new List<RegistoClinico>();

        /// <summary>
        /// Construtor
        /// </summary>
        public RegistosClinicos()
        {
            registoClinicos.Add(new RegistoClinico
            {
                Diagnostico = new Diagnostico("Tem um braço partido e uma fratura na perna"),
                Exames = new Exames("Precisa de fazer um raio-x em ambos os membros"),
                Anotacoes = new Anotacoes("É um utente com diabetes.")

            });
        }

        ///<summary>
        /// Adicionar novo registo clínico
        ///<summary>
        ///<param name="novoRegistoClinico">novo registo clinico</param>
        public void Add(RegistoClinico novoRegistoClinico)
        {
            // adiciona o registo clínico
            this.registoClinicos.Add(novoRegistoClinico);
        }

        ///<summary>
        /// Lista Registos Clinicos
        ///<summary>
        ///<param name="registoClinicos">registos clinicos</param>
        public void ListarRegistosClinicos(List<RegistoClinico> registoClinicos)
        {
            foreach (RegistoClinico registoClinico in registoClinicos)
                Console.WriteLine(registoClinico.ToString());
        }

        ///<summary>
        /// Listar todos os registos clínicos
        ///<summary>
        ///<param name="registosClinicos">registos clinicos</param>
        public void ListaRegistosTodos(List<RegistoClinico> registosClinicos) => ListarRegistosClinicos(registosClinicos);

        #endregion


    }
}
