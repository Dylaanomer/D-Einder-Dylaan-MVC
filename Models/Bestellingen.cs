using System.ComponentModel.DataAnnotations;

namespace D_Einder_Dylaan_MVC.Models
{
    public class Bestellingen
    {
        [Key]
        public int Id { get; set; }

        public string Bestelling { get; set; }

        public int Tijd { get; set; }

        public string Tafel { get; set; }

    }
}
