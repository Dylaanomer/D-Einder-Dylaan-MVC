using System.ComponentModel.DataAnnotations;

namespace D_Einder_Dylaan_MVC.Models
{
    public class MenuItems
    {
        [Key]
        public int Id { get; set; }

        public string Naam { get; set;}

        public string Ingredienten { get; set; }

        public string Categorien { get; set; }

    }
}
