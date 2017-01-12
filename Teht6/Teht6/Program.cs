/* Auton kulutus on 7.02 litraa 100 kilometrin matkalla ja bensan hinta on 1.595 Euroa. 
 * Tee ohjelma, joka tulostaa ajetulla matkalla (kysytään käyttäjältä) kuluvan bensan määrän sekä bensaan menevän rahan määrän.
 */

using System;

namespace Teht6 {
	class Program {
		static void Main(string[] args) {
			Console.WriteLine("Montako kilometria olet ajanut: ");
			float matka;
			matka = (float)int.Parse(Console.ReadLine());

			float litraa = matka * 7.02f;
			float hinta = litraa * 1.595f;
			Console.WriteLine("Olet kuluttanut: \n" + litraa + " -Litraa\n" + hinta + " -euroa\n");
		}
	}
}
