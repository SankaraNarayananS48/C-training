using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http.Headers;
using System.Net.Http;

namespace ProductMVC.Models
{
    public static class globalvariable
    {
        public static HttpClient http = new HttpClient();
        static globalvariable()
        {
            http.BaseAddress = new Uri("https://localhost:44336/api/");
            http.DefaultRequestHeaders.Clear();
            http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}