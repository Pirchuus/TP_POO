using System;
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

    public Medico(string nome, int numTelemovel, Sexo sexo, DateOnly dataNascimento, Cidade cidade, string codigoPostal, Especialidade especialidade, int numRegistoMedico)
        : base(nome, numTelemovel, sexo, dataNascimento, cidade, codigoPostal)
    {
        this.especialidade = especialidade;
        NumRegistoMedico = numRegistoMedico;
    }

    #endregion

    #endregion
}
