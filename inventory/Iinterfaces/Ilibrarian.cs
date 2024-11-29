using cairo_library.Models;

namespace cairo_library.Iinterface
{
    public interface Ilibrarian
    {
        public List<librarian> getlibrarians ();
        public void addlibrarian(librarian librarian);
        public void deletibrarian (librarian librarian);

        public librarian getlibrarianbyfirstname (string firstname);
        public librarian getlibrarianbylastnme (string lastname );
        void addlibrarian(Controllers.librariancontroller librarian);
    }
}
