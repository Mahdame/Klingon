using System;
using System.IO;
using System.Linq;

namespace Klingon
{
    public static class Prepositions
    {
        public static void PrepositionsTextB()
        {
            try
            {
                StreamReader sr = new StreamReader("assets\\klingon-textoB.txt");
                string line = sr.ReadToEnd();
                ListsFooBar lists = new ListsFooBar();

                string[] letters = line.Split(" ");

                string[] preposition = letters
                    .Where(x => x.Length == 3 && lists.Bar()
                    .Contains(x.Substring(2, 1)))
                    .ToArray();

                preposition = preposition
                    .Where(y => !y
                    .Contains("d"))
                    .ToArray();

                Console.WriteLine($"Existem {preposition.Length} preposições.");
            }
            catch (Exception e)
            {
                Console.WriteLine("The file on 'Preposition.cs' could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
