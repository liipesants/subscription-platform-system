using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MiniSistemaGerenciarAssinatura
{
    internal class Assinatura
    {
        protected string codigo;
        protected string nomeCliente;
        protected bool ativa;
        protected DateTime dataInicio;

        public Assinatura(string codigo, string nomeCliente)
        {
            if (string.IsNullOrWhiteSpace(codigo)) throw new ArgumentException("Erro: código inválido, informe um código diferente.");
            if (string.IsNullOrWhiteSpace(nomeCliente)) throw new ArgumentException("Erro: nome inválido, informe um nome diferente.");

            this.codigo = codigo;
            this.nomeCliente = nomeCliente;
            this.ativa = true;
            this.dataInicio = DateTime.Now;
         }
        public string Codigo => codigo;
        public string NomeCliente => nomeCliente;
        public bool Ativa => ativa;
        public DateTime DataInicio => dataInicio;
        public virtual string Tipo => "Irresoluta";

        public void Desativar()
        {
            if (!Ativa) throw new InvalidOperationException("Erro: assinatura já se encontra desativada.");

            Console.WriteLine("ASSINATURA DESATIVADA COM SUCESSO!");
            ativa = false;
        }
        public void Reativar()
        {
            if (Ativa) throw new InvalidOperationException("Erro: assinatura já se encontra ativa.");

            Console.WriteLine("ASSINATURA REATIVADA COM SUCESSO!");
            ativa = true;
        }
        public virtual double CalcularValorMensal()
        {
            return 0;
        }
    }
}
