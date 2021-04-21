using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var dados = new List<Pessoa>
            {
                new Pessoa(20, "Paulo", new DateTime(1987, 3, 4)),
                new Pessoa(60, "Jorge", new DateTime(1991, 12, 19)),
                new Pessoa(1, "João", new DateTime(1999, 5, 20)),
                new Pessoa(1008, "Marcos", new DateTime(2003, 10, 7))
            };

            Console.WriteLine("Pessoas nascidas até 1999 por ordem alfabética");
            Console.WriteLine();
            var pessoas = dados
                .Where(d => d.DataNascimento.Year <= 1999)
                .OrderBy(d => d.Nome)
                .ToList();

            pessoas.ForEach(p => Console.WriteLine(p.ToString()));

            Console.WriteLine();
            Console.WriteLine("---------------------------------");
            Console.WriteLine();

            Console.WriteLine("Pessoas nascidas antes do décimo dia do mês");
            Console.WriteLine();
            pessoas = dados
                .Where(d => d.DataNascimento.Day < 10)
                .ToList();

            pessoas.ForEach(p => Console.WriteLine(p.ToString()));

            Console.WriteLine();
            Console.WriteLine("---------------------------------");
            Console.WriteLine();

            Console.WriteLine("As 3 últimas pessoas cadastradas");
            Console.WriteLine();
            pessoas = dados
                .OrderByDescending(d => d.Codigo)
                .Take(3)
                .ToList();

            pessoas.ForEach(p => Console.WriteLine(p.ToString()));
        }
    }

    class Pessoa
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        public Pessoa(int codigo, string nome, DateTime dataNascimento)
        {
            Codigo = codigo;
            Nome = nome;
            DataNascimento = dataNascimento;
        }

        public override string ToString() =>
            $"Código: {Codigo} | Nome: {Nome} | Nascimento: {DataNascimento.ToShortDateString()}";
    }
}
