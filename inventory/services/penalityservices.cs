using cairo_library.data;
using cairo_library.Iinterface;
using cairo_library.Models;

namespace cairo_library.services
{
    public class penalityservices : Ipenality
    {
        private readonly myappdpcontext _context;
        public penalityservices(myappdpcontext context)
        {
            _context = context;
        }
        public void addpenality(penality penality)

        {
            throw new NotImplementedException();
        }

        public void deletepenality(penality penality)
        {
            throw new NotImplementedException();
        }

        public List<penality> getpenality()
        {
            var penality = _context .penalities.ToList();
            return penality;
        }

        public penality getpenalitybyid(int id)
        {
            throw new NotImplementedException();
        }
    }
}
