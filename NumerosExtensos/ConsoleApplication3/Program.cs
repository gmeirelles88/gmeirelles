using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Clear();
            String[] unidade = {"zero", "um", "dois", "tres", "quatro", "cinco", "seis", "sete", "oito", "nove", "dez", "onze",
            "doze", "treze", "quatorze", "quinze", "dezesseis", "dezessete", "dezoito", "dezenove"};
            String[] dezena = {"","", "vinte", "trinta", "quarenta", "cinquenta", "sessenta", "setenta", "oitenta", "noventa" };
            String[] centena = {"", "cento", "duzentos", "trezentos", "quatrocentos", "quinhentos", "seiscentos", "setecentos", "oitocentos", "novecentos" };

            

            int n, ne, nd, nc, nn, nr;

            Console.WriteLine("Escreva um numero para ver por extenso");
            n = Convert.ToInt32(Console.ReadLine());

            if(n < 0)
            {
                Console.WriteLine("Número inválido");
            }
            else if(n < 20)
            {
                Console.WriteLine(n + " corresponde a " + unidade[n]);
            }
            else if(n < 100)
            {
                ne = n / 10;
                nd = n % 10;
                Console.Write(dezena[ne]);
                if(nd > 0)
                {
                    Console.Write(" e " + unidade[nd]); 
                }
            }else if(n == 100)
            {
                Console.Write("cem! peixe");
            }
            else if(n < 1000)
            {
                nc = n % 100;
                nn = n / 100;
                nr = (n / 10);
                Console.Write(centena[nn]);
                if(nc > 0)
                {
                    Console.Write(" e " + dezena[nr]);

                }

            }
            Console.ReadKey();

        }

    }

}
    
