using System;
using System.Collections.Specialized;
using System.Configuration;

namespace ConConfig_ConsoleApp
{
    class Program
    {
        //-- https://docs.microsoft.com/en-us/troubleshoot/dotnet/csharp/store-custom-information-config-file
        static void Main(string[] args)
        {
            string iskola;
            string osztaly;

            // Read a particular key from the config file 
            iskola = ConfigurationManager.AppSettings.Get("suli");
            osztaly = ConfigurationManager.AppSettings.Get("osztaly");
            Console.WriteLine($"{iskola} iskola {osztaly} osztálya" + Environment.NewLine);

            // Read all the keys from the config file
            NameValueCollection sAll;
            sAll = ConfigurationManager.AppSettings;

            foreach (string s in sAll.AllKeys)
                Console.WriteLine("Key: " + s + " Value: " + sAll.Get(s));

            Console.ReadLine();
        }
    }
}
