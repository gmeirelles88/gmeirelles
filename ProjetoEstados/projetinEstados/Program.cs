using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetinEstados
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] estado = new string[27, 2];
            estado[0, 0] = "SP"; estado[0, 1] = "sao paulo";
            estado[1, 0] = "RJ"; estado[1, 1] = "rio de janeiro";
            estado[2, 0] = "RS"; estado[2, 1] = "rio grande do sul";
            estado[3, 0] = "MG"; estado[3, 1] = "minas gerais";
            estado[4, 0] = "GO"; estado[4, 1] = "goias";
            estado[5, 0] = "PB"; estado[5, 1] = "paraiba";
            estado[6, 0] = "PR"; estado[6, 1] = "parana";
            estado[7, 0] = "BA"; estado[7, 1] = "bahia";
            estado[8, 0] = "PI"; estado[8, 1] = "piaui";
            estado[9, 0] = "MT"; estado[9, 1] = "mato grosso";
            estado[10, 0] = "MS"; estado[10, 1] = "mato grosso do sul";
            estado[11, 0] = "RO"; estado[11, 1] = "rondonia";
            estado[12, 0] = "RR"; estado[12, 1] = "roraima";
            estado[13, 0] = "AM"; estado[13, 1] = "amazonas";
            estado[14, 0] = "AP"; estado[14, 1] = "amapa";
            estado[15, 0] = "CE"; estado[15, 1] = "ceara";
            estado[16, 0] = "AL"; estado[16, 1] = "alagoas";
            estado[17, 0] = "PE"; estado[17, 1] = "pernambuco";
            estado[18, 0] = "SE"; estado[18, 1] = "serjipe";
            estado[19, 0] = "SC"; estado[19, 1] = "santa catarina";
            estado[20, 0] = "TO"; estado[20, 1] = "tocantins";
            estado[21, 0] = "ES"; estado[21, 1] = "espirito santo, amem";
            estado[22, 0] = "DF"; estado[22, 1] = "distrito federal";
            estado[23, 0] = "RN"; estado[23, 1] = "rio grande do norte";
            estado[24, 0] = "PA"; estado[24, 1] = "para";
            estado[25, 0] = "AC"; estado[25, 1] = "acre";
            estado[26, 0] = "MA"; estado[26, 1] = "maranhao";

            string sta;
            string text;
            int i;
            
            do
            {
                Console.Clear();
                Console.Write("escreva uma sigla ou estado: ");
                text = sta = Console.ReadLine();
                string utxt = text.ToUpper();

                for (i = 0; i < 27; i++)
                {
                    if (utxt == estado[i, 0])
                    {
                        Console.WriteLine("{0} corresponde a {1}", utxt, estado[i, 1]);
                        break;
                    }
                
                    if (sta == estado[i, 1])
                    {
                        Console.WriteLine("{0} corresponde a {1}", sta, estado[i, 0]);
                        break;
                    }
                }
                if (i == 27)
                {
                    Console.WriteLine("algo de errado não está certo");
                }
            } while (Console.ReadKey().Key != ConsoleKey.N);
            
        }
    }
}
