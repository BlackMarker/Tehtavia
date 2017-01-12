/*
 * Tee ohjelma, jossa annetaan oppilaalle koulunumero seuraavan taulukon mukaan (pistemäärä kysytään ja ohjelma tulostaa numeron):
0-1		0
2-3		1
4-5		2
6-7		3
8-9		4
10-12	5
Juuso Rossi */
using System;

namespace Teht2{
	class Program{
		static void Main(string[] args){
			while (true) {
				Console.WriteLine("Syota luku");
				int luku;
				int tulos;
				luku = int.Parse(Console.ReadLine());
				if (luku != 12) {
					//luku--;
					tulos = luku / 2;
					Console.Write(tulos + "\n");
				}
				else {
					Console.WriteLine("12\n");
				}
			}
			
		}
		//public static bool Pariton(int value){
		//	return value % 2 != 0;
		//}
	}
}
