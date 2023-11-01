using System;
using Enums;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Pessoa
{
    #region ATRIBUTOS

    public string Nome { get; set; }
    public int NumTelemovel { get; set; }
    public Genero Genero { get; set; } 
    public DateTime DataNascimento { get; set; }
    public string Cidade { get; set; } 
    public string CodigoPostal { get; set; } 

    #endregion

    #region MÉTODOS
    #endregion

    #region CONSTRUTOR
    public Pessoa()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    #endregion

    
}
