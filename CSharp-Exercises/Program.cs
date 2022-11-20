using System;

namespace CSharp_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Kaue";
            int message = 3;
            double tempC = 34.4;
            double tempF = 94;
            double celsius = (tempF - 32) * 5 / 9;



            Console.WriteLine($"Olá, {name}!, Voce tem {message} mensagens na sua caixa de entrada. A temperatura é de {tempC}");

            Console.WriteLine($"A temperatura é de {celsius.ToString("F2")} celsius");
        }
    }
}
