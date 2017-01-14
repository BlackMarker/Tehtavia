using System;
/* Tee ohjelma, joka tulostaa seuraavanlaisen kuvion. Kysy käyttäjältä puunkorkeus käytä juurena kaksi korkeuden yksikkö.


    Anna Luku > 7 [Enter]    
        *        
       ***
      *****
     *******
    *********
        *
        */

namespace Teht15 {

	class Program {
		static void Main(string[] args) {
			Console.WriteLine("Kuinka korkea puu: ");
			int korkeus = int.Parse(Console.ReadLine());
			korkeus--;
			int leveys = korkeus;
			int teko = 0;
			//Muuttuja tähtien määrän kasvamisella
			int maara = 1;
			//Huijausapuri

			/*/For looppi korkeus riveille
			for (int i = 0; i < korkeus -2; i++) {
				//For looppi space maaralle
				for (int j = leveys; j > 0; j--) {
					Console.Write(" ");
					//Fof looppi tahdille
					for (int k = 0; k < korkeus; k++) {
						Console.Write("*");
					}
				}
				Console.WriteLine("\n");
			}
			*/
			//spacet
			if (teko == 0) {
				for (int i = leveys; i > -1; i--) {
					Console.Write(" ");
				}
				teko = 1;
			}
			//tähdet
			if (teko == 1) {
				for (int i = maara; i > 0; i--) {
					Console.Write("*");
				}
				teko = 2;
			}
			if (teko == 2) {
				Console.WriteLine();
				teko = 0;
			}
				while (true) {
				//spacet
				if (teko == 0) {
					for (int i = leveys; i > 0; i--) {
						Console.Write(" ");
					}
					teko = 1;
				}
				//tähdet
				if (teko == 1) {
					for (int i = maara; i > 0; i--) {
						Console.Write("**");
					}
					maara++;
					leveys--;
					teko = 2;
				}
				if (teko == 2) {
					Console.WriteLine();
					teko = 0;
				}
				if (maara == korkeus) {
					break;
				}
			}
		}
	}
}
