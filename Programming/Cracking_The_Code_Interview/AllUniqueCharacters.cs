// using System.Collections.Concurrent;
// using System.Reflection.Metadata;
// ///Implement an algorithm to determine if a string has all unique characters, what if you cannot use additional data structures?
// //A hashtable would be the best solution as a Data Structure.
// //With no Data Structure, I can sort them and check if the current equals the next. I can even use a LinkedList(if I knew how to)

// namespace UniqueCharacters
// {
//     class CharactersUnique
//     {
//         static void Main(string[] args)
//         {
//             string number1 = "allUniqueCharacters";
//             string number2 = "abcdefghijklmnopqrs";
//             //Turn to char array
//             var number1asCharArray = number1.ToCharArray();
//             var number2asCharArray = number2.ToCharArray();
//             //sort
//             Array.Sort(number1asCharArray);
//             Array.Sort(number2asCharArray);

//             //A bool to break the loop
//             bool stopIfTrue = false;

//             //A gap just so I can see the output better
//             Console.WriteLine();
            
//             for (int i = 0; i < number2asCharArray.Length; i++)
//             {
//                 for (int j = i + 1; j < number2asCharArray.Length; j++)
//                 {
//                     if (number1asCharArray[i] == number1asCharArray[j])
//                     {
//                         Console.WriteLine($"{number1asCharArray[i]} == {number1asCharArray[j]}");
//                         stopIfTrue = true;
//                         break;
//                     }

//                 }
//             }
//                 if (stopIfTrue)
//                 {
//                     Console.WriteLine("\nthe string has twin characters\n");
//                 }
//                 else { Console.WriteLine("\nno twin chars\n"); }
//         }
//     }
// }