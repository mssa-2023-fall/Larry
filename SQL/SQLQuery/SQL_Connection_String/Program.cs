using System;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {

            var queryThis = new NewTable();
            queryThis.ShowAllCustomers();
            Console.ReadLine();

        }

    }
}