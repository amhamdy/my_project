using cairo_library.Models;

namespace cairo_library.Iinterfaces
{
    public interface Ibook
    {
    
        public List<books> Getallbooks();
        public void deletebook(int id);
        public void addbook(books book);
        public books getbookbyname(string name);
        public books getbookbyauthor(string author);
        public books getbookbyid(string id);
        public void editbook(books book);

    


}
}
