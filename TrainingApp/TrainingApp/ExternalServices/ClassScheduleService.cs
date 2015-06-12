using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;
using System.Web;
using TrainingApp.Models;
using TrainingApp.ViewModels;

namespace TrainingApp.ExternalServices
{
    public class ClassScheduleService
    {
        public ClassScheduleService()
        {

        }
        public async Task<List<Presenter>> GetPresentersAsync()
        {
            HttpClient client = new HttpClient();
            var url = "http://csa-repo.app.lds.org/conference-scheduling/v1/participants";
            var response = await client.GetAsync(url);
            var presenters = await response.Content.ReadAsAsync<List<Presenter>>();
            return presenters.OrderBy(m => m.Name).ToList();
        }

        
        public List<TrainingViewModel> GetTrainings()
        {
            HttpClient client = new HttpClient();
            var url = "http://csa-repo.app.lds.org/conference-scheduling/v1/trainings";
            var response = client.GetAsync(url).Result;
            var trainings = response.Content.ReadAsAsync<List<TrainingViewModel>>().Result;
            return trainings.OrderBy(m => m.StartTime).ToList();
        }

        public List<Room> GetRooms()
        {
            HttpClient client = new HttpClient();
            var url = "http://csa-repo.app.lds.org/conference-scheduling/v1/rooms";
            var response = client.GetAsync(url).Result;
            var rooms = response.Content.ReadAsAsync<List<Room>>().Result;
            return rooms.OrderBy(m => m.Name).ToList();
        }
    }
}

