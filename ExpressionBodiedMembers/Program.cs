namespace ExpressionBodiedMembers
{
    class ExpressionBodiedMembers
    {
        public int Quantidade { get; set; }
        public double ValorUnitario { get; set; }
        public double ValorTotal => ValorUnitario * Quantidade; // Expression-bodied Properties no C# 6.0 (read-only)

        private double _valor;

        // Utilização na definição de propriedade pelo get e set (C# 7)
        public double Valor
        {
            get => _valor;
            set => _valor = value >= 0 ? value : 0;
        }

        public double CalcularValorTotal() => ValorTotal; // Expression-bodied Functions no C# 6.0

        //Construtor (C# 7)
        public ExpressionBodiedMembers() => ValorUnitario = 10;

        //Finalizer (C# 7)
        ~ExpressionBodiedMembers() => ValorUnitario = 0;
    }
}
