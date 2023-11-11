using System;
using TP_POO.Enums;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Triagem
{
    #region ATRIBUTOS
    /// <summary>
    /// Gravidade do mau estar do utente
    /// </summary>
    public Gravidade gravidade { get; set; } 

    /// <summary>
    /// Sintomas que o doente apresenta
    /// </summary>
    public string Sintomas { get; set; } 

    /// <summary>
    /// Prioridade que o doente tem perante a gravidade e os sintomas que tem
    /// </summary>
    public int Prioridade { get; set; }

    #endregion

    #region M�TODOS
    private int CalcularPrioridade()
    {
        int gravidadeValor = (int)gravidade;
        
        string[] sintomasArray = Sintomas.Split(',');
        int numeroSintomas = sintomasArray.Length;

        int prioridade = gravidadeValor + numeroSintomas;
        
        return prioridade;
    }

    public void ExibirTriagem()
    {
        Console.WriteLine($"Gravidade: {gravidade}");
        Console.WriteLine($"Sintomas: {Sintomas}");
        Console.WriteLine($"Prioridade: {Prioridade}");
    }

    #region CONSTRUTOR
    public Triagem(Gravidade gravidade, string sintomas)
    {
        this.gravidade = gravidade;
        Sintomas = sintomas;

        Prioridade = CalcularPrioridade();
    }

    #endregion
    #endregion
}
