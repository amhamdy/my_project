using System.ComponentModel.DataAnnotations.Schema;

namespace cairo_library.Models
{
    public class penality
    {
        public int Id { get; set; }
        [ForeignKey(nameof(member))]
        public int Member_id { get; set; }
        public member members { get; set; }
      
        public string Penality_amount { get; set; }
        public string Payment_status { get; set; }


    }
}
