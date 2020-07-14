using System;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            int fi1 = 0;
            int fi2 = 1;
            int soma = 0;


            if (numero < 2)
            {
                Console.WriteLine("Favor digitar um número maior ou igual a 2");
                Environment.Exit(-1);
            }
            //Console.Write(0 + " " + 1 + " ");

            for (int i = 0; i < numero; i++)
            {
                Console.Write(soma + " ");
                soma = fi1 + fi2;
                fi2 = fi1;
                fi1 = soma;
            }

        }
    }
}
