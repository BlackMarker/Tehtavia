//Tee ohjelma, joka kysyy käyttäjältä 3 kokonaislukua ja tulostaa niistä suurimman.
using System;

namespace Teht8 {
	class Program {
		static void Main(string[] args) {
			//alustetaan 3:n paikan taulu
			int[] taulu = new int[3];

			//tallennetaan käyttäjältä arvot tauluun
			Console.WriteLine("Anna 3 lukua eroteltuma spacella (Esim: '5 7 3')");
			string rivi = Console.ReadLine();
			string[] muuttujat = rivi.Split(' ');
			taulu[0]= int.Parse(muuttujat[0]);
			taulu[1] = int.Parse(muuttujat[1]);
			taulu[2] = int.Parse(muuttujat[2]);

			//verrataan for loopilla taulun[0] paikkaa jos [0] pienempi --> kopioi (käydään läpi jokaiseen tulun kohtaan
			for (int i = 1; i < 3; i++) {
				if ( taulu[0] <= taulu[i]) {
					taulu[0] = taulu[i];
				}
			}
			//tulostetaan isoin luku joka on taulu[0] paikasa
			Console.WriteLine("Suurin luku on: " + taulu[0]);
		}
	}
}
