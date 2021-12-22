using System;

namespace console_generics
{
    class Program
    {
        static void Main(string[] args)
        {
            int i1 = 2;
            int i2 = 2;

            float f1 = 2;
            float f2 = 2;

            string s1 = "2";
            string s2 = "2";

            ComparaClass<int, int> obj1 = new ComparaClass<int, int>();
            ComparaClass<float, float> obj2 = new ComparaClass<float, float>();
            ComparaClass<string, string> obj3 = new ComparaClass<string, string>();
            ComparaClass<string, int> obj4 = new ComparaClass<string, int>();
            obj1.Compara(i1, i2);
            obj2.Compara(f1, f2);
            obj3.Compara(s1, s2);
            
            //False -> Equals compara tipo também
            obj4.Compara(s1, i1);

            Console.ReadKey();
        }

    }
}
