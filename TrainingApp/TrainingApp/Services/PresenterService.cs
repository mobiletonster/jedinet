using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingApp.Models;

namespace TrainingApp.Services
{
    public class PresenterService
    {
        private TrainingContext _context;

        public PresenterService()
        {
            _context = new TrainingContext();
        }

        public List<Presenter> GetPresenters()
        {
            var presenters = _context.Presenters;
            return presenters.OrderBy(m=>m.Name).ToList();
        }
    }
}
