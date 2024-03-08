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
        IEnumerable<Account> GetAccounts(int roleID);
        Account GetAccountByID(int accId);
        void InsertAccount(string username, string password, string phone, string citizen, string address, int gender, DateTime dob, int role_id);
        void UpdateAccount(int accid, string username, string password, string phone, string citizen, string address, int gender, DateTime dob, int role_id);
        void DeleteAccount(int accId);

        Account Login(string username, string password);

        bool IsUsernameExist (string username);
    }
}
