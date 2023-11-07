using System;
using TP_POO.Enums;

/// <summary>
/// Summary description for Enfermeiro
/// </summary>
public class Enfermeiro : Pessoa
{
    #region ATRIBUTOS

    /// <summary>
    /// Atributo sobre a função que o enfermeiro exerce na urgência. Este é um enumerado
    /// </summary>
    public Funcao funcao { get; set; }

    /// <summary>
    /// Atributo do número de registo do enfermeiro, ou seja, o seu número de profissinal de saúde no hospital
    /// </summary>
    public int NumRegistoEnf { get; set; }

    #endregion

    #region MÉTODOS

    #region PROPRIEDADES
    #endregion

    #region CONTRUTOR

    public Enfermeiro(string nome, int numTelemovel, Sexo sexo, DateTime dataNascimento, Cidade cidade, string codigoPostal, Funcao funcao, int numRegistoEnf)
        : base(nome, numTelemovel, sexo, dataNascimento, cidade, codigoPostal)
    {
        this.funcao = funcao;
        NumRegistoEnf = numRegistoEnf;

    }

    #endregion

    #endregion

}
