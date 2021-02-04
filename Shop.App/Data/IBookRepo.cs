using System;
using System.Collections.Generic;
using Shop.App.Models;

namespace Shop.App.Data
{
    public interface IBookRepo
    {
        public bool Add(Book book);
        public IEnumerable<Book> GetPage(int page, int pageSize);
        public bool SaveChages();
        public Book First(int id);
        public bool Delete(int id);
    }
}