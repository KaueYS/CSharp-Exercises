using System;

namespace CSharp_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome: ");
            string name = Console.ReadLine();
            
            int message = 3;
            double tempC = 34.4;
            double tempF = 94;
            double celsius = (tempF - 32) * 5 / 9;



            Console.WriteLine($"Olá, {name}!, Voce tem {message} mensagens na sua caixa de entrada. " +
                $"A temperatura para hoje é de {tempC} C");
            
            Console.WriteLine($"A conversão de 94 farenheit para celsius : {celsius.ToString("F2")} celsius");
        }
    }
}
