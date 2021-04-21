using System;

namespace Tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            double temperatura;
            double umidade;

            //Vetor
            var valoresVetor = LeituraSensorVetor();
            temperatura = valoresVetor[0];
            umidade = valoresVetor[1];

            ExibirResultados(temperatura, umidade);

            //Classe
            var valoresClasse = LeituraSensorClasse();
            temperatura = valoresClasse.Temperatura;
            umidade = valoresClasse.Umidade;

            ExibirResultados(temperatura, umidade);

            //Tupla
            var valoresTupla = LeituraSensorTupla();
            temperatura = valoresTupla.temperatura;
            umidade = valoresTupla.umidade;

            ExibirResultados(temperatura, umidade);

            //Tupla - Desconstrução
            (temperatura, umidade) = LeituraSensorTupla();

            ExibirResultados(temperatura, umidade);

            //Tupla - Desconstrução e discard
            umidade = 0;
            (temperatura, _) = LeituraSensorTupla();

            ExibirResultados(temperatura, umidade);


            Console.ReadKey();
        }

        private static double[] LeituraSensorVetor()
        {
            var temperatura = 23.5;
            var umidade = 65.5;

            return new double[] { temperatura, umidade };
        }

        private static ValoresSensor LeituraSensorClasse()
        {
            var temperatura = 23.5;
            var umidade = 65.5;

            var valores = new ValoresSensor();
            valores.Temperatura = temperatura;
            valores.Umidade = umidade;

            return valores;
        }

        class ValoresSensor
        {
            public double Temperatura { get; set; }
            public double Umidade { get; set; }
        }

        private static(double temperatura, double umidade) LeituraSensorTupla()
        {
            var temperatura = 23.5;
            var umidade = 65.5;

            return (temperatura, umidade);
        }

        private static void ExibirResultados(double temperatura, double umidade)
        {
            Console.WriteLine($"Temperatura: {temperatura}");
            Console.WriteLine($"Umidade: {umidade}");
            Console.WriteLine(new String('-', 40));
        }
    }
}
