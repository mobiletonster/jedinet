using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingApp.Models;

namespace TrainingApp.ViewModels
{
    public class TrainingViewModel
    {
        public TrainingViewModel()
        {

        }

        public TrainingViewModel(Training t, List<Presenter> p, Room r)
        {
            Id = t.Id;
            Name = t.Name;
            Description = t.Description;
            StartTime = t.StartTime;
            EndTime = t.EndTime;
            AttendeeCount = t.AttendeeCount;

            Room = r;
            Presenters = p;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Room Room { get; set; }
        public List<Presenter> Presenters { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? AttendeeCount { get; set; }
    }
}
