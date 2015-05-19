using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TrainingApp.Models;
using TrainingApp.Services;

namespace TrainingApp.Controllers
{
    public class PresenterController : ApiController
    {
        private PresenterService _presenterService;
        public PresenterController()
        {
            _presenterService = new PresenterService();
        }

        [HttpGet]
        [Route("api/v2/participants")]
        public List<Presenter> GetPresenters()
        {
            var presenters = _presenterService.GetPresenters();
            return presenters.OrderBy(m => m.Name).ToList();
        }
    }
}
