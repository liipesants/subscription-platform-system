using System;
using System.Collections.Generic;
using System.Text;

namespace MiniSistemaGerenciarAssinatura
{
    internal class AssinaturaBasica : Assinatura
    {
        private double valorMensal;

        public AssinaturaBasica(string codigo, string nomeCliente, double valorMensal)
            : base(codigo, nomeCliente)
        {
            if (valorMensal <= 0) throw new ArgumentException("Erro: valor mensal inválido, informe um valor diferente.");

            this.valorMensal = valorMensal;
        }
        public double ValorMensal => valorMensal;
        public override string Tipo => "Básica";

        public override double CalcularValorMensal()
        {
            return ValorMensal;
        }
    }
}
