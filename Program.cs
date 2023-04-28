﻿using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;


namespace WhatsappMsg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello WhatsApp");

            
            const string accountSid = "AC0d285817bb37f597f090dd51eba59c";
            const string authToken = "5c590f16112063f61d250d980dfa";


            TwilioClient.Init(accountSid, authToken);


            var message = MessageResource.Create(
                from: new Twilio.Types.PhoneNumber("whatsapp:+141"),
                body: "Hello! Black Coder",
                 to: new Twilio.Types.PhoneNumber("whatsapp:+9187")
            );


            Console.WriteLine("Message response: {0}", message.Sid);
            Console.ReadLine();
        }
    }
}
