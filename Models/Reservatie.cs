using System.ComponentModel.DataAnnotations;

namespace D_Einder_Dylaan_MVC.Models
{
    public class Reservatie
    {
        [Key]
        public int Id { get; set; }

        public string User { get; set; }

        public int Tijd { get; set; }

        public string Tafel { get; set; }

        public string MenuKeuzes { get; set; }
    }
}
