using System.ComponentModel.DataAnnotations;

namespace MyBlazorServerApp.Data.Models
{
    public class StarWarsAffiliation
    {
        [Key]
        public int AffilID { get; set; }

        [Required]
        [MaxLength(1)]
        public string Affiliation { get; set; }
        
        [Required]
        public DateTime EDT { get; set; }
    }
}
