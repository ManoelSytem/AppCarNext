using CarNext.Model;
using CarNext.Service.Interface;
using Microsoft.Maui.ApplicationModel.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace CarNext.Service
{
    public class LoginService : ILoginService
    {
        public async Task<User> Login(string email, string senha)
        {
            _ = new User();
            var client = new HttpClient();
            string url = "https://10.0.2.2:7173/api/User/" + email + "/" + senha;
            client.BaseAddress = new Uri(url);
            HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
            if (response.IsSuccessStatusCode)
            {
                User user = await response.Content.ReadFromJsonAsync<User>();
                return await Task.FromResult(user!);
            }
            return null!;
        }

        public async Task<User> Login(string numeroTelefone)
        {
            _ = new User();
            var client = new HttpClient();
            string url = "https://10.0.2.2:7173/api/User/" + numeroTelefone + "";
            client.BaseAddress = new Uri(url);
            HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
            if (response.IsSuccessStatusCode)
            {
                User user = await response.Content.ReadFromJsonAsync<User>();
                return await Task.FromResult(user!);
            }
            return null!;
        }

    }
}
