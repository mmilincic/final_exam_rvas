using Formula.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Sponzori
{
    [Key]
    public int sponzorId { get; set; }

    [Required]
    public string naziv { get; set; }

    public ICollection<Vozac> vozaci { get; set; }
}
