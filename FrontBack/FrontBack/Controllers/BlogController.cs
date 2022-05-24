using FrontBack.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FrontBack.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            List<Blog> blogs = new List<Blog>();

            Blog blog_1 = new Blog()
            {
                Id = 1,
                Name = "Marketing",
                SubName = "Sweet Go Agency",
                ImgSrc = "images/project/project-image01.jpg"
            };
            Blog blog_2 = new Blog()
            {
                Id = 2,
                Name = "Website",
                SubName = "Smart Ladies",
                ImgSrc = "images/project/project-image02.jpg"
            };
            Blog blog_3 = new Blog()
            {
                Id = 3,
                Name = "Branding",
                SubName = "Shoes factory",
                ImgSrc = "images/project/project-image03.jpg"
            };
            Blog blog_4 = new Blog()
            {
                Id = 4,
                Name = "Social Media",
                SubName = "Race Bicycle",
                ImgSrc = "images/project/project-image04.jpg"
            };
            Blog blog_5 = new Blog()
            {
                Id = 5,
                Name = "Video",
                SubName = "Ultimate HealthCare",
                ImgSrc = "images/project/project-image05.jpg"
            };
            blogs.Add(blog_1);
            blogs.Add(blog_2);
            blogs.Add(blog_3);
            blogs.Add(blog_4);
            blogs.Add(blog_5);
            return View(blogs);
        }
    }
}
