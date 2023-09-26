using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Generate_Randoms_Sort_Binary_Tree
{
    public class NumberGenerator
    {
        public List<int> NumberGeneratorFunction()
        {
            //instantiate a random number generator
            Random random = new Random();

            //make a list to hold the values generated from the random number generator
            List<int> randomList = new List<int>();

            //define min/max range of numbers
            //for loop to iterate through and generate 1000 integers
            for (int i = 0; i < 1000; i++)
            {
                int number = random.Next(1, 100);

                randomList.Add(number);
            }
            //List.Sort
            randomList.Sort();
            randomList.Reverse();

            return randomList;

        }
    }
}
