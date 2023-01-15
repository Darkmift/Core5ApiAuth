using System.ComponentModel.DataAnnotations;

namespace Core5ApiAuth.Models
{
    public class Users
    {
        [Key]
        public int? Id { get; set; }  // must be public!
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
