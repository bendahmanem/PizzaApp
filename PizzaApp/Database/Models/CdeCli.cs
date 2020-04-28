using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PizzaApp.Database.Models
{
    [Table("Cde_Cli")]
    public class CdeCli
    {
        [Key]
        [Column("Num_Cde_Cli")]
        public int numCdeCli { get; set; }

      

        [ForeignKey("NumCli")]
        public Client Client { get; set; }

        [Column("Num_Cli")]
        public int NumCli { get; set; }


        [Column("Livre_Emporte")]
        public bool LivreEmporte { get; set; }

        [Column("Date_Cde")]
        public DateTime DateCde { get; set; }
    }
}
