/*Tee ohjelma, joka näyttää annetun sekuntimäärän tunteina, minuutteina 
ja sekunteina.Aikamääre sekuntteina kysytään käyttäjältä.
*/
using System;

namespace Teht5{
	class Program{
		static void Main(string[] args){
			//Kysymykset ja muuttuja alustukset
			int sek;
			Console.WriteLine("Anna sekunnit: ");
			sek = int.Parse(Console.ReadLine());
			int min = 0;
			int tun = 0;
			Console.WriteLine("Sen voi ilmottaa myos: \n");
			//for looppi joka laskee sekunnit minuuteiksi
			for (int i = sek; i > 59; i = i - 60) {
				min++;
				sek = sek - 60;
				//sen sisällä for looppi joka laskee minuutit tunneiksi
				for (int j = min; j > 59; j = j - 60) {
					tun++;
					min = min - 60;
				}
			}
			Console.WriteLine(tun + " -tuntia\n" + min + " -minuuttia\n" + sek + " -sekuntia\n");
		}
	}
}
