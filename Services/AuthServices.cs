using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WebClientCitas.Models;

namespace WebClientCitas.Services
{
    public interface IAuthServices
    {
        Users users { get; }
        Task<bool> Authentication(UsersRequest userRequest);
    }           

    public class AuthServices : IAuthServices
    {
        HttpClient client = new HttpClient();

        public Users users { get; private set; }

        public async Task<bool> Authentication(UsersRequest userRequest)
        {
            client = new HttpClient();

            client.BaseAddress = new Uri($"http://25.4.175.48:50000/api/auth/Users/Login");
            var postTask = await client.PostAsJsonAsync<UsersRequest>("Login", userRequest);

            if (postTask.IsSuccessStatusCode)
            {
                var result = postTask.Content.ReadFromJsonAsync<Users>();
                result.Wait();

                users = result.Result;
                return true;
            }
            else
                return false;
        }
    }
}
