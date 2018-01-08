using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdressBook.Models
{
    public class Person
    {
        public int PersonID { get; set; }
        [StringLength(5)]
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string Email { get; set; }
       
        public List<Adress> Adresses { get; set; }
    }
}
