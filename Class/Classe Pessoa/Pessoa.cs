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
    /// Atributo do n�mero de telemovel da pessoa
    /// </summary>
    public int NumTelemovel { get; set; }

    /// <summary>
    /// Atributo sobre o g�nero da pessoa. Este � um enumerado.
    /// </summary>
    public Sexo Sexo { get; set; }

    /// <summary>
    /// Data de Nascimento da Pessoa
    /// </summary>
    public DateTime DataNascimento { get; set; }

    /// <summary>
    /// Cidade de onde a pessoa �
    /// </summary>
    public Cidade cidade { get; set; } 

    /// <summary>
    /// C�digo Postal da pessoa
    /// </summary>
    public string CodigoPostal { get; set; }

    #endregion

    #region M�TODOS

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
