using System;
using System.Collections.Generic;
using System.IO;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Shop.App.Data;
using Shop.App.DTO;
using Shop.App.Models;

namespace Shop.App.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepo _repo;
        private readonly IMapper _mapper;
        public BookController(IBookRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        public ActionResult<IEnumerable<BookRead>> Index(int page = 1)
        {
            var pageSize = 6;
            var data = _repo.GetPage(page,pageSize);
            return View(_mapper.Map<IEnumerable<BookRead>>(data));
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult<BookRead> Add(BookCreating create)
        {
            var book = _mapper.Map<Book>(create);
            var ok = _repo.Add(book);
            _repo.SaveChages();
            return Ok(_mapper.Map<BookRead>(_repo.First(book.Id)));
        }
        public ActionResult Seed()
        {
            List<BookCreating> list = SeedBook.GetData3();
            foreach(var b in list)
            {
                _repo.Add(_mapper.Map<Book>(b));
            }
            _repo.SaveChages();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            _repo.Delete(id);
            _repo.SaveChages();
            return RedirectToAction("Index");
        }
    }
}