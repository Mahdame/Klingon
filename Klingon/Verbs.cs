using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Klingon
{
    public static class Verbs
    {
        public static void VerbsTextB()
        {
            try
            {
                StreamReader sr = new StreamReader("assets\\klingon-textoB.txt");
                string line = sr.ReadToEnd();
                string[] letters = line.Split(" ");
                ListsFooBar lists = new ListsFooBar();

                string[] verbs = letters
                    .Where(x => x.Length >= 8 && lists.Foo()
                    .Contains(x.Substring(x.Length - 1, 1)))
                    .ToArray();

                string[] firstPersonVerbs = verbs
                    .Where(x => lists.Bar()
                    .Contains(x.Substring(0, 1)))
                    .ToArray();

                Console.WriteLine($"\nExistem {verbs.Length} verbos.");
                Console.WriteLine($"Existem {firstPersonVerbs.Length} verbos em primeira pessoa.\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("The file on 'Verbs.cs' could not be read:");
                Console.WriteLine(e.Message);
            }            
        }
    }
}
