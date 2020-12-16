using Shopping_App.Repo.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Shopping_App.Repo
{
    public class Repo<T> : IRepo<T> where T : class
    {
        private readonly IHttpClientFactory clientfactory;

        public Repo(IHttpClientFactory _clientfactory)
        {
            clientfactory = _clientfactory;
        }
        public Task<bool> CreateAsync(string url, T objectCreate)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, url);
            if (objectCreate != null)
            {
                request.Content = new StringContent(JsonConvert)
            }
        }

        public Task<T> DeleteAsync(string url, int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAllAsync(string url)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetAsync(string url, int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(string url, T objectUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
