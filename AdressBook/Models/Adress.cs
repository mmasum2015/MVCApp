using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdressBook.Models
{
    public class Adress
    {
        public int AdressID { get; set; }
        public string Description { get; set; }
        public string Adresstype { get; set; }
        public int PersonID { get; set; }
        public Person Person { get; set; }
    }
}
