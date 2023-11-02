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

    #region MÉTODOS

    #region PROPRIEDADES
    #endregion

    #region CONSTRUTOR

    public Triagem()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    #endregion

    #endregion


    
    
}
