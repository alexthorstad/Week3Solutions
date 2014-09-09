using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LambdaPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> products = new List<string>() {"Basketball", "Baseball", "Tennis Raquet", "Running Shoes", "Wrestling Shoes", 
                "Soccer Ball", "Football", "Shoulder Pads", 
                "Trail Running Shoes", "Cycling Shoes", "Kayak", "Kayak Paddles"};


            //declare a variable kayakProducts and set it equal to all products that contain the word "Kayak"
            List<string> kayakProducts = products.Where(x => x.Contains("Kayak")).OrderBy(x => x).ToList();
            //print the kayakProducts to the console using a foreach loop.
            foreach (var kayaks in kayakProducts)
            {
                Console.WriteLine(kayaks);
            }
            //declare a variable shoeProducts and set it equal to all products that contain the word "Shoes"
            List<string> shoeProducts = products.Where(x => x.Contains("Shoes")).OrderBy(x => x).ToList();
            //print the shoeProducts to the console using a foreach loop or string.Join().
            foreach (var Shoes in shoeProducts)
            {
                Console.WriteLine(Shoes);
            }
            //declare a variable ballProducts and set it equal to all the products that have ball in the name.
            List<string> ballProducts = products.Where(x => x.Contains("ball")).ToList();
            //print the ballProducts to the console using a foreach loop or string.Join().
            foreach (var ball in ballProducts)
            {
                Console.WriteLine(ball);
            }
            //sort ballProducts alphabetically and print them to the console.
            Console.WriteLine(string.Join(", ", products.Where(x => x.Contains("ball")).OrderBy(x => x).ToList()));
            //add six more items to the products list using .add().
            products.Add("Snowboard");
            products.Add("Wiffle Bat");
            products.Add("Binding");
            products.Add("Pizza");
            products.Add("Chairlift");
            products.Add("Ant");
            //print the product with the longest name to the console using the .First() extension.
            List<string> longestName = products.OrderByDescending(x => x.Length).ToList();
            Console.WriteLine(longestName.First());
            //print the product with the shortest name to the console using OrderByDesceding() and the .First() extension.
            List<string> shortestName = products.OrderBy(x => x.Length).ToList();
            Console.WriteLine(shortestName.First());
            //print the product with the 4th shortest name to the console using an index or Skip/Take (you must convert the results to a list using .ToList()).
            Console.WriteLine(products.OrderBy(x => x.Length).Skip(3).Take(1).ToList().First());
            //print the ballProduct with the 2nd longest name to the console using an index or Skip/Take (you must convert the results to a list using .ToList()).
            Console.WriteLine(products.OrderByDescending(x => x.Length).Skip(1).Take(1).ToList().First());
            //declare a variable reversedProducts and set it equal to all products ordered by the longest word first. (use the OrderByDescending() extension).
            List<string> reversedProducts = products.OrderByDescending(x => x.Length).ToList();
            //print out the reversedProducts to the console using a foreach loop.
            foreach (var all in reversedProducts)
            {
                Console.WriteLine(all);
            }
            //print out all the products ordered by the longest word first using the OrderByDecending() extension and a foreach loop.  
            
            foreach (string all in products.OrderByDescending(x => x.Length).ToList())
            {
                Console.WriteLine(all);
            }
            
            //Note: you will not use a variable to store your list

            Console.ReadKey();
        }
    }
}