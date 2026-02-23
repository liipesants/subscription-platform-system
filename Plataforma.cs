using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace MiniSistemaGerenciarAssinatura
{
    internal class Plataforma
    {
        private List<Assinatura> assinaturas = new List<Assinatura>();
        private string nome;

        public Plataforma(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome)) throw new ArgumentException("Erro: nome da plataforma inválido, informe um nome diferente.");

            this.nome = nome;
        }
        public void AdicionarAssinatura(Assinatura assinatura)
        {
            if (!assinaturas.Any(a => a.Codigo == assinatura.Codigo))
            {
                assinaturas.Add(assinatura);
                Console.WriteLine("ASSINATURA CONTRATADA COM SUCESSO!");
            }
            else
            {
                Console.WriteLine("Erro: essa assinatura já está em vigor, contrate outra assinatura!");
            }
        }
        public void ListarAssinaturas()
        {
            int cont = 1;

            foreach (var ass in assinaturas)
            {
                Console.WriteLine($"-------| ASSINATURA: {cont} |-------");
                Console.WriteLine($"Código da Assinatura: {ass.Codigo}");
                Console.WriteLine($"Nome do Cliente: {ass.NomeCliente}");
                Console.WriteLine($"Assinatura: {ass.Tipo}");
                Console.WriteLine($"Data de Início: {ass.DataInicio}");
                Console.WriteLine($"Situação: {ass.Ativa}");
            }
        }
        public void BuscarAssinatura(string codigo)
        {
            var assinatura = assinaturas.FirstOrDefault(a => a.Codigo == codigo);

            if (assinatura == null)
            {
                Console.WriteLine("Erro: assinatura não encontrada.");
            }
            else
            {
                Console.WriteLine($"-------| ASSINATURA |-------");
                Console.WriteLine($"Código da Assinatura: {assinatura.Codigo}");
                Console.WriteLine($"Nome do Cliente: {assinatura.NomeCliente}");
                Console.WriteLine($"Assinatura: {assinatura.Tipo}");
                Console.WriteLine($"Data de Início: {assinatura.DataInicio}");
                Console.WriteLine($"Situação: {assinatura.Ativa}");
            }
        }
        public void DesativarAssinatura(string codigo)
        {
            bool achei = false;

            foreach (var ass in assinaturas)
            {
                if (ass.Codigo == codigo)
                {
                    ass.Desativar();
                    achei = true;
                }
            }
            if (!achei) Console.WriteLine("Erro: Assinatura não encontrada, informe o código de uma assinatura existente.");
        }
        public void CalcularFaturamentoMensal()
        {
            double faturamentoTotalMensal = 0;
            double faturamentoPremiumMensal = 0;
            double faturamentoBasicoMensal = 0;
            double faturamentoCorporativoMensal = 0;

            foreach (var ass in assinaturas)
            {
                if (ass.Ativa)
                {
                    faturamentoTotalMensal += ass.CalcularValorMensal();
                    if (ass.GetType() == typeof(AssinaturaBasica)) faturamentoBasicoMensal += ass.CalcularValorMensal();
                    if (ass.GetType() == typeof(AssinaturaCorporativa)) faturamentoCorporativoMensal += ass.CalcularValorMensal();
                    if (ass.GetType() == typeof(AssinaturaPremium)) faturamentoPremiumMensal += ass.CalcularValorMensal();
                }
            }

            Console.WriteLine("------| FATURAMENTO MENSAL DETALHADO |------");
            Console.WriteLine($"Assinatura Básica: {faturamentoBasicoMensal}");
            Console.WriteLine($"Assinatura Premium: {faturamentoPremiumMensal}");
            Console.WriteLine($"Assinatura Corporativa: {faturamentoCorporativoMensal}");
            Console.WriteLine($"FATURAMENTO TOTAL: {faturamentoTotalMensal}");
        }
    }
}
