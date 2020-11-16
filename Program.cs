using System;

namespace Calculadora_B_sica_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo a calculadora mágica, digite qual a operação deseja fazer ?? ( + , - , * , / )");
            string operacao = Console.ReadLine();

            Console.WriteLine("Digite o 1º valor: ");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 2º valor: ");
            float num2 = float.Parse(Console.ReadLine());

            float resultado = 0f;

            switch(operacao){
                case "+":
                    resultado = num1 + num2;
                break;

                case "-":
                    resultado = num1 - num2;
                break;

                case "*":
                    resultado = num1 * num2;
                break;

                case "/":
                    resultado = num1 / num2;
                break;

                default:
                    operacao = "invalida";
                    Console.WriteLine("Operação Inválida :c");
                break;
            }

            Console.WriteLine($"Calculo: {num1} com {num2} = {resultado}");
        }
    }
}
