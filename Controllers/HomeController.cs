using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ScaffoldDbContextSample.Data;
using ScaffoldDbContextSample.Models;

namespace ScaffoldDbContextSample.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly BlogDB2Context _blogDB2Context;
        public HomeController(BlogDB2Context blogDB2Context)
        {
            _blogDB2Context = blogDB2Context;
        }

        [HttpGet]
        public  IEnumerable< Posts> Get()
        {
            _blogDB2Context.Posts.Add(new Posts() { Title = "C#", Content = "这是最好的C#教程" });
            _blogDB2Context.SaveChanges();

            var posts = _blogDB2Context.Posts.ToList();
            return posts;
        }

        [HttpPost]
        public string Post()
        {
            _blogDB2Context.Posts.Add(new Posts() {  Title="C#",Content="这是最好的C#教程"});
            _blogDB2Context.SaveChanges();
            return "OK";
        }
    }
}