/*
* Diogo Pinheiro e Ana Pinto
* LEIM - 2º ano
* TP_POO - 2023/2024
* 
* Classe dados Registos Clinicos
**/

using TP_POO.Enums;
using TP_POO.Class;
using TP_POO.Exceptions;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Globalization;
using System.Text;

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
                Data = new DateTime(2021, 01, 01),
                Prescricao = new Prescricao
                {
                    Medicamento = "Paracetamol",
                    Dosagem = 500,
                    Instrucoes = "Tomar 1 comprimido de 8 em 8 horas."
                },
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
        /// <summary>
        /// Method that adds a clinical record to the list.
        /// </summary>
        /// <param name="novoRegistoClinico"></param>
        /// <returns></returns>
        /// <exception cref="DadoNulosException"></exception>
        /// <exception cref="DadoJaExisteException"></exception>
        public bool AddRegisto(RegistoClinico novoRegistoClinico)
        {
            if (novoRegistoClinico is null)
                throw new DadoNulosException("RegistoClinico");

            foreach (var rc in registoClinicos)
            {
                if (rc.NumeroRegisto.Equals(novoRegistoClinico.NumeroRegisto))
                    throw new DadoJaExisteException("RegistoClinico");
            }

            registoClinicos.Add(novoRegistoClinico);
            return true;
        }

        /// <summary>
        /// Method that removes a clinical record from the list.
        /// </summary>
        /// <param name="numRegisto"></param>
        /// <returns></returns>
        /// <exception cref="DadoNaoExisteException"></exception>
        public bool RemoveRegisto(int numRegisto)
        {
            bool found = false;

            for (int i = 0; i < registoClinicos.Count; i++)
            {
                if (registoClinicos[i].NumeroRegisto.Equals(numRegisto))
                {
                    registoClinicos.RemoveAt(i);
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                throw new DadoNaoExisteException("Registos Clinicos");
            }

            return true;
        }

        /// <summary>
        /// Method that updates a clinical record.
        /// </summary>
        /// <param name="registoClinico"></param>
        /// <returns></returns>
        /// <exception cref="DadoNulosException"></exception>
        /// <exception cref="DadoNaoExisteException"></exception>
        public bool UpdateRegisto(RegistoClinico registoClinico)
        {
            if (registoClinico is null)
                throw new DadoNulosException("RegistoClinico");

            for (int i = 0; i < registoClinicos.Count; i++)
            {
                if (registoClinicos[i].NumeroRegisto.Equals(registoClinico.NumeroRegisto))
                {
                    registoClinicos[i] = registoClinico;
                    return true;
                }
            }

            throw new DadoNaoExisteException("RegistoClinico");
        }

        /// <summary>
        /// Method that shows all clinical records fo a Utente based in the Utente id.
        /// </summary>
        /// <param name="userId"></param>
        public void ShowRegistosForUtente(int userId)
        {
            string fileName = $"{userId}_records.bin";

            if (File.Exists(fileName))
            {
                string[] records = File.ReadAllLines(fileName);
                if (records.Length == 0)
                {
                    Console.WriteLine("No previous records found.");
                }
                else
                {
                    foreach (string record in records)
                    {
                        Console.WriteLine(record);
                    }
                }
            }
        }

        /// <summary>
        /// Method that prints all clinical records.
        /// </summary>
        /// <returns></returns>
        public List<RegistoClinico> GetRegistosClinicos()
        {
            return registoClinicos;
        }

        /// <summary>
        /// Method that reads all clinical records from a file.
        /// </summary>
        /// <param name="filePath"></param>
        /// <exception cref="FileNotFoundException"></exception>
        public string LoadRecordsFromFile(string filePath)
        {
            string records = "";

            try
            {
                using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
                {
                    while (reader.PeekChar() > -1)
                    {
                        RegistoClinico novoRegisto = new RegistoClinico();

                        novoRegisto.Diagnostico = reader.ReadString();
                        novoRegisto.Utente = new Utente { Nome = reader.ReadString() };
                        novoRegisto.Utente.DataNascimento = DateOnly.Parse(reader.ReadString());
                        novoRegisto.Data = DateTime.Parse(reader.ReadString());
                        novoRegisto.Prescricao = new Prescricao
                        {
                            Medicamento = reader.ReadString(),
                            Dosagem = reader.ReadDouble(),
                            Instrucoes = reader.ReadString()
                        };
                        novoRegisto.Sintomas = reader.ReadString();

                        records += $"Registo Clínico:\n";
                        records += $"Diagnóstico: {novoRegisto.Diagnostico}\n";
                        records += $"Utente: {novoRegisto.Utente.Nome}\n";
                        records += $"Data de Nascimento: {novoRegisto.Utente.DataNascimento}\n";
                        records += $"Data do Registo: {novoRegisto.Data.ToShortDateString()}\n";
                        records += $"Prescrição: {novoRegisto.Prescricao.Medicamento}\n";
                        records += $"Dosagem: {novoRegisto.Prescricao.Dosagem}\n";
                        records += $"Instruções: {novoRegisto.Prescricao.Instrucoes}\n";
                        records += $"Sintomas: {novoRegisto.Sintomas}\n\n";
                    }
                }
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException("File not found.");
            }

            return records;
        }
        #endregion
    }
}
