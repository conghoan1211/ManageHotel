using HotelLibrary.BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelLibrary.Respository
{
    public interface IRespository 
    {
        IEnumerable<Account> GetAccounts(int roleID, int type_sort);
        Account GetAccountByID(int accId);
        Account GetAccountByName(string username);
        void InsertAccount(string username, string password, string phone, string citizen, string address, int gender, DateTime dob, int role_id);
        void UpdateAccount(int accid, string username, string password, string phone, string citizen, string address, int gender, DateTime dob, int role_id);
        void DeleteAccount(int accId);
        Account Login(string username, string password);
        bool IsUsernameExist (string username, int accid);
        IEnumerable<Account> GetAccountsNoRoom();


        IEnumerable<Room> GetRooms();
        IEnumerable<Room> GetRoomByStatus(int status);

        IEnumerable<Room> GetRoomByType(int typebed, int typeroom);
        void InsertRoom(int type_id, int price, int type_bed, int acc_id, int room_id);

        void Inactive(int roomid);
        Room GetRoomByID(int roomid);

        void Update(int acc_id, int type_id, int price, int type_bed, int room_id);
    }
}
