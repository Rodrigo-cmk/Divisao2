using System;

namespace Divisao2
{
    class Program
    {
        static void Main(string[] args)
        {
            string c;
            digite();

            do
            {
                double a, b;

                Console.WriteLine();
                digite2("| Insira o numerador: ");
                a = valor(Console.ReadLine());
                digite2("| insira o denominador: ");
                b = valor(Console.ReadLine());
                valor1(a, b);
                Console.WriteLine();

                Console.Write("Sair? (S / Qualquer tecla para N) ");
                c = Console.ReadLine().ToUpper();
                Console.WriteLine();
            } while (c != "S");

            Console.WriteLine("Fim");
        }

        static void digite()
        {
            DateTime agora = DateTime.Now;
            Console.WriteLine();
            Console.WriteLine($"Olá     {agora}");
            Console.WriteLine();
            Console.WriteLine("Exercício Divisão");
            Console.WriteLine("- Recepção de um numerador e um denominador. Exibição do resultado da divisão, ou 'Não é possível dividir por zero.', conforme o caso.");
        }

        static void digite2(string digite)
        {
            Console.Write(digite, "/n");
        }

        static double valor(string valor)
        {
            double a;
            return a = Convert.ToDouble(valor);
        }

        static void valor1(double a, double b)
        {
            double resul = a / b;

            if (b == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Atenção! Não é possível dividir por zero.");
                Console.ResetColor();
                Environment.Exit(-1);
            }

            Console.WriteLine($"| --> O resultado é {resul:N2}.");
        }

        static void laço()
        {
            string b;
            do
            {
                Console.Write("Sair (S / N)? ");
                b = Console.ReadLine().ToUpper();
            } while (b != "S");
        }
    }
}
