using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_Stream
{
    public class File_Processor
    {
        public string InputFilePath { get; }

        public File_Processor(string filePath) => InputFilePath = filePath;

        public void Process() => Console.WriteLine($"Begin process of {InputFilePath}");
    }
}
