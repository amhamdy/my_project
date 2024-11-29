using cairo_library.data;
using cairo_library.Iinterface;
using cairo_library.Models;

namespace cairo_library.services
{
    public class memberservices:Imember
    {
        private readonly myappdpcontext _context;
        public memberservices(myappdpcontext context)
        {
            _context = context;
        }

        public void addmember(member member)
        {
            _context.members.Add(member);
            _context.SaveChanges();
        }

        public void deletemember(member member)
        {
            throw new NotImplementedException();
        }

        public List<member> getallmember()
        {
            var member= _context.members.ToList();
            return member;
        }

        public librarian getmemberbyfirstname(string firstname)
        {
            throw new NotImplementedException();
        }

        public librarian getmemberbyid(int id)
        {
            throw new NotImplementedException();
        }

        public librarian getmemberbylastname(string lastname)
        {
            throw new NotImplementedException();
        }
    }
}
