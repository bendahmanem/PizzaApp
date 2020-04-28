using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace PizzaApp.Database.Models
{
    [Table("Adresses")]
    public class Adresses
    {
        [Key]
        [Column("Num_Adresse")]
        public int NumAdresse { get; set; }

        [Column("Adresse")]
        public string Adresse { get; set; }

        public Quartier Quartier { get; set; }

        [Column("Num_Quartier")]
        [ForeignKey("Quartier")]
        public int NumQuartier { get; set; }
    }
}
