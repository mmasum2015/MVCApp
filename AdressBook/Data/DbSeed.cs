using AdressBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdressBook.Data
{
    public class DbSeed
    {
        public static void Seed(ApplicationDbContext context)
        {
            var aMan = new Person() {FirstName="Raham", LastName="Masum", Email="raham@gmail.com"};
            var bMan = new Person() { FirstName = "Rahen", LastName = "Ismail", Email = "rehan@gmail.com"};

            var aAdress = new Adress() { Description = "He love to live that place", Adresstype = "Appartment",Person=aMan };

            var bAdress = new Adress() { Description = "He live that place for job purpases", Adresstype = "Villa" ,Person=bMan};
            context.Add(aAdress);
            context.Add(bAdress);

            context.SaveChanges();
        }
    }
}
