using HotelLibrary.BussinessObject;
using HotelLibrary.DataAccess;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HotelLibrary.Respository
{
    public class Repository : IRespository
    {
        public void DeleteAccount(int accId) => AccountDBContext.Instance.Remove(accId);
        public Account GetAccountByID(int accId) => AccountDBContext.Instance.GetByID(accId);
        public Account GetAccountByName(string name) => AccountDBContext.Instance.GetByName(name);
        public IEnumerable<Account> GetAccounts(int roleID, int type_sort) => AccountDBContext.Instance.GetList(roleID, type_sort);
        public Account Login(string username, string password) => AccountDBContext.Instance.Login(username, password);
        public void InsertAccount(string username, string password, string phone, string citizen, string address, int gender, DateTime dob, int role_id)
            => AccountDBContext.Instance.CreateNew(username, password, phone, citizen, address, gender, dob, role_id);
        public void UpdateAccount(int accid, string username, string password, string phone, string citizen, string address, int gender, DateTime dob, int role_id)
        => AccountDBContext.Instance.Update(accid, username, password, phone, citizen, address, gender, dob, role_id);
        public bool IsUsernameExist(string username, int accid) => AccountDBContext.Instance.IsUsernameExist(username, accid);

        public IEnumerable<Account> GetAccountsNoRoom() => AccountDBContext.Instance.GetAccountsNoRoom();

        public IEnumerable<Room> GetRooms() => RoomDBContext.Instance.GetList();
        public IEnumerable<Room> GetRoomByStatus(int status) => RoomDBContext.Instance.GetListByStatus(status);
        public IEnumerable<Room> GetRoomByType(int typebed, int typeroom) => RoomDBContext.Instance.GetListByType(typebed, typeroom);
        public void InsertRoom(int type_id, int price, int type_bed, int acc_id, int room_id)
         => RoomDBContext.Instance.CreateNew(type_id, price, type_bed, acc_id, room_id);

        public void Inactive(int roomid) => RoomDBContext.Instance.Inactive(roomid);
        public void Update(int acc_id, int type_id, int price, int type_bed, int room_id) => RoomDBContext.Instance.Update( acc_id,  type_id,  price,  type_bed, room_id);
        public Room GetRoomByID(int roomid) => RoomDBContext.Instance.GetRoomByID(roomid);

    }
}
