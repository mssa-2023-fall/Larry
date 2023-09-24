using System;
using System.Security.Cryptography.X509Certificates;

namespace Generate_Randoms_Sort_Binary_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new NumberGenerator();
            foreach (var n in numbers.NumberGeneratorFunction()) { Console.WriteLine(n); }
            
            
        }
    }
}



/// Generate random 1000 integer
/// and sort it, then reverse it
/// 
/// Generate Random 1000 integer
/// and sort it, then build a binary tree
/// 
/// generate 100 integer 
/// use the binary tree to see if some value is present
/// 
/// prepare dictionary<bool,int[]>
/// 
/// true => present results
/// false => do not present results
///
///
///
///
///
///