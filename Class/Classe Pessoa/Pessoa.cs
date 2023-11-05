using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_POO.Enums;

/// <summary>
/// Summary description for Class1
/// </summary>
public abstract class Pessoa
{
    #region ATRIBUTOS

    /// <summary>
    /// Atributo sobre o nome da pessoa
    /// </summary>
    private string Nome { get; set; }

    /// <summary>
    /// Atributo do número de telemovel da pessoa
    /// </summary>
    public int NumTelemovel { get; set; }

    /// <summary>
    /// Atributo sobre o género da pessoa. Este é um enumerado.
    /// </summary>
    public Sexo Sexo { get; set; }

    /// <summary>
    /// Data de Nascimento da Pessoa
    /// </summary>
    private DateOnly DataNascimento { get; set; }

    /// <summary>
    /// Cidade de onde a pessoa é
    /// </summary>
    public Cidade cidade { get; set; } 

    /// <summary>
    /// Código Postal da pessoa
    /// </summary>
    public string CodigoPostal { get; set; }

    #endregion

    #region MÉTODOS

    #region PROPRIEDADES

    public string name
    {
        get { return Nome; }
        set { Nome = value; }
    }

    public DateOnly data
    {
        get { return DataNascimento}
        set { DataNascimento = value; }
    }

    #endregion

    #region CONSTRUTOR

    public Pessoa(string Nome, DateOnly DataNascimento)
    {
        this.Nome = Nome;
        this.DataNascimento= DataNascimento;

    }

    #endregion

    #region DESTRUTOR

    ~Pessoa()
    {
        Console.WriteLine($"A instância da classe para {DataNascimento} foi destruída");
    }

    #endregion

    #region OUTROS MÉTODOS

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Data de Nascimento: {DataNascimento}");
    }

    #endregion

    #endregion





}
