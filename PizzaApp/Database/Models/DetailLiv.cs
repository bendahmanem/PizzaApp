using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaApp.Database.Models
{

    [Table("Detail_Liv")]
    public class DetailLiv
    {

        [Key]
        [Column("Num_Detail_Bon_Liv")]
        public int NumDetailBonLiv { get; set; }

        [ForeignKey("NumBonLiv")]
        public BonLiv BonLiv { get; set; }

        [Column("Num_Bon_Liv")]
        public int NumBonLiv { get; set; }

        [ForeignKey("NumLiv")]
        public Livraison Livraison { get; set; }

        [Column("Num_Liv")]
        public int NumLiv { get; set; }

        public Adresses Adresses { get; set; }

        [Column("Adresse_Liv")]
        [ForeignKey("Adresses")]
        public int AdresseLiv { get; set; }


    }
}
