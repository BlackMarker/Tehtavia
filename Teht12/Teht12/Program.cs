/*Tee kahden sisäkkäisen for-silmukan avulla ohjelma, joka tulostaa seuraavanlaisen kuvion:
*
**
***
****
*****
* */
using System;


namespace Teht12 {
	class Program {
		static void Main(string[] args) {
			Console.WriteLine("Anna luku: ");
			int maara = int.Parse(Console.ReadLine());

			for (int i = 0; i < maara; i++) {
				for (int j = 0; j < i + 1; j++) {
					Console.Write("*");
				}
				Console.WriteLine("\n");
			}
		}
	}
}
