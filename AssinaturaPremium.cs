using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace MiniSistemaGerenciarAssinatura
{
    internal class AssinaturaPremium : Assinatura
    {
        private double valorBase;
        private double percentualAdicional;

        public AssinaturaPremium(string codigo, string nomeCliente, double valorBase, double percentualAdicional)
            :base(codigo, nomeCliente)
        {
            if (valorBase <= 0) throw new ArgumentException("Erro: valor base inválido, informe um valor base diferente.");
            if (percentualAdicional < 0) throw new ArgumentException("Erro: percentual inválido, informe um valor diferente.");

            this.valorBase = valorBase;
            this.percentualAdicional = percentualAdicional;
        }
        public double ValorBase => valorBase;
        public double PercentualAdicional => percentualAdicional;
        public override string Tipo => "Premium";

        public override double CalcularValorMensal()
        {
            double valorMensal = valorBase + valorBase * percentualAdicional;
            return valorMensal;
        }
    }
}
