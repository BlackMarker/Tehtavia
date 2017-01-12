/*
 * Tee ohjelma, joka tulostaa käyttäjän antamaa lukua (1, 2 tai 3) vastaavan luvun sanana (yksi, kaksi tai kolme). 
 * Jos käyttäjä syöttää jonkin muun luvun, tulee näytölle tulostaa teksti: "joku muu luku". */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht1
{
	class Program{
		static void Main(string[] args){
			//Alustetaan muuttuja
			int syote;
			string[] taulu = { "annoit jonkun muun luvun", "yksi", "kaksi", "kolme" };
			while (true) {
				
				Console.WriteLine("Anna numero (1, 2 ,3)");
				//Tallennetaan muuttujaan käyttäjän syöte
				syote = int.Parse(Console.ReadLine());
				if (syote == 1 || syote == 2 || syote == 3) {
					Console.WriteLine(taulu[syote]);
				}
				else {
					Console.WriteLine(taulu[0]);
				}
			}

		}
	}
}
