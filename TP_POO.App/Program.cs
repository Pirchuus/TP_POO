using TP_POO.Enums;
using TP_POO.Class;
using TP_POO.Dados;


namespace TP_POO
{
    class Program
    {
        static Medicos medicosManager = new Medicos();
        static Prescricoes prescricoesManager = new Prescricoes();
        static Utentes utentesManager = new Utentes();
        static RegistosClinicos registosClinicosManager = new RegistosClinicos();
        static Triagens triagensManager = new Triagens();
        static ListaEspera waitingListManager = new ListaEspera();


        static void Main(string[] args)
        {

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
                        ManagementMenu();
                        break;
                    case "2":
                        UserMenu();
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

        static void ManagementMenu()
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

        static void UserMenu()
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
                        EmergencyVisit();
                        break;
                    case "2":
                        Consultation();
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

        static void CreateDoctor(Medicos medicosManager)
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
                medicosManager.AddMedico(newDoctor);
                Console.WriteLine($"{name} added as {especialidade}.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        static void CreatePrescription(Prescricoes prescricoesManager)
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
            prescricoesManager.AddPrescricao(newPrescription);

            Console.WriteLine("Prescription added successfully.");
        }
        static void EmergencyVisit()
        {
            Console.WriteLine("\n-- Emergency Visit --");

            // show utentes
            Console.Clear();
            utentesManager.ShowUtentes();

            // chose utente
            Console.Write("\n\nEnter utente ID's for triage: ");
            int utenteID = int.Parse(Console.ReadLine());

            // Retrieve the Utente object
            Utente selectedUtente = utentesManager.GetUtenteById(utenteID);
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
                triagensManager.AddTriagem(newTriagem);
                waitingListManager.AddToWaitingList(newTriagem);
                utentesManager.RemoveUtente(selectedUtente);
                Console.WriteLine($"\nUtente {selectedUtente.Nome} added to waiting list as severity: {gravidade}.\n\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            waitingListManager.ShowWaitingList();
            Console.ReadKey();
        }
        static void Consultation()
        {
            // Check if the waiting list is empty
            if (waitingListManager.waitingList.Count == 0)
            {
                Console.WriteLine("Waiting list is empty.");
                Console.ReadKey();
                return;
            }

            // Get the first patient from the waiting list
            Triagem nextPatientTriagem = waitingListManager.GetNextPatient();
            Utente nextPatient = nextPatientTriagem.Utente;

            // Show previous clinical records of the patient
            Console.WriteLine($"\nShowing previous clinical records for {nextPatient.Nome}...");

            string fileName = $"{nextPatient.NumUtente}_records.txt";
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
            string records = ReadFile(filePath);

            if (!string.IsNullOrEmpty(records))
            {
                Console.WriteLine(records);
            }
            else
            {
                Console.WriteLine("No previous records found.");
            }

            Console.WriteLine("\nPress any key to continue to the new clinical record...");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("\t\t\n-- New Clinical Record --\n\n");
            Console.Write("Enter diagnosis: ");
            string diagnosis = Console.ReadLine();

            Console.WriteLine("\n");
            prescricoesManager.ShowPrescricoes();
            Console.Write("Enter prescription ID: ");
            int prescriptionID = int.Parse(Console.ReadLine());

            DateTime recordDate = DateTime.Now; // Record the date of the consultation

            // Create the clinical record instance
            RegistoClinico newRecord = new RegistoClinico
            {
                Utente = nextPatient,
                Diagnostico = diagnosis,
                Data = recordDate,
                Prescricao = prescricoesManager.GetPrescricaoById(prescriptionID),
                Instrucoes = prescricoesManager.GetPrescricaoById(prescriptionID).Instrucoes,
                Dosagem = prescricoesManager.GetPrescricaoById(prescriptionID).Dosagem.ToString(),
                Sintomas = nextPatientTriagem.Sintomas
            };

            // Add the new clinical record
            registosClinicosManager.AddRegisto(newRecord);

            // Save the record to a file
            SaveRecordToFile(newRecord);
            Console.ReadKey();
        }
        static void SaveRecordToFile(RegistoClinico record)
        {
            string fileName = $"{record.Utente.NumUtente}_records.txt";
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

            try
            {
                // Create a string to represent the record's data
                string recordData = $"Clinical Record for Utente ID: {record.Utente.NumUtente}\n" +
                                    $"Name: {record.Utente.Nome}\n" +
                                    $"Date: {record.Data.ToShortDateString()}\n" +
                                    $"Diagnosis: {record.Diagnostico}\n" +
                                    $"Symptoms: {record.Sintomas}\n" +
                                    $"Prescription: {record.Prescricao.Medicamento} " +
                                    $"Dosage: {record.Dosagem} " +
                                    $"Instructions: {record.Instrucoes}\n" +
                                    $"--------------------------------------\n";

                // Write the data to the file
                File.AppendAllText(filePath, recordData);

                Console.WriteLine($"Record saved successfully to {filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving record: {ex.Message}");
            }
        }
        static string ReadFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                return File.ReadAllText(filePath);
            }
            else
            {
                return null;
            }
        }
    }
}