using System;
using System.Globalization;

namespace Uri1113
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string[] vet = Console.ReadLine().Split(' ');

            int x = int.Parse(vet[0]);
            int y = int.Parse(vet[1]);

            while(x != y)
            {
                if (x < y)
                {
                    Console.WriteLine("crescente");
                }
                else
                {
                    Console.WriteLine("decrescente");
                }

                vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);*/

            double idade = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double media = 0.0;
            double cont = 0.0;
          
            while(idade > 0)
            {
                media = media + idade;
                cont++;
                idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            media = media / cont;
            
            if (media > 0)
            {
                Console.WriteLine(media.ToString("f2", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("imposivel calcular");
            }      
        }
    }
}
