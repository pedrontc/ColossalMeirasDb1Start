using System;
using System;
using System.Collections.Generic;

class LembrancaBoa
{
    public int Ano { get; set; }
    public string Descricao { get; set; }
}
class AnoHistorico
{
    public int Ano { get; set; }
    public string ApresentacaoDoAno { get; set; }
    public string CampeonatosDisputados { get; set; }
    public string Classificacao { get; set; }
    public string Estatisticas { get; set; }
    public string InformacoesClube { get; set; }
}

class PalmeirasHistoria
{
    private List<AnoHistorico> anos;
    private List<LembrancaBoa> lembrancas;
    public PalmeirasHistoria()
    {
        anos = new List<AnoHistorico>
        {
    

            new AnoHistorico
            {
                Ano = 2015,
                ApresentacaoDoAno = "\nO ano de 2015 ficou marcado pelo começo de uma nova era no clube, contando com um novo patrocinador master (crefisa), como seu recém inaugurado estadio e com a chegada de novos jogadores ao clube, sendo a mais importante delas do jogador Dudu, na qual faz parte do elenco até hoje (2023), se tornando um dos maiores ídolo da história do clube alviverde",
                CampeonatosDisputados = "\nCampeonato Paulista | Copa do Brasil | Campeonato Brasileiro",
                Classificacao = "\n1º lugar na Copa do Brasil (campeão), | 2º lugar no Campeonato Paulista, | 9º lugar no Brasileirão",
                Estatisticas = "\nJ: 70 | V: 35 (15 Brasileirão, 12 Paulistão, 8 Copa do Brasil): | D:22 (15 Brasileirão, 5 Paulistão, 2 Copa do Brasil) | E: 13 (8 Brasileirão, 2 Paulistão, 3 Copa do Brasil), | Artilheiro: Dudu 16, | Mais assistencias: Robinho 14",
                InformacoesClube = "\nContratações no ano: 29, | Titulos no ano: 1 (copa do Brasil) | obs: Neste ano o clube alviver disputou duas finais com um dos seus rivais, o Santos, perdendo o campeonato Paulista e vencendo a Copa do Brasil",



            },
            new AnoHistorico
            {
                Ano = 2016,
                ApresentacaoDoAno = "\nO ano de 2016 foi extremamente importante para o torcedor alviverde pois foi o ano em que a Sociedade Esportiva Palmeiras se sagrou campeã do campeonato Brasileiro, taça que não era conquistada pelo clube a 22 anos",
                CampeonatosDisputados = "\nEm 2016, por ganhar a copa do Brasil 2015, o Palmeiras teve acesso a uma vaga na Copa Libertadores da América, disputando além deste o Campeonato Paulista, o Brasileirão e a Copa do Brasil",
                Classificacao = "\nSaiu nas quartas de finais da Copa do Brasil, Saiu na semi final do Campeonato Paulista e foi campeão do campeonato Brasileiro (Brasileirão)",
                Estatisticas = "\nJ: 65 | V: 35 (24 Brasileirão, 8 Paulistão, 2 copa libertadores, 1 Copa do Brasil) | D:15 (6 Brasileirão, 5 Paulistão, 2 copa libertadores, 2 copa do Brasil) | E: 15 (8 Brasileirão, 4 Paulistão, 2 copa Libertadores, 1 Copa do Brasil), | Artilheiro: Gabriel Jesus 21, | Mais assistencias: Dudu 13",
                InformacoesClube =  "\nContratações: 18, | Titulos no ano: 1 (campeonato Brasileiro)"

            },

           new AnoHistorico
            {
                Ano = 2017,
                ApresentacaoDoAno = "\nO início da temporada de 2017 viu o Palmeiras se destacar como a grande sensação do cenário futebolístico brasileiro, pois o clube tinha ganho o campeonato brasileiro do ano anterior, mas contrariando todas as expectativas da torcida e da imprensa o clube não conseguiu ser campeão de nenhuma competição disputada naquele ano",
                CampeonatosDisputados = "\nCampeonato Paulista | Copa do Brasil | Campeonato Brasileiro | Copa Libertadores da América",
                Classificacao = "\nTerminou na vice colocação do Brasileiro, foi liminado na semi final no Campeonato Paulista, nas quarta de final na copa do Brasil e nas oitavas de finai da Libertadores",
                Estatisticas ="\nJ: 68 | V: 36 (11 Campeonato Paulista, 19 Brasileirão, 5 Copa libertadores, 1 Copa do Brasil): | D:20 (13 Brasileirão, 4 Paulistão, 1 Copa do Brasil, 2 Copa libertadores | E: 12 (1 Paulistão, 1 Libertadores, 6 Brasileirão, 2 Copa do Brasil, | Artilheiro: Willian 17 | Mais assistências: Dudu 8",
                InformacoesClube = "\nContratações: 14, | Titulos no ano: 0",
            },
           new AnoHistorico
            {
                Ano = 2018,
                ApresentacaoDoAno = "O ano de 2018 foi marcado pela conquista de mais uma campeonato Brasileiro, ampliando ainda mais a vantagem do Palmeiras como maior campeão do Brasil",
                CampeonatosDisputados = "\nCampeonato Paulista | Copa do Brasil | Campeonato Brasileiro | Copa Libertadores da América",
                Classificacao = "Campeão Brasileiro. Ficou em 2º no campeonato Paulista, saiu na semifinais de Copa do Brasil e da Libertadores",
                Estatisticas = "\nJ: 74  | V: 45 (12 Campeonato Paulista, 23 Brasileirão, 8 Copa libertadores, 2 Copa do Brasil): | D:20 (4 Brasileirão, 4 Paulistão, 1 Copa do Brasil, 2 Copa libertadores | E: 11 (4  Paulistão, 2 Libertadores, 4 Brasileirão, 1 Copa do Brasil | Artilheiro: Borja 20 | Mais assistências: Dudu 8",
                InformacoesClube = "\nContratações: 15, | Titulos no ano: 1 (Brasileirão)",

            },
           new AnoHistorico
            {
                Ano = 2019,
                ApresentacaoDoAno =  "\nA temporada de 2019 foi a 105ª da existência da Sociedade Esportiva Palmeiras . Nesta temporada o Palmeiras participou do Campeonato Paulista , Copa Libertadores , Copa do Brasil e Série A.",
                CampeonatosDisputados = "Campeonato Paulista | Copa do Brasil | Campeonato Brasileiro | Copa Libertadores da América",
                Classificacao = "\n3º no Brasileirão, saiu nas quartas de final da Copa do Brasil e da Libertadores. No campeonato Paulista o clube alviver saiu na semifinais",
                Estatisticas = "\nJ: 68 | V: 39 (8  Campeonato Paulista, 21 Brasileirão, 7 Copa libertadores, 3 Copa do Brasil): | D:10 (6 Brasileirão, 1 Paulistão, 1 Copa do Brasil, 2 copa libertadores | E: 19  (7 Paulistão, 1 Libertadores, 11 Brasileirão, | Artilheiro: Gustavo Scarpa 13 | Mais assistências: Dudu 8",
                InformacoesClube = "\nContratações: 18, | Titulos no ano: 0",
            },
           new AnoHistorico
            {
                Ano = 2020,
                ApresentacaoDoAno = "\nA temporada de 2020 da Sociedade Esportiva Palmeiras marcou o 106º ano de história do clube. Destacando-se como uma das temporadas mais bem-sucedidas para o Palmeiras, o time foi campeão da Florida Cup, do Campeonato Paulista, da Copa Libertadores da América e da Copa do Brasil",
                CampeonatosDisputados = "\nFlorida Cup | Campeonato Paulista | Copa do Brasil | Campeonato Brasileiro | Copa Libertadores da América | Mundial de Clubes",
                Classificacao = "\nCampeão da Florida Cup, Campeonato Paulista, Copa Libertadores da América e da Copa do Brasil. No campeonato Brasileiro o clube alviverde ficou na 7º colocação e em 4º no Mundial de Clubes",
                Estatisticas ="\nJ: 79 | V: 40 (1 florida Cup, 8 Paulistão, 15 Brasileirão, 10 copa libertadores, 6 Copa do Brasil): | D:14 (10 Brasileirão, 2 Paulistão, 1 copa libertadores, 1 Mundial de Clubes) | E: 25 (1 Florida Cup, 6 Paulistão, 2 Libertadores, 13 Brasileirão, 2 Copa do Brasil, 1 Mundial de Clubes) | Artilheiro: Luiz Adriano 20 | Mais assistências: Rony 9",
                InformacoesClube = "\nContratações: 9, | Titulos no ano: 4 (Florida Cup, Paulistão, Libertadores e Copa do Brasil)",
            },
           new AnoHistorico
            {
                Ano = 2021,
                ApresentacaoDoAno = "\nA temporada de 2021 da Sociedade Esportiva Palmeiras representou a 107ª na história do clube. O Alviverde conquistou o título da Copa Libertadores da América, destacando-se também por sua participação na Supercopa do Brasil, na Recopa Sul-Americana, no Campeonato Paulista, na Copa do Brasil e no Campeonato Brasileiro Série A.",
                CampeonatosDisputados = "\nPaulistão | Libertadores | Brasileirão | Copa do Brasil | Recopa Sul-Americana | Super Copa do Brasil",
                Classificacao = "\nCampeão da Libertadores. 2º no Paulistão, 3º no Brasileirão, saiu na 3º fase da Copa do Brasil, 2º Recopa Sul-Americana e 2º na Super Copa do Brasil",
                Estatisticas = "\nJ: 72 | V: 39 (8 Paulistão, 20 Brasileirão, 9 copa libertadores, 1 Copa do Brasil, 1 Recopa): | D:19 (12 Brasileirão, 4 Paulistão, 1 Copa libertadores, 1 Copa do Brasil, 1 Recopa) | E: 14 (4 Paulistão, 3 Libertadores, 6 Brasileirão, 1 Supercopa, | Artilheiro: Raphael Veiga 18 | Mais assistências: Gustavo Scarpa 20",
                InformacoesClube = "\nContratações: 8, | Titulos no ano: 1 (Copa Libertadores da América)",
            },
           new AnoHistorico
            {
                Ano = 2022,
                ApresentacaoDoAno = "\nA temporada da Sociedade Esportiva Palmeiras de 2022 foi a 108ª na história do clube. O Alviverde sagrou-se campeão em três competições: o Campeonato Brasileiro (onde teve seu 11º título confirmado na 35ª rodada), a Recopa Sul-Americana e o Campeonato Paulista. Conseguiu o vice-campeonato no Mundial de Clubes, além de ter disputado também a Copa do Brasil e a Copa Libertadores da América",
                CampeonatosDisputados = "\nPaulistão, | Libertadores, | Brasileirão, | Copa do Brasil, | Recopa Sul-Americana, | Mundial de Clubes",
                Classificacao = "\nCampeão do Paulistão, da Recopa e do Brasileirão. 2º no Mundial de Clubes, saiu na semifinal na libertadores e nas oitavas de final da Copa do Brasil",
                Estatisticas ="\nJ: 74 | V: 48 (12 Paulistão, 23 Brasileirão, 8 copa libertadores, 3 Copa do Brasil, 1 Recopa, 1 Mundial de Clubes): | D:7 (3 Brasileirão, 1 Paulistão, 1 Copa libertadores, 1 Copa do Brasil, 1 Mundial de Clubes) | E: 14 (4 Paulistão, 3 Libertadores, 6 Brasileirão, 1 Supercopa, | Artilheiro: Raphael Veiga 18 | Mais assistências: Gustavo Scarpa 20",
                InformacoesClube = "\nContratações: 8, | Titulos no ano: 3 (Libertadores, Recopa e Paulistão)",
            },
        };
        lembrancas = new List<LembrancaBoa>();
    }
    public void ExibirLembrancas()
    {
        if (lembrancas.Count > 0)
        {
            Console.WriteLine("\nLembranças Cadastradas:\n");
            foreach (var lembranca in lembrancas)
            {
                Console.WriteLine($"Ano: {lembranca.Ano}, Lembrança: {lembranca.Descricao}");
            }
        }
        else
        {
            Console.WriteLine("\nNenhuma lembrança cadastrada.");
        }
    }
    public void ExibirInformacoesAno(int ano)
    {
        AnoHistorico anoSelecionado = anos.Find(a => a.Ano == ano);

        if (anoSelecionado != null)
        {
            Console.WriteLine($"História do Palmeiras em {anoSelecionado.Ano}.\n");
            Console.WriteLine($"{anoSelecionado.ApresentacaoDoAno}.\n");
            Console.WriteLine($"Campeonatos Disputados: {anoSelecionado.CampeonatosDisputados}.\n");
            Console.WriteLine($"Classificação: {anoSelecionado.Classificacao}.\n");
            Console.WriteLine($"Estatísticas: {anoSelecionado.Estatisticas}.\n");
            Console.WriteLine($"Informações do Clube: {anoSelecionado.InformacoesClube}.\n");
        }
        else
        {
            Console.WriteLine($"Informações para o ano {ano} não encontradas.");
        }
    }

    public void AdicionarLembranca(int ano, string descricao)
    {
        LembrancaBoa novaLembranca = new LembrancaBoa
        {
            Ano = ano,
            Descricao = descricao
        };

        lembrancas.Add(novaLembranca);
    }
}
