using System;
using System.Linq;

namespace LocalFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string Inverter(string valor)
            {
                return new string(
                    valor.ToCharArray().Reverse().ToArray());
            }

            string texto;

            texto = "Utilizando o C#";
            Console.WriteLine($"{texto} -> {Inverter(texto)}");

            texto = "Local Function";
            Console.WriteLine($"{texto} -> {Inverter(texto)}");

            Console.ReadKey();
        }
    }
}
