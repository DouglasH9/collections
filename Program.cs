using System;
using System.Collections.Generic;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int[] newArray = new int[10];
            int[] newArray2 = {0,1,2,3,4,5,6,7,8,9};
            int[] newArray3;
            newArray3 = new int[] {0,1,2,3,4,5,6,7,8,9};

            string[] nameArray = {"Tim", "Martin", "Nikki", "Sara"};
            bool[] boolArray = {true, false, true, false, true, false, true, false, true, false};

            List<string> iceCream = new List<string>();
            iceCream.Add("Chocolate");
            iceCream.Add("Pistachio");
            iceCream.Add("Vanilla");
            iceCream.Add("Orange Sherbet");
            iceCream.Add("Mint Chocolate Chip");

            Console.WriteLine(iceCream.Count);
            Console.WriteLine(iceCream[2]);
            iceCream.RemoveAt(2);
            Console.WriteLine(iceCream.Count);

            Dictionary<string, string> newDict = new Dictionary<string, string>();

            newDict.Add(nameArray[0], iceCream[rand.Next(0,4)]);
            // newDict.Add(nameArray[1], iceCream[rand.Next(0,4)]);
            // newDict.Add(nameArray[2], iceCream[rand.Next(0,4)]);
            // newDict.Add(nameArray[3], iceCream[rand.Next(0,4)]);
            foreach (KeyValuePair<string,string> name in newDict)
            {
                Console.WriteLine(name.key + name.value);
            }

            Console.WriteLine("Hello World!");
        }
    }
}
