// Services/UserService.cs
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Bitrix24.Models;
using static Bitrix24.Service.UserService;

namespace Bitrix24.Service
{
    public class UserService : IUserService
    {
        private readonly HttpClient _httpClient;

        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public interface IUserService
        {
            Task<List<User>> GetUsersAsync();
        }
        public async Task<List<User>> GetUsersAsync()
        {
            var response = await _httpClient.GetAsync("https://b24-3vc0pj.bitrix24.vn/rest/1/jmqm9giktcbhmg82/user.get");
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var apiResponse = JsonSerializer.Deserialize<ApiResponse>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return apiResponse.Result;
        }
    }
}

