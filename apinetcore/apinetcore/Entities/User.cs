using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace apinetcore.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public DateTime? datedenaissance { get; set; }
        public string pays { get; set; }
        public string ville { get; set; }

        public string login { get; set; }

        [JsonIgnore]
        public string password { get; set; }
        public string Token { get; set; }
        public DateTime? dateInscription { get; set; }
    }
}
