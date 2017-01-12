/* Tee ohjelma, joka alustaa sovellukseen käyttöö seuraavan taulukon arvot = [1,2,33,44,55,68,77,96,100]. 
 * Käy sovelluksessa taulukko läpi ja tulosta ruutuun "HEP"-sana aina kun taulukossa oleva luku on parillinen.
 * */

using System;

namespace Teht10 {
	class Program {
		static void Main(string[] args) {
			//tehdään muuttumaton muuttuja ( koska new int vaati sitä)
			const int pituus = 9;
			int[] taulu = new int[pituus]{ 1, 2, 33, 44, 55, 68, 77, 96, 100};
			for (int i = 0; i < pituus; i++) {
				if (taulu[i] % 2 == 0) {
					Console.Write("HEP\n");
				}
			}
		}
	}
}
