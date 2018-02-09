using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using QManager.Properties;

namespace QManager.Services.HTTP_API
{
    public class HTTPClientManager
    {
        private HttpClient httpClient;
        private static readonly HTTPClientManager instance = new HTTPClientManager();
        private string HOST_PORT = "http://" + Settings.Default.APIHost + ":" + Settings.Default.APIPort;

        private HTTPClientManager()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(HOST_PORT);
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded"));
        }

        public static HTTPClientManager Shared()
        {
            return instance;
        }

        private string CreateQueryStr(Dictionary<string, object> param)
        {
            var queryStr = "";
            var keyCollection = param.Keys;
            foreach (string key in keyCollection) {
                queryStr = queryStr + (queryStr.Length > 0 ? "&" : "") + key + "=" + param[key];
            }
            return "?" + queryStr;
        }

        private async Task<APIResponse> CreateResponseObjAsync(HttpResponseMessage raw)
        {
            string contentStr = await raw.Content.ReadAsStringAsync();
            return new APIResponse(contentStr);
        }

        private void SetToken(string token)
        {
            httpClient.DefaultRequestHeaders.Add(APIGlossary.RES_KEY_TOKEN, token);
        }

        private void ClearToken()
        {
            httpClient.DefaultRequestHeaders.Remove(APIGlossary.RES_KEY_TOKEN);
        }

        // RE-USE HTTP METHOD CALL
        public async Task<APIResponse> Get(string url, Dictionary<string,object> param)
        {
            var response = await httpClient.GetAsync(url + (param != null ? CreateQueryStr(param) : ""));
            APIResponse result = await CreateResponseObjAsync(response);
            return result;
        }

        public async Task<APIResponse> Post(string url, Dictionary<string,string> param)
        {
            var content = new FormUrlEncodedContent(param);
            var response = await httpClient.PostAsync(url, content);
            APIResponse result = await CreateResponseObjAsync(response);
            return result;
        }

        public async Task<APIResponse> Put(string url, Dictionary<string, string> param)
        {
            var content = new FormUrlEncodedContent(param);
            var response = await httpClient.PutAsync(url, content);
            APIResponse result = await CreateResponseObjAsync(response);
            return result;
        }

        public async Task<APIResponse> Delete(string url, Dictionary<string, string> param)
        {
            var request = new HttpRequestMessage(HttpMethod.Delete, url) {
                Content = new StringContent(JsonConvert.SerializeObject(param), Encoding.UTF8)
            };
            var response = await httpClient.SendAsync(request);
            APIResponse result = await CreateResponseObjAsync(response);
            return result;
        }

        // CALL API FOR EACH BUSINESS CASE
        public async Task<APIResponse> Login(string username, string password)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string> {
                { APIGlossary.KEY_USERNAME, username },
                { APIGlossary.KEY_PASSWORD, password }
            };
            APIResponse responseObj = await Post(APIGlossary.API_LOGIN, dictionary);
            if (responseObj.token != null) SetToken(responseObj.token);
            return responseObj;
        }

        public async Task<APIResponse> GetAllDepartment()
        {
            APIResponse responseObj = await Get(APIGlossary.API_GET_ALL_DEPARTMENT, null);
            return responseObj;
        }

        public void Logout() => ClearToken();
    }
}
