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
			while (true) {
				int syote;
				Console.WriteLine("Anna numero (1, 2 ,3)");
				//Tallennetaan muuttujaan käyttäjän syöte
				syote = Console.Read();
				string teksti = Convert.ToString(syote);
				if (teksti == "1" || teksti == "2" || teksti == "3") {
					Console.WriteLine("Annoit luvun: " + syote);
				}
				else {
					Console.WriteLine("Antamasi luku ei kelpaa");
				}
			}

		}
	}
}
