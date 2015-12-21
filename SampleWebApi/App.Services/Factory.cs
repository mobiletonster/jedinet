using App.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Services
{
    public static class Factory
    {

        public static Person PersonFactory(PersonVM p)
        {
            var person = new Person() {
                BirthDate = p.BirthDate,
                FirstName = p.FirstName,
                LastName = p.LastName,
                Id = p.Id,
                Username = p.Username }
            ;
            return person;
        }

        public static List<Address> AddressesFactory(PersonVM p)
        {
            return p.Addresses;
        }
    }
}
