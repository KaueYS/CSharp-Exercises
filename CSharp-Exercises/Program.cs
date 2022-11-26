using System;

namespace CSharp_Exercises
{
    internal class Program
    {

        static void Main(string[] args)
        {

            // declarar variaveis
            Console.WriteLine("Digite seu nome: ");
            string name = Console.ReadLine();

            int message = 3;
            double tempC = 34.4;
            double tempF = 94;
            double celsius = (tempF - 32) * 5 / 9;

            // intepolacao

            Console.WriteLine($"Olá, {name}!, Voce tem {message} mensagens na sua caixa de entrada. " +
                $"A temperatura para hoje é de {tempC} C");

            Console.WriteLine($"A conversão de 94 farenheit para celsius : {celsius.ToString("F2")} celsius");

            Console.WriteLine();

            // if/else
            Random random = new Random();
            int daysUntilExpiration = random.Next(12);
            int discountPercentage = 0;

            Console.WriteLine(daysUntilExpiration);


            if (daysUntilExpiration == 0)
            {
                Console.WriteLine("Your subscription has expired.");
            }
            else if (daysUntilExpiration == 1)
            {
                discountPercentage = 20;
                Console.WriteLine("Your subscription expires within a day!");
                Console.WriteLine($" Renew now and save {discountPercentage}%");
            }
            else if (daysUntilExpiration > 1 && daysUntilExpiration <= 5)
            {
                discountPercentage = 10;
                Console.WriteLine($" Your subscription expires in {daysUntilExpiration} days.");
                Console.WriteLine($" Renew now and save {discountPercentage}% ");
            }
            else if (daysUntilExpiration > 5 && daysUntilExpiration < 10)
            {
                Console.WriteLine("Your subscription will expire soon. Renew now!");
            }
            else
            {
                Console.WriteLine(" Your subscription will not expire soon!");
            }
            
        }
    }
}
