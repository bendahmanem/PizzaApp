using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace PizzaApp.Database.Models
{
    [Table("Bon_Liv")]
    public class BonLiv
    {
        [Key]
        [Column("Num_Bon_Liv")]
        public int NumBonLiv { get; set; }

        public CdeCli CdeCli { get; set; }

        [Column("Num_Cde_Cli")]
        [ForeignKey("CdeCli")]
        public int NumCdeCli { get; set; }

        [Column("Date_Liv")]
        public DateTime DateLiv;

        public FactCliBonLiv FactCliBonLiv { get; set; }


        [Column("Num_Fact")]
        [ForeignKey("FactCliBonLiv")]
        public int? Num_Fact { get; set; }
    }
}
