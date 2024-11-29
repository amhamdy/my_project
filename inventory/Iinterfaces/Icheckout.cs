using cairo_library.Models;

namespace cairo_library.Iinterface
{
    public interface Icheckout
    {
        public List<checkout> Getallcheckoutbooks();
        public void addcheckout (checkout item);
        public void deletecheckout (checkout item);
        public  checkout getcheckoutbyid (int id);

    }
}
