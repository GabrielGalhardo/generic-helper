using System;

namespace generic_helper
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaBase pessoa = new Pessoa(1, "Gabriel", 20);
            var metodo = ClasseHelper<Pessoa>.ObterMetodoPorNome("PossuiMaiorIdade");
            var maiorIdade = metodo.Invoke(pessoa, null);
            Console.WriteLine($"Possui maior idade:  { maiorIdade}");
        }
    }
    public abstract class PessoaBase { }
    public class Pessoa : PessoaBase
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa(int id, string nome, int idade)
        {
            Id = id;
            Nome = nome;
            Idade = idade;
        }
        public bool PossuiMaiorIdade() =>
            Idade >= 18;
    }
}
