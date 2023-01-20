using Newtonsoft.Json;
using Phichaya_1911310512.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Phichaya_1911310512.Services
{
    public class PicService : IPicService
    {

        string Base_url = "https://api.nasa.gov/planetary/apod?api_key=Y6WnWNNDux7McC1MUewjTuf0UnsNDeg29c65MERF";
        public async Task<PicDetail> getPic()
        {
            string url = Base_url;

            HttpClient client = new HttpClient();
            HttpResponseMessage responseMessage = await client.GetAsync(url);

            if (responseMessage.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var result = await responseMessage.Content.ReadAsStringAsync();
                var json = JsonConvert.DeserializeObject<PicDetail>(result);

                return json;
            }

            return null;
        }


    }
}
