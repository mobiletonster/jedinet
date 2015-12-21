using App.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data
{
    public class Repository
    {
        public List<Address> GetAddresses()
        {
            var a1 = new Address() { PersonId = 1, Address1 = "street 1", City = "riverton", State = "UT", Zip = "84067", Type = AddressType.Home };
            var a2 = new Address() { PersonId = 1, Address1 = "street 2", City = "riverton", State = "UT", Zip = "84067", Type = AddressType.Work };
            var a3 = new Address() { PersonId = 2, Address1 = "street 3", City = "riverton", State = "UT", Zip = "84067", Type = AddressType.Home };
            var a4 = new Address() { PersonId = 2, Address1 = "street 4", City = "riverton", State = "UT", Zip = "84067", Type = AddressType.Work };

            var adds = new List<Address>();
            adds.Add(a1);
            adds.Add(a2);
            adds.Add(a3);
            adds.Add(a4);
            return adds;
        }
        public List<Person> GetPersons()
        {
            var p1 = new Person() { Id = 1, FirstName = "Jef", LastName = "Jones", Password = "mysecert", SSN = "551113123", Username = "jjones" };
            var p2 = new Person() { Id = 2, FirstName = "Tony", LastName = "Spencer", Password = "supersecret", SSN = "443568308", Username = "spencerto" };
            var p3 = new Person() { Id = 3, FirstName = "Jim", LastName = "Byer", Password = "easy", SSN = "111234444", Username = "byerje" };
            var p4 = new Person() { Id = 4, FirstName = "Blaine", LastName = "Maxfield", Password = "standford", SSN = "111223333", Username = "maxballer" };
            var pers = new List<Person>() { p1, p2, p3, p4 };
            return pers;
        }
        public List<Address> GetAddressesByPersonId(int id)
        {
            return GetAddresses().Where(m => m.PersonId == id).ToList();
        }
        public Person GetPersonById(int id)
        {
            var persons = GetPersons();
            return persons.FirstOrDefault(m => m.Id == id);
        }
    }
}
