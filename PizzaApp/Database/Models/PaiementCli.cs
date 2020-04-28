using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace PizzaApp.Database.Models
{

    [Table("Paiement_Cli")]
    public class PaiementCli
    {

        [Key]
        [Column("Num_Piece_Compt")]
        public int NumPieceCompt { get; set; }

        [ForeignKey("NumFact")]
        public FactCliBonLiv FactCliBonLiv { get; set; }

        [Column("Num_Fact")]
        public int NumFact { get; set; }

        [Column("Date_Paiement")]
        public DateTime DatePaiement { get; set; }

        [Column("Montant_Paiement")]
        public int MontantPaiement { get; set; }

    }
}
