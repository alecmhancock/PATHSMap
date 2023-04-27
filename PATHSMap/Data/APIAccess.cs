﻿using System.Net.Http.Headers;

namespace PATHSMap.Data
{
    public class APIAccess
    {
        //setting up http client to make api calls
        private HttpClient _client;
        public APIAccess(HttpClient client)
        {
            _client = client;
        }

        public string GetJsonString(string url)
        {
            var response = _client.GetAsync(url).Result;
            var json = response.Content.ReadAsStringAsync().Result;
            return json;
        }   

        public static string Callout (string url)
        {
            var client = new HttpClient();
            var productValue = new ProductInfoHeaderValue("PATHSMap", "Alpha");
            client.DefaultRequestHeaders.UserAgent.Add(productValue);
            var response = client.GetAsync(url).Result;
            var rawjson =  response.Content.ReadAsStringAsync().Result;
            return rawjson;
        }

        
    }
}