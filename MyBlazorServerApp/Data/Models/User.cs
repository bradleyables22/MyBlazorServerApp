using System.ComponentModel.DataAnnotations;

namespace MyBlazorServerApp.Data.Models
{
    public class UserInfo
    {
            [Key]
            public int UserID { get; set; }

            [Required]
            [MaxLength(128)]
            public string UserName { get; set; }

            [Required]
            [MaxLength(128)]
            public string UserPassword { get; set; }

            [Required]
            [MaxLength(80)]
            public string Role { get; set; }
    }
}
