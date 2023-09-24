namespace Learn_Stream
{
    public class Learn_System_IO
    {
        static void Main(string[] args)
        {
            /* HOW TO READ A STREAMED FILE => StreamReader reader = new StreamReader(@"C:\temp\file.txt");
            var data = reader.ReadLine();
            Console.WriteLine(data);
            Console.ReadLine(); */
            //  Console.WriteLine("Parsing command line options");
            //Commandline validation omitted for brevity
            //   var command = args[0];
            const string sourcePath = "C:\\temp\\The_Eclipse_Original.gif";
            const string destinationPath = "C:\\temp\\The_Eclipse.gif";
            /*
           char a = 'a';
           string abc = "abc";
           decimal num = 12.34M;
           long num2 = 56;
           int num3 = 78;
           double num4 = 90.99;

           // StreamReader reader = new StreamReader(thePath);
           //READ => var data = reader.ReadLine();
           Stream streamOfBytes = new FileStream(thePath, FileMode.OpenOrCreate);
           BinaryWriter writer = new BinaryWriter(streamOfBytes);
           writer.Write(a);
           writer.Write(abc);
           writer.Write(num);
           writer.Write(num2);
           writer.Write(num3);
           writer.Write(num4);
           writer.Flush();
           writer.Close();
            */
            FileStream streamOfBytes = new FileStream(sourcePath, FileMode.Create, FileAccess.ReadWrite);
            BinaryWriter writeMe = new BinaryWriter(streamOfBytes);
            byte[] emptyBytes = Array.Empty<byte>();
            for (int i = 0; i < streamOfBytes.Length; i++)
            {
                writeMe.Write(emptyBytes, 0, i);


            }
            writeMe.Flush();
            writeMe.Close();
            Console.ReadLine();
        }

    }
}


//arrange: 
// 1 create a file Stream to store data at binary.bin
// 2 construct BinaryWriter with above stream
//act: write char,string, decimal, int64,int32 and write a double
//dont forget to flush and close the file