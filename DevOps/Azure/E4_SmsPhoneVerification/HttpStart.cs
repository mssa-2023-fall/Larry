using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;

namespace E4_SmsPhoneVerification
{
    public static class HttpStart
    {
        [FunctionName("HttpStart")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req,
            [DurableClient] IDurableClient starter,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            // Ensure the request body is read as a JSON string
            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);

            // Directly access the phoneNumber property from the dynamic object
            string phoneNumber = data?.phoneNumber;

            if (string.IsNullOrEmpty(phoneNumber))
            {
                return new BadRequestObjectResult("Please pass a phoneNumber in the request body.");
            }

            // Start the orchestrator function
            string instanceId = await starter.StartNewAsync<string>("E4_SmsPhoneVerification", phoneNumber);

            log.LogInformation($"Started orchestration with ID = '{instanceId}'.");

            // Returns a check status response to the client
            return starter.CreateCheckStatusResponse(req, instanceId);
        }
    }
}
