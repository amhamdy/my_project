using cairo_library.data;
using cairo_library.Iinterfaces;
using cairo_library.Models;

namespace cairo_library.services
{
    public class bookservices : Ibook
    {
        private readonly myappdpcontext _context;
        public bookservices(myappdpcontext context)

        {
            _context = context;
        }

        public void editbook(books book)
        {
            _context.Update(book);
            _context.SaveChanges();
        }

        void Ibook.addbook(books book)
        {
            _context.books.Add(book);

            _context.SaveChanges();


        }

        void Ibook.deletebook(int id)
        {
            throw new NotImplementedException();
        }

        List<books> Ibook.Getallbooks()
        {
            var books = _context.books.ToList();
            return books;

        }

        books Ibook.getbookbyauthor(string author)
        {
            var books = _context.books.Find(author);
            return (books);
        }

        books Ibook.getbookbyid(string id)
        {
            throw new NotImplementedException();
        }

        books Ibook.getbookbyname(string name)
        {
            throw new NotImplementedException();
        }
    }
}
