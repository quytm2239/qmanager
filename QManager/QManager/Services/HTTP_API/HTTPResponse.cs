using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace QManager.Services.HTTP_API
{
    public class APIResponse
    {
        public bool success;
        public string message;
        public List<Object> data;
        public string token;

        public APIResponse(string json)
        {
            var obj = (JObject)JsonConvert.DeserializeObject(json);
            success = obj[APIGlossary.RES_KEY_SUCCESS].Value<bool>();
            message = obj[APIGlossary.RES_KEY_MESSAGE].Value<string>();
            data = obj[APIGlossary.RES_KEY_DATA] != null ? (obj[APIGlossary.RES_KEY_DATA]).ToObject<List<Object>>() : new List<Object>();
            token = obj[APIGlossary.RES_KEY_TOKEN] != null ? (obj[APIGlossary.RES_KEY_TOKEN]).ToObject<string>() : "";
         }
    }
}
