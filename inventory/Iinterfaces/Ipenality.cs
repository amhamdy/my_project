using cairo_library.Models;

namespace cairo_library.Iinterface
{
    public interface Ipenality
    {
        public List<penality> getpenality();
        public void addpenality (penality penality);
        public void deletepenality (penality penality);
        public penality getpenalitybyid(int id);


    }
}
