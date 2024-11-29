using System.ComponentModel.DataAnnotations.Schema;

namespace cairo_library.Models
{
    public class books
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Isbn { get; set; }
        public string? Genre { get; set; }
        public string Bublishdate {  get; set; }

        [ForeignKey(nameof(checkout))]
      public int? checkoutsid { get; set; }
        public checkout? checkouts { get; set; }
        public string Status { get; set; }

    }
}
