using System.ComponentModel.DataAnnotations;

namespace D_Einder_Dylaan_MVC.Models
{
    public class Menu
    {
        [Key]
        public int Id { get; set; }

        public string Naam { get; set; }

        public int Prijs { get; set; }

        public string MenuItems { get; set; }


    }
}
