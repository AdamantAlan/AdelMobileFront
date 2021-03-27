using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using AdelMobileFront.Dtos;
using Newtonsoft.Json;
namespace AdelMobileFront.services
{
  static  class BooksService
    {
        internal static async  Task<T> GetBookAsync<T>() where T: class
        {
            try { 
            using (HttpClientHandler handler = new HttpClientHandler())
            {
                using (HttpClient client = new HttpClient(handler))
                {
                    using (HttpResponseMessage response = await client.GetAsync(UriApiGetOfBook<T>()))
                    {
                        var bookJson = await response.Content.ReadAsStringAsync();
                        if (string.IsNullOrEmpty(bookJson))
                            return null;
                        T book = JsonConvert.DeserializeObject<T>(bookJson);
                        return book;
                    }
                }
            }

            } catch (AggregateException exs)
            {
                    return null;
            }
        }
        internal static async Task<Dictionary<string, BookDto>> GetAllBookAsync() 
        {
            try
            {
                using (HttpClientHandler handler = new HttpClientHandler())
                {
                    using (HttpClient client = new HttpClient(handler))
                    {
                        using (HttpResponseMessage response = await client.GetAsync("http://adamantalan-001-site1.gtempurl.com/api/v1/ficbook/all/get"))
                        {
                            var bookJson = await response.Content.ReadAsStringAsync();
                            if (string.IsNullOrEmpty(bookJson))
                                return null;
                            Dictionary<string, BookDto> books = JsonConvert.DeserializeObject<Dictionary<string, BookDto>>(bookJson);
                            return books;
                        }
                    }
                }
            }
            catch (AggregateException exs)
            {
                return null;
            }
        }

        private static string UriApiGetOfBook<T>()
        {
            if (typeof(T).Name is "Rubin")
                return "http://adamantalan-001-site1.gtempurl.com/api/v1/ficbook/rubin/get";
            if (typeof(T).Name is "Woll")
                return "http://adamantalan-001-site1.gtempurl.com/api/v1/ficbook/rubin/get";
            if (typeof(T).Name is "Prayer")
                return "http://adamantalan-001-site1.gtempurl.com/api/v1/ficbook/rubin/get";
            if (typeof(T).Name is "Portrait")
                return "http://adamantalan-001-site1.gtempurl.com/api/v1/ficbook/rubin/get";
            return null;
        }
    }
}
