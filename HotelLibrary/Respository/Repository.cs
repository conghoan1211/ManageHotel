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

        public IEnumerable<Account> GetAccounts(int roleID) => AccountDBContext.Instance.GetList(roleID);

        public Account Login(string username, string password) => AccountDBContext.Instance.Login(username, password);

        public void InsertAccount(string username, string password, string phone, string citizen, string address, int gender, DateTime dob, int role_id)
            => AccountDBContext.Instance.CreateNew( username,  password,  phone,  citizen,  address,  gender,  dob,  role_id);

        public void UpdateAccount(int accid, string username, string password, string phone, string citizen, string address, int gender, DateTime dob, int role_id)
        => AccountDBContext.Instance.Update( accid,  username,  password,  phone,  citizen,  address,  gender,  dob,  role_id);

        public bool IsUsernameExist (string username) => AccountDBContext.Instance.IsUsernameExist(username);
    }
}
