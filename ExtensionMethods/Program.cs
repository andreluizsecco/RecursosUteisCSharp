using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var mensagem = "Hello World!";
            var mensagemInvertida = mensagem.Revert();
            Console.WriteLine($"Mensagem original: {mensagem}");
            Console.WriteLine($"Mensagem invertida: {mensagemInvertida}");
        }
    }
}
