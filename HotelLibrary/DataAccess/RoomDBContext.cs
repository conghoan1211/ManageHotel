using HotelLibrary.BussinessObject;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace HotelLibrary.DataAccess
{
    public class RoomDBContext : BaseDAL
    {
        private static RoomDBContext instance = null;
        private static readonly object instanceLock = new object();
        private RoomDBContext() { }

        public static RoomDBContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new RoomDBContext();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<Room> GetList()
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select room_id, t.type_id, t.type_name, r.acc_id, r.price, r.status ,b.bed_id, b.bed_name" +
                        " from Room r join TypeRoom t on r.type_id = t.type_id " +
                        "join TypeBed b on b.bed_id = r.type_bed";
            var rooms = new List<Room>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    int accIdOrdinal = 3; // Chỉ số của cột acc_id trong kết quả truy vấn
                    int? accId = dataReader.IsDBNull(accIdOrdinal) ? (int?)null : Convert.ToInt32(dataReader.GetValue(accIdOrdinal));

                    rooms.Add(new Room
                    {
                        RoomID = dataReader.GetInt32(0),
                        TypeRoom = new TypeRoom
                        {
                            Id = dataReader.GetInt32(1),
                            Name = dataReader.GetString(2),
                        },
                        AccID = accId,
                        Price = dataReader.GetInt32(4),
                        Status = dataReader.GetInt32(5),
                        TypeBed = new TypeBed
                        {
                            BedID = dataReader.GetInt32(6),
                            BedName = dataReader.GetString(7),
                        },
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
            return rooms;
        }

        public IEnumerable<Room> GetListByStatus(int status)
        {
            IDataReader dataReader = null;
            string SQLSelect = "";

            if (status != 1)
            {
                SQLSelect += "Select room_id, t.type_id, t.type_name, r.acc_id, r.price, r.status, b.bed_id, b.bed_name " +
                            " from Room r join TypeRoom t on r.type_id = t.type_id " +
                            " join TypeBed b on b.bed_id = r.type_bed " +
                            " Where r.status = " + status;
            }
            else if (status == 1)
            {
                SQLSelect += "Select room_id, t.type_id, t.type_name, r.acc_id, r.price, r.status, b.bed_id, b.bed_name, a.username " +
                            "from Room r join TypeRoom t on r.type_id = t.type_id  " +
                            "join TypeBed b on b.bed_id = r.type_bed " +
                            "join Account a on a.acc_id = r.acc_id " +
                            "Where r.status = 1";
            }

            var rooms = new List<Room>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);

                while (dataReader.Read())
                {
                    int accIdOrdinal = 3; // Chỉ số của cột acc_id trong kết quả truy vấn
                    int? accId = dataReader.IsDBNull(accIdOrdinal) ? (int?)null : Convert.ToInt32(dataReader.GetValue(accIdOrdinal));
                    Room room = new Room
                    {
                        RoomID = dataReader.GetInt32(0),
                        TypeRoom = new TypeRoom
                        {
                            Id = dataReader.GetInt32(1),
                            Name = dataReader.GetString(2),
                        },
                        AccID = accId,
                        Price = dataReader.GetInt32(4),
                        Status = dataReader.GetInt32(5),
                        TypeBed = new TypeBed
                        {
                            BedID = dataReader.GetInt32(6),
                            BedName = dataReader.GetString(7),
                        },
                        // Xác định giá trị AccName chỉ khi status = 1
                        AccName = status == 1 ? dataReader.GetString(8) : null,
                    };

                    rooms.Add(room);
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

            return rooms;
        }

        public IEnumerable<Room> GetListByType(int typebed, int typeroom)
        {
            string SQLSelect = "SELECT room_id, t.type_id, t.type_name, r.acc_id, r.price, r.status, b.bed_id, b.bed_name, a.username " +
                                "FROM Room r " +
                                "JOIN TypeRoom t ON r.type_id = t.type_id " +
                                "JOIN TypeBed b ON b.bed_id = r.type_bed " +
                                "LEFT JOIN Account a ON a.acc_id = r.acc_id ";
            if (typebed != -1 && typeroom == -1)
            {
                SQLSelect += " WHERE b.bed_id = " + typebed;
            }

            else if (typebed == -1 && typeroom != -1)
            {
                SQLSelect += " WHERE r.type_id = " + typeroom;

            }
            var rooms = new List<Room>();
            IDataReader dataReader = null;
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);

                while (dataReader.Read())
                {
                    Room room = new Room
                    {
                        RoomID = dataReader.GetInt32(0),
                        TypeRoom = new TypeRoom
                        {
                            Id = dataReader.GetInt32(1),
                            Name = dataReader.GetString(2),
                        },
                        AccID = dataReader.IsDBNull(3) ? (int?)null : dataReader.GetInt32(3),
                        Price = dataReader.GetInt32(4),
                        Status = dataReader.GetInt32(5),
                        TypeBed = new TypeBed
                        {
                            BedID = dataReader.GetInt32(6),
                            BedName = dataReader.GetString(7),
                        },
                        AccName = dataReader.IsDBNull(8) ? "Empty" : dataReader.GetString(8),
                    };

                    rooms.Add(room);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader?.Close();
                CloseConnection();
            }

            return rooms;
        }

        public Room GetRoomByID(int roomid)
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select room_id, t.type_id, t.type_name, r.acc_id, r.price, r.status ,b.bed_id, b.bed_name" +
                        " from Room r join TypeRoom t on r.type_id = t.type_id " +
                        "join TypeBed b on b.bed_id = r.type_bed " +
                        " Where room_id = " + roomid;
            Room room = null;
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    int accIdOrdinal = 3; // Chỉ số của cột acc_id trong kết quả truy vấn
                    int? accId = dataReader.IsDBNull(accIdOrdinal) ? (int?)null : Convert.ToInt32(dataReader.GetValue(accIdOrdinal));

                    room = new Room()
                    {
                        RoomID = dataReader.GetInt32(0),
                        TypeRoom = new TypeRoom
                        {
                            Id = dataReader.GetInt32(1),
                            Name = dataReader.GetString(2),
                        },
                        AccID = accId,
                        Price = dataReader.GetInt32(4),
                        Status = dataReader.GetInt32(5),
                        TypeBed = new TypeBed
                        {
                            BedID = dataReader.GetInt32(6),
                            BedName = dataReader.GetString(7),
                        },
                    };
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
            return room;
        }


        public void CreateNew(int type_id, int price, int type_bed, int acc_id, int room_id)
        {
            try
            {
                string SQLCreate = "";
                if (acc_id != -1)
                {
                    SQLCreate = "Update Room set acc_id = @acc_id, status = 1 " +
                               " Where room_id = @room_id";
                }
                else
                {
                    SQLCreate = "INSERT INTO Room ( [type_id], [status], price, [type_bed]) " +
                            "VALUES ( @type_id, 0, @price, @type_bed)";
                }
                var parameters = new List<SqlParameter>();
                if (acc_id != -1)
                {
                    parameters.Add(dataProvider.CreateParameter("@acc_id", 0, acc_id, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@room_id", 0, room_id, DbType.Int32));

                }
                parameters.Add(dataProvider.CreateParameter("@type_id", 0, type_id, DbType.Int32));
                parameters.Add(dataProvider.CreateParameter("@price", 0, price, DbType.Int32));
                parameters.Add(dataProvider.CreateParameter("@type_bed", 0, type_bed, DbType.Int32));
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

        public void Inactive(int roomid)
        {
            try
            {
                string SQLDelete = "Update Room Set status = 2 where room_id = @roomid";
                var param = dataProvider.CreateParameter("@roomid", 0, roomid, DbType.Int32);
                dataProvider.Delete(SQLDelete, CommandType.Text, param);
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

        public void Update(int acc_id, int type_id, int price, int type_bed, int room_id)
        {
            try
            {
                string SQLUpdate = "";
                if (acc_id != null)
                {
                    SQLUpdate = "Update Room set acc_id = @acc_id,type_id = @type_id, price=@price, " +
                              "type_bed=@type_bed, status = 1 Where room_id = @room_id";
                }
                else
                {
                    SQLUpdate = "Update Room set type_id = @type_id, price=@price, " +
                              "type_bed=@type_bed, status = 0  Where room_id = @room_id";
                }
                var parameters = new List<SqlParameter>();

                parameters.Add(dataProvider.CreateParameter("@type_id", 0, type_id, DbType.Int32));
                parameters.Add(dataProvider.CreateParameter("@price", 0, price, DbType.Int32));
                parameters.Add(dataProvider.CreateParameter("@type_bed", 0, type_bed, DbType.Int32));
                parameters.Add(dataProvider.CreateParameter("@room_id", 0, room_id, DbType.Int32));
                if (acc_id != null)
                {
                    parameters.Add(dataProvider.CreateParameter("@acc_id", 0, acc_id, DbType.Int32));
                }
                dataProvider.Update(SQLUpdate, CommandType.Text, parameters.ToArray());
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


    }
}
