using HomeWork2019._12._14_1_.AbstractModels;
using HomeWork2019._12._14_1_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeWork2019._12._14_1_.Web.Controllers
{
    public class PostController : Controller
    {
        private readonly IRepository<Post> _repository;
        public PostController(IRepository<Post> repository)
        {
            _repository = repository;
        }

        public ActionResult Index()
        {
            var posts = _repository.GetAll().ToList();
            return View(posts);
        }
        [HttpPost]
        public void Index(int postId, int likeCount)
        {
            var item = _repository.GetAll().Where(i => i.Id == postId).FirstOrDefault();
            item.LikeCoutnt = likeCount;
            _repository.Update(item);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Post post)
        {
            _repository.Add(post);

            return RedirectToAction("Index");
        }
    }
}