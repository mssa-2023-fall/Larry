using System;
using System.Collections;
using System.Diagnostics;
using System.Reflection;
namespace Debugger
{
    public class Program
    {
        static void Main(string[] args)
        {
          string thisString = "Hello";
          string thatString = "Hello";
          bool twoStrings = thisString == thatString;
          Console.Write(twoStrings);


        }
    }
}