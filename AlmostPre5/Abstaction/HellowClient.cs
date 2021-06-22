using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AlmostPre5.Abstaction
{
    class HellowClient
    {
        HttpClient client = new HttpClient();
        public HellowClient()
        {
            
        }

        public async Task<HttpResponseMessage> PostNewArticle(Post post)
        {
            StringContent content = new StringContent(JsonConvert.SerializeObject(post), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync("192.168.86.151:100000/article", content);
            return response;
        }

        public async Task<HttpResponseMessage> DeleteArticle(string id)
        {
            StringContent content = new StringContent($""
        }
    }
}
