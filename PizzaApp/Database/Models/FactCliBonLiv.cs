using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace PizzaApp.Database.Models
{

    [Table("Fact_Cli_Bon_Liv")]
    public class FactCliBonLiv
    {
        [Key]
        [Column("Num_Fact")]
        public int NumFAct { get; set; }

        [Column("Date_Fact_Cli")]
        public DateTime DateFactCli { get; set; }

        [Column("Montant_Total")]
        public int MontantTotal { get; set; }

        [ForeignKey("NumCli")]
        public Client Client { get; set; }

        [Column("Num_Cli")]
        public int NumCli { get; set; }
    }
}
