using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace apinetcore.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public DateTime? datedenaissance { get; set; }
        public string pays { get; set; }
        public string ville { get; set; }

        [Required]
        public string login { get; set; }

        [Required]
        [JsonIgnore]
        public string password { get; set; }
        public string Token { get; set; }
        public DateTime? dateInscription { get; set; }

    }
}