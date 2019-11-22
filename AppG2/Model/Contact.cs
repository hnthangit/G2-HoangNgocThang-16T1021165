using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppG2.Model
{
    public class Contact
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string IdUser { get; set; }

        public string FirstCharacter
        {
            get
            {
                return Name.Substring(0, 1).ToUpper();
            }
        }

    }
}
