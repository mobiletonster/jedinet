using App.Core;
using App.Data;
using App.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SampleWebApi.Controllers
{
    public class PersonController : ApiController
    {
        PeopleService peopleService;

        public PersonController()
        {
            peopleService = new PeopleService();
        }

        [Route("api/persons/{id:int}")]
        [HttpGet]
        public PersonVM GetCompletePerson(int id)
        {
            var cp = peopleService.GetCompletePersonById(id);
            return cp;
        }

        [Route("api/persons")]
        [HttpPost]
        public PersonVM SaveCompletePerson(PersonVM person)
        {
            var cp = peopleService.SaveCompletePerson(person);
            return cp;
        }

        [Route("api/enums/addresstypes")]
        [HttpGet]
        public Dictionary<int,string> GetAddressTypes()
        {
            return peopleService.GetAddressTypes();
        }
    }
}
