using System;
using TP_POO.Enums;

/// <summary>
/// Summary description for Class1
/// </summary>
public abstract class Pessoa
{
    #region ATRIBUTOS

    /// <summary>
    /// Atributo sobre o nome da pessoa
    /// </summary>
    public string Nome { get; set; }

    /// <summary>
    /// Atributo do número de telemovel da pessoa
    /// </summary>
    public int NumTelemovel { get; set; }

    /// <summary>
    /// Atributo sobre o género da pessoa. Este é um enumerado.
    /// </summary>
    public Sexo Sexo { get; set; }

    /// <summary>
    /// Data de Nascimento da Pessoa
    /// </summary>
    public DateTime DataNascimento { get; set; }

    /// <summary>
    /// Cidade de onde a pessoa é
    /// </summary>
    public Cidade cidade { get; set; } 

    /// <summary>
    /// Código Postal da pessoa
    /// </summary>
    public string CodigoPostal { get; set; }

    #endregion

    #region MÉTODOS

    #region PROPRIEDADES
    #endregion

    #region CONSTRUTOR
    public Pessoa()
    {
        //
        // TODO: Add constructor logic here
        //

    }
    #endregion

    #endregion


    

    
}
