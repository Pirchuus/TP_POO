using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class RegistoClinico
{
    #region ATRIBUTOS

    /// <summary>
    /// Atributo do diagn�stico do paciente registado no registo cl�nico
    /// </summary>
    public string Diagnostico { get; set; }

    /// <summary>
    /// Atributo dos Exames que est�o no registo cl�nico
    /// </summary>
    public string Exames { get; set; }

    /// <summary>
    /// Atributo das anota��es feitas pelo m�dico no registo cl�nnico de um determinado paciente
    /// </summary>
    public string Anotacoes { get; set; }

    #endregion

    #region M�TODOS

    #region PROPRIEDADES
    #endregion

    #region CONTRUTOR

    public RegistoClinico()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    #endregion

    #endregion
}
