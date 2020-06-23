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
            try
            {
                StreamReader sr = new StreamReader("assets\\klingon-textoB.txt");
                string line = sr.ReadToEnd();
                string[] letters = line.Split(" ");

                string[] result = letters
                    .OrderBy(x => AlphabetVocabulary.AlphabetDictionary()[x.Substring(0, 1)])
                    .ThenBy(x => AlphabetVocabulary.AlphabetDictionary()[x.Substring(1, 1)])
                    .ThenBy(x => AlphabetVocabulary.AlphabetDictionary()[x.Substring(2, 1)])
                    .Distinct()
                    .ToArray();

                Console.WriteLine($"\nA lista de vocabulário é:\n{string.Join(Environment.NewLine, result)}");
            }
            catch (Exception e)
            {
                Console.WriteLine("The file on 'Vocabulary.cs' could not be read:");
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
