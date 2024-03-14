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
        public Role Role { get; set; }
        public string CitizenID { get; set; }
        public string Phone {  get; set; }
        public string Address {  get; set; }
        public Gender Gender{ get; set; }
        public DateTime DOB {  get; set; }

        // Property giả mạo để chuyển đổi Gender sang kiểu bool
        public bool IsMale => Gender?.GenderName == "Male";

        // Property giả mạo để chuyển đổi Role sang kiểu bool
        public bool IsEmployee => Role?.RoleName == "Employee";

        //public override string? Tostring => $"{AccID};{Username};{Password};{Role.RoleName};{CitizenID};{Phone};{Address};{Gender.GenderName};{DOB}";

    }
}
