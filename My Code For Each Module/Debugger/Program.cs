using System;
using System.IO;

namespace Debugger
{
    class Program
    {
        static void Main(string[] args)
        {
            var files = 0;
            var directory = Directory.CreateDirectory(@"C:\Users\lol4l\source\repos\class-projects\Larry\My Code For Each Module\Debugger\");
            for (int i = 0; i == 10; i++)
            {
                directory.CreateSubdirectory("testesttest");
            }

        }
    }

}
