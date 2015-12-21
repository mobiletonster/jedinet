using App.Core;
using App.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Services
{
    public class PeopleService
    {
        Repository _repository;

        public PeopleService()
        {
            _repository = new Repository();
        }
        public PersonVM GetCompletePersonById(int id)
        {
            var person = _repository.GetPersonById(id);
            var addresses = _repository.GetAddressesByPersonId(id).ToList();
            PersonVM cp = new PersonVM(person, addresses);
            return cp;
        }

        public Dictionary<int,string> GetAddressTypes()
        {
            // sorry for the strange syntx...but enums are weird animals. To use an extension method [ToDictionary], you must apply it to a member of the enum.
            return AddressType.Home.ToDictionary();
        }

        public PersonVM SaveCompletePerson(PersonVM person)
        {
            // we would pull the PersonVM apart and get individual Person and List<Address> objects to save to their appropriate
            // tables, etc.
            var p = Factory.PersonFactory(person);
            var a = Factory.AddressesFactory(person);


            return person;
        }
    }
}
