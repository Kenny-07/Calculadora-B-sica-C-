using System;

namespace Calculadora_B_sica_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo a tabuada mágica, digite qual número você quer a tabuada: ");
            int v = int.Parse( Console.ReadLine());

            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine($"{v} x {i} = {v * i}");
            }

        }
    }
}
