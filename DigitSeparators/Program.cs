using System;

namespace DigitSeparators
{
    class Program
    {
        private const int LETRA_Y_BIN = 0b01_01_10_01; // 01011001 (binário) = 89 (decimal)
        private const int LETRA_Z_HEX = 0X5_A; // 5A (hexadecimal) = 80 (decimal)
        private const int POPULACAO_ESTIMADA_BRASIL = 204_500_000;
        private const double RENDA_PER_CAPITA_BRASIL_USD = 11_208.08;

        static void Main(string[] args)
        {
            Console.WriteLine("Valor numérico de alguns caracteres ASCII");
            Console.WriteLine($"Y = {LETRA_Y_BIN}");
            Console.WriteLine($"Z = {LETRA_Z_HEX}");
            Console.WriteLine(String.Empty);
            Console.WriteLine($"População estimada do Brasil = {POPULACAO_ESTIMADA_BRASIL}");
            Console.WriteLine($"Renda per capita do Brasil (US$) = {RENDA_PER_CAPITA_BRASIL_USD}");
            Console.ReadKey();
        }
    }
}
