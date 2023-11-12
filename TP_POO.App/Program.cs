using System;
using TP_POO.Enums;
using TP_POO.Class;

namespace SistemaUrgencias
{
    /// <summary>
    /// Main program class for managing an emergency system.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            Lista lista = new Lista();

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
                        Environment.Exit(0);
                        break;
                    case 1:
                        Console.Clear();
                        Console.WriteLine("**************** Utente ****************");
                        DateTime dataNascimento = new DateTime(1990, 5, 15);
                        Utente utente1 = new Utente("Joao", 123456789, Sexo.Masculino, dataNascimento, Cidade.Braga, "4700-400", 13);
                        lista.UtentesEspera.Add(utente1);
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
                                    // Não faz nada, apenas volta ao menu principal
                                    break;
                                case 1:
                                    lista.MostrarUtentes(lista.UtentesEspera);
                                    break;
                                case 2:
                                    lista.AdicionarUtente();
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
    }
}
