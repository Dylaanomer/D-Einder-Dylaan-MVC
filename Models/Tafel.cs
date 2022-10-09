using System.ComponentModel.DataAnnotations;

namespace D_Einder_Dylaan_MVC.Models
{
    public class Tafel
    {
        [Key]
        public int Id { get; set; }

        public string User { get; set; }

        public string Menu { get; set; }

        public string Rekening { get; set; }
        
    }
}
