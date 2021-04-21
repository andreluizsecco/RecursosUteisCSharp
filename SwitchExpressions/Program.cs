using System;

namespace SwitchExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo 1
            var fonteDados = FonteDados.APIExterna;

            var dados = fonteDados switch
            {
                FonteDados.BancoDeDados => BuscarDadosBD(),
                FonteDados.APIExterna => BuscarDadosAPI(),
                _ => "Não há um comportamento definido para essa fonte de dados"
            };

            Console.WriteLine($"Dados: {dados}");

            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine();

            // Exemplo 2

            Console.WriteLine($"Temperatura: -5ºC => {AvaliarCondicao(-5)}");
            Console.WriteLine($"Temperatura: 13ºC => {AvaliarCondicao(13)}");
            Console.WriteLine($"Temperatura: 22ºC => {AvaliarCondicao(22)}");
            Console.WriteLine($"Temperatura: 29ºC => {AvaliarCondicao(29)}");
            Console.WriteLine($"Temperatura: 40ºC => {AvaliarCondicao(40)}");
            Console.WriteLine($"Temperatura: 100ºC => {AvaliarCondicao(100)}");
        }

        enum FonteDados
        {
            BancoDeDados,
            APIExterna
        }

        static string BuscarDadosBD()
        {
            //Implementação de busca no banco de dados

            return "Dados do BD";
        }

        static string BuscarDadosAPI()
        {
            //Implementação de busca na API

            return "Dados da API";
        }


        static string AvaliarCondicao(double temperatura) =>
            temperatura switch
            {
                < 0 => "Muito frio",
                > 0 and <= 17 => "Frio",
                > 18 and <= 26 => "Ameno",
                > 26 and <= 30 => "Calor",
                > 30 and <= 50 => "Muito Calor",
                _ => "Sem classificação"
            };
    }
}
