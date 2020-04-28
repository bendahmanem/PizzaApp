using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace PizzaApp.Database.Models
{
    [Table("Livreur")]
    public class Livreur
    {
        [Key]
        [Column("Num_Liv")]
        public int NumLiv { get; set; }

        [Column("Nom_Livreur")]
        public string NomLivreur {get; set;}

        [ForeignKey("NumQuartier")]
        public Quartier Quartier { get; set; }

        [Column("Num_Quartier")]
        public int NumQuartier { get; set; }

    }
}
