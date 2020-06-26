using System.Collections.Generic;

namespace Klingon
{
    public static class Alphabet
    {
        public static Dictionary<char, long> AlphabetDictionary()
        {
            var alphabet = new Dictionary<char, long>() {
                { 'k', 0 },
                { 'b', 1 },
                { 'w', 2 },
                { 'r', 3 },
                { 'q', 4 },
                { 'd', 5 },
                { 'n', 6 },
                { 'f', 7 },
                { 'x', 8 },
                { 'j', 9 },
                { 'm', 10 },
                { 'l', 11 },
                { 'v', 12 },
                { 'h', 13 },
                { 't', 14 },
                { 'c', 15 },
                { 'g', 16 },
                { 'z', 17 },
                { 'p', 18 },
                { 's', 19 }
            };
            return alphabet;
        }
    }
}
