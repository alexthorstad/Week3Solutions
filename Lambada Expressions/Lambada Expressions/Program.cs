﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambada_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare a list of test strings
            List<string> myList = new List<string>() { "tyler", "kiwi", "strawberry", "boisonberry", "blueberry", "blackberry", "mango", "pineapple", "apple" };
            //call the order by example
            OrderByExample(myList);
            //call the where example
            WhereExample(myList);
            //call the Distinct() example
            DistinctExample();
            //call the FirstAndLAst() example
            FirstAndLastExample(myList);

            //call the SkipAndTake() example
            SkipAndTakeExample(myList);

            //keep the console open
            Console.ReadKey();
        }

        static void OrderByExample(IEnumerable<string> list)
        {
        //order the list by length, and print them out to the console.
        //then by sort alphabetically
        List<string> orderedList = list.OrderBy(x => x.Length).ThenBy(x=> x).ToList();
        Console.WriteLine(string.Join(", ", orderedList));  
        }

        static void WhereExample(IEnumerable<string> list)
        {
            //print to the console all items in the list that contain the text "berry"
            List<string> berryList = list.Where(x => x.Contains("berry")).ToList();
            Console.WriteLine(string.Join(", ", berryList));

            //print to the console all items in the list that Do Not contain the text "berry"
            List<string> notBerryList = list.Where(x => !x.Contains("berry")).ToList();
            Console.WriteLine(string.Join(", ", notBerryList));

            //Console.WriteLine(string.Join(", ", list.Where(x => x.Contains("berry"))));
        }

        static void DistinctExample()
        {
            //declare a new list of integers, with a bunch of duplicate values
            List<int> intList = new List<int>() { 1, 1, 2, 2, 3, 3, 4, 5, 5, 7, 7, 8 };
            Console.WriteLine(string.Join(", ", intList.Distinct()));

            Console.WriteLine(intList.Sum(x => x));
        }
        
        static void FirstAndLastExample(IEnumerable<string> list)
        {
            //we are going to sort the list alphabetically and print the first and last items to the console.
            List<string> sorted = list.OrderBy(x => x).ToList();
            Console.WriteLine(sorted.First());
            Console.WriteLine(sorted.Last());

            
        }

        static void SkipAndTakeExample(IEnumerable<string> list) 
        {
            //we want to print out the 3rd item from our list sorted by length
            List<string> sorted = list.OrderBy(x => x.Length).ToList();
            //skip 2 itms, print the 3rd.
            Console.WriteLine(list.Skip(2).Take(1).First());
            //skip to items, print the next 2 items
            Console.WriteLine(string.Join(", ", sorted.Skip(2).Take(2)));
        }
    }
}
