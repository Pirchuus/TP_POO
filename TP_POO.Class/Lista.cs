using System;
using System.Collections.Generic;

namespace TP_POO.Class
{
    public class Lista
    {
        #region ATRIBUTOS
        /// <summary>
        /// Lista de utentes, ou seja, lista de espera dos utentes
        /// </summary>
        public List<Utente> UtentesEspera { get; set; }
        #endregion

        #region MÉTODOS
        // Função da Lista de Utentes
        public void MostrarUtentes(List<Utente> utentes)
        {
            Console.Clear();
            Console.WriteLine("**************** Lista de Utentes ****************");

            if (utentes.Count == 0)
            {
                Console.WriteLine($"Nenhum Utente cadastrado.");
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


        // Funçaõ para Adicoonar os utentes
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
        public Lista()
        {
            UtentesEspera = new List<Utente>();
        }

        #endregion
        #endregion
    }
}
