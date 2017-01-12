/* TÄMÄ ON OIKEASTI TEHTÄVÄ 12
 * Tee ohjelma, joka kysyy käyttäjältä 5 kokonaislukua. Luvut tulee sijoittaa taulukkoon. 
 * Ohjelman tulee tulostaa annetut luvut käänteisessä järjestyksessä.
 * */
using System;

namespace Teht11 {
	class Program {
		static void Main(string[] args) {
			//alustetaan 5:n paikan taulu
			int[] taulu = new int[5];

			//tallennetaan käyttäjältä arvot tauluun
			Console.WriteLine("Anna 5 lukua eroteltuma spacella (Esim: '1 2 3 4 5')");
			string rivi = Console.ReadLine();
			string[] muuttujat = rivi.Split(' ');
			for (int i = 0; i < 5; i++) {
				taulu[i] = int.Parse(muuttujat[i]);
			}
			for (int i = 4; i > -1; i--) {
				Console.WriteLine(taulu[i]);
			}
		}
	}
}