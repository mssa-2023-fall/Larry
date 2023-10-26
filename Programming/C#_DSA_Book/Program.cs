using C__DSA_Book;
using System;
using System.Data.Common;
using System.Dynamic;

namespace CSharp_DSA_Book
{

    public class Program
    {
        static void Main(string[] args)
        {
            var linkedList = new LinkedList();
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);
            linkedList.Add(4);
            linkedList.Add(5);
            linkedList.Print();





        }

        #region Algorithm Outputs
        private static void SelectionSortOutput()
        {
            Console.WriteLine("Selection Sort: \nUnsorted___\n");
            int[] integerValues = { 90, 60, 80, 70, 100 };
            string[] stringValues = { "Charlie", "Echo", "Bravo", "Alpha", "Delta" };
            Console.WriteLine(string.Join(" | ", integerValues));
            Console.WriteLine("");
            Console.WriteLine(string.Join(" | ", stringValues));
            Console.WriteLine("\nSorted___\n");

            SelectionSort.Sort(integerValues);
            Console.WriteLine(string.Join(" | ", integerValues));
            Console.WriteLine("");
            SelectionSort.Sort(stringValues);
            Console.WriteLine(string.Join(" | ", stringValues));
        }

        private static void InsertionSortOutput()
        {
            Console.WriteLine("Insertion sort: \nUnsorted___\n");
            int[] integerValues = { 90, 60, 80, 70, 100 };
            string[] stringValues = { "Charlie", "Echo", "Bravo", "Alpha", "Delta" };
            Console.WriteLine(string.Join(" | ", integerValues));
            Console.WriteLine("");
            Console.WriteLine(string.Join(" | ", stringValues));
            Console.WriteLine("\nSorted___\n");

            InsertionSort.Sort(integerValues);
            Console.WriteLine(string.Join(" | ", integerValues));
            InsertionSort.Sort(stringValues);
            Console.WriteLine("");
            Console.WriteLine(string.Join(" | ", stringValues));
        }

        private static void QuickSortOutput()
        {
            Console.WriteLine("Quicksort: \nUnsorted___\n");
            int[] integerValues = { 90, 60, 80, 70, 100 };
            string[] stringValues = { "Charlie", "Echo", "Bravo", "Alpha", "Delta" };
            Console.WriteLine(string.Join(" | ", integerValues));
            Console.WriteLine("");
            Console.WriteLine(string.Join(" | ", stringValues));
            Console.WriteLine("\nSorted___\n");

            QuickSort.Sort(integerValues);
            Console.WriteLine(string.Join(" | ", integerValues));
            QuickSort.Sort(stringValues);
            Console.WriteLine("");
            Console.WriteLine(string.Join(" | ", stringValues));
        }

        private static void ListsOutput()
        {
            Lists.ListOfLists();
        }
        
        public static void PageOutput()
        {
            Page pageFirst = new Page() { Content = "Nowadays As someone who’s only spent 45$ to buy star citizen and have put 300+ hours into the game, I can confidently say that there’s a massive majority of people in the community who are just normal people who haven’t put 10k into it who are realistically positive about the news. Starcitizen fan doesn’t equal fanatic. I’d actually recommend starcitizen for 45$ if your pc is good enough. It’s a visual spectacle (...)" };
            Page pageSecond = new Page() { Content = "Application Damn. I dare the AngryJoe team to watch even a highlight reel of CitCon and give us a response to things like; server meshing, damage systems, water / fire tech, engineering... So much shown at the event! Not things they plan on making, things that are functioning and just need propagated or scaled as they work through the various test builds.(...)" };
            Page pageThird = new Page() { Content = "A lot of Also, reason for slowdown on SC is because the other 1300 employee were working on SQ42 and now they can go back and start implementing systems for SQ42 into SC. (...)" };
            Page pageFourth = new Page() { Content = "Do you know Also, reason for slowdown on SC is because the other 1300 employee were working on SQ42 and now they can go back and start implementing systems for SQ42 into SC. (...)" };
            Page pageFifth = new Page() { Content = "While You can respect a man's principles without agreeing with him politically. It's something modern America seems to struggle pretty hard with these days. (...)" };
            Page pageSixth = new Page() { Content = "Could you I never understood companies getting mad over video games using their cars/guns. Its not like the video game company stole it to make their own real car or gun lol, its just free product placement. (...)" };

            LinkedList<Page> pages = new LinkedList<Page>(); //new list is created
            pages.AddLast(pageSecond); //adding the data of the second page at the end of the list ([2])
            LinkedListNode<Page> nodePageFourth = pages.AddLast(pageFourth); //adding the data of the fourth page at the end of list ([2, 4])
            pages.AddLast(pageSixth); //adding the data of the sixth page at the end of the list ([2, 4, 6])
            pages.AddFirst(pageFirst); //adding the data of the first page at the beginning of the list ([1, 2, 4, 6])
            pages.AddBefore(nodePageFourth, pageThird); // Adding the data of the third page before the node of the fourth page ([1, 2, 3, 4, 6])
            pages.AddAfter(nodePageFourth, pageFifth); // Adding the data of the fifth page after the node of the fourth page ([1, 2, 3, 4, 5, 6])

            LinkedListNode<Page> current = pages.First;
            int number = 1;
            while (current != null)
            {
                Console.Clear();
                string numberString = $"- {number} -";
                int leadingSpaces = (90 - numberString.Length) / 2;
                Console.WriteLine(numberString.PadLeft(leadingSpaces
                    + numberString.Length));
                Console.WriteLine();

                string content = current.Value.Content;
                for (int i = 0; i < content.Length; i += 90)
                {
                    string line = content.Substring(i);
                    line = line.Length > 90 ? line.Substring(0, 90) : line;
                    Console.WriteLine(line);
                }

                Console.WriteLine();
                Console.WriteLine($"""
                    Quote from "Windows Application Development Cookbook" by Marcin Jamro, 
                    {Environment.NewLine}
                    published by Packt Publishing in 2016.
                    """);
                Console.WriteLine();
                Console.Write(current.Previous != null ? "< PREVIOUS [P]" : GetSpaces(14));
                Console.Write(current.Next != null ? "[N] Next >".PadLeft(76) : string.Empty);
                Console.WriteLine();

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.N:
                        if (current.Next != null)
                        {
                            current = current.Next;
                            number++;
                        }
                        break;
                    case ConsoleKey.P:
                        if (current.Previous != null)
                        {
                            current = current.Previous;
                            number--;
                        }
                        break;
                    default:
                        return;
                }
            }
        }
        private static string GetSpaces(int number)
        {
            string result = string.Empty;
            for (int i = 0; i < number; i++)
            {
                result += " ";
            }
            return result;
        }
        #endregion
    }
}


