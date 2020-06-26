using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Klingon
{
    public static class Numbers
    {
        public static void PrettyNumbers()
        {
            var alphabet = Alphabet.AlphabetDictionary();

            try
            {
                StreamReader sr = new StreamReader(@"D:\dev\Klingon\Klingon\assets\klingon-textoB.txt");
                string line = sr.ReadToEnd();
                List<long> list = new List<long>();
                string[] words = line.Split(" ");

                for (int j = 0; j < words.Length; j++)
                {
                    long total = 0;
                    var letters = words[j].ToCharArray();

                    for (int i = 0; i < letters.Length; i++)
                    {
                        if (i == 0)
                        {
                            var firstNumber = alphabet.GetValueOrDefault(letters[i]);
                            firstNumber *= 1;
                            total += firstNumber;
                        }
                        else if (i == 1)
                        {
                            var secondNumber = alphabet.GetValueOrDefault(letters[i]);
                            secondNumber *= 20;
                            total += secondNumber;
                        }
                        else if (i == 2)
                        {
                            var thirdNumber = alphabet.GetValueOrDefault(letters[i]);
                            thirdNumber *= 400;
                            total += thirdNumber;
                        }
                        else if (i == 3)
                        {
                            var fourthNumber = alphabet.GetValueOrDefault(letters[i]);
                            fourthNumber *= 8000;
                            total += fourthNumber;
                        }
                        else if (i == 4)
                        {
                            var fifthNumber = alphabet.GetValueOrDefault(letters[i]);
                            fifthNumber *= 160000;
                            total += fifthNumber;
                        }
                        else if (i == 5)
                        {
                            var sixthNumber = alphabet.GetValueOrDefault(letters[i]);
                            sixthNumber *= 3200000;
                            total += sixthNumber;
                        }
                        else if (i == 6)
                        {
                            var seventhNumber = alphabet.GetValueOrDefault(letters[i]);
                            seventhNumber *= 64000000;
                            total += seventhNumber;
                        }
                        else if (i == 7)
                        {
                            var eighthNumber = alphabet.GetValueOrDefault(letters[i]);
                            eighthNumber *= 1280000000;
                            total += eighthNumber;
                        }
                        else if (i == 8)
                        {
                            var ninethNumber = alphabet.GetValueOrDefault(letters[i]);
                            ninethNumber *= 25600000000;
                            total += ninethNumber;
                        }
                        else if (i == 9)
                        {
                            var tenthNumber = alphabet.GetValueOrDefault(letters[i]);
                            tenthNumber *= 512000000000;
                            total += tenthNumber;
                        }
                    }
                    if (total >= 440566 && (total % 3) == 0)
                    {
                        list.Add(total);
                    }
                }
                Console.WriteLine($"Existem {list.Distinct().Count()} números bonitos distintos.");

            }
            catch (Exception e)
            {
                Console.WriteLine("The file on 'Number.cs' could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
