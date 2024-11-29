using cairo_library.Models;

namespace cairo_library.Iinterface
{
    public interface Imember
    {
        public List<member> getallmember();
        public void addmember (member member);
        public void deletemember (member member);

        public librarian getmemberbyfirstname (string firstname);
        public librarian getmemberbylastname (string lastname);
        public librarian getmemberbyid (int id);

    }
}
