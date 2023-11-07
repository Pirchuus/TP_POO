using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Lista
{
    #region ATRIBUTOS

    /// <summary>
    /// Lista de utentes na lista de espera
    /// </summary>
    public List<Utente> UtentesEspera { get; set; }


    #endregion

    #region MÉTODOS

    #region PROPRIEDADES
    #endregion

    #region CONSTRUTOR

    public Lista()
    {
        UtentesEspera = new List<Utente>();
    }

    #endregion

    #endregion
}
