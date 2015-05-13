using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingApp.Models;

namespace TrainingApp.Services
{
    public class RoomService
    {
        private TrainingContext _context;
        public RoomService()
        {
            _context = new TrainingContext();
        }

        public List<Room> GetRooms()
        {
            var rooms = _context.Rooms;
            return rooms.OrderBy(m => m.Name).ToList();
        }
    }
}
