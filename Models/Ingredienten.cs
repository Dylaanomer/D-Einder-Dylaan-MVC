using System.ComponentModel.DataAnnotations;

namespace D_Einder_Dylaan_MVC.Models
{
    public class Ingredienten
    {
        [Key]
        public int Id { get; set; }

        public string Naam { get; set; }

        public int Hoeveelheid { get; set; }
    }
}
