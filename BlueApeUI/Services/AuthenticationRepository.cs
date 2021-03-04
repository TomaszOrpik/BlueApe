using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Blazored.LocalStorage;
using BlueApeUI.Contracts;
using BlueApeUI.Models.Users.Requests;
using BlueApeUI.Models.Users.Responses;
using BlueApeUI.Providers;
using Newtonsoft.Json;

namespace BlueApeUI.Services
{
    public class AuthenticationRepository : IAuthenticationRepository
    {
        private readonly HttpClient _client;
        private readonly ILocalStorageService _localStorage;
        private readonly ApiAuthenticationProvider _authenticationProvider;
        public AuthenticationRepository(IHttpClientFactory factory, ILocalStorageService localStorage, ApiAuthenticationProvider authenticationProvider)
        {
            _client = factory.CreateClient("baseClient");
            _localStorage = localStorage;
            _authenticationProvider = authenticationProvider;
        }
        public async Task<UserDataResponse> Login(LoginEntity user)
        {
            var response = await _client.PostAsJsonAsync($"{_client.BaseAddress}api/v1/Users/Login", user);
            Console.WriteLine(response.StatusCode);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var content = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<UserDataResponse>(content);
                await _localStorage.SetItemAsync("authToken", data.Token);
                await _authenticationProvider.GetAuthenticationStateAsync();
                data.StatusCode = response.StatusCode;
                return data;
            }
            string error;
            switch(response.StatusCode)
            {
                case HttpStatusCode.Unauthorized:
                    error = "Unauthorized Access";
                    break;
                case HttpStatusCode.BadRequest:
                    error = "Bad Request";
                    break;
                case HttpStatusCode.InternalServerError:
                    error = "Internal Server Error";
                    break;
                default:
                    error = "Undefined Error Occured";
                    break;
            }
            UserDataResponse failedResponse = new UserDataResponse(error, null, null, new DateTime());
            failedResponse.StatusCode = response.StatusCode;
            return failedResponse;
        }

        public Task Logout()
        {
            throw new NotImplementedException();
        }

        public async Task<UserDataResponse> Register(RegisterEntity user)
        {
            var response = await _client.PostAsJsonAsync($"{_client.BaseAddress}api/v1/Users/Register", user);
            if (response.StatusCode == System.Net.HttpStatusCode.Created)
            {
                var content = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<UserDataResponse>(content);
                data.StatusCode = response.StatusCode;
                return data;
            }
            string error;
            switch (response.StatusCode)
            {
                case HttpStatusCode.Unauthorized:
                    error = "Unauthorized Access";
                    break;
                case HttpStatusCode.BadRequest:
                    error = "Bad Request";
                    break;
                case HttpStatusCode.InternalServerError:
                    error = "Internal Server Error";
                    break;
                default:
                    error = "Undefined Error Occured";
                    break;
            }
            UserDataResponse failedResponse = new UserDataResponse(error, null, null, new DateTime());
            failedResponse.StatusCode = response.StatusCode;
            return failedResponse;
        }
    }
}
