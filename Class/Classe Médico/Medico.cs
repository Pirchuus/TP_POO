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
    /// Atributo sobre a especialidade a que o médico pertence, sendo este um enumerado.
    /// </summary>
    public Especialidade especialidade { get; set; } 

    /// <summary>
    /// Atributo referente ao número de registo do médico, ou seja, o número do profissional de saúde do hospital
    /// </summary>
    public int NumRegistoMedico { get; private set; }

    #endregion

    #region MÉTODOS

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
