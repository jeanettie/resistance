using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace resistance.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Body { get; set; }
        public string Meta { get; set; }
        public string UrlSeo { get; set; }
        public bool Published { get; set; }
        public DateTime PostedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }


    }
}