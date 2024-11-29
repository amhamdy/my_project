using cairo_library.data;
using cairo_library.Iinterface;
using cairo_library.Models;

namespace cairo_library.services
{
    public class checkout : Icheckout

    {



        private readonly myappdpcontext _context;

        public checkout(myappdpcontext context)
        {
            _context = context;
        }



        public void addcheckout(Models.checkout item)
        {
            throw new NotImplementedException();
        }

        public void deletecheckout(Models.checkout item)
        {
            throw new NotImplementedException();
        }

        public List<Models.checkout> Getallcheckoutbooks()
        {
            var checkoutbook = _context.checkouts.ToList();
            return checkoutbook ;

        }

        public Models.checkout getcheckoutbyid(int id)
        {
            throw new NotImplementedException();
        }
    }
}
