/* Kirjoita ohjelma, joka pyytää käyttäjältä opiskelijoiden arvosanat 0-5 ohjelmointi-opintojaksosta (voit itse päättää lopetusehdon). 
 * Tulosta arvosanajakauma käyttäen tähtimerkkejä seuraavasti:

Arvosanajakauma: 
0:
1:****
2:**
3:******
4:*****
5:**
*/
using System;


namespace Teht14 {
	class Program {
		static void Main(string[] args) {
			//Ludaan arvosaoille taulu
			int[] taulu = new int[6];
			//Kysellään
			while (true) {
				Console.WriteLine("Anna arvosana (6 -lopettaa): ");
				int a = int.Parse(Console.ReadLine());
				if (a == 6) {
					break;
				}
				taulu[a]++;
			}
			//Tulostetaan
			Console.WriteLine("Arvosanajakauma: \n");
			for (int i = 0; i < 6; i++) {
				Console.Write(i + ":");
				for (int j = 0; j < taulu[i]; j++) {
					Console.Write("*");
				}
				Console.WriteLine("\n");
			}
		}
	}
}
