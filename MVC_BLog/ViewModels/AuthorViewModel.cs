using MVC_BLog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_BLog.ViewModels
{
    public class AuthorViewModel
    {
        public User Author { get; set; }
        public string Name { get; set; }
        public City City { get; set; }
        public string AddressDetails { get; set; }
        public List<Post> PostsList { get; set; }

        public int TotalPosts { get; set; }

        public int PageNo { get; set; }
        public int Posts { get; set; }

        public bool DisplayNext { get; set; }
        public bool DisplayPrevious { get; set; }
    }
}