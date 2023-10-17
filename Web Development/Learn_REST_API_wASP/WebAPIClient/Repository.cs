using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections;
using System.Net.Http.Headers;
using System.Diagnostics;

namespace WebAPIClient
{
    public record class Repository(
        [property: JsonPropertyName("name")] string Name);
}


