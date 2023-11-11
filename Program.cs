using System;
using TP_POO;
using TP_POO.Enums;
using SexoEnum = TP_POO.Enums.Sexo;
using CidadeEnum = TP_POO.Enums.Cidade;
using System.Diagnostics.Metrics;

namespace SistemaUrgencias
{
    class Program
    {

        static void Main(string[] args)
        {
            int op;
            Utente[] utentes = new Utente[100]; // Initialize an array to store Utentes
            int index = 0; // Initialize the index for the Utentes array

            do
            { 
                Console.Clear();
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("|                    Urgência                     |\n" +
                                  "|      Implementação Essencial das Classes        |");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("|  1 - Utente                                     |");
                Console.WriteLine("|  2 - Médico                                     |");
                Console.WriteLine("|  3 - Lista de Utentes                           |");
                Console.WriteLine("|  4 - Prescrição                                 |");
                Console.WriteLine("|  5 - Registo Clínico                            |");
                Console.WriteLine("|  6 - Triagem                                    |");
                Console.WriteLine("|  0 - Sair                                       |");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("\nEscolha uma opcao: ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 0:
                        System.Environment.Exit(0);
                        break;
                    case 1:
                        Console.Clear();
                        Console.WriteLine("**************** Utente ****************");
                        DateTime dataNascimento = new DateTime(1990, 5, 15);
                        Utente utente1 = new Utente("Joao", 123456789, Sexo.Masculino, dataNascimento, Cidade.Braga, "4700-400", 13);
                        utentes[index] = utente1;
                        index++;
                        utente1.ExibirUtente();
                        Console.WriteLine();
                        Console.WriteLine($"Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("**************** Médico ****************");
                        DateTime dataNascimentoMedico = new DateTime(1987, 4, 4);
                        Medico medico1 = new Medico("Albertina", 654789231, Sexo.Feminino, dataNascimentoMedico, Cidade.Guimaraes, "4201-654", Especialidade.Cardiologia, 50);
                        medico1.ExibirMedico();
                        Console.WriteLine();
                        Console.WriteLine($"Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 3:
                        int op2;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("--------------------------------------------------");
                            Console.WriteLine("|                 Lista de Utentes                |");
                            Console.WriteLine("--------------------------------------------------");
                            Console.WriteLine("|  1 - Lista Utentes                              |");
                            Console.WriteLine("|  2 - Adicionar Utentes                          |");
                            Console.WriteLine("|  0 - Voltar                                     |");
                            Console.WriteLine("--------------------------------------------------");
                            Console.WriteLine("\nEscolha uma opcao: ");
                            op2 = int.Parse(Console.ReadLine());
                    
                            switch (op2)
                            {
                                case 0:
                                    Main(args);
                                    break;
                                case 1:
                                    MostrarUtentes(utentes);
                                    break;
                                case 2:
                                    AdicionarUtente(utentes, ref index);
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida. Tente novamente.");
                                    break;
                            }
                        } while (op2 != 0);
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("**************** Prescrição ****************");
                        Prescricao prescricao1 = new Prescricao("Paracetamol", 1.5, "Tomar duas vezes ao dias, após refeições.");
                        prescricao1.ExibirPrescricao();
                        Console.WriteLine();
                        Console.WriteLine($"Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("**************** Registo Clínico ****************");
                        RegistoClinico rclinico1 = new RegistoClinico("Frequência Cardíaca Alta", "Ecocardiografia", "Este utente têm frequência cardíaca alta, tensão alta.");
                        rclinico1.ExibirRegisto();
                        Console.WriteLine();
                        Console.WriteLine($"Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("**************** Triagem ****************");
                        Triagem tri1 = new Triagem(Gravidade.Grave, "Sensação de mal estar e fraqueza, desmaio frequente");
                        tri1.ExibirTriagem();
                        Console.WriteLine();
                        Console.WriteLine($"Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            } while (op != 0);
        }


        // Function to obtain a new Utente (patient) from user input
        static Utente ObterUtente()
        {
            Console.Clear();
            Console.WriteLine("**************** Adicionar Utente ****************");

            // Variables to store user input
            string nome, codigoPostal, sexoStr, cidadeStr;
            DateTime dataNascimento;
            int numeroTelemovel, numeroUtente;
            SexoEnum sexo;
            CidadeEnum cidade;

            // Obtain data from the console
            Console.Write("Nome do Utente: ");
            nome = Console.ReadLine();
            Console.Write("Número de Telemóvel: ");
            numeroTelemovel = int.Parse(Console.ReadLine());

            Console.Write("Sexo do Utente: ");
            sexoStr = Console.ReadLine();
            if (!Enum.TryParse(sexoStr, true, out sexo))
            {
                Console.WriteLine("Sexo inválido. Use 'Masculino' ou 'Feminino'.");
                return null;
            }

            Console.Write("Data de Nascimento (yyyy-MM-dd): ");
            if (!DateTime.TryParse(Console.ReadLine(), out dataNascimento))
            {
                Console.WriteLine("Data de Nascimento inválida. Use o formato 'yyyy-MM-dd'.");
                return null;
            }

            Console.Write("Cidade do Utente: ");
            cidadeStr = Console.ReadLine();
            if (!Enum.TryParse(cidadeStr, true, out cidade))
            {
                Console.WriteLine("Cidade inválida. Use as cidades que são válidas.");
                return null;
            }

            Console.Write("Código Postal: ");
            codigoPostal = Console.ReadLine();
            Console.Write("Número de Utente: ");
            numeroUtente = int.Parse(Console.ReadLine());

            // Create the Utente object using the obtained data
            Utente utente = new Utente(nome, numeroTelemovel, sexo, dataNascimento, cidade, codigoPostal, numeroUtente);

            return utente;
        }


        // Function to add a new Utente to the array and display the list
        static void AdicionarUtente(Utente[] utentes, ref int index)
        {
            if (index < utentes.Length)
            {
                Utente novoUtente = ObterUtente(); // Get user input to create a new Utente

                if (novoUtente != null)
                {
                    // Add the new Utente to the array
                    utentes[index] = novoUtente;
                    index++;

                    Console.WriteLine($"Utente adicionado com sucesso!");

                    // Display the list of Utentes
                    MostrarUtentes(utentes);
                }
                else
                {
                    Console.WriteLine($"Não foi possível adicionar o Utente. Verifique os dados inseridos.");
                }
            }
            else
            {
                Console.WriteLine($"Limite de Utentes atingido. Não é possível adicionar mais Utentes.");
            }
        }


        // Function to list Utentes
        static void MostrarUtentes(Utente[] utentes)
        {
            Console.Clear();
            Console.WriteLine("**************** Lista de Utentes ****************");

            if (utentes.Length == 0)
            {
                Console.WriteLine($"Nenhum Utente cadastrado.");
            }
            else
            {
                Console.WriteLine($"Lista de Utentes:");
                for (int i = 0; i < utentes.Length; i++)
                {
                    if (utentes[i] != null)
                    {
                        Console.WriteLine($"Utente {i + 1}:");
                        Console.WriteLine($"Nome: " + utentes[i].Nome);
                        Console.WriteLine($"Número de Telemóvel: " + utentes[i].NumTelemovel);
                        Console.WriteLine($"Sexo: " + utentes[i].Sexo);
                        Console.WriteLine($"Data de Nascimento: " + utentes[i].DataNascimento.ToString("yyyy-MM-dd"));
                        Console.WriteLine($"Cidade: " + utentes[i].Cidade);
                        Console.WriteLine($"Código Postal: " + utentes[i].CodigoPostal);
                        Console.WriteLine($"Número de Utente: " + utentes[i].NumUtente);
                        Console.WriteLine();
                    }
                }
            }

            Console.WriteLine($"Pressione qualquer tecla para continuar..."); 
            Console.ReadKey();
        }
    }
}
