using System.ComponentModel.DataAnnotations.Schema;

namespace cairo_library.Models
{
    public class checkout
    {
        public int Id { get; set; }
        [ForeignKey(nameof(member))]
        public int Member_id { get; set; }
        public  member member { get; set; }



        [ForeignKey(nameof(librarian))]
        public int Librarian_id { get; set; }
        public librarian librarians { get; set; }

        
        public string Checkout_date { get; set; }
        public string  Due_date { get; set; }
        public string Penality_amount { get; set; }
        public string Return_date { get; set; }
        public ICollection<books> books { get; set; }=new HashSet<books>();
      
    }
}
