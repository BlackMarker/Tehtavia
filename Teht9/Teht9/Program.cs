//Tee ohjelma, joka kysyy käyttäjältä lukuja, kunnes hän syöttää luvun 0. Ohjelman tulee tulostaa syötettyjen lukujen summa.
using System;
using System.Collections.Generic;

namespace Teht8 {
	class Program {
		static void Main(string[] args) {
			Console.WriteLine("Luettele lukuja, 0 -lopettaa ja kertoo summan");
			int tulos = 0;
			//luodaan dynaaminen lista
			List <int> lista = new List<int>();
			while (true) {
				int luku = int.Parse(Console.ReadLine());
				if (luku == 0) {
					break;
				}
				lista.Add(luku);
			}
			//foreach käy listan jokaisen kohdan läpi ja lisää muuttujaan tulos
			foreach (int kohta in lista) {
				tulos = tulos + kohta;
			}
			Console.Write("lukujen summa on: " + tulos + "\n");
		}
	}
}
