//Tee ohjelma, joka kysyy käyttäjältä kolme lukua ja tulostaa niiden summan ja keskiarvon.
using System;


namespace Teht3
{
    class Program
    {
        static void Main(int[] args)
        {
            Console.WriteLine("Anna 3 lukue (Esim: '5 7 3'");
            string rivi = Console.ReadLine();
            string[] muuttujat = rivi.Split(' ');
            int m1 = int.Parse(muuttujat[0]);
            int m2 = int.Parse(muuttujat[0]);
            int m3 = int.Parse(muuttujat[0]);

            int tulos = (m1 + m2 + m3) / 2;
            Console.Write(tulos);
        }
    }
}
