 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_generics
{
    public class ComparaClass <T, U>
    {
        public void Compara(T p1, U p2) 
        {
            bool resultado;
            resultado = p1.Equals(p2);
            Console.WriteLine($"Os parâmetros são iguais? {resultado}");
        }
    }
}
