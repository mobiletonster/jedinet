using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TrainingApp.ExternalServices;
using TrainingApp.Models;
using TrainingApp.ViewModels;

namespace TrainingApp.Controllers
{
    public class ClassScheduleController : ApiController
    {
        private ClassScheduleService _classScheduleService;

        public ClassScheduleController()
        {
            _classScheduleService = new ClassScheduleService();
        }

        [HttpGet]
        [Route("api/rooms")]
        public List<Room> GetRooms()
        {
            var rooms = _classScheduleService.GetRooms();
            return rooms.OrderBy(m => m.Name).ToList();
        }

        [HttpGet]
        [Route("api/participants")]
        public List<Presenter> GetPresenters()
        {
            var presenters = _classScheduleService.GetPresenters();
            return presenters.OrderBy(m => m.Name).ToList();
        }

        [HttpGet]
        [Route("api/trainings")]
        public List<TrainingViewModel> GetTrainingsViewModel()
        {
            var trainings = _classScheduleService.GetTrainings();
            return trainings;
        }
    }
}
