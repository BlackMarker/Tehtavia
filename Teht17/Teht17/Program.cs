/*Tee ohjelma, joka lajittelee kahdessa kokonaislukutaulukossa olevat alkiot suurusjärjestykseen kolmanteen kokonaislukutaulukkoon. 
 * Tulosta lopuksi lajitellun taulukon sisältö.*/
using System;

namespace Teht17 {
	class Program {
		static void Main(string[] args) {
			int pituus = 5;
			//muuttuja toisen taulun (taulu2) indexille
			int c = 0;
			int[] taulu1 = new int[] { 10, 11, 12, 13, 14 };
			int[] taulu2 = new int[] { 1, 2, 3, 4, 50 };
			int[] taulu3 = new int[10];
			int apu;

			//Taulujen yhistely
			for (int i = 0; i < 4; i++) {
				taulu3[i] = taulu1[i];
			}
			for (int i = 4; i < 9; i++) {
				taulu3[i] = taulu2[c];
				c++;
			}
			//for looppi joka järjestelee taulun suuruus järjestykseen
			for (int i = 0; i < 9; i++) {
				for (int j = 0; j < 9; j++) {
					if (taulu3[i] < taulu3[j]) {
						apu = taulu3[i];
						taulu3[i] = taulu3[j];
						taulu3[j] = apu;
					}
				}
			}
			//taulun 3 tulostus
			for (int i = 0; i < 9; i++) {
				Console.Write(taulu3[i]);
				Console.Write(" ");
			}
		}
	}
}
