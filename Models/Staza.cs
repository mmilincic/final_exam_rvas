using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Formula.Models
{
    public class Staza
    {
        [Key]
        public int stazaId { get; set; }
        [Required]
        public string? nazivStaze { get; set; }
        [Required]
        public float duzina { get; set; }
        //public ICollection<Trke>? Trke { get; set; }

    }
}
