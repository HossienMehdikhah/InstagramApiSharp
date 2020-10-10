using InstagramApiSharp.API.Builder;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Logger;
using System;

namespace ConsoleTest
{
    class Program
    {
        public static void Main(string[] args)
        {
            var userSession = new UserSessionData
            {
                UserName = "fifia181818",
                Password = "P&GB3cn#ZYBBS#HdhVK5nnF4X"
            };
            

            var delay = RequestDelay.FromSeconds(2, 2);
            // create new InstaApi instance using Builder
            var InstaApi = InstaApiBuilder.CreateBuilder()
                .SetUser(userSession)
                .UseLogger(new DebugLogger(LogLevel.All)) // use logger for requests and debug messages
                .SetRequestDelay(delay)
                .Build();

            var temp =  InstaApi.LoginAsync().Result;
            var temp1 = InstaApi.GetCurrentUserAsync().Result;


            Console.WriteLine("Hello World!");
        }
    }
}
