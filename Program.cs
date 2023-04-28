using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;


namespace WhatsappMsg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wait.. Loading WhatsApp API");

            
            const string accountSid = "YourAccountSid";
            const string authToken = "YourAuthToken";


            TwilioClient.Init(accountSid, authToken);


            var message = MessageResource.Create(
                from: new Twilio.Types.PhoneNumber("whatsapp:(countrycodewithsendernumber"),
                body: "Hello! Black Coder",
                 to: new Twilio.Types.PhoneNumber("whatsapp:(CountryCodewithreceivernumberWhichisAuthenticated)")
            );


            Console.WriteLine("Message response: {0}", message.Sid);
            Console.ReadLine();
        }
    }
}
