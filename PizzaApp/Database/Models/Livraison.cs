using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace PizzaApp.Database.Models
{
    [Table("Livraison")]
    public class Livraison
    {
        [Key]
        [Column("Num_Liv")]
        public int NumLiv { get; set; }

        [Column("Date_Depart")]
        public DateTime DateDepart { get; set; }

        [Column("Date_Arrive")]
        public DateTime DateArrive { get; set; }

/*        [ForeignKey("NumQuartier")]
        public Quartier Quartier { get; set; }

        [Column("Num_Quartier")]
        public int NumQuartier { get; set; }*/
    }
}
