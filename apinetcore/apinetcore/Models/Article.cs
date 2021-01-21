using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace apinetcore.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string titre { get; set; }
        public string img { get; set; }
        public DateTime? date { get; set; }
        public string text { get; set; }

        [Required]
        public int UserId { get; set; }

        public UserModel user { get; set; }


    }
}