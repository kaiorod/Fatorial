using System;

namespace Fatorial
{
    class Program
    {
        //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
        static void Main(string[] args)
        {
            int i, fat, n; 

            Console.Write("Digite o valor de n : "); 
            n = int.Parse(Console.ReadLine()); 

            fat = n; 

            if(n == 0)
            {
                Console.WriteLine($"Fatorial de {n} = 1");
            }
            else
            {
            Console.Write($"{n}"); 
            do 
            { 
                for(i = n - 1; i > 0; i = i = i - 1) 
                { 
                    Console.Write($" * {i}"); 
                    fat = fat * i; 
                } 
            } 
            while (i > 0); 
            Console.WriteLine($"\nFatorial de {n} = {fat}"); 
            }
        }
    }
}
