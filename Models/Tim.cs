using System.ComponentModel.DataAnnotations;

namespace Formula.Models

{
    public class Tim
    {
        [Key]
        public int timId {  get; set; }
        [Required]
        public required string nazivTima { get; set;}
        public ICollection<Vozac> vozaci { get; set; } = new List<Vozac>();
    }
}
