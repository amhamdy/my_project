using cairo_library.data;
using cairo_library.Iinterface;
using cairo_library.Models;

namespace cairo_library.services
{
    public class librarianservices : Ilibrarian
    {
        private readonly myappdpcontext _context;

        public librarianservices(myappdpcontext context )
        {
            _context = context;
        }


        public void addlibrarian(librarian librarian)
        {
            _context.librarians.Add( librarian );
            _context.SaveChanges();

            
        }

        public void addlibrarian(Controllers.librariancontroller librarian)
        {
            throw new NotImplementedException();
        }

        public void deletibrarian(librarian librarian)
        {
            throw new NotImplementedException();
        }

        public librarian getlibrarianbyfirstname(string firstname)
        {
            throw new NotImplementedException();
        }

        public librarian getlibrarianbylastnme(string lastname)
        {
            throw new NotImplementedException();
        }

        public List<librarian> getlibrarians ()
        {
            var librarian = _context.librarians .ToList();
            return librarian;
        }
    }
}
