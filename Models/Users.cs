using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core5ApiAuth.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }  // must be public!
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
