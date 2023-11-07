using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO.Enums
{
    public enum Sexo
    {
        Masculino,
        Feminino
    };

    public enum Cidade
    {
        Braga,
        Porto,
        Lisboa,
        Guimaraes,
        Famalicao,
        Barcelos
    };

    public enum Funcao
    {
        Triagem,
        AdministracaoMedicamento,
        MonitoramentoPacientesObservacao,
        CoordenacaoCuidados,
        ProcedimentoMedicos
    };

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

    public enum Gravidade
    {
        PoucoGrave = 1,
        Grave = 2,
        MuitoGrave = 3
    };
}
