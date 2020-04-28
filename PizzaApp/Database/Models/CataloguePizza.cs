using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PizzaApp.Database.Models
{
    [Table("Catalogue_Pizza")]
    public class CataloguePizza
    {
        [Key]
        [Column("Num_Pizza")]
        public int NumPizza { get; set; }

        [Column("Nom_Pizza")]
        public string NomPizza { get; set; }

        [Column("Taille_Pizza")]
        public int TaillePizza { get; set; }

        [Column("Prix_Pizza")]
        public int PrixPizza { get; set; }
    }
}
