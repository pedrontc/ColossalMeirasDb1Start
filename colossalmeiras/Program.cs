using System;

namespace Colossalmeiras
{
    class Program
    {
        static void Main()
        {
            string resposta;
            bool continuar = true;
            PalmeirasHistoria palmeirasHistoria = new PalmeirasHistoria();

            Console.WriteLine("Bem vindo ao projeto colossalmeiras, aqui iremos disponibilizar para você informações sobre a Sociedade Esportiva Palmeiras entre os anos de 2015 à 2022");
            Console.WriteLine();

            // ...

            while (continuar)
            {
                Console.Write("Digite o ano que você deseja saber mais sobre o Palmeiras (2015 a 2022): ");

                if (int.TryParse(Console.ReadLine(), out int anoEscolhido))
                {
                    palmeirasHistoria.ExibirInformacoesAno(anoEscolhido);

                    // Solicitar ao usuário para cadastrar uma lembrança
                    Console.Write("Você tem alguma lembrança boa para cadastrar? (s para sim, n para não): ");
                    resposta = Console.ReadLine();

                    if (resposta.ToLower() == "s")
                    {
                        // Solicitar ao usuário para inserir a lembrança
                        Console.Write("Digite sua lembrança boa com o Palmeiras: ");
                        string lembrancaDescricao = Console.ReadLine();

                        // Adicionar a lembrança à lista
                        palmeirasHistoria.AdicionarLembranca(anoEscolhido, lembrancaDescricao);

                        Console.WriteLine("Lembrança cadastrada com sucesso!");
                    }

                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Por favor, digite um ano válido.");
                }

                Console.WriteLine("Você deseja ver outro ano? s para continuar, n para encerrar");
                resposta = Console.ReadLine();

                if (resposta.ToLower() != "s")
                {
                    continuar = false;
                }
            }

            // Exibir as lembranças cadastradas ao final do programa
            palmeirasHistoria.ExibirLembrancas();
        }
    }
}

