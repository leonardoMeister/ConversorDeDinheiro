using System;

namespace ConversorDeDinheiro.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ConversorDinheiro aux = new ConversorDinheiro("2.101.283,99");
            Console.WriteLine(aux.auxValor);
            Console.WriteLine("\n");

            aux = new ConversorDinheiro("3.222.101.283,11");
            Console.WriteLine(aux.auxValor);
            Console.WriteLine("\n");

            aux = new ConversorDinheiro("1.283,11");
            Console.WriteLine(aux.auxValor);
            Console.WriteLine("\n");

            aux = new ConversorDinheiro("123.013,01");
            Console.WriteLine(aux.auxValor);
            Console.WriteLine("\n");

            aux = new ConversorDinheiro("3,41");
            Console.WriteLine(aux.auxValor);
            Console.WriteLine("\n");

            aux = new ConversorDinheiro("111.039.101.201,10");
            Console.WriteLine(aux.auxValor);
            Console.WriteLine("\n");
        }
    }
}