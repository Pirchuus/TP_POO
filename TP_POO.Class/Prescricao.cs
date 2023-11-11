using System;

namespace TP_POO.Class
{
    public class Prescricao
    {
        #region ATRIBUTOS

        /// <summary>
        /// Medicamento presente na prescição que o médico realizou aquele utente
        /// </summary>
        public string Medicamento { get; set; }

        /// <summary>
        /// Dosagem passada para o utente daquele(s) medicamento(s) que lhe foi prescrito
        /// </summary>
        public double Dosagem { get; set; }

        /// <summary>
        /// Instruções corretas para que o utente tome o medicamento de forma certa
        /// </summary>
        public string Instrucoes { get; set; }

        #endregion

        #region MÉTODOS

        // Método para exibir o que foi feito na prescrição.
        public void ExibirPrescricao()
        {
            Console.WriteLine($"Medicamento: {Medicamento}");
            Console.WriteLine($"Dosagem: {Dosagem}");
            Console.WriteLine($"Instruções: {Instrucoes}");
        }

        #region CONSTRUTOR
        public Prescricao(string medicamento, double dosagem, string instrucoes)
        {
            Medicamento = medicamento;
            Dosagem = dosagem;
            Instrucoes = instrucoes;
        }

        #endregion
        #endregion
    }
}
