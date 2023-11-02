using System;
using Classe Pessoa.Pessoa;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Utente : Pessoa
{
    #region ATRIBUTOS

    /// <summary>
    /// Histórico Médico de situações passadas anteriormente
    /// </summary>
    public string HistoricoMedico { get; set; }

    /// <summary>
    /// Número do utente
    /// </summary>
    public int NumUtente { get; private set; }

    #endregion

    #region MÉTODOS

    #region PROPRIEDADES
    #endregion

    #region CONSTRUTOR

    public Utente()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    #endregion

    #endregion


    
    
}
