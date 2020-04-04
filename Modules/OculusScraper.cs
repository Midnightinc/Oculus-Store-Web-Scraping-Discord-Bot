using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace Rift_S_Availability_Checker.Modules
{
    class OculusScraper
    {
        public static string CheckIfAvailable()
        {
            string url = "https://www.oculus.com/rift-s/?locale=en_US";

            var httpClient = new HttpClient();

            var html = httpClient.GetByteArrayAsync(url);

            var searchString = Encoding.UTF8.GetString(html.Result);

            if (searchString.Contains("Notify Me"))
            {
                return "The Oculus Rift S is still unavailable";
            }
            else
            {
                return "The Rift S is probably available";
            }
        }

        public static bool IsAvailable()
        {
            string url = "https://www.oculus.com/rift-s/?locale=en_US";

            var httpClient = new HttpClient();

            var html = httpClient.GetByteArrayAsync(url);

            var searchString = Encoding.UTF8.GetString(html.Result);

            if (searchString.Contains("Notify Me"))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
