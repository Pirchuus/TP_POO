using System;

/// <summary>
/// Summary description for Enfermeiro
/// </summary>
public class Enfermeiro : Pessoa
{
    #region ATRIBUTOS

    /// <summary>
    /// Atributo sobre a função que o enfermeiro exerce na urgência. Este é um enumerado
    /// </summary>
    public Funcao funcao { get; set; }

    /// <summary>
    /// Atributo do número de registo do enfermeiro, ou seja, o seu número de profissinal de saúde no hospital
    /// </summary>
    public int NumRegistoEnf { get; set; }

    #endregion
}
