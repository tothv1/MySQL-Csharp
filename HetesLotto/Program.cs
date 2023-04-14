using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HetesLotto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] sajatSzamok = new int[7];
            int sajatDb = 0;
            while (sajatDb != 7)
            {
                Console.Write($"Kérem a(z) {sajatDb+1}. számot: " );
                sajatSzamok[sajatDb] = int.Parse(Console.ReadLine());
                sajatDb++;
            }
            int[] gepiSzamok = new int[7];
            int db = 0;
            while (db != 7)
            {
                int num = random.Next(1, 36);
                if (!gepiSzamok.Contains(num))
                {
                    gepiSzamok[db] = num;
                    Console.WriteLine(gepiSzamok[db]);
                    db++;

                }
            }
            int talalatok = 0;
            foreach (var sajatSzam in sajatSzamok)
            {
                if (gepiSzamok.Contains(sajatSzam))
                {
                    talalatok++;
                }
            }
            Console.WriteLine($"Találatok száma: {talalatok}db");
            Console.WriteLine($"Esély a winre: {((decimal)35*34*33*32*31*30*29) / (1*2*3*4*5*6*7)}");

            Console.ReadKey();
        }
    }
}
