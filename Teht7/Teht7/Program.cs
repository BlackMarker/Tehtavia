/*Tee ohjelma, joka näyttää onko annettu vuosi karkausvuosi. Vuosiluku kysytään käyttäjältä.
Algoritmi:

4:llä jaolliset on, paitsi täydet vuosisadat. Kuitenkin 400:lla jaolliset vuosisadat ovat
Esim. 1991 -> ei, 1992 -> on, 1900 -> ei, 2000 -> on
*/
using System;

namespace Teht7 {
	class Program {
		static void Main(string[] args) {
			Console.WriteLine("Anna vuosiluku, kerron onko se karkausvuosi: ");
			int vuosi = int.Parse(Console.ReadLine());
			//jos vuosi on 400 jaollinen TAI vuosi on 4 jaollinen, mutta ei 100 jaollinen
			if (vuosi % 400 == 0 || vuosi % 4 == 0 && vuosi % 100 != 0) {
				Console.WriteLine(vuosi + " on karkaus vuosi");
			}
			else {
				Console.WriteLine(vuosi + " ei ole karkaus vuosi");
			}
		}
	}
}

