using HotelLibrary.BussinessObject;
using HotelLibrary.Respository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelWinApp
{
    public partial class frmAddRoom : Form
    {
        IRespository RoomRespository = null;

        public frmAddRoom()
        {
            InitializeComponent();
            if (RoomRespository == null)
            {
                RoomRespository = new Repository();
            }

            IEnumerable<Account> accsNoRoom = RoomRespository.GetAccountsNoRoom();
            cbCustomerID.DataSource = accsNoRoom;

            cbCustomerID.ValueMember = "AccID";
            cbCustomerID.DisplayMember = "Username: " + " AccID";
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoadRoom_Click(object sender, EventArgs e)
        {
            ClearText();
            LoadListRoom();
        }

        public void LoadListRoom()
        {
            var list = RoomRespository.GetRooms();
            try
            {
                dgvDataRoom.DataSource = null;
                dgvDataRoom.DataSource = list.Select(x => new
                {
                    RoomID = x.RoomID,
                    CustomerID = x.AccID.HasValue ? x.AccID.ToString() : "Empty",
                    TypeRoom = x.TypeRoom.Name,
                    TypeBed = x.TypeBed.BedName,
                    Price = x.Price,
                    Status = x.Status == 1 ? "Being used" : (x.Status == 2 ? "Inactived" : "Not used yet"),
                }).ToList();

                if (list.Count() == 0)
                {
                    ClearText();
                    btnHideRoom.Enabled = false;
                }
                else
                {
                    int total = list.Count();
                    lbTotalRoom.Text = $"Total: {total} Rooms";
                    btnHideRoom.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load List Room");
            }
        }
        private void ClearText()
        {
            cbCustomerID.Text = string.Empty;
            cbTypeBed.Text = string.Empty;
            cbTypeRoom.Text = string.Empty;
            numPrice.Text = string.Empty;
            numRoomID.Text = string.Empty;
        }
        private void cbFilterStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexSelected = cbFilterStatus.SelectedIndex;

            var list = RoomRespository.GetRoomByStatus(indexSelected);
            try
            {
                dgvDataRoom.DataSource = null;
                if (indexSelected == 0 || indexSelected == 2)
                {
                    dgvDataRoom.DataSource = list.Select(x => new
                    {
                        RoomID = x.RoomID,
                        TypeRoom = x.TypeRoom.Name,
                        TypeBed = x.TypeBed.BedName,
                        Price = x.Price,
                        Status = x.Status == 1 ? "Being used" : (x.Status == 2 ? "Inactived" : "Not used yet"),
                    }).ToList();
                }
                else if (indexSelected == 1)
                {
                    dgvDataRoom.DataSource = list.Select(x => new
                    {
                        RoomID = x.RoomID,
                        CustomerID = x.AccID.HasValue ? x.AccID.ToString() : "Empty",
                        CustomerName = x.AccName == null ? "Empty" : x.AccName.ToString(),
                        TypeRoom = x.TypeRoom.Name,
                        TypeBed = x.TypeBed.BedName,
                        Price = x.Price,
                        Status = x.Status == 1 ? "Being used" : (x.Status == 2 ? "Inactived" : "Not used yet"),
                    }).ToList();
                }
                if (list.Count() == 0)
                {
                    ClearText();
                    btnHideRoom.Enabled = false;
                }
                else
                {
                    int total = list.Count();
                    lbTotalRoom.Text = $"Total: {total} Rooms";
                    btnHideRoom.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load List Room");
            }
        }


        /*private Account GetRoomObject()
        {
            Room room = null;
            Account acc = null;
            try
            {
                room = new Room()
                {
                    RoomID = int.Parse(numRoomID.Value.ToString()),
                    AccID = cbCustomerID.SelectedIndex != null ? RoomRespository.GetAccountByID(cbCustomerID.SelectedIndex).AccID : null ,
                    AccName = cbCustomerID.SelectedIndex != null ? RoomRespository.GetAccountByID(cbCustomerID.SelectedIndex).Username : null,
                    Price = int.Parse(numPrice.Value.ToString()),
                    Status = RoomRespository.GetAccountByID(cbCustomerID.SelectedIndex) == null ? 0 : 1,
                    TypeBed = cbTypeBed.SelectedIndex,
                    TypeRoom
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Room");
            }
            return room;
        }*/

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            Room room = new Room();
            try
            {
                if (RoomRespository != null)
                {

                    int accid = cbCustomerID.SelectedIndex;
                    int type_id = cbTypeRoom.SelectedIndex + 1;
                    int price = int.Parse(numPrice.Value.ToString());
                    int bed_id = cbTypeBed.SelectedIndex + 1;
                    // Check if all necessary information is provided
                    if (accid != null && type_id != null && price > 0 && bed_id != null)
                    {
                        RoomRespository.InsertRoom(type_id, price, bed_id, -1, -1);
                        MessageBox.Show("Add Successfully");
                    }
                    else
                    {
                        MessageBox.Show("You must input full information", "Notification");
                    }
                }
                else
                {
                    // Xử lý khi AccRepository là null
                    MessageBox.Show("AccRepository is not initialized.", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Room fail");
            }
            LoadListRoom();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            Room room = new Room();
            try
            {
                if (RoomRespository != null)
                {
                    int roomid = int.Parse(numRoomID.Value.ToString());
                    int accid = cbCustomerID.SelectedIndex;
                    int type_id = cbTypeRoom.SelectedIndex + 1;
                    int price = int.Parse(numPrice.Value.ToString());
                    int bed_id = cbTypeBed.SelectedIndex + 1;

                    Room r = RoomRespository.GetRoomByID(roomid);
                    if (r != null)
                    {
                        MessageBox.Show("Cannot add Customer. Room being used.", "Notification");
                        return;
                    }
                    // Check if all necessary information is provided
                    if (accid != null && type_id != null && price > 0 && roomid > 0 && bed_id != null)
                    {
                        RoomRespository.InsertRoom(type_id, price, bed_id, accid, roomid);
                        MessageBox.Show("Add Customer Successfully", "Notification");
                    }
                    else
                    {
                        MessageBox.Show("You must input full information", "Notification");
                    }
                }
                else
                {
                    // Xử lý khi AccRepository là null
                    MessageBox.Show("AccRepository is not initialized.", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Account fail");
            }
            LoadListRoom();
        }


        private void btnHideRoom_Click(object sender, EventArgs e)
        {
            try
            {
                int roomID = int.Parse(numRoomID.Value.ToString());
                Room room = RoomRespository.GetRoomByID(roomID);
                if (room.AccID != null)
                {
                    MessageBox.Show("Cannot Inactive. Room being used", "Notification");
                    return;
                }
                if (room != null)
                {
                    RoomRespository.Inactive(roomID);
                    MessageBox.Show("Inactive Successfully", "Notification");
                    LoadListRoom();
                }
                else
                {
                    MessageBox.Show("Room is not exist.", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Account");
            }
        }

        private void dgvDataRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDataRoom.Rows.Count)
            {
                string roomid = dgvDataRoom.Rows[e.RowIndex].Cells[0].Value?.ToString();
                if (!string.IsNullOrEmpty(roomid))
                {
                    Room room = RoomRespository.GetRooms().FirstOrDefault(x => x.RoomID == int.Parse(roomid));
                    if (room != null)
                    {
                        numRoomID.Value = int.Parse(room.RoomID.ToString());
                        numPrice.Value = int.Parse(room.Price.ToString());

                        if (cbTypeBed.Items.Contains(room.TypeBed.BedID))
                        {
                            cbTypeBed.Text = room.TypeBed.BedName;
                        }

                        if (cbTypeRoom.Items.Contains(room.TypeRoom.Id))
                        {
                            cbTypeRoom.Text = room.TypeRoom.Name;
                        }

                        if (room.AccID.HasValue && cbCustomerID.Items.Contains(room.AccID.Value.ToString()))
                        {
                            cbCustomerID.Text = room.AccID.Value.ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Room not found", "Error");
                    }
                }
            }
            else
            {
                MessageBox.Show("Room ID is not valid", "Error");
            }
        }

        private void filterTypeRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int indexSelected = filterTypeRoom.SelectedIndex + 1;

                var list = RoomRespository.GetRoomByType(-1, indexSelected);
                //  var list = RoomRespository.GetRoomByStatus(indexSelected);
                dgvDataRoom.DataSource = null;
                dgvDataRoom.DataSource = list.Select(x => new
                {
                    RoomID = x.RoomID,
                    CustomerID = x.AccID.HasValue ? x.AccID.ToString() : "Empty",
                    CustomerName = x.AccName == null ? "Empty" : x.AccName.ToString(),
                    TypeRoom = x.TypeRoom.Name,
                    TypeBed = x.TypeBed.BedName,
                    Price = x.Price,
                    Status = x.Status == 1 ? "Being used" : (x.Status == 2 ? "Inactived" : "Not used yet"),

                }).ToList();
                if (list.Count() == 0)
                {
                    ClearText();
                    btnHideRoom.Enabled = false;
                }
                else
                {
                    int total = list.Count();
                    lbTotalRoom.Text = $"Total: {total} Rooms";
                    btnHideRoom.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load List Room");
            }
        }

        private void filterTypeBed_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int indexSelected = filterTypeBed.SelectedIndex + 1;

                var list = RoomRespository.GetRoomByType(indexSelected, -1);
                //  var list = RoomRespository.GetRoomByStatus(indexSelected);
                dgvDataRoom.DataSource = null;
                dgvDataRoom.DataSource = list.Select(x => new
                {
                    RoomID = x.RoomID,
                    CustomerID = x.AccID.HasValue ? x.AccID.ToString() : "Empty",
                    CustomerName = x.AccName == null ? "Empty" : x.AccName.ToString(),
                    TypeRoom = x.TypeRoom.Name,
                    TypeBed = x.TypeBed.BedName,
                    Price = x.Price,
                    Status = x.Status == 1 ? "Being used" : (x.Status == 2 ? "Inactived" : "Not used yet"),

                }).ToList();
                if (list.Count() == 0)
                {
                    ClearText();
                    btnHideRoom.Enabled = false;
                }
                else
                {
                    int total = list.Count();
                    lbTotalRoom.Text = $"Total: {total} Rooms";
                    btnHideRoom.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load List Room");
            }
        }

        private void btnSeacrhRoom_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(numRoomID.Value.ToString());

                if (id <= 0)
                {
                    MessageBox.Show("Input Account ID first!", "Search Account");
                    return;
                }

                Room room = RoomRespository.GetRoomByID(id);
                if (room == null)
                {
                    MessageBox.Show("Room ID is not exist", "Notification");
                    return;
                }

                List<Room> list = new List<Room> { room };

                // Hiển thị thông tin tìm kiếm trong DataGridView
                dgvDataRoom.DataSource = list.Select(x => new
                {
                    RoomID = x.RoomID,
                    CustomerID = x.AccID.HasValue ? x.AccID.ToString() : "Empty",
                    Username = x.AccName != null ? x.AccName : "Empty",
                    TypeRoom = x.TypeRoom.Name,
                    TypeBed = x.TypeBed.BedName,
                    Price = x.Price,
                    Status = x.Status == 1 ? "Being used" : (x.Status == 2 ? "Inactived" : "Not used yet"),
                }).ToList();

                int total = list.Count();
                lbTotalRoom.Text = $"Total: {total} record";
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Account ID format!", "Search Account");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Search Account");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int roomid = int.Parse(numRoomID.Value.ToString());
                int price = int.Parse(numPrice.Value.ToString());
                int type_id = cbTypeRoom.SelectedIndex +1 ;
                int typeBed = cbTypeBed.SelectedIndex + 1;

                Account selectedAccount = cbCustomerID.SelectedItem as Account;
                int acc_id = selectedAccount?.AccID ?? 0; // Lấy AccID, nếu null thì mặc định là 0

                Room room = RoomRespository.GetRoomByID(roomid);
                if (room == null)
                {
                    MessageBox.Show("Room is not exist", "Notification");
                    return;
                }
                if ( type_id != null && price > 0 && roomid > 0 && typeBed != null)
                {
                    RoomRespository.Update(acc_id, type_id, price, typeBed,  roomid);
                    MessageBox.Show("Update Room Successfully", "Notification");
                    LoadListRoom();
                }
                else
                {
                    MessageBox.Show("You must input full information", "Notification");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Update Room");
            }

        }
    }
}
