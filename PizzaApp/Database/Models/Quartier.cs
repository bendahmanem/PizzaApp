using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace PizzaApp.Database.Models
{

    [Table("Quartier")]
    public class Quartier
    {
        [Key]
        [Column("Num_Quartier")]
        public int NumQuartier { get; set; }

        [Column("Nom_Quartier")]
        public string Nom_Quartier { get; set; }

    }
}
