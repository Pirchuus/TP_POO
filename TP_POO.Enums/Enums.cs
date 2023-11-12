namespace TP_POO.Enums
{
    /// <summary>
    /// Represents the gender of an individual.
    /// </summary>
    public enum Sexo
    {
        Masculino,
        Feminino
    };

    /// <summary>
    /// Represents different cities.
    /// </summary>
    public enum Cidade
    {
        Braga,
        Porto,
        Lisboa,
        Guimaraes,
        Famalicao,
        Barcelos
    };

    /// <summary>
    /// Represents various functions within a medical context.
    /// </summary>
    public enum Funcao
    {
        Triagem,
        AdministracaoMedicamento,
        MonitoramentoPacientesObservacao,
        CoordenacaoCuidados,
        ProcedimentoMedicos
    };

    /// <summary>
    /// Represents medical specialties.
    /// </summary>
    public enum Especialidade
    {
        Cardiologia,
        MedicinaGeral,
        Ortopedia,
        Pediatria,
        Dermatologia,
        Oncologia,
        Psiquiatria,
        Neurologia
    };

    /// <summary>
    /// Represents the severity of a medical condition.
    /// </summary>
    public enum Gravidade
    {
        PoucoGrave = 1,
        Grave = 2,
        MuitoGrave = 3
    };
}
