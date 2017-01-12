/*Mäkihypyssä käytetään viittä arvostelutuomaria.Kirjoita ohjelma, joka kysyy arvostelupisteet yhdelle hypylle ja 
tulostaa tyylipisteiden summan siten, että summasta on vähennetty pois pienin ja suurin tyylipiste. Esim:
	Anna pisteet > 18 [Enter]
    Anna pisteet > 15 [Enter]
    Anna pisteet > 20 [Enter]
    Anna pisteet > 19 [Enter]
    Anna pisteet > 17 [Enter]
    Kokonaispisteet ovat 54
	*/
using System;


namespace Teht13 {
	class Program {
		static void Main(string[] args) {
			//luodaan taulu (5 paikkaa)
			int[] taulu = new int[5];
			//apu muuttuja taulukon järjestämiseen suuruus järjestykseen
			int apu;
			//for loopilla kysellään pisteet
			for (int i = 0; i < 5; i++) {
				Console.WriteLine("Anna pisteet: ");
				taulu[i] = int.Parse(Console.ReadLine());
			}
			//for looppi joka järjestelee taulun suuruus järjestykseen
			for (int i = 0; i < 5; i++) {
				for (int j = 0; j < 5; j++) {
					if (taulu[i] < taulu[j]) {
						apu = taulu[i];
						taulu[i] = taulu[j];
						taulu[j] = apu;
					}
				}
			}
			//for looppien jälkeen taulu on suuruus järjestyksessä ja lasketaan keskimmäiset arvot
			int tulos = taulu[1] + taulu[2] + taulu[3];
			Console.WriteLine("Pisteet ovat: " + tulos);
		}
	}
}
