using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_POO.Class;

namespace TP_POO.Dados
{
    public class ListaEspera
    {
        // variables
        public List<Triagem> waitingList = new List<Triagem>();

        /// <summary>
        /// Add a triagem to the waiting list
        /// </summary>
        /// <param name="triagem"></param>
        public void AddToWaitingList(Triagem triagem)
        {
            // Find the insert position based on severity
            int insertIndex = waitingList.FindIndex(t => t.Gravidade < triagem.Gravidade);

            if (insertIndex == -1)
            {
                // If no more severe case is found, add to the end of the list
                waitingList.Add(triagem);
            }
            else
            {
                // Insert the triagem before the first less severe case
                waitingList.Insert(insertIndex, triagem);
            }
        }

        /// <summary>
        /// Show the waiting list
        /// </summary>
        public void ShowWaitingList()
        {
            foreach (var t in waitingList)
                Console.WriteLine($"{t.Utente.Nome} - Severity: {t.Gravidade}");
        }

        /// <summary>
        /// Get the next patient from the waiting list
        /// </summary>
        /// <returns></returns>
        public Triagem GetNextPatient()
        {
            var nextPatient = waitingList.First();
            waitingList.RemoveAt(0); // Remove the patient from the waiting list
            return nextPatient;
        }
    }
}