using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelLibrary.BussinessObject
{
    public class Account
    {
        public int AccID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string CitizenID { get; set; }
        public string Phone {  get; set; }
        public string Address {  get; set; }
        public string Gender{ get; set; }
        public DateTime DOB {  get; set; }
    }
}
