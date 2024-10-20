﻿namespace OnlineEdu.WebUI_.Helpers
{
    public static class HttpClientInstance
    {
        public  static HttpClient CreateClient() 
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7144/api/");
            return client;
        }
    }
}
