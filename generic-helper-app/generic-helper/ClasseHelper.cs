using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace generic_helper
{
    class ClasseHelper<T> where T: class
    {
        public static string ObterNomeClasse() =>
            typeof(T).Name;
        public static MethodInfo ObterMetodoPorNome(string nome) =>
            typeof(T)
            .GetMethods()
            .FirstOrDefault(p => p.Name.Equals(nome, System.StringComparison.InvariantCulture));
    }
}
