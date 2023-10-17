// using System.Text;
// using System.Collections;
// using System.Reflection.Metadata;

// ///Given two strings, write a method to decide if one is a permutation of the other.

// namespace CheckPermutations
// {
//     class PermutationsCheck
//     {
//         static void Main(string[] args)
//         {
//             string no1 = "anagram";
//             string no2 = "nagaram";

//             //Check Length
//             if (no1.Length != no2.Length) {{ Console.WriteLine("These are not permutations of each other"); }}
//             //Sort both strings and then compare if they are equal
//             //Creating array
//             char[] no1ToCharArray = no1.ToCharArray();
//             char[] no2ToCharArray = no2.ToCharArray();

//             //Sort Array
//             Array.Sort(no1ToCharArray); 
//             Array.Sort(no2ToCharArray);

//             //In order to check if the string is equal, the CharArrays need to be converted back to strings using the 'new' keyword
//             string no1BackToString = new string(no1ToCharArray);
//             string no2BackToString = new string(no2ToCharArray);
            
//            // if( no1ToCharArray== no2ToCharArray){Console.WriteLine($"\nShould be congruent:\n {no1ToCharArray} == {no2ToCharArray}\n");}
//             Console.WriteLine();
//             Console.WriteLine($"{no1BackToString} == {no2BackToString}");

//         }
//     }
// }