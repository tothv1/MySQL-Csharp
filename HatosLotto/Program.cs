using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatosLotto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] sajatSzamok = new int[6] { 10, 34, 12, 22, 30, 20 };
            int[] gepiSzamok = new int[6];
            int db = 0;
            while (db != 6)
            {
                int num = random.Next(1, 46);
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

            Console.ReadKey();
        }
    }
}
