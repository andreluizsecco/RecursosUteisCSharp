using System.Linq;

namespace ExtensionMethods
{
    public static class StringExtensions
    {
        public static string Revert(this string valor) =>
            new string(valor.ToCharArray().Reverse().ToArray());
    }
}
