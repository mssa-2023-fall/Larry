//HashSet type String using the .Add method [5]
using System;
using System.Resources;

HashSet<string> firstSet = new HashSet<string>();
firstSet.Add("Types of Plants: ");
firstSet.Add("Agave");
firstSet.Add("Agapetes");
firstSet.Add("Adenia");
firstSet.Add("Azalea");
firstSet.Add("Acacia");
firstSet.Add("Bambusa");
Console.WriteLine("\nUsing the .Add Method for adding: ");
foreach(var n in firstSet)
{
    Console.WriteLine(n);
}

//HashSet type int using the {} for initialization
HashSet<int> secondSet = new HashSet<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
Console.WriteLine("\nUsing {} for instant intialization: ");
foreach(var e in secondSet)
{
    Console.Write("{0},",e);
}

//Attempting to use the .Remove() method for Hashsets.
Console.WriteLine($"\n\nCurrently I have {secondSet.Count()} hashes available");
//.Remove()
secondSet.Remove(1);
Console.WriteLine($"\nNow I have {secondSet.Count} hashes, after using the .Remove() method.");
//Using the .Clear() method
//firstSet.Clear();
//Console.WriteLine($"\nUsing the .Clear() method: \nAfter using the .Clear() method, I have {firstSet.Count()} hashes. ");

/// Creating a new thirdSet[4]
/// Using my preferred method for adding hashes
/// The {} initialization:
HashSet<string> thirdSet = new HashSet<string>()
{
   "Bambusa","Bauhinia","Billbergia","Bulbine","Biophytum","Azalea"
};
/// using the UnionWith method
/// Adds 2 hashsets(of the same type) together.
/// firstset(string) secondset(int) won't work.
/*firstSet.UnionWith(thirdSet);
Console.WriteLine("\nUsing the .UnionWith() for firstSet and thirdSet: \n");
foreach(var u in firstSet)
{
    Console.WriteLine($"{u}");
}
*/
///The .IntersectWith() method will only output
///values that are included in both Collections
/*firstSet.IntersectWith(thirdSet);
Console.WriteLine("\nShowing firstSet with the IntersectWith(thirdSet) method:");
foreach(var i in firstSet)
{
    Console.WriteLine($"{i}");
}
Console.WriteLine($"\nShowing with the .ExceptWith() method:\n");
*/
///The .ExceptWith() method will output all values
///that are unique to the firstSet
/*firstSet.ExceptWith(thirdSet);
foreach(var e in firstSet)
{
    Console.WriteLine($"{e}");
}
*/

///Running IF statements for HashSets
///Checking if the firstSet contians Azalea
Console.WriteLine("\nDoes the firstSet contain 'Azalea':");
if (firstSet.Contains("Azalea"))
{
    Console.WriteLine("\nThe firstSet contains Azalea");
}
else
{
    Console.WriteLine("\nDoes not contain Azalea");
}

///Pulling an array into a HashSet in order to remove Duplicates
///HashSets do not allow duplicates into their collection
///Creating string[]
string[] placesIWantToGo = { "Chiang Mai", "Tokyo", "Bogota", "MachuPichu", "Ontario", "Scandanavia", "Alaska","Chiang Mai" };
///Creating a HashSet
HashSet<string> places = new HashSet<string>(placesIWantToGo);
///outputting values with a foreach(hash)
Console.WriteLine("\nPlaces I want to go to: \n");
foreach(var place in places)
{
    Console.WriteLine(place);
}

Console.WriteLine($"\nAttempting 'Remove Duplicates from Sorted Array in LeetCode:\n");
int[] tip = { 123, 123, 4, 1223, 124, 12, 22342, 354325, 21312, 31232, 1, 12, 3, 2, 2, 1, 1, 2, 2 };
var sheathe = new Sword();
Console.WriteLine(sheathe.RemoveDuplicates(tip));


///FAILED LEETCODE

Console.ReadLine();




















public class Sword
{
    public int RemoveDuplicates(int[] nums)
    {
        int numsLength = nums.Length;
        HashSet<int> moreNums = new HashSet<int>(nums);

        for (int count = numsLength - 1; count <= 0; count++)
        {
            moreNums.Add(nums[count]);
            count++;
        }
        int saveNums = moreNums.Count();
         
        return numsLength
    }
    /*
    public int Remove_Duplicates(int[] nums)
    {
        int finalNums = 0;
        foreach(var n in nums)
        {
            finalNums = n;
        }
        return finalNums;
    }*/
}