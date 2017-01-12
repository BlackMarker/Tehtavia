using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht3Toimiva
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna 3 lukua eroteltuma spacella (Esim: '5 7 3')");
            string rivi = Console.ReadLine();
            string[] muuttujat = rivi.Split(' ');
            int m1 = int.Parse(muuttujat[0]);
            int m2 = int.Parse(muuttujat[1]);
            int m3 = int.Parse(muuttujat[2]);

            int tulos1 = m1 + m2 + m3;
            float apu = (float)tulos1;
            float tulos2 = apu / 3;
            Console.Write("Summa: " + tulos1 + " KA: " + tulos2 + "\n");
        }
    }
}
