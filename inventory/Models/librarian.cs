namespace cairo_library.Models
{
    public class librarian
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public  string Phonenumber {  get; set; }
        public string Email { get; set; }
        public string Hiredate {  get; set; }
        public ICollection<checkout> Checkouts { get; set; }= new HashSet<checkout>();
    }
}
