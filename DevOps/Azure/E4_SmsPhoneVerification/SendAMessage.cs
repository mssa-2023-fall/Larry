/*using System;
using System.Collections.Generic;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

class Example
{
    static void Main(string[] args)
    {
        var accountSid = "ACef2614795d9de423f5f2d44c085ec2ae";
        var authToken = "[AuthToken]";
        TwilioClient.Init(accountSid, authToken);

        var messageOptions = new CreateMessageOptions(
          new PhoneNumber("+13059858348"));
        messageOptions.From = new PhoneNumber("+18442551247");
        messageOptions.Body = "Test";


        var message = MessageResource.Create(messageOptions);
        Console.WriteLine(message.Body);
    }
}*/