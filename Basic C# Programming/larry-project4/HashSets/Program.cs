//HashSet type String using the .Add method 
HashSet<string> firstSet = new HashSet<string>();
firstSet.Add("a");
firstSet.Add("b");
firstSet.Add("c");
firstSet.Add("d");
firstSet.Add("e");
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
    Console.WriteLine(e);
}

//Attempting to use the .Remove() method for Hashsets.
Console.WriteLine($"\nCurrently I have {firstSet.Count()} hashes available");
//.Remove()
firstSet.Remove("a");
Console.WriteLine($"\nNow I have {firstSet.Count} hashes.");
//Using the .Clear() method
firstSet.Clear();
Console.WriteLine($"\nUsing the .Clear() method: \nAfter using the .Clear() method, I have {firstSet.Count()} hashes. ");















Console.ReadLine();