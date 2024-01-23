/*
* Diogo Pinheiro e Ana Pinto
* LEIM - 2º ano
* TP_POO - 2023/2024
* 
* Classe dados Lista de Espera
**/

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
        /// Add a patient to the waiting list
        /// </summary>
        /// <param name="triagem"></param>
        /// <returns></returns>
        public bool AddToWaitingList(Triagem triagem)
        {
            int insertIndex = -1;

            // Iterate through the waiting list to find the correct insert position
            for (int i = 0; i < waitingList.Count; i++)
            {
                if (waitingList[i].Gravidade < triagem.Gravidade)
                {
                    insertIndex = i;
                    break;
                }
            }

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

            return true;
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