using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__DSA_Book
{
    public static class Lists
    {
        





        public static void ListOfLists()
        {
            List<object> arrayList = new List<object>();
            arrayList.Add(5);
            arrayList.AddRange(new object[] { 6, -7, 8 });
            arrayList.AddRange(new object[] { "Marcin", "Mary" });
            arrayList.Insert(5, 7.8);
            Console.Write(string.Join(" | ", arrayList)); 
            

        }
    }
}
