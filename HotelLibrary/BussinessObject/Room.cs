using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelLibrary.BussinessObject
{
    public class Room
    {
        public int RoomID { get; set; }
        public int? AccID { get; set; }
        public string AccName { get; set; }
        public TypeRoom TypeRoom { get; set; }
        public int Status { get; set; }
        public int Price { get; set; }
        public TypeBed TypeBed { get; set; }

    }
}
