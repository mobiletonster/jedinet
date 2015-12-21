﻿using App.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Services
{
    public class PersonVM
    {
        public PersonVM()
        {

        }
        public PersonVM(Person p, List<Address> a)
        {
            Id = p.Id;
            FirstName = p.FirstName;
            LastName = p.LastName;
            BirthDate = p.BirthDate;
            Username = p.Username;
            Addresses = a;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Username { get; set; }
        public List<Address> Addresses { get; set; }
    }
}
