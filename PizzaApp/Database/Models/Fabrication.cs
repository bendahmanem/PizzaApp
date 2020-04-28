using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PizzaApp.Database.Models
{
    [Table("Fabrication")]
    public class Fabrication
    {
        [Key]
        [Column("Num_Fab")]
        public int NumFab { get; set; }

        [ForeignKey("NumPizza")]
        public CataloguePizza  CataloguePizza { get; set; }

        [Column("Num_Pizza")]
        public int NumPizza { get; set; }


        [Column("Quant_Fab")]
        public int QuantFab { get; set; }

        [Column("Date_Fab")]
        public DateTime DateFab {get; set;}
    }
}
