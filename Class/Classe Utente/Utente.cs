using System;
using TP_POO.Enums;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Utente : Pessoa
{
    #region ATRIBUTOS

    /// <summary>
    /// Número do utente
    /// </summary>
    public int NumUtente { get; private set; }


    #endregion

    #region MÉTODOS

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Numero de Telemovel: {NumTelemovel}");
        Console.WriteLine($"Sexo: {Sexo}");
        Console.WriteLine($"Data de Nascimento: {DataNascimento}");
        Console.WriteLine($"Cidade: {Cidade}");
        Console.WriteLine($"Codigo Postal: {CodigoPostal}");
        Console.WriteLine($"Numero de Utente: {NumUtente}");
    }

    #region PROPRIEDADES
    #endregion

    #region CONSTRUTOR

    public Utente(string nome, int numTelemovel, Sexo sexo, DateOnly dataNascimento, Cidade cidade, string codigoPostal, int numUtente)
        : base(nome, numTelemovel, sexo, dataNascimento, cidade, codigoPostal)
    {
        NumUtente = numUtente;
    }

    #endregion

    #endregion
}
