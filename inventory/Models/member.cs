using System.ComponentModel.DataAnnotations;

namespace cairo_library.Models
{
    public class member
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Phonenumber { get; set; }
        [ EmailAddress]
        public string Email { get; set; }

        public string Membershipdate { get; set; }
        public ICollection<checkout> Checkouts { get; set; } = new HashSet<checkout>();
        public ICollection<penality> penalities { get; set; }= new HashSet<penality>();

    }
}
