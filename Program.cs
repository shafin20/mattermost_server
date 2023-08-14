using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MattermostConnection
{
    /*class channel {
        public String  team_id { get; set; }

        public String name {get; set;}
        public String  display_name { get; set; }
        public String  purpose { get; set; }
        public String  header { get; set; }
        public String  type { get; set; }
        


        
    }
class createPost{
    public string username {get;set;}
    public string display_name {get;set;}
    public string description {get;set;}
}*/

    class Program
    {
        static async Task Main(string[] args)
        {var json = System.IO.File.ReadAllText(@"C:\TestApp\test.json");
            Console.WriteLine(json);
            //Console.ReadLine();
            string mattermostBaseUrl = "http://172.174.225.188";
            string personalAccessToken = "6udotg5pgprq9dp1y7hifokb6c";
            // GenerateChatMessage message = new GenerateChatMessage();
            // ChatMessage[] messages =  message.CreateChatMessage();

            // foreach (var m in messages)
            // {
            //     Console.WriteLine(m);
            //     Console.WriteLine();
            // }


          /*channel req= new channel();
          req.team_id = "5zqx6p7ya3fddnw6yz4qgywkir";
          req.display_name = "demo";
          req.purpose = "test test test";
          req.name = "demo";
          
          req.type = "O";*/


 for(int i=0;i<10;i++)
                { 
            using (var httpClient = new HttpClient())
            {
                //httpClient.BaseAddress = new Uri(mattermostBaseUrl);
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", personalAccessToken);
                
/*
                var response = await httpClient.GetAsync("/api/v4/users/me/teams");
                if (response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(responseBody);
                }
                else
                {
                    Console.WriteLine($"Failed to connect. Status code: {response.StatusCode}");
                }*/
                //var jsonString = JsonConvert.SerializeObject(botreq);
                
               
                //json = json.Replace("hello","hello-"+i);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response1 = await httpClient.PostAsync("http://172.174.225.188/api/v4/posts", content);
                if (response1.IsSuccessStatusCode)
                {
                    var responseBody1 = await response1.Content.ReadAsStringAsync();
                    Console.WriteLine(responseBody1);
                }
                else
                {
                    var responseBody1 = await response1.Content.ReadAsStringAsync();
                    Console.WriteLine(responseBody1);
                    Console.WriteLine($"Failed to connect. Status code: {response1}");
                }
                }
            }
        }
    }
}
