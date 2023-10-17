using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections;
using System.Net.Http.Headers;
using System.Diagnostics;
using System.Text.Json;

namespace WebAPIClient
{

    class Program
    {
        static async Task Main(string[] args)
        {
            using HttpClient client = new();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");


            await ProcessRepositoriesASync(client);

           /* #region  Deserializing {"name:"} to {Name:}
            static async Task ProcessRepositoriesASync(HttpClient client)
            {


                await using Stream stream =
         await client.GetStreamAsync("https://api.github.com/orgs/dotnet/repos");

                //deserialize repos to c#
                var repositories =
                await JsonSerializer.DeserializeAsync<List<Repository>>(stream);


                //output a List of type Repository
                Console.Write(repositories);
                foreach (var repo in repositories ?? Enumerable.Empty<Repository>())
                    Console.Write(repo.Name);
            }
            #endregion
           */
            static async Task<List<Repository>> ProcessRepositoriesASync(HttpClient client)
            {
                await using Stream stream =
                await client.GetStreamAsync("https://api.github.com/orgs/dotnet/repos");
                var repositories =
                await JsonSerializer.DeserializeAsync<List<Repository>>(stream);
                return repositories ?? new();
            }

        }
    }

    public class ProcessingRepos
    {

    }

}