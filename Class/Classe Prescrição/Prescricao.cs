using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Prescricao
{
    #region ATRIBUTOS

    /// <summary>
    /// Medicamento presente na prescição que o médico realizou aquele utente
    /// </summary>
    public string Medicamento { get; set; }

    /// <summary>
    /// Dosagem passada para o utente daquele(s) medicamento(s) que lhe foi prescrito
    /// </summary>
    public double Dosagem { get; set; }

    /// <summary>
    /// Instruções corretas para que o utente tome o medicamento de forma certa
    /// </summary>
    public string Instrucoes { get; set; }

    #endregion

    #region MÉTODOS

    #region PROPRIEDADES
    #endregion

    #region CONSTRUTOR

    public Prescricao()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    #endregion

    #endregion


    

    
}
