using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Vamos calcular o índice de massa corporal?");
            Console.WriteLine(" pressione enter para continuar:");
            Console.ReadKey();

            Console.WriteLine("Informe o peso em kg.");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a altura em metros");
            double altura = double.Parse(Console.ReadLine());

            Console.Write("O IMC é: ");
            double result = Math.Pow(altura, 2);
            double result2 = (peso / result );

            Console.Write( result2);
            Console.WriteLine(" kg/m².");

            Console.ReadKey();
        }
    }
}
