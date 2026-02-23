namespace MiniSistemaGerenciarAssinatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Plataforma plataforma = new Plataforma("LipeFlix");

            AssinaturaBasica assinaturaBasica;
            double valorMensal;

            AssinaturaPremium assinaturaPremium;
            double valorBase;
            double percentualAdicional;

            AssinaturaCorporativa assinaturaCorporativa;
            double valorPorUser;
            int quantidadeUser;

            bool sair = false;
            int opcao;
            string codigo;
            string nomeCliente;


            do
            {
                Console.WriteLine("1 - CRIAR ASSINATURA BÁSICA");
                Console.WriteLine("2 - CRIAR ASSINATURA PREMIUM");
                Console.WriteLine("3 - CRIAR ASSINATURA CORPORATIVA");
                Console.WriteLine("4 - LISTAR ASSINATURAS");
                Console.WriteLine("5 - BUSCAR ASSINATURA");
                Console.WriteLine("6 - DESATIVAR ASSINATURA");
                Console.WriteLine("7 - FATURAMENTO TOTAL");
                Console.WriteLine("8 - SAIR");
                Console.Write("Escolha a opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:

                        Console.Write("Informe o código da assinatura: ");
                        codigo = Console.ReadLine();
                        Console.Write("Informe o nome do cliente: ");
                        nomeCliente = Console.ReadLine();
                        Console.Write("Informe o valor mensal da assinatura: ");
                        valorMensal = double.Parse(Console.ReadLine());

                        assinaturaBasica = new AssinaturaBasica(codigo, nomeCliente, valorMensal);
                        plataforma.AdicionarAssinatura(assinaturaBasica);

                        break;

                    case 2:

                        Console.Write("Informe o código da assinatura: ");
                        codigo = Console.ReadLine();
                        Console.Write("Informe o nome do cliente: ");
                        nomeCliente = Console.ReadLine();
                        Console.Write("Informe o valor base da assinatura: ");
                        valorBase = double.Parse(Console.ReadLine());
                        Console.Write("Informe o percentual adicional da assinatura: ");
                        percentualAdicional = double.Parse(Console.ReadLine());

                        assinaturaPremium = new AssinaturaPremium(codigo, nomeCliente, valorBase, percentualAdicional);
                        plataforma.AdicionarAssinatura(assinaturaPremium);

                        break;

                    case 3:

                        Console.Write("Informe o código da assinatura: ");
                        codigo = Console.ReadLine();
                        Console.Write("Informe o nome do cliente: ");
                        nomeCliente = Console.ReadLine();
                        Console.Write("Informe o valor por usuário: ");
                        valorPorUser = double.Parse(Console.ReadLine());
                        Console.Write("Informe o número de usuário: ");
                        quantidadeUser = int.Parse(Console.ReadLine());

                        assinaturaCorporativa = new AssinaturaCorporativa(codigo, nomeCliente, valorPorUser, quantidadeUser);
                        plataforma.AdicionarAssinatura(assinaturaCorporativa);

                        break;

                        case 4:

                        plataforma.ListarAssinaturas();

                        break;

                    case 5:

                        Console.Write("Informe o código da assinatura: ");
                        codigo = Console.ReadLine();

                        plataforma.BuscarAssinatura(codigo);

                        break;

                        case 6:

                        Console.Write("Informe o código da assinatura que você deseja desativar: ");
                        codigo = Console.ReadLine();

                        plataforma.DesativarAssinatura(codigo);

                        break;

                    case 7:

                        plataforma.CalcularFaturamentoMensal();

                        break;

                    case 8:

                        sair = true;

                        break;
                }

            } while (!sair);
        }
    }
}
