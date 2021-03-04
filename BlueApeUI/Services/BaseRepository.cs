using BlueApeUI.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;

namespace BlueApeUI.Services
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly HttpClient _client;
        public BaseRepository(HttpClient client)
        {
            _client = client;
        }
        public async Task<bool> Create(string url, T obj)
        {
            HttpResponseMessage response = await _client.PostAsJsonAsync(url, obj);
            if (response.StatusCode == System.Net.HttpStatusCode.Created) return true;
            else return false;
        }

        public async Task<bool> Delete(string url, int id)
        {
            if (id < 1) return false;
            HttpResponseMessage response = await _client.DeleteAsync(url + id);
            if (response.StatusCode == System.Net.HttpStatusCode.NoContent) return true;
            else return false;
        }

        public async Task<T> Get(string url, int id)
        {
            var reponse = await _client.GetFromJsonAsync<T>(url + id);

            return reponse;
        }

        public async Task<IList<T>> Get(string url)
        {
            try
            {
                var reponse = await _client.GetFromJsonAsync<IList<T>>(url);
                return reponse;

            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<bool> Update(string url, T obj, int id)
        {
            if (obj == null) return false;
            var response = await _client.PutAsJsonAsync<T>(url + id, obj);

            if (response.StatusCode == System.Net.HttpStatusCode.NoContent) return true;
            return false;
        }
    }
}
