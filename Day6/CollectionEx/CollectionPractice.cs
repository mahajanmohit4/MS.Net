using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionEx
{
    class CollectionPractice
    {
     
       
        static void Main11()
        {
            SortedList sl = new SortedList();
            sl.Add(1, "Car");
            sl.Add(2, "Bike");
            sl.Add(3, "Dug Dugi");


            sl.Remove(3); // give Key
            sl.RemoveAt(1); // give index D location

            sl.Add(2, "Bike");
            sl.Add(3, "Dug Dugi");


            Console.WriteLine(sl.Contains(2));

            Console.WriteLine(sl.ContainsKey(12));

            ArrayList objKeys = (ArrayList)sl.GetKeyList();

            foreach (DictionaryEntry de in sl)
            {
                Console.WriteLine(de.Key+ " : "+ de.Value);
            }
            Console.ReadLine();
        }
    }
}
