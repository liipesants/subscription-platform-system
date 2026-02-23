using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace MiniSistemaGerenciarAssinatura
{
    internal class AssinaturaCorporativa : Assinatura
    {
        private double valorPorUser;
        private int quantidadeUser;

        public AssinaturaCorporativa(string codigo, string nomeCliente, double valorPorUser, int quantidadeUser)
            :base(codigo, nomeCliente)
        {
            if (valorPorUser <= 0) throw new ArgumentException("Erro: valor por usuário inválido, informe um valor diferente.");
            if (quantidadeUser <= 0) throw new ArgumentException("Erro: quantidade de usuário inválida, informe uma quantidade diferente.");

            this.valorPorUser = valorPorUser;
            this.quantidadeUser = quantidadeUser;
        }
        public double ValorPorUser => valorPorUser;
        public int QuantidadeUser => quantidadeUser;
        public override string Tipo => "Corporativa";
        public override double CalcularValorMensal()
        {
            return valorPorUser * quantidadeUser;
        }
    }
}
