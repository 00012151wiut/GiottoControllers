using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GiottoControllers.Models
{
    public class Account
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }
        public int Number { get; set; }
        public int Address { get; set; }

        [Required]
        public string Allergy { get; set; }
    }
}
