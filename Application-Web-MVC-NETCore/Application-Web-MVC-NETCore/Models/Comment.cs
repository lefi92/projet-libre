using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BlogApi.Models
{
    public class Comment
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime? date { get; set; }

        public int ArticleId { get; set; }
        public Article article { get; set; }



    }
}