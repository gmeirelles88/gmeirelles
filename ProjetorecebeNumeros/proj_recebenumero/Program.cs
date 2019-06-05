using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_recebenumero
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[11];
            int  par, imp, tot, pma, pme;
            par = imp = tot = pma = pme = 0;

            do
            {
                Console.Clear();                
                for (int i = 0; i < 10; i++)
                {
                    Console.Write("escreva o " + (i + 1) + "º numuro ");
                    vet[i] = int.Parse(Console.ReadLine());
                }
                for (int i = 0; i < 10; i++)
                {
                    if (vet[i] % 2 == 0)
                    {
                        par++;
                    }
                    else
                    {
                        imp++;
                    }
                    tot = tot + vet[i];

                }

                int men = vet[0];
                for (int i = 0; i < 10; i++)
                {
                    if (vet[i] < men)
                    {
                        men = vet[i];
                        pme = i;
                    }
                }

                int mai = vet[10];
                for (int i = 0; i < 10; i++)
                {
                    if (vet[i] > mai)
                    {
                        mai = vet[i];
                        pma = i;
                    }
                }
                Console.WriteLine("nº dos pares: " + par);
                Console.WriteLine("nº dos impares: " + imp);
                Console.WriteLine("somatoria: " + tot);
                Console.WriteLine("o maior numuro é " + mai + " e aparece na " + (pma + 1) + "º posição ");
                Console.WriteLine("o menor numuro é " + men + " e aparece na " + (pme + 1) + "º posição ");
                Console.Write("quer refazer? S/N: ");
            } while (Console.ReadKey().Key != ConsoleKey.N);
                   
        }
    }
}
