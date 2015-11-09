namespace JsonPlaceholder.ConsoleClient
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    public class Start
    {
        private const string requestUri = "posts";

        static void Main()
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://jsonplaceholder.typicode.com/");
            var posts = GetPosts(httpClient, "sunt", 5).Result;
            PrintPosts(posts, httpClient.BaseAddress.ToString());    
        }

        static async Task<IEnumerable<Post>> GetPosts(HttpClient httpClient, string queryString, int count)
        {
            var response = await httpClient.GetAsync(requestUri);            
            var postsAsString = await response.Content.ReadAsStringAsync();
            var postsAsJson = JsonConvert
                .DeserializeObject<List<Post>>(postsAsString)
                .Where(p => p.Title.Contains(queryString))
                .Take(count);
            return postsAsJson;
        }

        static void PrintPosts(IEnumerable<Post> posts, string baseAddress)
        {
            foreach (var post in posts)
            {
                Console.WriteLine("Post title: " + post.Title);
                Console.WriteLine("Post URl: " + baseAddress + requestUri + "/" + post.Id);
            }

            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();
        }
    }
}
