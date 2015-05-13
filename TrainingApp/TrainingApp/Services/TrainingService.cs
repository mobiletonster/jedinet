using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingApp.Models;

namespace TrainingApp.Services
{
    public class TrainingService
    {
        private TrainingContext _context;
        public TrainingService()
        {
            _context = new TrainingContext();
        }

        public List<Training> GetTrainings()
        {
            var trainings = _context.Trainings;
            return trainings.OrderBy(m=>m.StartTime).ThenBy(m=>m.RoomId).ToList();
        }

        public List<TrainingPresenter> GetTrainingPresenters()
        {
            var tp = _context.TrainingPresenters;
            return tp.ToList();
        }
    }
}
