using System.Linq;
using System.Reflection;

namespace Generics
{
    public static class ClasseHelper<T> where T: class
    {
        public static string ObterNomeClasse() =>
            typeof(T).Name;

        public static MethodInfo ObterMetodoPorNome(string nome) =>
            typeof(T)
            .GetMethods()
            .FirstOrDefault(p => p.Name.Equals(nome, System.StringComparison.InvariantCultureIgnoreCase));
    }
}
