using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace TrendingNews.Models
{
    public class User
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public byte[] PasswordSalt { get; set; }
        [Required]
        public byte[] PasswordHash { get; set; }
    }
}
