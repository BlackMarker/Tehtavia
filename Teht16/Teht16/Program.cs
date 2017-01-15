/* Tee ohjelma, joka arpoo satunnaisluvun väliltä 0-100. Käytä C#:n Random -luokkaa. 
 * Tämän jälkeen ohjelman käyttäjää kehoitetaan arvaaman arvottu luku. Ohjelman tulee antaa vihje arvauksen 
 * jälkeen onko arvottu luku pienemäi vai suurempi. Tämän jälkeen vihjeitä toistetaan kunnes käyttäjä arvaa oikean 
 * luvun. Tulosta lopuksi arvausten määrä näytölle. PS Satunnaislukujen arpomisesta tietokoneella löytyy mielenkiintoista 
 * luettavaa esimerkiksi tästä artikkelista: Computers are lousy random number generators.
 */
using System;


namespace Teht16 {
	class Program {
		static void Main(string[] args) {
			Random arpoa = new Random();
			int luku = arpoa.Next(0, 100);
			int maara = 0;
			Console.Write("Arvaa oikea luku (0-100)");

			while (true) {
				int arvaus = int.Parse(Console.ReadLine());
				maara++;
				if (arvaus == luku) {
					Console.WriteLine("VOITIT!");
					Console.WriteLine("Arvauksien maara: " + maara);
					break;
				}
				if (arvaus < luku) {
					Console.WriteLine("Luku on suurempi kuin arvauksesi");
				}
				if (arvaus > luku) {
					Console.WriteLine("Luku on pienempi kuin arvauksesi");
				}
			}
		}
	}
}
