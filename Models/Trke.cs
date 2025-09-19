using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Formula.Models
{
    public class Trke
    {
        [Key]
        public int trkaId { get; set; }

        [Required]
        public DateOnly datumTrke { get; set; }

        //public ICollection<Staza>? stazas{ get; set; }
        //[ForeignKey("Staza")]
        //public int staza { get; set; }

        //public Staza Staza { get; set; }

    }
}
