using Formula.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Rezultat
{
    [Key]
    public int rezultatId { get; set; }

    
    [ForeignKey("Vozac")]
    public int vozacId { get; set; }
    public Vozac vozac { get; set; }

    
    [ForeignKey("Trka")]
    public int trkaId { get; set; }
    public Trke trke { get; set; }

    [Required]
    public int poeni { get; set; }
    public DateTime datum { get; set; }
}
