using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishDict
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] things = {
                "Boat",
                "House",
                "Cat",
                "River",
                "Cupboard"
            };

          for (int i = 0; i < things.Length; i++)
            {
                things[i] += 's';
                Console.WriteLine(things[i]);
            }
            Console.WriteLine();
            things[2] = "Homestead";
            foreach(string thing in things)
            {
                Console.WriteLine(thing);
            }

            List<string> thingList = things.ToList<string>();
            thingList.Add("Computer");


            Console.WriteLine("\nStrings with length greater than 6 ...");
            string[] allwith5Length = Array.FindAll(thingList.ToArray(), x => x.Length > 6);
            foreach (var item in allwith5Length)
                Console.WriteLine(item);
            Console.WriteLine("\n" + things[2]);
            Array.Sort(things);
            Console.WriteLine("\n");
            foreach (var thing in things)
                Console.WriteLine(thing);
            Array.Reverse(things);
            Console.WriteLine("\n");
            foreach (var thing in things)
                Console.WriteLine(thing);
        }
    }

    class StringComparer: IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return x.Length.CompareTo(y.Length);
        }       
    }
}
