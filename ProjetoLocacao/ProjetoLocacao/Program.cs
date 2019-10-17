using System;
using ProjetoLocacao.Model;

namespace ProjetoLocacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            TabelaPrecoModel tb = new TabelaPrecoModel
            {
                IdTabela = 1,
                Descricao = "Duas Portas Com Ar",
                ValorDiaria = 200.00f
            };
        }
    }
}
