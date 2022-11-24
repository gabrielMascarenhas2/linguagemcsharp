using System;

namespace TipoByte
{
    class Program
    {
        static void Main(string[] args)
        {
            byte x;
            try
            {
                byte x = Convert.ToByte(Console.ReadLine());
                   Console.WriteLine("os valores digitais são: {0}", x)
            }
            catch (OverflowException)
            {
                   Console.WriteLine("o valor digitado está fora o maximo. o maximo é 255");
               
            }
            catch (FormatException)
            {
                   Console.WriteLine("voce digitou um texto. só é aceitavel um numero de 0 a 255");

            }





}
               
        }
    }
}
