using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Formula.Models
{
    public class Vozac
    {
        [Key]
        public int vozacId { get; set; }
        [Required]
        public string ime { get; set; }
        [Required]
        public string prezime { get; set; }
        [Required]
        [StringLength(3)]
        public string nacionalnost { get; set; }
        [Required]
        public int brojVozaca { get; set; }
        [Required]
        public DateOnly datumRodjenja { get; set; }
        [ForeignKey("Tim")]
        public int tim { get; set; }
        public required Tim Tim { get; set; }

        public ICollection<Rezultat>? rezultati { get; set; }
        public ICollection<Sponzori>? sponzori { get; set; }

    }
}
