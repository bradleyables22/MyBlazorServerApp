using System.ComponentModel.DataAnnotations;

namespace MyBlazorServerApp.Data.Models
{
    public class GuestEntry
    {
        [Key]
        public int GuestEntryID { get; set; }

        [Required]
        [MaxLength(128)]
        public string GuestName { get; set; }

        [Required]
        public DateTime EntryTimeDate { get; set; }
        
        [Required]
        [MaxLength(1024)]
        public string GuestInput { get; set; }
    }
}
