using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextStatsLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            TextStats("Do you like to party like He Man?  No, you must like to party like Skeletor.  Fear the beast, eat a Slim Jim Dude.");
            Console.ReadKey();
        }

        static void TextStats(string input)
        {
            int TextStats = ("Do you like to party like He Man?  No, you must like to party like Skeletor.  Fear the beast, eat a Slim Jim Dude.");
            //Lets find characters
            Console.WriteLine("Would you like to Character?: " + input.Length);
            //Lets find words
            Console.WriteLine("There are this many words in muh sentence d00d: " + input.Count);
            //Lets find vowels
            Console.WriteLine(string.Join(", ", TextStats.Where(x => x.Contains("aeiou")).OrderBy(x => x).ToList()));
            //Lets find consonants
            Console.WriteLine("Consonants rock: " + input
            //Lets find special characters
            Console.WriteLine(x => x.Contains("!@#$%^&*")).OrderBy(x => x).ToList();
            //Lets find the longest word
            List<string> longestName = TextStats.OrderByDescending(x => x.Length).ToList();
            Console.WriteLine(longestName.First());
            //Lets find the shortest word
             List<string> shortestName = TextStats.OrderBy(x => x.Length).ToList();
            Console.WriteLine(shortestName.First());
            //Lets call this function from our Main function
            // using a three sentence string? Huh?

        }
    }
}
