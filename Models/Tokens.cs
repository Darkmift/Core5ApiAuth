using System.ComponentModel.DataAnnotations;

namespace Core5ApiAuth.Models
{
    public class Tokens
    {
        [Key]
        public int Id { get; set; }  // must be public!
        public string Token { get; set; }
        public string RefreshToken { get; set; }
    }
}
