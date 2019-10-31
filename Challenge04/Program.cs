using System;
using System.Collections;

namespace Substitution
{
    class Program
    {
        static void Main(string[] args)
        {
            // We have some word collection ...
            var censoredWords = new ArrayList();
            censoredWords.Add("imperdiet");
            censoredWords.Add("dolor");
            censoredWords.Add("duo");

            // and a paragraph.
            var paragraph = "Lorem ipsum dolor sit amet, imperdiet vituperata duo in, nonumy.";
            string word1 = ArrayList[0].Replace(*****);
            string word2 = ArrayList[1].Replace(*********);
            string word3 = ArrayList[2].Replace(***);
Console.WriteLine($"Lorem ipsum {word1} sit amet, {word2} vituperata {word3}");
            // Censor the words in paragraph by using * symbol.
            // Output example:
            // Lorem ipsum ***** sit amet, ********* vituperata *** in, nonumy.
        }
    }
}
