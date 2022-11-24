using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro valor: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int r = a * b; 
            Console.WriteLine("O resultado é: ",r);
        }
    }
}
