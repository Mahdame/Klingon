using System.Collections.Generic;

namespace Klingon
{
    public class ListsFooBar
    {
        List<string> bar = new List<string>()
            { "a", "b", "c", "d", "e", "g", "h", "i", "j", "m", "n", "o", "p", "q", "r", "t", "u", "v", "x", "y", "z" };

        List<string> foo = new List<string>()
            { "f", "k", "l", "s", "w" };

        public List<string> Foo()
        {
            return foo;
        }

        public List<string> Bar()
        {
            return bar;
        }
    }
}
