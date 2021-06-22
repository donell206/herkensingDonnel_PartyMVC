using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace herkensingDonnel_PartyMVC.PartyMVCLibrary.Models
{
    public class Visitor
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string SecondName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Tel { get; set; }
        [Required]
        [Range(18, 60)]
        public int Age { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        [Range(1000, 1500)]
        public int PostalCode { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public bool IsFamily { get; set; }
    }
}
