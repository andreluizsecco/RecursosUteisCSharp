using System;

namespace InitOnlyProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarações permitidas
            var pessoa = new Pessoa()
            {
                Nome = "André"
            };

            var pessoa2 = new Pessoa("André");

            Console.WriteLine("Init-Only");
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"Nome da pessoa: {pessoa.Nome}");
            Console.WriteLine($"Nome da pessoa: {pessoa2.Nome}");
            Console.WriteLine();

            //Operação não permitida
            //pessoa.Nome = "André";
        }
    }

    public class Pessoa
    {
        public string Nome { get; init; }

        public Pessoa() { }

        public Pessoa(string nome)
        {
            Nome = nome;
        }
    }

    public class Carro
    {
        private readonly string _modelo;

        // Atribuição permitida
        public string Modelo
        {
            get => _modelo;
            init => _modelo = value;
        }

        // Atribuição não permitida (erro de compilação)
        public string Modelo2
        {
            get => _modelo;
            set => _modelo = value;
        }
    }
}
