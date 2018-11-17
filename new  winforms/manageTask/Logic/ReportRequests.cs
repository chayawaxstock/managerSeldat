using manageTask.HelpModel;
using manageTask.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace manageTask.Logic
{
    class ReportRequests
    {
        public static List<ReportProject> getSimpleWorkers()
        {
            HttpClient client1 = new HttpClient();
            client1.BaseAddress = new Uri(@"http://localhost:61309/");
            client1.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response1 = client1.GetAsync($"api/Users/getWorkers").Result;
            if (response1.IsSuccessStatusCode)
            {
                var CardsJson = response1.Content.ReadAsStringAsync().Result;
                List<ReportProject> workers = JsonConvert.DeserializeObject<List<ReportProject>>(response1.Content.ReadAsStringAsync().Result);
                if (workers != null)
                    return workers;
                return null;

            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response1.StatusCode, response1.ReasonPhrase);
                return null;
            }

        }
    }
}
