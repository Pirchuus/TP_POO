/*
* Diogo Pinheiro e Ana Pinto
* LEIM - 2º ano
* TP_POO - 2023/2024
* 
* Programa Principal
**/

using TP_POO.Dados;
using TP_POO.Enums;
using TP_POO.Class;
using TP_POO.Exceptions;

namespace TP_POO
{
    class Program
    {

        static void Main(string[] args)
        {
            Medicos medicosManager = new Medicos();
            Prescricoes prescricoesManager = new Prescricoes();
            Utentes utentesManager = new Utentes();
            RegistosClinicos registosClinicosManager = new RegistosClinicos();
            Triagens triagensManager = new Triagens();
            ListaEspera waitingListManager = new ListaEspera();

            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("\n\t\tWelcome to the Medical System");
                Console.WriteLine("\n1. Management");
                Console.WriteLine("2. User Operations");
                Console.WriteLine("0. Exit");
                Console.Write("Select an option: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        ManagementMenu(medicosManager, prescricoesManager);
                        break;
                    case "2":
                        UserMenu(utentesManager, triagensManager, waitingListManager, prescricoesManager, registosClinicosManager);
                        break;
                    case "0":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }

        static void ManagementMenu(Medicos medicosManager, Prescricoes prescricoesManager)
        {

            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("\n\t\tManagement Menu");
                Console.WriteLine("\n1. Create Doctor");
                Console.WriteLine("2. Create Prescription");
                Console.WriteLine("3. Show Doctors");
                Console.WriteLine("4. Show Prescriptions");
                Console.WriteLine("0. Back");
                Console.Write("Select an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CreateDoctor(medicosManager);
                        break;
                    case "2":
                        CreatePrescription(prescricoesManager);
                        break;
                    case "3":
                        Console.Clear();
                        medicosManager.ShowMedicos();
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.Clear();
                        prescricoesManager.ShowPrescricoes();
                        Console.ReadKey();
                        break;
                    case "0":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }

        static void UserMenu(Utentes utentesManager, Triagens triagensManager, ListaEspera waitingListManager, Prescricoes prescricoesManager, RegistosClinicos registosClinicosManager)
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("\n\t\tUser Operations Menu");
                Console.WriteLine("\n1. Emergency Visit");
                Console.WriteLine("2. Consultation");
                Console.WriteLine("0. Back");
                Console.Write("Select an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        EmergencyVisit(utentesManager, triagensManager, waitingListManager);
                        break;
                    case "2":
                        Consultation(waitingListManager, prescricoesManager, registosClinicosManager);
                        break;
                    case "0":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }


        static void CreateDoctor(Medicos medicos)
        {
            Console.WriteLine("\n-- Create New Doctor --");

            // Get Doctor's Name
            Console.Write("Enter doctor's name: ");
            string name = Console.ReadLine();

            // Choose Specialty
            Console.WriteLine("Choose Specialty:");
            foreach (var specialty in Enum.GetValues(typeof(Especialidade)))
            {
                Console.WriteLine($"- {specialty}");
            }
            Console.Write("Specialty: ");
            Especialidade especialidade;
            Enum.TryParse(Console.ReadLine(), out especialidade);

            // Create and Add Doctor
            try
            {
                Medico newDoctor = new Medico { Nome = name, Especialidade = especialidade };
                medicos.AddMedico(newDoctor);
                Console.WriteLine($"{name} added as {especialidade}.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        static void CreatePrescription(Prescricoes prescricoes)
        {
            Console.WriteLine("\n-- Create New Prescription --");

            // Get Prescription Details
            Console.Write("Enter medication name: ");
            string medicamento = Console.ReadLine();

            Console.Write("Enter dosage: ");
            double dosagem = double.Parse(Console.ReadLine());

            Console.Write("Enter instructions: ");
            string instrucoes = Console.ReadLine();

            // Create and Add Prescription
            Prescricao newPrescription = new Prescricao { Medicamento = medicamento, Dosagem = dosagem, Instrucoes = instrucoes };
            prescricoes.AddPrescricao(newPrescription);

            Console.WriteLine("Prescription added successfully.");
        }
        static void EmergencyVisit(Utentes utentes, Triagens triagens, ListaEspera waitingList)
        {
            Console.WriteLine("\n-- Emergency Visit --");

            // show utentes
            Console.Clear();
            utentes.ShowUtentes();

            // chose utente
            Console.Write("\n\nEnter utente ID's for triage: ");
            int utenteID = int.Parse(Console.ReadLine());

            // Retrieve the Utente object
            Utente selectedUtente = utentes.GetUtenteById(utenteID);
            if (selectedUtente == null)
            {
                Console.WriteLine("Utente not found.");
                return;
            }

            Console.Clear();
            Console.WriteLine($"Utente {utenteID}.");
            Console.WriteLine("Inserir sintomas:");
            string sintomas = Console.ReadLine();

            // choose severity
            Console.WriteLine("Choose Severity:");
            foreach (var severity in Enum.GetValues(typeof(Gravidade)))
            {
                Console.WriteLine($"- {severity}");
            }
            Console.Write("Severity: ");
            Gravidade gravidade;
            Enum.TryParse(Console.ReadLine(), out gravidade);

            try
            {
                Triagem newTriagem = new Triagem { Utente = selectedUtente, Sintomas = sintomas, Gravidade = gravidade };
                triagens.AddTriagem(newTriagem);
                waitingList.AddToWaitingList(newTriagem);
                utentes.RemoveUtente(utenteID);
                Console.WriteLine($"\nUtente {selectedUtente.Nome} added to waiting list as severity: {gravidade}.\n\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            waitingList.ShowWaitingList();
            Console.ReadKey();
        }
        static void Consultation(ListaEspera waitingList, Prescricoes prescricoes, RegistosClinicos registosClinicos)
        {
            // Check if the waiting list is empty
            if (waitingList.waitingList.Count == 0)
            {
                Console.WriteLine("Waiting list is empty.");
                Console.ReadKey();
                return;
            }

            // Get the first patient from the waiting list
            Triagem nextPatientTriagem = waitingList.GetNextPatient();
            Utente nextPatient = nextPatientTriagem.Utente;

            // Show previous clinical records of the patient
            Console.WriteLine($"\nShowing previous clinical records for {nextPatient.Nome}...");

            string fileName = $"{nextPatient.NumUtente}_records.bin";
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
            string records = registosClinicos.LoadRecordsFromFile(filePath);

            foreach (string record in records.Split('\n'))
            {
                Console.WriteLine(record);
            }

            Console.WriteLine("\nPress any key to continue to the new clinical record...");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("\t\t\n-- New Clinical Record --\n\n");
            Console.Write("Enter diagnosis: ");
            string diagnosis = Console.ReadLine();

            Console.WriteLine("\n");
            prescricoes.ShowPrescricoes();
            Console.Write("Enter prescription ID: ");
            int prescriptionID = int.Parse(Console.ReadLine());

            DateTime recordDate = DateTime.Now;

            // Create the clinical record instance
            RegistoClinico newRecord = new RegistoClinico
            {
                Utente = nextPatient,
                Diagnostico = diagnosis,
                Data = recordDate,
                Prescricao = prescricoes.GetPrescricaoById(prescriptionID),
                Instrucoes = prescricoes.GetPrescricaoById(prescriptionID).Instrucoes,
                Dosagem = prescricoes.GetPrescricaoById(prescriptionID).Dosagem.ToString(),
                Sintomas = nextPatientTriagem.Sintomas
            };

            // Add the new clinical record
            registosClinicos.AddRegisto(newRecord);

            // Save the record to a file
            SaveRecordToFile(newRecord);
            Console.ReadKey();
        }
        static void SaveRecordToFile(RegistoClinico record)
        {
            string fileName = $"{record.Utente.NumUtente}_records.bin";
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

            try
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Append)))
                {
                    // Write clinical record data to the binary file
                    writer.Write(record.Diagnostico);
                    writer.Write(record.Utente.Nome);
                    writer.Write(record.Utente.DataNascimento.ToString("yyyy-MM-dd"));
                    writer.Write(record.Data.ToString("yyyy-MM-dd"));
                    writer.Write(record.Prescricao.Medicamento);
                    writer.Write(record.Prescricao.Dosagem);
                    writer.Write(record.Prescricao.Instrucoes);
                    writer.Write(record.Sintomas);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving record: {ex.Message}");
            }
        }

    }
}