using System;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
              Console.Write("Digite um número: ");
            int numero=Convert.ToInt32(Console.ReadLine());

            int fi1=0;
            int fi2=1;
            int soma=fi1 + fi2;

            Console.Write(0 + " " + 1 +" ");
            
            for (int i = 3; i <=numero; i++)
            {
                Console.Write(soma + " ");
                fi1=fi2;
                fi2=soma;
                soma=fi1 + fi2;
            }

        }
    }
}
    

