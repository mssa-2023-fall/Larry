using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections;
using System.Net.Http.Headers;
using System.Diagnostics;
using System.Text.Json;
using System.IO;
using System.Dynamic;


namespace WebAPIClient_Dictionary_APINinja
{
    public class WordResponse
    {
        public string Definition { get; set; }
        public string Word { get; set; }
        public bool Valid { get; set; }
    }

    class Program
    {
        static async Task Main(string[] args)
        {
            string apiKey = Environment.GetEnvironmentVariable("API_NINJAS_KEY");
            Console.WriteLine("What word would you like to search for?");

            string word = Console.ReadLine();
            
            string apiUrl = $"https://api.api-ninjas.com/v1/dictionary?word={word}";

            using HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("X-Api-Key", apiKey);
            
            HttpResponseMessage response = await client.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                WordResponse wordResponse = JsonSerializer.Deserialize<WordResponse>(responseBody);
                
                Console.WriteLine($"Word: {wordResponse.Word}");
                Console.WriteLine($"Definition: {wordResponse.Definition}");
                Console.WriteLine($"IsValid: {wordResponse.Valid}");
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode} {await response.Content.ReadAsStringAsync()}");
            }
        }
    }
}






































































/*
namespace WebAPIClient_Dictionary_APINinja
{

    class Program
    {
        static async Task Main(string[] args)
        {
            using HttpClient client = new();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");


            await ProcessDictionaryAsync(client);

            #region  Deserializing 1 property of {"name:"} to {Name:}
            
             static async Task ProcessDictionaryAsync(HttpClient client)
             {


                 await using Stream stream =
          await client.GetStreamAsync("https://api.api-ninjas.com/v1/dictionary?word=");

                 //deserialize repos to c#
                 var words =
                 await JsonSerializer.DeserializeAsync<List<Words>>(stream);


                 //output a List of type Repository
                 Console.Write(words);
                 foreach (var word in words ?? Enumerable.Empty<Words>())
                     Console.Write(word.Word);
             }
             
             #endregion
            
            #region Output of multiple JSON formatted requests
            /*
            static async Task<List<Repository>> ProcessDictionaryAsync(HttpClient client)
            {
                await using Stream stream =
                await client.GetStreamAsync("https://api.github.com/orgs/dotnet/repos");
                var repositories =
                await JsonSerializer.DeserializeAsync<List<Repository>>(stream);
                foreach (var repo in repositories)
                {
                    Console.WriteLine($"Name: {repo.Name}");
                    Console.WriteLine($"Homepage: {repo.Homepage}");
                    Console.WriteLine($"GitHub: {repo.GitHubHomeUrl}");
                    Console.WriteLine($"Description: {repo.Description}");
                    Console.WriteLine($"Watchers: {repo.Watchers:#,0}");
                    Console.WriteLine($"Time: {repo.LastPush}");
                    Console.WriteLine();
                } 


                return repositories ?? new();

            }
            #endregion
        }
    }

    public class ProcessingRepos
    {

    }

}
*/