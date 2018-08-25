using System;
using System.Linq;

// INPUT = abcd

// DESIRED OUPUT = A - Bb - Ccc- Dddd

namespace FirstLetterLoopProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var letters = "abcd";
            var output = string.Join("-", letters.Select((c, i) => Char.ToUpper(c) + new string(Char.ToLower(c),i)));
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
