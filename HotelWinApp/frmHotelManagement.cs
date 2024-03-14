using HotelLibrary.BussinessObject;
using HotelLibrary.Respository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelWinApp
{
    public partial class frmHotelManagement : Form
    {
        IRespository RoomRespository = null;

        public frmHotelManagement()
        {
            InitializeComponent();
            if (RoomRespository == null)
            {
                RoomRespository = new Repository();
            }
            var rooms = RoomRespository.GetRooms();
            DisplayRoomImages(rooms);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void DisplayRoomImages(IEnumerable<Room> rooms)
        {
            foreach (var room in rooms)
            {
                if (room.Status == 0 || room.Status == 1)
                {
                    // Tạo PictureBox cho mỗi phòng
                    PictureBox pictureBox = new PictureBox();

                    // Xác định hình ảnh dựa trên trạng thái của phòng
                    if (room.Status == 0)
                    {
                        pictureBox.Image = Properties.Resources.bed_8_64; // Thay thế bằng thuộc tính tương ứng
                    }
                    else if (room.Status == 1)
                    {
                        pictureBox.Image = Properties.Resources.bed_9_64; // Thay thế bằng thuộc tính tương ứng
                    }

                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Size = new Size(70, 63); // Đặt kích thước mới ở đây


                    // Thêm sự kiện Click để xử lý khi người dùng chọn một phòng cụ thể.
                    pictureBox.Click += (sender, e) => Room_Click(room.RoomID, room.Status);

                    // Thêm PictureBox vào FlowLayoutPanel
                    flowLayoutPanel1.Controls.Add(pictureBox);

                    // Tạo Label để hiển thị ID phòng
                    Label label = new Label();
                    label.Text = "P" + room.RoomID.ToString();
                    label.TextAlign = ContentAlignment.MiddleCenter;

                    label.Location = new Point(pictureBox.Left, pictureBox.Bottom + 10);

                    flowLayoutPanel1.Controls.Add(label);

                }
            }
        }

        private void Room_Click(int roomNumber, int status)
        {

            if (status == 1)
            {
                MessageBox.Show($" Room: {roomNumber}, being used", "Room Status");
            }
            else
            {
                MessageBox.Show($" Room: {roomNumber}, not used yet", "Room Status");
            }
            // Xử lý khi người dùng chọn một phòng cụ thể.
            //...
        }

        private void loadRoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rooms = RoomRespository.GetRooms();
            DisplayRoomImages(rooms);
        }

        private void manageAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccountDetails frmAccountDetails = new frmAccountDetails();
            frmAccountDetails.ShowDialog();
        }

        private void menuMnRoom_Click(object sender, EventArgs e)
        {
            frmAddRoom frmAddRoom = new frmAddRoom();
            frmAddRoom.ShowDialog();
        }

        private void existToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin(); 
            frmLogin.Show();
            this.Close();
        }
    }
}
