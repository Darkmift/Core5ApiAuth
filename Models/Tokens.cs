using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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
