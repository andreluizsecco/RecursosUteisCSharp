using System;

namespace PatternMatching
{
    class CotacaoMonetaria
    {
        public abstract class Cotacao
        {
            public DateTime DataCotacao { get; set; }
            public abstract string SiglaMoeda { get; }
            public abstract string NomeMoeda { get; }
        }

        public class CotacaoDolar : Cotacao
        {
            public override string SiglaMoeda
            { get { return "USD"; } }

            public override string NomeMoeda
            { get { return "Dólar norte-americano"; } }

            public double ValorComercial { get; set; }
            public double ValorTurismo { get; set; }
        }

        public class CotacaoEuro : Cotacao
        {
            public override string SiglaMoeda
            { get { return "EUR"; } }

            public override string NomeMoeda
            { get { return "Euro"; } }

            public double ValorCotacao { get; set; }
        }

        public class CotacaoBitcoin : Cotacao
        {
            public override string SiglaMoeda
            { get { return "BTC"; } }

            public override string NomeMoeda
            { get { return "Bitcoin"; } }

            public double ValorCotacaoMecadoBitcoin { get; set; }
        }
    }
}
