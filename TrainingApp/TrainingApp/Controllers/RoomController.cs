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
    public class RoomController : ApiController
    {
        private RoomService _roomService;

        public RoomController()
        {
            _roomService = new RoomService();
        }

        [HttpGet]
        [Route("api/v2/rooms")]
        public List<Room> GetRooms()
        {
            var rooms = _roomService.GetRooms();
            return rooms.OrderBy(m => m.Name).ToList();
        }

    }
}
