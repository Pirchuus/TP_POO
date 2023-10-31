using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Pessoa
{
    #region ATRIBUTOS

    public string Nome { get; set; }
    public int NumTelemovel { get; set; }
    public string Genero { get; set; } // pode ser enumerado
    public DateTime DataNascimento { get; set; }
    public string Cidade { get; set; } // pode ser enumerado talvez
    public int CodigoPostal { get; set; } // acho que não é do tipo int

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
