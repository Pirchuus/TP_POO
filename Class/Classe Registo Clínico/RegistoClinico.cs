using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class RegistoClinico
{
    #region ATRIBUTOS

    /// <summary>
    /// Atributo do diagnóstico do paciente registado no registo clínico
    /// </summary>
    public string Diagnostico { get; set; }

    /// <summary>
    /// Atributo dos Exames que estão no registo clínico
    /// </summary>
    public string Exames { get; set; }

    /// <summary>
    /// Atributo das anotações feitas pelo médico no registo clínnico de um determinado paciente
    /// </summary>
    public string Anotacoes { get; set; }

    #endregion

    #region MÉTODOS

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
