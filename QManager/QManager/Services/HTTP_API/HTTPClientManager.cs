using System;
using System.Collections.Generic;
using System.Net.Http;

namespace QManager.HTTP_API.Services
{
    public class HTTPClientManager
    {
        private HttpClient httpClient;
        private static readonly HTTPClientManager instance = new HTTPClientManager();

        private HTTPClientManager()
        {
            httpClient = new HttpClient();
        }
        
        public static HTTPClientManager SharedInstance()
        {
            return instance;
        }

        public async void Get(string url, Dictionary<string,object> param)
        {

            var response = await httpClient.DeleteAsync(url);
            var responseString = await response.Content.ReadAsStringAsync();
        }

        public async void Post(string url, Dictionary<string,string> param)
        {
            var content = new FormUrlEncodedContent(param);
            var response = await httpClient.PostAsync(url, content);
            var responseString = await response.Content.ReadAsStringAsync();
        }

        public async void Put(string url, Dictionary<string, string> param)
        {
            var content = new FormUrlEncodedContent(param);
            var response = await httpClient.PutAsync(url, content);
            var responseString = await response.Content.ReadAsStringAsync();
        }

        public async void Delete(string url, string key, Int64 param)
        {
            var response = await httpClient.DeleteAsync(url + key + param);
            var responseString = await response.Content.ReadAsStringAsync();
        }

        public async void Delete(string url, string key, string param)
        {
            var response = await httpClient.DeleteAsync(url + param);
            var responseString = await response.Content.ReadAsStringAsync();
        }
    }
}
