using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TrainingApp.ExternalServices;
using TrainingApp.Security;
using TrainingApp.Services;
using TrainingApp.ViewModels;

namespace TrainingApp.Controllers
{
    //[AuthorizeClientApp]
    public class TrainingController : ApiController
    {
        private TrainingService _trainingService;
        private RoomService _roomService;
        private PresenterService _presenterService;

        public TrainingController()
        {
            _trainingService = new TrainingService();
            _roomService = new RoomService();
            _presenterService = new PresenterService();
        }

        [HttpGet]
        [Route("api/v2/trainings")]
        public List<TrainingViewModel> GetTrainingsViewModel()
        {
            var trainings = _trainingService.GetTrainings();
            var rooms = _roomService.GetRooms();
            var presenters = _presenterService.GetPresenters();
            var trainingPresenters = _trainingService.GetTrainingPresenters();

            List<TrainingViewModel> tvm = new List<TrainingViewModel>();
            foreach (var t in trainings)
            {
                var trainPres = trainingPresenters.Where(m => m.TrainingId == t.Id);
                var p = (from pres in presenters join tp in trainPres on pres.Id equals tp.PresenterId select pres).ToList();
                var r = rooms.Where(m => m.Id == t.RoomId).FirstOrDefault();
                var trainingViewModel = new TrainingViewModel(t, p, r);
                tvm.Add(trainingViewModel);
            }

            return tvm;
        }
    }
}
