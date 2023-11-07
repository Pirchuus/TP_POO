using System;
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

    public Medico(string nome, int numTelemovel, Sexo sexo, DateOnly dataNascimento, Cidade cidade, string codigoPostal, Especialidade especialidade, int numRegistoMedico)
        : base(nome, numTelemovel, sexo, dataNascimento, cidade, codigoPostal)
    {
        this.especialidade = especialidade;
        NumRegistoMedico = numRegistoMedico;
    }

    #endregion

    #endregion
}
