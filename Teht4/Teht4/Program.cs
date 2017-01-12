/* Tee ohjelma, jossa kysytään käyttäjältä tämän ikä. 
 * Jos ikä on alle 18 vuotta, tulosta "alaikäinen", jos se on 18-65 vuotta,
 *  tulosta "aikuinen", muussa tapauksessa tulosta "seniori".
 *   alaikäinen < 18
 *   18 < aikuinen < 65
 *   else: seniori
 */

using System;

namespace Teht4{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Kuinka vanha olet: ");
            int ika;
            ika = int.Parse(Console.ReadLine());
			if (ika <= 65){
				if (ika >= 18){
					Console.WriteLine("aikuinen");
				}
				else{
					Console.WriteLine("alaikainen");
				}
			}
			else{
				Console.WriteLine("seniori");
			}
        }
    }
}
