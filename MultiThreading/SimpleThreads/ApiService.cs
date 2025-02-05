using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleThreads
{
    public class ApiService
    {
        private readonly HttpClient _httpClient = new();

        //1. seçenek:

        public async Task<List<string>> GetAsyncWithWaitAll()
        {
            var tasks = Enumerable.Range(1, 1000)
                        .Select(x => _httpClient.GetStringAsync($"https://sample/api/{x}"))
                        .ToList();

            //dead lock olabilir:
            Task.WaitAll(tasks.ToArray());
            return tasks.Select(r => r.Result).ToList();


        }

        //2. seçenek:
        public async Task<List<string>> GetAsyncWithWhenAll()
        {
            var tasks = Enumerable.Range(1, 1000)
                        .Select(x => _httpClient.GetStringAsync($"https://sample/api/{x}"))
                        .ToList();

            //dead lock olmaz:
            Task.WhenAll(tasks.ToArray());
            return tasks.Select(r => r.Result).ToList();


        }


    }
}
