using System;

namespace Exercicio_RetContorno
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 1, numero2 = 1, L, A;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Digite a altura: ");
            A = int.Parse(Console.ReadLine());
            
            Console.Write("Digite a largura: ");
            L = int.Parse(Console.ReadLine());
            Console.ResetColor();

            if (A < 0 || A > 10 || L < 0 || L > 10)
            {
                Console.WriteLine("Apenas números de 0 a 10.");
            }
            else
            {
                Console.WriteLine();
                while (numero1 <= L)
                {
                    while (numero2 <= A)
                    {
                        if (numero1 == 1 || numero1 == L || numero2 == 1 || numero2 == A)
                        {
                            Console.Write("* ");
                        }
                        else
                        {
                            Console.Write("  ");
                        }
                        numero2++;
                    }
                    numero2 = 1;
                    numero1++;
                    Console.WriteLine();
                }
            }
        }
    }
} 