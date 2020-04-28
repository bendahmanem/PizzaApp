using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PizzaApp.Database.Models
{
    [Table("Client")]
    public class Client
    {
        [Key]
        [Column("Num_Client")]
        public int NumCli { get; set; }

        [Column("Nom_Cli")]
        public string NomCli { get; set; }

        [Column("Adresse")]
        public string Adresse { get; set; }
    }
}
