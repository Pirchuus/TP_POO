using System;
using System.Collections.Generic;

namespace TP_POO.Class
{
    /// <summary>
    /// Represents a list of patients in a waiting list.
    /// </summary>
    public class Lista
    {
        #region ATRIBUTOS
        /// <summary>
        /// List of patients, i.e., waiting list of patients.
        /// </summary>
        public List<Utente> UtentesEspera { get; set; }
        #endregion

        #region MÉTODOS
        /// <summary>
        /// Displays the list of patients.
        /// </summary>
        /// <param name="utentes">The list of patients to display.</param>
        public void MostrarUtentes(List<Utente> utentes)
        {
            Console.Clear();
            Console.WriteLine("**************** Lista de Utentes ****************");

            if (utentes.Count == 0)
            {
                Console.WriteLine($"Nenhum Utente registado.");
            }
            else
            {
                Console.WriteLine($"Lista de Utentes:");
                int index = 1;
                foreach (var utente in utentes)
                {
                    Console.WriteLine($"Utente {index}:");
                    Console.WriteLine($"Nome: {utente.Nome}");
                    Console.WriteLine($"Número de Telemóvel: {utente.NumTelemovel}");
                    Console.WriteLine($"Sexo: {utente.Sexo}");
                    Console.WriteLine($"Data de Nascimento: {utente.DataNascimento.ToString("yyyy-MM-dd")}");
                    Console.WriteLine($"Cidade: {utente.Cidade}");
                    Console.WriteLine($"Código Postal: {utente.CodigoPostal}");
                    Console.WriteLine($"Número de Utente: {utente.NumUtente}");
                    Console.WriteLine();
                    index++;
                }
            }

            Console.WriteLine($"Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }


        /// <summary>
        /// Adds a new patient to the waiting list.
        /// </summary>
        public void AdicionarUtente()
        {
            Utente novoUtente = Utente.ObterUtente();

            if (novoUtente != null)
            {
                // Add the new Utente to the list
                UtentesEspera.Add(novoUtente);

                Console.WriteLine($"Utente adicionado com sucesso!");

                // Display the list of Utentes
                MostrarUtentes(UtentesEspera);
            }
            else
            {
                Console.WriteLine($"Não foi possível adicionar o Utente. Verifique os dados inseridos.");
            }
        }


        #region CONSTRUTOR
        /// <summary>
        /// Initializes a new instance of the <see cref="Lista"/> class.
        /// </summary>
        public Lista()
        {
            UtentesEspera = new List<Utente>();
        }

        #endregion
        #endregion
    }
}
