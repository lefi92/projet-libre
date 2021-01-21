using BlogApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Application_Web_MVC_NETCore.Models
{
    public class UserService : IUserService
    {
        private readonly HttpClient _httpClient;
        private readonly string _controllerUrl = "http://localhost:8090/api/Users";

        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public User Inscription(User user)
        {
            Console.WriteLine(user.nom);
            var data = JsonConvert.SerializeObject(user);
            HttpContent content = new StringContent(data, Encoding.UTF8, "application/json");
            var json = _httpClient.PostAsync(_controllerUrl, content).Result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<User>(json.ToString());
        }

        public User Connexion(User user)
        {
            throw new NotImplementedException();
        }

        public User GetUser(int id)
        {
            var json = _httpClient.GetStringAsync(_controllerUrl + "/" + id).Result;
            return JsonConvert.DeserializeObject<User>(json);
        }

        public User UpdateUser(int id, User user)
        {
            var data = JsonConvert.SerializeObject(user);
            HttpContent content = new StringContent(data, Encoding.UTF8, "application/json");
            var json = _httpClient.PutAsync(_controllerUrl + "/" + id, content).Result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<User>(json.ToString());
        }

        public User DeleteUser(int id)
        {
            var json = _httpClient.DeleteAsync(_controllerUrl + "/" + id).Result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<User>(json.ToString());
        }
    }
}
