using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
using System.Xml.Serialization;

//input all winners into a separate csv
namespace Learn_List
{
    public class Winners
    {
        //My Condition
        public void Conditions()

        {
            int Index { get; set; }
            int Year { get; set; }
            int Age { get; set; }
            string Name { get; set; }
            string Movie { get; set; }
            string inputCsv = "C:\\Users\\lol4l\\source\\repo\\mssa-2023-fall\\Larry\\C# Programming\\Learning_Programming_Projects\\Learn_List\\oscar_age_male.csv";
            string outputCsv = "C:\\Users\\lol4l\\source\\repo\\mssa-2023-fall\\Larry\\C# Programming\\Learning_Programming_Projects\\Learn_List\\Winners.csv";
            //DOESNT WORK var filterCondition = new Func<Name, bool>(p => p.Age >= 18); // Example filter condition
            using(var reader = new StreamReader(inputCsv))
            using(var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                 var records = csv.GetRecords<Person>().ToList(); // Read and parse the CSV

            var filteredRecords = records.Where(filterCondition).ToList(); // Apply the filter condition

            using (var writer = new StreamWriter(outputCsv))
            using (var csvWriter = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                csvWriter.WriteRecords(filteredRecords); // Write the filtered records to the output CSV
            }

            Console.WriteLine("Filtered CSV has been created.");
            }


        }

    }
}