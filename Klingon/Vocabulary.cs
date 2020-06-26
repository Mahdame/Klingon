using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Klingon
{
    public static class Vocabulary
    {
        public static void VocabularyList()
        {
            var alphabet = Alphabet.AlphabetDictionary();

            try
            {
                StreamReader sr = new StreamReader(@"D:\dev\Klingon\Klingon\assets\klingon-textoB.txt");
                string line = sr.ReadToEnd();
                string[] letters = line.Split(" ");

                string[] result = letters
                    .OrderBy(x => alphabet[Convert.ToChar(x.Substring(0, 1))])
                    .ThenBy(x => alphabet[Convert.ToChar(x.Substring(1, 1))])
                    .ThenBy(x => alphabet[Convert.ToChar(x.Substring(2, 1))])
                    .Distinct()
                    .ToArray();

                Console.WriteLine($"\nA lista de vocabulário é:\n{string.Join(" ", result)}");
            }
            catch (Exception e)
            {
                Console.WriteLine("The file on 'Vocabulary.cs' could not be read:");
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
