using static System.Net.WebRequestMethods;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();



//Prompts the user for a search result, redirects to letmegooglethat.com for querying.


Console.WriteLine("What would you like to search");
var prompt = Console.ReadLine();
app.Run(async context =>
{
    //formats the prompt for URIs
    string search = $"https://letmegooglethat.com/?q={Uri.EscapeDataString(prompt)}";
    context.Response.Redirect(search);
});

app.Run();
