using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using Microsoft.Azure.WebJobs.Extensions.Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace E4_SmsPhoneVerification
{
    public static class E4_SendSmsChallenge
    {
        [FunctionName("E4_SendSmsChallenge")]
        public static int SendSmsChallenge(
    [ActivityTrigger] string phoneNumber,
    ILogger log,
    [TwilioSms(AccountSidSetting = "TwilioAccountSid", AuthTokenSetting = "TwilioAuthToken", From = "%TwilioPhoneNumber%")]
        out CreateMessageOptions message)
        {
            // Get a random number generator with a random seed (not time-based)
            var rand = new Random(Guid.NewGuid().GetHashCode());
            int challengeCode = rand.Next(10000);

            log.LogInformation($"Sending verification code {challengeCode} to {phoneNumber}.");

            message = new CreateMessageOptions(new Twilio.Types.PhoneNumber(phoneNumber));
            message.Body = $"Your verification code is {challengeCode:0000}";

            return challengeCode;
        }
    }
}
