using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppG2.Model
{
    public class User
    {
        [Key]
        public string IdUser { get; set; }      
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
