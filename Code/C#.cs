using System;
using System.Net;
using System.Net.Http;

namespace MacVendorLookup
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("MAC: ");
                string macAddress = Console.ReadLine();

                using (HttpClient httpClient = new HttpClient())
                {
                    Uri uri = new Uri("http://api.macvendors.com/" + WebUtility.UrlEncode(macAddress));
                    Console.WriteLine(macAddress + " --> " + httpClient.GetStringAsync(uri).Result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
