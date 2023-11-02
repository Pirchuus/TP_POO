using System;
using Classe Pessoa.Pessoa;
using TP_POO.Enums;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Medico : Pessoa 
{
    #region ATRIBUTOS

    /// <summary>
    /// Atributo sobre a especialidade a que o m�dico pertence, sendo este um enumerado.
    /// </summary>
    public Especialidade especialidade { get; set; } 

    /// <summary>
    /// Atributo referente ao n�mero de registo do m�dico, ou seja, o n�mero do profissional de sa�de do hospital
    /// </summary>
    public int NumRegistoMedico { get; private set; }

    #endregion

    #region M�TODOS

    #region PROPRIEDADES
    #endregion

    #region CONSTRUTOR

    public Medico()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    #endregion

    #endregion


    
    
}
