using System;
using System.Collections;
using System.Collections.Generic;

namespace Cracking_The_Coding_Interview
{
    class Simple_Hashtable
    {
        public void Hashtable()
        {
            Hashtable hashtable = new Hashtable(10);
            hashtable.Add(100, "Spongebob");
            hashtable.Add(123, "Patrick");
            hashtable.Add(122, "Patrick");
            hashtable.Add(321, "Sandy");
            hashtable.Add(555, "Squidward");
            hashtable.Add(777, "Gary");

            foreach (var value in hashtable)
            {
                Console.WriteLine($"{hashtable.GetHashCode()}, {value}");

            }
        }

    }

}