using System;
using System.Collections.Generic;
using System.Linq;
using Shop.App.Models;

namespace Shop.App.Data
{
    public class SqlBookRepo : IBookRepo
    {
        public readonly ShopContext _context;
        public SqlBookRepo(ShopContext context)
        {
            _context = context;
        }
        public bool Add(Book book)
        {
            _context.Books.Add(book);
            return true;
        }

        public bool Delete(int id)
        {
            _context.Books.Remove(this.First(id));
            return true;
        }

        public Book First(int id)
        {
            return _context.Books.First(x => x.Id == id);
        }
        public IEnumerable<Book> GetPage(int page, int pageSize)
        {
            return _context.Books.ToList().OrderBy(x => x.Id)
                                          .Skip((page - 1) * pageSize)
                                          .Take(pageSize);
            // return new List<Book>() { new Book { Id = 0 }};
        }
        public bool SaveChages()
        {
            return _context.SaveChanges() > 0;
        }
    }
}