﻿using HotelLibrary.BussinessObject;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HotelLibrary.DataAccess
{
    public class AccountDBContext : BaseDAL
    {
        private static AccountDBContext instance = null;
        private static readonly object instanceLock = new object();
        private AccountDBContext() { }

        public static AccountDBContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new AccountDBContext();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<Account> GetList(int roleID)
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select acc_id, username, password , citizen_id, phone, address, g.gender_name, DOB, r.role_name from account a " +
                "join Role r on a.role_id = r.role_id " +
                "join Gender g on a.gender = g.gender_id " +
                "where r.role_id = @roleID " +
                "order by acc_id DESC";

            var accounts = new List<Account>();
            try
            {
                var param = dataProvider.CreateParameter("@roleID", 0, roleID, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                while (dataReader.Read())
                {
                    accounts.Add(new Account
                    {
                        AccID = dataReader.GetInt32(0),
                        Username = dataReader.GetString(1),
                        Password = dataReader.GetString(2),
                        CitizenID = dataReader.GetString(3),
                        Phone = dataReader.GetString(4),
                        Address = dataReader.GetString(5),
                        Gender = dataReader.GetString(6),
                        DOB = dataReader.GetDateTime(7),
                        Role = dataReader.GetString(8)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return accounts;
        }

        public Account GetByID(int accountID)
        {
            Account acc = null;
            IDataReader dataReader = null;
            try
            {
                string SQLGet = "Select acc_id, username, password , citizen_id, phone, address, g.gender_name, DOB, r.role_name from account a " +
                "join Role r on a.role_id = r.role_id " +
                "join Gender g on a.gender = g.gender_id ";
                if (accountID == -1)
                {
                    SQLGet += " where acc_id = @accountID";
                    var param = dataProvider.CreateParameter("@accountID", 0, accountID, DbType.Int32);
                    dataReader = dataProvider.GetDataReader(SQLGet, CommandType.Text, out connection, param);
                }
                if (dataReader.Read())
                {
                    acc = new Account
                    {
                        AccID = dataReader.GetInt32(0),
                        Password = dataReader.GetString(2),
                        CitizenID = dataReader.GetString(3),
                        Phone = dataReader.GetString(4),
                        Address = dataReader.GetString(5),
                        Gender = dataReader.GetString(6),
                        DOB = dataReader.GetDateTime(7),
                        Role = dataReader.GetString(8)

                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                // Kiểm tra xem dataReader có khác null không trước khi gọi Close
                if (dataReader != null && !dataReader.IsClosed)
                {
                    dataReader.Close();
                }
                if (connection != null)
                {
                    CloseConnection();
                }
            }

            return acc;
        }


        public void CreateNew(string username, string password, string phone, string citizen, string address, int gender, DateTime dob, int role_id)
        {
            try
            {
                string SQLCreate = "INSERT INTO Account (username, password, citizen_id, phone, address, gender, DOB, role_id) " +
                           "VALUES (@username, @password, @citizen_id, @phone, @address, @gender, @DOB, @role_id)";

                var parameters = new List<SqlParameter>();
                parameters.Add(dataProvider.CreateParameter("@username", 32, username.Trim(), DbType.String));
                parameters.Add(dataProvider.CreateParameter("@password", 40, password.Trim(), DbType.String));
                parameters.Add(dataProvider.CreateParameter("@citizen_id", 0, citizen.Trim(), DbType.String));
                parameters.Add(dataProvider.CreateParameter("@phone", 11, phone.Trim(), DbType.String));
                parameters.Add(dataProvider.CreateParameter("@address", 80, address.Trim(), DbType.String));
                parameters.Add(dataProvider.CreateParameter("@gender", 0, gender, DbType.Int32));
                parameters.Add(dataProvider.CreateParameter("@DOB", 0, dob, DbType.DateTime));
                parameters.Add(dataProvider.CreateParameter("@role_id", 0, role_id, DbType.Int32));

                dataProvider.Insert(SQLCreate, CommandType.Text, parameters.ToArray());

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Update(int accid, string username, string password, string phone, string citizen, string address,
            int gender, DateTime dob, int role_id)
        {
            try
            {
                Account acc = GetByID(accid);
                if (acc != null)
                {
                    string SQLUpdate = "Update Account set username = @username,password = @password, citizen_id=@citizen_id, " +
                      "phone=@phone, address=@address, gender=@gender, DOB=@DOB, role_id = @role_id Where acc_id = @acc_id";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@username", 32, username.Trim(), DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@password", 40, password.Trim(), DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@citizen_id", 0, citizen.Trim(), DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@phone", 11, phone.Trim(), DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@address", 80, address, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@gender", 0, gender, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@DOB", 0, dob, DbType.DateTime));
                    parameters.Add(dataProvider.CreateParameter("@role_id", 0, role_id, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@acc_id", 0, accid, DbType.Int32));

                    dataProvider.Update(SQLUpdate, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The account ID does not exist");

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Remove(int accid)
        {
            try
            {
                Account acc = GetByID(accid);
                if (acc != null)
                {
                    string SQLDelete = "Delete Account where acc_id = @accid";
                    var param = dataProvider.CreateParameter("@accid", 0, accid, DbType.Int32);
                    dataProvider.Delete(SQLDelete, CommandType.Text, param);
                }
                else
                {
                    throw new Exception("The account does not exist");

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public Account Login(string username, string password)
        {
            Account acc = null;
            IDataReader dataReader = null;
            try
            {
                string SQLGet = "select acc_id, username, password , citizen_id, phone, address, g.gender_name, DOB, r.role_name from account a " +
                     "join Role r on a.role_id = r.role_id " +
                     "join Gender g on a.gender = g.gender_id " +
                     "where username = @username and password = @password ";
                var parameters = new List<SqlParameter>();
                parameters.Add(dataProvider.CreateParameter("@username", 0, username.Trim(), DbType.String));
                parameters.Add(dataProvider.CreateParameter("@password", 40, password.Trim(), DbType.String));
                dataReader = dataProvider.GetDataReader(SQLGet, CommandType.Text, out connection, parameters.ToArray());
                if (dataReader.Read())
                {
                    acc = new Account
                    {
                        AccID = dataReader.GetInt32(0),
                        Username = dataReader.GetString(1),
                        Password = dataReader.GetString(2),
                        CitizenID = dataReader.GetString(3),
                        Phone = dataReader.GetString(4),
                        Address = dataReader.GetString(5),
                        Gender = dataReader.GetString(6),
                        DOB = dataReader.GetDateTime(7),
                        Role = dataReader.GetString(8)
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving account information." + ex.Message, ex);
            }
            finally
            {
                // Kiểm tra xem dataReader có khác null không trước khi gọi Close
                if (dataReader != null && !dataReader.IsClosed)
                {
                    dataReader.Close();
                }
                if (connection != null)
                {
                    CloseConnection();
                }
            }

            return acc;
        }

        public bool IsUsernameExist(string username)
        {
            IDataReader dataReader = null;
            try
            {
                string SQLCheckExistence = "SELECT * FROM account WHERE username = @username";
                var parameters = new List<SqlParameter>();
                parameters.Add(dataProvider.CreateParameter("@username", 0, username.Trim(), DbType.String));

                dataReader = dataProvider.GetDataReader(SQLCheckExistence, CommandType.Text, out connection, parameters.ToArray());

                return dataReader.Read();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (dataReader != null && !dataReader.IsClosed)
                {
                    dataReader.Close();
                }
                CloseConnection();
            }
        }

    }

}
