using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PizzaApp.Database.Models
{

    [Table("Ligne_Cde_Cli")]
    public class LigneCdeCli
    {
        [Key]
        [Column("Num_Ligne_Cde")]
        public int NumLigneCde { get; set; }

        [ForeignKey("NumCdeCli")]
        public CdeCli CdeCli { get; set; }

        [Column("Num_Cde_Cli")]
        public int NumCdeCli { get; set; }

        public CataloguePizza CataloguePizza { get; set; }

        [Column("Num_Pizza")]
        [ForeignKey("CataloguePizza")]
        public int NumPizza { get; set; }

        [Column("Quantite")]
        public int Quantite { get; set; }
    }
}
